using System.Text;

namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex23 : Exercicio
    {
        public override string GetDescricao()
        {
            return "23-Crie um programa que solicite ao usuário um número e exiba na tela a sua fatoração em números primos.";
        }

        public override void Executar()
        {
            Console.Write("Informe um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int x = 1;
                var sb = new StringBuilder();
                for (int i = number; i > 0; i--)
                {
                    if (IsPrime(i))
                    {
                        sb.Append($"{i}").Append(" * ");
                        x *= i;
                    }
                }
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 2, 2);
                    sb.Append($"= {x}");
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    Console.WriteLine("Nenhum número primo encontrado no fatorial!");
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            for (int x = 2; x < number; x++)
                if (number % x == 0)
                    return false;
            return true;
        }

    }
}
