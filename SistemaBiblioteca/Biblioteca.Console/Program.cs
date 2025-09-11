String opcao = "";
Tela tela = new Tela(
    50,
    10,
    ConsoleColor.Yellow,
    ConsoleColor.Black
);

List<string> menu = new List<string>();
menu.Add("1 - Emprestimos");
menu.Add("2 - Livros");
menu.Add("3 - Alunos");
menu.Add("4 - Usuarios");
menu.Add("0 - Sair");


while (true)
{
    tela.PrepararTela();
    if (opcao == "0") break;
    Console.ReadKey();

}