using ListarPessoaApp;
using PessoApp;
using System;

namespace Cadastro1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("----Escolha uma opcão----");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                opcao = Convert.ToInt32(Console.ReadLine());
                Pessoa pessoa = new Pessoa();
                Listar lista = new Listar();
            switch (opcao)
            {
                    case 1:
                        pessoa.Executa();
                        break;
                    case 2:
                        lista.Executa();
                        break;
                    case 0:
                        
                        break;
                    default:
                        break;
            }
            } while (opcao != 0);
            Console.ReadLine();
            Console.Clear();
            

        }
    }
}
