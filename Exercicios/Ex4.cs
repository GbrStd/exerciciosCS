namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex4 : Exercicio
    {
        public override string GetDescricao()
        {
            return "4-Faça um programa que leia um número inteiro e informe se ele é primo ou não.";
        }

        public override void Executar()
        {
            Console.Write("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("Digite um número maior que 1!");
                return;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("O número não é primo!");
                    return;
                }
            }

            Console.WriteLine("O número é primo!");
        }
    }
}
