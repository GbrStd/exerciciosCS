namespace ExerciciosFaculdade.Exercicios
{
    internal class Ex1 : Exercicio
    {
        public override string GetDescricao()
        {
            return "1-Faça um programa que receba dois números e retorne a soma, a subtração, a multiplicação e a divisão entre eles.";
        }

        public override void Executar()
        {
            Console.Write("Insira o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos números é: {0}", num1 + num2);
            Console.WriteLine("A subtração dos números é: {0}", num1 - num2);
            Console.WriteLine("A multiplicação dos números é: {0}", num1 * num2);
            if (num2 <= 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                Console.WriteLine("A divisão dos números é: {0}", num1 / num2);
            }
        }

    }
}
