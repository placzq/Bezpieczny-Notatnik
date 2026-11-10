namespace Bezpieczny_Notatnik
{
    partial class Ustawienia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ustawienia));
            menu = new Panel();
            btnSettings = new PictureBox();
            btnNotes = new PictureBox();
            btnDashboard = new PictureBox();
            opis = new Label();
            info = new Label();
            panel1 = new Panel();
            btnEksport = new Button();
            btnZmienHaslo = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPowtorzHaslo = new TextBox();
            txtNoweHaslo = new TextBox();
            txtStareHaslo = new TextBox();
            label1 = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.None;
            menu.BackColor = Color.FromArgb(249, 244, 249);
            menu.Controls.Add(btnSettings);
            menu.Controls.Add(btnNotes);
            menu.Controls.Add(btnDashboard);
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(106, 500);
            menu.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImageLayout = ImageLayout.None;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(30, 180);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(46, 50);
            btnSettings.SizeMode = PictureBoxSizeMode.Zoom;
            btnSettings.TabIndex = 2;
            btnSettings.TabStop = false;
            // 
            // btnNotes
            // 
            btnNotes.Image = (Image)resources.GetObject("btnNotes.Image");
            btnNotes.Location = new Point(30, 109);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(46, 44);
            btnNotes.SizeMode = PictureBoxSizeMode.Zoom;
            btnNotes.TabIndex = 1;
            btnNotes.TabStop = false;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.Location = new Point(30, 32);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(46, 50);
            btnDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            btnDashboard.TabIndex = 0;
            btnDashboard.TabStop = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // opis
            // 
            opis.Font = new Font("Sour Gummy Light", 13.8F);
            opis.ForeColor = Color.FromArgb(57, 36, 72);
            opis.ImeMode = ImeMode.NoControl;
            opis.Location = new Point(35, 402);
            opis.Name = "opis";
            opis.Size = new Size(600, 422);
            opis.TabIndex = 15;
            opis.Text = resources.GetString("opis.Text");
            opis.Click += opis_Click;
            // 
            // info
            // 
            info.AutoSize = true;
            info.Font = new Font("Patrick Hand", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            info.ForeColor = Color.FromArgb(57, 36, 72);
            info.ImeMode = ImeMode.NoControl;
            info.Location = new Point(38, 351);
            info.Name = "info";
            info.Size = new Size(65, 40);
            info.TabIndex = 16;
            info.Text = "Info";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnEksport);
            panel1.Controls.Add(btnZmienHaslo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPowtorzHaslo);
            panel1.Controls.Add(txtNoweHaslo);
            panel1.Controls.Add(txtStareHaslo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(info);
            panel1.Controls.Add(opis);
            panel1.Location = new Point(112, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 500);
            panel1.TabIndex = 17;
            // 
            // btnEksport
            // 
            btnEksport.BackColor = Color.FromArgb(250, 205, 236);
            btnEksport.FlatAppearance.BorderSize = 0;
            btnEksport.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnEksport.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnEksport.FlatStyle = FlatStyle.Flat;
            btnEksport.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnEksport.ForeColor = Color.FromArgb(57, 36, 72);
            btnEksport.ImeMode = ImeMode.NoControl;
            btnEksport.Location = new Point(306, 227);
            btnEksport.Name = "btnEksport";
            btnEksport.Size = new Size(264, 65);
            btnEksport.TabIndex = 25;
            btnEksport.Text = "Eksportuj notatki";
            btnEksport.UseVisualStyleBackColor = false;
            btnEksport.Click += btnEksport_Click;
            // 
            // btnZmienHaslo
            // 
            btnZmienHaslo.BackColor = Color.FromArgb(254, 236, 165);
            btnZmienHaslo.FlatAppearance.BorderSize = 0;
            btnZmienHaslo.FlatAppearance.MouseDownBackColor = Color.FromArgb(190, 151, 196);
            btnZmienHaslo.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 218, 136);
            btnZmienHaslo.FlatStyle = FlatStyle.Flat;
            btnZmienHaslo.Font = new Font("Patrick Hand", 18F, FontStyle.Bold);
            btnZmienHaslo.ForeColor = Color.FromArgb(57, 36, 72);
            btnZmienHaslo.ImeMode = ImeMode.NoControl;
            btnZmienHaslo.Location = new Point(343, 118);
            btnZmienHaslo.Name = "btnZmienHaslo";
            btnZmienHaslo.Size = new Size(191, 65);
            btnZmienHaslo.TabIndex = 24;
            btnZmienHaslo.Text = "Zmień hasło";
            btnZmienHaslo.UseVisualStyleBackColor = false;
            btnZmienHaslo.Click += btnZmienHaslo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(57, 36, 72);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(35, 227);
            label4.Name = "label4";
            label4.Size = new Size(194, 31);
            label4.TabIndex = 23;
            label4.Text = "Powtórz nowe hasło";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(57, 36, 72);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(35, 155);
            label3.Name = "label3";
            label3.Size = new Size(116, 31);
            label3.TabIndex = 22;
            label3.Text = "Nowe hasło";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Patrick Hand", 13.7999992F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(57, 36, 72);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(38, 82);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 21;
            label2.Text = "Stare hasło";
            // 
            // txtPowtorzHaslo
            // 
            txtPowtorzHaslo.ForeColor = Color.FromArgb(57, 36, 72);
            txtPowtorzHaslo.Location = new Point(35, 265);
            txtPowtorzHaslo.Name = "txtPowtorzHaslo";
            txtPowtorzHaslo.PasswordChar = '♥';
            txtPowtorzHaslo.Size = new Size(183, 27);
            txtPowtorzHaslo.TabIndex = 20;
            // 
            // txtNoweHaslo
            // 
            txtNoweHaslo.ForeColor = Color.FromArgb(57, 36, 72);
            txtNoweHaslo.Location = new Point(35, 189);
            txtNoweHaslo.Name = "txtNoweHaslo";
            txtNoweHaslo.PasswordChar = '♥';
            txtNoweHaslo.Size = new Size(183, 27);
            txtNoweHaslo.TabIndex = 19;
            // 
            // txtStareHaslo
            // 
            txtStareHaslo.ForeColor = Color.FromArgb(57, 36, 72);
            txtStareHaslo.Location = new Point(38, 118);
            txtStareHaslo.Name = "txtStareHaslo";
            txtStareHaslo.PasswordChar = '♥';
            txtStareHaslo.Size = new Size(183, 27);
            txtStareHaslo.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Patrick Hand", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.FromArgb(57, 36, 72);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(163, 40);
            label1.TabIndex = 17;
            label1.Text = "Zmień hasło";
            // 
            // Ustawienia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(menu);
            Name = "Ustawienia";
            Size = new Size(800, 500);
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDashboard).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private PictureBox btnSettings;
        private PictureBox btnNotes;
        private PictureBox btnDashboard;
        private Label opis;
        private Label info;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPowtorzHaslo;
        private TextBox txtNoweHaslo;
        private TextBox txtStareHaslo;
        private Label label1;
        private Button btnEksport;
        private Button btnZmienHaslo;
    }
}
