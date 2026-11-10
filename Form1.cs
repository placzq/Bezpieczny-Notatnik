using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO; // WA¯NE: Dodano obs³ugê plików

namespace Bezpieczny_Notatnik
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();

            // 1. Przesuwanie okna za pomoc¹ górnego paska
            panelTitle.MouseDown += PrzesunOkno;

            // 2. Zaokr¹glenie g³ównego bia³ego panelu (który jest w Form1)
            ZaokraglijPanel();
            panel1.Resize += (s, e) => ZaokraglijPanel();

            // 3. Inteligentne uruchamianie odpowiedniego ekranu
            UruchomOdpowiedniEkran();
        }

        // --- NOWA METODA SPRAWDZAJ¥CA (Szuka folderu) ---
        private void UruchomOdpowiedniEkran()
        {
            string folderZNotatkami = "Moje_Zaszyfrowane_Notatki";

            if (Directory.Exists(folderZNotatkami))
            {
                // Folder istnieje! U¿ytkownik ma ju¿ notatnik, wiêc wo³amy ekran logowania
                WczytajWidok(new WidokLogowania());
            }
            else
            {
                // Folderu nie ma! U¿ytkownik jest tu pierwszy raz
                WczytajWidok(new WidokStart());
            }
        }

        // Metoda do ³atwego prze³¹czania ekranów wewn¹trz bia³ego panelu
        public void WczytajWidok(UserControl nowyWidok)
        {
            panel1.Controls.Clear();             // Czyœci panel ze starych rzeczy
            nowyWidok.Dock = DockStyle.Fill;     // Dopasowuje rozmiar do panelu
            panel1.Controls.Add(nowyWidok);      // Wrzuca nowy ekran do œrodka
        }

        // Zaokr¹glenie bia³ego panelu
        private void ZaokraglijPanel()
        {
            int promien = 25;
            int d = promien * 2;

            using GraphicsPath sciezka = new GraphicsPath();
            sciezka.AddArc(0, 0, d, d, 180, 90);
            sciezka.AddArc(panel1.Width - d, 0, d, d, 270, 90);
            sciezka.AddArc(panel1.Width - d, panel1.Height - d, d, d, 0, 90);
            sciezka.AddArc(0, panel1.Height - d, d, d, 90, 90);
            sciezka.CloseFigure();

            Region? staryRegion = panel1.Region;
            panel1.Region = new Region(sciezka);
            staryRegion?.Dispose();
        }

        // Metoda do przesuwania okna bez obramowania
        private void PrzesunOkno(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Zamyka ca³¹ aplikacjê
        }

        private void btnMini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}