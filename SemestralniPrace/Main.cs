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
    public partial class Main : Form
    {
        public static ZaznamyOddeleni oddeleni = new ZaznamyOddeleni();
        public static ZaznamyZakaznik zakaznici = new ZaznamyZakaznik();
        public static Kniha kni;
        public static Oddeleni oddel;
        public static Zakaznik zak;
        public static Kniha vypujc;
        public Main()
        {
            Oddeleni od1 = new Oddeleni("A");
            Oddeleni od2 = new Oddeleni("B");
            od1.addKniha(new Kniha("RUR", "Čapek", "123"));
            od1.addKniha(new Kniha("Bílá Nemoc", "Čapek", "25"));
            od1.addKniha(new Kniha("Válka s mloky", "Čapek", "62362"));
            od1.addKniha(new Kniha("Nevím", "Čapek", "7237"));

            od2.addKniha(new Kniha("Babička", "Němcová", "325"));
            od2.addKniha(new Kniha("Fakt nevím", "Random", "7234"));

            Zakaznik z1 = new Zakaznik("Patrik", zakaznici.Count);
            zakaznici.Add(z1);
            Zakaznik z2 = new Zakaznik("Adam", zakaznici.Count);
            zakaznici.Add(z2);
            oddeleni.Add(od1);
            oddeleni.Add(od2);




            InitializeComponent();
            refreshOddeleni();
            refreshZakaznici();
            comboBox1.DataSource = Enum.GetValues(typeof(EnumCombo.Combo));
        }
        private void AddOnClick(object sender, EventArgs e)
        {
            int volba = comboBox1.SelectedIndex;
            AddEdit addEdit = new AddEdit(volba,false);
            addEdit.ShowDialog();
            refreshOddeleni();
            refreshZakaznici();


        }

        private void EditOnClick(object sender, EventArgs e)
        {
            int volba = comboBox1.SelectedIndex;
            switch(volba)
            {
                case 0:
                    if(LVoddeleni.SelectedItems.Count > 0)
                    {
                        oddel = oddeleni[LVoddeleni.SelectedItems[0].Index];
                    }else
                    {
                        MessageBox.Show("Není vybráno oddělení");
                    }
                    //oddeleni
                    break;
                case 1:
                    if (LVknihy.SelectedItems.Count > 0)
                    {
                        if (LVoddeleni.SelectedItems.Count > 0)
                        {
                            oddel = oddeleni[LVoddeleni.SelectedItems[0].Index];
                            kni = oddel.knihy[LVknihy.SelectedItems[0].Index];
                        }else
                        {
                            MessageBox.Show("Není vybrané oddělení");
                        }
                    }else
                    {
                        MessageBox.Show("Není vybrána kniha");
                    }
                    //knihy
                    break;
                case 2:
                    if (LVzakaznici.SelectedItems.Count > 0)
                    {
                       zak = zakaznici[LVzakaznici.SelectedItems[0].Index];
                    }else
                    {
                        MessageBox.Show("Není vybrán zákazník");
                    }
                    //zakaznici
                    break;
                case 3:
                    if (LVvypujc.SelectedItems.Count > 0)
                    {
                        if (LVzakaznici.SelectedItems.Count > 0)
                        {
                            zak = zakaznici[LVzakaznici.SelectedItems[0].Index];
                            vypujc=zak.Pujcene[LVvypujc.SelectedItems[0].Index];
                        }
                        else
                        {
                            MessageBox.Show("Není vybrán zákazník");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Není vybráná výpůjčka");
                    }
                    //vypujcky
                    break;
            }
            AddEdit addEdit = new AddEdit(volba,true);
            addEdit.ShowDialog();
            refreshOddeleni();
            refreshZakaznici();
            LVknihy.Items.Clear();
            LVvypujc.Items.Clear();
        }

        private void DeleteOnClick(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (LVoddeleni.SelectedItems.Count > 0)
                    {
                        oddeleni.Remove(LVoddeleni.SelectedItems[0].Index);
                        refreshOddeleni();
                        LVknihy.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Není vybráno oddělení");
                    }
                    //oddeleni
                    break;
                case 1:
                    if (LVoddeleni.SelectedItems.Count > 0)
                    {
                        Oddeleni o = oddeleni[LVoddeleni.SelectedItems[0].Index];
                        if (LVknihy.SelectedItems.Count > 0)
                        {
                            Kniha k = o.knihy[LVknihy.SelectedItems[0].Index];
                            o.removeKniha(k);
                            refreshKnihy(o);
                            refreshOddeleni();
                        }
                        else
                        {
                            MessageBox.Show("Není vybráná kniha");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Není vybráno oddělení");
                    }
                    //knihy
                    break;
                case 2:
                    if (LVzakaznici.SelectedItems.Count > 0)
                    {
                        zakaznici.Remove(LVzakaznici.SelectedItems[0].Index);
                        refreshZakaznici();
                    }
                    else
                    {
                        MessageBox.Show("Není vybrán zákazník");
                    }
                    //zakaznici
                    break;
                case 3:
                    if (LVzakaznici.SelectedItems.Count > 0)
                    {
                        Zakaznik z = zakaznici[LVzakaznici.SelectedItems[0].Index];
                        if (LVvypujc.SelectedItems.Count > 0)
                        {
                            Kniha k = z.Pujcene[LVvypujc.SelectedItems[0].Index];
                            z.RemoveVypujcku(k);
                            refreshZakaznici();
                            refreshVypujcky(z);
                        }
                        else
                        {
                            MessageBox.Show("Není vybrána výpůjčka");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Není vybrán zákazník");
                    }
                    //vypujcky
                    break;
                default:
                    break;
            }

        }
        private void oddActive(object sender, MouseEventArgs e)
        {
            refreshKnihy(oddeleni[LVoddeleni.Items.IndexOf(LVoddeleni.SelectedItems[0])]);
        }

        private void vrat_Click(object sender, EventArgs e)
        {

            if (LVoddeleni.SelectedItems.Count > 0)
            {
                Oddeleni o = oddeleni[LVoddeleni.SelectedItems[0].Index];
                if (LVzakaznici.SelectedItems.Count > 0)
                {
                    Zakaznik z = zakaznici[LVzakaznici.SelectedItems[0].Index];
                    if (LVvypujc.SelectedItems.Count > 0)
                    {
                        Kniha k = z.Pujcene[LVvypujc.SelectedItems[0].Index];
                        z.RemoveVypujcku(k);
                        o.addKniha(k);
                        refreshKnihy(o);
                        refreshZakaznici();
                        refreshVypujcky(z);

                    }
                    else
                    {
                        MessageBox.Show("Není vybrána výpůjčka");
                    }
                }
                else
                {
                    MessageBox.Show("Není vybrán zákazník");
                }
            } else
            {
                MessageBox.Show("Není vybráno oddělení");
            }
        }

        private void vypujci_Click(object sender, EventArgs e)
        {
            if (LVoddeleni.SelectedItems.Count > 0)
            {
                Oddeleni o = oddeleni[LVoddeleni.SelectedItems[0].Index];
                if (LVknihy.SelectedItems.Count > 0)
                {
                    Kniha k = o.knihy[LVknihy.SelectedItems[0].Index];
                    if (LVzakaznici.SelectedItems.Count > 0)
                    {
                        Zakaznik z = zakaznici[LVzakaznici.SelectedItems[0].Index];
                        z.AddVypujcku(k);
                        o.removeKniha(k);

                        refreshVypujcky(z);
                        refreshZakaznici();
                        refreshKnihy(o);
                    }
                    else
                    {
                        MessageBox.Show("Není vybrán zákazník");
                    }
                }
                else
                {
                    MessageBox.Show("Není vybráná kniha");
                }
            } else
            {
                MessageBox.Show("Není vybráno oddělení");
            }
        }
        private void refreshOddeleni()
        {
            LVoddeleni.Items.Clear();
            foreach (var item in oddeleni.oddeleni)
            {
                ListViewItem lvi = new ListViewItem(item.Nazev);
                lvi.SubItems.Add(item.Count + "");
                LVoddeleni.Items.Add(lvi);
            }
        }
        private void refreshKnihy(Oddeleni o)
        {
            LVknihy.Items.Clear();
            foreach (Kniha item in o.knihy)
            {
                ListViewItem lvi = new ListViewItem(item.Nazev);
                lvi.SubItems.Add(item.Autor + "");
                lvi.SubItems.Add(item.ISBN + "");
                LVknihy.Items.Add(lvi);
            }
        }
        private void refreshVypujcky(Zakaznik z)
        {
            LVvypujc.Items.Clear();
            foreach (var item in z.Pujcene)
            {
                ListViewItem lvi = new ListViewItem(item.Nazev);
                lvi.SubItems.Add(item.Autor);
                lvi.SubItems.Add(item.ISBN);



                LVvypujc.Items.Add(lvi);
            }
        }
        private void refreshZakaznici()
        {
            LVzakaznici.Items.Clear();
            foreach (var item in zakaznici.zakaznici)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Id + "");
                lvi.SubItems.Add(item.Vypujceno + "");
                LVzakaznici.Items.Add(lvi);
            }
        }

        private void zakActive(object sender, MouseEventArgs e)
        {
            refreshVypujcky(zakaznici[LVzakaznici.SelectedItems[0].Index]);
        }

        private void uloz_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Knihovna evidence (*.kev) | *.kev";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveLoad sl = new SaveLoad(sfd.FileName, oddeleni, zakaznici);
                sl.Save();
            }
        }

        private void nacti_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Knihovna evidence (*.kev) | *.kev";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SaveLoad sl = new SaveLoad(ofd.FileName,oddeleni,zakaznici);
                sl.Load(out oddeleni,out zakaznici);
            }
            refreshZakaznici();
            refreshOddeleni();
            LVknihy.Items.Clear();
            LVvypujc.Items.Clear();

        }
    }
}
