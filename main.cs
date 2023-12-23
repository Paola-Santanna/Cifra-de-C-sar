using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static class RemoverEspacos
{
    public static string removerEspacosBrancos(this string str)
    {
        return Regex.Replace(str, @"\s+", String.Empty);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Cifra de César--\n");
        
        Dictionary<char, char> x = new Dictionary<char, char>();
            x.Add('A', 'M');
            x.Add('À', 'M');
            x.Add('Á', 'M');
            x.Add('Ã', 'M');
            x.Add('Â', 'M');
            x.Add('B', 'N');
            x.Add('C', 'O');
            x.Add('Ç', 'O');
            x.Add('D', 'P');
            x.Add('E', 'Q');
            x.Add('É', 'Q');
            x.Add('Ê', 'Q');
            x.Add('È', 'Q');
            x.Add('F', 'R');
            x.Add('G', 'S');
            x.Add('H', 'T');
            x.Add('I', 'U');
            x.Add('Í', 'U');
            x.Add('Ì', 'U');
            x.Add('Î', 'U');
            x.Add('J', 'V');
            x.Add('K', 'W');
            x.Add('L', 'X');
            x.Add('M', 'Y');
            x.Add('N', 'Z');
            x.Add('O', 'A');
            x.Add('Ó', 'A');
            x.Add('Ò', 'A');
            x.Add('Ô', 'A');
            x.Add('Õ', 'A');
            x.Add('P', 'B');
            x.Add('Q', 'C');
            x.Add('R', 'D');
            x.Add('S', 'E');
            x.Add('T', 'F');
            x.Add('U', 'G');
            x.Add('Ú', 'G');
            x.Add('Ù', 'G');
            x.Add('Û', 'G');
            x.Add('V', 'H');
            x.Add('W', 'I');
            x.Add('X', 'J');
            x.Add('Y', 'K');
            x.Add('Z', 'L');
            x.Add('a', 'M');
            x.Add('à', 'M');
            x.Add('á', 'M');
            x.Add('ã', 'M');
            x.Add('â', 'M');
            x.Add('b', 'N');
            x.Add('c', 'O');
            x.Add('ç', 'O');
            x.Add('d', 'P');
            x.Add('e', 'Q');
            x.Add('é', 'Q');
            x.Add('è', 'Q');
            x.Add('ê', 'Q');
            x.Add('f', 'R');
            x.Add('g', 'S');
            x.Add('h', 'T');
            x.Add('i', 'U');
            x.Add('í', 'U');
            x.Add('ì', 'U');
            x.Add('î', 'U');
            x.Add('j', 'V');
            x.Add('k', 'W');
            x.Add('l', 'X');
            x.Add('m', 'Y');
            x.Add('n', 'Z');
            x.Add('o', 'A');
            x.Add('ò', 'A');
            x.Add('ó', 'A');
            x.Add('ô', 'A');
            x.Add('õ', 'A');
            x.Add('p', 'B');
            x.Add('q', 'C');
            x.Add('r', 'D');
            x.Add('s', 'E');
            x.Add('t', 'F');
            x.Add('u', 'G');
            x.Add('ú', 'G');
            x.Add('ù', 'G');
            x.Add('û', 'G');
            x.Add('v', 'H');
            x.Add('w', 'I');
            x.Add('x', 'J');
            x.Add('y', 'K');
            x.Add('z', 'L');
        
        Console.WriteLine("Digite a Frase: ");
        string y = Console.ReadLine();
        
        string z = y;
        
        foreach (KeyValuePair <char, char> item in x)
        {
            z = z.Replace(item.Key, item.Value).Trim();
        }
        
        Console.WriteLine("Resultado: {0}", z.removerEspacosBrancos().ToUpper());
        
        Console.WriteLine("\n--Pressione ENTER para encerrar--");
        Console.ReadLine();
    }
}
