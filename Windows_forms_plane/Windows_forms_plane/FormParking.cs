using System;
using NLog;
using System.Drawing;
using System.Windows.Forms;


namespace Windows_forms_plane
{
    public partial class FormParking : Form
    {
        
        MultiLevelParking parking;
        FormPlaneConfig form;
        private Logger logger;
        private const int countLevel = 5;

        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
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
                        logger.Info("Изъят поезд " + plane.ToString() + " с места " + maskedTextBoxPlace.Text);
                        Draw();
                    }
                    catch(ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                        pictureBoxParking.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                try { 
                int place = parking[listBoxMultiParking.SelectedIndex] + plane;
                logger.Info("Добавлен самолет " + plane.ToString() + " на место " + place);
                Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Load_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void Sort_button_Click(object sender, EventArgs e)
        {
            parking.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}

