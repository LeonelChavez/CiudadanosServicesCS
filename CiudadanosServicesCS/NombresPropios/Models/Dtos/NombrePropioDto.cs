using System;

namespace CiudadanosServicesCS.NombresPropios.Models.Dtos;

public class NombrePropioDto
{
    public int Id { get; set; }
    public string NombrePropio { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public string UsuarioCreacion { get; set; } = string.Empty;
}
