using ExerciciosFaculdade.Exercicios;

Exercicio[] exercicios = {
    new Ex1(), new Ex2(), new Ex3(), new Ex4(), new Ex5(),
    new Ex6(), new Ex7(), new Ex8(), new Ex9(), new Ex10(),
    new Ex11(), new Ex12(), new Ex13(), new Ex16(), new Ex18(),
    new Ex19(), new Ex20(), new Ex21(), new Ex22(), new Ex23(),
    new Ex24(), new Ex25(), new Ex26(), new Ex27()
};

Console.WriteLine("Escolha um exercício para executar: ");

Console.WriteLine("----");

for (int i = 0; i < exercicios.Length; i++)
{
    Console.WriteLine($"{i + 1} - {exercicios[i].GetType().Name}");
}

Console.WriteLine("----");

Console.Write("Escolhe uma opção: ");

if (int.TryParse(Console.ReadLine(), out int option))
{
    if (option > 0 && option <= exercicios.Length)
    {
        var exe = exercicios[option - 1];
        Console.WriteLine(exe.GetDescricao());
        exe.Executar();
    }
    else
    {
        Console.WriteLine("Exercício não encontrado!");
    }
}
else
{
    Console.WriteLine("Opção inválida!");
}