namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex24 : Exercicio
    {
        public override string GetDescricao()
        {
            return "24-Crie um programa que solicite ao usuário um número e exiba na tela se ele é um número palíndromo ou não.";
        }

        public override void Executar()
        {
            Console.Write("Informe um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine("É palíndromo");
                }
                else
                {
                    Console.WriteLine("Não é palíndromo");
                }
            }
        }

        private static bool IsPalindrome(int number)
        {
            if (GetNumberIndex(number, 1) == 0)
                return false;
            int digits = CountNumberDigits(number);
            for (int i = 0; i < digits; i++)
            {
                if (GetNumberIndex(number, i + 1) != GetNumberIndex(number, digits - i))
                    return false;
                if (i > digits / 2)
                    break;
            }
            return true;
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
