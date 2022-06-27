using Repositorio;

namespace Cmd;

public static class OperacaoRelatorio {

    public static void Executar() {
        Console.WriteLine("Informe o nome da lista");
        var nomeDalistaDesejada = Console.ReadLine();
        var listas = ListaRepositorio.ObterTodos();
        var listaDesejada = listas.FirstOrDefault(l => l.Nome == nomeDalistaDesejada);
        if(listaDesejada == null) {
            Console.WriteLine("Lista não encontrada");
            OperacaoInicial.Executar();
        }
        var totalEmReaisDosProdutos = listaDesejada.Produtos.Sum(p => p.ValorPago);
        var totalEmReaisDeMercado = 
            listaDesejada.Produtos
                .Where(p => p.CategoriaDoProduto == Modelo.CategoriaDoProduto.Mercado).Sum(p => p.ValorPago);
        var totalEmReaisDeEscritorio = 
            listaDesejada.Produtos
                .Where(p => p.CategoriaDoProduto == Modelo.CategoriaDoProduto.Escritorio).Sum(p => p.ValorPago);
        var totalEmReaisDeManutencao = 
            listaDesejada.Produtos
                .Where(p => p.CategoriaDoProduto == Modelo.CategoriaDoProduto.Manutencao).Sum(p => p.ValorPago);
        var totalDeProdutosNaoComprados = listaDesejada.Produtos.Where(p => p.Comprado == false).Count();

        Console.WriteLine($"Total em reais {totalEmReaisDosProdutos}");
        Console.WriteLine($"Total em mercadoria {totalEmReaisDeMercado}");
        Console.WriteLine($"Total em escritório {totalEmReaisDeEscritorio}");
        Console.WriteLine($"Total em Manutenção {totalEmReaisDeManutencao}");
        Console.WriteLine($"Total produtos não comprados {totalDeProdutosNaoComprados}");

        OperacaoInicial.Executar();
    }
}