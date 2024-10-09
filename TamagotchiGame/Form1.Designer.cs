namespace TamagotchiGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblHambre = new Label();
            lblFelicidad = new Label();
            lblEnergia = new Label();
            btnAlimentar = new Button();
            btnJugar = new Button();
            btnDormir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(59, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 316);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblHambre
            // 
            lblHambre.AutoSize = true;
            lblHambre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHambre.Location = new Point(476, 71);
            lblHambre.Name = "lblHambre";
            lblHambre.Size = new Size(71, 21);
            lblHambre.TabIndex = 1;
            lblHambre.Text = "Hambre";
            // 
            // lblFelicidad
            // 
            lblFelicidad.AutoSize = true;
            lblFelicidad.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFelicidad.Location = new Point(476, 118);
            lblFelicidad.Name = "lblFelicidad";
            lblFelicidad.Size = new Size(79, 21);
            lblFelicidad.TabIndex = 2;
            lblFelicidad.Text = "Felicidad";
            // 
            // lblEnergia
            // 
            lblEnergia.AutoSize = true;
            lblEnergia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnergia.Location = new Point(476, 162);
            lblEnergia.Name = "lblEnergia";
            lblEnergia.Size = new Size(68, 21);
            lblEnergia.TabIndex = 3;
            lblEnergia.Text = "Energia";
            // 
            // btnAlimentar
            // 
            btnAlimentar.BackColor = Color.FromArgb(0, 0, 192);
            btnAlimentar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlimentar.ForeColor = SystemColors.ButtonHighlight;
            btnAlimentar.Location = new Point(432, 238);
            btnAlimentar.Name = "btnAlimentar";
            btnAlimentar.Size = new Size(109, 42);
            btnAlimentar.TabIndex = 4;
            btnAlimentar.Text = "Alimentar";
            btnAlimentar.UseVisualStyleBackColor = false;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.FromArgb(0, 0, 192);
            btnJugar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.ForeColor = Color.White;
            btnJugar.Location = new Point(561, 238);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(109, 42);
            btnJugar.TabIndex = 5;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = false;
            // 
            // btnDormir
            // 
            btnDormir.BackColor = Color.FromArgb(0, 0, 192);
            btnDormir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDormir.ForeColor = SystemColors.ButtonHighlight;
            btnDormir.Location = new Point(432, 305);
            btnDormir.Name = "btnDormir";
            btnDormir.Size = new Size(109, 42);
            btnDormir.TabIndex = 6;
            btnDormir.Text = "Dormir";
            btnDormir.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDormir);
            Controls.Add(btnJugar);
            Controls.Add(btnAlimentar);
            Controls.Add(lblEnergia);
            Controls.Add(lblFelicidad);
            Controls.Add(lblHambre);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHambre;
        private Label lblFelicidad;
        private Label lblEnergia;
        private Button btnAlimentar;
        private Button btnJugar;
        private Button btnDormir;
        private System.Windows.Forms.Timer timer1;
    }
}
