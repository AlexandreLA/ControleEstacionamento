namespace ControleEstacionamento.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime? HoraSaida { get; set; }
    }
}
