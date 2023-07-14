namespace Teste03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Teste 03");
            
            while (true)
            {
                Console.WriteLine("Informe o nome do Aluno:");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual foi a nota do primeiro Semestre do Aluno " + nome + "?");
                string nota1 = Console.ReadLine();
                double nota1Double = double.Parse(nota1);

                Console.WriteLine("Qual foi a nota do segundo Semestre do Aluno " + nome + "?");
                string nota2 = Console.ReadLine();
                double nota2Double = double.Parse(nota2);

                double media = (nota1Double + nota2Double) / 2;

                Console.WriteLine("Nome do aluno: " + nome);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("O Aluno foi: " + (media < 6.5 ? "Reprovado" : "Aprovado"));
                Console.WriteLine();
            }

        }
    }
}