//Exercico 1!


using System.Reflection;

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

CalculoIdade(); 
//Concluido!

//Exercicio2

static void Cumprimentos()
{
    Console.Write("Escreva um nome: ");
    string name = Console.ReadLine();
    Console.WriteLine("Olá " + name + "!");
}

Cumprimentos();

//Concluido!

//Exercicio3


static float ConvertionToCelsius(float far1)
{
    float cel = (((far1 - 32) / 9 *5));   
    return cel;
}

    Console.Write("Escreva uma temperatura em Fahrenheit: ");
    string far = Console.ReadLine();
    float far1 = float.Parse(far);
    Console.WriteLine(far1 + "f = " + ConvertionToCelsius(far1) + " Cº");
// Concluido 


//Exercicio 4

static void NotaFinal()
{
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
NotaFinal();
