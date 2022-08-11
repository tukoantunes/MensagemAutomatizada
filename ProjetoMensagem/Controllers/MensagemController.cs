using ProjetoMensagem.Entities;
using ProjetoMensagem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMensagem.Controllers
{
    public class MensagemController
    {
        public void CadastrarMensagem()
        {
            try
            {
                Console.WriteLine("|Cadastro de Mensagem|");

                var mensagem = new Mensagem();

                mensagem.Id = Guid.NewGuid();

                Console.WriteLine("Informe o nome do remetente:");
                mensagem.NomeRemetente = Console.ReadLine();

                Console.WriteLine("Informe o nome do destinatário:");
                mensagem.NomeDestinatario = Console.ReadLine();

                Console.WriteLine("Informe o email do destinatário:");
                mensagem.EmailDestinatario = Console.ReadLine();

                Console.WriteLine("Informe o assunto da mensagem:");
                mensagem.Assunto = Console.ReadLine();

                Console.WriteLine("Informe o texto:");
                mensagem.Texto = Console.ReadLine();

                Console.WriteLine("Informe a prioridade - (1)BAIXA / (2)MEDIA / (3)ALTA:");
                mensagem.Prioridade = (PrioridadeMensagem) int.Parse(Console.ReadLine());

                EmailService.EnviarEmail(mensagem);

                Console.WriteLine("Email Enviado!");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao cadastrar mensagem: {ex.Message}");
            }
        }
    }
}
