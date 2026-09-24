using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показать диалог выбора цвета. Если пользователь нажмёт «ОК»,
            // изменить фон PictureBox на выбранный цвет.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрыть форму
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Отображается диалоговое окно «Открыть файл». 
            // Если пользователь нажмёт «ОК», загружается выбранное изображение.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Очистить изображение
            pictureBox1.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Если флажок установлен — растягивать изображение,
            // иначе — отображать в обычном режиме.
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        
    }
}
