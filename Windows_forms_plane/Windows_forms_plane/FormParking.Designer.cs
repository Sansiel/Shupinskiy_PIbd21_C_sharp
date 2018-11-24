namespace Windows_forms_plane
{
    partial class FormParking
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
            this.pictureBoxField = new System.Windows.Forms.PictureBox();
            this.groupBoxNavigation = new System.Windows.Forms.GroupBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSteal = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelStealing = new System.Windows.Forms.Label();
            this.listBoxMultiParking = new System.Windows.Forms.ListBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.groupBoxNavigation.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.Location = new System.Drawing.Point(13, 27);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(833, 443);
            this.pictureBoxField.TabIndex = 0;
            this.pictureBoxField.TabStop = false;
            // 
            // groupBoxNavigation
            // 
            this.groupBoxNavigation.Controls.Add(this.pictureBoxParking);
            this.groupBoxNavigation.Controls.Add(this.buttonSteal);
            this.groupBoxNavigation.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxNavigation.Controls.Add(this.labelStealing);
            this.groupBoxNavigation.Location = new System.Drawing.Point(864, 269);
            this.groupBoxNavigation.Name = "groupBoxNavigation";
            this.groupBoxNavigation.Size = new System.Drawing.Size(173, 210);
            this.groupBoxNavigation.TabIndex = 3;
            this.groupBoxNavigation.TabStop = false;
            this.groupBoxNavigation.Text = "Угнать самолет";
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 88);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(173, 112);
            this.pictureBoxParking.TabIndex = 3;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSteal
            // 
            this.buttonSteal.Location = new System.Drawing.Point(20, 57);
            this.buttonSteal.Name = "buttonSteal";

            this.buttonSteal.Size = new System.Drawing.Size(132, 25);
            this.buttonSteal.TabIndex = 2;
            this.buttonSteal.Text = "Угнать";
            this.buttonSteal.UseVisualStyleBackColor = true;
            this.buttonSteal.Click += new System.EventHandler(this.buttonSteal_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(87, 29);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelStealing
            // 
            this.labelStealing.AutoSize = true;
            this.labelStealing.Location = new System.Drawing.Point(6, 29);
            this.labelStealing.Name = "labelStealing";
            this.labelStealing.Size = new System.Drawing.Size(53, 17);
            this.labelStealing.TabIndex = 0;
            this.labelStealing.Text = "Место:";
            // 
            // listBoxMultiParking
            // 
            this.listBoxMultiParking.FormattingEnabled = true;
            this.listBoxMultiParking.ItemHeight = 16;
            this.listBoxMultiParking.Location = new System.Drawing.Point(881, 18);
            this.listBoxMultiParking.Name = "listBoxMultiParking";
            this.listBoxMultiParking.Size = new System.Drawing.Size(123, 100);
            this.listBoxMultiParking.TabIndex = 4;
            this.listBoxMultiParking.SelectedIndexChanged += new System.EventHandler(this.listBoxLevelsChange_SelectedIndexChanged);
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Location = new System.Drawing.Point(881, 124);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(112, 49);
            this.buttonSetPlane.TabIndex = 5;
            this.buttonSetPlane.Text = "Добавить Самолет";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.Load_ToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 482);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.listBoxMultiParking);
            this.Controls.Add(this.groupBoxNavigation);
            this.Controls.Add(this.pictureBoxField);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "АНГАРИЩЕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.groupBoxNavigation.ResumeLayout(false);
            this.groupBoxNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.GroupBox groupBoxNavigation;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSteal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelStealing;
        private System.Windows.Forms.ListBox listBoxMultiParking;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}