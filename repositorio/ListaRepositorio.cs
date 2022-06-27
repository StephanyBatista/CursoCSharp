using Modelo;

namespace Repositorio;

public static class ListaRepositorio{

    private static List<Lista> _listas = new List<Lista>();

    public static void Adicionar(Lista lista) {
        _listas.Add(lista);
    }

    public static List<Lista> ObterTodos() {
        return _listas;
    }
}