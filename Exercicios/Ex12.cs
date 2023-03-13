namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex12 : Exercicio
    {
        public override string GetDescricao()
        {
            return "12-Crie um programa que exiba na tela os números pares de 0 a 20.";
        }

        public override void Executar()
        {
            IEnumerable<int> even = Enumerable.Range(0, 21).Where(x => x % 2 == 0);
            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
        }
    }
}
