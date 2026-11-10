using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class WidokLogowania : UserControl
    {
        public WidokLogowania()
        {
            InitializeComponent();

            btnOdblokuj.Click += btnOdblokuj_Click;

            txtHaslo.PasswordChar = '•';

            btnOdblokuj.FlatStyle = FlatStyle.Flat;
            btnOdblokuj.FlatAppearance.BorderSize = 0;
            ZaokraglijPrzycisk();
            btnOdblokuj.Resize += (s, e) => ZaokraglijPrzycisk();
        }

        private void ZaokraglijPrzycisk()
        {
            int d = Math.Min(btnOdblokuj.Height - 1, btnOdblokuj.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btnOdblokuj.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btnOdblokuj.Region;
            btnOdblokuj.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        private void btnOdblokuj_Click(object sender, EventArgs e)
        {
            string wpisaneHaslo = txtHaslo.Text;

            if (string.IsNullOrWhiteSpace(wpisaneHaslo))
            {
                MessageBox.Show("Proszę wpisać hasło, aby odblokować notatnik.", "Wymagane hasło", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sciezkaKlucza = System.IO.Path.Combine("Moje_Zaszyfrowane_Notatki", "klucz.txt");

            // Sprawdzamy, czy ktoś nie usunął pliku weryfikacyjnego
            if (!System.IO.File.Exists(sciezkaKlucza))
            {
                MessageBox.Show("Błąd krytyczny: Brak pliku klucz.txt. Baza danych mogła zostać uszkodzona.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Próbujemy odszyfrować nasz tajny znacznik wpisanym hasłem
                string pobranyZnacznik = System.IO.File.ReadAllText(sciezkaKlucza);
                string odszyfrowanyTekst = Szyfrator.Odszyfruj(pobranyZnacznik, wpisaneHaslo);

                // Jeśli program odczytał słowo "OtworzSezam", hasło jest IDEALNE!
                if (odszyfrowanyTekst == "OtworzSezam")
                {
                    Szyfrator.AktualneHaslo = wpisaneHaslo; // Zapamiętujemy w RAM do zapisu notatek

                    if (this.ParentForm is Form1 formGlowne)
                    {
                        formGlowne.WczytajWidok(new Dashboard());
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawne hasło!", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                // Jeśli hasło jest zupełnie złe, algorytm wyrzuci błąd matematyczny
                MessageBox.Show("Niepoprawne hasło!", "Odmowa dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}