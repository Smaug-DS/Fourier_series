using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFourier
{
    public partial class Form1 : Form
    {
        int n = 0;
        int [] answer;
        public Form1()
        {
            InitializeComponent();
            answer = new int [10];
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i1);
        }

        public void redGreen4()
        {
            if (answer[0] == 3) { button4.BackColor = Color.Green; }
            else { button4.BackColor = Color.Red; }
        }
        public void redGreen5()
        {
            if (answer[1] == 2) { button5.BackColor = Color.Green; }
            else { button5.BackColor = Color.Red; }
        }

        public void redGreen6()
        {
            if (answer[2] == 4) { button6.BackColor = Color.Green; }
            else { button6.BackColor = Color.Red; }
        }

        public void redGreen7()
        {
            if (answer[3] == 5) { button7.BackColor = Color.Green; }
            else { button7.BackColor = Color.Red; }
        }

        public void redGreen8()
        {
            if (answer[4] == 3) { button8.BackColor = Color.Green; }
            else { button8.BackColor = Color.Red; }
        }

        public void redGreen9()
        {
            if (answer[5] == 2) { button9.BackColor = Color.Green; }
            else { button9.BackColor = Color.Red; }
        }

        public void redGreen10()
        {
            if (answer[6] == 5) { button10.BackColor = Color.Green; }
            else { button10.BackColor = Color.Red; }
        }

        public void redGreen11()
        {
            if (answer[7] == 2) { button11.BackColor = Color.Green; }
            else { button11.BackColor = Color.Red; }
            

        }

        public void redGreen12()
        {
            if (answer[8] == 3) { button12.BackColor = Color.Green; }
            else
            {
                button12.BackColor = Color.Red;
            }
        }

            public void show(int n)
        {
            int n1 = n + 1;
            if (n1 == 10) n1 = 9;

            label1.Text = "Вопрос № " + n1 + " / 9";

            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 2:

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 3:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 4:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 7:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
                case 8:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    break;
            }

            void radioText()
            {
                radioButton1.Text = "A";
                radioButton2.Text = "B";
                radioButton3.Text = "C";
                radioButton4.Text = "D";
                radioButton5.Text = "E";
                radioButton6.Text = "F";
            }

            switch (n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i1);
                    //redGreen4();
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i2);
                    redGreen4();
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i3);
                    redGreen5();
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i4);
                    redGreen6();
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i5);
                    redGreen7();
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i6);
                    redGreen8();
                    break;
                case 6:
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i7);
                    redGreen9();
                    break;
                case 7:
                    radioText();
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i8);
                    redGreen10();
                    break;
                case 8:
                    radioButton1.Text = "2A 4B 5C \n1D 6E 3F";
                    radioButton2.Text = "5A 2B 1C \n4D 6E 3F";
                    radioButton3.Text = "2A 1B 4C \n3D 6E 5F";
                    radioButton4.Text = "5A 2B 4C \n1D 3E 6F";
                    radioButton5.Text = "2A 3B 4C \n1D 6E 3F";
                    radioButton6.Text = "3A 2B 4C \n1D 6E 3F";
                    pictureBox1.BackgroundImage = new Bitmap(global::TestFourier.Properties.Resources.i9);
                    redGreen11();
                    break;
                case 9:
                    redGreen12();
                    break;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n = 0;
            show(n);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 9) n = 8;
            show(n);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)    // правильный ответ
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)    // правильный ответ
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)    // правильный ответ
        {
            answer[n] = 3;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)  // правильный ответ
        {
            answer[n] = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)    // правильный ответ
        {
            answer[n] = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)    // правильный ответ
        {
            answer[n] = 6;
        }

        public void button3_Click(object sender, EventArgs e)
        {

            //int correct = 0;
            verification objCorrect = new verification();
            verification objPrcntl = new verification();


            if (answer[0] == 3)
                objCorrect.correct++;
            if (answer[1] == 2)
                objCorrect.correct++;
            if (answer[2] == 4)
                objCorrect.correct++;
            if (answer[3] == 5)
                objCorrect.correct++;
            if (answer[4] == 3)
                objCorrect.correct++;
            if (answer[5] == 2)
                objCorrect.correct++;
            if (answer[6] == 5)
                objCorrect.correct++;
            if (answer[7] == 2)
                objCorrect.correct++;
            if (answer[8] == 3)
                objCorrect.correct++;

            objPrcntl.prcntl = objCorrect.correct * 100 / 9;

            //objPrcntl.translation(objPrcntl.prcntl);

            //result res = new result();
            //res.ShowDialog();

            if (objPrcntl.prcntl < 88)
            { 
                DialogResult result = MessageBox.Show("Правильно отвечена на " + objPrcntl.prcntl + " процетов \n\nВам следует повторить материал по теме \n\"Вычисление неопределенных интегралов\"", "Подведение итога", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    result res = new result();
                    res.ShowDialog();
                }
            }
            if (objPrcntl.prcntl >= 88)
                MessageBox.Show("Правильно отвечена на " + objPrcntl.prcntl + " процетов" + "\nВаших знаний достаточно для решения интегралов Фурье", "Подведение итога", MessageBoxButtons.OK);



                //    MessageBox.Show("Правильно отвечена на " + objPrcntl.prcntl + " процетов" + "\nВам следует повторить материал по теме \"Вычисление интегралов\"");
                //if (objPrcntl.prcntl >= 88)
                //MessageBox.Show("Правильно отвечена на " + objPrcntl.prcntl + " процетов" + "\nВаших знаний достаточно для решения интегралов Фурье" + MessageBoxButtons.OK);
                //"Правильно отвечена на " + objPrcntl.prcntl + " процетов" + "\nВаших знаний достаточно для решения интегралов Фурье");



        }
    }
}
