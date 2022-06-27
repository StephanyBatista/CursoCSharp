using Repositorio;

namespace Cmd;

public static class OperacaoEditarProduto {

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
        var produtoDesejado = listaDesejada.Produtos.FirstOrDefault(p => p.Nome == nomeDoProduto);
        if(produtoDesejado == null) {
            Console.WriteLine("Produto não encontrada");
            OperacaoEditarLista.Executar();
        }
        Console.WriteLine("Valor pago:");
        var valorPago = Console.ReadLine();
        produtoDesejado.InformarValorPago(decimal.Parse(valorPago));
    }
}