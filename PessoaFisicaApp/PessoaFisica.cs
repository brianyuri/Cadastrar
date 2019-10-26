using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PessoaFisicaApp
{
    public class PessoaFisica
    {
        public int CPF { get; set; }
        public void Executa()
        {
            Console.Write("CPF:");
            CPF = Convert.ToInt32(Console.ReadLine());
            Cadastra();
            Console.ReadKey();
            Console.Read();
            Console.Clear();         
        }
        public void Cadastra()
        {
            string arquivo = @"C:\Users\Acer\Documents\Pessoa.txt";
            StreamWriter sw = File.AppendText(arquivo);
            sw.WriteLine($"{CPF}");
            sw.Close();
        }
    }
}
