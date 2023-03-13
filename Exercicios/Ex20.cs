namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex20 : Exercicio
    {
        public override string GetDescricao()
        {
            return "20-Crie um programa que solicite ao usuário um número e exiba na tela a sua tabuada de multiplicação e de divisão, de 1 a 10.";
        }

        public override void Executar()
        {
            Console.Write("Escolha um número: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                IEnumerable<int> table = Enumerable.Range(1, 10).Select(x => x * number);
                Console.WriteLine("-----");
                Console.WriteLine("Tabuada de Multiplicacão");
                for (int i = 0; i < table.Count(); i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i + 1, number, table.ElementAt(i));
                }
                Console.WriteLine("-----");
                Console.WriteLine("Tabuada de Divisão");
                for (int i = 0; i < table.Count(); i++)
                {
                    Console.WriteLine("{0} / {1} = {2}", table.ElementAt(i), number, i + 1);
                }
            }
        }
    }
}
