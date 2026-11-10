using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class WszystkieNotatki : UserControl
    {
        public WszystkieNotatki()
        {
            InitializeComponent();

            WczytajWszystkieKafelki();
        }

        private void WczytajWszystkieKafelki()
        {
            panelWszystkichNotatek.Controls.Clear();

            string folderZNotatkami = "Moje_Zaszyfrowane_Notatki";
            if (!Directory.Exists(folderZNotatkami)) return;

            string[] pliki = Directory.GetFiles(folderZNotatkami, "Notatka_*.txt");

            int szerokoscKafelka = (panelWszystkichNotatek.Width / 2) - 35;

            foreach (string sciezkaPliku in pliki)
            {
                try
                {
                    string zaszyfrowanyTekst = File.ReadAllText(sciezkaPliku);
                    string odszyfrowanyTekst = Szyfrator.Odszyfruj(zaszyfrowanyTekst, Szyfrator.AktualneHaslo);

                    string[] czesci = odszyfrowanyTekst.Split(new string[] { "---SEPARATOR---" }, StringSplitOptions.None);
                    string tytulText = czesci[0].Trim();
                    string trescText = czesci.Length > 1 ? czesci[1].Trim() : "";

                    // 1. Główny kafelek
                    Panel kafelek = new Panel();
                    kafelek.Size = new Size(szerokoscKafelka, 160);
                    kafelek.BackColor = ColorTranslator.FromHtml("#FEECA5");
                    kafelek.Margin = new Padding(10);
                    kafelek.Cursor = Cursors.Hand;

                    // Obsługa kliknięcia w cały kafelek
                    kafelek.Click += (s, e) => {
                        if (this.ParentForm is Form1 formGlowne)
                        {
                            formGlowne.WczytajWidok(new PodgladNotatki(sciezkaPliku, tytulText, trescText));
                        }
                    };

                    // 2. Tytuł (Jasny fiolet)
                    Label lblTytul = new Label();
                    lblTytul.Text = tytulText;
                    lblTytul.Font = new Font("Sour Gummy Light", 11f, FontStyle.Bold);
                    lblTytul.ForeColor = ColorTranslator.FromHtml("#BE97C4");
                    lblTytul.AutoSize = false;
                    lblTytul.Size = new Size(kafelek.Width - 30, 25);
                    lblTytul.Location = new Point(15, 15);
                    lblTytul.Cursor = Cursors.Hand;

                    // Obsługa kliknięcia w tytuł
                    lblTytul.Click += (s, e) => {
                        if (this.ParentForm is Form1 formGlowne)
                        {
                            formGlowne.WczytajWidok(new PodgladNotatki(sciezkaPliku, tytulText, trescText));
                        }
                    };
                    kafelek.Controls.Add(lblTytul);

                    // 3. Treść (Ciemny fiolet)
                    Label lblTresc = new Label();
                    lblTresc.Text = trescText;
                    lblTresc.Font = new Font("Sour Gummy Light", 13.8f, FontStyle.Regular);
                    lblTresc.ForeColor = ColorTranslator.FromHtml("#392448");
                    lblTresc.AutoSize = false;
                    lblTresc.Size = new Size(kafelek.Width - 30, kafelek.Height - lblTytul.Height - 30);
                    lblTresc.Location = new Point(15, lblTytul.Bottom + 2);
                    lblTresc.Cursor = Cursors.Hand;

                    // Obsługa kliknięcia w treść
                    lblTresc.Click += (s, e) => {
                        if (this.ParentForm is Form1 formGlowne)
                        {
                            formGlowne.WczytajWidok(new PodgladNotatki(sciezkaPliku, tytulText, trescText));
                        }
                    };
                    kafelek.Controls.Add(lblTresc);

                    ZaokraglijPanelKafelka(kafelek, 20);

                    panelWszystkichNotatek.Controls.Add(kafelek);
                }
                catch
                {
                    // Ignoruj błędy plików
                }
            }
        }

        private void ZaokraglijPanelKafelka(Panel kafelek, int promien)
        {
            int d = promien * 2;
            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 180, 90);
            sciezka.AddArc(kafelek.Width - d, 0, d, d, 270, 90);
            sciezka.AddArc(kafelek.Width - d, kafelek.Height - d, d, d, 0, 90);
            sciezka.AddArc(0, kafelek.Height - d, d, d, 90, 90);
            sciezka.CloseFigure();
            kafelek.Region = new Region(sciezka);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Dashboard());
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new Ustawienia());
            }
        }
    }
}