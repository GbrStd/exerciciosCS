namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex10 : Exercicio
    {
        public override string GetDescricao()
        {
            return "10-Faça um programa que leia uma lista de números e informe qual é o segundo maior número da lista";
        }

        public override void Executar()
        {

            var listNumbers = new List<float>();

        BeginLoop:
            string answer = string.Empty;
            do
            {
                Console.Write("Informe um número: ");

                if (float.TryParse(Console.ReadLine(), out float number))
                {
                    listNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                    goto BeginLoop;
                }

                Console.Write("Deseja informar outro número? (S/N): ");

                answer = Console.ReadLine().ToUpper();

                if (answer != "S" && listNumbers.Count < 2)
                {
                    Console.WriteLine("Informe mais 1 número!");
                    goto BeginLoop;
                }

            } while (answer == "S");

            // Acha o maior numero da lista
            float max = listNumbers.Max();

            float secondMax = float.MinValue;
            float diff = max - secondMax;

            // Acha o segundo maior numero, comparando a diferenca com o primeiro maior
            for (int i = 0; i < listNumbers.Count; i++)
            {
                if (listNumbers[i] == max)
                    continue;

                if (max - listNumbers[i] < diff)
                {
                    diff = max - listNumbers[i];
                    secondMax = listNumbers[i];
                }
            }

            Console.WriteLine($"O segundo maior número é: {secondMax}");

            /*
            // Remover o maior numero da lista
            listNumbers.Remove(listNumbers.Max());

            // Achar o segundo maior numero
            Console.WriteLine($"O segundo maior número é: {listNumbers.Max()}");
             */

        }
    }
}
