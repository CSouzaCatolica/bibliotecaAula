public class Livro
{
    //
    // propriedades
    //
    public int codigo, paginas;
    public string titulo, autor;
    public double preco;




    //
    // métodos
    //
    public Livro(int codigo = 0, string titulo = "",
    string autor = "", int paginas = 0, double preco = 0)
    {
        this.codigo = codigo;
        this.titulo = titulo;
        this.autor = autor;
        this.paginas = paginas;
        this.preco = preco;
    }
    public void ImprimirLivro()
    {
        Console.WriteLine($"--- Dados do Livro {this.codigo} ---");
        Console.WriteLine($"Codigo : {this.codigo}");
        Console.WriteLine($"Título : {this.titulo}");
        Console.WriteLine($"Autor : {this.autor}");
        Console.WriteLine($"Num de páginas : {this.paginas}");
        Console.WriteLine($"Preço : {this.preco}");
        Console.WriteLine("");
    }
}