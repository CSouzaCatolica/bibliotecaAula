
Livro livro = new Livro("Teste", "asdw");
Console.WriteLine(livro);
// #########################################################################################
public class Livro
{
    protected string nome { get; set; }
    protected string capa { get; set; }

    // construtor full
    public Livro(string nome, string capa)
    {
        this.nome = nome;
        this.capa = capa;
    }

    // construtor separado
    public Livro() : this("Sem nome", "")
    {
    }


    public Livro(string nome)
    {
        this.nome = nome;
        this.capa = "";
    }


    public override string ToString()
    {
        return "{'nome':'" + this.nome + "','capa':'" + this.capa + "}";
    }


}
