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

        public int CountOfPrograms = 0;   //ez lesz a cilkus számlálója az ellenörzésnél
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
                StreamReader route = File.OpenText("C:/desktop/installroutes.txt");
                while ((txtline = route.ReadLine()) != null)
                {
                    string[] database = txtline.Split(';');
                    ItemChooser.Items.Add(new Tolt(database[0], database[1], database[2]));
                    location[CountOfPrograms+1] = Convert.ToString(database[2]);
                    CountOfPrograms++; 
                }
                route.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            /*Ide kéne megírni a beolvasást, hogy már a form betöltésénél legyen 
             adat a ItemChooser-ben. Try-catch-ben mindenképpen */
            

            }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ItemChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public bool ListDisplay (int index)
        {

            if (ItemChooser.GetItemCheckState == CheckState.Checked)
                {

                    return true;
                }
                else
                {
                    return false;
                }
           
        }
    }


    public class Tolt   //ez az a get-set dolog
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
