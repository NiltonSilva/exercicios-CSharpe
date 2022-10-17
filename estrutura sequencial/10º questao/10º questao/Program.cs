// See https://aka.ms/new-console-template for more information

// 10º questao

Console.Write("Informe a temperatura em graus Celsius: ");
float tempC = int.Parse(Console.ReadLine());

float tempF = tempC * 1.8f + 32;

Console.WriteLine($"Temperatura em graus Fahrenheit é {tempF:F2}ºF.");