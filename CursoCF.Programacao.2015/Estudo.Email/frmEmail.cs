using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estudo.Email
{
    public partial class frmEmail : Form
    {
        public frmEmail()
        {
            InitializeComponent();
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                lblAnexo.Text = dialog.FileName;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //VALIDA INFORMAÇÕES
            bool validado = ValidarInformacoes();
            if (!validado)
            {
                MessageBox.Show("Preencha os campos obrigatórios");
                return;
            }


            // CRIA OBJETO DO EMAIL
            string remetente = txtRemetente.Text.Trim();
            string para = txtPara.Text.Trim();
            string copia = txtCopia.Text.Trim();
            string copiaOculta = txtCopiaOculta.Text.Trim();
            string assunto = txtAssunto.Text.Trim();
            string mensagem = txtCorpo.Text.Trim();
            string anexo = lblAnexo.Text.Trim();

            System.Net.Mail.MailMessage message = CriarEmail(remetente, para, copia, copiaOculta, assunto, mensagem, anexo);


            // ENVIAR E-MAIL
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            EnviarEmail(message, usuario, senha);
        }

        private bool ValidarInformacoes()
        {
            // SE o usuário preencher o REMETENTE, USUARIO, SENHA e PARA está validado
            if (!string.IsNullOrEmpty(txtRemetente.Text)
             && !string.IsNullOrEmpty(txtUsuario.Text)
             && !string.IsNullOrEmpty(txtSenha.Text)
             && !string.IsNullOrEmpty(txtPara.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public System.Net.Mail.MailMessage CriarEmail(string remetente, string para, string copia, string copiaOculta, string assunto, string mensagem, string anexo)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

            // Informa o REMETENTE
            message.From = new System.Net.Mail.MailAddress(remetente);

            // Informa o DESTINATARIO
            message.To.Add(para);

            // Verifica se existe COPIA para enviar
            if (!string.IsNullOrEmpty(copia))
                message.CC.Add(copia);

            // Verifica se existe COPIA OCULTA para enviar
            if (!string.IsNullOrEmpty(copiaOculta))
                message.Bcc.Add(copiaOculta);

            // Anexa arquivo escolhido
            message.Attachments.Add(new System.Net.Mail.Attachment(anexo));

            // Informa o ASSUNTO
            message.Subject = assunto;

            // Informa o CORPO
            message.Body = mensagem;

            return message;
        }

        public void EnviarEmail(System.Net.Mail.MailMessage message, string usuario, string senha)
        {
            // Configura E-mail do GMAIL
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            
            // Informa as CREDENCIAIS
            smtp.Credentials = new System.Net.NetworkCredential(usuario, senha);

            // Envia o EMAIL
            smtp.Send(message);
        }
    }
}
