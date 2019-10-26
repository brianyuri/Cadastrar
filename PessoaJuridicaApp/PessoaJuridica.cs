using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PessoaJuridicaApp
{
    public class PessoaJuridica
    {
        public int CNPJ { get; set; }
        public string nomefantasia { get; set; }
        public void Executa()
        {
            Console.Write("CNPJ: ");
            CNPJ = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome Fantasia: ");
            nomefantasia = Console.ReadLine();
            Cadastra();
            Console.Read();
            Console.ReadKey();
            Console.Clear();
        }
        public void Cadastra()
        {
            string arquivo = @"C:\Users\Acer\Documents\Pessoa.txt";
            StreamWriter sw = File.AppendText(arquivo);
            sw.WriteLine($"{CNPJ}");
            sw.WriteLine($"{nomefantasia}");
            sw.Close();
        }
    }
}
