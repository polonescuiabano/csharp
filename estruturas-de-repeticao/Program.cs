// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1,101);
// int contador = 0;
// Console.WriteLine($"Numero Alvo: {numero}");

// while (contador != numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"O contador atingiu o numero alvo: {contador}");

// int numero1 = 0;
// do
// {
//     Console.WriteLine($"Numero: {numero1}");
//     numero1++;
// } while (numero1<=10);

// for(int i=0;i<=10;i++)
// {
//     Console.WriteLine($"Valor de i: {i}");
// }

// string[] nomes = {"Fernando", "Daniely", "Suzana"};
// foreach (string nome in nomes)
// {
//     Console.WriteLine(nome);
// }


// int soma = 0;
// for(int i=1;i<=100;i++)
// {
//     if(i%2==0){
//         soma = soma+i;
//     }
// }
// Console.WriteLine(soma);

// int? i = null;
// for(i=10; i>=1; i--)
// {
//     Console.WriteLine($"Contagem regressiva: {i}");
// }
// Console.WriteLine("Decolar!");

// Console.WriteLine("Escreva uma palavra ou frase");
// string resp = Console.ReadLine().ToLower.Replace("","");
// int contagemVogais = 0;

// foreach (char letra in palavra){
//     if("aeiou".contains(letra)){
//         contagemVogais++;
//     }
// }
// Console.WriteLine(contagemVogais);

// Console.WriteLine("Escreva sua palavra ou frase: ");
// string palavra = Console.ReadLine().ToLower().Replace(" ","");
// string reverso = new string(palavra.Reverse().ToArray());

// if(reverso == palavra){
//     Console.WriteLine("Sua palavra ou frase e um palindromo");
// }else{
//     Console.WriteLine("Nao e um palindromo");
// }


Random random = new Random();
int numeroAleatorio = random.Next(1,101);
int tentativa;
int contador = 0;
bool acertou = false;

Console.WriteLine("Tente adivinhar o numero entre 1 e 100");

while (!acertou){
    Console.WriteLine("Digite seu palpite");
    tentativa = int.Parse(Console.ReadLine());

    if(tentativa< numeroAleatorio){
        Console.WriteLine("O numero e maior");
        contador++;
    }
    else if (tentativa > numeroAleatorio){
        Console.WriteLine("O numero e menor");
        contador++;
    }
    else{
        contador++;
        Console.WriteLine($"Parabens, vc acertou depois de {contador} tentativas");
        acertou = true;
    }
}




