// See https://aka.ms/new-console-template for more information

// 6º Questão

Console.Write("Informe o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());

double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine($"A área do círculo é {area:F2}.");