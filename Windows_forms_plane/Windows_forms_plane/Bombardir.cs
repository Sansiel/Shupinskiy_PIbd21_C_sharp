﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_forms_plane
{
    class Bombardir : vehicle
    {



        protected const int carWidth = 100;
        /// Ширина отрисовки автомобиля
        protected const int carHeight = 60;
        /// Максимальная скорость

        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        /// Признак наличия переднего спойлера
        public bool FrontSpoiler { private set; get; }
        /// Признак наличия боковых спойлеров
        public bool SideSpoiler { private set; get; }
        /// Признак наличия заднего спойлера
        public bool BackSpoiler { private set; get; }
        /// Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        public Bombardir(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       frontSpoiler, bool sideSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontSpoiler = frontSpoiler;
            SideSpoiler = sideSpoiler;
            BackSpoiler = backSpoiler;
        }

        public Bombardir(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
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
                    if (_startPosY - step > 0 + carHeight)
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
                    //Диагонально вниз и направо
            }
        }
        /// <param name="g"></param>
        public override void DrawCar(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);

            g.FillEllipse(br, _startPosX + 20, _startPosY + 5, 10, 20);
            g.FillEllipse(br, _startPosX + 50, _startPosY - 5, 10, 40);
            g.FillEllipse(br, _startPosX + 10, _startPosY + 10, 70, 10);


        }
    }
}


