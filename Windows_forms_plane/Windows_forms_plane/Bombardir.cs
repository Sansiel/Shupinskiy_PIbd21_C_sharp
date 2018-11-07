using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_forms_plane
{
    class Bombardir
    {
        

        /// Левая координата отрисовки автомобиля
        private float _startPosX;
        /// Правая кооридната отрисовки автомобиля
        private float _startPosY;
        /// Ширина окна отрисовки
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// Ширина отрисовки автомобиля
        private const int carWidth = 100;
        /// Ширина отрисовки автомобиля
        private const int carHeight = 60;
        /// Максимальная скорость
        public int MaxSpeed { private set; get; }
        /// Вес автомобиля
        public float Weight { private set; get; }
        /// Основной цвет кузова
        public Color MainColor { private set; get; }
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        /// Признак наличия переднего спойлера
        public bool BOMBA { private set; get; }
        /// Признак наличия боковых спойлеров
        public bool ARMOUR { private set; get; }
        public Bombardir(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bomba, bool armour)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            BOMBA = bomba;
            ARMOUR = armour;
        }
        /// Установка позиции автомобиля
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
                
            }
        }
        /// <param name="g"></param>
        public void DrawPlane(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);

            g.FillEllipse(br, _startPosX + 20, _startPosY + 5, 10, 20);
            g.FillEllipse(br, _startPosX + 50, _startPosY - 5, 10, 40);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 10, 70, 10);


        }
    }
}

