namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex19 : Exercicio
    {
        public override string GetDescricao()
        {
            return "19-Crie um programa que exiba na tela a sequência de números primos até 100.";
        }

        public override void Executar()
        {

            for (int i = 2; i < 100; i++)
            {
                bool primo = true;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo)
                    Console.WriteLine($"O {i} número é primo!");
            }

        }
    }
}
