// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;
// Console.WriteLine("Numeros no array");
// for( int i=0; i< meuArray.Length; i++){
//     Console.WriteLine(meuArray[i]);
// }

// List<string> nomeLista = new List<string>{"Fernando", "Daniely"};
// nomeLista.Add("Isabela");

// Console.WriteLine("Nomes na lista: ");
// for(int i=0; i<nomeLista.Count; i++){
//     Console.WriteLine(nomeLista[i]);
// }

// string nomeVerificar = "Fernando";
// if (nomeLista.Contains(nomeVerificar)){
//     Console.WriteLine($"O nome {nomeVerificar} esta na lista.");
// }else{
//     Console.WriteLine($"O nome {nomeVerificar} nao esta na lista.");
// }

// string nomeRemover = "Daniely";
// bool foiRemovido = nomeLista.Remove(nomeRemover);
// if(foiRemovido){
//     Console.WriteLine($"O nome {nomeRemover} foi removido da lista.");
// }else{
//     Console.WriteLine($"O nome {nomeRemover} nao foi encontrado na lista.");
// }

// Console.WriteLine($"Nomes na lista depois da remocao do nome {nomeRemover}");
// for (int i=0; i< nomeLista.Count; i++){
//     Console.WriteLine(nomeLista[i]);
// }

// HashSet<int> conjunto = new HashSet<int> {1,2,3};
// conjunto.Add(4);
// conjunto.Add(2);

// Console.WriteLine("Elementos do conjunto");
// foreach (int elemento in conjunto){
//     Console.WriteLine(elemento);
// }

// HashSet<string> frutas = new HashSet<string> {"Abacaxi", "Abacate", "Banana"};
// frutas.Add("Abacaxi");
// frutas.Add("Manga");

// Console.WriteLine("Frutas no conjunto: ");
// foreach (string fruta in frutas){
//     Console.WriteLine(fruta);
// }

// Console.WriteLine("\nVerificacao de existencia: ");
// Console.WriteLine(frutas.Contains("Abacaxi") ? "Abacaxi esta no conjunto": "Abacaxi nao esta no conjunto");

// frutas.Remove("Banana");
// Console.WriteLine("\nApos remover banana");
// foreach (string fruta in frutas){
//     Console.WriteLine(fruta);
// }

// exercicios

int[] numeros = {1,2,3,4,5};
int soma =0;
foreach(int numero in numeros){
    soma = soma+numero;
}

Console.WriteLine(soma);

// List<string> nomes = new List<string> {"Jeane", "Wanderson", "Jeane", "Ryan", "Jeane"};

// foreach(string nome in nomes){
//     if(nome=="Jeane"){
//         int contador = contador+1
//     }
// }
// Console.WriteLine(contador);

// List<int> numeros = new List<int>{1,2,2,3,4,4,5};
// var hashset = new HashSet<int>(numeros);
// foreach(int numero in hashset){
//     Console.WriteLine(numero);
// }


// HashSet<string> frutas = new HashSet<string> {"Manga", "Banana", "Laranja"};
// if(frutas.Contains("Banana")){
//     Console.WriteLine("Banana esta no conjunto");
// }else{
//     Console.WriteLine("Banana nao esta no conjunto"); 
// }

// List<int> numeros = new List<int>();
// for(int i = 1; i<6; i++){
//     numeros.Add(i);
// }
// foreach(int numero in numeros){
//     Console.WriteLine(numero);
// }




