namespace AutoInstaller
{
    partial class Form1
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
            "Outlook",
            "Directx",
            "Appshare"});
            this.ItemChooser.Location = new System.Drawing.Point(13, 13);
            this.ItemChooser.Name = "ItemChooser";
            this.ItemChooser.ScrollAlwaysVisible = true;
            this.ItemChooser.Size = new System.Drawing.Size(570, 349);
            this.ItemChooser.TabIndex = 0;
            this.ItemChooser.SelectedIndexChanged += new System.EventHandler(this.ItemChooser_SelectedIndexChanged);
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
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(745, 373);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.ItemChooser);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ItemChooser;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button starter;
    }
}

