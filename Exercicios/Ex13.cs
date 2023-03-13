namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex13 : Exercicio
    {
        public override string GetDescricao()
        {
            return "13-Crie um programa que solicite ao usuário um número e exiba na tela a tabuada desse número, de 1 a 10.";
        }

        public override void Executar()
        {
            Console.Write("Escolha um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                IEnumerable<int> table = Enumerable.Range(1, 10).Select(x => x * number);
                for (int i = 0; i < table.Count(); i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i + 1, number, table.ElementAt(i));
                }
            }
        }
    }
}
