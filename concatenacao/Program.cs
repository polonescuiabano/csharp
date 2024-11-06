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

//Metodo Convert

string valorTexto1 = "100";
Console.WriteLine("A variavel valorTexto1 e do tipo" + valorTexto1.GetType());

int numeroConvertido = Convert.ToInt32(valorTexto1);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variavel numeroConvertido e do tipo"+numeroConvertido.GetType());

//Metodo ToString
int numero2 = 123;
Console.WriteLine(numero2.GetType());

string numeroComoString = numero2.ToString();
Console.WriteLine(numeroComoString.GetType());


DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

double preco = 29.99;
Console.WriteLine($"o preco e: {preco.ToString("C2")}");

decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new.System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new.System.Globalization.Culture("pt-BR"));
Console.WriteLine(valorBR);
