public class Tela
{
    //
    // Propriedades
    //
    private int largura;
    private int altura;
    private ConsoleColor corTexto;
    private ConsoleColor corFundo;

    //
    // Construtores
    //
    public Tela(int largura, int altura, ConsoleColor corTexto, ConsoleColor corFundo)
    {
        this.largura = largura;
        this.altura = altura;
        this.corTexto = corTexto;
        this.corFundo = corFundo;
    }

    //
    // Métodos
    //
    public void PrepararTela()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        this.MontarMoldura(0, 0, this.largura, this.altura);
    }

    public void MontarMoldura(int colIni, int linIni, int colFin, int linFin)
    {
        for (int coluna = 0; coluna < colFin; coluna++)
        {
            // horizontal sup
            Console.SetCursorPosition(coluna, linIni);

            Console.Write("═");
            // horizontal inf
            Console.SetCursorPosition(coluna, linFin);
            Console.Write("═");
        }

        for (int linha = linIni; linha <= linFin; linha++)
        {
            // vertical esq
            Console.Write("║");
            Console.SetCursorPosition(colIni, linha);

            // vertical dir
            Console.SetCursorPosition(colFin, linha);
            Console.Write("║");
        }
    }

}