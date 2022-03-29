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
        public Main()
        {
            Oddeleni od1 = new Oddeleni("ahoj");
            Oddeleni od2 = new Oddeleni("čau");
            oddeleni.Add(od1);
            oddeleni.Add(od2);




            InitializeComponent();
            for (int i = 0; i < oddeleni.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(oddeleni[i].Nazev);
                lvi.SubItems.Add(oddeleni[i].Count + "");
                LVoddeleni.Items.Add(lvi);
            }
            comboBox1.DataSource = Enum.GetValues(typeof(EnumCombo.Combo));
        }
        private void AddOnClick(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.Label1Text = "Úprava";
            addEdit.ShowDialog();
            LVoddeleni.Items.Clear();
            for (int i = 0; i < oddeleni.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(oddeleni[i].Nazev);
                lvi.SubItems.Add(oddeleni[i].Count + "");
                LVoddeleni.Items.Add(lvi);
            }
            

        }

        private void EditOnClick(object sender, EventArgs e)
        {
            AddEdit addEdit = new AddEdit();
            addEdit.ShowDialog();
        }

        private void DeleteOnClick(object sender, EventArgs e)
        {
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
