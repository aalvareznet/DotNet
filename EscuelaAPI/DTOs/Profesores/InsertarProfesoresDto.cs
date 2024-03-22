namespace EscuelaAPI.DTOs.Profesores
{
    public class InsertarProfesoresDto
    {
        public string? Nombre { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public int MateriaId { get; set; }
    }
}
