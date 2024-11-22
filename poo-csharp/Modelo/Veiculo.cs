namespace poo_csharp.Modelo{
    public class Veiculo{
        private string marca {get;set;}
        private string modelo {get;set;}
        private int ano {get;set;}
        protected double velocidadeAtual {get;set;}

        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual){
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this velocidadeAtual = velocidadeAtual;
        }
        public void Acelerar(double incremento){
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} km/h");
        }
        public void Freiar(double decremento){
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freiando... Velocidade atual {velocidadeAtual} km/h")
        }
    }
}