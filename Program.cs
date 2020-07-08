using System;
using MVC_POO.Controllers;

namespace MVC_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produto = new ProdutoController();
            produto.Filtrar("1500");
            
        }
    }
}
