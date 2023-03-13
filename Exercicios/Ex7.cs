namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex7 : Exercicio
    {

        public override string GetDescricao()
        {
            return "7-Faça um programa que calcule o fatorial de um número informado pelo usuário.";
        }

        public override void Executar()
        {

            Console.Write("Informe um número: ");
            int number = int.Parse(Console.ReadLine());

            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine($"O fatorial de {number} é: {result}");
        }
    }
}
