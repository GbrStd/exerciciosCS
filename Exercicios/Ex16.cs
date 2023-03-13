namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex16 : Exercicio
    {
        public override string GetDescricao()
        {
            return "16-Crie um programa que solicite ao usuário um número e exiba na tela a sequência de Fibonacci até esse número.";
        }

        public override void Executar()
        {
            Console.Write("Escolha um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int a = 1;
                int b = 0;
                int c = 0;

                for (int i = 0; i < number; i++)
                {
                    c = a + b;
                    if (c > number)
                        break;
                    Console.Write($"{c} ");
                    a = b;
                    b = c;
                }
            }
        }
    }
}
