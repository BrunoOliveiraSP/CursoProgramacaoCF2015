namespace Estudo.Exercicio.ContatosGoogle
{
    partial class frmContatos
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
            this.gvContatos = new System.Windows.Forms.DataGridView();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvContatos
            // 
            this.gvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContatos.Location = new System.Drawing.Point(12, 51);
            this.gvContatos.Name = "gvContatos";
            this.gvContatos.Size = new System.Drawing.Size(510, 319);
            this.gvContatos.TabIndex = 0;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(132, 21);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(164, 13);
            this.lblArquivo.TabIndex = 1;
            this.lblArquivo.Text = "c:\\user\\documents\\contacts.csv";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar contatos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.gvContatos);
            this.Name = "frmContatos";
            this.Text = "Importar contatos do Gmail";
            ((System.ComponentModel.ISupportInitialize)(this.gvContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvContatos;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.Button button1;
    }
}

