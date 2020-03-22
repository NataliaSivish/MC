﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculatio
{
    public partial class Form1 : Form
    {
        String mesResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInputKeyBoard_Click(object sender, EventArgs e)
        {
            buttonSaveRes.Enabled = false;
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            if (textBoxForX.Enabled) 
            {
                textBoxForX.Enabled = false;
                textBoxForY.Enabled = false;
            }
            else
            {
                textBoxForX.Enabled = true;
                textBoxForY.Enabled = true;
            }
        }

        private void buttonInputRand_Click(object sender, EventArgs e)
        {
            buttonSaveRes.Enabled = false;
            Double x = 1.0;
            Double y = 1.0;
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            textBoxForX.Enabled = false;
            textBoxForY.Enabled = false;
            var rand = new Random();
            if (rand.Next(100) % 2 == 0)
            {
                x = -1.0;
            }
            if (rand.Next(200) % 2 == 0)
            {
                y = -1.0;
            }

            y = y * rand.NextDouble();
            x = x * rand.NextDouble();

            if (rand.Next(100) % 2 == 0)
            {
                if (x < 0.0)
                    x = x - rand.Next(3);
                else
                    x = x + rand.Next(3);
            }
            if (rand.Next(200) % 2 == 0)
            {
                if (y < 0.0)
                    y = y - rand.Next(3);
                else
                    y = y + rand.Next(3);
            }
            textBoxForX.Text = x.ToString().Substring(0, 6);
            textBoxForY.Text = y.ToString().Substring(0, 6);
        }

        private void buttonInputFile_Click(object sender, EventArgs e)
        {
            buttonSaveRes.Enabled = false;
            bool isFilledX = false;
            bool isFilledY = false;
            string x = "";
            string y = "";
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            
            StreamReader sr;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"coordinates.txt"; 
            try
            {
                sr = new StreamReader(path);
                string coordinate = sr.ReadToEnd();
                char[] charArr = coordinate.ToCharArray();
                sr.Close();
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i].ToString() == "x" || isFilledX)
                    {
                        if (charArr[i + 1].ToString() == "y")
                        {
                            isFilledX = false;
                        }
                        else
                        {
                            isFilledX = true;
                        }
                        if (charArr[i].ToString() != "x")
                        {
                            if (charArr[i].ToString() == ".")
                                x = x + ",";
                            else
                                x = x + charArr[i].ToString();
                        }
                    }
                    if (charArr[i].ToString() == "y" || isFilledY)
                    {
                        isFilledY = true;
                        if (charArr[i].ToString() != "y")
                        {
                            if (charArr[i].ToString() == ".")
                                y = y + ",";
                            else
                                y = y + charArr[i].ToString();
                        }
                    }
                }
                if (x == "" || x == "") {
                    MessageBox.Show("Данные в файле некорректны. \nПроверьте данные в файле исходника, они должны соответствовать форме 'x*****y*****'.");
                    return;
                }
                textBoxForX.Text = x;
                textBoxForY.Text = y;
            }
            catch (Exception t)
            {
                MessageBox.Show("Не удается найти и открыть файл содержащий координаты точки");
            }
        }

        

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Double x = 0.0;
            Double y = 0.0;
            try
            {
                x = Convert.ToDouble(textBoxForX.Text);
                y = Convert.ToDouble(textBoxForY.Text);
            }
            catch (Exception) {
                if (textBoxForX.Text == "" && textBoxForY.Text == "")
                {
                    MessageBox.Show("Данные в поле значения x и у отсутствуют");
                    return;
                }
                if (textBoxForY.Text == "") {
                    MessageBox.Show("Данные в поле значения у отсутствуют");
                    return;
                }
                if (textBoxForX.Text == "")
                {
                    MessageBox.Show("Данные в поле значения x отсутствуют");
                    return;
                }
                MessageBox.Show("Проверьте правильность вводимых данных");
                return;
            }
           if (x >= 3.0 && x <= -3.0) {
                MessageBox.Show("Введеyное значение х не соответствует условиям  -3 <= x <= 3 ");
                return;
            }
            if (y >= 3.0 && y <= -3.0)
            {
                MessageBox.Show("Введеное значение y не соответствует  -3 <= y <= 3 ");
                return;
            }

            if (((x > 0.0 && x < Math.Sqrt(1 - y * y)) && (y > -0.6 && y < Math.Sqrt(1 - x * x))) || ((x < 0.0 && x > Math.Sqrt(1 - y * y) * (-1.0)) && (y < -0.6 && y > Math.Sqrt(1 - x * x) * (-1.0))))
            {
                mesResult = "Точка находится внутри заштрихованной области";
                MessageBox.Show(mesResult);
            }
            else if (((x * x + y * y == 1.0) && ((x > 0.0 && y >= -0.6) || (x < 0.0 && y <= -0.6))) || (y == -0.6 && (x <= Math.Sqrt(1 - y * y) && x >= Math.Sqrt(1 - y * y) * (-1.0))))
            {
                mesResult = "Точка находится на границе заштрихованной области";
                MessageBox.Show(mesResult);
            }
            else
            {
                mesResult = "Точка находится вне заштрихованной границы";
                MessageBox.Show(mesResult);
            }
            mesResult = mesResult + ". Координаты x = " + x.ToString() + " y = " + y.ToString()+ "\r";
            x = x * 100.0 + pictureGraphic.Location.X + pictureGraphic.Size.Width / 2;
            if(y > 0.0)
                y = pictureGraphic.Location.Y + pictureGraphic.Size.Height / 2 - y * 100.0;
            else
                y = pictureGraphic.Location.Y + pictureGraphic.Size.Height / 2 - y * 100.0;
            picturePoint.Location = new Point(Convert.ToInt16(x), Convert.ToInt16(y));
            picturePoint.Visible = true;
            buttonSaveRes.Enabled = true;
        }

        private void buttonSaveRes_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            StreamWriter sw;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Res.txt";
            try
            {
                sr = new StreamReader(path);
                String res = sr.ReadToEnd();
                sr.Close();
                res = res + mesResult;
                sw = new StreamWriter(path);
                sw.WriteLine(res);
                sw.Close();
                buttonSaveRes.Enabled = false;
            }
            catch (Exception p) {
                MessageBox.Show("Не удается найти и открыть файл с результатами");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }




    }
}