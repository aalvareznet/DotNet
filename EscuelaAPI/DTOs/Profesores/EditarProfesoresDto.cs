﻿namespace EscuelaAPI.DTOs.Profesores
{
    public class EditarProfesoresDto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public int MateriaId { get; set; }
    }
}
