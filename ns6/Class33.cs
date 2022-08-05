using System;
using System.IO;
using System.Net;
using System.Threading;
using MelonLoader;

namespace ns6
{
	// Token: 0x0200004D RID: 77
	internal class Class33
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0000A93C File Offset: 0x00008B3C
		public static void smethod_0()
		{
			if (!File.Exists(MelonUtils.GameDirectory + "\\Plugins\\KU.dll"))
			{
				MelonLogger.Msg("Loading Updater...");
				WebClient webClient = new WebClient();
				webClient.DownloadFile("http://sussy.ga/krazehook/KU.dll", MelonUtils.GameDirectory + "\\Plugins\\KU.dll");
				MelonLogger.Msg("Done!");
			}
			if (File.Exists(MelonUtils.GameDirectory + "\\Plugins\\KU.dll"))
			{
				MelonLogger.Msg("Loading Updater...");
				WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("http://sussy.ga/krazehook/KU.dll", MelonUtils.GameDirectory + "\\Plugins\\KU.dll");
				MelonLogger.Msg("Done!");
			}
			Thread.Sleep(1000);
			if (File.Exists(MelonUtils.GameDirectory + "\\Plugins\\KU.dll"))
			{
				MelonLogger.Msg("Updater Found!");
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class33()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000034A6 File Offset: 0x000016A6
		internal static bool smethod_1()
		{
			return Class33.class33_0 == null;
		}

		// Token: 0x04000166 RID: 358
		private static Class33 class33_0;
	}
}
