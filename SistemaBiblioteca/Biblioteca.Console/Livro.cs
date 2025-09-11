public class Livro
{
    public int codigo;
    public string titulo;
    public string autor;
    public int paginas;
    public double preco;

    // metodos


    public Livro(int codigo, string titulo, string autor, int paginas, double preco)
    {
        this.codigo = codigo;
        this.titulo = titulo;
        this.autor = autor;
        this.paginas = paginas;
        this.preco = preco;
    }
    public void imprimirLivro()
    {
        Console.WriteLine($"----- Dados do Livro {this.codigo} -----");
        Console.WriteLine($"Codigo: {this.codigo}");
        Console.WriteLine($"Titulo: {this.titulo}");
        Console.WriteLine($"Autor: {this.autor}");
        Console.WriteLine($"Paginas: {this.paginas}");
        Console.WriteLine($"Preco: {this.preco}");
        Console.WriteLine("-------------------------");
    }

}