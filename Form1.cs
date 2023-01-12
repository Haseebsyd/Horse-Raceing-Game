using System;
using System.Drawing;
using System.Windows.Forms;
//using Unity.Engine;

namespace A2_HorseRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Math Functions and Random used
        private Random _rnd = new Random();
        const double degToRad = Math.PI / 180.0;
        const double radToDeg = 180.0 / Math.PI;

        //Initial values for each horse and variables used
        const int oneHorseRadius = 192;
        double horseOneTime = 0;
        double horseOneDistance = 924.6;
        double horseOneAngle;
        Point horseOnePoint;

        const int twoHorseRadius = 170;
        double horseTwoTime = 0;
        double horseTwoDistance = 864;
        double horseTwoAngle;
        Point horseTwoPoint;

        const int threeHorseRadius = 140;
        double horseThreeTime = 0;
        double horseThreeDistance = 768.2;
        double horseThreeAngle;
        Point horseThreePoint;

        Point centerPoint = new Point(209, 213);

        bool horseOneFinish = false;
        bool horseTwoFinish = false;
        bool horseThreeFinish = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            oneHorse.Location = new Point(15, 223);
            horseOneTime = 0;

            twoHorse.Location = new Point(43, 223);
            horseTwoTime = 0;

            threeHorse.Location = new Point(71, 223);
            horseThreeTime = 0;

            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;

            lblDescription.Text = "";
            lblWinner.Text = "Winner:";
            lblTiming.Text = "Timing:";
            lblSpeed.Text = "Speed:";

            lblTime1.Text = "...";
            lblTime2.Text = "...";
            lblTime3.Text = "...";

            lblSpeed1.Text = "...";
            lblSpeed2.Text = "...";
            lblSpeed3.Text = "...";
        }

        public double findAngle(Point centerPoint, Point finish)
        {
            return Math.Atan2(centerPoint.Y - finish.Y, centerPoint.X - finish.X) * radToDeg;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //horseOneTime++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            //horseTwoTime++;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            //horseThreeTime++;
        }

        public Point findPoint(double angle, double radius)
        {
            int posX;
            int posY;

            posX = Convert.ToInt32(centerPoint.X - (radius * (Math.Cos(angle * degToRad))));
            posY = Convert.ToInt32(centerPoint.Y - (radius * (Math.Sin(angle * degToRad))));

            return new Point(posX, posY);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        void finalResults()
        {
            lblDescription.Text = "";

            string speed1 = Math.Round(horseOneDistance / horseOneTime).ToString();
            string speed2 = Math.Round(horseTwoDistance / horseTwoTime).ToString();
            string speed3 = Math.Round(horseThreeDistance / horseThreeTime).ToString();

            double time1 = horseOneTime / 10;
            double time2 = horseTwoTime / 10;
            double time3 = horseThreeTime / 10;

            lblTime1.Text = time1.ToString();
            lblSpeed1.Text = speed1;

            lblTime2.Text = time2.ToString();
            lblSpeed2.Text = speed2;

            lblTime3.Text = time3.ToString();
            lblSpeed3.Text = speed3;

            //int _time1 = Convert.ToInt32(time1);
            //int _time2 = Convert.ToInt32(time2);
            //int _time3 = Convert.ToInt32(time3);

            if (horseOneTime < horseTwoTime && horseOneTime < horseThreeTime)
            {
                lblWinner.Text += "  1";
                lblSpeed.Text += "  " + speed1;
                lblTiming.Text += "  " + (horseOneTime / 10);
            }
            if (horseTwoTime < horseOneTime && horseTwoTime < horseThreeTime)
            {
                lblWinner.Text += "  2";
                lblSpeed.Text += "  " + speed2;
                lblTiming.Text += "  " + (horseTwoTime / 10);
            }
            if (horseThreeTime < horseTwoTime && horseThreeTime < horseOneTime)
            {
                lblWinner.Text += "  3";
                lblSpeed.Text += "  " + speed3;
                lblTiming.Text += "  " + (horseThreeTime / 10);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            horseOneTime++;
            horseTwoTime++;
            horseThreeTime++;

            horseOnePoint = oneHorse.Location;
            horseOneAngle = findAngle(centerPoint, horseOnePoint);
            horseOneAngle = horseOneAngle + _rnd.Next(3, 7);
            Point oneHorsePoint = findPoint(horseOneAngle, oneHorseRadius);
            oneHorse.Location = oneHorsePoint;

            if (horseOnePoint.X <= richTextBox1.Right && horseOnePoint.Y > centerPoint.Y)
            {
                horseOneFinish = true;
                timer1.Enabled = false;
                timer4.Enabled = false;

                if (horseOneFinish == true)
                    {
                        finalResults();
                    }
            }

            horseTwoPoint = twoHorse.Location;
            horseTwoAngle = findAngle(centerPoint, horseTwoPoint);
            horseTwoAngle = horseTwoAngle + _rnd.Next(3, 7);
            Point twoHorsePoint = findPoint(horseTwoAngle, twoHorseRadius);
            twoHorse.Location = twoHorsePoint;

            if (horseTwoPoint.X <= richTextBox1.Right && horseTwoPoint.Y > centerPoint.Y)
            {
                horseTwoFinish = true;
                timer2.Enabled = false;
                timer5.Enabled = false;

                if (horseTwoFinish == true)
                {
                    finalResults();
                }
            }

            horseThreePoint = threeHorse.Location;
            horseThreeAngle = findAngle(centerPoint, horseThreePoint);
            horseThreeAngle = horseThreeAngle + _rnd.Next(3, 7);
            Point threeHorsePoint = findPoint(horseThreeAngle, threeHorseRadius);
            threeHorse.Location = threeHorsePoint;

            if (horseThreePoint.X <= richTextBox1.Right && horseThreePoint.Y > centerPoint.Y)
            {
                horseThreeFinish = true;
                timer3.Enabled = false;
                timer6.Enabled = false;

                if (horseThreeFinish == true)
                {
                    finalResults();
                }
            }

            if (oneHorse.Left > twoHorse.Left + 5 && oneHorse.Left > threeHorse.Left + 5)
            {
                lblDescription.Text = "Description:   Horse ONE Now In The Lead";
            }
            if (twoHorse.Left > oneHorse.Left + 5 && twoHorse.Left > threeHorse.Left + 5)
            {
                lblDescription.Text = "Description:   Horse TWO Takes The Lead";
            }
            if (threeHorse.Left > oneHorse.Left + 5 && threeHorse.Left > twoHorse.Left + 5)
            {
                lblDescription.Text = "Description:   Speedy Horse THREE In The Lead";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }
    }
}