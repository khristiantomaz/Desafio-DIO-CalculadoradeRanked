using System;

class progam
{
    static void Main(string[] args)
    {
        int Vitorias = 30;
        int Derrotas = 5;
        string nivel = CalcularRank(Vitorias, Derrotas);
        Console.WriteLine($"O Heroi tem um saldo de {Vitorias - Derrotas} e está no nivel {nivel}");
    }

    static string CalcularRank( int Vitorias, int Derrotas)
    {
        int saldodeVitorias = Vitorias - Derrotas;
        switch (Vitorias)
        {
            case int n when (n < 10):
                return "Ferro";
            case int n when (n <= 11 && n <= 20):
                return "Bronze";
            case int n when(n <= 21 && n <= 50):
                return "Prata";
            case int n when (n <= 51 && n <= 80):
                return "Ouro";
            case int n when (n <= 81 && n <= 90):
                return "Diamante";
            case int n when (n <= 91 && n <= 100):
                return "Lendario";
            default:
                return "Imortal";
        }

    }
}