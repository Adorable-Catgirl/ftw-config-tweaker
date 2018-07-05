/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 7/5/2018
 * Time: 12:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using IniParser;
using IniParser.Model;

namespace FTWConfigTweaker
{
	/// <summary>
	/// Description of FTWConfig.
	/// </summary>
	public static class FTWConfig
	{
		public static bool sgRes = false;
		public static byte sgVisDist = 0;
		public static byte sgAAQuality = 0;
		public static byte sgShadowQuality = 0;
		public static byte sgPPQuality = 0;
		public static byte sgTxQuality = 0;
		public static byte sgFxQuality = 0;
		public static byte sgFolQuality = 0;
		public static ushort ResX = 0;
		public static ushort ResY = 0;
		public static bool vsync = false;
		public static byte fsmode = 0;
		static IniData ini;
		static FileIniDataParser parser;
		public static void LoadConfig() {
			parser = new FileIniDataParser();
			ini = parser.ReadFile(@"C:\Users\"+Environment.UserName+@"\AppData\Local\FearTheWolves\Saved\Config\WindowsNoEditor\GameUserSettings.ini");
			sgRes = double.Parse(ini["ScalabilityGroups"]["sg.ResolutionQuality"]) < 100;
			sgVisDist = byte.Parse(ini["ScalabilityGroups"]["sg.ViewDistanceQuality"]);
			sgAAQuality = byte.Parse(ini["ScalabilityGroups"]["sg.AntiAliasingQuality"]);
			sgShadowQuality = byte.Parse(ini["ScalabilityGroups"]["sg.ShadowQuality"]);
			sgPPQuality = byte.Parse(ini["ScalabilityGroups"]["sg.PostProcessQuality"]);
			sgTxQuality = byte.Parse(ini["ScalabilityGroups"]["sg.TextureQuality"]);
			sgFxQuality = byte.Parse(ini["ScalabilityGroups"]["sg.EffectsQuality"]);
			sgFolQuality = byte.Parse(ini["ScalabilityGroups"]["sg.FoliageQuality"]);
			ResX = ushort.Parse(ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["ResolutionSizeX"]);
			ResY = ushort.Parse(ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["ResolutionSizeY"]);
			vsync = bool.Parse(ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["bUseVSync"]);
		}
		public static void WriteConfig() {
			ini["ScalabilityGroups"]["sg.ResolutionQuality"] = sgRes ? "75" : "100";
			ini["ScalabilityGroups"]["sg.ViewDistanceQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.AntiAliasingQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.ShadowQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.PostProcessQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.TextureQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.EffectsQuality"] = sgVisDist.ToString();
			ini["ScalabilityGroups"]["sg.FoliageQuality"] = sgVisDist.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["ResolutionSizeX"] = ResX.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["ResolutionSizeY"] = ResY.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["DesiredScreenWidth"] = ResX.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["DesiredScreenHeight"] = ResY.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["LastUserConfirmedResolutionSizeX"] = ResX.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["LastUserConfirmedResolutionSizeY"] = ResY.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["FullscreenMode"] = fsmode.ToString();
			ini["/Game/Blueprints/Core/TLSGameUserSettings_BP.TLSGameUserSettings_BP_C"]["bUseVSync"] = upperfirst(vsync.ToString());
			parser.WriteFile(@"C:\Users\"+Environment.UserName+@"\AppData\Local\FearTheWolves\Saved\Config\WindowsNoEditor\GameUserSettings.ini", ini);
		}
		static string upperfirst(string s)
	    {
	        return char.ToUpper(s[0]) + s.Substring(1);
	    }
	}
}
