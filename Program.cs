using System;
using Objetos_como_argumento.classes;

namespace Objetos_como_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(1,"Mouse Razer 3.5", 300);
            Produto produto2 = new Produto(1,"HeadSet Chroma 7.1", 500);
            Produto produto3 = new Produto(1,"Mouse Pas XPT0", 300);

            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);
            
            
            
            carrinho.MostrarProdutos();
            

            //Inicio do Menu
            // {
             
            //     Console.WriteLine("STORE");
            //     Console.WriteLine("Selecione uma opção: ");
            //     Console.WriteLine("[1] - ");
            //     Console.WriteLine("[2] - ");
            //     Console.WriteLine("[3] - Sair");
                
                     


        }
    }
}
