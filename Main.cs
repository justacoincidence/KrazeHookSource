using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using HarmonyLib;
using IKMod.IKHandler;
using KrazeHook.Core;
using KrazeHook.Modules;
using MelonLoader;
using MezHud;
using ns3;
using ns5;
using ns6;
using UnhollowerRuntimeLib;
using UnityEngine;
using VRC;
using VRC.UI.Elements;

namespace KrazeHook
{
	// Token: 0x0200000F RID: 15
	public class Main : MelonMod
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00004004 File Offset: 0x00002204
		public override void OnApplicationStart()
		{
			Console.Title = "Loading KrazeHook...";
			MelonLogger.Msg("Initializing Mod...");
			Class34.smethod_0();
			Patches.Initialize();
			Class33.smethod_0();
			this.method_0().Start();
			Main.smethod_0().Start();
			Main.smethod_1().Start();
			ClassInjector.RegisterTypeInIl2Cpp<IKComponent>();
			Console.Title = "K R A Z E  -  H O O K";
			MelonCoroutines.Start(Class31.smethod_0());
			ClassInjector.RegisterTypeInIl2Cpp<Class36>();
			Class15.smethod_0();
			Thread.Sleep(1000);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
			Console.WriteLine("[X]=============================================================================================[X]");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("                                                                                                   ");
			Console.WriteLine("$$\\   $$\\ $$$$$$$\\   $$$$$$\\  $$$$$$$$\\ $$$$$$$$\\         $$\\   $$\\  $$$$$$\\   $$$$$$\\  $$\\   $$\\ ");
			Console.WriteLine("$$ | $$  |$$  __$$\\ $$  __$$\\ \\____$$  |$$  _____|        $$ |  $$ |$$  __$$\\ $$  __$$\\ $$ | $$  |");
			Console.WriteLine("$$ |$$  / $$ |  $$ |$$ /  $$ |    $$  / $$ |              $$ |  $$ |$$ /  $$ |$$ /  $$ |$$ |$$  / ");
			Console.WriteLine("$$$$$  /  $$$$$$$  |$$$$$$$$ |   $$  /  $$$$$\\    $$$$$$\\ $$$$$$$$ |$$ |  $$ |$$ |  $$ |$$$$$  /  ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("$$  $$<   $$  __$$< $$  __$$ |  $$  /   $$  __|   \\______|$$  __$$ |$$ |  $$ |$$ |  $$ |$$  $$<   ");
			Console.WriteLine("$$ |\\$$\\  $$ |  $$ |$$ |  $$ | $$  /    $$ |              $$ |  $$ |$$ |  $$ |$$ |  $$ |$$ |\\$$\\  ");
			Console.WriteLine("$$ | \\$$\\ $$ |  $$ |$$ |  $$ |$$$$$$$$\\ $$$$$$$$\\         $$ |  $$ | $$$$$$  | $$$$$$  |$$ | \\$$\\ ");
			Console.WriteLine("\\__|  \\__|\\__|  \\__|\\__|  \\__|\\________|\\________|        \\__|  \\__| \\______/  \\______/ \\__|  \\__|");
			Console.WriteLine("                                                                                                   ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("[X]===================================== VERSION " + UI.RpcVersions + " ===========================================[X]");
			MelonLogger.Msg("");
			Main.Modules.Add(new UI());
			foreach (KModule kmodule in Main.Modules)
			{
				kmodule.Start();
			}
			MelonLogger.Msg("[==========] KEYBINDS [==========]");
			MelonLogger.Msg("Fly: Ctrl + F");
			Class9.smethod_2();
			MelonLogger.Msg("Speed: Ctrl + Y");
			MelonLogger.Msg("[==========] KEYBINDS [==========]");
			Class10.smethod_0();
			base.HarmonyInstance.Patch(typeof(NetworkManager).GetMethod("OnJoinedRoom"), new HarmonyMethod(typeof(Main).GetMethod("OnRoomJoin", BindingFlags.Static | BindingFlags.NonPublic)), null, null, null, null);
			MelonCoroutines.Start(MezHudLog.MakeUI());
			MelonLogger.Msg("Successfully initialized the client!");
			MelonLogger.Msg("[==========] TIME INFO [==========]");
			MelonLogger.Msg(string.Format("UTC: {0}", DateTime.UtcNow));
			MelonLogger.Msg(string.Format("Date: {0}", DateTime.Today));
			MelonLogger.Msg("[==========] TIME INFO [==========]");
			MelonLogger.Msg("");
			MelonLogger.Msg("Thank you for using KrazeHook :)");
			Class25.smethod_4();
			MelonCoroutines.Start(Class25.smethod_0());
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022F9 File Offset: 0x000004F9
		private static void OnRoomJoin()
		{
			MelonCoroutines.Start(Main.AddComponent());
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002306 File Offset: 0x00000506
		public override void OnPreferencesSaved()
		{
			Main._zKey = Class8.smethod_1();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002312 File Offset: 0x00000512
		public override void OnApplicationLateStart()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004284 File Offset: 0x00002484
		public override void OnUpdate()
		{
			Class25.smethod_1();
			try
			{
				foreach (Player player in PlayerManager.Method_Public_Static_get_PlayerManager_0().field_Private_List_1_Player_0)
				{
					if (player.Method_Internal_get_APIUser_0().allowAvatarCopying.Equals(false))
					{
						player.Method_Internal_get_APIUser_0().allowAvatarCopying = true;
					}
				}
			}
			catch (NullReferenceException)
			{
			}
			Class9.smethod_3();
			Class12.smethod_0();
			if (Main.InfJump)
			{
				Class13.smethod_4();
			}
			if (Main.KeybindsOn)
			{
				bool flag = false;
				if (Input.GetKey(306) && Input.GetKeyDown(102))
				{
					if (flag)
					{
						if (flag)
						{
							flag.Equals(false);
							Class13.smethod_3();
						}
					}
					else
					{
						Class13.smethod_2();
						flag.Equals(true);
					}
				}
				bool flag2 = false;
				if (Input.GetKey(306) && Input.GetKeyDown(121))
				{
					if (flag2)
					{
						if (flag2)
						{
							flag2.Equals(false);
							Class13.smethod_1();
						}
					}
					else
					{
						Class13.smethod_0();
						flag2.Equals(true);
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004394 File Offset: 0x00002594
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			if (buildIndex == -1)
			{
				Main.smethod_2().Start();
				Main.smethod_3().Start();
			}
			if (buildIndex == 1)
			{
				MelonCoroutines.Start(this.method_2());
			}
			if (buildIndex == 2)
			{
				MelonCoroutines.Start(this.method_1());
			}
			foreach (KModule kmodule in Main.Modules)
			{
				kmodule.SceneLoaded(buildIndex, sceneName);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002314 File Offset: 0x00000514
		private IEnumerator method_0()
		{
			while (Object.FindObjectOfType<QuickMenu>() == null)
			{
				yield return null;
			}
			foreach (KModule i in Main.Modules)
			{
				i.QuickMenuInit();
				i = null;
			}
			List<KModule>.Enumerator enumerator = default(List<KModule>.Enumerator);
			yield break;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002323 File Offset: 0x00000523
		private static IEnumerator smethod_0()
		{
			while (VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0() == null)
			{
				yield return null;
				int num;
				if (num != 1)
				{
					yield break;
				}
			}
			foreach (KModule i in Main.Modules)
			{
				i.SocialMenuInit();
				i = null;
			}
			List<KModule>.Enumerator enumerator = default(List<KModule>.Enumerator);
			yield break;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000232B File Offset: 0x0000052B
		private static IEnumerator smethod_1()
		{
			return new Main.<WaitForHUD>d__26(0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002333 File Offset: 0x00000533
		private static IEnumerator smethod_2()
		{
			while (RoomManager.field_Internal_Static_ApiWorld_0 == null)
			{
				yield return null;
			}
			while (RoomManager.field_Internal_Static_ApiWorldInstance_0 == null)
			{
				yield return null;
			}
			foreach (KModule i in Main.Modules)
			{
				i.WorldLoaded(RoomManager.field_Internal_Static_ApiWorld_0, RoomManager.field_Internal_Static_ApiWorldInstance_0);
				i = null;
			}
			List<KModule>.Enumerator enumerator = default(List<KModule>.Enumerator);
			Class10.smethod_1();
			yield break;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000233B File Offset: 0x0000053B
		private static IEnumerator smethod_3()
		{
			return new Main.<WaitForPlayer>d__28(0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004428 File Offset: 0x00002628
		private static string smethod_4()
		{
			string[] files = Directory.GetFiles(Class34.string_0 + "\\Loading");
			foreach (string text in files)
			{
				if (!text.EndsWith(".wav") && !text.EndsWith(".ogg"))
				{
					if (text.EndsWith(".mp3"))
					{
						MelonLogger.Msg("Loading Song must be .ogg");
					}
					else if (text.EndsWith(".aiff"))
					{
						MelonLogger.Msg("Loading Song must be .ogg");
					}
					else
					{
						MelonLogger.Msg("Setting Up Loading Music...");
					}
				}
			}
			files = Directory.GetFiles(Class34.string_0 + "\\Loading");
			string result;
			if (files.Length == 0)
			{
				Main.bool_0 = true;
				int num = Main.random_0.Next(files.Length);
				result = files[num - 1];
			}
			else
			{
				result = files[0];
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002343 File Offset: 0x00000543
		private IEnumerator method_1()
		{
			Main.<ChangeLoadingScreen>d__32 <ChangeLoadingScreen>d__ = new Main.<ChangeLoadingScreen>d__32(0);
			<ChangeLoadingScreen>d__.<>4__this = this;
			return <ChangeLoadingScreen>d__;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002352 File Offset: 0x00000552
		private IEnumerator method_2()
		{
			Main.<LoadingScreen>d__33 <LoadingScreen>d__ = new Main.<LoadingScreen>d__33(0);
			<LoadingScreen>d__.<>4__this = this;
			return <LoadingScreen>d__;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002361 File Offset: 0x00000561
		public static IEnumerator AddComponent()
		{
			return new Main.<AddComponent>d__34(0);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002369 File Offset: 0x00000569
		public override void OnApplicationQuit()
		{
			MelonPreferences.Save();
			MelonLogger.Msg("Saved Prefs!");
			Process.GetCurrentProcess().Kill();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002384 File Offset: 0x00000584
		public Main()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000044FC File Offset: 0x000026FC
		// Note: this type is marked as 'beforefieldinit'.
		static Main()
		{
			Class39.smethod_16();
			Main.Modules = new List<KModule>();
			Main.InfJump = false;
			Main.bool_0 = false;
			Main.KeybindsOn = false;
			Main._preZoom = 60f;
			Main._zKey = 308;
			Main.random_0 = new Random();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002391 File Offset: 0x00000591
		internal static bool smethod_5()
		{
			return Main.main_0 == null;
		}

		// Token: 0x04000026 RID: 38
		public static List<KModule> Modules;

		// Token: 0x04000027 RID: 39
		public static bool InfJump;

		// Token: 0x04000028 RID: 40
		private static bool bool_0;

		// Token: 0x04000029 RID: 41
		public static bool KeybindsOn;

		// Token: 0x0400002A RID: 42
		public static MelonPreferences_Category melon;

		// Token: 0x0400002B RID: 43
		internal static MelonPreferences_Entry<bool> melonPreferences_Entry_0;

		// Token: 0x0400002C RID: 44
		internal static MelonPreferences_Entry<bool> melonPreferences_Entry_1;

		// Token: 0x0400002D RID: 45
		internal static MelonPreferences_Entry<bool> melonPreferences_Entry_2;

		// Token: 0x0400002E RID: 46
		internal static MelonPreferences_Entry<float> melonPreferences_Entry_3;

		// Token: 0x0400002F RID: 47
		internal static MelonPreferences_Entry<float> melonPreferences_Entry_4;

		// Token: 0x04000030 RID: 48
		internal static MelonPreferences_Entry<float> melonPreferences_Entry_5;

		// Token: 0x04000031 RID: 49
		internal static MelonPreferences_Entry<string> melonPreferences_Entry_6;

		// Token: 0x04000032 RID: 50
		public static bool _isZoomed;

		// Token: 0x04000033 RID: 51
		public static float _preZoom;

		// Token: 0x04000034 RID: 52
		public static float _lastFOV;

		// Token: 0x04000035 RID: 53
		public static KeyCode _zKey;

		// Token: 0x04000036 RID: 54
		public static GameObject _reticleObj;

		// Token: 0x04000037 RID: 55
		public static GameObject _hudVoiceIcon;

		// Token: 0x04000038 RID: 56
		private static AudioSource audioSource_0;

		// Token: 0x04000039 RID: 57
		private static Random random_0;

		// Token: 0x0400003A RID: 58
		internal static Main main_0;
	}
}
