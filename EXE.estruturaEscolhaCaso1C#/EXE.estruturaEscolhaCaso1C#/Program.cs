//Exercícios Para "Estrutura Escolha-Caso"

int dia = 1;


Console.WriteLine("Digite o numero corresponde ao mes");
dia = Convert.ToInt16(Console.ReadLine());

switch (dia)
{

    case 1:
        Console.WriteLine("Domingo");
        break;

    case 2:
        Console.WriteLine("Segunda");
        break;

    case 3:
        Console.WriteLine("Terça");
        break;

    case 4:
        Console.WriteLine("Quarta");
        break;

    case 5:
        Console.WriteLine("Quinta");
        break;

    case 6:
        Console.WriteLine("sexta");
        break;

    case 7:
        Console.WriteLine("Sabado");
        break;
    default:
        Console.WriteLine("op invalida");
        break;

}