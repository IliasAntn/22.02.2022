using _22._02._2022.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._02._2022.Views
{
    public partial class MainView : Form
    {
        CarController carcontroller = new CarController();

        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = carcontroller.GetAllCars();
        }
    }
}
