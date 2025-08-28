// ########################################################
// ###                      MAIN                        ###
// ########################################################

List<int> codigos = new List<int>();
List<string> titulos = new List<string>();
List<string> autores = new List<string>();
List<long> paginas = new List<long>();
List<double> precos = new List<double>();
int op;

while (true)
{
    populaLivros();
    Console.Clear();
    Console.WriteLine("--===== Sistema de Biblioteca =====--");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Ver Livro");
    Console.WriteLine("3 - Excluir Livro");
    Console.WriteLine("4 - Relatorios de Livros");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    op = int.Parse(Console.ReadLine());
    if (op == 0)
    {
        Console.WriteLine("Saindo...");
        break;
    }

    switch (op)
    {
        case 1: CadastrarLivro(); break;
        case 2: ConsultarLivro(); break;
        case 3: ExcluirLivro(); break;
        case 4: EmitirRelatorios(); break;
    }
    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadKey();
    Console.Clear();

}

// ########################################################
// ###                 FUNCTIONS                        ###
// ########################################################
void CadastrarLivro()
{
    int codigo;
    long pagina;
    string titulo, autor;
    double preco;

    Console.Clear();
    Console.WriteLine("--===== Cadastrar Livro =====--");
    Console.Write("Código: ");
    codigo = int.Parse(Console.ReadLine());
    Console.Write("Título: ");
    titulo = Console.ReadLine();
    Console.Write("Autor: ");
    autor = Console.ReadLine();
    Console.Write("Páginas: ");
    pagina = long.Parse(Console.ReadLine());
    Console.Write("Preço: ");
    preco = double.Parse(Console.ReadLine());

    codigos.Add(codigo);
    titulos.Add(titulo);
    autores.Add(autor);
    paginas.Add(pagina);
    precos.Add(preco);

    Console.WriteLine("\nLivro cadastrado com sucesso!");
    Console.Write("Código: " + codigo + "\nTítulo: " + titulo + "\nAutor: " + autor + "\nPáginas: " + paginas + "\nPreço: " + preco + "\n");
}
// ########################################################
void ConsultarLivro()
{

}

// ########################################################
void ExcluirLivro()
{

}

// ########################################################
void EmitirRelatorios()
{
    int linha = 3;
    //lista todos os livros
    Console.Clear();
    Console.WriteLine("--===== Relatorios de Livros =====--");
    Console.SetCursorPosition(0, 2);
    Console.Write("Codigo");
    Console.SetCursorPosition(8, 2);
    Console.Write("Título");
    Console.SetCursorPosition(40, 2);
    Console.Write("Autor");
    Console.SetCursorPosition(60, 2);
    Console.Write("Páginas");
    Console.SetCursorPosition(69, 2);
    Console.Write("Preço");

    for (int i = 0; i < codigos.Count; i++)
    {
        Console.SetCursorPosition(0, linha);
        Console.Write(codigos[i]);
        Console.SetCursorPosition(8, linha);
        Console.Write(titulos[i]);
        Console.SetCursorPosition(40, linha);
        Console.Write(autores[i]);
        Console.SetCursorPosition(60, linha);
        Console.Write(paginas[i]);
        Console.SetCursorPosition(69, linha);
        Console.Write(precos[i]);
        linha++;
        // Console.WriteLine("Código: " + codigos[i] + " - Título: " + titulos[i] + " - Autor: " + autores[i] + " - Páginas: " + paginas[i] + " - Preço: " + precos[i]);
    }
}

void populaLivros()
{

    codigos.Add(1);
    codigos.Add(2);
    codigos.Add(3);
    codigos.Add(4);
    codigos.Add(5);

    titulos.Add("Livro 1");
    titulos.Add("Livro 2");
    titulos.Add("Livro 3");
    titulos.Add("Livro 4");
    titulos.Add("Livro 5");

    autores.Add("Autor 1");
    autores.Add("Autor 2");
    autores.Add("Autor 3");
    autores.Add("Autor 4");
    autores.Add("Autor 5");

    paginas.Add(100);
    paginas.Add(200);
    paginas.Add(300);
    paginas.Add(400);
    paginas.Add(500);

    precos.Add(10.99);
    precos.Add(20.99);
    precos.Add(30.99);
    precos.Add(40.99);
    precos.Add(50.99);

}