// See https://aka.ms/new-console-template for more information

// 5º Questão
Console.Write("Informe a medida em metros: ");
float medida = float.Parse(Console.ReadLine());

float medidaEmCm = medida * 100;

Console.WriteLine($"A medida em centrímetros é {medidaEmCm} cm.");