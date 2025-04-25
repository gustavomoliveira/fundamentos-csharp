namespace Aula_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tipos de Dados");
        char c;
        int valor1;
        float valor2;
        double valor3;
        bool b;
        string palavra;

        c = 'R';
        Console.WriteLine("Caractere = " + c);

        valor1 = 4;
        Console.WriteLine("Inteiro = " + valor1);

        valor2 = 4.34f; //valor float precisa do f ao final para demonstrar atribuição
        Console.WriteLine("Float = " + valor2);

        valor3 = 4.3434565656434;
        Console.WriteLine("Double = " + valor3);

        b = true;
        Console.WriteLine("Boolean = " + b);

        palavra = "Palavras, letras ou qualquer sentença.";
        Console.WriteLine(palavra);
        Console.WriteLine($"Formatando uma frase com variável do tipo string: {palavra}"); //interpolação

        double nota1, nota2, nota3, media;
        nota1 = 7.44;
        nota2 = 8.33;
        nota3 = 5.44;
        media = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"Cálculo da média = {media:F1}"); //formatação de 1 casa decimal

        int a = 5;
        Console.WriteLine($"Variável a: {a}");
        a--;
        Console.WriteLine($"Variável a decrementada: {a}");
        a -= 1;
        Console.WriteLine($"Variável a decrementada mais uma vez: {a}");

        String nome1 = "Gustavo";
        string nome2 = "Gustavo";
        if (nome1.Equals(nome2)) //comparação que retorna um boolean, mais eficiente
        {
            Console.WriteLine("Nomes iguais!");
        }

        string nomeMaiusculo;
        nomeMaiusculo = nome1.ToUpper();
        Console.WriteLine($"Nome maiúsculo: {nomeMaiusculo}");

        string nomeMinusculo;
        nomeMinusculo = nome1.ToLower();
        Console.WriteLine($"Nome maiúsculo: {nomeMinusculo}");

        if (nome1.Equals(nomeMaiusculo, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Nomes iguais.");
        }
        else
        {
            Console.WriteLine("Nomes diferentes.");
        }

        string frase1;
        frase1 = "Frase de teste."; 
        string fraseNova;
        fraseNova = frase1.Replace("Frase", "Oração");
        Console.WriteLine($"Nova frase = {fraseNova}");
    }
}