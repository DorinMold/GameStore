using System;
using System.ComponentModel.DataAnnotations;

namespace Gamestore.Client.Models;

public class Game 
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(25)]
    public string Genre { get; set; } = string.Empty;
    [Range(10, 100)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}