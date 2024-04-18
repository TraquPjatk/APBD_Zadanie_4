using System.ComponentModel.DataAnnotations;

namespace APBD_Zadanie_4;

public class Visit
{
    [Required]
    public Animal Animal { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public int Price { get; set; }
}