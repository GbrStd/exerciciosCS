namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex25 : Exercicio
    {
        public override string GetDescricao()
        {
            return "25-Crie um programa que solicite ao usuário uma palavra e exiba na tela se ela é um palíndromo ou não.";
        }

        public override void Executar()
        {
            Console.Write("Informe uma palavra: ");

            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine("É palíndromo");
            }
            else
            {
                Console.WriteLine("Não é palíndromo");
            }
        }

        private static bool IsPalindrome(string? text)
        {
            if (text == null)
                return false;
            return text.Equals(new string(text.Reverse().ToArray()));
        }

    }
}
