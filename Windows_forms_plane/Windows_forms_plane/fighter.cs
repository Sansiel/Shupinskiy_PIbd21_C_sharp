using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Windows_forms_plane
{
    class fighter : Bombardir
    {
        public Color DopColor { private set; get; }
        public bool ShoutGun { private set; get; }

        public fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool shoutgun, bool bomba, bool armour) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            ShoutGun = shoutgun;

        }

        public override void DrawCar(Graphics g)
        {

            Brush bru = new SolidBrush(DopColor);
            g.FillEllipse(bru, _startPosX + 20, _startPosY + 5, 10, 20);
            g.FillEllipse(bru, _startPosX + 50, _startPosY - 27, 10, 80);
            g.FillEllipse(bru, _startPosX + 10, _startPosY + 10, 70, 10);

            if (ShoutGun)
            {

                g.FillRectangle(bru, _startPosX + 50, _startPosY - 10, 30, 5);
                g.FillRectangle(bru, _startPosX + 50, _startPosY + 30, 30, 5);

            }

            base.DrawCar(g);

        }
    }
}
