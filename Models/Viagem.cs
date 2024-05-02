using SQLite;
namespace custoViagem.Models
{
    public class Viagem
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Local { get; set; }
    }
}
