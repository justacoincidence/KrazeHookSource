using System;
using System.Reflection;
using HarmonyLib;
using MelonLoader;
using MezHud;
using VRC;

namespace KrazeHook.Core
{
	// Token: 0x02000050 RID: 80
	public static class Patches
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0000AD64 File Offset: 0x00008F64
		private static HarmonyMethod smethod_0(string string_0)
		{
			return new HarmonyMethod(typeof(Patches).GetMethod(string_0, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public static void Initialize()
		{
			Patches.harmony_0.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), Patches.smethod_0("PlayerJoinedPatch"), null, null, null, null);
			Patches.harmony_0.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_1"), Patches.smethod_0("PlayerLeftPatch"), null, null, null, null);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		private static void PlayerJoinedPatch(object __0)
		{
			Class36 @class = __0.transform.Find("Player Nameplate/Canvas/Nameplate").gameObject.AddComponent<Class36>();
			@class.player_0 = __0;
			MezHudLog.Msg("Player Joined: " + __0.field_Private_APIUser_0.displayName + " (More Info in Console)", 2.5f);
			MelonLogger.Msg("Player Joined: " + __0.field_Private_APIUser_0.displayName);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(string.Concat(new string[]
			{
				"[",
				Patches.KrazeConsTime,
				"] ",
				Patches.KrazeCons,
				" INFO: [ID] ",
				__0.field_Private_APIUser_0.id
			}));
			Console.WriteLine(string.Format("[{0}] {1} INFO: [isFriend] {2}", Patches.KrazeConsTime, Patches.KrazeCons, __0.field_Private_APIUser_0.isFriend));
			Console.WriteLine(string.Format("[{0}] {1} INFO: [isMod] {2}", Patches.KrazeConsTime, Patches.KrazeCons, __0.field_Private_APIUser_0.hasModerationPowers));
			Console.WriteLine(string.Concat(new string[]
			{
				"[",
				Patches.KrazeConsTime,
				"] ",
				Patches.KrazeCons,
				" INFO: [AVATAR] ",
				__0.Method_Public_get_ApiAvatar_0().name
			}));
			Console.ForegroundColor = ConsoleColor.White;
			string b = "usr_803dfe55-8827-4f3f-b891-b147f495ed77";
			if (__0.field_Private_APIUser_0.id == b)
			{
				MezHudLog.Msg("<color=#d000ff>CLIENT OWNER JOINED</color>", 5f);
			}
			if (__0.field_Private_APIUser_0.hasModerationPowers)
			{
				MezHudLog.Msg("[WARNING] <color=#ff0000>ADMIN IS IN LOBBY: " + __0.field_Private_APIUser_0.displayName + "</color>", 5f);
				MezHudLog.Msg("[WARNING] <color=#ff0000>ADMIN IS IN LOBBY: " + __0.field_Private_APIUser_0.displayName + "</color>", 5f);
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine(string.Concat(new string[]
				{
					"[",
					Patches.KrazeConsTime,
					"] ",
					Patches.KrazeCons,
					" ALERT: [MODERATOR / ADMIN] There is a VRChat mod in the lobby!"
				}));
				Console.WriteLine(string.Concat(new string[]
				{
					"[",
					Patches.KrazeConsTime,
					"] ",
					Patches.KrazeCons,
					" ALERT: [MODERATOR / ADMIN] There is a VRChat mod in the lobby!"
				}));
				Console.WriteLine(string.Concat(new string[]
				{
					"[",
					Patches.KrazeConsTime,
					"] ",
					Patches.KrazeCons,
					" ALERT: [MODERATOR / ADMIN] There is a VRChat mod in the lobby!"
				}));
				Console.WriteLine(string.Concat(new string[]
				{
					"[",
					Patches.KrazeConsTime,
					"] ",
					Patches.KrazeCons,
					" ALERT: [MODERATOR / ADMIN] There is a VRChat mod in the lobby!"
				}));
				Console.ForegroundColor = ConsoleColor.White;
				if (Patches.LeaveOnAdmin)
				{
					VRCFlowManager.Method_Public_Static_get_VRCFlowManager_PDM_0().Method_Public_Void_String_WorldTransitionInfo_Action_1_String_Boolean_0(__0.Method_Internal_get_APIUser_0().homeLocation, null, null, true);
				}
			}
			Class10.smethod_2();
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000034F0 File Offset: 0x000016F0
		private static void PlayerLeftPatch(Player __0)
		{
			MezHudLog.Msg("Player Left: " + __0.field_Private_APIUser_0.displayName, 2.5f);
			MelonLogger.Msg("Player Left: " + __0.field_Private_APIUser_0.displayName);
			Class10.smethod_2();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B0E0 File Offset: 0x000092E0
		// Note: this type is marked as 'beforefieldinit'.
		static Patches()
		{
			Class39.smethod_16();
			Patches.KrazeCons = "[Kraze-Hook] >>>";
			Patches.LeaveOnAdmin = false;
			Patches.KrazeConsTime = string.Format("{0}", DateTime.Now);
			Patches.harmony_0 = new Harmony(Guid.NewGuid().ToString());
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003530 File Offset: 0x00001730
		internal static bool smethod_1()
		{
			return Patches.patches_0 == null;
		}

		// Token: 0x0400016A RID: 362
		public static string KrazeCons;

		// Token: 0x0400016B RID: 363
		public static bool LeaveOnAdmin;

		// Token: 0x0400016C RID: 364
		public static string KrazeConsTime;

		// Token: 0x0400016D RID: 365
		private static Harmony harmony_0;

		// Token: 0x0400016E RID: 366
		internal static Patches patches_0;
	}
}
