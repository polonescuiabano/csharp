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

List<string> nomeLista = new List<string>{"Fernando", "Daniely"};
nomeLista.Add("Isabela");

Console.WriteLine("Nomes na lista: ");
for(int i=0; i<nomeLista.Count; i++){
    Console.WriteLine(nomeLista[i]);
}

string nomeVerificar = "Fernando";
if (nomeLista.Contains(nomeVerificar)){
    Console.WriteLine($"O nome {nomeVerificar} esta na lista.");
}else{
    Console.WriteLine($"O nome {nomeVerificar} nao esta na lista.");
}

string nomeRemover = "Daniely";
bool foiRemovido = nomeLista.Remove(nomeRemover);
if(foiRemovido){
    Console.WriteLine($"O nome {nomeRemover} foi removido da lista.");
}else{
    Console.WriteLine($"O nome {nomeRemover} nao foi encontrado na lista.");
}

Console.WriteLine($"Nomes na lista depois da remocao do nome {nomeRemover}");
for (int i=0; i< nomeLista.Count; i++){
    Console.WriteLine(nomeLista[i]);
}




