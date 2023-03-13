namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex6 : Exercicio
    {

        public override string GetDescricao()
        {
            return "6-Faça um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero.";
        }

        public override void Executar()
        {

            Console.Write("Informe um número: ");
            float number = float.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("O número é positivo!");
            }
            else if (number < 0)
            {
                Console.WriteLine("O número é negativo!");
            }
            else
            {
                Console.WriteLine("O número é zero!");
            }

        }
    }
}
