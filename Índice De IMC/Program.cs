string nome = string.Empty;
int idade;
double imc;
double anodenascimento = 2023;
string rimc = string.Empty;

Console.WriteLine("Dígite o seu nome: ");
nome = Console.ReadLine();

Console.Clear();
Console.WriteLine("Olá " + nome + ", Prazer em conhecelo.");

Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("Você tem: " + idade + " Anos." + " (Aperte enter)");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Digite sua altura: ");
var altura = float.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("Digite seu peso: ");
var peso = float.Parse(Console.ReadLine());


imc = peso / (altura * altura);                 // calculo de IMC
anodenascimento = anodenascimento - idade;      // Calculo da idade


Console.Clear();
if (imc < 18.5)
{
    rimc = "Magreza.";
}
else if (imc >= 18.5 || imc <= 24.9)
{
    rimc = "Saudável.";
}
else if (imc >= 25 || imc <= 29.9)
{
    rimc = "Sobrepeso.";
}
else if (imc <= 30 || imc >= 34.9)
{
    rimc = "Obesidade grau I.";
}
else if (imc <= 35 || imc >= 39.9)
{
    rimc = "Obesidade grau II.";
}
else
{
    rimc = "Obesidade grau III.";
}



Console.WriteLine("Olá " + nome + " é um prazer conhecer-lo melhor.");
Console.WriteLine("Você nasceu em: " + anodenascimento + " e sua idade é: " + idade + " anos.");
Console.WriteLine("O seu peso é: " + peso.ToString("F2") + "Kg" + " e sua antura é: " + altura.ToString("F2") + " Metros.");
Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));
Console.WriteLine(rimc);
Console.WriteLine("Até logo.");