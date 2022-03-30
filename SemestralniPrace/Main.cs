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

            Zakaznik z1 = new Zakaznik("Patrik",zakaznici.Count);
            zakaznici.Add(z1);
            Zakaznik z2 = new Zakaznik("Adam",zakaznici.Count);
            zakaznici.Add(z2);
            oddeleni.Add(od1);
            oddeleni.Add(od2);




            InitializeComponent();
            for (int i = 0; i < oddeleni.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(oddeleni[i].Nazev);
                lvi.SubItems.Add(oddeleni[i].Count + "");
                LVoddeleni.Items.Add(lvi);
            }
            for (int i = 0; i < zakaznici.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(zakaznici[i].Name);
                lvi.SubItems.Add(zakaznici[i].Id + "");
                lvi.SubItems.Add(zakaznici[i].Vypujceno + "");
                LVzakaznici.Items.Add(lvi);
            }
            comboBox1.DataSource = Enum.GetValues(typeof(EnumCombo.Combo));
        }
        private void AddOnClick(object sender, EventArgs e)
        {
            int volba = comboBox1.SelectedIndex;
            AddEdit addEdit = new AddEdit(volba);
            addEdit.ShowDialog();
            LVoddeleni.Items.Clear();
            for (int i = 0; i < oddeleni.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(oddeleni[i].Nazev);
                lvi.SubItems.Add(oddeleni[i].Count + "");
                LVoddeleni.Items.Add(lvi);
            }
            LVzakaznici.Items.Clear();
            for (int i = 0; i < zakaznici.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(zakaznici[i].Name);
                lvi.SubItems.Add(zakaznici[i].Id + "");
                lvi.SubItems.Add(zakaznici[i].Vypujceno+"");
                LVzakaznici.Items.Add(lvi);
            }


        }

        private void EditOnClick(object sender, EventArgs e)
        {
            int volba = comboBox1.SelectedIndex;
            AddEdit addEdit = new AddEdit(volba);
            addEdit.ShowDialog();
        }

        private void DeleteOnClick(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    //oddeleni
                    oddeleni.Remove(LVoddeleni.SelectedItems[0].Index);
                    LVoddeleni.Items.Clear();
                    for (int i = 0; i < oddeleni.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(oddeleni[i].Nazev);
                        lvi.SubItems.Add(oddeleni[i].Count + "");
                        LVoddeleni.Items.Add(lvi);
                    }
                    LVknihy.Items.Clear();
                    break;
                case 1:
                    //knihy
                    break;
                case 2:
                    //zakaznici
                    zakaznici.Remove(LVzakaznici.SelectedItems[0].Index);
                    LVzakaznici.Items.Clear();
                    for (int i = 0; i < zakaznici.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(zakaznici[i].Name);
                        lvi.SubItems.Add(zakaznici[i].Id + "");
                        lvi.SubItems.Add(zakaznici[i].Vypujceno + "");
                        LVzakaznici.Items.Add(lvi);
                    }
                    break;
                case 3:
                    //vypujcky
                    break;
                default:
                    break;
            }
           
        }
        private void oddActive(object sender, MouseEventArgs e)
        {
            LVknihy.Items.Clear();
            foreach (var item in oddeleni[LVoddeleni.Items.IndexOf(LVoddeleni.SelectedItems[0])].knihy)
            {
                ListViewItem lvi = new ListViewItem(item.Nazev);
                lvi.SubItems.Add(item.Autor);
                lvi.SubItems.Add(item.ISBN);
                LVknihy.Items.Add(lvi);

            }
        }
    }
}
