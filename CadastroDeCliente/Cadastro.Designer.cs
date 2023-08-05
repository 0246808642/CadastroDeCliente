namespace CadastroDeCliente
{
    partial class CadastroTela1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            NomeBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TelefoneBox = new TextBox();
            label5 = new Label();
            CidadeBox = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            UserGv = new DataGridView();
            Procuratb = new TextBox();
            button4 = new Button();
            button5 = new Button();
            MovelBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)UserGv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 122);
            label1.Name = "label1";
            label1.Size = new Size(478, 70);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 300);
            label2.Name = "label2";
            label2.Size = new Size(99, 38);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(166, 308);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(418, 31);
            NomeBox.TabIndex = 2;
            NomeBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 226);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 363);
            label4.Name = "label4";
            label4.Size = new Size(128, 38);
            label4.TabIndex = 4;
            label4.Text = "Telefone:";
            // 
            // TelefoneBox
            // 
            TelefoneBox.Location = new Point(192, 371);
            TelefoneBox.Name = "TelefoneBox";
            TelefoneBox.Size = new Size(389, 31);
            TelefoneBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 438);
            label5.Name = "label5";
            label5.Size = new Size(108, 38);
            label5.TabIndex = 6;
            label5.Text = "Cidade:";
            // 
            // CidadeBox
            // 
            CidadeBox.Location = new Point(172, 446);
            CidadeBox.Name = "CidadeBox";
            CidadeBox.Size = new Size(409, 31);
            CidadeBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 519);
            label6.Name = "label6";
            label6.Size = new Size(99, 38);
            label6.TabIndex = 8;
            label6.Text = "Móvel:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(61, 615);
            button1.Name = "button1";
            button1.Size = new Size(115, 43);
            button1.TabIndex = 11;
            button1.Text = "Adcionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(271, 615);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 12;
            button2.Text = "Editar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(466, 615);
            button3.Name = "button3";
            button3.Size = new Size(115, 43);
            button3.TabIndex = 13;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserGv
            // 
            UserGv.AllowUserToAddRows = false;
            UserGv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserGv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            UserGv.DefaultCellStyle = dataGridViewCellStyle1;
            UserGv.EditMode = DataGridViewEditMode.EditProgrammatically;
            UserGv.Location = new Point(638, 198);
            UserGv.Name = "UserGv";
            UserGv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            UserGv.RowTemplate.Height = 33;
            UserGv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserGv.Size = new Size(911, 766);
            UserGv.TabIndex = 20;
            UserGv.CellContentClick += UserGv_CellContentClick;
            // 
            // Procuratb
            // 
            Procuratb.Location = new Point(799, 145);
            Procuratb.Name = "Procuratb";
            Procuratb.Size = new Size(413, 31);
            Procuratb.TabIndex = 17;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1241, 141);
            button4.Name = "button4";
            button4.Size = new Size(110, 38);
            button4.TabIndex = 18;
            button4.Text = "Pesquisar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(1366, 141);
            button5.Name = "button5";
            button5.Size = new Size(112, 39);
            button5.TabIndex = 19;
            button5.Text = "Atualizar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // MovelBox
            // 
            MovelBox.Location = new Point(166, 526);
            MovelBox.Name = "MovelBox";
            MovelBox.Size = new Size(409, 31);
            MovelBox.TabIndex = 20;
            // 
            // CadastroTela1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1674, 1028);
            Controls.Add(MovelBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(Procuratb);
            Controls.Add(UserGv);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(CidadeBox);
            Controls.Add(label5);
            Controls.Add(TelefoneBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(NomeBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroTela1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente ";
            Load += CadastroTela1_Load;
            ((System.ComponentModel.ISupportInitialize)UserGv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NomeBox;
        private Label label3;
        private Label label4;
        private TextBox TelefoneBox;
        private Label label5;
        private TextBox CidadeBox;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView UserGv;
        private TextBox Procuratb;
        private Button button4;
        private Button button5;
        private TextBox MovelBox;
    }
}