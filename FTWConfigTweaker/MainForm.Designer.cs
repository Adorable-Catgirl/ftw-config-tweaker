/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 7/5/2018
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FTWConfigTweaker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox lres;
		private System.Windows.Forms.TrackBar vdist;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar aalevel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TrackBar shadowlevel;
		private System.Windows.Forms.TrackBar pplevel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar txlevel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TrackBar fxlevel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TrackBar follevel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown resx;
		private System.Windows.Forms.NumericUpDown resy;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown flimit;
		private System.Windows.Forms.CheckBox uvsync;
		private System.Windows.Forms.ComboBox wmode;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.lres = new System.Windows.Forms.CheckBox();
			this.vdist = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.aalevel = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.shadowlevel = new System.Windows.Forms.TrackBar();
			this.pplevel = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.txlevel = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.fxlevel = new System.Windows.Forms.TrackBar();
			this.label7 = new System.Windows.Forms.Label();
			this.follevel = new System.Windows.Forms.TrackBar();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.resx = new System.Windows.Forms.NumericUpDown();
			this.resy = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.flimit = new System.Windows.Forms.NumericUpDown();
			this.uvsync = new System.Windows.Forms.CheckBox();
			this.wmode = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vdist)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aalevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shadowlevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pplevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txlevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fxlevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.follevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resx)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flimit)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Scalability (Most FPS here!)";
			// 
			// lres
			// 
			this.lres.Location = new System.Drawing.Point(13, 36);
			this.lres.Name = "lres";
			this.lres.Size = new System.Drawing.Size(373, 24);
			this.lres.TabIndex = 1;
			this.lres.Text = "Low Resolution Scaling (Only check this if you have the most potato PC!)";
			this.lres.UseVisualStyleBackColor = true;
			// 
			// vdist
			// 
			this.vdist.LargeChange = 1;
			this.vdist.Location = new System.Drawing.Point(9, 89);
			this.vdist.Maximum = 4;
			this.vdist.Name = "vdist";
			this.vdist.Size = new System.Drawing.Size(104, 29);
			this.vdist.TabIndex = 2;
			this.vdist.Value = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "View Distance";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(112, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Anti Aliasing";
			// 
			// aalevel
			// 
			this.aalevel.LargeChange = 1;
			this.aalevel.Location = new System.Drawing.Point(112, 89);
			this.aalevel.Maximum = 4;
			this.aalevel.Name = "aalevel";
			this.aalevel.Size = new System.Drawing.Size(104, 29);
			this.aalevel.TabIndex = 5;
			this.aalevel.Value = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(218, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Shadows";
			// 
			// shadowlevel
			// 
			this.shadowlevel.LargeChange = 1;
			this.shadowlevel.Location = new System.Drawing.Point(218, 89);
			this.shadowlevel.Maximum = 4;
			this.shadowlevel.Name = "shadowlevel";
			this.shadowlevel.Size = new System.Drawing.Size(104, 29);
			this.shadowlevel.TabIndex = 7;
			this.shadowlevel.Value = 3;
			// 
			// pplevel
			// 
			this.pplevel.LargeChange = 1;
			this.pplevel.Location = new System.Drawing.Point(324, 89);
			this.pplevel.Maximum = 4;
			this.pplevel.Name = "pplevel";
			this.pplevel.Size = new System.Drawing.Size(104, 29);
			this.pplevel.TabIndex = 9;
			this.pplevel.Value = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(324, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Post-Process";
			// 
			// txlevel
			// 
			this.txlevel.LargeChange = 1;
			this.txlevel.Location = new System.Drawing.Point(430, 89);
			this.txlevel.Maximum = 4;
			this.txlevel.Name = "txlevel";
			this.txlevel.Size = new System.Drawing.Size(104, 29);
			this.txlevel.TabIndex = 11;
			this.txlevel.Value = 3;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(430, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Textures";
			// 
			// fxlevel
			// 
			this.fxlevel.LargeChange = 1;
			this.fxlevel.Location = new System.Drawing.Point(13, 147);
			this.fxlevel.Maximum = 4;
			this.fxlevel.Name = "fxlevel";
			this.fxlevel.Size = new System.Drawing.Size(104, 29);
			this.fxlevel.TabIndex = 13;
			this.fxlevel.Value = 3;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Effects";
			// 
			// follevel
			// 
			this.follevel.LargeChange = 1;
			this.follevel.Location = new System.Drawing.Point(112, 147);
			this.follevel.Maximum = 4;
			this.follevel.Name = "follevel";
			this.follevel.Size = new System.Drawing.Size(104, 29);
			this.follevel.TabIndex = 15;
			this.follevel.Value = 3;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(112, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Foliage";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(13, 183);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "General Settings";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(9, 210);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 17;
			this.label10.Text = "Resolution";
			// 
			// resx
			// 
			this.resx.Location = new System.Drawing.Point(12, 237);
			this.resx.Maximum = new decimal(new int[] {
			9999,
			0,
			0,
			0});
			this.resx.Name = "resx";
			this.resx.Size = new System.Drawing.Size(64, 20);
			this.resx.TabIndex = 18;
			// 
			// resy
			// 
			this.resy.Location = new System.Drawing.Point(99, 237);
			this.resy.Maximum = new decimal(new int[] {
			9999,
			0,
			0,
			0});
			this.resy.Name = "resy";
			this.resy.Size = new System.Drawing.Size(62, 20);
			this.resy.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(79, 237);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(14, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "x";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(184, 210);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 23);
			this.label12.TabIndex = 21;
			this.label12.Text = "Framerate Limit";
			// 
			// flimit
			// 
			this.flimit.Location = new System.Drawing.Point(184, 237);
			this.flimit.Maximum = new decimal(new int[] {
			9999,
			0,
			0,
			0});
			this.flimit.Name = "flimit";
			this.flimit.Size = new System.Drawing.Size(83, 20);
			this.flimit.TabIndex = 22;
			// 
			// uvsync
			// 
			this.uvsync.Location = new System.Drawing.Point(9, 264);
			this.uvsync.Name = "uvsync";
			this.uvsync.Size = new System.Drawing.Size(104, 24);
			this.uvsync.TabIndex = 23;
			this.uvsync.Text = "Use VSync";
			this.uvsync.UseVisualStyleBackColor = true;
			// 
			// wmode
			// 
			this.wmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.wmode.FormattingEnabled = true;
			this.wmode.Items.AddRange(new object[] {
			"Windowed",
			"Bordless Windowed",
			"Fullscreen"});
			this.wmode.Location = new System.Drawing.Point(9, 295);
			this.wmode.Name = "wmode";
			this.wmode.Size = new System.Drawing.Size(121, 21);
			this.wmode.TabIndex = 24;
			this.wmode.SelectedIndexChanged += new System.EventHandler(this.WmodeSelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(507, 461);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 25;
			this.button1.Text = "Write";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 496);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.wmode);
			this.Controls.Add(this.uvsync);
			this.Controls.Add(this.flimit);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.resy);
			this.Controls.Add(this.resx);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.follevel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.fxlevel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txlevel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pplevel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.shadowlevel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.aalevel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.vdist);
			this.Controls.Add(this.lres);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Fear The Wolves Config Tweaker";
			((System.ComponentModel.ISupportInitialize)(this.vdist)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aalevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shadowlevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pplevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txlevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fxlevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.follevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resx)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flimit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
