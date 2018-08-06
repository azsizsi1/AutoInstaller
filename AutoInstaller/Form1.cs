using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//      Severity Code    Description Project File Line    Suppression State
//Error CS0111  Type 'Form1' already defines a member called 'InitializeComponent' with the same parameter types AutoInstaller   C:\Users\azsizsi1\Desktop\közösapp\AutoInstaller\AutoInstaller\Form1.Designer.cs	29	N/A


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            /*BeleírtamTeszt*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
