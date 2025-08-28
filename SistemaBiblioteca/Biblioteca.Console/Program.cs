
Livro livro = new Livro("Teste");
Console.WriteLine(livro);
livro.nome = "sim";
Console.WriteLine(livro);

// #########################################################################################
public class Livro
{
    public string nome { get; set; }
    protected string capa { get; set; }
    protected string autor { get; set; }


    // construtor full
    public Livro(string nome, string capa, string autor)
    {
        this.nome = nome;
        this.capa = capa;
        this.autor = autor;
    }

    // construtor separado
    public Livro() : this("", "", "")
    {
    }


    public Livro(string nome)
    {
        this.nome = nome;
    }


    public override string ToString()
    {
        return "{'nome':'" + this.nome + "','capa':'" + this.capa + "}";
    }


}
