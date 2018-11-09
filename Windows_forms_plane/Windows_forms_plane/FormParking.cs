using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms_plane
{
    public partial class FormParking : Form
    {
        
        MultiLevelParking parking;
       
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureBoxField.Width, pictureBoxField.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxMultiParking.Items.Add("Уровень " + (i + 1));
            }
            listBoxMultiParking.SelectedIndex = 0;
            
        }

        private void Draw()
        {
            if (listBoxMultiParking.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxField.Width, pictureBoxField.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxMultiParking.SelectedIndex].Draw(gr);
                pictureBoxField.Image = bmp;
            }
        }



        private void buttonCreateBombardir_Click(object sender, EventArgs e)
        {
            if (listBoxMultiParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Bombardir(100, 1000, dialog.Color);
                    int place = parking[listBoxMultiParking.SelectedIndex] + plane;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }

        }

        private void buttonCreateFighter_Click(object sender, EventArgs e)
        {
            if (listBoxMultiParking.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new fighter(100, 1000, dialog.Color, dialogDop.Color,
                       true, true, true);
                        int place = parking[listBoxMultiParking.SelectedIndex] + plane;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }

        }

        private void buttonSteal_Click(object sender, EventArgs e)
        {
            if (listBoxMultiParking.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var plane = parking[listBoxMultiParking.SelectedIndex] -
                   Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (plane != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        plane.SetPosition(5, 30, pictureBoxParking.Width, pictureBoxParking.Height);
                        plane.DrawPlane(gr);
                        pictureBoxParking.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                       pictureBoxParking.Height);
                        pictureBoxParking.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevelsChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        
    }
}

