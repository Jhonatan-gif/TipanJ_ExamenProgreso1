using System.ComponentModel.DataAnnotations;

namespace TipanJ_ExamenProgreso1.Models
{
    public class Recompensa
    {
        [Key]
        public int IdRecompensa { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }

        public DateTime FechaInicio { get; set; }
        public int PuntosAcumulados { get; set; }
        public string TipoDeRecompensa { get; set; }


    }
}
