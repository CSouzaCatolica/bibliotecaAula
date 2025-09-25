using System.Text;

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
        bool achou = false;
        string resp;
        Tela tela = new Tela(this.largura, this.altura);
        tela.MontarTela(this.coluna, this.linha, this.dados, "Cadastro de Livros");

        this.EntrarDados(1);

        achou = this.ProcurarCodigo();

        if (!achou)
        {
            tela.MostrarMensagem("Livro não cadastrado", 13, 20);

            resp = tela.Perguntar(coluna: 14, linha: 20, perg: "Quer cadastrar? [S:Sim, N:Não]", toUpper: true);
            if (resp == "S")
            {
                this.EntrarDados(2);
            }

        }
    }


    public bool ProcurarCodigo(){
        for (int i = 0; i < this.livros.Count; i++)
        {
            if (this.livros[i].codigo == this.livro.codigo)
            {
                this.indice = i;
                Console.SetCursorPosition(this.coluna + this.dados[0].Length + 1, this.linha + 3);
                Console.Write(this.livros[i].titulo);
                Console.SetCursorPosition(this.coluna + this.dados[0].Length + 1, this.linha + 4);
                Console.Write(this.livros[i].autor);
                Console.SetCursorPosition(this.coluna + this.dados[0].Length + 1, this.linha + 5);
                Console.Write(this.livros[i].paginas);
                Console.SetCursorPosition(this.coluna + this.dados[0].Length + 1, this.linha + 6);
                Console.Write(this.livros[i].preco);
                return true;
            }
        }
        return false;
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

            this.livros.Add(this.livro);



        }
    }

}