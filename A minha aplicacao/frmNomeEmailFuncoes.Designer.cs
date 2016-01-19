namespace A_minha_aplicacao
{
    partial class frmNomeEmailFuncoes
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultadoEmail2 = new System.Windows.Forms.Label();
            this.lblResultadoEmail1 = new System.Windows.Forms.Label();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSemEspacos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(187, 272);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultadoEmail2
            // 
            this.lblResultadoEmail2.AutoSize = true;
            this.lblResultadoEmail2.Location = new System.Drawing.Point(115, 189);
            this.lblResultadoEmail2.Name = "lblResultadoEmail2";
            this.lblResultadoEmail2.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoEmail2.TabIndex = 18;
            this.lblResultadoEmail2.Text = "label7";
            // 
            // lblResultadoEmail1
            // 
            this.lblResultadoEmail1.AutoSize = true;
            this.lblResultadoEmail1.Location = new System.Drawing.Point(115, 149);
            this.lblResultadoEmail1.Name = "lblResultadoEmail1";
            this.lblResultadoEmail1.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoEmail1.TabIndex = 17;
            this.lblResultadoEmail1.Text = "label6";
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Location = new System.Drawing.Point(115, 109);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(93, 13);
            this.lblResultadoNome.TabIndex = 16;
            this.lblResultadoNome.Text = "lblResultadoNome";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(33, 189);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(44, 13);
            this.lblEmail2.TabIndex = 15;
            this.lblEmail2.Text = "Email 2:";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(33, 149);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(44, 13);
            this.lblEmail1.TabIndex = 14;
            this.lblEmail1.Text = "Email 1:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 109);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(187, 57);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 12;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(118, 20);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(296, 20);
            this.txtNomeCompleto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome Completo";
            // 
            // lblSemEspacos
            // 
            this.lblSemEspacos.AutoSize = true;
            this.lblSemEspacos.Location = new System.Drawing.Point(33, 231);
            this.lblSemEspacos.Name = "lblSemEspacos";
            this.lblSemEspacos.Size = new System.Drawing.Size(35, 13);
            this.lblSemEspacos.TabIndex = 20;
            this.lblSemEspacos.Text = "label2";
            // 
            // frmNomeEmailFuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 307);
            this.Controls.Add(this.lblSemEspacos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultadoEmail2);
            this.Controls.Add(this.lblResultadoEmail1);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.lblEmail2);
            this.Controls.Add(this.lblEmail1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "frmNomeEmailFuncoes";
            this.Text = "frmNomeEmailFuncoes";
            this.Load += new System.EventHandler(this.frmNomeEmailFuncoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultadoEmail2;
        private System.Windows.Forms.Label lblResultadoEmail1;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSemEspacos;
    }
}