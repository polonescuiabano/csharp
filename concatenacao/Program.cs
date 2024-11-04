string nome = "Fernando";
string saudacao = "Ola, "+nome+"! Seja bem vindo.";
Console.WriteLine(saudacao);

//Interpolacao de strings
string nome1= "Fernando";
string saudacao1= $"Ola, {nome1}! Seja bem vindo.";
Console.WriteLine(saudacao1);

//Operador GetType
int numero = 5;
Console.WriteLine(numero.GetType());

//Palavra-chave typeof
Console.WriteLine(typeof(int));

//Metodo Parse
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:"+valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variavel numeroParse e do tipo:"+numero1.GetType());