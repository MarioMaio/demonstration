namespace A_minha_aplicacao
{
    partial class frmConverterOpt
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCambio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDollar = new System.Windows.Forms.RadioButton();
            this.rbCoroaSueca = new System.Windows.Forms.RadioButton();
            this.rbReal = new System.Windows.Forms.RadioButton();
            this.rbEscudoCaboVerde = new System.Windows.Forms.RadioButton();
            this.lblConversao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(37, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnCambio
            // 
            this.btnCambio.Location = new System.Drawing.Point(37, 103);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(106, 23);
            this.btnCambio.TabIndex = 2;
            this.btnCambio.Text = "Cambio";
            this.btnCambio.UseVisualStyleBackColor = true;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbReal);
            this.groupBox1.Controls.Add(this.rbEscudoCaboVerde);
            this.groupBox1.Controls.Add(this.rbCoroaSueca);
            this.groupBox1.Controls.Add(this.rbDollar);
            this.groupBox1.Location = new System.Drawing.Point(203, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moeda";
            // 
            // rbDollar
            // 
            this.rbDollar.AutoSize = true;
            this.rbDollar.Location = new System.Drawing.Point(21, 20);
            this.rbDollar.Name = "rbDollar";
            this.rbDollar.Size = new System.Drawing.Size(52, 17);
            this.rbDollar.TabIndex = 0;
            this.rbDollar.TabStop = true;
            this.rbDollar.Text = "Dollar";
            this.rbDollar.UseVisualStyleBackColor = true;
            this.rbDollar.CheckedChanged += new System.EventHandler(this.rbDollar_CheckedChanged);
            // 
            // rbCoroaSueca
            // 
            this.rbCoroaSueca.AutoSize = true;
            this.rbCoroaSueca.Location = new System.Drawing.Point(21, 53);
            this.rbCoroaSueca.Name = "rbCoroaSueca";
            this.rbCoroaSueca.Size = new System.Drawing.Size(87, 17);
            this.rbCoroaSueca.TabIndex = 1;
            this.rbCoroaSueca.TabStop = true;
            this.rbCoroaSueca.Text = "Coroa Sueca";
            this.rbCoroaSueca.UseVisualStyleBackColor = true;
            this.rbCoroaSueca.CheckedChanged += new System.EventHandler(this.rbCoroaSueca_CheckedChanged);
            // 
            // rbReal
            // 
            this.rbReal.AutoSize = true;
            this.rbReal.Location = new System.Drawing.Point(157, 53);
            this.rbReal.Name = "rbReal";
            this.rbReal.Size = new System.Drawing.Size(47, 17);
            this.rbReal.TabIndex = 3;
            this.rbReal.TabStop = true;
            this.rbReal.Text = "Real";
            this.rbReal.UseVisualStyleBackColor = true;
            this.rbReal.CheckedChanged += new System.EventHandler(this.rbReal_CheckedChanged);
            // 
            // rbEscudoCaboVerde
            // 
            this.rbEscudoCaboVerde.AutoSize = true;
            this.rbEscudoCaboVerde.Location = new System.Drawing.Point(157, 20);
            this.rbEscudoCaboVerde.Name = "rbEscudoCaboVerde";
            this.rbEscudoCaboVerde.Size = new System.Drawing.Size(120, 17);
            this.rbEscudoCaboVerde.TabIndex = 2;
            this.rbEscudoCaboVerde.TabStop = true;
            this.rbEscudoCaboVerde.Text = "Escudo Cabo Verde";
            this.rbEscudoCaboVerde.UseVisualStyleBackColor = true;
            this.rbEscudoCaboVerde.CheckedChanged += new System.EventHandler(this.rbEscudoCaboVerde_CheckedChanged);
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(86, 159);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(35, 13);
            this.lblConversao.TabIndex = 4;
            this.lblConversao.Text = "label2";
            // 
            // frmConverterOpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCambio);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmConverterOpt";
            this.Text = "frmConverterOpt";
            this.Load += new System.EventHandler(this.frmConverterOpt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCambio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReal;
        private System.Windows.Forms.RadioButton rbEscudoCaboVerde;
        private System.Windows.Forms.RadioButton rbCoroaSueca;
        private System.Windows.Forms.RadioButton rbDollar;
        private System.Windows.Forms.Label lblConversao;
    }
}