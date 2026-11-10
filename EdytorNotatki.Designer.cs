namespace Bezpieczny_Notatnik
{
    partial class EdytorNotatki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdytorNotatki));
            panel1 = new Panel();
            txtTytul = new TextBox();
            btnWstecz = new PictureBox();
            txtTresc = new TextBox();
            btnZapisz = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTytul);
            panel1.Controls.Add(btnWstecz);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 0;
            // 
            // txtTytul
            // 
            txtTytul.BackColor = Color.FromArgb(255, 252, 244);
            txtTytul.BorderStyle = BorderStyle.None;
            txtTytul.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            txtTytul.ForeColor = Color.FromArgb(57, 36, 72);
            txtTytul.Location = new Point(90, 12);
            txtTytul.Name = "txtTytul";
            txtTytul.PlaceholderText = "Tytuł";
            txtTytul.Size = new Size(666, 55);
            txtTytul.TabIndex = 17;
            // 
            // btnWstecz
            // 
            btnWstecz.Image = (Image)resources.GetObject("btnWstecz.Image");
            btnWstecz.Location = new Point(16, 19);
            btnWstecz.Name = "btnWstecz";
            btnWstecz.Size = new Size(38, 41);
            btnWstecz.SizeMode = PictureBoxSizeMode.Zoom;
            btnWstecz.TabIndex = 16;
            btnWstecz.TabStop = false;
            // 
            // txtTresc
            // 
            txtTresc.BackColor = Color.FromArgb(255, 252, 244);
            txtTresc.BorderStyle = BorderStyle.None;
            txtTresc.Font = new Font("Sour Gummy Light", 13.8F);
            txtTresc.ForeColor = Color.FromArgb(57, 36, 72);
            txtTresc.Location = new Point(16, 84);
            txtTresc.Multiline = true;
            txtTresc.Name = "txtTresc";
            txtTresc.PlaceholderText = "Zacznij pisać...";
            txtTresc.Size = new Size(740, 317);
            txtTresc.TabIndex = 1;
            txtTresc.TextChanged += txtTresc_TextChanged;
            // 
            // btnZapisz
            // 
            btnZapisz.BackColor = Color.FromArgb(254, 236, 165);
            btnZapisz.FlatAppearance.BorderSize = 0;
            btnZapisz.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnZapisz.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnZapisz.FlatStyle = FlatStyle.Flat;
            btnZapisz.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnZapisz.ForeColor = Color.FromArgb(57, 36, 72);
            btnZapisz.ImeMode = ImeMode.NoControl;
            btnZapisz.Location = new Point(314, 422);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(173, 65);
            btnZapisz.TabIndex = 18;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = false;
            // 
            // EdytorNotatki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnZapisz);
            Controls.Add(txtTresc);
            Controls.Add(panel1);
            Name = "EdytorNotatki";
            Size = new Size(800, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtTytul;
        private PictureBox btnWstecz;
        private TextBox txtTresc;
        private Button btnZapisz;
    }
}
