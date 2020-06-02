using System.Data.Entity;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.DBModel
{
     public class NewsContext : DbContext
     {
          public NewsContext() : base("name=eUseControl")
          {
          }

          public virtual DbSet<News> New { get; set; }
     }
}
