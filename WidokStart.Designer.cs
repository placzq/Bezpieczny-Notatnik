namespace Bezpieczny_Notatnik
{
    partial class WidokStart
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
            label1 = new Label();
            btnUtworz = new Button();
            label2 = new Label();
            btnImportuj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(57, 36, 72);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(144, 67);
            label1.Name = "label1";
            label1.Size = new Size(513, 54);
            label1.TabIndex = 14;
            label1.Text = "Witaj w Bezpiecznym Notatniku!";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            btnUtworz.Location = new Point(241, 338);
            btnUtworz.Name = "btnUtworz";
            btnUtworz.Size = new Size(319, 65);
            btnUtworz.TabIndex = 17;
            btnUtworz.Text = "Utwórz nowy notatnik";
            btnUtworz.UseVisualStyleBackColor = false;
            btnUtworz.Click += btnUtworz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sour Gummy Light", 13.8F);
            label2.ForeColor = Color.FromArgb(57, 36, 72);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(219, 136);
            label2.Name = "label2";
            label2.Size = new Size(362, 34);
            label2.TabIndex = 15;
            label2.Text = "Twoje notatki szyfrowane lokalnie.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnImportuj
            // 
            btnImportuj.BackColor = Color.FromArgb(227, 203, 227);
            btnImportuj.FlatAppearance.BorderSize = 0;
            btnImportuj.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnImportuj.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnImportuj.FlatStyle = FlatStyle.Flat;
            btnImportuj.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnImportuj.ForeColor = Color.FromArgb(57, 36, 72);
            btnImportuj.ImeMode = ImeMode.NoControl;
            btnImportuj.Location = new Point(312, 228);
            btnImportuj.Name = "btnImportuj";
            btnImportuj.Size = new Size(177, 65);
            btnImportuj.TabIndex = 18;
            btnImportuj.Text = "Importuj";
            btnImportuj.UseVisualStyleBackColor = false;
            btnImportuj.Click += btnImportuj_Click;
            // 
            // WidokStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnImportuj);
            Controls.Add(label1);
            Controls.Add(btnUtworz);
            Controls.Add(label2);
            Name = "WidokStart";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUtworz;
        private Label label2;
        private Button btnImportuj;
    }
}
