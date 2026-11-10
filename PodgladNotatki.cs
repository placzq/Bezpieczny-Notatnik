using System;
using System.Windows.Forms;

namespace Bezpieczny_Notatnik
{
    public partial class PodgladNotatki : UserControl
    {
        private string sciezkaAktualnegoPliku;
        private string aktualnyTytul;
        private string aktualnaTresc;

        // Konstruktor odbierający dane z klikniętego kafelka
        public PodgladNotatki(string sciezka, string tytul, string tresc)
        {
            InitializeComponent();

            sciezkaAktualnegoPliku = sciezka;
            aktualnyTytul = tytul;
            aktualnaTresc = tresc;

            // Przypisanie tytułu i treści do właściwych kontrolek
            lblTytul.Text = tytul;
            textBox1.Text = tresc;

            // Zabezpieczenie przed edycją i włączenie scrollowania w dół
            textBox1.ReadOnly = true;
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        // Kliknięcie przycisku "Edytuj"
        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                // Przekazujemy dane do edytora, żeby wiedział, który plik nadpisać
                formGlowne.WczytajWidok(new EdytorNotatki2(sciezkaAktualnegoPliku, aktualnyTytul, aktualnaTresc));
            }
        }

        // Kliknięcie strzałki powrotu "<"
        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 formGlowne)
            {
                formGlowne.WczytajWidok(new WszystkieNotatki());
            }
        }
    }
}