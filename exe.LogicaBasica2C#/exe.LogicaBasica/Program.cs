//Exercícios de Lógica Básica
//Escreva um algoritmo que leia dois numeros inteiros e mostre a soma deles

using System;

int nm1;
int nm2;
int soma;

Console.WriteLine("Digite o primeiro numero");
nm1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
nm2 = Convert.ToInt16(Console.ReadLine());

soma = nm1 + nm2;
Console.WriteLine($"O resultado dos números é {soma}");