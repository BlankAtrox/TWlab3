using System.Data.Entity;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DBModel
{
     public class TopuriContext : DbContext
     {
          public TopuriContext() : base("name=eUseControl")
          {
          }

          public virtual DbSet<Topuris> Topuri { get; set; }
     }
}
