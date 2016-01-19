namespace A_minha_aplicacao
{
    partial class frmCelcius
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
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnNovoCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farenheit";
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(70, 6);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFarenheit.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(70, 33);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Celcius";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Enabled = false;
            this.txtCelcius.Location = new System.Drawing.Point(70, 61);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 4;
            // 
            // btnNovoCalculo
            // 
            this.btnNovoCalculo.Location = new System.Drawing.Point(70, 88);
            this.btnNovoCalculo.Name = "btnNovoCalculo";
            this.btnNovoCalculo.Size = new System.Drawing.Size(100, 23);
            this.btnNovoCalculo.TabIndex = 5;
            this.btnNovoCalculo.Text = "Novo Cálculo";
            this.btnNovoCalculo.UseVisualStyleBackColor = true;
            this.btnNovoCalculo.Click += new System.EventHandler(this.btnNovoCalculo_Click);
            // 
            // frmCelcius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 124);
            this.Controls.Add(this.btnNovoCalculo);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFarenheit);
            this.Controls.Add(this.label1);
            this.Name = "frmCelcius";
            this.Text = "frmCelcius";
            this.Load += new System.EventHandler(this.frmCelcius_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnNovoCalculo;
    }
}