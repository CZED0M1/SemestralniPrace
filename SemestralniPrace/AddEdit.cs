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
        //TODO vypujcky add
        int volbaH = 0;
        bool edit;
        public AddEdit(int volba,bool edit)
        {
            this.edit = edit;
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
                        for (int i = 0; i < Main.oddeleni.Count; i++)
                        {
                            comboBox1.Items.Add(Main.oddeleni[i].Nazev);
                        }
                        comboBox1.SelectedIndex = 0;
                        //knihy
                        break;
                    case 2:
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        textAutor.Visible = false;
                        textISBN.Visible = false;
                        comboBox1.Visible = false;
                        label1.Text = "Jméno";
                        //zakaznici
                        break;
                    case 3:
                        label4.Text = "Zákazník";
                        for (int i = 0; i < Main.zakaznici.Count; i++)
                        {
                            comboBox1.Items.Add(Main.zakaznici[i].Name);
                        }
                        comboBox1.SelectedIndex = 0;
                        //vypujcky
                        break;
                    default:
                        break;
                }
            
            if(edit)
            {
                switch (volba)
                {
                    case 0:
                        if (Main.oddel != null)
                        {
                            textNazev.Text = Main.oddel.Nazev;
                        }else
                        {
                            return;
                        }
                        //oddeleni
                        break;
                    case 1:
                        if (Main.kni != null)
                        {
                            textNazev.Text = Main.kni.Nazev;
                            textAutor.Text = Main.kni.Autor;
                            textISBN.Text = Main.kni.ISBN;
                        }else
                        {
                            return;
                        }
                        //knihy
                        break;
                    case 2:
                        if (Main.zak != null)
                        {
                            textNazev.Text = Main.zak.Name;
                        }else
                        {
                            return;
                        }
                        //zakaznici
                        break;
                    case 3:
                        if (Main.vypujc != null)
                        {
                            textNazev.Text = Main.vypujc.Nazev;
                            textAutor.Text = Main.vypujc.Autor;
                            textISBN.Text = Main.vypujc.ISBN;
                        }else
                        {
                            return;
                        }
                        //vypujcky
                        break;
                    default:
                        break;
                }
            }
         
        }

        private void OkOnClick(object sender, EventArgs e)
        {
            switch(volbaH)
            {
                case 0:
                    if (!edit)
                    {
                        if (!String.IsNullOrEmpty(textNazev.Text))
                        {
                            Oddeleni o = new Oddeleni(textNazev.Text);
                            Main.oddeleni.Add(o);
                            Close();
                        }
                        else MessageBox.Show("Missing parameter");
                    }else
                    {
                        Main.oddel.Nazev = textNazev.Text;
                        Close();
                    }
                    //oddeleni
                    break;
                case 1:
                    //knihy
                    if (!edit)
                    {
                        if (!String.IsNullOrEmpty(textNazev.Text) && !String.IsNullOrEmpty(textAutor.Text) && !String.IsNullOrEmpty(textISBN.Text))
                        {
                            Kniha kn = new Kniha(textNazev.Text, textAutor.Text, textISBN.Text);
                            Main.oddeleni[comboBox1.SelectedIndex].addKniha(kn);
                            Close();
                        }
                        else MessageBox.Show("Missing parameter");
                    }else
                    {
                        Main.kni.Nazev= textNazev.Text;
                        Main.kni.ISBN = textISBN.Text;
                        Main.kni.Autor = textAutor.Text;
                        Close();
                    }
                    break;
                case 2:
                    if (!edit)
                    {
                        if (!String.IsNullOrEmpty(textNazev.Text))
                        {
                            Zakaznik z = new Zakaznik(textNazev.Text, Main.zakaznici.Count);
                            Main.zakaznici.Add(z);
                            Close();
                        }
                    else MessageBox.Show("Missing parameter");
                    }
                    else
                    {
                        Main.zak.Name = textNazev.Text;
                        Close();
                    }
                    //zakaznici
                    break;
                case 3:
                    if (!edit)
                    {
                        if (!String.IsNullOrEmpty(textNazev.Text) && !String.IsNullOrEmpty(textAutor.Text) && !String.IsNullOrEmpty(textISBN.Text))
                        {
                            Kniha kn = new Kniha(textNazev.Text, textAutor.Text, textISBN.Text);
                            Main.zakaznici[comboBox1.SelectedIndex].AddVypujcku(kn);
                            Close();
                        }
                        else MessageBox.Show("Missing parameter");
                    }else
                    {
                        Main.vypujc.Nazev = textNazev.Text;
                        Main.vypujc.ISBN = textISBN.Text;
                        Main.vypujc.Autor = textAutor.Text;
                        Close();
                    }
                    //vypujcky
                    break;
                default:
                    break;
            }
            
        }
    }
}
