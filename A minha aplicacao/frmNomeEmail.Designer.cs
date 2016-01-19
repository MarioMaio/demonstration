namespace A_minha_aplicacao
{
    partial class frmNomeEmail
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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.lblResultadoEmail1 = new System.Windows.Forms.Label();
            this.lblResultadoEmail2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(101, 5);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(296, 20);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(170, 42);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.Location = new System.Drawing.Point(16, 134);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(44, 13);
            this.lblEmail1.TabIndex = 4;
            this.lblEmail1.Text = "Email 1:";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(16, 174);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(44, 13);
            this.lblEmail2.TabIndex = 5;
            this.lblEmail2.Text = "Email 2:";
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Location = new System.Drawing.Point(98, 94);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(93, 13);
            this.lblResultadoNome.TabIndex = 6;
            this.lblResultadoNome.Text = "lblResultadoNome";
            // 
            // lblResultadoEmail1
            // 
            this.lblResultadoEmail1.AutoSize = true;
            this.lblResultadoEmail1.Location = new System.Drawing.Point(98, 134);
            this.lblResultadoEmail1.Name = "lblResultadoEmail1";
            this.lblResultadoEmail1.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoEmail1.TabIndex = 7;
            this.lblResultadoEmail1.Text = "label6";
            // 
            // lblResultadoEmail2
            // 
            this.lblResultadoEmail2.AutoSize = true;
            this.lblResultadoEmail2.Location = new System.Drawing.Point(98, 174);
            this.lblResultadoEmail2.Name = "lblResultadoEmail2";
            this.lblResultadoEmail2.Size = new System.Drawing.Size(35, 13);
            this.lblResultadoEmail2.TabIndex = 8;
            this.lblResultadoEmail2.Text = "label7";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(170, 202);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmNomeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 238);
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
            this.Name = "frmNomeEmail";
            this.Text = "frmNomeEmail";
            this.Load += new System.EventHandler(this.frmNomeEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Label lblResultadoEmail1;
        private System.Windows.Forms.Label lblResultadoEmail2;
        private System.Windows.Forms.Button btnLimpar;
    }
}