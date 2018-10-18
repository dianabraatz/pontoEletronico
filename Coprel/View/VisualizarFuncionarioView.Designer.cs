namespace Coprel.View
{
    partial class VisualizarFuncionarioView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.tfBuscar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AllowUserToResizeColumns = false;
            this.tabela.AllowUserToResizeRows = false;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tabela.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle12;
            this.tabela.EnableHeadersVisualStyles = false;
            this.tabela.Location = new System.Drawing.Point(28, 185);
            this.tabela.MultiSelect = false;
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(1203, 409);
            this.tabela.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(778, 600);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 37);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 132);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Funcionários";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(1084, 151);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(147, 28);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(1084, 600);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 37);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(931, 600);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 37);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(28, 155);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(137, 25);
            this.cbFiltro.TabIndex = 7;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            this.cbFiltro.Leave += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // tfBuscar
            // 
            this.tfBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfBuscar.Location = new System.Drawing.Point(171, 156);
            this.tfBuscar.Name = "tfBuscar";
            this.tfBuscar.Size = new System.Drawing.Size(100, 25);
            this.tfBuscar.TabIndex = 8;
            this.tfBuscar.Text = "Buscar";
            this.tfBuscar.TextChanged += new System.EventHandler(this.tfBuscar_TextChanged);
            this.tfBuscar.Enter += new System.EventHandler(this.tfBuscar_Enter);
            this.tfBuscar.Leave += new System.EventHandler(this.tfBuscar_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(277, 156);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 25);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.Location = new System.Drawing.Point(358, 156);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 25);
            this.btnCancela.TabIndex = 10;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // VisualizarFuncionarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1260, 670);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.tfBuscar);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.tabela);
            this.Name = "VisualizarFuncionarioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarFuncionarioView";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnVisualizar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.ComboBox cbFiltro;
        public System.Windows.Forms.TextBox tfBuscar;
        private System.Windows.Forms.Button btnCancela;
    }
}