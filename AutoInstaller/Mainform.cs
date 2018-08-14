using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInstaller
{
    public partial class Mainform : Form
    {
        //string[] location;
        List<string> locationblock = new List<string>();
        int index = 0;
        string txtline = "";
        public Mainform()
        {
            InitializeComponent();
        }
        public List<Tolt> lstTolt = new List<Tolt>();
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader route = new StreamReader(@"C:\Users\azsizsi1\Desktop\közösapp\AutoInstaller\AutoInstaller\txt\installroutes.txt");
                while ((txtline = route.ReadLine()) != null)
                {
                    string[] database = txtline.Split(';');
                    lstTolt.Add(new Tolt(database[0], database[1], database[2]));
                    ItemChooser.Items.Add(new Tolt(database[0], database[1], database[2]));
                }
                route.Close();
                ItemChooser.DataSource = lstTolt;
                ItemChooser.DisplayMember = "Name";
                //MessageBox.Show((ItemChooser.Items[] as Tolt).Path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void starter_Click(object sender, EventArgs e)
        {
            if (ItemChooser.CheckedItems.Count == 0)
            {
                MessageBox.Show("No items checked! \nPlease check items for install.");
            }
            else
            {
                installstarter();
            }
        }

        public void LocationSaver(string location)
        {
            locationblock.Add(location);
            index++;
        }
        public void LocationRemover(string remove)
        {
            locationblock.Remove(remove);
            index--;
        }
        public void installstarter()
        {
            for (int i = 0; i < index; i++)
            {
                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo();
                    psInfo.FileName = locationblock[i];
                    using (Process install = Process.Start(psInfo))
                    {
                        install.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ItemChooser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CheckState.Checked == ItemChooser.GetItemCheckState(e.Index))
            {
                ItemList.Items.Remove((ItemChooser.Items[e.Index] as Tolt).Name);
                LocationRemover((ItemChooser.Items[e.Index] as Tolt).Path);
            }
            else
            {
                ItemList.Items.Add((ItemChooser.Items[e.Index] as Tolt).Name);
                LocationSaver((ItemChooser.Items[e.Index] as Tolt).Path);
            }
        }
    }

    public class Tolt  
    {
        
        public string Name { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }

        public Tolt(string name, string version, string path)
        {
            Name = name;
            Version = version;
            Path = path;
        }
    }
}


