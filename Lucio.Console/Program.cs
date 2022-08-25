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

Console.Write($" Intervalo: {calc.Intervalo}");
Console.WriteLine();
Console.WriteLine();

Console.Write(" ROL:");
foreach (var item in calc.Rol)
{
    Console.Write($" {item}");
}
Console.WriteLine();

Console.Write($" Quantidade total: {calc.Dados.Count}");
Console.WriteLine();

Console.Write($" Amplitude total: {calc.AmplitudeTotal}");
Console.WriteLine();

Console.WriteLine($" Amplitude do intervalo: {calc.AmplitudeDoIntervalo}");
Console.WriteLine();

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();

Console.WriteLine(" Dados         fi   Fi   fr   Fr");
Console.WriteLine();

for (int i = 0; i < calc.Table.Count; i++)
{
    if (i != calc.Table.Count - 1)
    {
        Console.WriteLine($" {calc.Table[i].LenghtIntervalo.valor1} |-  {calc.Table[i].LenghtIntervalo.valor2}    {calc.Table[i].Fi1}   {calc.Table[i].Fi2}");
    }
    else
    {
        Console.WriteLine($" {calc.Table[i].LenghtIntervalo.valor1} |-| {calc.Table[i].LenghtIntervalo.valor2}    {calc.Table[i].Fi1}   {calc.Table[i].Fi2}");
    }
}
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine($" Total:         {calc.Fi1Total}   -");

Console.ReadKey();