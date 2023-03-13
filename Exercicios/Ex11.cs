namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex11 : Exercicio
    {
        public override string GetDescricao()
        {
            return "11-Crie um programa que exiba na tela os números de 1 a 10.";
        }

        public override void Executar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
