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
    public partial class FormPlaneConfig : Form
    {
        ITransport plane = null;
        private event planeDelegate eventAddPlane;
        public FormPlaneConfig()
        {
            InitializeComponent();

            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlaneConfig.Width, pictureBoxPlaneConfig.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 35, pictureBoxPlaneConfig.Width, pictureBoxPlaneConfig.Height);
                plane.DrawPlane(gr);
                pictureBoxPlaneConfig.Image = bmp;
            }
        }

        public void AddEvent(planeDelegate ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new planeDelegate(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void labelBombardir_MouseDown(object sender, MouseEventArgs e)
        {
            labelBombardir.DoDragDrop(labelBombardir.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelFighter_MouseDown(object sender, MouseEventArgs e)
        {
            labelFighter.DoDragDrop(labelFighter.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelBoxPlaneConfig_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            
        }

        private void panelBoxPlaneConfig_DragDrop(object sender, DragEventArgs e)
        {

            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Bombardir":
                    plane = new Bombardir(100, 500, Color.White);
                    break;
                case "Fighter":
                    plane = new fighter(100, 500, Color.White, Color.Black, true);
                    break;
            }
           DrawPlane();
        }

        private ITransport GetData(Type type)
        {
            throw new NotImplementedException();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is fighter)
                {
                    if (e.Data.GetDataPresent(typeof(Color)))
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                    else
                    {
                        e.Effect = DragDropEffects.None;
                    }
                }
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is fighter)
                {
                    (plane as fighter).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }
            }
        }

        private void buttonCreatePlane_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }

    }
}
