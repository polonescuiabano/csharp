// //Estrutura condicional simples
// double nota1 = 5.5;
// double nota2 = 10;
// double nota3 = 0;
// double media = (nota1+nota2+nota3)/3;

// if (media >= 7){
//     Console.WriteLine($"Media {media:F2}: Aprovado");
// }else{
//     Console.WriteLine($"Media {media:F2}: Recuperacao");
// }

// //Estrutura condicional alinhada: else if
// double nota4 = 5;
// double nota5 = 8.0;
// double nota6 = 5.0;
// double mediaNota=(nota4+nota5+nota6)3;
// if (mediaNota==7){
//     Console.WriteLine($"Media {mediaNota:F2}: Aprovado");
// }
// else if (mediaNota>=5 && mediaNota < 7){
//     Console.WriteLine($"Media {mediaNota:F2}: Recuperacao");
// }
// else{
//     Console.WriteLine($"Media {mediaNota:F2}: Reprovado");
// }

// Console.WriteLine("Digita uma vogal");
// string? letra = Console.ReadLine();
// if (letra =="a" || letra =="A"){
//     Console.WriteLine($"Voce digitou a vogal: {letra}");
// }
// else if(letra =="e" || letra =="E"){
//     Console.WriteLine($"Voce digitou a vogal: {letra}");
// }
// else if(letra =="i" || letra =="I"){
//     Console.WriteLine($"Voce digitou a vogal: {letra}");
// }
// else if(letra =="o" || letra =="O"){
//     Console.WriteLine($"Voce digitou a vogal: {letra}");
// }
// else if(letra =="u" || letra =="U"){
//     Console.WriteLine($"Voce digitou a vogal: {letra}");
// }
// else{
//     Console.WriteLine($"A variavel {letra} nao e uma vogal.");
// }

// //Switch case
// string dia = "segunda";
// switch(dia)
// {
//     case "segunda":
//         Console.WriteLine("Comecou a semana");
//         break;
//     case "sexta":
//         Console.WriteLine("Final de semana esta chegando");
//         break;
//     case "sabado":
//         Console.WriteLine("Final de semana chegou");
//         break;
//     default:
//         Console.WriteLine("Outro dia qualquer");
//         break;
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();
// string letraMinuscula = letra.ToLower();
// switch (letraMinuscula)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra {letraMinuscula} e uma vogal");
//         break;
//     default:
//         Console.WriteLine($"A letra {letraMinuscula} nao e uma vogal");
//         break;
// }

// //Operador ternario
// int idade =18;
// string mensagem = idade >= 18 ? "Maior de idade":"Menor de idade";
// Console.WriteLine(mensagem);


// Console.WriteLine("Digite uma idade:");
// string resp = Console.ReadLine();
// int idade = Convert.ToInt32(resp);

// if (idade>=18){
//     Console.WriteLine("Entrada Permitida");
// }else{
//     Console.WriteLine("A pessoa possui autorizacao do responsavel?");
//     string autorizacao = Console.ReadLine();
//     string auth = autorizacao.ToLower();
//     if (auth=="sim"){
//         autorizacao = "1";
//     }else{
//         autorizacao = "0";
//     }
//     if(idade>=18 || autorizacao == "1"){
//         Console.WriteLine("Entrada permitida");
//     }else{
//         Console.WriteLine("Entrada nao permitida");
//     }
// }

// Console.WriteLine("O aluno possui presenca minima?");
// string? resp = Console.ReadLine();
// string? resp1 = resp.ToLower();
// Console.WriteLine("Digite a nota 1: ");
// string? nota1 = Console.ReadLine();
// Console.WriteLine("Digite a nota 2: ");
// string? nota2 = Console.ReadLine();
// Console.WriteLine("Digite a nota 3: ");
// string? nota3 = Console.ReadLine();

// double nota4 = Convert.ToDouble(nota1);
// double nota5 = Convert.ToDouble(nota2);
// double nota6 = Convert.ToDouble(nota3);

// double media = (nota4+nota5+nota6)/3;

// if(resp=="sim"&& media >=7){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }

Console.WriteLine("Choveu?");
string? resp = Console.ReadLine();
string? resp1 = resp.ToLower();
if(resp1=="sim"){
    bool resultado = true;
    if(!resultado==false){
        Console.WriteLine("Vai pedalar outro dia!");
    }else{  
        Console.WriteLine("Esta tarde?");
        string? resp2 = Console.ReadLine();
        string? resp3 = resp2.ToLower();
        if(resp3=="sim"){
            Console.WriteLine("Vai pedalar outro dia");
        }else{
            Console.WriteLine("Vai pedalar agora!!");
        }
    }
}else{
    Console.WriteLine("Esta tarde?");
        string? resp2 = Console.ReadLine();
        string? resp3 = resp2.ToLower();
        if(resp3=="sim"){
            Console.WriteLine("Vai pedalar outro dia");
        }else{
            Console.WriteLine("Vai pedalar agora!!");
        }
}







