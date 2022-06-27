using Modelo;
using Repositorio;

namespace Cmd;

public static class OperacaoCriarLista {

    public static void Executar() {
        Console.WriteLine("Nome:");
        var nome = Console.ReadLine();
        Console.WriteLine("Data desejada:");
        var dataDesejada = Console.ReadLine();
        DateTime.TryParse(dataDesejada, out var dataDesejadaConvertida);
        var lista = new Lista(nome, dataDesejadaConvertida);
        if(!lista.Valido())
        {
            foreach(var item in lista.Errors) {
                Console.WriteLine(item);
            }
            OperacaoInicial.Executar();
        }
        ListaRepositorio.Adicionar(lista);
        Console.WriteLine($"Lista {lista.Nome} criada para a data {lista.DataDesejadaDaCompra}");
        OperacaoInicial.Executar();
    }
}