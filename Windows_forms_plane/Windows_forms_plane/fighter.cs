using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Windows_forms_plane
{
    class fighter : Bombardir, IComparable<Bombardir>, IEquatable<Bombardir>
    {
        public Color DopColor { private set; get; }
        public bool ShoutGun { private set; get; }

        public fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool shoutgun) : base(maxSpeed, weight, mainColor)
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
            return base.ToString() + ";" + DopColor.Name + ";" + ShoutGun;
        }
        public int CompareTo(fighter other)
        {
            var res = (this is Bombardir).CompareTo(other is Bombardir);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }

            return 0;
        }
        public bool Equals(fighter other)
        {
            var res = (this as Bombardir).Equals(other as Bombardir);
            if (!res)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            fighter planeObj = obj as fighter;
            if (planeObj == null)
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
        public override int GetHashCode() { return base.GetHashCode(); }

    }
}
