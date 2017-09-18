using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp2
{
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, EventArgs e)
        {

            SoundPlayer pokemon = new SoundPlayer(Properties.Resources.Pokemon_SMS_Tone_Sound_Effect);
            SoundPlayer beep = new SoundPlayer(Properties.Resources.beep_02);

            Pen GreenPen = new Pen(color: Color.Green, width: 13);
            SolidBrush DeepSkyBlueBrush = new SolidBrush(Color.DeepSkyBlue);

            Graphics formGraphics = this.CreateGraphics();

            startbutton.Visible = false;
            beep.Play();
            counter.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            beep.Play();
            counter.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            beep.Play();
            counter.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            counter.Text = "Go!";
            pokemon.Play();
            Refresh();
            Thread.Sleep(2000);

            counter.Visible = false;
            Refresh();

            formGraphics.Clear(Color.Salmon);
            
            formGraphics.DrawEllipse(GreenPen, 370, 340, 270, 270);
            GreenPen.Color = Color.DeepSkyBlue;
            formGraphics.DrawEllipse(GreenPen, 380, 350, 250, 250);
            formGraphics.FillEllipse(DeepSkyBlueBrush, 380, 350, 250, 250);

            //Text for Logo
            Graphics fg = this.CreateGraphics();

            Font TFont = new Font("Courier new", 66, FontStyle.Bold);
            SolidBrush TBrush = new SolidBrush(Color.Blue);
            fg.DrawString("T", TFont, TBrush, 345, 384);

            Font urtleFont = new Font("Courier new", 33, FontStyle.Bold);
            SolidBrush urtleBrush = new SolidBrush(Color.Blue);
            fg.DrawString("urtle", urtleFont, urtleBrush, 415, 437);

            //Rotated Text
            Font SCFont = new Font("Courier new", 10, FontStyle.Bold);
            SolidBrush SCBrush = new SolidBrush(Color.Blue);
            fg.TranslateTransform(650, 625);
            fg.RotateTransform(270);
            fg.DrawString("Stratford Central School", SCFont, SCBrush, new Rectangle());
            fg.ResetTransform();
            Thread.Sleep(2000);

            //PacMan Game

            //Borders
            Pen LinePen = new Pen(Color.Blue, 15);
            formGraphics.Clear(Color.Black);
            formGraphics.DrawLine(LinePen, 0, 10, 650, 10);
            formGraphics.DrawLine(LinePen, 0, 150, 450, 150);
            formGraphics.DrawLine(LinePen, 645, 10, 645, 500);
            formGraphics.DrawLine(LinePen, 445, 150, 445, 500);

            //PacManAnimation
            Pen PacManYPen = new Pen(Color.Yellow);
            SolidBrush PacManYBrush = new SolidBrush(Color.Yellow);
            Pen PacManBPen = new Pen(Color.Black);
            SolidBrush PacManBBrush = new SolidBrush(Color.Black);

            formGraphics.DrawPie(PacManYPen, 40, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 40, 50, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 40, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 40, 50, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 100, 50, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 100, 50, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 100, 50, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 100, 50, 60, 60);

            formGraphics.DrawPie(PacManYPen, 160, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 160, 50, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 160, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 160, 50, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 220, 50, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 220, 50, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 220, 50, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 220, 50, 60, 60);

            formGraphics.DrawPie(PacManYPen, 280, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 280, 50, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 280, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 280, 50, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 340, 50, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 340, 50, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 340, 50, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 340, 50, 60, 60);

            formGraphics.DrawPie(PacManYPen, 400, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 400, 50, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 400, 50, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 400, 50, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 460, 50, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 460, 50, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 460, 50, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 460, 50, 60, 60);

            formGraphics.DrawPie(PacManYPen, 520, 50, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 520, 50, 60, 60, 130, 280);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 520, 50, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 520, 50, 60, 60, 130, 280);

            formGraphics.DrawEllipse(PacManYPen, 520, 110, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 520, 110, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 520, 110, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 520, 110, 60, 60);

            formGraphics.DrawPie(PacManYPen, 520, 170, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 520, 170, 60, 60, 130, 280);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 520, 170, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 520, 170, 60, 60, 130, 280);

            formGraphics.DrawEllipse(PacManYPen, 520, 230, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 520, 230, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 520, 230, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 520, 230, 60, 60);

            formGraphics.DrawPie(PacManYPen, 520, 290, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 520, 290, 60, 60, 130, 280);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 520, 290, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 520, 290, 60, 60, 130, 280);

            formGraphics.DrawEllipse(PacManYPen, 520, 350, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 520, 350, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 520, 350, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 520, 350, 60, 60);

            formGraphics.DrawPie(PacManYPen, 520, 410, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 520, 410, 60, 60, 130, 280);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 520, 410, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 520, 410, 60, 60, 130, 280);

            formGraphics.DrawEllipse(PacManYPen, 520, 470, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 520, 470, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 520, 470, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 520, 470, 60, 60);

            formGraphics.DrawPie(PacManYPen, 520, 530, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 520, 530, 60, 60, 130, 280);
            Thread.Sleep(1500);

            formGraphics.DrawPie(PacManBPen, 520, 530, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 520, 530, 60, 60, 130, 280);

            //Congratulations Sign
            Font CongratulationsFont = new Font("Arial", 30, FontStyle.Bold);
            SolidBrush CongratulationsBrush = new SolidBrush(Color.Yellow);


            fg.DrawString("Congratulations", CongratulationsFont, CongratulationsBrush, 300, 600);

            //PacManEnd
            formGraphics.DrawEllipse(PacManYPen, 580, 530, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 580, 530, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 580, 530, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 580, 530, 60, 60);

            formGraphics.DrawPie(PacManYPen, 640, 530, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 640, 530, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 640, 530, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 640, 530, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 700, 530, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 700, 530, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 700, 530, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 700, 530, 60, 60);

            formGraphics.DrawPie(PacManYPen, 760, 530, 60, 60, 30, 300);
            formGraphics.FillPie(PacManYBrush, 760, 530, 60, 60, 30, 300);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 760, 530, 60, 60, 30, 300);
            formGraphics.FillPie(PacManBBrush, 760, 530, 60, 60, 30, 300);

            formGraphics.DrawEllipse(PacManYPen, 820, 530, 60, 60);
            formGraphics.FillEllipse(PacManYBrush, 820, 530, 60, 60);
            Thread.Sleep(700);

            formGraphics.DrawEllipse(PacManBPen, 820, 530, 60, 60);
            formGraphics.FillEllipse(PacManBBrush, 820, 530, 60, 60);

            formGraphics.DrawPie(PacManYPen, 820, 590, 60, 60, 130, 280);
            formGraphics.FillPie(PacManYBrush, 820, 590, 60, 60, 130, 280);
            Thread.Sleep(700);

            formGraphics.DrawPie(PacManBPen, 820, 590, 60, 60, 130, 280);
            formGraphics.FillPie(PacManBBrush, 820, 590, 60, 60, 130, 280);
        }
    }
}

