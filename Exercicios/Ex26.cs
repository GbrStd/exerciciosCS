namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex26 : Exercicio
    {
        public override string GetDescricao()
        {
            return "26-Crie um programa que solicite ao usuário um número e exiba na tela a sua decomposição em números decimais.";
        }

        public override void Executar()
        {

            Console.Write("Informe um número: ");

            if (double.TryParse(Console.ReadLine(), out double number))
            {
                string numberStr = number.ToString();

                string? decimalStr = null;

                if (number - Math.Floor(number) > 0.0)
                {
                    string[] split = numberStr.Split(',');
                    numberStr = split[0];
                    decimalStr = split[1];
                }

                int lIntegerPlaces = numberStr.Length;

                Console.Write($"{number} = ");

                for (int i = 0; i < lIntegerPlaces; i++)
                {
                    Console.Write($"{numberStr[i]}{new string('0', lIntegerPlaces - (i + 1))} ");
                    if (i + 1 != lIntegerPlaces)
                        Console.Write("+ ");
                }

                if (decimalStr != null)
                {
                    int rDecimalPlaces = decimalStr.Length;
                    for (int i = 0; i < rDecimalPlaces; i++)
                        Console.Write($"+ 0,{new string('0', i)}{decimalStr[i]} ");
                }
            }

        }

    }
}
