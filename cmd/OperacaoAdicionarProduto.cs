using Modelo;
using Repositorio;

namespace Cmd;

public static class OperacaoAdicionarProduto {

    public static void Executar() {
        Console.WriteLine("Informe o nome da lista");
        var nomeDalistaDesejada = Console.ReadLine();
        var listas = ListaRepositorio.ObterTodos();
        var listaDesejada = listas.FirstOrDefault(l => l.Nome == nomeDalistaDesejada);
        if(listaDesejada == null) {
            Console.WriteLine("Lista não encontrada");
            OperacaoEditarLista.Executar();
        }
        Console.WriteLine("Nome do produto:");    
        var nomeDoProduto = Console.ReadLine();
        Console.WriteLine("Categoria do produto (0 - Mercado, 1 - Escritório, 2 - Manutenção):");    
        var categoriaDoProdutoConsole = Console.ReadLine();
        Enum.TryParse<CategoriaDoProduto>(categoriaDoProdutoConsole, out CategoriaDoProduto categoriaDoProduto);
        var produto = new Produto(nomeDoProduto, categoriaDoProduto);
        if(!produto.Valido())
        {
            foreach(var item in produto.Errors) {
                Console.WriteLine(item);
            }
        }
        else
            listaDesejada.Adicionar(produto);
    }
}