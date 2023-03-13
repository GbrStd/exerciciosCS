namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex2 : Exercicio
    {
        public override string GetDescricao()
        {
            return "2-Faça um programa que leia um número inteiro e informe se ele é par ou ímpar.";
        }

        public override void Executar()
        {

            Console.Write("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }
        }

    }
}
