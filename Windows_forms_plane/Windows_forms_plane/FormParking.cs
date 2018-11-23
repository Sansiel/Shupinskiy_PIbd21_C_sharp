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
        FormPlaneConfig form;
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

        private void buttonSetPlane_Click(object sender, EventArgs e)
        {
            form = new FormPlaneConfig();
            form.AddEvent(AddPlane);
            form.Show();
        }
        private void AddPlane(ITransport plane)
        {
            if (plane != null && listBoxMultiParking.SelectedIndex > -1)
            {
                int place = parking[listBoxMultiParking.SelectedIndex] + plane;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Load_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (parking.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}

