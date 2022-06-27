namespace Modelo;

public class Lista : ModeloBase {
    public readonly string Nome;
    public DateTime DataDesejadaDaCompra { get; private set; }
    public List<Produto> Produtos {get; private set; } = new List<Produto>();

    public Lista(string nome, DateTime dataDesejadaDaCompra)
    {
        AdicionarValidacao(string.IsNullOrEmpty(nome), "Nome inválido");
        AdicionarValidacao(dataDesejadaDaCompra == DateTime.MinValue, "Data inválida");
        
        Nome = nome;
        DataDesejadaDaCompra = dataDesejadaDaCompra;
    }

    public void Adicionar(Produto produto) {
        Produtos.Add(produto);
    }
}