// ########################################################
// ###                      MAIN                        ###
// ########################################################




int op;

while (true)
{
    Console.Clear();
    Console.WriteLine("--===== Sistema de Biblioteca =====--");
    Console.WriteLine("1 - Cadastrar Livro");
    Console.WriteLine("2 - Ver Livro");
    Console.WriteLine("3 - Excluir Livro");
    Console.WriteLine("4 - Relatorios de Livros");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");
    op = int.Parse(Console.ReadLine());

    if (op == 0) break;

    switch (op)
    {
        case 1: CadastrarLivro(); break;
        // case 2: VerLivro(); break;
        // case 3: ExcluirLivro(); break;
        // case 4: RelatoriosLivros(); break;
    }
    Console.WriteLine("\nPressione Enter para continuar...");
    Console.ReadKey();
    Console.Clear();
       
}












// ########################################################
// ###                 FUNCTIONS                        ###
// ########################################################

bool CadastrarLivro()
{
    return true;
}