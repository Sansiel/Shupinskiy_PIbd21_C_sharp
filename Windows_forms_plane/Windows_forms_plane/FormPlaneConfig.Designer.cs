namespace Windows_forms_plane
{
    partial class FormPlaneConfig
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
            this.pictureBoxPlaneConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxTypePlane = new System.Windows.Forms.GroupBox();
            this.labelFighter = new System.Windows.Forms.Label();
            this.labelBombardir = new System.Windows.Forms.Label();
            this.panelForPictureBox = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonCreatePlane = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaneConfig)).BeginInit();
            this.groupBoxTypePlane.SuspendLayout();
            this.panelForPictureBox.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPlaneConfig
            // 
            this.pictureBoxPlaneConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlaneConfig.Location = new System.Drawing.Point(24, 26);
            this.pictureBoxPlaneConfig.Name = "pictureBoxPlaneConfig";
            this.pictureBoxPlaneConfig.Size = new System.Drawing.Size(222, 130);
            this.pictureBoxPlaneConfig.TabIndex = 0;
            this.pictureBoxPlaneConfig.TabStop = false;
            // 
            // groupBoxTypePlane
            // 
            this.groupBoxTypePlane.Controls.Add(this.labelFighter);
            this.groupBoxTypePlane.Controls.Add(this.labelBombardir);
            this.groupBoxTypePlane.Location = new System.Drawing.Point(33, 43);
            this.groupBoxTypePlane.Name = "groupBoxTypePlane";
            this.groupBoxTypePlane.Size = new System.Drawing.Size(186, 167);
            this.groupBoxTypePlane.TabIndex = 1;
            this.groupBoxTypePlane.TabStop = false;
            this.groupBoxTypePlane.Text = "Type of plane";
            // 
            // labelFighter
            // 
            this.labelFighter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFighter.Location = new System.Drawing.Point(11, 104);
            this.labelFighter.Name = "labelFighter";
            this.labelFighter.Size = new System.Drawing.Size(153, 53);
            this.labelFighter.TabIndex = 1;
            this.labelFighter.Text = "Fighter";
            this.labelFighter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFighter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFighter_MouseDown);
            // 
            // labelBombardir
            // 
            this.labelBombardir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBombardir.Location = new System.Drawing.Point(11, 27);
            this.labelBombardir.Name = "labelBombardir";
            this.labelBombardir.Size = new System.Drawing.Size(153, 55);
            this.labelBombardir.TabIndex = 0;
            this.labelBombardir.Text = "Bombardir";
            this.labelBombardir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBombardir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBombardir_MouseDown);
            // 
            // panelForPictureBox
            // 
            this.panelForPictureBox.AllowDrop = true;
            this.panelForPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForPictureBox.Controls.Add(this.labelDopColor);
            this.panelForPictureBox.Controls.Add(this.labelMainColor);
            this.panelForPictureBox.Controls.Add(this.pictureBoxPlaneConfig);
            this.panelForPictureBox.Location = new System.Drawing.Point(252, 43);
            this.panelForPictureBox.Name = "panelForPictureBox";
            this.panelForPictureBox.Size = new System.Drawing.Size(272, 324);
            this.panelForPictureBox.TabIndex = 2;
            this.panelForPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoxPlaneConfig_DragDrop);
            this.panelForPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoxPlaneConfig_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(24, 252);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(221, 55);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Dop Color";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(24, 181);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(222, 54);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Main Color";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(581, 40);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(177, 327);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(98, 238);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(52, 50);
            this.panelOrange.TabIndex = 7;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(23, 239);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(53, 50);
            this.panelGray.TabIndex = 6;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(98, 185);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(53, 47);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(23, 185);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(52, 48);
            this.panelRed.TabIndex = 4;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(98, 121);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(54, 49);
            this.panelBlue.TabIndex = 3;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(23, 121);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(52, 49);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(98, 55);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(55, 51);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(23, 55);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(53, 52);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonCreatePlane
            // 
            this.buttonCreatePlane.Location = new System.Drawing.Point(22, 246);
            this.buttonCreatePlane.Name = "buttonCreatePlane";
            this.buttonCreatePlane.Size = new System.Drawing.Size(99, 33);
            this.buttonCreatePlane.TabIndex = 4;
            this.buttonCreatePlane.Text = "Create";
            this.buttonCreatePlane.UseVisualStyleBackColor = true;
            this.buttonCreatePlane.Click += new System.EventHandler(this.buttonCreatePlane_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(99, 304);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 408);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreatePlane);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelForPictureBox);
            this.Controls.Add(this.groupBoxTypePlane);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlaneConfig)).EndInit();
            this.groupBoxTypePlane.ResumeLayout(false);
            this.panelForPictureBox.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlaneConfig;
        private System.Windows.Forms.GroupBox groupBoxTypePlane;
        private System.Windows.Forms.Label labelFighter;
        private System.Windows.Forms.Label labelBombardir;
        private System.Windows.Forms.Panel panelForPictureBox;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonCreatePlane;
        private System.Windows.Forms.Button buttonCancel;
    }
}