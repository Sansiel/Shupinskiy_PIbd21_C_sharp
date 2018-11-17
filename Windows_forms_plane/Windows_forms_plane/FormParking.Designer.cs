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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUpgrate = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSteal = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).BeginInit();
            this.groupBox.SuspendLayout();
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
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(884, 31);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(132, 59);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Припарковать маленький бомбардировщик";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonUpgrate
            // 
            this.buttonUpgrate.Location = new System.Drawing.Point(884, 96);
            this.buttonUpgrate.Name = "buttonUpgrate";
            this.buttonUpgrate.Size = new System.Drawing.Size(132, 55);
            this.buttonUpgrate.TabIndex = 2;
            this.buttonUpgrate.Text = "Припарковать Истребитель";
            this.buttonUpgrate.UseVisualStyleBackColor = true;
            this.buttonUpgrate.Click += new System.EventHandler(this.buttonUpgrate_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxParking);
            this.groupBox.Controls.Add(this.buttonSteal);
            this.groupBox.Controls.Add(this.maskedTextBoxNumber);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Location = new System.Drawing.Point(864, 269);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(173, 210);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Угнать самолет";
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 88);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(173, 112);
            this.pictureBoxParking.TabIndex = 3;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonUpgrate
            // 
            this.buttonSteal.Location = new System.Drawing.Point(20, 57);
            this.buttonSteal.Name = "buttonUpgrate";
            this.buttonSteal.Size = new System.Drawing.Size(132, 25);
            this.buttonSteal.TabIndex = 2;
            this.buttonSteal.Text = "Угнать";
            this.buttonSteal.UseVisualStyleBackColor = true;
            this.buttonSteal.Click += new System.EventHandler(this.buttonSteal_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(87, 29);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(65, 22);
            this.maskedTextBoxNumber.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 482);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonUpgrate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxField);
            this.Name = "FormParking";
            this.Text = "АНГАРИЩЕ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxField)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxField;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUpgrate;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSteal;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label label;
    }
}