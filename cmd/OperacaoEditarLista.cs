namespace Cmd;

public static class OperacaoEditarLista {

    public static void Executar() {
        while(true) {
            Console.WriteLine("Informe a operação desejada");
            Console.WriteLine("1 - Adicionar produto");
            Console.WriteLine("2 - Editar produto");
            var operacaoDesejada = Console.ReadLine();
            if(operacaoDesejada == "1")
                OperacaoAdicionarProduto.Executar();
            else if(operacaoDesejada == "2")
                OperacaoEditarProduto.Executar();
            OperacaoInicial.Executar();
        }
    }
}