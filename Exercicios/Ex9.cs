namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex9 : Exercicio
    {
        public override string GetDescricao()
        {
            return "9 - Faça um programa que leia um número inteiro e informe se ele é um número perfeito." +
                "Um número perfeito é aquele cuja soma dos seus divisores (exceto ele mesmo) é igual ao próprio número.";
        }

        public override void Executar()
        {

            Console.Write("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Digite um número maior que 0!");
                return;
            }

            int result = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    result += i;
                }
            }

            if (result == num)
            {
                Console.WriteLine("O número é perfeito!");
            }
            else
            {
                Console.WriteLine("O número não é perfeito!");
            }

        }
    }
}
