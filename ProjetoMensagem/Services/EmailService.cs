using ProjetoMensagem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMensagem
{
    public static class EmailService
    {
        public static void EnviarEmail(Mensagem mensagem)
        {
            var conta = "cotinaoresponda@outlook.com";
            var senha = "@Admin123456";
            var smtp = "smtp-mail.outlook.com";
            var porta = 587;

            var textoMensagem = $@"
            Olá {mensagem.NomeDestinatario}. Email enviado por {mensagem.NomeRemetente}. <br/>
            Nivel de prioridade {mensagem.Prioridade}. <br/>
            Texto {mensagem.Texto}.";

            var mailMessage = new MailMessage(conta, mensagem.EmailDestinatario);
            mailMessage.Subject = mensagem.Assunto;
            mailMessage.Body = textoMensagem;
            mailMessage.IsBodyHtml = true;

            var smtpClient = new SmtpClient(smtp, porta);
            smtpClient.Credentials = new NetworkCredential(conta, senha);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
