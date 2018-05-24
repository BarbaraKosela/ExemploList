namespace MeuGuardaRoupa
{
    partial class ListaDePeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDePeca));
            this.dgvListaPeca = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPeca
            // 
            this.dgvListaPeca.AllowUserToAddRows = false;
            this.dgvListaPeca.AllowUserToDeleteRows = false;
            this.dgvListaPeca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPeca.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvListaPeca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnCor,
            this.ColumnTipo,
            this.ColumnValor});
            this.dgvListaPeca.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListaPeca.Location = new System.Drawing.Point(12, 80);
            this.dgvListaPeca.Name = "dgvListaPeca";
            this.dgvListaPeca.ReadOnly = true;
            this.dgvListaPeca.Size = new System.Drawing.Size(667, 349);
            this.dgvListaPeca.TabIndex = 0;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnCor
            // 
            this.ColumnCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCor.HeaderText = "Cor";
            this.ColumnCor.Name = "ColumnCor";
            this.ColumnCor.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrar.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(292, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 42);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(423, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 42);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "     EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.BackColor = System.Drawing.SystemColors.Control;
            this.btnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagar.BackgroundImage")));
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApagar.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagar.Location = new System.Drawing.Point(554, 21);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(125, 42);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "      APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.BackgroundImage")));
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAtualizar.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAtualizar.Location = new System.Drawing.Point(161, 21);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 42);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "BUSCA:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 33);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(143, 20);
            this.txtBusca.TabIndex = 8;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            this.txtBusca.Leave += new System.EventHandler(this.txtBusca_Leave);
            // 
            // ListaDePeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvListaPeca);
            this.Name = "ListaDePeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista de peças do seu guarda roupa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ListaDePeca_Activated);
            this.Load += new System.EventHandler(this.ListaDePeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPeca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
    }
}

