using System;
using System.Threading.Tasks;
using KrazeHook.Core;
using MelonLoader;
using MezHud;
using ns0;
using VRC.Core;

namespace ns3
{
	// Token: 0x02000039 RID: 57
	internal class Class21
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00008588 File Offset: 0x00006788
		public static void smethod_0()
		{
			try
			{
				Class21.string_2 = APIUser.CurrentUser.avatarId;
				Class1.smethod_4().smethod_17(true);
				Class1.smethod_30(Class21.string_1);
			}
			catch
			{
				MelonLogger.Msg("Failed to send ID to crash!");
				MezHudLog.Msg("Failed to send ID to crash!", 2.5f);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000085E8 File Offset: 0x000067E8
		public static void smethod_1()
		{
			try
			{
				Class21.string_2 = APIUser.CurrentUser.avatarId;
				Class1.smethod_4().smethod_17(true);
				Class1.smethod_30(Class21.string_0);
			}
			catch
			{
				MelonLogger.Msg("Failed to send ID to crash!");
				MezHudLog.Msg("Failed to send ID to crash!", 2.5f);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002F89 File Offset: 0x00001189
		public static void smethod_2()
		{
			Class1.smethod_30(Class21.string_2);
			Class1.smethod_4().smethod_17(false);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008648 File Offset: 0x00006848
		public static void smethod_3()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			if (Class3.smethod_2() != "")
			{
				Class2.smethod_2(Class3.smethod_2());
			}
			Console.WriteLine(string.Concat(new string[]
			{
				"[",
				Patches.KrazeConsTime,
				"] ",
				Patches.KrazeCons,
				" COPIED: ",
				Class3.smethod_2()
			}));
			MezHudLog.Msg("COPIED: " + Class3.smethod_2(), 2.5f);
			Console.ForegroundColor = ConsoleColor.White;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000086D8 File Offset: 0x000068D8
		public static void smethod_4()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			VRCFlowManager.Method_Public_Static_get_VRCFlowManager_PDM_0().Method_Public_Void_String_WorldTransitionInfo_Action_1_String_Boolean_0(Class2.smethod_1(), null, null, true);
			Console.WriteLine(string.Concat(new string[]
			{
				"[",
				Patches.KrazeConsTime,
				"] ",
				Patches.KrazeCons,
				" JOINING: ",
				Class2.smethod_1()
			}));
			MezHudLog.Msg("JOINING: " + Class2.smethod_1(), 2.5f);
			Console.ForegroundColor = ConsoleColor.White;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002FA0 File Offset: 0x000011A0
		public static void smethod_5()
		{
			VRCFlowManager.Method_Public_Static_get_VRCFlowManager_PDM_0().Method_Public_Void_String_WorldTransitionInfo_Action_1_String_Boolean_0(Class3.smethod_2(), null, null, true);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002FB4 File Offset: 0x000011B4
		public static void smethod_6()
		{
			Task.Run(new Action(Class21.<>c.<>c_0.method_0));
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class21()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002FDB File Offset: 0x000011DB
		// Note: this type is marked as 'beforefieldinit'.
		static Class21()
		{
			Class39.smethod_16();
			Class21.string_0 = "avtr_76c6a4ce-3b7e-4a5f-8802-f3e649926548";
			Class21.string_1 = "";
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002FF6 File Offset: 0x000011F6
		internal static bool smethod_7()
		{
			return Class21.class21_0 == null;
		}

		// Token: 0x04000120 RID: 288
		public static string string_0;

		// Token: 0x04000121 RID: 289
		public static string string_1;

		// Token: 0x04000122 RID: 290
		public static string string_2;

		// Token: 0x04000123 RID: 291
		private static Class21 class21_0;
	}
}
