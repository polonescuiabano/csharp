namespace poo_csharp.Modelo{
    public class Moto : Veiculo{
        private bool partidaEletrica {get; set;}
        private bool protetorDeCarenagem {get;set;}

        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool partidaEletrica, bool protetorDeCarenagem): base (marca, modelo, ano, velocidadeAtual){
            this.partidaEletrica = partidaEletrica;
            this.protetorDeCarenagem = protetorDeCarenagem;
        }
        public override void Acelerar(double incremento){
            velocidadeAtual += incremento;
            Console.WriteLine($"A moto acelerou e atingiu a velocidade de {velocidadeAtual} km/h");
        }
        public override void Freiar(double decremento){
            velocidadeAtual -= decremento;
            Console.WriteLine($"A moto desacelerou e atingiu a velocidade de {velocidadeAtual} km/h");
        }
        public void Empinar(){
            Console.WriteLine($"A moto esta empinando");
        }
    }
}