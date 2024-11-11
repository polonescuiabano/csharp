Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1,101);
int contador = 0;
Console.WriteLine($"Numero Alvo: {numero}");

while (contador != numero)
{
    Console.WriteLine($"Contador: {contador}.");
    contador++;
}
Console.WriteLine($"O contador atingiu o numero alvo: {contador}");