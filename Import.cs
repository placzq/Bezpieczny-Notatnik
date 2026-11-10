using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class Import : UserControl
    {
        public Import()
        {
            InitializeComponent();

            // Tymi dwiema linijkami "na sztywno" łączymy przyciski z kodem:
            btnWybierzPlik.Click += btnWybierzPlik_Click;
            btnImportujZatwierdz.Click += btnImportujZatwierdz_Click;

            // Ustawienia wyglądu głównego przycisku
            btnImportujZatwierdz.FlatStyle = FlatStyle.Flat;
            btnImportujZatwierdz.FlatAppearance.BorderSize = 0;
            ZaokraglijPrzycisk();
            btnImportujZatwierdz.Resize += (s, e) => ZaokraglijPrzycisk();
        }

        // Zaokrąglanie głównego przycisku
        private void ZaokraglijPrzycisk()
        {
            int d = Math.Min(btnImportujZatwierdz.Height - 1, btnImportujZatwierdz.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btnImportujZatwierdz.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btnImportujZatwierdz.Region;
            btnImportujZatwierdz.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        // Przycisk "Przeglądaj..." do wyboru pliku
        private void btnWybierzPlik_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Wybierz plik notatnika";
                ofd.Filter = "Wszystkie pliki (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtSciezka.Text = ofd.FileName;
                }
            }
        }

        // Główny przycisk "Importuj do notatnika"
        private void btnImportujZatwierdz_Click(object sender, EventArgs e)
        {
            // Sprawdzamy też, czy tekst nie wynosi "a" (czyli czy ktoś nie użył domyślnego napisu)
            if (string.IsNullOrWhiteSpace(txtSciezka.Text) || txtSciezka.Text == "a")
            {
                MessageBox.Show("Najpierw wybierz plik do importu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHasloImport.Text))
            {
                MessageBox.Show("Podaj hasło, aby odszyfrować plik.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Plik wybrany, hasło podane! (Tu nastąpi wczytanie)", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}