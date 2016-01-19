namespace A_minha_aplicacao
{
    partial class frmFicheiros
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabEscritaFicheiro = new System.Windows.Forms.TabPage();
            this.txtTextoGuardar = new System.Windows.Forms.TextBox();
            this.tabEscritaFicheiroAppend = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtGuardarTextoAppend = new System.Windows.Forms.TextBox();
            this.tabLeituraFicheiros = new System.Windows.Forms.TabPage();
            this.txtLeituraTexto = new System.Windows.Forms.TextBox();
            this.tabGuardarPessoas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mocDataNascimento = new System.Windows.Forms.MonthCalendar();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabEscritaFicheiro.SuspendLayout();
            this.tabEscritaFicheiroAppend.SuspendLayout();
            this.tabLeituraFicheiros.SuspendLayout();
            this.tabGuardarPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabEscritaFicheiro);
            this.tabMenu.Controls.Add(this.tabEscritaFicheiroAppend);
            this.tabMenu.Controls.Add(this.tabLeituraFicheiros);
            this.tabMenu.Controls.Add(this.tabGuardarPessoas);
            this.tabMenu.Location = new System.Drawing.Point(13, 13);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(746, 409);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabEscritaFicheiro
            // 
            this.tabEscritaFicheiro.Controls.Add(this.txtTextoGuardar);
            this.tabEscritaFicheiro.Location = new System.Drawing.Point(4, 22);
            this.tabEscritaFicheiro.Name = "tabEscritaFicheiro";
            this.tabEscritaFicheiro.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscritaFicheiro.Size = new System.Drawing.Size(738, 383);
            this.tabEscritaFicheiro.TabIndex = 0;
            this.tabEscritaFicheiro.Text = "Escrita em ficheiro";
            this.tabEscritaFicheiro.UseVisualStyleBackColor = true;
            // 
            // txtTextoGuardar
            // 
            this.txtTextoGuardar.Location = new System.Drawing.Point(7, 7);
            this.txtTextoGuardar.Multiline = true;
            this.txtTextoGuardar.Name = "txtTextoGuardar";
            this.txtTextoGuardar.Size = new System.Drawing.Size(725, 370);
            this.txtTextoGuardar.TabIndex = 0;
            // 
            // tabEscritaFicheiroAppend
            // 
            this.tabEscritaFicheiroAppend.Controls.Add(this.txtGuardarTextoAppend);
            this.tabEscritaFicheiroAppend.Location = new System.Drawing.Point(4, 22);
            this.tabEscritaFicheiroAppend.Name = "tabEscritaFicheiroAppend";
            this.tabEscritaFicheiroAppend.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscritaFicheiroAppend.Size = new System.Drawing.Size(738, 383);
            this.tabEscritaFicheiroAppend.TabIndex = 1;
            this.tabEscritaFicheiroAppend.Text = "Escrita em ficheiro - Append";
            this.tabEscritaFicheiroAppend.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(679, 428);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtGuardarTextoAppend
            // 
            this.txtGuardarTextoAppend.Location = new System.Drawing.Point(7, 7);
            this.txtGuardarTextoAppend.Multiline = true;
            this.txtGuardarTextoAppend.Name = "txtGuardarTextoAppend";
            this.txtGuardarTextoAppend.Size = new System.Drawing.Size(725, 373);
            this.txtGuardarTextoAppend.TabIndex = 0;
            // 
            // tabLeituraFicheiros
            // 
            this.tabLeituraFicheiros.Controls.Add(this.txtLeituraTexto);
            this.tabLeituraFicheiros.Location = new System.Drawing.Point(4, 22);
            this.tabLeituraFicheiros.Name = "tabLeituraFicheiros";
            this.tabLeituraFicheiros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeituraFicheiros.Size = new System.Drawing.Size(738, 383);
            this.tabLeituraFicheiros.TabIndex = 2;
            this.tabLeituraFicheiros.Text = "Leitura de Ficheiros";
            this.tabLeituraFicheiros.UseVisualStyleBackColor = true;
            // 
            // txtLeituraTexto
            // 
            this.txtLeituraTexto.Location = new System.Drawing.Point(7, 7);
            this.txtLeituraTexto.Multiline = true;
            this.txtLeituraTexto.Name = "txtLeituraTexto";
            this.txtLeituraTexto.ReadOnly = true;
            this.txtLeituraTexto.Size = new System.Drawing.Size(725, 370);
            this.txtLeituraTexto.TabIndex = 0;
            // 
            // tabGuardarPessoas
            // 
            this.tabGuardarPessoas.Controls.Add(this.btnVer);
            this.tabGuardarPessoas.Controls.Add(this.txtResultado);
            this.tabGuardarPessoas.Controls.Add(this.mocDataNascimento);
            this.tabGuardarPessoas.Controls.Add(this.label3);
            this.tabGuardarPessoas.Controls.Add(this.txtMorada);
            this.tabGuardarPessoas.Controls.Add(this.txtNome);
            this.tabGuardarPessoas.Controls.Add(this.label2);
            this.tabGuardarPessoas.Controls.Add(this.label1);
            this.tabGuardarPessoas.Location = new System.Drawing.Point(4, 22);
            this.tabGuardarPessoas.Name = "tabGuardarPessoas";
            this.tabGuardarPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuardarPessoas.Size = new System.Drawing.Size(738, 383);
            this.tabGuardarPessoas.TabIndex = 3;
            this.tabGuardarPessoas.Text = "Guardar e listar pessoas";
            this.tabGuardarPessoas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Morada:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(71, 64);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(319, 20);
            this.txtMorada.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento:";
            // 
            // mocDataNascimento
            // 
            this.mocDataNascimento.Location = new System.Drawing.Point(163, 134);
            this.mocDataNascimento.Name = "mocDataNascimento";
            this.mocDataNascimento.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(431, 32);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(301, 264);
            this.txtResultado.TabIndex = 6;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(656, 303);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 7;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // frmFicheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 461);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabMenu);
            this.Name = "frmFicheiros";
            this.Text = "frmFicheiros";
            this.tabMenu.ResumeLayout(false);
            this.tabEscritaFicheiro.ResumeLayout(false);
            this.tabEscritaFicheiro.PerformLayout();
            this.tabEscritaFicheiroAppend.ResumeLayout(false);
            this.tabEscritaFicheiroAppend.PerformLayout();
            this.tabLeituraFicheiros.ResumeLayout(false);
            this.tabLeituraFicheiros.PerformLayout();
            this.tabGuardarPessoas.ResumeLayout(false);
            this.tabGuardarPessoas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabEscritaFicheiro;
        private System.Windows.Forms.TabPage tabEscritaFicheiroAppend;
        private System.Windows.Forms.TextBox txtTextoGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtGuardarTextoAppend;
        private System.Windows.Forms.TabPage tabLeituraFicheiros;
        private System.Windows.Forms.TextBox txtLeituraTexto;
        private System.Windows.Forms.TabPage tabGuardarPessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.MonthCalendar mocDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVer;
    }
}