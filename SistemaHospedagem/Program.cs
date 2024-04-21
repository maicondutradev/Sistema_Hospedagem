namespace SistemaHospedagem
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hospede 1");
            Pessoa p2 = new Pessoa(nome: "Hospede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);

            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            Console.WriteLine($"Hospedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}