using System.ComponentModel.DataAnnotations;

namespace PadelGo.Domain.Entities;

public class CourtType
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "El campo tipo de pista no puede ser vacío.")]
    public string Type { get; set; } = null!;

    public bool Active { get; set; } = true;
}