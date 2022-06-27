namespace Modelo;

public abstract class ModeloBase {

    public List<string> Errors {get; set;} = new List<string>();

    public void AdicionarValidacao(bool ehInvalido, string mensagem) {
        if(ehInvalido)
            Errors.Add(mensagem);
    }

    public bool Valido() {
        return Errors.Count() == 0;
    }
}