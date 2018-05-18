namespace ExemploList
{
    partial class Exemplo01
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.rtbNumeros = new System.Windows.Forms.RichTextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicaoApagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorParaApagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelecionarParaEditar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroEditar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(93, 17);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(262, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.btnCadastrar_Click);
            this.txtNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumero_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(362, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 45);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // rtbNumeros
            // 
            this.rtbNumeros.Location = new System.Drawing.Point(15, 93);
            this.rtbNumeros.Name = "rtbNumeros";
            this.rtbNumeros.Size = new System.Drawing.Size(329, 270);
            this.rtbNumeros.TabIndex = 3;
            this.rtbNumeros.Text = "";
            // 
            // btnProcessar
            // 
            this.btnProcessar.Font = new System.Drawing.Font("Square721 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessar.Location = new System.Drawing.Point(188, 370);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(156, 45);
            this.btnProcessar.TabIndex = 4;
            this.btnProcessar.Text = "PROCESSAR";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "NÚMEROS:";
            // 
            // txtPosicaoApagar
            // 
            this.txtPosicaoApagar.Location = new System.Drawing.Point(350, 110);
            this.txtPosicaoApagar.Name = "txtPosicaoApagar";
            this.txtPosicaoApagar.Size = new System.Drawing.Size(178, 20);
            this.txtPosicaoApagar.TabIndex = 7;
            this.txtPosicaoApagar.TextChanged += new System.EventHandler(this.btnProcessar_Click);
            this.txtPosicaoApagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "POSIÇÃO PARA APAGAR:";
            // 
            // txtValorParaApagar
            // 
            this.txtValorParaApagar.Location = new System.Drawing.Point(350, 171);
            this.txtValorParaApagar.Name = "txtValorParaApagar";
            this.txtValorParaApagar.Size = new System.Drawing.Size(178, 20);
            this.txtValorParaApagar.TabIndex = 9;
            this.txtValorParaApagar.TextChanged += new System.EventHandler(this.btnProcessar_Click);
            this.txtValorParaApagar.Leave += new System.EventHandler(this.txtValorParaApagar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "VALOR PARA APAGAR:";
            // 
            // cbSelecionarParaEditar
            // 
            this.cbSelecionarParaEditar.FormattingEnabled = true;
            this.cbSelecionarParaEditar.Location = new System.Drawing.Point(350, 237);
            this.cbSelecionarParaEditar.Name = "cbSelecionarParaEditar";
            this.cbSelecionarParaEditar.Size = new System.Drawing.Size(188, 21);
            this.cbSelecionarParaEditar.TabIndex = 10;
            this.cbSelecionarParaEditar.SelectedIndexChanged += new System.EventHandler(this.cbSelecionarParaEditar_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "SELECIONE PARA EDITAR:";
            // 
            // txtNumeroEditar
            // 
            this.txtNumeroEditar.Enabled = false;
            this.txtNumeroEditar.Location = new System.Drawing.Point(350, 288);
            this.txtNumeroEditar.Name = "txtNumeroEditar";
            this.txtNumeroEditar.Size = new System.Drawing.Size(188, 20);
            this.txtNumeroEditar.TabIndex = 12;
            this.txtNumeroEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroEditar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "NÚMERO:";
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 427);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSelecionarParaEditar);
            this.Controls.Add(this.txtValorParaApagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosicaoApagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.rtbNumeros);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Exemplo01";
            this.Text = "Exemplo01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.RichTextBox rtbNumeros;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicaoApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorParaApagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSelecionarParaEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroEditar;
        private System.Windows.Forms.Label label6;
    }
}