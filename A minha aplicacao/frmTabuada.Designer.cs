namespace A_minha_aplicacao
{
    partial class frmTabuada
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
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblTabuada = new System.Windows.Forms.Label();
            this.btnLimpa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(27, 13);
            this.nudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 0;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(27, 40);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(120, 23);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblTabuada
            // 
            this.lblTabuada.AutoSize = true;
            this.lblTabuada.Location = new System.Drawing.Point(27, 80);
            this.lblTabuada.Name = "lblTabuada";
            this.lblTabuada.Size = new System.Drawing.Size(35, 13);
            this.lblTabuada.TabIndex = 2;
            this.lblTabuada.Text = "label1";
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(27, 244);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(120, 23);
            this.btnLimpa.TabIndex = 3;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.lblTabuada);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.nudValor);
            this.Name = "frmTabuada";
            this.Text = "frmTabuada";
            this.Load += new System.EventHandler(this.frmTabuada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblTabuada;
        private System.Windows.Forms.Button btnLimpa;
    }
}