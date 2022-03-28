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
    public partial class AddEdit : Form
    {
        public string Label1Text
        {
            get{ return this.label1.Text; }
            set{ this.label1.Text = value;}
        }
        public string Label2Text
        {
            get { return this.label2.Text; }
            set { this.label2.Text = value; }
        }
        public string Label3Text
        {
            get { return this.label3.Text; }
            set { this.label3.Text = value; }
        }
        public string Label4Text
        {
            get { return this.label4.Text; }
            set { this.label4.Text = value; }
        }
        public AddEdit()
        {

            InitializeComponent();
        }

        private void OkOnClick(object sender, EventArgs e)
        {

        }
    }
}
