using SQLite;
namespace custoViagem.Models
{
    public class Viagem
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Distancia { get; set; }
        public double Rendimento { get; set; }
        public double Preco { get; set; }
    }
}
