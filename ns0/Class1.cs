using System;
using System.Collections.Generic;
using System.Linq;
using KrazeHook.Core;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.SDKBase;
using VRC.UI;
using VRC.UI.Elements.Menus;

namespace ns0
{
	// Token: 0x02000018 RID: 24
	internal static class Class1
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000024D2 File Offset: 0x000006D2
		public static Player[] smethod_0()
		{
			return PlayerManager.Method_Public_Static_get_PlayerManager_0().Method_Public_get_ArrayOf_Player_0();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004D18 File Offset: 0x00002F18
		public static Player smethod_1(string string_0)
		{
			Class1.<>c__DisplayClass2_0 CS$<>8__locals1 = new Class1.<>c__DisplayClass2_0();
			CS$<>8__locals1.string_0 = string_0;
			return Class1.smethod_0().First(new Func<Player, bool>(CS$<>8__locals1.method_0));
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000024E3 File Offset: 0x000006E3
		public static void smethod_2(this Player player_0)
		{
			VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = player_0.Method_Internal_get_VRCPlayer_1().transform.position;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002504 File Offset: 0x00000704
		public static Player smethod_3()
		{
			return Player.Method_Internal_Static_get_Player_0();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000250B File Offset: 0x0000070B
		public static VRCPlayer smethod_4()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002512 File Offset: 0x00000712
		public static APIUser smethod_5(this Player player_0)
		{
			return player_0.Method_Internal_get_APIUser_0();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000251A File Offset: 0x0000071A
		public static float smethod_6(this Player player_0)
		{
			return (player_0._playerNet.Method_Public_get_Byte_0() != 0) ? Mathf.Floor(1000f / (float)player_0._playerNet.Method_Public_get_Byte_0()) : -1f;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002547 File Offset: 0x00000747
		public static short smethod_7(this Player player_0)
		{
			return player_0._playerNet.field_Private_Int16_0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002554 File Offset: 0x00000754
		public static bool smethod_8(this object object_0)
		{
			return (object_0.smethod_7() <= 0 && object_0.smethod_6() <= 0f) || object_0.transform.position == Vector3.zero;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002584 File Offset: 0x00000784
		public static IUser smethod_9(this SelectedUserMenuQM selectedUserMenuQM_0)
		{
			return selectedUserMenuQM_0.field_Private_IUser_0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000258C File Offset: 0x0000078C
		public static Player smethod_10(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_Player_0();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002594 File Offset: 0x00000794
		public static VRCPlayer smethod_11(this Player player_0)
		{
			return player_0._vrcplayer;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000259C File Offset: 0x0000079C
		public static Color smethod_12(this Player player_0)
		{
			return VRCPlayer.Method_Public_Static_Color_APIUser_0(player_0.Method_Internal_get_APIUser_0());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000025A9 File Offset: 0x000007A9
		public static APIUser smethod_13(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_Player_0().Method_Internal_get_APIUser_0();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000025B6 File Offset: 0x000007B6
		public static VRCPlayerApi smethod_14(this Player player_0)
		{
			return (player_0 != null) ? player_0.Method_Public_get_VRCPlayerApi_0() : null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000025C4 File Offset: 0x000007C4
		public static bool smethod_15(this Player player_0)
		{
			return player_0.smethod_14().isMaster;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000025D1 File Offset: 0x000007D1
		public static int smethod_16(this Player player_0)
		{
			return (player_0.smethod_14() == null) ? -1 : player_0.smethod_14().playerId;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000025E9 File Offset: 0x000007E9
		public static void smethod_17(this VRCPlayer vrcplayer_0, bool bool_0)
		{
			vrcplayer_0.Method_Public_get_Player_0().smethod_18(bool_0);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000025F7 File Offset: 0x000007F7
		public static void smethod_18(this Component component_0, bool bool_0)
		{
			component_0.transform.Find("ForwardDirection").gameObject.active = !bool_0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002617 File Offset: 0x00000817
		public static USpeaker smethod_19(this Player player_0)
		{
			return player_0.Method_Public_get_USpeaker_0();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004D48 File Offset: 0x00002F48
		public static ulong smethod_20(this Player player_0)
		{
			return (player_0._vrcplayer.field_Private_UInt64_0 > 10000000000000000UL) ? player_0._vrcplayer.field_Private_UInt64_0 : ulong.Parse(player_0.Method_Public_get_Player_0().Method_Public_get_Hashtable_0()["steamUserID"].ToString());
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000261F File Offset: 0x0000081F
		public static Player smethod_21(this Player player_0)
		{
			return player_0.Method_Public_get_Player_0();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002627 File Offset: 0x00000827
		public static bool smethod_22(this Player player_0)
		{
			return player_0.smethod_6() > 90f || player_0.smethod_6() < 1f || player_0.smethod_7() > 665 || player_0.smethod_7() < 0;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000265C File Offset: 0x0000085C
		public static ApiAvatar smethod_23(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_ApiAvatar_1();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002664 File Offset: 0x00000864
		public static ApiAvatar smethod_24(this Player player_0)
		{
			return player_0._vrcplayer.Method_Public_get_ApiAvatar_1();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004D9C File Offset: 0x00002F9C
		public static void smethod_25()
		{
			Ray ray;
			ray..ctor(Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit[] array = Physics.RaycastAll(ray);
			if (array.Length != 0)
			{
				RaycastHit raycastHit = array[0];
				VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position = raycastHit.point;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004E00 File Offset: 0x00003000
		public static string smethod_26(this Player player_0)
		{
			float num = player_0.smethod_6();
			string result;
			if (num > 80f)
			{
				result = "<color=green>" + num.ToString() + "</color>";
			}
			else if (num <= 30f)
			{
				result = "<color=red>" + num.ToString() + "</color>";
			}
			else
			{
				result = "<color=yellow>" + num.ToString() + "</color>";
			}
			return result;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00004E74 File Offset: 0x00003074
		public static string smethod_27(this Player player_0)
		{
			short num = player_0.smethod_7();
			string result;
			if (num <= 150)
			{
				if (num <= 75)
				{
					result = "<color=green>" + num.ToString() + "</color>";
				}
				else
				{
					result = "<color=yellow>" + num.ToString() + "</color>";
				}
			}
			else
			{
				result = "<color=red>" + num.ToString() + "</color>";
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00004EE4 File Offset: 0x000030E4
		public static string smethod_28(this Player player_0)
		{
			string result;
			if (!player_0.Method_Internal_get_APIUser_0().IsOnMobile)
			{
				if (player_0.smethod_14().IsUserInVR())
				{
					result = "<color=#CE00D5>VR</color>";
				}
				else
				{
					result = "<color=grey>DESKTOP</color>";
				}
			}
			else
			{
				result = "<color=green>QUESTIE</color>";
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004F24 File Offset: 0x00003124
		public static void smethod_29(this Delegate delegate_0, params object[] args)
		{
			Delegate[] invocationList = delegate_0.GetInvocationList();
			for (int i = 0; i < invocationList.Length; i++)
			{
				try
				{
					invocationList[i].DynamicInvoke(args);
				}
				catch (Exception ex)
				{
					Console.WriteLine(Patches.KrazeCons + "Error while executing delegate:\n" + ex.ToString(), ConsoleColor.Red);
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00004F8C File Offset: 0x0000318C
		public static void smethod_30(string string_0)
		{
			PageAvatar component = GameObject.Find("Screens").transform.Find("Avatar").GetComponent<PageAvatar>();
			component.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar
			{
				id = string_0
			};
			component.ChangeToSelectedAvatar();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004FD8 File Offset: 0x000031D8
		public static Player smethod_31(int int_0)
		{
			Player result = null;
			Class1.dictionary_0.TryGetValue(int_0, out result);
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002671 File Offset: 0x00000871
		// Note: this type is marked as 'beforefieldinit'.
		static Class1()
		{
			Class39.smethod_16();
			Class1.dictionary_0 = new Dictionary<int, Player>();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002682 File Offset: 0x00000882
		internal static bool smethod_32()
		{
			return Class1.class1_0 == null;
		}

		// Token: 0x04000068 RID: 104
		public static Dictionary<int, Player> dictionary_0;

		// Token: 0x04000069 RID: 105
		internal static Class1 class1_0;
	}
}
