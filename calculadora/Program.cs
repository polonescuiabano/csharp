using calculadora_csharp.Modelo;
string operador;
Console.WriteLine("Escolha o operador: +, -, /, *");
operador = Console.ReadLine();
Console.WriteLine("Digite o primeiro numero");
string n1 =Console.ReadLine();
Console.WriteLine("Digite o segundo numero");
string n2 = Console.ReadLine();

double n3 = Convert.ToDouble(n1);
double n4 = Convert.ToDouble(n2);
Calculadora objCalculadora = new Calculadora(n3, n4);

switch (operador){
    case "+":
        objCalculadora.Somar(0);
    break;
    case "-":
        objCalculadora.Subtrair(0);
    break;
    case "*":
        objCalculadora.Multiplicar(0);
    break;
    case "/":
        if(n4 == 0){
            Console.WriteLine("Seu divisor e igual a 0, retorne um divisor diferente de 0");
        }else{
            objCalculadora.Dividir(0);    
        }      
    break;  
}