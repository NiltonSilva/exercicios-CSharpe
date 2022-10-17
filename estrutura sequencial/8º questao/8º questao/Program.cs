// See https://aka.ms/new-console-template for more information

// 8º Questão

Console.Write("Informe o valor ganho por hora: ");
float precoHora = float.Parse(Console.ReadLine());
Console.Write("Informe quantas horas foram trabalhadas no mês: ");
float horasTrabalhadas = float.Parse(Console.ReadLine());

float salario = precoHora * horasTrabalhadas;

Console.WriteLine($"O salário a receber é R$ {salario:F2}.");