//Exercico 1!


using System.Reflection;
using System.Runtime.InteropServices;

static int GetYear()
{
string CurrentYear = DateTime.Now.ToString("yyyy");
int CurrentYear1 = Convert.ToInt32(CurrentYear);
return CurrentYear1;
}

static void CalculoIdade()
{
    Console.WriteLine("Em que ano nasceu?");
    int ano = Convert.ToInt32(Console.ReadLine());

    if (ano<=GetYear())
    {
        int idade = GetYear() -1- ano;
        Console.WriteLine("Tens: "+idade+"!");
    }

    else
    {
        Console.WriteLine("Por favor introduza um ano de nascimento válido.");
    }

}

//CalculoIdade(); 
//Concluido!

//Exercicio2

static void Cumprimentos()
{
    System.Console.WriteLine("******************** Cumprimento ********************");
    Console.Write("Escreva um nome: ");
    string name = Console.ReadLine();
    Console.WriteLine("Olá " + name + "!");
}

//Cumprimentos();

//Concluido!

//Exercicio3


static void ConvertionToCelsius()
{
    System.Console.WriteLine("******************** Fahrenheit ********************");
    Console.Write("Escreva uma temperatura em Fahrenheit: ");
    string far = Console.ReadLine();
    float far1 = float.Parse(far);
    float cel = (((far1 - 32) / 9 *5));   
    Console.WriteLine(far1 + "f = " + cel + " Cº");
    
}
    //ConvertionToCelsius();
// Concluido 


//Exercicio 4

static void NotaFinal()
{
    System.Console.WriteLine("******************** NOta Final *******************");
    const float p1 = (65/100f);
    const float p2 = (15/100f);
    const float p3 = (20/100f);
    float t1;
    float t2;
    float tr1;
    float tr2;
    float tf;
    float nf;
    Console.WriteLine("Qual foi a nota do primeiro teste? ");
    t1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual foi a nota do Segundo  teste? ");
    t2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual foi a nota do primeiro trabalho? ");
    tr1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual foi a nota do segundo trabalho? ");
    tr2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual foi a nota do trabalho final? ");
    tf = float.Parse(Console.ReadLine());

    nf = p1*((t1+t2)/2) + p2*((tr1+tr2)/2) + p3 * tf;
    System.Console.WriteLine("A nota final é de: " + nf + " Valores!");
}   
//NotaFinal();
//Concluido

//Exercicio 5

static void Menu()
{
    string y;
    do
    {
    System.Console.WriteLine();
    System.Console.WriteLine("******************** MENU ********************");
    System.Console.WriteLine();
    System.Console.WriteLine("Qual é o exercicio que quer executar?");
    System.Console.WriteLine();
    System.Console.WriteLine("1 - Cumprimentos ");
    System.Console.WriteLine("2 - Fahrenheit");
    System.Console.WriteLine("3 - Nota Final");
    System.Console.WriteLine("4 - Câmbio");
    System.Console.WriteLine("5 - Numeros");
    System.Console.WriteLine("6 - Ao contrário");
    System.Console.WriteLine();

    string x = System.Console.ReadLine();
    System.Console.WriteLine();

    switch (x)
    {
        case "1": 

        Cumprimentos();
        break;

        case "2":

        ConvertionToCelsius();
        break;

        case "3":

        NotaFinal();
        break;

        case "4":

        Câmbio();
        break;

        case "5":
        Numeros();
        break;

        case "6":
        Backwards();
        break;

        default:
        System.Console.WriteLine("Ecolha uma opção válida!");
        break;
    }
    System.Console.WriteLine("Deseja sair do programa? (s/n)");
    y = System.Console.ReadLine();
    }
    while (y == "n");

}

Menu();

static void Câmbio()
{
    System.Console.WriteLine("******************** Câmbio *******************");
    System.Console.WriteLine("Qual o valor em Euros? ");
    float er = float.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Escolha uma moeda para fazer o Câmbio:");
    System.Console.WriteLine(" 1 - Dollar");
    System.Console.WriteLine(" 2 - Libra");
    System.Console.WriteLine(" 3 - Iene");
    System.Console.WriteLine(" 4 - SEK");
    string answer = System.Console.ReadLine();

    switch (answer)
    {
        case "1":

        float dl = er * 1.08f;
        System.Console.WriteLine(er + " Euros corresponde a: " + dl + " Dolares!");
        break;

        case "2":

        float lb = er * 0.85f;
        System.Console.WriteLine(er + " Euros corresponde a: " + lb + " Libras!");
        break;

        case "3":

        float Ie = er * 163f;
        System.Console.WriteLine(er + " Euros corresponde a: " + Ie + " Ienes!");
        break;

        case "4":

        float sk = er * 11.20f;
        System.Console.WriteLine(er + " Euros corresponde a: " + sk + " SEK!");
        break;

        default:

        System.Console.WriteLine("Por favor introduza uma opção válida!");
        break;

    }
    //Câmbio();
}

//Concluido

//Exercicio 6
static void Numeros()
{

float number;
float totalnumber = 0;
int count = 0; 

do
{
    System.Console.WriteLine("Introduza um número: ");
    number = float.Parse(System.Console.ReadLine());
    count ++;
    totalnumber = totalnumber + number;

} while (number != 0);

System.Console.WriteLine("O total de numeros introduzidos é de: " + (count - 1));
System.Console.WriteLine("A soma de todos os numero introduzidos é: " + totalnumber);
System.Console.WriteLine("A média dos números introduzidos é de: " + (totalnumber/(count - 1)));
}
//Numeros()

//Concluido

//Exercicio 7

static void Backwards()
{
    for (int i = 100; i > 0; i-- )
    {
       System.Console.WriteLine(i); 
    }
}
