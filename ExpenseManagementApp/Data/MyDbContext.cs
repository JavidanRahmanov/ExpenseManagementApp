using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManagementApp.Models;

namespace ExpenseManagementApp.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public MyDbContext() : base("name=MyDbContext") // Bağlantı dizesini buraya yazın
        {
        }
    }
}
