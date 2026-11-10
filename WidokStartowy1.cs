using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Bezpieczny_Notatnik
{
    public partial class WidokStartowy1 : UserControl
    {
        public WidokStartowy1()
        {
            InitializeComponent();

            // Ustawienie wysokości pierwszego pola "Hasło"
            txtHaslo.AutoSize = false;
            txtHaslo.Height = 45;
            txtHaslo.Width = txtPowtorzHaslo.Width; // Wyrównanie szerokości

            // Ustawienie wysokości drugiego pola "Powtórz hasło"
            txtPowtorzHaslo.AutoSize = false;
            txtPowtorzHaslo.Height = 45;

            // Zaokrąglenie TYLKO przycisku
            ZaokraglijPrzycisk();
            btnUtworz.Resize += (s, e) => ZaokraglijPrzycisk();

            // Wygląd przycisku bez obramowania
            btnUtworz.FlatStyle = FlatStyle.Flat;
            btnUtworz.FlatAppearance.BorderSize = 0;
        }

        // Zaokrąglenie przycisku
        private void ZaokraglijPrzycisk()
        {
            int d = Math.Min(btnUtworz.Height - 1, btnUtworz.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btnUtworz.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btnUtworz.Region;
            btnUtworz.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new WidokStart());
            }
        }

        private void btnUtworz_Click(object sender, EventArgs e)
        {
            string haslo = txtHaslo.Text;
            string powtorz = txtPowtorzHaslo.Text;

            if (string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Hasło nie może być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (haslo != powtorz)
            {
                MessageBox.Show("Hasła nie są identyczne. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- TWORZENIE FOLDERU ---
            string folderZNotatkami = "Moje_Zaszyfrowane_Notatki";
            if (!System.IO.Directory.Exists(folderZNotatkami))
            {
                System.IO.Directory.CreateDirectory(folderZNotatkami);
            }

            // --- TWORZYMY ZASZYFROWANY PLIK WERYFIKACYJNY (KLUCZ) ---
            string sciezkaKlucza = System.IO.Path.Combine(folderZNotatkami, "klucz.txt");
            string zaszyfrowanyZnacznik = Szyfrator.Zaszyfruj("OtworzSezam", haslo);
            System.IO.File.WriteAllText(sciezkaKlucza, zaszyfrowanyZnacznik);

            // --- ZAPAMIĘTUJEMY HASŁO W RAM NA CZAS DZIAŁANIA PROGRAMU ---
            Szyfrator.AktualneHaslo = haslo;

            // Przechodzimy do głównego widoku
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Dashboard());
            }
        }
    }
}