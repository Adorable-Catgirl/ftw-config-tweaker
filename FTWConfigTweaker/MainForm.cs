/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 7/5/2018
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FTWConfigTweaker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			FTWConfig.LoadConfig();
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			lres.Checked = FTWConfig.sgRes;
			vdist.Value = FTWConfig.sgVisDist;
			shadowlevel.Value = FTWConfig.sgShadowQuality;
			aalevel.Value = FTWConfig.sgAAQuality;
			pplevel.Value = FTWConfig.sgPPQuality;
			fxlevel.Value = FTWConfig.sgFxQuality;
			follevel.Value = FTWConfig.sgFolQuality;
			txlevel.Value = FTWConfig.sgTxQuality;
			resx.Value = FTWConfig.ResX;
			resy.Value = FTWConfig.ResY;
			uvsync.Checked = FTWConfig.vsync;
			wmode.SelectedIndex = FTWConfig.fsmode;
			Console.WriteLine(wmode.SelectedIndex);
		}
		void Button1Click(object sender, EventArgs e)
		{
			FTWConfig.sgRes = lres.Checked;
			FTWConfig.sgVisDist = (byte) vdist.Value;
			FTWConfig.sgShadowQuality = (byte) shadowlevel.Value;
			FTWConfig.sgAAQuality = (byte) aalevel.Value;
			FTWConfig.sgPPQuality = (byte) pplevel.Value;
			FTWConfig.sgFxQuality = (byte) fxlevel.Value;
			FTWConfig.sgFolQuality = (byte) follevel.Value;
			FTWConfig.sgTxQuality = (byte) txlevel.Value;
			FTWConfig.ResX = (ushort) resx.Value;
			FTWConfig.ResY = (ushort) resy.Value;
			FTWConfig.vsync = uvsync.Checked;
			FTWConfig.fsmode = (byte) wmode.SelectedIndex;
			FTWConfig.WriteConfig();
		}
		void WmodeSelectedIndexChanged(object sender, EventArgs e)
		{
			Console.WriteLine(wmode.SelectedIndex);
		}
	}
}
