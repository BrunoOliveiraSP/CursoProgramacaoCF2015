namespace Estudo.Email
{
    partial class frmEmail
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
            this.txtRemetente = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCopia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCopiaOculta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorpo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remetente";
            // 
            // txtRemetente
            // 
            this.txtRemetente.Location = new System.Drawing.Point(84, 23);
            this.txtRemetente.Name = "txtRemetente";
            this.txtRemetente.Size = new System.Drawing.Size(318, 20);
            this.txtRemetente.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(84, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(293, 49);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(109, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(84, 111);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(318, 20);
            this.txtPara.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Para";
            // 
            // txtCopia
            // 
            this.txtCopia.Location = new System.Drawing.Point(84, 137);
            this.txtCopia.Name = "txtCopia";
            this.txtCopia.Size = new System.Drawing.Size(318, 20);
            this.txtCopia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cópia";
            // 
            // txtCopiaOculta
            // 
            this.txtCopiaOculta.Location = new System.Drawing.Point(84, 163);
            this.txtCopiaOculta.Name = "txtCopiaOculta";
            this.txtCopiaOculta.Size = new System.Drawing.Size(318, 20);
            this.txtCopiaOculta.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cópia oculta";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(84, 220);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(318, 20);
            this.txtAssunto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Assunto";
            // 
            // txtCorpo
            // 
            this.txtCorpo.Location = new System.Drawing.Point(84, 246);
            this.txtCorpo.Multiline = true;
            this.txtCorpo.Name = "txtCorpo";
            this.txtCorpo.Size = new System.Drawing.Size(318, 102);
            this.txtCorpo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Corpo";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(84, 393);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(318, 32);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAnexo
            // 
            this.btnAnexo.Location = new System.Drawing.Point(327, 355);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(75, 23);
            this.btnAnexo.TabIndex = 17;
            this.btnAnexo.Text = "Anexo";
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // lblAnexo
            // 
            this.lblAnexo.Location = new System.Drawing.Point(84, 360);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(237, 13);
            this.lblAnexo.TabIndex = 18;
            this.lblAnexo.Text = "Arquivo.txt";
            this.lblAnexo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 437);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCorpo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCopiaOculta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCopia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemetente);
            this.Controls.Add(this.label1);
            this.Name = "frmEmail";
            this.Text = "Enviar E-mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemetente;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCopia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCopiaOculta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorpo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Label lblAnexo;
    }
}

