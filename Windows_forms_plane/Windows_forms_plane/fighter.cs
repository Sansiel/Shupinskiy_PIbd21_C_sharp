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
        public fighter(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                ShoutGun = Convert.ToBoolean(strs[4]);
            }
        }

        public override void DrawPlane(Graphics g)
        {

            Brush bru = new SolidBrush(DopColor);
            g.FillEllipse(bru, _startPosX + 20, _startPosY + 5, 10, 20);
            g.FillEllipse(bru, _startPosX + 50, _startPosY - 20, 10, 70);
            g.FillEllipse(bru, _startPosX + 10, _startPosY + 10, 70, 10);

            if (ShoutGun)
            {

                g.FillRectangle(bru, _startPosX + 50, _startPosY - 10, 30, 5);
                g.FillRectangle(bru, _startPosX + 50, _startPosY + 30, 30, 5);

            }

            base.DrawPlane(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + DopColor + ";" + ShoutGun;
        }
    }
}
