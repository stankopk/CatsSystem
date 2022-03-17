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
    }
}
