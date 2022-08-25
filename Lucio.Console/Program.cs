using Lucio.Logic.Actions;

List<double> dados = new()
{
    174,
    170,
    168,
    180,
    163,
    165,
    167,
    162,
    160,
    170,
    177,
    175,
    160,
    174,
    172,
    171,
    178,
    178,
    163,
    178
};

Calc calc = new(dados, 5);

Console.Write(" Dados:");
foreach (var item in calc.Dados)
{
    Console.Write($" {item}");
}
Console.WriteLine();

Console.Write(" ROL:");
foreach (var item in calc.Rol)
{
    Console.Write($" {item}");
}
Console.WriteLine();

Console.Write($" Amplitude total: {calc.AmplitudeTotal}");
Console.WriteLine();

Console.Write($" Amplitude do intervalo: {calc.AmplitudeDoIntervalo}");
Console.WriteLine();

Console.Write("-------------------------------------------------------");
Console.WriteLine();

Console.ReadKey();