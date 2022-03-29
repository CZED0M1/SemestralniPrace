using SemestralniPrace.Entity;
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
            for (int i = 0; i < Main.oddeleni.Count; i++)
            {
                comboBox1.Items.Add(Main.oddeleni[i].Nazev);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void OkOnClick(object sender, EventArgs e)
        {
            Kniha kn = new Kniha(textNazev.Text, textAutor.Text, textISBN.Text);
            Main.oddeleni[comboBox1.SelectedIndex].addKniha(kn);
            Close();
        }
    }
}
