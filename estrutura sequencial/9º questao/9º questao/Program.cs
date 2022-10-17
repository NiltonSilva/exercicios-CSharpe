// See https://aka.ms/new-console-template for more information

// 9º Questão

Console.Write("Informe a temperatura em ºF: ");
float tempF = float.Parse(Console.ReadLine());

float tempC = 5 * ((tempF - 32) / 9);

Console.WriteLine($"A temperatura em graus Celsius é {tempC:F2}ºC");