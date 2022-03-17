using CatsSystem.Controller;
using CatsSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsSystem.View
{
    public partial class MainView : Form
    {
        MainController mainController = new MainController();

        public MainView()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvCats.DataSource = mainController.GetAllCats();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat();
            cat.Name = txtName.Text;
            cat.Age = int.Parse(txtAge.Text);
            mainController.AddCat(cat);
            RefreshTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCats.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Cat cat = new Cat();
            cat.Name = txtName.Text;
            cat.Age = int.Parse(txtAge.Text);
            mainController.UpdateCat(id, cat);
            RefreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCats.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            mainController.DeleteCat(id);
            RefreshTable();
        }

        private void btnShowCatsOlderThan5Years_Click(object sender, EventArgs e)
        {
            dgvCats.DataSource = mainController.ShowCatsOlderThan5Years();
        }

        private void btnShowAllCats_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
