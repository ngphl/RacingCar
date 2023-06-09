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
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
