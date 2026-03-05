// Inverte as palavras de uma frase, porém mantém os caracteres de espaço.
// Usando LINQ

using System.Text;

static string ReverseWords(string str)
{
    return string.Concat(
        str.Split(' ').Select((word, index) => 
            new string(word.Reverse().ToArray())+
            (index < str.Length && index < str.Split(' ').Length - 1 ? " " : "")
        )
    );
}

Console.Write("\nEscreva a frase que terá as palavras invertidas: \n");
Console.Write("\nFrase com palavras invertidas: \n" + ReverseWords(Console.ReadLine()));
