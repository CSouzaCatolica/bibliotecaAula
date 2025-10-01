using System.Runtime.CompilerServices;

public class LivroCRUD
{
    //
    // Propriedades
    //
    private List<Livro> livros;
    private Livro livro;
    private int indice;
    private List<string> dados;
    private int coluna, linha, largura, altura;



    //
    // Métodos
    //
    public LivroCRUD()
    {
        this.livros = new List<Livro>();
        //this.livro = new Livro(0,"","",0,0);
        this.livro = new Livro();
        this.indice = -1;

        this.dados = new List<string>();
        dados.Add("Código : ");
        dados.Add("Título : ");
        dados.Add("Autor : ");
        dados.Add("Páginas : ");
        dados.Add("Preço : ");

        this.coluna = 20;
        this.linha = 5;
        this.largura = 30;
        this.altura = 7;
    }


    public void ExecutarCRUD()
    {
        string resp;
        Tela tela = new Tela(this.largura, this.altura);
        tela.MontarTela(this.coluna, this.linha, this.dados, "Cadastro de Livros");

        this.EntrarDados(1);
        bool achou = this.ProcurarCodigo();
        if (!achou)
        {
            tela.MostrarMensagem(1, 23, "Código não encontrado.");
            resp = tela.Perguntar(1, 24, "Deseja cadastrar (S/N) : ");
            if (resp.ToLower() == "s")
            {
                this.EntrarDados(2);
                resp = tela.Perguntar(1, 24, "Confirma o cadastro (S/N) : ");
                if (resp.ToLower() == "s")
                {
                    this.livros.Add(new Livro(this.livro.codigo, this.livro.titulo, this.livro.autor, this.livro.paginas, this.livro.paginas));
                }
            }
        }
        else //if (achou)
        {
            this.MostrarDados();
        }
    }


    public void EntrarDados(int qual)
    {
        int coluna = this.coluna + this.dados[0].Length + 1;
        int linha = this.linha + 2;
        if (qual == 1)
        {
            Console.SetCursorPosition(coluna, linha);
            this.livro.codigo = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.SetCursorPosition(coluna, linha + 1);
            this.livro.titulo = Console.ReadLine();
            Console.SetCursorPosition(coluna, linha + 2);
            this.livro.autor = Console.ReadLine();
            Console.SetCursorPosition(coluna, linha + 3);
            this.livro.paginas = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(coluna, linha + 4);
            this.livro.preco = double.Parse(Console.ReadLine());
        }
    }

    public bool ProcurarCodigo()
    {
        bool encontrei = false;

        for (int i = 0; i < this.livros.Count; i++)
        {
            if (this.livro.codigo == this.livros[i].codigo)
            {
                encontrei = true;
                this.indice = i;
                break;
            }
        }
        return encontrei;
    }

    public void MostrarDados()
    {
        int coluna = this.coluna + this.dados[0].Length + 1;
        int linha = this.linha + 3;

        Console.SetCursorPosition(coluna, linha);
        Console.Write(this.livros[this.indice].titulo);
        Console.SetCursorPosition(coluna, linha + 1);
        Console.Write(this.livros[this.indice].autor);
        Console.SetCursorPosition(coluna, linha + 2);
        Console.Write(this.livros[this.indice].paginas);
        Console.SetCursorPosition(coluna, linha + 3);
        Console.Write(this.livros[this.indice].preco);
        
    }

}