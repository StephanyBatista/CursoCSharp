using Repositorio;

namespace Cmd;

public static class OperacaoObterListas {

    public static void Executar() {
        var listas = ListaRepositorio.ObterTodos();

        foreach (var item in listas)
        {
            Console.WriteLine(
                @$"Lista '{item.Nome}' criada para a data 
                {item.DataDesejadaDaCompra} com {item.Produtos.Count()} produto(s)"
            );
            foreach(var produto in item.Produtos) {
                Console.WriteLine(
                    @$"Produto '{produto.Nome}' - {produto.CategoriaDoProduto} 
                    com valor {produto.ValorPago}"
                );
            }
        }

        OperacaoInicial.Executar();
    }
}