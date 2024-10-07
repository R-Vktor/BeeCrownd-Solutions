using System.Globalization;
using System;

// Quando temos um calculo a ser feito que vai ser double temos que ja receber as variáveis fazendo parse para doble, pois o C# nao vai permitir fazer casting posteriormente
double tempo = double.Parse(Console.ReadLine());

double velocidade = double.Parse(Console.ReadLine());

double distancia = velocidade * tempo;

double litros = distancia/12;

Console.WriteLine(litros.ToString("F3",CultureInfo.InvariantCulture));