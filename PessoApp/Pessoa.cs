using PessoaFisicaApp;
using PessoaJuridicaApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PessoApp
{
    public class Pessoa
    { 
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string pessoa { get; set; }
    
        public void Executa()
        {
            int pessoa = 0;
            //do
            //{
                PessoaFisica fisica = new PessoaFisica();
                PessoaJuridica juridica = new PessoaJuridica();
                Console.WriteLine("----Priencha o campo a baixo para cadastro----");                
                Console.Write("Nome:");
                nome = Console.ReadLine();
                Console.Write("Sobrenome:");
                sobrenome = Console.ReadLine();
                Console.Write("Endereco:");
                endereco = Console.ReadLine();
            Cadastra();
                Console.WriteLine("1 - Pessoa Fisica 2 - Pessoa Juridica:");
                pessoa = Convert.ToInt32(Console.ReadLine());
                switch (pessoa)
                {
                    case 1:
                        fisica.Executa();
                        break;
                    case 2:
                        juridica.Executa();
                        break;
                    default:
                        break;
                }

            // while (pessoa != 0);
            Console.ReadLine();
        }
        public void Cadastra()
        {
            string arquivo = @"C:\Users\Acer\Documents\Pessoa.txt";
            StreamWriter sw = File.AppendText(arquivo);
            sw.WriteLine($"{nome}");
            sw.WriteLine($"{sobrenome}");
            sw.WriteLine($"{endereco}");
            sw.Close();
        }
    }
}
