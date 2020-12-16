using System;
using System.Collections.Generic;
using Listas_de_objetos.classes;

namespace Listas_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produto = new List<Produto>();

            produto.Add(new Produto(1, "Apple Watch", 3522.56f));
            produto.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produto.Add(new Produto(3, "Zenfone ASUS", 2522.56f));
            produto.Add(new Produto(4, "Apple Watch", 2522.87f));
            produto.Add(new Produto(5, "Apple Watch", 3522.56f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XXI";
            iphone.Preco = 5233.99f;

            produto.Add(iphone);

            foreach(Produto p in produto){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco} ");
            }

        }
    }
}
