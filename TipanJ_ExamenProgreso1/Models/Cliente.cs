using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TipanJ_ExamenProgreso1.Models
{
    public class Cliente
    {
        [Key]
        [MaxLength(8)]
        public int IdCliente { get; set; }
        [MaxLength(100)]
        [DisplayName("Ingrese el Nombre: ")]
        public String Nombre { get; set; }
        [MaxLength(4)]
        public int DiasHospedaje { get; set; }
        [MaxLength(4)]
        public DateTime FechaDeNacimiento { get; set; }
        public float PuntuacionServicio { get; set; }
        public bool DescuentorPorRecomendacion { get; set; }

        public int IdReserva { get; set; }

        [ForeignKey("IdReserva")]
        public Reserva? Reserva { get; set; }

    }
}
