using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManagementApp.Models;

namespace ExpenseManagementApp
{
    public AddExpenseTypeForm()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtNewExpenseType.Text))
        {
            MessageBox.Show("Harcama türü boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using (var context = new ExpenseDbContext())
        {
            var newExpenseType = new ExpenseType { Name = txtNewExpenseType.Text };
            context.ExpenseTypes.Add(newExpenseType);
            context.SaveChanges();
        }

        MessageBox.Show("Yeni harcama türü eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
