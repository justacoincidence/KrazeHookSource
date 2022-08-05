using System;
using MelonLoader;
using MezHud;
using ns0;
using ns2;
using UnityEngine;
using UnityEngine.UI;
using VRC.Udon;

namespace ns4
{
	// Token: 0x0200003B RID: 59
	internal class Class22
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00008834 File Offset: 0x00006A34
		public static void smethod_0()
		{
			if (Class3.smethod_1() == Class22.string_0)
			{
				MelonLogger.Msg("Sending all Undon events to AmongUs [" + Class22.string_0 + "]");
				MezHudLog.Msg("Sending all events to Among Us", 2.5f);
				Class22.smethod_6();
				Class22.smethod_7();
				Class22.smethod_8();
				Class22.smethod_9();
				Class22.smethod_2();
				Class22.smethod_3();
				Class22.smethod_4();
				Class22.smethod_5();
			}
			else if (!(Class3.smethod_1() == Class23.string_0))
			{
				MelonLogger.Msg("Invalid world type! Please go to Among Us or Murder 4");
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000088C0 File Offset: 0x00006AC0
		public static void smethod_1()
		{
			foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
			{
				if (gameObject.name.Contains("Player Entry") && gameObject.GetComponentInChildren<Text>().text != "PlayerName" && gameObject.GetComponent<Image>().color.r > 0f)
				{
					MelonLogger.Msg(gameObject.GetComponentInChildren<Text>().text + " is the imposter");
				}
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008968 File Offset: 0x00006B68
		public static void smethod_2()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "Btn_SkipVoting");
				}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000089C4 File Offset: 0x00006BC4
		public static void smethod_3()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "Btn_Start");
				}
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008A20 File Offset: 0x00006C20
		public static void smethod_4()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncAbort");
				}
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008A7C File Offset: 0x00006C7C
		public static void smethod_5()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "KillLocalPlayer");
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00008AD8 File Offset: 0x00006CD8
		public static void smethod_6()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "StartMeeting");
				}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00008B34 File Offset: 0x00006D34
		public static void smethod_7()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncVictoryM");
				}
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00008B90 File Offset: 0x00006D90
		public static void smethod_8()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncVictoryB");
				}
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00008BEC File Offset: 0x00006DEC
		public static void smethod_9()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncVotedOut");
				}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00008C48 File Offset: 0x00006E48
		public static void smethod_10()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageLights");
				}
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00008CA4 File Offset: 0x00006EA4
		public static void smethod_11()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "OnLocalPlayerCompletedTask");
				}
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00008D00 File Offset: 0x00006F00
		public static void smethod_12()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageOxygen");
				}
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00008D5C File Offset: 0x00006F5C
		public static void smethod_13()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageReactor");
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00008DB8 File Offset: 0x00006FB8
		public static void smethod_14()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageComms");
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00008E14 File Offset: 0x00007014
		public static void smethod_15()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsStorage");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsLower");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsSecurity");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsUpper");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsCafeteria");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageDoorsMedbay");
				}
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00008EAC File Offset: 0x000070AC
		public static void smethod_16()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageComms");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageReactor");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageOxygen");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncDoSabotageLights");
				}
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00008F2C File Offset: 0x0000712C
		public static void smethod_17()
		{
			if (Class6.smethod_12())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncRepairComms");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncRepairReactor");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncRepairOxygen");
					udonBehaviour.SendCustomNetworkEvent(0, "SyncRepairLights");
				}
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class22()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000301B File Offset: 0x0000121B
		// Note: this type is marked as 'beforefieldinit'.
		static Class22()
		{
			Class39.smethod_16();
			Class22.string_0 = "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7";
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000302C File Offset: 0x0000122C
		internal static bool smethod_18()
		{
			return Class22.class22_0 == null;
		}

		// Token: 0x04000127 RID: 295
		public static string string_0;

		// Token: 0x04000128 RID: 296
		private static Class22 class22_0;
	}
}
