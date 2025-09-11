public class Tela
{
    //propriedades
    private int largura, altura;
    private ConsoleColor corTexto, corFundo;

    //metodos

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
        Console.BackgroundColor = this.corTexto;
        Console.Clear();
        this.MontarMoldura(0, 0, this.largura, this.altura);
    }

    public void MontarMoldura(int colIni, int linIni, int colFin, int linFin)
    {
        for (int coluna = colIni; coluna <= colFin; coluna++)
        {
            Console.SetCursorPosition(coluna, linIni);
            Console.Write("-");

            Console.SetCursorPosition(coluna, linFin);
            Console.Write("-");
        }

        for (int linha = linIni; linha <= linFin; linha++)
        {
            Console.SetCursorPosition(colIni, linha);
            Console.Write("|");

            Console.SetCursorPosition(colFin, linha);
            Console.Write("|");
        }
    }

}