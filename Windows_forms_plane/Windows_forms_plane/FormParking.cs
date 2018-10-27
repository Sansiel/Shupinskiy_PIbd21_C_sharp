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
        Parking<ITransport> parking;

        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(5, pictureBoxField.Width, pictureBoxField.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxField.Width, pictureBoxField.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxField.Image = bmp;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Bombardir(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }

        }

        private void buttonUpgrate_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new fighter(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    int place = parking + car;
                    Draw();
                }
            }
        }

        private void buttonSteal_Click(object sender, EventArgs e)
        {
            var car = parking - Convert.ToInt32(maskedTextBoxNumber.Text);
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 30, pictureBoxParking.Width, pictureBoxParking.Height);
                car.DrawCar(gr);
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

