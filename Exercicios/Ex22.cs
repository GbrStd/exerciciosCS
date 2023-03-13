namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex22 : Exercicio
    {
        public override string GetDescricao()
        {
            return "22-Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número de Armstrong ou não.";
        }

        public override void Executar()
        {
            Console.Write("Informe um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int digits = CountNumberDigits(number);
                double sum = 0;
                for (int i = 0; i < digits; i++)
                    sum += Math.Pow(GetNumberIndex(number, i + 1), digits);
                if (sum == number)
                    Console.WriteLine("É um número de Armstrong");
                else
                    Console.WriteLine("Não é um número de Armstrong");
            }
        }

        private static int CountNumberDigits(int number)
        {
            int x = 10;
            int count = 1;
            while ((float)number / x >= 1.0f)
            {
                count++;
                x *= 10;
            }
            return count;
        }

        private static int GetNumberIndex(int number, int place)
        {
            int digits = CountNumberDigits(number);
            int diff = digits - place;
            int x = 1;
            if (diff > 0)
                for (int i = 0; i < diff; i++)
                    x *= 10;
            return (int)Math.Floor((double)(number / x)) % 10;
        }

    }
}
