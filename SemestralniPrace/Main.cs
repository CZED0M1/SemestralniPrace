using SemestralniPrace.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralniPrace
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(EnumCombo.Combo));
        }
        private void AddOnClick(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            //záleží co se vybere v CB
            addEdit.Label1Text = "Úprava";
            addEdit.ShowDialog();

        }

        private void EditOnClick(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.ShowDialog();
        }

        private void DeleteOnClick(object sender, EventArgs e)
        {

        }
    }
}
