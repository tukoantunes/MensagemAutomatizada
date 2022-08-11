using ProjetoMensagem.Controllers;

namespace ProjetoMensagem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mensagemController = new MensagemController();
            mensagemController.CadastrarMensagem();

            Console.ReadKey();
        }
    }
    
}