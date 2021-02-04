using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSheletr.Models
{
    class AppCtx : DbContext
    {
        public AppCtx() : base("DefaultConnection") { }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
