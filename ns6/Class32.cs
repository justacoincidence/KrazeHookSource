using System;
using System.Diagnostics;
using System.Threading;
using MelonLoader;
using VRC.Core;

namespace ns6
{
	// Token: 0x0200004C RID: 76
	internal class Class32
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public static void smethod_0()
		{
			MelonLogger.Msg("Checking for blacklisted user IDs...");
			if (APIUser.CurrentUser.id == Class32.string_0)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_1)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_2)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_3)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_4)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_5)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_6)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_7)
			{
				Class32.smethod_1();
			}
			if (APIUser.CurrentUser.id == Class32.string_8)
			{
				Class32.smethod_1();
			}
			MelonLogger.Msg(string.Format("Banned: {0} Blacklisted User IDs from KrazeHook!", 8));
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000A804 File Offset: 0x00008A04
		public static void smethod_1()
		{
			Console.Clear();
			Console.Title = "Kraze Hook Authorization";
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("The following User ID is banned: " + APIUser.CurrentUser.id);
			Console.WriteLine("");
			Console.WriteLine("YOU ARE BLACKLISTED");
			Console.Beep();
			Console.WriteLine("YOU ARE BLACKLISTED");
			Console.Beep();
			Console.WriteLine("YOU ARE BLACKLISTED");
			Console.Beep();
			Console.WriteLine("YOU ARE BLACKLISTED");
			Console.Beep();
			Console.WriteLine("");
			Console.WriteLine("Closing in 10 seconds...");
			Thread.Sleep(10000);
			foreach (Process process in Process.GetProcessesByName("Discord"))
			{
				process.Kill();
			}
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class32()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		// Note: this type is marked as 'beforefieldinit'.
		static Class32()
		{
			Class39.smethod_16();
			Class32.string_0 = "usr_a9e0411e-5389-4ecd-9e7a-142a75a19495";
			Class32.string_1 = "usr_d8e9c2a7-891b-4fba-9c88-d007b789dc21";
			Class32.string_2 = "usr_9c7614a1-f501-4263-8663-aa3c6f8755f5";
			Class32.string_3 = "usr_1ba7526c-3df7-441a-8f22-865f6bf1d84f";
			Class32.string_4 = "usr_7e2f9c37-c222-4f70-85c9-910848fb783a";
			Class32.string_5 = "usr_c51684d4-6d55-4f2b-902d-c44c5fc72020";
			Class32.string_6 = "usr_a9ab7b06-b1f0-4837-b97b-c25b6b0c1272";
			Class32.string_7 = "usr_5f7f8999-1b04-4ee3-883e-568697c01eee";
			Class32.string_8 = "usr_66a35e0d-9e68-4313-9642-6a13a1efcba2";
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000349C File Offset: 0x0000169C
		internal static bool smethod_2()
		{
			return Class32.class32_0 == null;
		}

		// Token: 0x0400015C RID: 348
		public static string string_0;

		// Token: 0x0400015D RID: 349
		public static string string_1;

		// Token: 0x0400015E RID: 350
		public static string string_2;

		// Token: 0x0400015F RID: 351
		public static string string_3;

		// Token: 0x04000160 RID: 352
		public static string string_4;

		// Token: 0x04000161 RID: 353
		public static string string_5;

		// Token: 0x04000162 RID: 354
		public static string string_6;

		// Token: 0x04000163 RID: 355
		public static string string_7;

		// Token: 0x04000164 RID: 356
		public static string string_8;

		// Token: 0x04000165 RID: 357
		internal static Class32 class32_0;
	}
}
