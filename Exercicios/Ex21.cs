namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex21 : Exercicio
    {
        public override string GetDescricao()
        {
            return "21-Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número triangular ou não.";
        }

        public override void Executar()
        {
            Console.Write("Informe um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int x = 1;
                int sum = 1;
                while (true)
                {
                    x++;
                    sum += x;
                    if (sum > number)
                    {
                        Console.WriteLine("O número não é triangular");
                    }
                    else if (sum == number)
                    {
                        Console.WriteLine("O número é triangular");
                    }
                    else
                    {
                        continue;
                    }

                    break;
                }
            }
        }
    }
}
