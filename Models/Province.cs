
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace prueba_tecnica.Models
{
    public class Province
    {

        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }


        [Column("Name")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [ForeignKey("FkRegion")]
        public Region region { get; set; }
    }
}
