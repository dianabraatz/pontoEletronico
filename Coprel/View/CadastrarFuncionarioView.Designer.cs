namespace Coprel.View
{
    partial class CadastrarFuncionarioView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tfSenha = new System.Windows.Forms.TextBox();
            this.tfNumeroRegistro = new System.Windows.Forms.TextBox();
            this.tfNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tfCNH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tfCTPS = new System.Windows.Forms.TextBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tfConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tfDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.tfDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.tfRG = new System.Windows.Forms.MaskedTextBox();
            this.tfCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Registro ......";
            // 
            // tfSenha
            // 
            this.tfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfSenha.Location = new System.Drawing.Point(301, 448);
            this.tfSenha.Name = "tfSenha";
            this.tfSenha.Size = new System.Drawing.Size(267, 26);
            this.tfSenha.TabIndex = 1;
            this.tfSenha.UseSystemPasswordChar = true;
            this.tfSenha.TextChanged += new System.EventHandler(this.tfSenha_TextChanged);
            this.tfSenha.Leave += new System.EventHandler(this.tfSenha_Leave);
            // 
            // tfNumeroRegistro
            // 
            this.tfNumeroRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNumeroRegistro.Location = new System.Drawing.Point(301, 128);
            this.tfNumeroRegistro.Name = "tfNumeroRegistro";
            this.tfNumeroRegistro.Size = new System.Drawing.Size(267, 26);
            this.tfNumeroRegistro.TabIndex = 2;
            // 
            // tfNome
            // 
            this.tfNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfNome.Location = new System.Drawing.Point(301, 160);
            this.tfNome.Name = "tfNome";
            this.tfNome.Size = new System.Drawing.Size(267, 26);
            this.tfNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha ..........................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de Nascimento .....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data de Admissão ........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome ............................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "RG ................................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "CPF ..............................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "CNH .............................";
            // 
            // tfCNH
            // 
            this.tfCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCNH.Location = new System.Drawing.Point(301, 256);
            this.tfCNH.Name = "tfCNH";
            this.tfCNH.Size = new System.Drawing.Size(267, 26);
            this.tfCNH.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Função ........................";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Setor ...........................";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(98, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "CTPS ...........................";
            // 
            // tfCTPS
            // 
            this.tfCTPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCTPS.Location = new System.Drawing.Point(301, 352);
            this.tfCTPS.Name = "tfCTPS";
            this.tfCTPS.Size = new System.Drawing.Size(267, 26);
            this.tfCTPS.TabIndex = 22;
            // 
            // cbSetor
            // 
            this.cbSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(301, 416);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(267, 28);
            this.cbSetor.TabIndex = 24;
            // 
            // cbFuncao
            // 
            this.cbFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(301, 384);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(267, 28);
            this.cbFuncao.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(171, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Confirmar senha";
            // 
            // tfConfirmaSenha
            // 
            this.tfConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfConfirmaSenha.Location = new System.Drawing.Point(301, 480);
            this.tfConfirmaSenha.Name = "tfConfirmaSenha";
            this.tfConfirmaSenha.Size = new System.Drawing.Size(267, 26);
            this.tfConfirmaSenha.TabIndex = 27;
            this.tfConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(470, 534);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(98, 31);
            this.btnCadastrar.TabIndex = 28;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(366, 534);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 31);
            this.btnLimpar.TabIndex = 29;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(102, 534);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(98, 31);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 31);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cadastro de Funcionário";
            // 
            // tfDataNascimento
            // 
            this.tfDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfDataNascimento.Location = new System.Drawing.Point(301, 289);
            this.tfDataNascimento.Mask = "00/00/0000";
            this.tfDataNascimento.Name = "tfDataNascimento";
            this.tfDataNascimento.Size = new System.Drawing.Size(267, 26);
            this.tfDataNascimento.TabIndex = 32;
            this.tfDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // tfDataAdmissao
            // 
            this.tfDataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfDataAdmissao.Location = new System.Drawing.Point(301, 321);
            this.tfDataAdmissao.Mask = "00/00/0000";
            this.tfDataAdmissao.Name = "tfDataAdmissao";
            this.tfDataAdmissao.Size = new System.Drawing.Size(267, 26);
            this.tfDataAdmissao.TabIndex = 33;
            this.tfDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // tfRG
            // 
            this.tfRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfRG.Location = new System.Drawing.Point(301, 192);
            this.tfRG.Mask = "00000000000000";
            this.tfRG.Name = "tfRG";
            this.tfRG.Size = new System.Drawing.Size(267, 26);
            this.tfRG.TabIndex = 34;
            // 
            // tfCPF
            // 
            this.tfCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfCPF.Location = new System.Drawing.Point(301, 224);
            this.tfCPF.Mask = "000.000.000-00";
            this.tfCPF.Name = "tfCPF";
            this.tfCPF.Size = new System.Drawing.Size(267, 26);
            this.tfCPF.TabIndex = 35;
            // 
            // CadastrarFuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 599);
            this.Controls.Add(this.tfCPF);
            this.Controls.Add(this.tfRG);
            this.Controls.Add(this.tfDataAdmissao);
            this.Controls.Add(this.tfDataNascimento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tfConfirmaSenha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFuncao);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tfCTPS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tfCNH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfNome);
            this.Controls.Add(this.tfNumeroRegistro);
            this.Controls.Add(this.tfSenha);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarFuncionarioView";
            this.Text = "FuncionarioView";
            this.Load += new System.EventHandler(this.FuncionarioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tfConfirmaSenha;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tfSenha;
        public System.Windows.Forms.TextBox tfNumeroRegistro;
        public System.Windows.Forms.TextBox tfNome;
        public System.Windows.Forms.TextBox tfCNH;
        public System.Windows.Forms.TextBox tfCTPS;
        public System.Windows.Forms.ComboBox cbSetor;
        public System.Windows.Forms.ComboBox cbFuncao;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.MaskedTextBox tfDataNascimento;
        public System.Windows.Forms.MaskedTextBox tfDataAdmissao;
        public System.Windows.Forms.MaskedTextBox tfRG;
        public System.Windows.Forms.MaskedTextBox tfCPF;
    }
}