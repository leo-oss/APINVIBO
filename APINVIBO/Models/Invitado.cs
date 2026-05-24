using System.ComponentModel.DataAnnotations;

namespace APINVIBO.Models
{
    public class Invitado
    {
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellido { get; set; }

        public bool Asistira { get; set; }

        public bool LlevaAcompanante { get; set; }

        public string? NombreAcompanante { get; set; }

        public string? TipoInvitado { get; set; }

        public int CantidadNinos { get; set; }
    }
}