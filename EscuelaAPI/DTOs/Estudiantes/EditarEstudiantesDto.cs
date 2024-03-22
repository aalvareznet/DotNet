namespace EscuelaAPI.DTOs.Estudiantes
{
    public class EditarEstudiantesDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public int Grado { get; set; }
        public int Seccion { get; set; }
        public int ProfesorGuiaId { get; set; }
    }
}
