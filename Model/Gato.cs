namespace API_Petshop.Model
{
    //Model de um gato
    public class Gato
    {
        public int ID_Gato { get; set; }
        public string Nome { get; set; }
        public string Cores { get; set; }
        public string Tamanho { get; set; }
        public double Peso { get; set; }
        public string Nascimento { get; set; }
        public string Temperamento { get; set; }
    }
}
