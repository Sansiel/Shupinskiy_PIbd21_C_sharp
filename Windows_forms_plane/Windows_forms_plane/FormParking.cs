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
            parking = new Parking<ITransport>(5, pictureBox1.Width, pictureBox1.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBox1.Image = bmp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Bombardir(100, 1000, dialog.Color);
                int place = parking + car;
                Draw();
            }

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            var car = parking - Convert.ToInt32(maskedTextBox1.Text);
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 30, pictureBox2.Width, pictureBox2.Height);
                car.DrawCar(gr);
                pictureBox2.Image = bmp;
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox2.Width,
               pictureBox2.Height);
                pictureBox2.Image = bmp;
            }
            Draw();
        }


    }
}

