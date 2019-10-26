using PessoApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ListarPessoaApp
{
    public class Listar
    {
        public void Executa()
        {
            
            List<Pessoa> listaP = new List<Pessoa>();
            Pessoa uL;
            string arquivo = @"C:\Users\Acer\Documents\Pessoa.txt";
            StreamReader sr = File.OpenText(arquivo);
            while (sr.EndOfStream == false)
            {
                uL = new Pessoa();
                string linha = sr.ReadLine();
                uL.nome = linha;
                uL.sobrenome = linha;
                uL.endereco = linha;
                Console.WriteLine($"{linha}");                
                listaP.Add(uL);                
            }
            Console.ReadLine();
        }       
    }
}
