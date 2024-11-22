namespace classes.Modelo{
    public class Veiculo{
        string marca;
        string modelo;
        int ano;

        public Veiculo(string marca, string modelo, int ano){
            this.marca= marca;
            this.modelo= modelo;
            this.ano=ano;
        }
        public void Acelerar(){
            Console.WriteLine($"{marca} {modelo} esta acelerando");
        }
        public void Freiar(){
            Console.WriteLine($"{marca} {modelo} esta freiando");
        }
    }
}