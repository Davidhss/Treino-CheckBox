
namespace AtivCkBx
{
    partial class frmAmazon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmazon));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbxSmart = new System.Windows.Forms.CheckBox();
            this.cbxEcho = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtSmart = new System.Windows.Forms.TextBox();
            this.txtKindle = new System.Windows.Forms.TextBox();
            this.txtEcho = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.gpElet = new System.Windows.Forms.GroupBox();
            this.cbxKindle = new System.Windows.Forms.CheckBox();
            this.gpLiv = new System.Windows.Forms.GroupBox();
            this.cbxManha = new System.Windows.Forms.CheckBox();
            this.txtLago = new System.Windows.Forms.TextBox();
            this.cbxBichos = new System.Windows.Forms.CheckBox();
            this.txtManha = new System.Windows.Forms.TextBox();
            this.cbxLago = new System.Windows.Forms.CheckBox();
            this.txtBichos = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.picAmazon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpElet.SuspendLayout();
            this.gpLiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAmazon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(343, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(432, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbxSmart
            // 
            this.cbxSmart.AutoSize = true;
            this.cbxSmart.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSmart.Location = new System.Drawing.Point(7, 50);
            this.cbxSmart.Name = "cbxSmart";
            this.cbxSmart.Size = new System.Drawing.Size(158, 18);
            this.cbxSmart.TabIndex = 2;
            this.cbxSmart.Text = "Smart Lâmpada Elgin (R$):";
            this.cbxSmart.UseVisualStyleBackColor = true;
            this.cbxSmart.CheckedChanged += new System.EventHandler(this.cbxSmart_CheckedChanged);
            // 
            // cbxEcho
            // 
            this.cbxEcho.AutoSize = true;
            this.cbxEcho.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEcho.Location = new System.Drawing.Point(7, 24);
            this.cbxEcho.Name = "cbxEcho";
            this.cbxEcho.Size = new System.Drawing.Size(152, 18);
            this.cbxEcho.TabIndex = 3;
            this.cbxEcho.Text = "Echo Dot 4ª Geração (R$):";
            this.cbxEcho.UseVisualStyleBackColor = true;
            this.cbxEcho.CheckedChanged += new System.EventHandler(this.cbxEcho_CheckedChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(179, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(60, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtSmart
            // 
            this.txtSmart.Enabled = false;
            this.txtSmart.Location = new System.Drawing.Point(167, 48);
            this.txtSmart.Name = "txtSmart";
            this.txtSmart.Size = new System.Drawing.Size(60, 21);
            this.txtSmart.TabIndex = 5;
            this.txtSmart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKindle
            // 
            this.txtKindle.Enabled = false;
            this.txtKindle.Location = new System.Drawing.Point(167, 74);
            this.txtKindle.Name = "txtKindle";
            this.txtKindle.Size = new System.Drawing.Size(60, 21);
            this.txtKindle.TabIndex = 6;
            this.txtKindle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEcho
            // 
            this.txtEcho.Enabled = false;
            this.txtEcho.Location = new System.Drawing.Point(167, 22);
            this.txtEcho.Name = "txtEcho";
            this.txtEcho.Size = new System.Drawing.Size(60, 21);
            this.txtEcho.TabIndex = 7;
            this.txtEcho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Amazon Ember", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValor.Location = new System.Drawing.Point(23, 111);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(141, 17);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor do Produto (R$):";
            // 
            // gpElet
            // 
            this.gpElet.Controls.Add(this.cbxKindle);
            this.gpElet.Controls.Add(this.txtEcho);
            this.gpElet.Controls.Add(this.cbxSmart);
            this.gpElet.Controls.Add(this.txtKindle);
            this.gpElet.Controls.Add(this.cbxEcho);
            this.gpElet.Controls.Add(this.txtSmart);
            this.gpElet.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpElet.ForeColor = System.Drawing.SystemColors.Control;
            this.gpElet.Location = new System.Drawing.Point(10, 16);
            this.gpElet.Name = "gpElet";
            this.gpElet.Size = new System.Drawing.Size(233, 108);
            this.gpElet.TabIndex = 90;
            this.gpElet.TabStop = false;
            this.gpElet.Text = "Eletrônicos";
            // 
            // cbxKindle
            // 
            this.cbxKindle.AutoSize = true;
            this.cbxKindle.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKindle.Location = new System.Drawing.Point(7, 76);
            this.cbxKindle.Name = "cbxKindle";
            this.cbxKindle.Size = new System.Drawing.Size(145, 18);
            this.cbxKindle.TabIndex = 8;
            this.cbxKindle.Text = "Kindle 10ª Geração (R$):";
            this.cbxKindle.UseVisualStyleBackColor = true;
            this.cbxKindle.CheckedChanged += new System.EventHandler(this.cbxKindle_CheckedChanged);
            // 
            // gpLiv
            // 
            this.gpLiv.Controls.Add(this.cbxManha);
            this.gpLiv.Controls.Add(this.txtLago);
            this.gpLiv.Controls.Add(this.cbxBichos);
            this.gpLiv.Controls.Add(this.txtManha);
            this.gpLiv.Controls.Add(this.cbxLago);
            this.gpLiv.Controls.Add(this.txtBichos);
            this.gpLiv.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLiv.ForeColor = System.Drawing.SystemColors.Control;
            this.gpLiv.Location = new System.Drawing.Point(272, 16);
            this.gpLiv.Name = "gpLiv";
            this.gpLiv.Size = new System.Drawing.Size(233, 108);
            this.gpLiv.TabIndex = 100;
            this.gpLiv.TabStop = false;
            this.gpLiv.Text = "Livros";
            // 
            // cbxManha
            // 
            this.cbxManha.AutoSize = true;
            this.cbxManha.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxManha.Location = new System.Drawing.Point(7, 76);
            this.cbxManha.Name = "cbxManha";
            this.cbxManha.Size = new System.Drawing.Size(151, 18);
            this.cbxManha.TabIndex = 103;
            this.cbxManha.Text = "O Milagre da Manhã (R$):";
            this.cbxManha.UseVisualStyleBackColor = true;
            this.cbxManha.CheckedChanged += new System.EventHandler(this.cbxManha_CheckedChanged);
            // 
            // txtLago
            // 
            this.txtLago.Enabled = false;
            this.txtLago.Location = new System.Drawing.Point(167, 22);
            this.txtLago.Name = "txtLago";
            this.txtLago.Size = new System.Drawing.Size(60, 21);
            this.txtLago.TabIndex = 7;
            this.txtLago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxBichos
            // 
            this.cbxBichos.AutoSize = true;
            this.cbxBichos.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBichos.Location = new System.Drawing.Point(7, 50);
            this.cbxBichos.Name = "cbxBichos";
            this.cbxBichos.Size = new System.Drawing.Size(157, 18);
            this.cbxBichos.TabIndex = 102;
            this.cbxBichos.Text = "Revolução dos Bichos (R$):";
            this.cbxBichos.UseVisualStyleBackColor = true;
            this.cbxBichos.CheckedChanged += new System.EventHandler(this.cbxBichos_CheckedChanged);
            // 
            // txtManha
            // 
            this.txtManha.Enabled = false;
            this.txtManha.Location = new System.Drawing.Point(167, 74);
            this.txtManha.Name = "txtManha";
            this.txtManha.Size = new System.Drawing.Size(60, 21);
            this.txtManha.TabIndex = 6;
            this.txtManha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxLago
            // 
            this.cbxLago.AutoSize = true;
            this.cbxLago.Font = new System.Drawing.Font("Amazon Ember", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLago.Location = new System.Drawing.Point(7, 24);
            this.cbxLago.Name = "cbxLago";
            this.cbxLago.Size = new System.Drawing.Size(137, 18);
            this.cbxLago.TabIndex = 1001;
            this.cbxLago.Text = "A Garota do Lago (R$):";
            this.cbxLago.UseVisualStyleBackColor = true;
            this.cbxLago.CheckedChanged += new System.EventHandler(this.cbxLago_CheckedChanged);
            // 
            // txtBichos
            // 
            this.txtBichos.Enabled = false;
            this.txtBichos.Location = new System.Drawing.Point(167, 48);
            this.txtBichos.Name = "txtBichos";
            this.txtBichos.Size = new System.Drawing.Size(60, 21);
            this.txtBichos.TabIndex = 5;
            this.txtBichos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Amazon Ember", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(18, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Valor Total da Compra (R$):";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(179, 278);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picAmazon
            // 
            this.picAmazon.Image = ((System.Drawing.Image)(resources.GetObject("picAmazon.Image")));
            this.picAmazon.Location = new System.Drawing.Point(92, 9);
            this.picAmazon.Name = "picAmazon";
            this.picAmazon.Size = new System.Drawing.Size(337, 92);
            this.picAmazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmazon.TabIndex = 13;
            this.picAmazon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpLiv);
            this.groupBox1.Controls.Add(this.gpElet);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(11, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 133);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inclua em sua compra:";
            // 
            // frmAmazon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(543, 312);
            this.Controls.Add(this.picAmazon);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAmazon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon";
            this.Load += new System.EventHandler(this.frmAmazon_Load);
            this.gpElet.ResumeLayout(false);
            this.gpElet.PerformLayout();
            this.gpLiv.ResumeLayout(false);
            this.gpLiv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAmazon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox cbxSmart;
        private System.Windows.Forms.CheckBox cbxEcho;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtSmart;
        private System.Windows.Forms.TextBox txtKindle;
        private System.Windows.Forms.TextBox txtEcho;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.GroupBox gpElet;
        private System.Windows.Forms.CheckBox cbxKindle;
        private System.Windows.Forms.GroupBox gpLiv;
        private System.Windows.Forms.CheckBox cbxManha;
        private System.Windows.Forms.TextBox txtLago;
        private System.Windows.Forms.CheckBox cbxBichos;
        private System.Windows.Forms.TextBox txtManha;
        private System.Windows.Forms.CheckBox cbxLago;
        private System.Windows.Forms.TextBox txtBichos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox picAmazon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

