namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex8 : Exercicio
    {
        public override string GetDescricao()
        {
            return "8-Faça um programa que leia uma string e informe quantas vezes uma determinada letra aparece na string.";
        }

        public override void Executar()
        {

            Console.Write("Informe um texto: ");
            string str = Console.ReadLine();

        GetLetter:
            Console.Write("Informe uma letra: ");
            if (!char.TryParse(Console.ReadLine(), out char letter))
            {
                Console.WriteLine("A letra informada é inválida!");
                goto GetLetter;
            }

            int count = 0;
            foreach (char c in str)
            {
                if (letter.ToString().ToLower() == c.ToString().ToLower())
                {
                    count++;
                }
            }

            Console.WriteLine($"A letra {letter} aparece {count} vezes no texto informado!");
        }
    }
}
