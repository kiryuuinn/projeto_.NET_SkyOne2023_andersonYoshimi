namespace Teste02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Teste 2, para iniciarmos qual é o seu Nome?");
            string nome = Console.ReadLine();

            int quantidadeProvas = 0;
            double somaNotas = 0;

            while (true)
            {
                Console.WriteLine(nome + " por favor, nos informe qual foi sua nota na prova?");
                string nota = Console.ReadLine();
                double notaDouble = double.Parse(nota);

                quantidadeProvas++;
                somaNotas += notaDouble;

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Quantidade de provas: " + quantidadeProvas);
                Console.WriteLine("Total de Nota: " + somaNotas);
                Console.WriteLine("Sua média é de: " + (somaNotas / quantidadeProvas));

                Console.WriteLine();
            }

        }
    }
}