using System;
using POOconstrutores.classes;

namespace exercicios_15._12_POOconstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            construtor Produto1 = new construtor ();
            System.Console.WriteLine($"Código = {Produto1.Codigo}, Nome = {Produto1.Nome} 'null', Estoque = {Produto1.Estoque}, Descrição = {Produto1.Descricao} 'null'");
            construtor Produto2 = new construtor ();
            System.Console.WriteLine($"Código = {Produto2.Codigo}, Nome = {Produto2.Nome} 'null', Estoque = {Produto2.Estoque}, Descrição = {Produto2.Descricao} 'null'");
            construtor Produto3 = new construtor ();
            System.Console.WriteLine($"Código = {Produto3.Codigo}, Nome = {Produto3.Nome} 'null', Estoque = {Produto3.Estoque}, Descrição = {Produto3.Descricao} 'null'");

            Console.ReadLine();
            
        }
    }
}
