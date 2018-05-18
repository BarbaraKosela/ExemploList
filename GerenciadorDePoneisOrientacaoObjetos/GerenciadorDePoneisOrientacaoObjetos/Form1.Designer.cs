namespace GerenciadorDePoneisOrientacaoObjetos
{
    partial class Form1
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
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRaca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNivelFofura = new System.Windows.Forms.TrackBar();
            this.cbCorCrista = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbVivo = new System.Windows.Forms.RadioButton();
            this.rbMorto = new System.Windows.Forms.RadioButton();
            this.cbDancarino = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLocalidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvPoneis = new System.Windows.Forms.DataGridView();
            this.ColumnApelido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbNivelFofura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoneis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELIDO:";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(101, 19);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(347, 20);
            this.txtApelido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "RAÇA:";
            // 
            // cbRaca
            // 
            this.cbRaca.FormattingEnabled = true;
            this.cbRaca.Items.AddRange(new object[] {
            "Fofo nível Estagiário",
            "Fofo nível Master",
            "Fofo nível Senior",
            "Fofo nível Pleno"});
            this.cbRaca.Location = new System.Drawing.Point(76, 59);
            this.cbRaca.Name = "cbRaca";
            this.cbRaca.Size = new System.Drawing.Size(372, 21);
            this.cbRaca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "NÍVEL DE FOFURA:";
            // 
            // tbNivelFofura
            // 
            this.tbNivelFofura.LargeChange = 3;
            this.tbNivelFofura.Location = new System.Drawing.Point(175, 98);
            this.tbNivelFofura.Maximum = 100;
            this.tbNivelFofura.Minimum = 25;
            this.tbNivelFofura.Name = "tbNivelFofura";
            this.tbNivelFofura.Size = new System.Drawing.Size(273, 45);
            this.tbNivelFofura.TabIndex = 5;
            this.tbNivelFofura.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbNivelFofura.Value = 25;
            // 
            // cbCorCrista
            // 
            this.cbCorCrista.FormattingEnabled = true;
            this.cbCorCrista.Items.AddRange(new object[] {
            "Rosê",
            "Pink",
            "Fuschia",
            "Magenta"});
            this.cbCorCrista.Location = new System.Drawing.Point(150, 135);
            this.cbCorCrista.Name = "cbCorCrista";
            this.cbCorCrista.Size = new System.Drawing.Size(298, 21);
            this.cbCorCrista.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "COR DA CRISTA:";
            // 
            // rbVivo
            // 
            this.rbVivo.AutoSize = true;
            this.rbVivo.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbVivo.Location = new System.Drawing.Point(469, 39);
            this.rbVivo.Name = "rbVivo";
            this.rbVivo.Size = new System.Drawing.Size(85, 29);
            this.rbVivo.TabIndex = 8;
            this.rbVivo.TabStop = true;
            this.rbVivo.Text = "VIVO";
            this.rbVivo.UseVisualStyleBackColor = true;
            // 
            // rbMorto
            // 
            this.rbMorto.AutoSize = true;
            this.rbMorto.Font = new System.Drawing.Font("Square721 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMorto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMorto.Location = new System.Drawing.Point(469, 78);
            this.rbMorto.Name = "rbMorto";
            this.rbMorto.Size = new System.Drawing.Size(111, 29);
            this.rbMorto.TabIndex = 9;
            this.rbMorto.TabStop = true;
            this.rbMorto.Text = "MORTO";
            this.rbMorto.UseVisualStyleBackColor = true;
            // 
            // cbDancarino
            // 
            this.cbDancarino.AutoSize = true;
            this.cbDancarino.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDancarino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbDancarino.Location = new System.Drawing.Point(469, 142);
            this.cbDancarino.Name = "cbDancarino";
            this.cbDancarino.Size = new System.Drawing.Size(122, 20);
            this.cbDancarino.TabIndex = 10;
            this.cbDancarino.Text = "DANÇARINHO";
            this.cbDancarino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "LOCALIDADE:";
            // 
            // cbLocalidade
            // 
            this.cbLocalidade.FormattingEnabled = true;
            this.cbLocalidade.Items.AddRange(new object[] {
            "Poneyslândia",
            "PoneyCity",
            "MetroPoney",
            "NovaPoney"});
            this.cbLocalidade.Location = new System.Drawing.Point(133, 175);
            this.cbLocalidade.Name = "cbLocalidade";
            this.cbLocalidade.Size = new System.Drawing.Size(315, 21);
            this.cbLocalidade.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "DESCRIÇÃO:";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(124, 214);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(324, 122);
            this.rtbDescricao.TabIndex = 14;
            this.rtbDescricao.Text = "";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DeepPink;
            this.btnCadastrar.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(280, 352);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(168, 51);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "CADASTRAR ESSA FOFURA";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvPoneis
            // 
            this.dgvPoneis.AllowUserToAddRows = false;
            this.dgvPoneis.AllowUserToDeleteRows = false;
            this.dgvPoneis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoneis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnApelido,
            this.ColumnRaca});
            this.dgvPoneis.Location = new System.Drawing.Point(597, 19);
            this.dgvPoneis.Name = "dgvPoneis";
            this.dgvPoneis.ReadOnly = true;
            this.dgvPoneis.Size = new System.Drawing.Size(385, 364);
            this.dgvPoneis.TabIndex = 16;
            // 
            // ColumnApelido
            // 
            this.ColumnApelido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnApelido.HeaderText = "Apelido";
            this.ColumnApelido.Name = "ColumnApelido";
            this.ColumnApelido.ReadOnly = true;
            // 
            // ColumnRaca
            // 
            this.ColumnRaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRaca.HeaderText = "Raça";
            this.ColumnRaca.Name = "ColumnRaca";
            this.ColumnRaca.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1010, 415);
            this.Controls.Add(this.dgvPoneis);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLocalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDancarino);
            this.Controls.Add(this.rbMorto);
            this.Controls.Add(this.rbVivo);
            this.Controls.Add(this.cbCorCrista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNivelFofura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CadastrarFofuras";
            ((System.ComponentModel.ISupportInitialize)(this.tbNivelFofura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoneis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbNivelFofura;
        private System.Windows.Forms.ComboBox cbCorCrista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbVivo;
        private System.Windows.Forms.RadioButton rbMorto;
        private System.Windows.Forms.CheckBox cbDancarino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLocalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvPoneis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApelido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRaca;
    }
}

