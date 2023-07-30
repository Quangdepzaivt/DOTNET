using System.ComponentModel.DataAnnotations.Schema;
namespace WebApp.Models;
[Table("Category")]
public class Category
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CategoryId")]
    public byte Id { get; set; }
    [Column("CategoryName")]
    public string Name { get; set; } = null!;
}