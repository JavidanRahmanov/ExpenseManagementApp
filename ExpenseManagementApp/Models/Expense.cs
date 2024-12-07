using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagementApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int ExpenseTypeId { get; set; }  // Foreign key
        public ExpenseType ExpenseType { get; set; }  // Navigation property
    }
}
