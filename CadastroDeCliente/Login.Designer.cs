namespace CadastroDeCliente
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            button1 = new Button();
            SenhaLoginTextBox = new TextBox();
            NomeLoginTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(SenhaLoginTextBox);
            panel1.Controls.Add(NomeLoginTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(242, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 579);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 67);
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
            checkBox1.Location = new Point(282, 322);
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
            label3.Location = new Point(62, 326);
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
            button1.Location = new Point(62, 371);
            button1.Name = "button1";
            button1.Size = new Size(396, 108);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SenhaLoginTextBox
            // 
            SenhaLoginTextBox.Location = new Point(62, 252);
            SenhaLoginTextBox.Name = "SenhaLoginTextBox";
            SenhaLoginTextBox.PlaceholderText = "Senha:";
            SenhaLoginTextBox.Size = new Size(396, 31);
            SenhaLoginTextBox.TabIndex = 3;
            SenhaLoginTextBox.UseSystemPasswordChar = true;
            // 
            // NomeLoginTextBox
            // 
            NomeLoginTextBox.Location = new Point(62, 173);
            NomeLoginTextBox.Name = "NomeLoginTextBox";
            NomeLoginTextBox.PlaceholderText = "Usuário:";
            NomeLoginTextBox.Size = new Size(396, 31);
            NomeLoginTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(199, 19);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(328, 9);
            label2.Name = "label2";
            label2.Size = new Size(294, 32);
            label2.TabIndex = 1;
            label2.Text = "CADASTRO DE CLIENTES\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(151, 491);
            label4.Name = "label4";
            label4.Size = new Size(209, 28);
            label4.TabIndex = 8;
            label4.Text = "Não tem uma conta?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Cyan;
            label5.Location = new Point(170, 529);
            label5.Name = "label5";
            label5.Size = new Size(161, 24);
            label5.TabIndex = 9;
            label5.Text = "Criar uma conta";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1007, 865);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label label3;
        private Button button1;
        private TextBox SenhaLoginTextBox;
        private TextBox NomeLoginTextBox;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}