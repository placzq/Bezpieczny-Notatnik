using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class EdytorNotatki2 : UserControl
    {
        private string sciezkaAktualnegoPliku = "";

        public EdytorNotatki2()
        {
            InitializeComponent();
        }

        public EdytorNotatki2(string sciezkaPliku, string tytul, string tresc)
        {
            InitializeComponent();

            sciezkaAktualnegoPliku = sciezkaPliku;
            txtTytul.Text = tytul;
            txtTresc.Text = tresc;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTytul.Text))
            {
                MessageBox.Show("Notatka musi mieć tytuł!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string folder = "Moje_Zaszyfrowane_Notatki";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (string.IsNullOrEmpty(sciezkaAktualnegoPliku))
            {
                sciezkaAktualnegoPliku = Path.Combine(folder, "Notatka_" + DateTime.Now.Ticks + ".txt");
            }

            string doZaszyfrowania = txtTytul.Text.Trim() + "\n---SEPARATOR---\n" + txtTresc.Text;

            try
            {
                string zaszyfrowane = Szyfrator.Zaszyfruj(doZaszyfrowania, Szyfrator.AktualneHaslo);
                File.WriteAllText(sciezkaAktualnegoPliku, zaszyfrowane);

                if (this.ParentForm is Form1 formGlowne)
                {
                    formGlowne.WczytajWidok(new WszystkieNotatki());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd przy zapisie: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sciezkaAktualnegoPliku))
            {
                WrocDoNotatek();
                return;
            }

            DialogResult odp = MessageBox.Show("Czy na pewno chcesz usunąć tę notatkę? Tego nie da się cofnąć.", "Potwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (odp == DialogResult.Yes)
            {
                try
                {
                    if (File.Exists(sciezkaAktualnegoPliku))
                    {
                        File.Delete(sciezkaAktualnegoPliku);
                    }
                    WrocDoNotatek();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się usunąć: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WrocDoNotatek()
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new WszystkieNotatki());
            }
        }
    }
}