Tela tela = new Tela(80, 25, ConsoleColor.Yellow, ConsoleColor.Black);

string opcao = "";

List<string> menu = new List<string>();
menu.Add("1 - Empréstimos");
menu.Add("2 - Livros");
menu.Add("3 - Alunos");
menu.Add("4 - Relatórios");
menu.Add("0 - Sair");

while (true)
{

    tela.PrepararTela();


    int linha = 5;
    foreach (string op in menu)
    {
        Console.SetCursorPosition(5, linha);
        Console.Write(op);
        linha++;
    }

    if (opcao == "0") break;
    Console.ReadKey();
}