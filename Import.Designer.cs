namespace Bezpieczny_Notatnik
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            btnWstecz = new PictureBox();
            btnImportujZatwierdz = new Button();
            label2 = new Label();
            txtSciezka = new Label();
            txtHasloImport = new TextBox();
            btnWybierzPlik = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnWstecz).BeginInit();
            SuspendLayout();
            // 
            // btnWstecz
            // 
            btnWstecz.Image = (Image)resources.GetObject("btnWstecz.Image");
            btnWstecz.Location = new Point(24, 27);
            btnWstecz.Name = "btnWstecz";
            btnWstecz.Size = new Size(38, 41);
            btnWstecz.SizeMode = PictureBoxSizeMode.Zoom;
            btnWstecz.TabIndex = 21;
            btnWstecz.TabStop = false;
            // 
            // btnImportujZatwierdz
            // 
            btnImportujZatwierdz.BackColor = Color.FromArgb(254, 236, 165);
            btnImportujZatwierdz.FlatAppearance.BorderSize = 0;
            btnImportujZatwierdz.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnImportujZatwierdz.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnImportujZatwierdz.FlatStyle = FlatStyle.Flat;
            btnImportujZatwierdz.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnImportujZatwierdz.ForeColor = Color.FromArgb(57, 36, 72);
            btnImportujZatwierdz.ImeMode = ImeMode.NoControl;
            btnImportujZatwierdz.Location = new Point(245, 348);
            btnImportujZatwierdz.Name = "btnImportujZatwierdz";
            btnImportujZatwierdz.Size = new Size(310, 65);
            btnImportujZatwierdz.TabIndex = 20;
            btnImportujZatwierdz.Text = "Importuj do notatnika";
            btnImportujZatwierdz.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sour Gummy Light", 13.8F);
            label2.ForeColor = Color.FromArgb(57, 36, 72);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(254, 35);
            label2.Name = "label2";
            label2.Size = new Size(292, 34);
            label2.TabIndex = 17;
            label2.Text = "Importuj istniejący notatnik";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSciezka
            // 
            txtSciezka.Font = new Font("Patrick Hand", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            txtSciezka.ForeColor = Color.FromArgb(57, 36, 72);
            txtSciezka.ImeMode = ImeMode.NoControl;
            txtSciezka.Location = new Point(60, 82);
            txtSciezka.Name = "txtSciezka";
            txtSciezka.Size = new Size(688, 31);
            txtSciezka.TabIndex = 18;
            txtSciezka.Text = "a";
            txtSciezka.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtHasloImport
            // 
            txtHasloImport.Font = new Font("Patrick Hand", 12F, FontStyle.Bold);
            txtHasloImport.ForeColor = Color.FromArgb(190, 151, 196);
            txtHasloImport.Location = new Point(275, 246);
            txtHasloImport.Name = "txtHasloImport";
            txtHasloImport.Size = new Size(251, 35);
            txtHasloImport.TabIndex = 19;
            txtHasloImport.UseSystemPasswordChar = true;
            // 
            // btnWybierzPlik
            // 
            btnWybierzPlik.BackColor = Color.FromArgb(254, 236, 165);
            btnWybierzPlik.FlatAppearance.BorderSize = 0;
            btnWybierzPlik.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnWybierzPlik.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnWybierzPlik.FlatStyle = FlatStyle.Flat;
            btnWybierzPlik.Font = new Font("Patrick Hand", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnWybierzPlik.ForeColor = Color.FromArgb(57, 36, 72);
            btnWybierzPlik.ImeMode = ImeMode.NoControl;
            btnWybierzPlik.Location = new Point(328, 131);
            btnWybierzPlik.Name = "btnWybierzPlik";
            btnWybierzPlik.Size = new Size(144, 50);
            btnWybierzPlik.TabIndex = 23;
            btnWybierzPlik.Text = "Przeglądaj...";
            btnWybierzPlik.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 36, 72);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(275, 212);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 24;
            label3.Text = "Hasło";
            // 
            // Import
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label3);
            Controls.Add(btnWybierzPlik);
            Controls.Add(btnWstecz);
            Controls.Add(btnImportujZatwierdz);
            Controls.Add(label2);
            Controls.Add(txtSciezka);
            Controls.Add(txtHasloImport);
            Name = "Import";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)btnWstecz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox btnWstecz;
        private Button btnImportujZatwierdz;
        private Label label2;
        private Label txtSciezka;
        private TextBox txtHasloImport;
        private Button btnWybierzPlik;
        private Label label3;
    }
}
