//Exercico 1!


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
    Console.WriteLine(ConvertionToCelsius(far1) + " Cº");
// Concluido 


