// See https://aka.ms/new-console-template for more information

// 4º Questão

Console.Write("Informe a 1º nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.Write("Informe a 2º nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.Write("Informe a 3º nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.Write("Informe a 4º nota: ");
float nota4 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine("A média do aluno é " + media);