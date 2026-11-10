using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class EdytorNotatki : UserControl
    {
        public EdytorNotatki()
        {
            InitializeComponent();

            // Ręczne podpięcie zdarzenia dla przycisku Wstecz
            btnWstecz.Click += btnWstecz_Click;

            // Ustawienia dla przycisku Zapisz
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.FlatAppearance.BorderSize = 0;
            btnZapisz.Click += btnZapisz_Click;

            ZaokraglijPrzyciskZapisz();
            btnZapisz.Resize += (s, e) => ZaokraglijPrzyciskZapisz();
        }

        // Metoda dla przycisku WSTECZ (Wraca do Dashboardu)
        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Dashboard());
            }
        }

        // --- ZAKTUALIZOWANA METODA ZAPISZ (Teraz szyfruje!) ---
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string tytul = txtTytul.Text;
            string tresc = txtTresc.Text;

            if (string.IsNullOrWhiteSpace(tytul) || string.IsNullOrWhiteSpace(tresc))
            {
                MessageBox.Show("Tytuł i treść nie mogą być puste!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Łączymy tytuł i treść, używając specjalnego separatora
                string zawartoscDoZapisania = tytul + Environment.NewLine + "---SEPARATOR---" + Environment.NewLine + tresc;

                // 2. Szyfrujemy połączony tekst używając zapamiętanego hasła
                string zaszyfrowanyTekst = Szyfrator.Zaszyfruj(zawartoscDoZapisania, Szyfrator.AktualneHaslo);

                // 3. Generujemy unikalną nazwę pliku z datą i czasem
                string nazwaPliku = "Notatka_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string sciezkaDoZapisu = System.IO.Path.Combine("Moje_Zaszyfrowane_Notatki", nazwaPliku);

                // 4. Zapisujemy w naszym folderze-skarbczyku
                System.IO.File.WriteAllText(sciezkaDoZapisu, zaszyfrowanyTekst);

                // Powrót do menu głównego po udanym zapisie
                if (this.ParentForm is Form1 formGlowne)
                {
                    formGlowne.WczytajWidok(new Dashboard());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas zapisywania: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metoda zaokrąglająca przycisk Zapisz
        private void ZaokraglijPrzyciskZapisz()
        {
            int d = Math.Min(btnZapisz.Height - 1, btnZapisz.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btnZapisz.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btnZapisz.Region;
            btnZapisz.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        private void txtTresc_TextChanged(object sender, EventArgs e)
        {
            // Zostawiamy puste, aby zapobiec błędowi CS0103
        }
    }
}