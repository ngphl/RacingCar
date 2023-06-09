namespace RacingCar
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.roadTrack1 = new System.Windows.Forms.PictureBox();
			this.roadTrack2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(133, 474);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(130, 59);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 536);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Avoid other cars and get points";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 560);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Use Left and Right Key to Move Car";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(165, 458);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Distance: 00";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.roadTrack2);
			this.panel1.Controls.Add(this.roadTrack1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 424);
			this.panel1.TabIndex = 4;
			// 
			// roadTrack1
			// 
			this.roadTrack1.Image = global::RacingCar.Properties.Resources.roadTrack;
			this.roadTrack1.Location = new System.Drawing.Point(-2, -638);
			this.roadTrack1.Name = "roadTrack1";
			this.roadTrack1.Size = new System.Drawing.Size(385, 632);
			this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.roadTrack1.TabIndex = 0;
			this.roadTrack1.TabStop = false;
			// 
			// roadTrack2
			// 
			this.roadTrack2.Image = global::RacingCar.Properties.Resources.roadTrack;
			this.roadTrack2.Location = new System.Drawing.Point(-3, -222);
			this.roadTrack2.Name = "roadTrack2";
			this.roadTrack2.Size = new System.Drawing.Size(385, 632);
			this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.roadTrack2.TabIndex = 1;
			this.roadTrack2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 657);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Racing Car";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox roadTrack2;
		private System.Windows.Forms.PictureBox roadTrack1;
	}
}

