//Operadores aritmeticos
double resultado = 12 + 8 + 12 / 3;
Console.WriteLine(resultado);

double resultado1 = (12 + 8 + 12) / 3;
Console.WriteLine(resultado1);

double resultado2 = (2 + 8) * 2 / 4;
Console.WriteLine(resultado2);

//Operadores lógicos
//E logico
bool a = true;
bool b = false;
Console.WriteLine(a && b);

//Ou logico
bool c = true;
bool d = false;
Console.WriteLine(a || b);

//NOT logico
bool e = true;
Console.WriteLine(!e);

//XOR logico
bool f = true;
bool g = false;
Console.WriteLine(f^g);

//Precedencia de operadores logicos
bool a1 = true;
bool b1 = false;
bool c1 = false;
bool resultado3 = !a1 || (b1&&c1);
Console.WriteLine(resultado3);

bool a2 = false;
bool b2 = false;
bool c2 = false;
bool resultado4 = !a2 || b2&&c2;
Console.WriteLine(resultado4);