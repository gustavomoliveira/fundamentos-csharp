namespace PrimeiroProjeto;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2;
        n1 = 10;
        n2 = 20;
        Console.WriteLine("n1 = " + n1);
        Console.WriteLine("n2 = " + n2);

        int soma = n1 + n2;
        Console.WriteLine("soma = " + soma);

        var dt = new DateTime(); //var tipa a variável como qualquer tipo, poderia ser DateTime dt = ...;
        Console.WriteLine(dt);
        dt = DateTime.Now;
        Console.WriteLine(dt);
        System.Console.WriteLine("Dia: " + dt.Day);

        double nota1, nota2, nota3, media;

        nota1 = 6.44;
        nota2 = 7.33;
        nota3 = 5.17;
        media = (nota1 + nota2 + nota3) / 3;
        System.Console.WriteLine("Media = " + media);
    }
}
