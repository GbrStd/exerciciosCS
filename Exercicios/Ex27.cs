namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex27 : Exercicio
    {
        public override string GetDescricao()
        {
            return "27-Crie um programa que solicite ao usuário uma frase e exiba na tela a mesma frase, mas invertida.";
        }

        public override void Executar()
        {
            Console.Write("Informe uma palavra: ");

            string text = Console.ReadLine();

            if (text != null)
            {
                Console.WriteLine($"Palavra normal: {text}");
                Console.WriteLine($"Palavra invertida: {new string(text.Reverse().ToArray())}");
            }

        }

    }
}
