using System.Collections.Generic;
using System;
using MVC_POO.Models;

namespace MVC_POO.Views
{
    public class ProdutoView
    {
        
       public void MostrarNoConsole(List<Produto> prodt){
           foreach(Produto coisa in prodt){
               Console.WriteLine($"R$ {coisa.Preco} - {coisa.Nome}");
           }
       }

    }
}