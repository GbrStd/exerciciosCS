using System.Text.RegularExpressions;

namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex18 : Exercicio
    {
        public override string GetDescricao()
        {
            return "18-Crie um programa que solicite ao usuário uma frase e exiba na tela quantas vezes cada letra aparece na frase.";
        }

        public override void Executar()
        {
            Console.Write("Escreva uma frase: ");

            string text = Console.ReadLine();

            if (text != null && text.Trim().Length > 0)
            {
                Regex.Replace(text, @"\s+", "");

                var lettersCount = new Dictionary<char, int>();

                foreach (char letter in text)
                {
                    if (lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter]++;
                    }
                    else
                    {
                        lettersCount.Add(letter, 1);
                    }
                }

                for (int i = 0; i < lettersCount.Count(); i++)
                {
                    var element = lettersCount.ElementAt(i);
                    Console.WriteLine($"{element.Key} = {element.Value}");
                }

            }
        }
    }
}
