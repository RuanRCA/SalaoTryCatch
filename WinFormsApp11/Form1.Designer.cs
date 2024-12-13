namespace WinFormsApp11
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
            lblCPF = new Label();
            gpbCadastro = new GroupBox();
            rbtFeminino = new RadioButton();
            rbtMasculino = new RadioButton();
            lblSexo = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            maskedTextBox3 = new MaskedTextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            maskedTextBox2 = new MaskedTextBox();
            lblRG = new Label();
            maskedTextBox1 = new MaskedTextBox();
            gpbProcedimentos = new GroupBox();
            btnAdicionar = new Button();
            chbSobrancelha = new CheckBox();
            chPedicure = new CheckBox();
            chbManicure = new CheckBox();
            chbEscova = new CheckBox();
            chbCorteSimples = new CheckBox();
            chbRestauracao = new CheckBox();
            chbTintura = new CheckBox();
            chbHidratacao = new CheckBox();
            chbCachos = new CheckBox();
            chbTerapiaCapilar = new CheckBox();
            lsbServicos = new ListBox();
            gpbCadastro.SuspendLayout();
            gpbProcedimentos.SuspendLayout();
            SuspendLayout();
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(6, 19);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 0;
            lblCPF.Text = "CPF";
            // 
            // gpbCadastro
            // 
            gpbCadastro.Controls.Add(rbtFeminino);
            gpbCadastro.Controls.Add(rbtMasculino);
            gpbCadastro.Controls.Add(lblSexo);
            gpbCadastro.Controls.Add(txtEmail);
            gpbCadastro.Controls.Add(lblEmail);
            gpbCadastro.Controls.Add(maskedTextBox3);
            gpbCadastro.Controls.Add(lblTelefone);
            gpbCadastro.Controls.Add(txtNome);
            gpbCadastro.Controls.Add(lblNome);
            gpbCadastro.Controls.Add(maskedTextBox2);
            gpbCadastro.Controls.Add(lblRG);
            gpbCadastro.Controls.Add(maskedTextBox1);
            gpbCadastro.Controls.Add(lblCPF);
            gpbCadastro.Location = new Point(12, 12);
            gpbCadastro.Name = "gpbCadastro";
            gpbCadastro.Size = new Size(203, 213);
            gpbCadastro.TabIndex = 1;
            gpbCadastro.TabStop = false;
            gpbCadastro.Text = "Cadastro";
            // 
            // rbtFeminino
            // 
            rbtFeminino.AutoSize = true;
            rbtFeminino.Location = new Point(113, 188);
            rbtFeminino.Name = "rbtFeminino";
            rbtFeminino.Size = new Size(75, 19);
            rbtFeminino.TabIndex = 12;
            rbtFeminino.TabStop = true;
            rbtFeminino.Text = "Feminino";
            rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            rbtMasculino.AutoSize = true;
            rbtMasculino.Location = new Point(12, 188);
            rbtMasculino.Name = "rbtMasculino";
            rbtMasculino.Size = new Size(80, 19);
            rbtMasculino.TabIndex = 11;
            rbtMasculino.TabStop = true;
            rbtMasculino.Text = "Masculino";
            rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(12, 170);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(63, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 138);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(63, 106);
            maskedTextBox3.Mask = "(00) 00000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(100, 23);
            maskedTextBox3.TabIndex = 7;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(6, 109);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 80);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(63, 48);
            maskedTextBox2.Mask = "00.000.000-0";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(100, 23);
            maskedTextBox2.TabIndex = 3;
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Location = new Point(12, 48);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(22, 15);
            lblRG.TabIndex = 2;
            lblRG.Text = "RG";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(63, 19);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // gpbProcedimentos
            // 
            gpbProcedimentos.Controls.Add(btnAdicionar);
            gpbProcedimentos.Controls.Add(chbSobrancelha);
            gpbProcedimentos.Controls.Add(chPedicure);
            gpbProcedimentos.Controls.Add(chbManicure);
            gpbProcedimentos.Controls.Add(chbEscova);
            gpbProcedimentos.Controls.Add(chbCorteSimples);
            gpbProcedimentos.Controls.Add(chbRestauracao);
            gpbProcedimentos.Controls.Add(chbTintura);
            gpbProcedimentos.Controls.Add(chbHidratacao);
            gpbProcedimentos.Controls.Add(chbCachos);
            gpbProcedimentos.Controls.Add(chbTerapiaCapilar);
            gpbProcedimentos.Location = new Point(24, 262);
            gpbProcedimentos.Name = "gpbProcedimentos";
            gpbProcedimentos.Size = new Size(452, 148);
            gpbProcedimentos.TabIndex = 2;
            gpbProcedimentos.TabStop = false;
            gpbProcedimentos.Text = "Procedimentos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(354, 68);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(89, 56);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // chbSobrancelha
            // 
            chbSobrancelha.AutoSize = true;
            chbSobrancelha.Location = new Point(195, 128);
            chbSobrancelha.Margin = new Padding(3, 2, 3, 2);
            chbSobrancelha.Name = "chbSobrancelha";
            chbSobrancelha.Size = new Size(91, 19);
            chbSobrancelha.TabIndex = 9;
            chbSobrancelha.Text = "Sobrancelha";
            chbSobrancelha.UseVisualStyleBackColor = true;
            // 
            // chPedicure
            // 
            chPedicure.AutoSize = true;
            chPedicure.Location = new Point(195, 102);
            chPedicure.Margin = new Padding(3, 2, 3, 2);
            chPedicure.Name = "chPedicure";
            chPedicure.Size = new Size(72, 19);
            chPedicure.TabIndex = 8;
            chPedicure.Text = "Pedicure";
            chPedicure.UseVisualStyleBackColor = true;
            // 
            // chbManicure
            // 
            chbManicure.AutoSize = true;
            chbManicure.Location = new Point(195, 80);
            chbManicure.Margin = new Padding(3, 2, 3, 2);
            chbManicure.Name = "chbManicure";
            chbManicure.Size = new Size(76, 19);
            chbManicure.TabIndex = 7;
            chbManicure.Text = "Manicure";
            chbManicure.UseVisualStyleBackColor = true;
            // 
            // chbEscova
            // 
            chbEscova.AutoSize = true;
            chbEscova.Location = new Point(195, 56);
            chbEscova.Name = "chbEscova";
            chbEscova.Size = new Size(62, 19);
            chbEscova.TabIndex = 6;
            chbEscova.Text = "Escova";
            chbEscova.UseVisualStyleBackColor = true;
            // 
            // chbCorteSimples
            // 
            chbCorteSimples.AutoSize = true;
            chbCorteSimples.Location = new Point(195, 31);
            chbCorteSimples.Name = "chbCorteSimples";
            chbCorteSimples.Size = new Size(99, 19);
            chbCorteSimples.TabIndex = 5;
            chbCorteSimples.Text = "Corte Simples";
            chbCorteSimples.UseVisualStyleBackColor = true;
            // 
            // chbRestauracao
            // 
            chbRestauracao.AutoSize = true;
            chbRestauracao.Location = new Point(7, 130);
            chbRestauracao.Name = "chbRestauracao";
            chbRestauracao.Size = new Size(164, 19);
            chbRestauracao.TabIndex = 4;
            chbRestauracao.Text = "Restauração com Creatina";
            chbRestauracao.UseVisualStyleBackColor = true;
            // 
            // chbTintura
            // 
            chbTintura.AutoSize = true;
            chbTintura.Location = new Point(6, 106);
            chbTintura.Name = "chbTintura";
            chbTintura.Size = new Size(63, 19);
            chbTintura.TabIndex = 3;
            chbTintura.Text = "Tintura";
            chbTintura.UseVisualStyleBackColor = true;
            // 
            // chbHidratacao
            // 
            chbHidratacao.AutoSize = true;
            chbHidratacao.Location = new Point(6, 81);
            chbHidratacao.Name = "chbHidratacao";
            chbHidratacao.Size = new Size(84, 19);
            chbHidratacao.TabIndex = 2;
            chbHidratacao.Text = "Hidratação";
            chbHidratacao.UseVisualStyleBackColor = true;
            // 
            // chbCachos
            // 
            chbCachos.AutoSize = true;
            chbCachos.Location = new Point(6, 56);
            chbCachos.Name = "chbCachos";
            chbCachos.Size = new Size(65, 19);
            chbCachos.TabIndex = 1;
            chbCachos.Text = "Cachos";
            chbCachos.UseVisualStyleBackColor = true;
            // 
            // chbTerapiaCapilar
            // 
            chbTerapiaCapilar.AutoSize = true;
            chbTerapiaCapilar.Location = new Point(6, 31);
            chbTerapiaCapilar.Name = "chbTerapiaCapilar";
            chbTerapiaCapilar.Size = new Size(103, 19);
            chbTerapiaCapilar.TabIndex = 0;
            chbTerapiaCapilar.Text = "Terapia Capilar";
            chbTerapiaCapilar.UseVisualStyleBackColor = true;
            // 
            // lsbServicos
            // 
            lsbServicos.FormattingEnabled = true;
            lsbServicos.ItemHeight = 15;
            lsbServicos.Location = new Point(454, 20);
            lsbServicos.Margin = new Padding(3, 2, 3, 2);
            lsbServicos.Name = "lsbServicos";
            lsbServicos.Size = new Size(269, 199);
            lsbServicos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(lsbServicos);
            Controls.Add(gpbProcedimentos);
            Controls.Add(gpbCadastro);
            Name = "Form1";
            Text = "Form1";
            gpbCadastro.ResumeLayout(false);
            gpbCadastro.PerformLayout();
            gpbProcedimentos.ResumeLayout(false);
            gpbProcedimentos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCPF;
        private GroupBox gpbCadastro;
        private RadioButton rbtFeminino;
        private RadioButton rbtMasculino;
        private Label lblSexo;
        private TextBox txtEmail;
        private Label lblEmail;
        private MaskedTextBox maskedTextBox3;
        private Label lblTelefone;
        private TextBox txtNome;
        private Label lblNome;
        private MaskedTextBox maskedTextBox2;
        private Label lblRG;
        private MaskedTextBox maskedTextBox1;
        private GroupBox gpbProcedimentos;
        private CheckBox chbEscova;
        private CheckBox chbCorteSimples;
        private CheckBox chbRestauracao;
        private CheckBox chbTintura;
        private CheckBox chbHidratacao;
        private CheckBox chbCachos;
        private CheckBox chbTerapiaCapilar;
        private CheckBox chPedicure;
        private CheckBox chbManicure;
        private CheckBox chbSobrancelha;
        private ListBox lsbServicos;
        private Button btnAdicionar;
    }
}