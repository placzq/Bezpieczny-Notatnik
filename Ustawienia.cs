using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class Ustawienia : UserControl
    {
        public Ustawienia()
        {
            InitializeComponent();
        }

        // Zostawiamy puste, żeby nie popsuć Projektanta (bo już w to kliknęłaś)
        private void opis_Click(object sender, EventArgs e)
        {
        }

        // Nawigacja: powrót do ekranu głównego
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Dashboard());
            }
        }

        // Logika zmiany hasła i szyfrowania na nowo wszystkich plików
        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            if (txtStareHaslo.Text != Szyfrator.AktualneHaslo)
            {
                MessageBox.Show("Stare hasło jest niepoprawne!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNoweHaslo.Text) || txtNoweHaslo.Text != txtPowtorzHaslo.Text)
            {
                MessageBox.Show("Nowe hasła muszą być identyczne i nie mogą być puste.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string folder = "Moje_Zaszyfrowane_Notatki";
                if (Directory.Exists(folder))
                {
                    string[] pliki = Directory.GetFiles(folder, "Notatka_*.txt");

                    // Odszyfrowujemy starym hasłem i szyfrujemy nowym
                    foreach (string sciezkaPliku in pliki)
                    {
                        string staryZaszyfrowany = File.ReadAllText(sciezkaPliku);
                        string odkodowany = Szyfrator.Odszyfruj(staryZaszyfrowany, txtStareHaslo.Text);
                        string nowyZaszyfrowany = Szyfrator.Zaszyfruj(odkodowany, txtNoweHaslo.Text);
                        File.WriteAllText(sciezkaPliku, nowyZaszyfrowany);
                    }

                    // Aktualizujemy klucz główny
                    string sciezkaKlucza = Path.Combine(folder, "klucz.txt");
                    string nowyZnacznik = Szyfrator.Zaszyfruj("OtworzSezam", txtNoweHaslo.Text);
                    File.WriteAllText(sciezkaKlucza, nowyZnacznik);
                }

                Szyfrator.AktualneHaslo = txtNoweHaslo.Text;
                txtStareHaslo.Clear();
                txtNoweHaslo.Clear();
                txtPowtorzHaslo.Clear();

                MessageBox.Show("Hasło zostało pomyślnie zmienione!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zmiany hasła: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEksport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Plik tekstowy (*.txt)|*.txt";
                sfd.Title = "Wybierz gdzie zapisać swoje notatki";
                sfd.FileName = "Moje_Notatki_Backup.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendLine("=== EKSPORT Z BEZPIECZNEGO NOTATNIKA ===");
                    sb.AppendLine("Data: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm"));
                    sb.AppendLine("========================================\n");

                    string folder = "Moje_Zaszyfrowane_Notatki";
                    if (System.IO.Directory.Exists(folder))
                    {
                        string[] pliki = System.IO.Directory.GetFiles(folder, "Notatka_*.txt");
                        foreach (string sciezka in pliki)
                        {
                            try
                            {
                                string zaszyfrowane = System.IO.File.ReadAllText(sciezka);
                                string odkodowane = Szyfrator.Odszyfruj(zaszyfrowane, Szyfrator.AktualneHaslo);
                                string[] czesci = odkodowane.Split(new string[] { "---SEPARATOR---" }, StringSplitOptions.None);

                                sb.AppendLine("TYTUŁ: " + czesci[0].Trim());
                                sb.AppendLine("TREŚĆ:\n" + (czesci.Length > 1 ? czesci[1].Trim() : ""));
                                sb.AppendLine("\n--------------------------------------------------\n");
                            }
                            catch { }
                        }
                    }

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Gotowe! Notatki wyeksportowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Nawigacja: przejście do ekranu Wszystkie Notatki
        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new WszystkieNotatki());
            }
        }
    }

}