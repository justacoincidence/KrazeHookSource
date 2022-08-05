using System;
using System.Collections.Generic;
using MelonLoader;
using MezHud;
using ns0;
using ns2;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ns4
{
	// Token: 0x0200003C RID: 60
	internal class Class23
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00003036 File Offset: 0x00001236
		private static void smethod_0(string string_1)
		{
			GameObject.Find("/Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, string_1);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00008FAC File Offset: 0x000071AC
		public static void smethod_1()
		{
			if (Class3.smethod_1() == Class23.string_0)
			{
				MelonLogger.Msg("Sending all Undon events to Murder 4 [" + Class23.string_0 + "]");
				MezHudLog.Msg("Sending all events to Murder 4", 2.5f);
				Class23.smethod_5();
				Class23.smethod_6();
				Class23.smethod_7();
				Class23.smethod_8();
				Class23.smethod_9();
				Class23.smethod_10();
				Class23.smethod_11();
				Class23.smethod_12();
				Class23.smethod_14();
				Class23.smethod_15();
				Class23.smethod_16();
				Class23.smethod_17();
				Class23.smethod_2();
				Class23.smethod_3();
				Class23.smethod_4();
				Class23.smethod_13();
			}
			else if (!(Class3.smethod_1() == Class22.string_0))
			{
				MelonLogger.Msg("Invalid world type! Please go to Among Us or Murder 4");
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000304E File Offset: 0x0000124E
		public static void smethod_2()
		{
			if (Class6.smethod_13())
			{
				Class23.smethod_0("SyncVictoryB");
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00003061 File Offset: 0x00001261
		public static void smethod_3()
		{
			if (Class6.smethod_13())
			{
				Class23.smethod_0("SyncVictoryM");
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003074 File Offset: 0x00001274
		public static void smethod_4()
		{
			if (Class6.smethod_13())
			{
				Class23.smethod_0("KillLocalPlayer");
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00009060 File Offset: 0x00007260
		public static void smethod_5()
		{
			if (Class6.smethod_13())
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Frag"))
					{
						Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, gameObject);
						gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
					}
				}
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000910C File Offset: 0x0000730C
		public static void smethod_6()
		{
			if (Class6.smethod_13())
			{
				Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, GameObject.Find("/Game Logic").transform.Find("Weapons/Revolver").gameObject);
				GameObject.Find("/Game Logic").transform.Find("Weapons/Revolver").gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000091A8 File Offset: 0x000073A8
		public static void smethod_7()
		{
			if (Class6.smethod_13())
			{
				List<GameObject> list = new List<GameObject>
				{
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (0)").gameObject,
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (1)").gameObject,
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (2)").gameObject,
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (3)").gameObject,
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (4)").gameObject,
					GameObject.Find("Game Logic").transform.Find("Weapons/Knife (5)").gameObject
				};
				foreach (GameObject gameObject in list)
				{
					Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, gameObject);
					gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00009320 File Offset: 0x00007520
		public static void smethod_8()
		{
			if (Class6.smethod_13())
			{
				Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, GameObject.Find("Game Logic").transform.Find("Luger").gameObject);
				GameObject.Find("Game Logic").transform.Find("Luger").gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000093BC File Offset: 0x000075BC
		public static void smethod_9()
		{
			if (Class6.smethod_13())
			{
				Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, GameObject.Find("Game Logic").transform.Find("Shotgun").gameObject);
				GameObject.Find("Game Logic").transform.Find("Shotgun").gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009458 File Offset: 0x00007658
		public static void smethod_10()
		{
			if (Class6.smethod_13())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncStartGame");
				}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000094B4 File Offset: 0x000076B4
		public static void smethod_11()
		{
			if (Class6.smethod_13())
			{
				foreach (GameObject gameObject in Resources.FindObjectsOfTypeAll<GameObject>())
				{
					if (gameObject.name.Contains("Bear Trap"))
					{
						Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, gameObject);
						gameObject.transform.position = Class6.smethod_0().smethod_2().transform.position + new Vector3(0f, 0.1f, 0f);
					}
				}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00009560 File Offset: 0x00007760
		public static void smethod_12()
		{
			if (Class6.smethod_13())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "OnLocalPlayerFlashbanged");
					udonBehaviour.SendCustomNetworkEvent(0, "OnLocalPlayerBlinded");
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003087 File Offset: 0x00001287
		public static void smethod_13()
		{
			if (Class6.smethod_13())
			{
				Class23.smethod_0("SyncAbort");
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000095C8 File Offset: 0x000077C8
		public static void smethod_14()
		{
			if (Class6.smethod_13())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncCluesFinished");
					udonBehaviour.SendCustomNetworkEvent(0, "OnPlayerUnlockedClues");
					udonBehaviour.SendCustomNetworkEvent(0, "OnCollectClue");
				}
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000963C File Offset: 0x0000783C
		public static void smethod_15()
		{
			if (Class6.smethod_13())
			{
				foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
				{
					udonBehaviour.SendCustomNetworkEvent(0, "SyncAssignM");
				}
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00009698 File Offset: 0x00007898
		public static void smethod_16()
		{
			foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
			{
				udonBehaviour.SendCustomNetworkEvent(0, "SyncUnlockMinigameComplete");
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000096EC File Offset: 0x000078EC
		public static void smethod_17()
		{
			List<GameObject> list = new List<GameObject>
			{
				GameObject.Find("Game Logic").transform.Find("Switch Boxes/Switchbox (0)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Switch Boxes/Switchbox (1)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Switch Boxes/Switchbox (2)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Switch Boxes/Switchbox (3)").gameObject
			};
			foreach (GameObject gameObject in list)
			{
				gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SwitchDown");
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class23()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000309A File Offset: 0x0000129A
		// Note: this type is marked as 'beforefieldinit'.
		static Class23()
		{
			Class39.smethod_16();
			Class23.string_0 = "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe";
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000030AB File Offset: 0x000012AB
		internal static bool smethod_18()
		{
			return Class23.class23_0 == null;
		}

		// Token: 0x04000129 RID: 297
		public static string string_0;

		// Token: 0x0400012A RID: 298
		private static Class23 class23_0;
	}
}
