namespace Bezpieczny_Notatnik
{
    partial class WidokStartowy1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WidokStartowy1));
            btnUtworz = new Button();
            txtPowtorzHaslo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtHaslo = new TextBox();
            label4 = new Label();
            btnWstecz = new PictureBox();
            warning1 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).BeginInit();
            SuspendLayout();
            // 
            // btnUtworz
            // 
            btnUtworz.BackColor = Color.FromArgb(254, 236, 165);
            btnUtworz.FlatAppearance.BorderSize = 0;
            btnUtworz.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnUtworz.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnUtworz.FlatStyle = FlatStyle.Flat;
            btnUtworz.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnUtworz.ForeColor = Color.FromArgb(57, 36, 72);
            btnUtworz.ImeMode = ImeMode.NoControl;
            btnUtworz.Location = new Point(275, 293);
            btnUtworz.Name = "btnUtworz";
            btnUtworz.Size = new Size(251, 65);
            btnUtworz.TabIndex = 13;
            btnUtworz.Text = "Utwórz notatnik";
            btnUtworz.UseVisualStyleBackColor = false;
            btnUtworz.Click += btnUtworz_Click;
            // 
            // txtPowtorzHaslo
            // 
            txtPowtorzHaslo.Font = new Font("Patrick Hand", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtPowtorzHaslo.ForeColor = Color.FromArgb(190, 151, 196);
            txtPowtorzHaslo.Location = new Point(275, 226);
            txtPowtorzHaslo.Name = "txtPowtorzHaslo";
            txtPowtorzHaslo.Size = new Size(251, 35);
            txtPowtorzHaslo.TabIndex = 14;
            txtPowtorzHaslo.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sour Gummy Light", 13.8F);
            label2.ForeColor = Color.FromArgb(57, 36, 72);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(120, 35);
            label2.Name = "label2";
            label2.Size = new Size(571, 34);
            label2.TabIndex = 9;
            label2.Text = "Ustaw hasło główne, aby zabezpieczyć swoje notatki.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 36, 72);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(275, 111);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 10;
            label3.Text = "Hasło";
            // 
            // txtHaslo
            // 
            txtHaslo.Font = new Font("Patrick Hand", 12F, FontStyle.Bold);
            txtHaslo.ForeColor = Color.FromArgb(190, 151, 196);
            txtHaslo.Location = new Point(275, 145);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.Size = new Size(251, 35);
            txtHaslo.TabIndex = 12;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(57, 36, 72);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(275, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 31);
            label4.TabIndex = 11;
            label4.Text = "Powtórz hasło";
            // 
            // btnWstecz
            // 
            btnWstecz.Image = (Image)resources.GetObject("btnWstecz.Image");
            btnWstecz.Location = new Point(24, 27);
            btnWstecz.Name = "btnWstecz";
            btnWstecz.Size = new Size(38, 41);
            btnWstecz.SizeMode = PictureBoxSizeMode.Zoom;
            btnWstecz.TabIndex = 15;
            btnWstecz.TabStop = false;
            btnWstecz.Click += btnWstecz_Click;
            // 
            // warning1
            // 
            warning1.Font = new Font("Sour Gummy Light", 13.8F);
            warning1.ForeColor = Color.FromArgb(57, 36, 72);
            warning1.ImeMode = ImeMode.NoControl;
            warning1.Location = new Point(120, 402);
            warning1.Name = "warning1";
            warning1.Size = new Size(571, 77);
            warning1.TabIndex = 16;
            warning1.Text = "Brak opcji odzyskiwania hasła. Zapamiętaj je, aby nie stracić dostępu do notatek.";
            warning1.TextAlign = ContentAlignment.TopCenter;
            // 
            // WidokStartowy1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(warning1);
            Controls.Add(btnWstecz);
            Controls.Add(btnUtworz);
            Controls.Add(txtPowtorzHaslo);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtHaslo);
            Controls.Add(label4);
            Name = "WidokStartowy1";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)btnWstecz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnUtworz;
        private TextBox txtPowtorzHaslo;
        private Label label2;
        private Label label3;
        private TextBox txtHaslo;
        private Label label4;
        private PictureBox btnWstecz;
        private Label warning1;
    }
}
