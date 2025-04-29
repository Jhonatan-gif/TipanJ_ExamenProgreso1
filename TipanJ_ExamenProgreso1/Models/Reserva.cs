using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipanJ_ExamenProgreso1.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }

        public bool valorPagar {  get; set; }
        public String InformacionCliente { get; set; }

        [ForeignKey("IdRecompensa")]
        public Recompensa? Recompensa { get; set; }
    }
}
