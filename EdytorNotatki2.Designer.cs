namespace Bezpieczny_Notatnik
{
    partial class EdytorNotatki2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdytorNotatki2));
            txtTytul = new TextBox();
            btnWstecz = new PictureBox();
            btnZapisz = new Button();
            txtTresc = new TextBox();
            btnUsun = new Button();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).BeginInit();
            SuspendLayout();
            // 
            // txtTytul
            // 
            txtTytul.BackColor = Color.FromArgb(255, 252, 244);
            txtTytul.BorderStyle = BorderStyle.None;
            txtTytul.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            txtTytul.ForeColor = Color.FromArgb(57, 36, 72);
            txtTytul.Location = new Point(104, 13);
            txtTytul.Name = "txtTytul";
            txtTytul.PlaceholderText = "Tytuł";
            txtTytul.Size = new Size(666, 55);
            txtTytul.TabIndex = 21;
            // 
            // btnWstecz
            // 
            btnWstecz.Image = (Image)resources.GetObject("btnWstecz.Image");
            btnWstecz.Location = new Point(30, 20);
            btnWstecz.Name = "btnWstecz";
            btnWstecz.Size = new Size(38, 41);
            btnWstecz.SizeMode = PictureBoxSizeMode.Zoom;
            btnWstecz.TabIndex = 20;
            btnWstecz.TabStop = false;
            btnWstecz.Click += btnZapisz_Click;
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
            btnZapisz.Location = new Point(224, 423);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(173, 65);
            btnZapisz.TabIndex = 22;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = false;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // txtTresc
            // 
            txtTresc.BackColor = Color.FromArgb(255, 252, 244);
            txtTresc.BorderStyle = BorderStyle.None;
            txtTresc.Font = new Font("Sour Gummy Light", 13.8F);
            txtTresc.ForeColor = Color.FromArgb(57, 36, 72);
            txtTresc.Location = new Point(30, 85);
            txtTresc.Multiline = true;
            txtTresc.Name = "txtTresc";
            txtTresc.PlaceholderText = "Zacznij pisać...";
            txtTresc.Size = new Size(740, 317);
            txtTresc.TabIndex = 19;
            // 
            // btnUsun
            // 
            btnUsun.BackColor = Color.FromArgb(190, 151, 196);
            btnUsun.FlatAppearance.BorderSize = 0;
            btnUsun.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnUsun.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnUsun.FlatStyle = FlatStyle.Flat;
            btnUsun.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnUsun.ForeColor = Color.FromArgb(57, 36, 72);
            btnUsun.ImeMode = ImeMode.NoControl;
            btnUsun.Location = new Point(423, 423);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(173, 65);
            btnUsun.TabIndex = 23;
            btnUsun.Text = "Usuń";
            btnUsun.UseVisualStyleBackColor = false;
            btnUsun.Click += btnUsun_Click;
            // 
            // EdytorNotatki2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnUsun);
            Controls.Add(txtTytul);
            Controls.Add(btnWstecz);
            Controls.Add(btnZapisz);
            Controls.Add(txtTresc);
            Name = "EdytorNotatki2";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)btnWstecz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTytul;
        private PictureBox btnWstecz;
        private Button btnZapisz;
        private TextBox txtTresc;
        private Button btnUsun;
    }
}
