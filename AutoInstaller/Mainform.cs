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
        string txtline = "";
        public List<Tolt> lstTolt = new List<Tolt>();

        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader route = new StreamReader(@"C:\Users\frudnic3\source\repos\AutoInstallerMain\AutoInstaller\txt\installroutes.txt");
                while ((txtline = route.ReadLine()) != null)
                {
                    string[] database = txtline.Split(';');
                    lstTolt.Add(new Tolt(database[0], database[1], database[2]));
                    ItemChooser.Items.Add(new Tolt(database[0], database[1], database[2]));
                }
                route.Close();
                ItemChooser.DataSource = lstTolt;
                ItemChooser.DisplayMember = "Name";
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
                Installstarter();
            }
        }
        
        private void Installstarter()
        {
            for (int i = 0; i < ItemChooser.CheckedItems.Count; i++)
            {
                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo();
                    psInfo.FileName = (ItemChooser.CheckedItems[i] as Tolt).Path; // locationblock[i];
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
            if (ItemChooser.GetItemCheckState(e.Index) == CheckState.Checked)
            {
                ItemList.Items.Remove((ItemChooser.Items[e.Index] as Tolt).Name);
            }
            else
            {
                ItemList.Items.Add((ItemChooser.Items[e.Index] as Tolt).Name);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


