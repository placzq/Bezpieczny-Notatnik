using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class WidokStart : UserControl
    {
        public WidokStart()
        {
            InitializeComponent();

            // 1. Wygląd i zaokrąglenie przycisku "Utwórz nowy notatnik"
            btnUtworz.FlatStyle = FlatStyle.Flat;
            btnUtworz.FlatAppearance.BorderSize = 0;
            ZaokraglijPrzycisk(btnUtworz);
            btnUtworz.Resize += (s, e) => ZaokraglijPrzycisk(btnUtworz);

            // 2. Wygląd i zaokrąglenie przycisku "Importuj"
            btnImportuj.FlatStyle = FlatStyle.Flat;
            btnImportuj.FlatAppearance.BorderSize = 0;
            ZaokraglijPrzycisk(btnImportuj);
            btnImportuj.Resize += (s, e) => ZaokraglijPrzycisk(btnImportuj);
        }

        // Uniwersalna metoda, która zaokrągli każdy przycisk, jaki do niej wrzucimy
        private void ZaokraglijPrzycisk(Button btn)
        {
            int d = Math.Min(btn.Height - 1, btn.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btn.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btn.Region;
            btn.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        private void btnUtworz_Click(object sender, EventArgs e)
        {
            // Przenosi do ekranu z ustawianiem hasła
            ((Form1)this.ParentForm).WczytajWidok(new WidokStartowy1());
        }

        private void btnImportuj_Click(object sender, EventArgs e)
        {
            // Przenosi do nowego ekranu importu!
            ((Form1)this.ParentForm).WczytajWidok(new Import());
        }
    }
}