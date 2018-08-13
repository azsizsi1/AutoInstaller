using System;
using System.Windows.Forms;

namespace AutoInstaller
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemChooser = new System.Windows.Forms.CheckedListBox();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.starter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemChooser
            // 
            this.ItemChooser.FormattingEnabled = true;
            this.ItemChooser.Items.AddRange(new object[] {
            ""});
            this.ItemChooser.Location = new System.Drawing.Point(13, 13);
            this.ItemChooser.Name = "ItemChooser";
            this.ItemChooser.ScrollAlwaysVisible = true;
            this.ItemChooser.Size = new System.Drawing.Size(570, 349);
            this.ItemChooser.TabIndex = 0;
            this.ItemChooser.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemChooser_ItemCheck);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(589, 13);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(153, 316);
            this.ItemList.TabIndex = 1;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // starter
            // 
            this.starter.Location = new System.Drawing.Point(589, 336);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(153, 26);
            this.starter.TabIndex = 2;
            this.starter.Text = "Install Item(s)";
            this.starter.UseVisualStyleBackColor = true;
            this.starter.Click += new System.EventHandler(this.starter_Click);
            // 
            // Mainform
            // 
            this.ClientSize = new System.Drawing.Size(745, 373);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.ItemChooser);
            this.Name = "Mainform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        
        private void ItemChooser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (CheckState.Checked == ItemChooser.GetItemCheckState(e.Index))
            {
                ItemList.Items.Remove(ItemChooser.Items[e.Index].ToString());
            }
            else
            {
                ItemList.Items.Add(ItemChooser.Items[e.Index].ToString());
            }
                                   
        }

        #endregion

        private System.Windows.Forms.CheckedListBox ItemChooser;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button starter;
    }
}

