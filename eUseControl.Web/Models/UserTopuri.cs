using System.Web;

namespace eUseControl.Web.Models
{
     public class UserTopuri
     {
          public string Data { get; set; }
          public string Status { get; set; }
          public float Nota { get; set; }
          public int Anul { get; set; }
          public int Serii { get; set; }
          public string Descriere { get; set; }
          public string Foto { get; set; }

          public HttpPostedFileBase ImageFile { get; set; }

     }
}