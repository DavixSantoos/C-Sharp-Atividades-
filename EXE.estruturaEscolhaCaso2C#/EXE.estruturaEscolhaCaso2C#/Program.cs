//Exercícios para Estrutura Escolha-Caso
//crie um programa que leia o codigo de um produto (1 a 5) e exiba seu nome e preço
int Produto;

Console.WriteLine("Digite o codigo do produto 1 a 5");
Produto = Convert.ToInt16(Console.ReadLine());

switch (Produto) {

    case 1:
        Console.WriteLine("Maça  Preço R$ 2,00");
        break;

    case 2:
        Console.WriteLine("arroz  Preço R$ 5,00");
        break;
    case 3:
        Console.WriteLine("Limao  Preço R$ 7,00");
        break;
    case 4:
        Console.WriteLine("Coca-Cola Preço R$ 6,00");
        break;
    case 5:
        Console.WriteLine("vinho R$ 52,00");
        break;
    default: Console.WriteLine("OP invalida");
        break;
}
