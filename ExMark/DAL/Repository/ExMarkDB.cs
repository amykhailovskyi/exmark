using System.Data.Entity;
using DAL.Models;

namespace DAL.Repository
{
    public class ExMarkDB : DbContext
    {
        public DbSet<Progress> Progresses { get; set; }
    }
}