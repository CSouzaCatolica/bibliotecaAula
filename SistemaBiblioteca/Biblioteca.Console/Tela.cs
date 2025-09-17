public class Tela
{
    ///
    /// Propriedades
    ///
    private int largura, altura;
    private ConsoleColor corTexto, corFundo;

    ///
    /// Métodos
    ///
    public Tela(int lar, int alt, ConsoleColor txt, ConsoleColor fun)
    {
        this.largura = lar;
        this.altura = alt;
        this.corTexto = txt;
        this.corFundo = fun;
    }


    public void PrepararTela()
    {
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
        this.MontarMoldura(0, 0, this.largura, this.altura);
    }


    public void MontarMoldura(int colIni, int linIni, int colFin, int linFin)
    {
        for (int coluna = colIni; coluna <= colFin; coluna++)
        {
            // desenha a linha horizontal superior
            Console.SetCursorPosition(coluna, linIni);
            Console.Write("═");

            // desenha a linha horizontal inferior
            Console.SetCursorPosition(coluna, linFin);
            Console.Write("═");
        }

        for (int linha = linIni; linha <= linFin; linha++)
        {
            // desenha a linha vertical esquerda
            Console.SetCursorPosition(colIni, linha);
            Console.Write("║");
            // desenha a linha vertical direita
            Console.SetCursorPosition(colFin, linha);
            Console.Write("║");
        }
    }


}