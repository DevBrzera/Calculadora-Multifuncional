// VARIAVEL MENU
using System.Diagnostics.Contracts;

string opMenu;
bool sairMenu = true;

// MENU
do {
Console.Clear();
Console.WriteLine("===========================");
Console.WriteLine("CALCULADORA MULTI FUNCIONAL");
Console.WriteLine("===========================\n");
Console.WriteLine("--- MENU ---\n");
Console.WriteLine("Selecione uma opção: \n");
Console.WriteLine("1 - Calculadora Básica\n2 - Calculadora de IMC\n3 - Calculadora de Combustível (Gás/Álcool)\n4 - Sair\n");
Console.Write("Opção -> ");
opMenu = Convert.ToString(Console.ReadLine()!);
if (opMenu == "1") {
    Console.Clear();
    FuncaoCalculadoraBasica();
}
else if (opMenu == "2") {
    Console.Clear();
    FuncaoCalculadoraIMC();
}
else if (opMenu == "3") {
    Console.Clear();
    FuncaoCalculadoraCombustivel();
}
else if (opMenu == "4") {
    Console.Clear();
    Console.WriteLine("Obrigado por utilizar nosso sistema!");
    sairMenu = false;
}
else {
    Console.WriteLine("\nValor Inválido!\n\n");
}
} while (opMenu != "4" && sairMenu);


// CALCULADORA BÁSICA DE 6 OPERAÇÕES:

static void FuncaoCalculadoraBasica() {

// VARIAVEIS
string opCalculadoraBasicaSistema;
bool calculadoraBasicaSistema = true;

// LAYOUT
do {
Console.Clear();
Console.WriteLine("=== CALCULADORA BÁSICA DE 6 OPERAÇÕES ===\n");
Console.WriteLine(" - OPERAÇÕES (+)\n - OPERAÇÕES (-)\n - OPERAÇÕES (X)\n - OPERAÇÕES (/)\n - OPERAÇÕES (*) = POTÊNCIA\n - OPERAÇÕES (%) = RAÍZ\n");

// PROGRAMA
Console.Write("Digite a expressão (ex: 10 + 5): ");
string expressao = Console.ReadLine()!;

string[] partes = expressao.Split(" ");

if (partes.Length != 3) {
    Console.WriteLine("Expressão Inválida! Certifique-se de incluir dois números e uma operação");
}
else {

double num1 = double.Parse(partes[0]);
string operacao = partes[1];
double num2 = double.Parse(partes[2]);

double res = 0;

switch (operacao)
{
    case "+":
        Console.Clear();
        res = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {res}");

        break;

    case "-":
        Console.Clear();
        res = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {res}");
        break;

    case "X":
        Console.Clear();
        res = num1 * num2;
        Console.WriteLine($"{num1} X {num2} = {res}");

        break;

    case "/":
        if (num2 == 0) {
            Console.WriteLine("Valor Inválido para divisão!");
        }
        else {
        Console.Clear();
        res = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {res}");
        }

        break;

    case "*":
        Console.Clear();
        res = Math.Pow(num1, num2);
        Console.WriteLine($"{num1} elevado a {num2} = {res}");

        break;

    case "%":
        Console.Clear();
        res = Math.Pow(num1, (1 / num2));
        Console.WriteLine($"Raíz {num2} de {num1} = {res}");

        break;

    default:
        Console.Clear();
        Console.WriteLine("Operação Inválida!");

        break;
}

}

// RESET
Console.WriteLine("Deseja fazer outra operação?");
Console.WriteLine("1 - Sim\n2 - Não");
opCalculadoraBasicaSistema = Convert.ToString(Console.ReadLine()!);

if (opCalculadoraBasicaSistema == "1") {
    calculadoraBasicaSistema = true;
    Console.Clear();
}
else if (opCalculadoraBasicaSistema == "2") {
    calculadoraBasicaSistema = false;        
    Console.Clear();
}
else {

while (!(opCalculadoraBasicaSistema == "1" || opCalculadoraBasicaSistema == "2")) {
    Console.WriteLine("\nValor Inválido\n");
    Console.WriteLine("Deseja fazer outra operação?");
    Console.WriteLine("1 - Sim\n2 - Não");
    opCalculadoraBasicaSistema = Convert.ToString(Console.ReadLine()!);

    if (opCalculadoraBasicaSistema == "1") {
    calculadoraBasicaSistema = true;
    Console.Clear();
}
else if (opCalculadoraBasicaSistema == "2") {
    calculadoraBasicaSistema = false;        
    Console.Clear();
}

}

}
 
}
while (calculadoraBasicaSistema);

}

// CALCULADORA DE IMC:


static void FuncaoCalculadoraIMC() {
// VARIAVEIS
double peso, altura, imc;
string opCalculadoraIMCSistema;
bool calculadoraIMCSistema = true;

// PROGRAMA
do {
Console.WriteLine("=== CALCULADORA DE IMC ===\n\n");
Console.Write("Digite o peso (KG): ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura (m): ");
altura = Convert.ToDouble(Console.ReadLine());

// CALCULOS
imc = peso / (altura * altura);

// TABELA IMC
if (imc < 18.5) {
    Console.WriteLine("\nClassificação: Baixo Peso\n\n");
}
else if (imc >= 18.5 && imc < 24.9) {
    Console.WriteLine("\nClassificação: Peso Normal\n\n");
}
else if (imc >= 25 && imc < 29.9) {
    Console.WriteLine("\nClassificação: Excesso de Peso\n\n");
}
else if (imc >= 30 && imc < 34.9) {
    Console.WriteLine("\nClassificação: Obesidade classe I\n\n");
}
else if (imc >= 35 && imc < 39.9) {
    Console.WriteLine("\nClassificação: Obesidade classe II\n\n");
}
else if (imc > 40) {
    Console.WriteLine("\nClassificação: Obesidade Mórbida\n\n");
}

// RESET
Console.WriteLine("Deseja fazer outra operação?");
Console.WriteLine("1 - Sim\n2 - Não");
opCalculadoraIMCSistema = Convert.ToString(Console.ReadLine()!);

if (opCalculadoraIMCSistema == "1") {
    calculadoraIMCSistema = true;
    Console.Clear();
}
else if (opCalculadoraIMCSistema == "2") {
    calculadoraIMCSistema = false;        
    Console.Clear();
}
else {

while (!(opCalculadoraIMCSistema == "1" || opCalculadoraIMCSistema == "2")) {
    Console.WriteLine("\nValor Inválido\n");
    Console.WriteLine("Deseja fazer outra operação?");
    Console.WriteLine("1 - Sim\n2 - Não");
    opCalculadoraIMCSistema = Convert.ToString(Console.ReadLine()!);

    if (opCalculadoraIMCSistema == "1") {
    calculadoraIMCSistema = true;
    Console.Clear();
}
else if (opCalculadoraIMCSistema == "2") {
    calculadoraIMCSistema = false;        
    Console.Clear();
}

}

}

} while (calculadoraIMCSistema);

}


// CALCULADORA DE COMBUSTÍVEL:


static void FuncaoCalculadoraCombustivel() {
// VARIAVEIS
double precoGasolina, precoAlcool, litrosGasolina, litrosAlcool, custoTotalGasolina, custoTotalAlcool;
string combustivelEconomico, opCalculadoraCombustivelSistema;
bool calculadoraCombustivelSistema = true;

// PROGRAMA
do {
Console.WriteLine("=== CALCULADORA DE COMBUSTÍVEL (GÁS/ÁLCOOL) ===\n");
Console.Write("Digite o preço da gasolina: ");
precoGasolina = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o preço do álcool: ");
precoAlcool = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de litros de gasolina: ");
litrosGasolina = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de litros de álcool: ");
litrosAlcool = Convert.ToDouble(Console.ReadLine());

// CALCULO
custoTotalGasolina = precoGasolina * litrosGasolina;

custoTotalAlcool = precoAlcool * litrosAlcool;

// MAIS ECONOMICO
if (custoTotalAlcool < custoTotalGasolina) {
    combustivelEconomico = "Álcool";
}
else if (custoTotalAlcool > custoTotalGasolina) {
    combustivelEconomico = "Gasolina";
}
else {
    combustivelEconomico = "Ambos tem o mesmo custo";
}

// RESULTADOS
Console.WriteLine($"\n\nCusto total de abastecimento de gasolina: R$ {custoTotalGasolina}\n\n");
Console.WriteLine($"Custo total de abastecimento de álcool: R$ {custoTotalAlcool}\n\n");
Console.WriteLine($"Combustível mais econômico: {combustivelEconomico}\n\n");

// RESET
Console.WriteLine("Deseja fazer outra operação?");
Console.WriteLine("1 - Sim\n2 - Não");
opCalculadoraCombustivelSistema = Convert.ToString(Console.ReadLine()!);

if (opCalculadoraCombustivelSistema == "1") {
    calculadoraCombustivelSistema = true;
    Console.Clear();
}
else if (opCalculadoraCombustivelSistema == "2") {
    calculadoraCombustivelSistema = false;        
    Console.Clear();
}
else {

while (!(opCalculadoraCombustivelSistema == "1" || opCalculadoraCombustivelSistema == "2")) {
    Console.WriteLine("\nValor Inválido\n");
    Console.WriteLine("Deseja fazer outra operação?");
    Console.WriteLine("1 - Sim\n2 - Não");
    opCalculadoraCombustivelSistema = Convert.ToString(Console.ReadLine()!);

    if (opCalculadoraCombustivelSistema == "1") {
    calculadoraCombustivelSistema = true;
    Console.Clear();
}
else if (opCalculadoraCombustivelSistema == "2") {
    calculadoraCombustivelSistema = false;        
    Console.Clear();
}

}

}

} while (calculadoraCombustivelSistema);

}