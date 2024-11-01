using System.Diagnostics.Contracts;

//Tipos de dados primitivos
short ano = 2025;
int contador = 10;
long populacaoMundial = 7800000000;

Console.WriteLine(ano);
Console.WriteLine(contador);
Console.WriteLine(populacaoMundial);

//numeros de ponto flutuante
float temperatura = 43.6f;
double precoProduto = 199.90;

//dados do tipo caracter
char inicial = 'F';

//tipos de dados logicos
bool isLogged = true;
bool active = false;

//tipos de dados nao primitivos
string saudacao = "Ola mundo!";

//arrays
int[] numeros = {1, 2, 3, 4, 5};
string[] nomes = {"Fernando", "Suzana", "Daniely"};

//classes

public class Pessoa
{
    public string Nome;
    public int idade;
}

//Structs
public class Ponto
{
    public int x;
    public int y;
}

//enums
public enum diaDaSemana
{
    Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
}

//interface
public interface IVeiculo
{
    void Mover();
}

//delegates
public delegate void Processar(int numero);

//Nullable types
int? idade = null;

