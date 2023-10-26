namespace Proyecto_Medicos.Models
{
    public class Usuarios
    {
        public string? nombre { get; set; }   
        public string? correo { get; set; }
        public string? clave { get; set; }
        public Rol idRol { get; set; }

    }
}
