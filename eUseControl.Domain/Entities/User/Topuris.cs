using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities.User
{
     public class Topuris
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }
    
          [Required]
          public string Data { get; set; }

          [Required]
          public string Status { get; set; }

          [Required]
          public float Nota { get; set; }

          [Required]
          public int Anul { get; set; }

          [Required]
          public int Serii { get; set; }

          [Required]
          public string Descriere { get; set; }

          [Required]
          public string Foto { get; set; }


     }
}
