namespace Teste01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do primeiro semestre:");
            string nota1 = Console.ReadLine();
            double nota1double = double.Parse(nota1);

            Console.WriteLine("Digite a nota do segundo semestre:");
            string nota2 = Console.ReadLine();
            double nota2double = double.Parse(nota2);

            double media = (nota1double + nota2double) / 2;

            Console.WriteLine("Sua média é de " + media);


            Console.ReadKey();
        }
    }
}