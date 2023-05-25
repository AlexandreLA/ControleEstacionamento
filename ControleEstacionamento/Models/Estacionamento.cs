namespace ControleEstacionamento.Models
{
    public class Estacionamento
    {
        private List<Carro> carros;

        public Estacionamento()
        {
            carros = new List<Carro>();
        }

        public List<Carro> ObterCarros()
        {
            return carros;
        }

        public void AdicionarCarro(Carro carro)
        {
            carros.Add(carro);
        }

        public void RemoverCarro(Carro carro)
        {
            carros.Remove(carro);
        }
    }
}
