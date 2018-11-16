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

            this.buttonCreateBombardir = new System.Windows.Forms.Button();
            this.buttonCreateFighter = new System.Windows.Forms.Button();
            this.groupBoxNavigation = new System.Windows.Forms.GroupBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSteal = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelStealing = new System.Windows.Forms.Label();
            this.listBoxMultiParking = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.groupBoxNavigation.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxField
            // 
            this.pictureBoxField.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxField.Name = "pictureBoxField";
            this.pictureBoxField.Size = new System.Drawing.Size(833, 457);
            this.pictureBoxField.TabIndex = 0;
            this.pictureBoxField.TabStop = false;
            // 
            // buttonCreateBombardir
            // 
            this.buttonCreateBombardir.Location = new System.Drawing.Point(873, 143);
            this.buttonCreateBombardir.Name = "buttonCreateBombardir";
            this.buttonCreateBombardir.Size = new System.Drawing.Size(132, 59);
            this.buttonCreateBombardir.TabIndex = 1;
            this.buttonCreateBombardir.Text = "Припарковать маленький бомбардировщик";
            this.buttonCreateBombardir.UseVisualStyleBackColor = true;
            this.buttonCreateBombardir.Click += new System.EventHandler(this.buttonCreateBombardir_Click);
            // 
            // buttonCreateFighter
            // 
            this.buttonCreateFighter.Location = new System.Drawing.Point(873, 208);
            this.buttonCreateFighter.Name = "buttonCreateFighter";
            this.buttonCreateFighter.Size = new System.Drawing.Size(132, 55);
            this.buttonCreateFighter.TabIndex = 2;
            this.buttonCreateFighter.Text = "Припарковать Истребитель";
            this.buttonCreateFighter.UseVisualStyleBackColor = true;
            this.buttonCreateFighter.Click += new System.EventHandler(this.buttonCreateFighter_Click);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 482);
            this.Controls.Add(this.listBoxMultiParking);
            this.Controls.Add(this.groupBoxNavigation);
            this.Controls.Add(this.buttonCreateFighter);
            this.Controls.Add(this.buttonCreateBombardir);

            this.Controls.Add(this.pictureBoxField);
            this.Name = "FormParking";
            this.Text = "АНГАРИЩЕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.groupBoxNavigation.ResumeLayout(false);
            this.groupBoxNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.Button buttonCreateBombardir;
        private System.Windows.Forms.Button buttonCreateFighter;
        private System.Windows.Forms.GroupBox groupBoxNavigation;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSteal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelStealing;
        private System.Windows.Forms.ListBox listBoxMultiParking;

    }
}