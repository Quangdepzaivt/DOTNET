using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models;

[Table("Brand")]
public class Brand
{
    //public byte Id{get; set;}
    [Column("BrandId")]
    public byte Id { get; set; }
    [Column("BrandName")]
    public string Name { get; set; } = null!;//Ko chap nhan null
}