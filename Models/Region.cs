using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prueba_tecnica.Models
{
    [Table("Region")]
    public class Region
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }


        public List<Province> Provinces { get; } = new List<Province>();
    }
}
