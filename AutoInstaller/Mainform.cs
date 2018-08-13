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
        public int i = 0;
        string[] location;   //egy szöveges útvonal ez majd a listába lesz
        string txtline = "";    //tomi írta :P
        public Mainform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader route = new StreamReader("txt\\installroutes.txt");
                while ((txtline = route.ReadLine()) != null)
                {
                    string[] database = txtline.Split(';');
                    location[i] = database[2];
                    ItemChooser.Items.Add(new Tolt(database[0], database[1], database[2]));
                    i++;
                }
                route.Close();
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
                Locations start = new Locations();
                start.installstarter();
            }
        }

    }


    public class Locations
    {
        public List<string> locationblock;
        int index = 0;
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
    }
    public class Tolt   //ez az a get-set dolog
    {
        private int i = 0;
        private string[] Name { get; set; }
        private string[] Version { get; set; }
        public string[] Path { get; set; }

        public Tolt(string name, string version, string path)
        {
            Name[i] = name;
            Version[i] = version;
            Path[i] = path;
            i++;
        }
    }
}


