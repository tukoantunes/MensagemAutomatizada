using ProjetoMensagem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMensagem.Entities
{
    public class Mensagem
    {
        public Guid Id { get; set; }
        public string NomeRemetente { get; set; }
        public string NomeDestinatario { get; set; }
        public string EmailDestinatario { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public PrioridadeMensagem Prioridade { get; set; }
    }
}
