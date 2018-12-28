using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_forms_plane
{
    class Bombardir : vehicle, IComparable<Bombardir>, IEquatable<Bombardir>
    {
        protected const int planeWidth = 100;
        /// Ширина отрисовки автомобиля
        protected const int planeHeight = 60;
        /// Максимальная скорость

        /// Дополнительный цвет
        public Color DopColor { private set; get; }
       
        public Bombardir(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;

        }
        public Bombardir (string info) {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }


        /// Установка позиции автомобиля
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0 + planeHeight)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;

            }
        }
        /// <param name="g"></param>
        public override void DrawPlane(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);

            g.FillEllipse(br, _startPosX + 20, _startPosY + 5, 10, 20);
            g.FillEllipse(br, _startPosX + 50, _startPosY - 5, 10, 40);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 10, 70, 10);


        }
        public override string ToString() { return MaxSpeed + ";" + Weight + ";" + MainColor.Name; }
        public int CompareTo(Bombardir other) {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        public bool Equals(Bombardir other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            Bombardir planeObj = obj as Bombardir;
            if (planeObj == null)
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

