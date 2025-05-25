namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
                Console.WriteLine("Os Hóspedes foram cadastrados na suite com sucesso");
            }
            else
            {
                // Implementado
                throw new Exception("O número de hóspedes é maior do que a capacidade máxima da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Implementado 
            if (DiasReservados >= 10)
            {
                //suponhamso que seja 300 o valor total, entao ficaria 300 * 0.1 = 30 , depois decrementa 30 de 300 = 270
                valor -= valor * 0.10m; 
            }

            return valor;
        }
    }
}