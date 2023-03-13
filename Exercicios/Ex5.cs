namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex5 : Exercicio
    {

        public override string GetDescricao()
        {
            return "5-Faça um programa que calcule a média de um conjunto de números informados pelo usuário. O usuário deve informar quantos números deseja informar.";
        }

        public override void Executar()
        {

            var numbers = new List<float>();

        BeginLoop:
            do
            {
                Console.Write("Informe um número: ");

                if (float.TryParse(Console.ReadLine(), out float number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Número inválido!");
                    goto BeginLoop;
                }

                Console.Write("Deseja informar outro número? (S/N): ");

            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine();

            Console.WriteLine($"A média dos números informados é: {numbers.Average()}");
        }
    }
}
