using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();

            // Ustawienia stylu dla przycisku "Nowa notatka"
            btnNowaNotatka.FlatStyle = FlatStyle.Flat;
            btnNowaNotatka.FlatAppearance.BorderSize = 0;
            btnNowaNotatka.Click += btnNowaNotatka_Click;

            ZaokraglijPrzycisk();
            btnNowaNotatka.Resize += (s, e) => ZaokraglijPrzycisk();
        }

        // Metoda do zaokrąglenia przycisku "Nowa notatka"
        private void ZaokraglijPrzycisk()
        {
            int d = Math.Min(btnNowaNotatka.Height - 1, btnNowaNotatka.Width - 1);
            if (d < 2) return;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 90, 180);
            sciezka.AddArc(btnNowaNotatka.Width - d - 1, 0, d, d, 270, 180);
            sciezka.CloseFigure();

            Region? staryRegion = btnNowaNotatka.Region;
            btnNowaNotatka.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        private void btnNowaNotatka_Click(object? sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new EdytorNotatki());
            }
        }

        // Przejście do Wszystkich Notatek (ikona notesu)
        private void btnNotes_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new WszystkieNotatki());
            }
        }

        // Przejście do Ustawień (ikona zębatki)
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Ustawienia());
            }
        }
    }
}