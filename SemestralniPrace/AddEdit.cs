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
        int volbaH = 0;
        public AddEdit(int volba)
        {
            volbaH = volba;
            InitializeComponent();
            switch (volba)
            {
                case 0:
                    //oddeleni
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textAutor.Visible = false;
                    textISBN.Visible = false;
                    comboBox1.Visible = false;
                    break;
                case 1:
                    //knihy
                    break;
                case 2:
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textAutor.Visible = false;
                    textISBN.Visible = false;
                    comboBox1.Visible = false;
                    //zakaznici
                    break;
                case 3:
                    //vypujcky
                    break;
                default: 

                    break;
            }
            for (int i = 0; i < Main.oddeleni.Count; i++)
            {
                comboBox1.Items.Add(Main.oddeleni[i].Nazev);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void OkOnClick(object sender, EventArgs e)
        {
            switch(volbaH)
            {
                case 0:
                    if (!String.IsNullOrEmpty(textNazev.Text))
                    {
                        Oddeleni o = new Oddeleni(textNazev.Text);
                        Main.oddeleni.Add(o);
                        Close();
                    } else MessageBox.Show("Missing parameter");
                    //oddeleni
                    break;
                case 1:
                    //knihy
                    if (!String.IsNullOrEmpty(textNazev.Text) && !String.IsNullOrEmpty(textAutor.Text) && !String.IsNullOrEmpty(textISBN.Text))
                    {
                        Kniha kn = new Kniha(textNazev.Text, textAutor.Text, textISBN.Text);
                        Main.oddeleni[comboBox1.SelectedIndex].addKniha(kn);
                        Close();
                    } else MessageBox.Show("Missing parameter");
                    break;
                case 2:
                    if (!String.IsNullOrEmpty(textNazev.Text))
                    {
                        Zakaznik z = new Zakaznik(textNazev.Text);
                        Main.zakaznici.Add(z);
                        Close();
                    }
                    else MessageBox.Show("Missing parameter");
                    //zakaznici
                    break;
                case 3:
                    //vypujcky
                    break;
                default:
                    break;
            }
            
        }
    }
}
