namespace MauiAppHotel.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }


    public int DuracaoDias
        {
            get
            {
                TimeSpan diferenca = DataTermino.Date - DataInicio.Date;
                return diferenca.Days >= 0 ? diferenca.Days : 0;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }
    }
}