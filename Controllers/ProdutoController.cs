using System.Collections.Generic;
using MVC_POO.Models;
using MVC_POO.Views;

namespace MVC_POO.Controllers
{
    public class ProdutoController
    {
        
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){
            produtoView.MostrarNoConsole(produtoModel.Ler());
        }

        public void Filtrar(string _preco){
            List<Produto> lista = produtoModel.Ler();
            lista = lista.FindAll(x => x.Preco == float.Parse(_preco));
            produtoView.MostrarNoConsole(lista);
        }

    }
}