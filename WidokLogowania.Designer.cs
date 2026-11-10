namespace Bezpieczny_Notatnik
{
    partial class WidokLogowania
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
            btnOdblokuj = new Button();
            label2 = new Label();
            label3 = new Label();
            txtHaslo = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOdblokuj
            // 
            btnOdblokuj.BackColor = Color.FromArgb(254, 236, 165);
            btnOdblokuj.FlatAppearance.BorderSize = 0;
            btnOdblokuj.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnOdblokuj.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnOdblokuj.FlatStyle = FlatStyle.Flat;
            btnOdblokuj.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnOdblokuj.ForeColor = Color.FromArgb(57, 36, 72);
            btnOdblokuj.ImeMode = ImeMode.NoControl;
            btnOdblokuj.Location = new Point(314, 351);
            btnOdblokuj.Name = "btnOdblokuj";
            btnOdblokuj.Size = new Size(173, 65);
            btnOdblokuj.TabIndex = 17;
            btnOdblokuj.Text = "Odblokuj";
            btnOdblokuj.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sour Gummy Light", 13.8F);
            label2.ForeColor = Color.FromArgb(57, 36, 72);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(167, 137);
            label2.Name = "label2";
            label2.Size = new Size(467, 34);
            label2.TabIndex = 14;
            label2.Text = "Wpisz hasło, aby odblokować swoje notatki.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 36, 72);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(275, 209);
            label3.Name = "label3";
            label3.Size = new Size(66, 31);
            label3.TabIndex = 15;
            label3.Text = "Hasło";
            // 
            // txtHaslo
            // 
            txtHaslo.Font = new Font("Patrick Hand", 12F, FontStyle.Bold);
            txtHaslo.ForeColor = Color.FromArgb(190, 151, 196);
            txtHaslo.Location = new Point(275, 243);
            txtHaslo.Name = "txtHaslo";
            txtHaslo.PasswordChar = '♥';
            txtHaslo.Size = new Size(251, 35);
            txtHaslo.TabIndex = 16;
            txtHaslo.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Patrick Hand", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(57, 36, 72);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(218, 48);
            label1.Name = "label1";
            label1.Size = new Size(364, 54);
            label1.TabIndex = 18;
            label1.Text = "Witaj z powrotem! \U0001fa77";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // WidokLogowania
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label1);
            Controls.Add(btnOdblokuj);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtHaslo);
            Name = "WidokLogowania";
            Size = new Size(800, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOdblokuj;
        private Label label2;
        private Label label3;
        private TextBox txtHaslo;
        private Label label1;
    }
}
