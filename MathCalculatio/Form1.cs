using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculation
{
    public partial class Form1 : Form
    {
        Boolean isInputM = false;
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
            startState();   
        }

        private void buttonInputRand_Click(object sender, EventArgs e)
        {
            picturePoint.Visible = false;
            isInputM = false;
            buttonSaveRes.Enabled = false;

            buttonInputKeyBoard.Enabled = true;
            buttonInputFile.Enabled = true;
            buttonInputOnGraph.Enabled = true;
            buttonInputRand.Enabled = false;

            setCoordinatesRand.Visible = true;
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            textBoxForX.Enabled = false;
            textBoxForY.Enabled = false;
           
        }

        private void buttonInputFile_Click(object sender, EventArgs e)
        {
            setCoordinatesRand.Visible = false;
            buttonInputKeyBoard.Enabled = true;
            buttonInputFile.Enabled = false;
            buttonInputOnGraph.Enabled = true;
            buttonInputRand.Enabled = true;
            textBoxForX.Enabled = false;
            textBoxForY.Enabled = false;
            picturePoint.Visible = false;
            isInputM = false;
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
                    startState();
                    MessageBox.Show("Данные в файле некорректны. \nПроверьте данные в файле исходника, они должны соответствовать форме 'x*****y*****'.");
                    return;
                }
                try
                {
                    double xx = Convert.ToDouble(x);
                    double yy = Convert.ToDouble(y);
                }
                catch (Exception r) {
                    startState();
                    MessageBox.Show("Данные в файле некорректны. \nПроверьте данные в файле исходника, они должны соответствовать форме 'x*****y*****'.\n На месте звездочек должны быть числа");
                    return;
                }
                textBoxForX.Text = x;
                textBoxForY.Text = y;
            }
            catch (Exception t)
            {
                startState();
                MessageBox.Show("Не удается найти и открыть файл, содержащий координаты точки");
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
           if (x > 3.0 || x < -3.0) {
                MessageBox.Show("Введенное значение х не соответствует условиям  -3 <= x <= 3 ");
                return;
            }
            if (y > 3.0 || y < -3.0)
            {
                MessageBox.Show("Введеное значение y не соответствует  -3 <= y <= 3 ");
                return;
            }

            if (((x > 0.0 && x < Math.Sqrt(1 - y * y)) && (y > -0.6 && y < Math.Sqrt(1 - x * x))) || ((x < 0.0 && x > Math.Sqrt(1 - y * y) * (-1.0)) && (y < -0.6 && y > Math.Sqrt(1 - x * x) * (-1.0))))
            {
                mesResult = "Точка находится внутри заштрихованной области";
                MessageBox.Show(mesResult);
            }
            else if (((x * x + y * y == 1.0) && ((x > 0.0 && y >= -0.6) || (x < 0.0 && y <= -0.6))) || (y == -0.6 && (x <= Math.Sqrt(1 - y * y) && x >= Math.Sqrt(1 - y * y) * (-1.0))) || (x==0 && (y>=-1 || y<=1 )))
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
                picturePoint.Visible = false;
            }
            catch (Exception p) {
                MessageBox.Show("Не удается найти и открыть файл с результатами");
            }
        }

        private void buttonInputOnGraph_Click(object sender, EventArgs e)
        {
            buttonInputKeyBoard.Enabled = true;
            buttonInputFile.Enabled = true;
            buttonInputOnGraph.Enabled = false;
            buttonInputRand.Enabled = true;
            textBoxForX.Enabled = false;
            textBoxForY.Enabled = false;
            picturePoint.Visible = false;
            buttonSaveRes.Enabled = false;
            setCoordinatesRand.Visible = false;
            string x = "";
            string y = "";
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            isInputM = true;

        }

        private void pictureGraphic_Click(object sender, EventArgs e)
        {
            if (isInputM)
            {
                Point coordMouse = Form1.ActiveForm.PointToClient(Cursor.Position);
                int x = coordMouse.X;
                int y = coordMouse.Y;
                int x0 = pictureGraphic.Location.X + pictureGraphic.Size.Width / 2;
                int y0 = pictureGraphic.Location.Y + pictureGraphic.Size.Height / 2;
                picturePoint.Location = new Point(Convert.ToInt16(x), Convert.ToInt16(y));

                x = x - x0;
                y = y - y0;
                if (x > y0)
                {
                    x = x * (-1);
                }
                if (y < x0)
                {
                    y = y * (-1);
                }
                textBoxForX.Text = (Convert.ToDouble(x) / 100.0).ToString();
                textBoxForY.Text = (Convert.ToDouble(y) / 100.0).ToString();
                picturePoint.Visible = true;
            }
            else {
                MessageBox.Show("Чтобы выбирать точки на графике с помощью мыши, выберете 'ввод с помощью мыши'.");
            }
            
        }

        private void textBoxForX_TextChanged(object sender, EventArgs e)
        {
            buttonSaveRes.Enabled = false;
        }

        private void textBoxForY_TextChanged(object sender, EventArgs e)
        {
            buttonSaveRes.Enabled = false;
        }

        private void setCoordinatesRand_Click(object sender, EventArgs e)
        {
            Double x = 1.0;
            Double y = 1.0;
            
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

        private void startState() {
            picturePoint.Visible = false;
            buttonSaveRes.Enabled = false;
            isInputM = false;
            setCoordinatesRand.Visible = false;
            buttonInputKeyBoard.Enabled = false;
            buttonInputFile.Enabled = true;
            buttonInputOnGraph.Enabled = true;
            buttonInputRand.Enabled = true;
            if (textBoxForX.Text != "" || textBoxForY.Text != "")
            {
                textBoxForX.Text = "";
                textBoxForY.Text = "";
            }
            textBoxForX.Enabled = true;
            textBoxForY.Enabled = true;
        }
    }
}
