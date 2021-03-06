﻿using System;
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemChooser
            // 
            this.ItemChooser.FormattingEnabled = true;
            this.ItemChooser.Location = new System.Drawing.Point(13, 13);
            this.ItemChooser.Name = "ItemChooser";
            this.ItemChooser.ScrollAlwaysVisible = true;
            this.ItemChooser.Size = new System.Drawing.Size(570, 344);
            this.ItemChooser.TabIndex = 0;
            this.ItemChooser.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemChooser_ItemCheck);
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.ItemHeight = 16;
            this.ItemList.Location = new System.Drawing.Point(589, 13);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(153, 276);
            this.ItemList.TabIndex = 1;
            // 
            // starter
            // 
            this.starter.Location = new System.Drawing.Point(589, 295);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(153, 28);
            this.starter.TabIndex = 2;
            this.starter.Text = "Install Item(s)";
            this.starter.UseVisualStyleBackColor = true;
            this.starter.Click += new System.EventHandler(this.starter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(589, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(153, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Mainform
            // 
            this.ClientSize = new System.Drawing.Size(745, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.ItemChooser);
            this.Name = "Mainform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        public System.Windows.Forms.CheckedListBox ItemChooser;
        public System.Windows.Forms.ListBox ItemList;
        public System.Windows.Forms.Button starter;
        private Button btnClose;
    }
}

