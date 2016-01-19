namespace A_minha_aplicacao
{
    partial class frmConverterChk
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
            this.lblConversao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbReal = new System.Windows.Forms.CheckBox();
            this.cbEscudoCaboVerde = new System.Windows.Forms.CheckBox();
            this.cbCoroaSueca = new System.Windows.Forms.CheckBox();
            this.cbDollar = new System.Windows.Forms.CheckBox();
            this.btnCambio = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(76, 155);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(35, 13);
            this.lblConversao.TabIndex = 9;
            this.lblConversao.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbReal);
            this.groupBox1.Controls.Add(this.cbEscudoCaboVerde);
            this.groupBox1.Controls.Add(this.cbCoroaSueca);
            this.groupBox1.Controls.Add(this.cbDollar);
            this.groupBox1.Location = new System.Drawing.Point(193, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // cbReal
            // 
            this.cbReal.AutoSize = true;
            this.cbReal.Location = new System.Drawing.Point(163, 71);
            this.cbReal.Name = "cbReal";
            this.cbReal.Size = new System.Drawing.Size(48, 17);
            this.cbReal.TabIndex = 3;
            this.cbReal.Text = "Real";
            this.cbReal.UseVisualStyleBackColor = true;
            this.cbReal.CheckedChanged += new System.EventHandler(this.cbReal_CheckedChanged);
            // 
            // cbEscudoCaboVerde
            // 
            this.cbEscudoCaboVerde.AutoSize = true;
            this.cbEscudoCaboVerde.Location = new System.Drawing.Point(163, 31);
            this.cbEscudoCaboVerde.Name = "cbEscudoCaboVerde";
            this.cbEscudoCaboVerde.Size = new System.Drawing.Size(121, 17);
            this.cbEscudoCaboVerde.TabIndex = 2;
            this.cbEscudoCaboVerde.Text = "Escudo Cabo Verde";
            this.cbEscudoCaboVerde.UseVisualStyleBackColor = true;
            this.cbEscudoCaboVerde.CheckedChanged += new System.EventHandler(this.cbEscudoCaboVerde_CheckedChanged);
            // 
            // cbCoroaSueca
            // 
            this.cbCoroaSueca.AutoSize = true;
            this.cbCoroaSueca.Location = new System.Drawing.Point(18, 71);
            this.cbCoroaSueca.Name = "cbCoroaSueca";
            this.cbCoroaSueca.Size = new System.Drawing.Size(88, 17);
            this.cbCoroaSueca.TabIndex = 1;
            this.cbCoroaSueca.Text = "Coroa Sueca";
            this.cbCoroaSueca.UseVisualStyleBackColor = true;
            this.cbCoroaSueca.CheckedChanged += new System.EventHandler(this.cbCoroaSueca_CheckedChanged);
            // 
            // cbDollar
            // 
            this.cbDollar.AutoSize = true;
            this.cbDollar.Location = new System.Drawing.Point(18, 31);
            this.cbDollar.Name = "cbDollar";
            this.cbDollar.Size = new System.Drawing.Size(53, 17);
            this.cbDollar.TabIndex = 0;
            this.cbDollar.Text = "Dollar";
            this.cbDollar.UseVisualStyleBackColor = true;
            this.cbDollar.CheckedChanged += new System.EventHandler(this.cbDollar_CheckedChanged);
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(27, 99);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(106, 23);
            this.btnCambio.TabIndex = 7;
            this.btnCambio.Text = "Cambio";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(27, 59);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // frmConverterChk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 267);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmConverterChk";
            this.Text = "frmConverterChk";
            this.Load += new System.EventHandler(this.frmConverterChk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbReal;
        private System.Windows.Forms.CheckBox cbEscudoCaboVerde;
        private System.Windows.Forms.CheckBox cbCoroaSueca;
        private System.Windows.Forms.CheckBox cbDollar;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
    }
}