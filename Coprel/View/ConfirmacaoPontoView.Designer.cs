namespace Coprel.View
{
    partial class ConfirmacaoPontoView
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
            this.hora = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.numRegistro = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(157, 59);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(97, 24);
            this.hora.TabIndex = 0;
            this.hora.Text = "HORARIO";
            this.hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hora.Click += new System.EventHandler(this.hora_Click);
            // 
            // data
            // 
            this.data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(171, 143);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(61, 24);
            this.data.TabIndex = 3;
            this.data.Text = "DATA";
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // numRegistro
            // 
            this.numRegistro.AutoSize = true;
            this.numRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRegistro.Location = new System.Drawing.Point(132, 183);
            this.numRegistro.Name = "numRegistro";
            this.numRegistro.Size = new System.Drawing.Size(154, 24);
            this.numRegistro.TabIndex = 4;
            this.numRegistro.Text = "NUM REGISTRO";
            this.numRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numRegistro.Click += new System.EventHandler(this.numRegistro_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(92, 100);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(236, 24);
            this.nome.TabIndex = 5;
            this.nome.Text = "NOME DO FUNCIONARIO";
            this.nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nome.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmacaoPontoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.numRegistro);
            this.Controls.Add(this.data);
            this.Controls.Add(this.hora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ConfirmacaoPontoView";
            this.ShowIcon = false;
            this.Text = "Confirmação de Ponto";
            this.Load += new System.EventHandler(this.PontoFuncionarioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label hora;
        public System.Windows.Forms.Label data;
        public System.Windows.Forms.Label numRegistro;
        public System.Windows.Forms.Label nome;
    }
}