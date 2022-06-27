namespace Modelo;

public enum CategoriaDoProduto {
    Mercado,
    Escritorio,
    Manutencao
}

public class Produto : ModeloBase {
    public string Nome { get; private set; } = default!;
    public CategoriaDoProduto CategoriaDoProduto {get; private set;}
    public decimal ValorPago { get; private set; }
    public bool Comprado { get; private set; }

    public Produto(string nome, CategoriaDoProduto categoriaDoProduto)
    {
        AdicionarValidacao(string.IsNullOrEmpty(nome), "Nome inválido");
        Nome = nome;
        CategoriaDoProduto = categoriaDoProduto;
    }

    public void InformarValorPago(decimal valorPago) {
        ValorPago = valorPago;
        Comprado = true;
    }
}