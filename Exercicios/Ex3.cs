namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex3 : Exercicio
    {
        public override string GetDescricao()
        {
            return "3-Faça um programa que leia três números e informe qual deles é o maior.";
        }

        public override void Executar()
        {
            Console.Write("Insira o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            float num3 = float.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O primeiro número é o maior!");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O segundo número é o maior!");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O terceiro número é o maior!");
            }
            else
            {
                Console.WriteLine("Os números são iguais!");
            }
        }

    }
}
