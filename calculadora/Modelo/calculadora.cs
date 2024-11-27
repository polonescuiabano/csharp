namespace calculadora_csharp.Modelo{
    public class Calculadora{
        private double numero1 {get;set;}
        private double numero2 {get;set;}
        public Calculadora (double numero1, double numero2){
            this.numero1= numero1;
            this.numero2 = numero2;
        }
        public void Somar(double soma){
            soma = numero1+numero2;
            Console.WriteLine(soma);
        }
        public void Subtrair(double subtrair){
            subtrair = numero1 - numero2;
            Console.WriteLine(subtrair);
        }
        public void Multiplicar(double multiplicar){
            multiplicar = numero1 * numero2;
            Console.WriteLine(multiplicar);
        }
        public void Dividir(double dividir){
            dividir = numero1 / numero2;
            Console.WriteLine(dividir);
        }
    }
}