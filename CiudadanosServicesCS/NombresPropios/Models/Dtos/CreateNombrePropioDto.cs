using System;
using System.ComponentModel.DataAnnotations;

namespace CiudadanosServicesCS.NombresPropios.Models.Dtos;

public class CreateNombrePropioDto
{
    [Required( ErrorMessage = "El nombre propio es obligatorio.")]
    [MaxLength(60, ErrorMessage = "El nombre propio no puede exceder los 60 caracteres.")]
    [MinLength(3, ErrorMessage = "El nombre propio no puede tener menos de 3 caracteres.")]
    public string NombrePropio { get; set; } = string.Empty;

    [Required(ErrorMessage = "El usuario de creación es obligatorio.")]
    [MaxLength(60, ErrorMessage = "El usuario de creación no puede exceder los 60 caracteres.")]
    [MinLength(3, ErrorMessage = "El usuario de creación no puede tener menos de 3 caracteres.")]
    public string UsuarioCreacion { get; set; } = string.Empty;
}
