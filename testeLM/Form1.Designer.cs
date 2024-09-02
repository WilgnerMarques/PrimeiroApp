namespace testeLM
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
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbNasc = new MaskedTextBox();
            label6 = new Label();
            maskNac = new ComboBox();
            txtFone = new MaskedTextBox();
            groupBox1 = new GroupBox();
            cbUF = new ComboBox();
            label9 = new Label();
            txtBairro = new TextBox();
            label10 = new Label();
            txtN = new TextBox();
            label8 = new Label();
            txtEndereco = new TextBox();
            label7 = new Label();
            btnMSG = new Button();
            btnLimpar = new Button();
            btnLB = new Button();
            btnFechar = new Button();
            pictureBox1 = new PictureBox();
            lblResult = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(439, 36);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(31, 145);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 0;
            label2.Text = "Digite o nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtNome.Location = new Point(262, 138);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(756, 32);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(31, 218);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 0;
            label3.Text = "Digite seu email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtEmail.Location = new Point(262, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(756, 32);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(31, 289);
            label4.Name = "label4";
            label4.Size = new Size(183, 25);
            label4.TabIndex = 0;
            label4.Text = "Digite seu telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(31, 362);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 0;
            label5.Text = "Digite sua data Nasc:";
            // 
            // cbNasc
            // 
            cbNasc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            cbNasc.Location = new Point(262, 362);
            cbNasc.Mask = "00/00/0000";
            cbNasc.Name = "cbNasc";
            cbNasc.Size = new Size(187, 32);
            cbNasc.TabIndex = 4;
            cbNasc.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(492, 365);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 0;
            label6.Text = "Nacionalidade:";
            // 
            // maskNac
            // 
            maskNac.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            maskNac.FormattingEnabled = true;
            maskNac.Items.AddRange(new object[] { "Brasileiro", "Estrangeiro" });
            maskNac.Location = new Point(694, 362);
            maskNac.Name = "maskNac";
            maskNac.Size = new Size(198, 33);
            maskNac.TabIndex = 5;
            // 
            // txtFone
            // 
            txtFone.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtFone.Location = new Point(262, 282);
            txtFone.Mask = "(00) 99999-9999";
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(756, 32);
            txtFone.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbUF);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtN);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(31, 447);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(987, 230);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados residenciais ";
            // 
            // cbUF
            // 
            cbUF.FormattingEnabled = true;
            cbUF.Items.AddRange(new object[] { " AC", " AL", " AP ", "AM", " BA ", "CE ", "DF ", "ES", " GO", " MA ", "MT ", "MS", " MG", " PA", " PB ", "PR", " PE", " PI ", "RJ ", "RN", " RS", " RO", "RR", "SC", "SP", "SE", "TO" });
            cbUF.Location = new Point(794, 113);
            cbUF.Name = "cbUF";
            cbUF.Size = new Size(95, 25);
            cbUF.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 119);
            label9.Name = "label9";
            label9.Size = new Size(143, 19);
            label9.TabIndex = 0;
            label9.Text = "Selecione o estado :";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(231, 113);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(374, 25);
            txtBairro.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 116);
            label10.Name = "label10";
            label10.Size = new Size(125, 19);
            label10.TabIndex = 0;
            label10.Text = "Digite seu Bairro:";
            // 
            // txtN
            // 
            txtN.Location = new Point(676, 54);
            txtN.Name = "txtN";
            txtN.Size = new Size(129, 25);
            txtN.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(645, 60);
            label8.Name = "label8";
            label8.Size = new Size(25, 19);
            label8.TabIndex = 0;
            label8.Text = "N°";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(231, 54);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(374, 25);
            txtEndereco.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 57);
            label7.Name = "label7";
            label7.Size = new Size(146, 19);
            label7.TabIndex = 0;
            label7.Text = "Digite seu endereço:";
            // 
            // btnMSG
            // 
            btnMSG.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMSG.Location = new Point(52, 703);
            btnMSG.Name = "btnMSG";
            btnMSG.Size = new Size(186, 50);
            btnMSG.TabIndex = 10;
            btnMSG.Text = "Enviar Mensagem";
            btnMSG.UseVisualStyleBackColor = true;
            btnMSG.Click += btnMSG_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpar.Location = new Point(537, 703);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(206, 50);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnLB
            // 
            btnLB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLB.Location = new Point(280, 703);
            btnLB.Name = "btnLB";
            btnLB.Size = new Size(200, 50);
            btnLB.TabIndex = 11;
            btnLB.Text = "Enviar label";
            btnLB.UseVisualStyleBackColor = true;
            btnLB.Click += btnLB_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFechar.Location = new Point(802, 703);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(199, 50);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Shulioooooooooooo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1065, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(527, 847);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResult.Location = new Point(1065, 141);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(164, 25);
            lblResult.TabIndex = 0;
            lblResult.Text = "Dados recebidos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 881);
            Controls.Add(lblResult);
            Controls.Add(pictureBox1);
            Controls.Add(btnFechar);
            Controls.Add(btnLB);
            Controls.Add(btnLimpar);
            Controls.Add(btnMSG);
            Controls.Add(groupBox1);
            Controls.Add(txtFone);
            Controls.Add(maskNac);
            Controls.Add(label6);
            Controls.Add(cbNasc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projeto PIM 2024";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private MaskedTextBox cbNasc;
        private Label label6;
        private ComboBox maskNac;
        private MaskedTextBox txtFone;
        private GroupBox groupBox1;
        private TextBox txtEndereco;
        private Label label7;
        private Label label9;
        private TextBox txtBairro;
        private Label label10;
        private TextBox txtN;
        private Label label8;
        private ComboBox cbUF;
        private Button btnMSG;
        private Button btnLimpar;
        private Button btnLB;
        private Button btnFechar;
        private PictureBox pictureBox1;
        private Label lblResult;
    }
}
