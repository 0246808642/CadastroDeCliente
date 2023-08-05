namespace CadastroDeCliente
{
    partial class Registrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            panel1 = new Panel();
            label2 = new Label();
            ConfirmaSenhaBox = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            SenhaLoginTextBox1 = new TextBox();
            NomeLoginTextBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ConfirmaSenhaBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SenhaLoginTextBox1);
            panel1.Controls.Add(NomeLoginTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(193, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 579);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(187, 537);
            label2.Name = "label2";
            label2.Size = new Size(146, 24);
            label2.TabIndex = 11;
            label2.Text = "Voltar ao login";
            label2.Click += label2_Click;
            // 
            // ConfirmaSenhaBox
            // 
            ConfirmaSenhaBox.Location = new Point(62, 315);
            ConfirmaSenhaBox.Name = "ConfirmaSenhaBox";
            ConfirmaSenhaBox.PlaceholderText = "Confirmar Senha:";
            ConfirmaSenhaBox.Size = new Size(396, 31);
            ConfirmaSenhaBox.TabIndex = 10;
            ConfirmaSenhaBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(282, 379);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(176, 32);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar Senha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(62, 379);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 5;
            label3.Text = "Limpar";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlDark;
            button1.Location = new Point(62, 417);
            button1.Name = "button1";
            button1.Size = new Size(396, 108);
            button1.TabIndex = 4;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SenhaLoginTextBox1
            // 
            SenhaLoginTextBox1.Location = new Point(62, 248);
            SenhaLoginTextBox1.Name = "SenhaLoginTextBox1";
            SenhaLoginTextBox1.PlaceholderText = "Senha:";
            SenhaLoginTextBox1.Size = new Size(396, 31);
            SenhaLoginTextBox1.TabIndex = 3;
            SenhaLoginTextBox1.UseSystemPasswordChar = true;
            // 
            // NomeLoginTextBox1
            // 
            NomeLoginTextBox1.Location = new Point(62, 185);
            NomeLoginTextBox1.Name = "NomeLoginTextBox1";
            NomeLoginTextBox1.PlaceholderText = "Usuário:";
            NomeLoginTextBox1.Size = new Size(396, 31);
            NomeLoginTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(170, 12);
            label1.Name = "label1";
            label1.Size = new Size(145, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(905, 671);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label label3;
        private Button button1;
        private TextBox SenhaLoginTextBox1;
        private TextBox NomeLoginTextBox1;
        private Label label1;
        private TextBox ConfirmaSenhaBox;
        private Label label2;
    }
}