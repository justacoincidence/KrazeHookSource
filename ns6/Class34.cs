using System;
using System.IO;
using System.Net;
using MelonLoader;

namespace ns6
{
	// Token: 0x0200004F RID: 79
	internal class Class34
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public static void smethod_0()
		{
			MelonLogger.Msg("Loading client Directories...");
			MelonLogger.Msg("This May Take A While!");
			if (!Directory.Exists(Class34.string_0 ?? ""))
			{
				Directory.CreateDirectory(Class34.string_0 ?? "");
			}
			if (!Directory.Exists(Class34.string_0 + "\\Dependencies"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\Dependencies");
			}
			if (!Directory.Exists(Class34.string_0 + "\\VRCAs"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\VRCAs");
			}
			if (!Directory.Exists(Class34.string_0 + "\\VRCWs"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\VRCWs");
			}
			if (!Directory.Exists(Class34.string_0 + "\\Settings"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\Settings");
			}
			if (!Directory.Exists(Class34.string_0 + "\\Misc"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\Misc");
			}
			if (!Directory.Exists(Class34.string_0 + "\\Misc\\Extra"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\Misc\\Extra");
			}
			if (!Directory.Exists(Class34.string_0 + "\\Loading"))
			{
				Directory.CreateDirectory(Class34.string_0 + "\\Loading");
			}
			MelonLogger.Msg("Done!");
			MelonLogger.Msg("Writing Client Files...");
			if (!File.Exists(Class34.string_0 + "\\Settings\\ClientSave.json"))
			{
				File.WriteAllText(Class34.string_0 + "\\Settings\\ClientSave.json", "[This will have the all client's configs once loaded]");
			}
			if (!File.Exists(Class34.string_0 + "\\Settings\\AvatarProtectionSettings.json"))
			{
				File.WriteAllText(Class34.string_0 + "\\Settings\\AvatarProtectionSettings.json", "{}");
			}
			if (File.Exists(Class34.string_0 + "\\Settings\\MeshAnti.json"))
			{
				File.Delete(Class34.string_0 + "\\Settings\\MeshAnti.json");
			}
			if (File.Exists(Class34.string_0 + "\\Settings\\ShaderAnti.json"))
			{
				File.Delete(Class34.string_0 + "\\Settings\\ShaderAnti.json");
			}
			if (File.Exists(Class34.string_0 + "\\Settings\\CFG.json"))
			{
				File.Delete(Class34.string_0 + "\\Settings\\CFG.json");
			}
			if (File.Exists(Class34.string_0 + "\\Settings\\ClientSave.json"))
			{
				File.WriteAllText(Class34.string_0 + "\\Settings\\ClientSave.json", "[This will have the all client's configs once loaded]");
			}
			MelonLogger.Msg("Done!");
			MelonLogger.Msg("Starting file installs...");
			if (!File.Exists(Class34.string_0 + "\\Loading\\loading.ogg"))
			{
				MelonLogger.Msg("Installing loading song...");
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://sussy.ga/krazehook/loading.ogg", Class34.string_0 + "\\Loading\\loading.ogg");
				MelonLogger.Msg("Installed loading song [1/2]");
			}
			if (!File.Exists(Class34.string_0 + "\\Dependencies\\discord-rpc.dll"))
			{
				WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://sussy.ga/krazehook/discord-rpc.dll", Class34.string_0 + "\\Dependencies\\discord-rpc.dll");
				MelonLogger.Msg("Installed Discord RPC");
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class34()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000034CB File Offset: 0x000016CB
		// Note: this type is marked as 'beforefieldinit'.
		static Class34()
		{
			Class39.smethod_16();
			Class34.string_0 = MelonUtils.GameDirectory + "\\KrazeHook";
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000034E6 File Offset: 0x000016E6
		internal static bool smethod_1()
		{
			return Class34.class34_0 == null;
		}

		// Token: 0x04000168 RID: 360
		public static string string_0;

		// Token: 0x04000169 RID: 361
		internal static Class34 class34_0;
	}
}
