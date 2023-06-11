using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingCar
{
	public partial class Form1 : Form
	{
		//global var 
		int carSpeed = 5;
		int roadSpeed = 5;
		bool carLeft;
		bool carRight;
		int trafficSpeed = 5;
		int Score = 5;
		Random rnd = new Random();

		private void Reset()
		{
			trophy.Visible = false; //hide

			button1.Enabled = false; //hide start button

			explosion.Visible = false;

			trafficSpeed = 5; //back to default

			roadSpeed = 5; //default

			Score = 0;

			player.Left = 161; //reset position
			player.Top = 286; //reset top

			carLeft = false;
			carRight = false;

			//move AI to default position
			AI1.Left = 66;
			AI1.Top = -120;

			AI2.Left = 294;
			AI2.Top = -185;

			//road
			roadTrack2.Left = -3;
			roadTrack2.Top = -222;
			roadTrack1.Left = -2;
			roadTrack1.Top = -638;

			//reset timer
			timer1.Start();


		}

		public Form1()
		{
			InitializeComponent();
			Reset();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Score++;
			distance.Text = "" + Score;

			roadTrack1.Top += roadSpeed;
			roadTrack2.Top += roadSpeed;

			// if the track has gone past -630 then we set it back to default
			// this means it will give us a seamless animation
			if (roadTrack1.Top > 630)
			{
				roadTrack1.Top = -630;
			}
			if (roadTrack2.Top > 630)
			{
				roadTrack2.Top = -630;
			}
			//end of track animation

			if (carLeft) { player.Left -= carSpeed; };
			if (carRight) { player.Left += carSpeed; };

			//end of car moving

			//move the AI cars down
			AI1.Top += trafficSpeed;
			AI2.Top += trafficSpeed;

			//respawn the AIs and change their images 
			if (AI1.Top > panel1.Height)
			{
				changeAI1(); //change AI car images once they left scene
				AI1.Left = rnd.Next(2, 160);
				AI1.Top = rnd.Next(100, 200) * -1;
			}

			if (AI2.Top > panel1.Height)
			{
				changeAI2(); // change the AI car images once they left the scene
				AI2.Left = rnd.Next(185, 327); // random numbers where they appear on the left
				AI2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
			}

			//end of respawning

			//hit test player & AI
			if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds))
			{
				gameOver();
			}
		}

		private void gameOver()
		{
			trophy.Visible = true;
			timer1.Stop();

			button1.Enabled = true;

			//showing epxlosion
			explosion.Visible = true;
			player.Controls.Add(explosion);

			explosion.Location = new Point(-8, 5);
			explosion.BackColor = Color.Transparent;
			explosion.BringToFront();

			//final score

			if (Score < 1000)
			{
				trophy.Image = Properties.Resources.bronze;
			}
			if (Score > 3500)
			{
				trophy.Image = Properties.Resources.gold;
			}
			if (Score > 2000)
			{
				trophy.Image = Properties.Resources.silver;
			}

		}

		private void changeAI2()
		{
			int num = rnd.Next(1, 8); // we set up a local variable to generate a number between 1 and 8
									  // by using a switch statement we can show any image based on that number
									  // switch statement will check which number has been generated and will displayer the images as requested
			switch (num)
			{
				// if the number generated is 1 we show the green car
				case 1:
					AI2.Image = Properties.Resources.carGreen;
					break;
				// if the number generated is 2 we show the grey car
				case 2:
					AI2.Image = Properties.Resources.carGrey;
					break;
				// if the number generated is 3 we show the orange car
				case 3:
					AI2.Image = Properties.Resources.carOrange;
					break;
				// if the number generated is 4 we show the pink car
				case 4:
					AI2.Image = Properties.Resources.carPink;
					break;
				// if the number generated is 5 we show the red car
				case 5:
					AI2.Image = Properties.Resources.CarRed;
					break;
				// if the number generated is 6 we show the blue truck
				case 6:
					AI2.Image = Properties.Resources.TruckBlue;
					break;
				// if the number generated is 7 we show the white truck
				case 7:
					AI2.Image = Properties.Resources.TruckWhite;
					break;
				// if the number generated is 8 we show the ambulance
				case 8:
					AI2.Image = Properties.Resources.ambulance;
					break;
				default:
					break;
			}
		}

		private void changeAI1()
		{
			int num = rnd.Next(1, 8); // we set up a local variable to generate a number between 1 and 8
									  // by using a switch statement we can show any image based on that number
									  // switch statement will check which number has been generated and will displayer the images as requested
			switch (num)
			{
				// if the number generated is 1 we show the green car
				case 1:
					AI1.Image = Properties.Resources.carGreen;
					break;
				// if the number generated is 2 we show the grey car
				case 2:
					AI1.Image = Properties.Resources.carGrey;
					break;
				// if the number generated is 3 we show the orange car
				case 3:
					AI1.Image = Properties.Resources.carOrange;
					break;
				// if the number generated is 4 we show the pink car
				case 4:
					AI1.Image = Properties.Resources.carPink;
					break;
				// if the number generated is 5 we show the red car
				case 5:
					AI1.Image = Properties.Resources.CarRed;
					break;
				// if the number generated is 6 we show the blue truck
				case 6:
					AI1.Image = Properties.Resources.TruckBlue;
					break;
				// if the number generated is 7 we show the white truck
				case 7:
					AI1.Image = Properties.Resources.TruckWhite;
					break;
				// if the number generated is 8 we show the ambulance
				// this is why its important to name your images so they make logical sense
				case 8:
					AI1.Image = Properties.Resources.ambulance;
					break;
				default:
					break;
			}
		}
	}
}
