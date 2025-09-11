Tela tela = new Tela(80, 25, ConsoleColor.Yellow, ConsoleColor.DarkGreen);

string opcao = "";

List<string> menu = new List<string>;
menu.Add("1 - Empréstimos");
menu.Add("2 - Livros");
menu.Add("3 - Alunos");
menu.Add("4 - Relatórios");
menu.Add("0 - Sair");

while (true)
{

    tela.PrepararTela();

    if (opcao == "0") break;
}