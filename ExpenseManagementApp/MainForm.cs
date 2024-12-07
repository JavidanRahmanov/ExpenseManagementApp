using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManagementApp.Data;
using ExpenseManagementApp.Models;

namespace ExpenseManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadExpenseTypes();
            LoadExpenses();
        }

        private void LoadExpenseTypes()
        {
            using (var context = new MyDbContext())
            {
                var expenseTypes = context.ExpenseTypes.ToList();
                cmbExpenseType.DataSource = expenseTypes;
                cmbExpenseType.DisplayMember = "Name";
                cmbExpenseType.ValueMember = "Id";
            }
        }

        private void LoadExpenses()
        {
            using (var context = new MyDbContext())
            {
                var expenses = context.Expenses
                    .Select(e => new
                    {
                        e.Id,
                        ExpenseType = e.ExpenseType.Name,
                        e.Amount,
                        e.ExpenseDate
                    })
                    .ToList();

                dgvExpenses.DataSource = expenses;
            }
        }

        private void btnAddExpenseType_Click(object sender, EventArgs e)
        {
            AddExpenseTypeForm form = new AddExpenseTypeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadExpenseTypes();
            }
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            if (cmbExpenseType.SelectedItem == null || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Harcama türü ve tutarını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new MyDbContext())
            {
                var expense = new Expense
                {
                    ExpenseTypeId = (int)cmbExpenseType.SelectedValue,
                    Amount = decimal.Parse(txtAmount.Text),
                    ExpenseDate = DateTime.Now
                };

                context.Expenses.Add(expense);
                context.SaveChanges();
            }

            MessageBox.Show("Harcama kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExpenses();
        }
    }
}
