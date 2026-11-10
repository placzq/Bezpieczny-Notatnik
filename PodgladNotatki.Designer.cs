namespace Bezpieczny_Notatnik
{
    partial class PodgladNotatki
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodgladNotatki));
            btnWstecz = new PictureBox();
            btnEdytuj = new Button();
            lblTytul = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).BeginInit();
            SuspendLayout();
            // 
            // btnWstecz
            // 
            btnWstecz.Image = (Image)resources.GetObject("btnWstecz.Image");
            btnWstecz.Location = new Point(30, 20);
            btnWstecz.Name = "btnWstecz";
            btnWstecz.Size = new Size(38, 41);
            btnWstecz.SizeMode = PictureBoxSizeMode.Zoom;
            btnWstecz.TabIndex = 24;
            btnWstecz.TabStop = false;
            btnWstecz.Click += btnWstecz_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.BackColor = Color.FromArgb(254, 236, 165);
            btnEdytuj.FlatAppearance.BorderSize = 0;
            btnEdytuj.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnEdytuj.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnEdytuj.FlatStyle = FlatStyle.Flat;
            btnEdytuj.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnEdytuj.ForeColor = Color.FromArgb(57, 36, 72);
            btnEdytuj.ImeMode = ImeMode.NoControl;
            btnEdytuj.Location = new Point(314, 407);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(173, 65);
            btnEdytuj.TabIndex = 26;
            btnEdytuj.Text = "Edytuj";
            btnEdytuj.UseVisualStyleBackColor = false;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // lblTytul
            // 
            lblTytul.AutoSize = true;
            lblTytul.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            lblTytul.ForeColor = Color.FromArgb(57, 36, 72);
            lblTytul.Location = new Point(104, 13);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(114, 54);
            lblTytul.TabIndex = 27;
            lblTytul.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 252, 244);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sour Gummy Light", 13.8F);
            textBox1.ForeColor = Color.FromArgb(57, 36, 72);
            textBox1.Location = new Point(30, 85);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(740, 299);
            textBox1.TabIndex = 28;
            // 
            // PodgladNotatki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(textBox1);
            Controls.Add(lblTytul);
            Controls.Add(btnWstecz);
            Controls.Add(btnEdytuj);
            Name = "PodgladNotatki";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)btnWstecz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnWstecz;
        private Button btnEdytuj;
        private Label lblTytul;
        private TextBox textBox1;
    }
}
