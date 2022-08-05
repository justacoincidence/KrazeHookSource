using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.UI;

namespace ns5
{
	// Token: 0x02000041 RID: 65
	internal static class Class26
	{
		// Token: 0x06000227 RID: 551 RVA: 0x000055AC File Offset: 0x000037AC
		public static VRCPlayer smethod_0()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000051FC File Offset: 0x000033FC
		public static Player smethod_1()
		{
			return Player.Method_Internal_Static_get_Player_0();
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000076FC File Offset: 0x000058FC
		public static APIUser smethod_2()
		{
			return APIUser.CurrentUser;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00009D18 File Offset: 0x00007F18
		public static USpeaker smethod_3()
		{
			return Class26.smethod_0().field_Private_USpeaker_0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00009D34 File Offset: 0x00007F34
		public static VRCPlayerApi smethod_4()
		{
			return Class26.smethod_0().field_Private_VRCPlayerApi_0;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000536C File Offset: 0x0000356C
		public static PlayerManager smethod_5()
		{
			return PlayerManager.field_Private_Static_PlayerManager_0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00009D50 File Offset: 0x00007F50
		public static List<Player> smethod_6()
		{
			return Class26.smethod_5().field_Private_List_1_Player_0.ToArray().ToList<Player>();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00007958 File Offset: 0x00005B58
		public static ApiAvatar smethod_7(this Player player_0)
		{
			return player_0.Method_Public_get_ApiAvatar_0();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00009D74 File Offset: 0x00007F74
		public static PlayerNet smethod_8(this Player player_0)
		{
			return player_0.Method_Internal_get_PlayerNet_0();
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00009D8C File Offset: 0x00007F8C
		public static USpeaker smethod_9(this Player player_0)
		{
			return player_0.Method_Public_get_USpeaker_0();
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000528C File Offset: 0x0000348C
		public static VRCPlayerApi smethod_10(this Player player_0)
		{
			return player_0.field_Private_VRCPlayerApi_0;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00009DA4 File Offset: 0x00007FA4
		public static APIUser smethod_11(this Player player_0)
		{
			return player_0.Method_Internal_get_APIUser_0();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000314D File Offset: 0x0000134D
		public static bool smethod_12(this Player player_0)
		{
			return player_0.smethod_11().IsOnMobile;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00009DBC File Offset: 0x00007FBC
		public static void smethod_13(VRC_EventHandler.VrcEvent vrcEvent_0, VRC_EventHandler.VrcBroadcastType vrcBroadcastType_0, GameObject gameObject_0)
		{
			if (Class26.vrc_EventHandler_0 == null)
			{
				Class26.vrc_EventHandler_0 = Resources.FindObjectsOfTypeAll<VRC_EventHandler>().FirstOrDefault<VRC_EventHandler>();
			}
			vrcEvent_0.ParameterObject = Player.Method_Internal_Static_get_Player_0().Method_Public_get_USpeaker_0().gameObject;
			Class26.vrc_EventHandler_0.TriggerEvent(vrcEvent_0, vrcBroadcastType_0, gameObject_0, 0f);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00009E0C File Offset: 0x0000800C
		public static GameObject smethod_14(string string_0, Vector3 vector3_0, Quaternion quaternion_0)
		{
			return Networking.Instantiate(0, string_0, vector3_0, quaternion_0);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000315A File Offset: 0x0000135A
		public static void smethod_15(bool bool_0)
		{
			DefaultTalkController.field_Private_Static_Boolean_0 = bool_0;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003162 File Offset: 0x00001362
		public static void smethod_16(this Player player_0, float float_0)
		{
			player_0.smethod_9().field_Private_SimpleAudioGain_0.field_Public_Single_0 = float_0;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00009E24 File Offset: 0x00008024
		public static float smethod_17(this Player player_0)
		{
			return player_0.smethod_9().field_Private_SimpleAudioGain_0.field_Public_Single_0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00003175 File Offset: 0x00001375
		public static bool smethod_18(this Player player_0)
		{
			return player_0.smethod_17() == 0f;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003184 File Offset: 0x00001384
		public static void smethod_19(this Player player_0)
		{
			player_0.smethod_16(0f);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003191 File Offset: 0x00001391
		public static void smethod_20(this Player player_0)
		{
			player_0.smethod_16(1f);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000319E File Offset: 0x0000139E
		public static bool smethod_21(this Player player_0)
		{
			return player_0.smethod_10().IsUserInVR();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000031AB File Offset: 0x000013AB
		public static void smethod_22(this Player player_0)
		{
			Class26.smethod_0().transform.position = player_0.smethod_26().transform.position;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000031CC File Offset: 0x000013CC
		public static QuickMenu smethod_23()
		{
			return GameObject.Find("UserInterface/QuickMenu").GetComponent<QuickMenu>();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000031DD File Offset: 0x000013DD
		public static Player smethod_24()
		{
			return Class26.smethod_23().field_Private_Player_0;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000031E9 File Offset: 0x000013E9
		public static void smethod_25()
		{
			Class26.smethod_0().Method_Public_Void_Boolean_0(false);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00009E44 File Offset: 0x00008044
		public static VRCPlayer smethod_26(this Player player_0)
		{
			return player_0.Method_Internal_get_VRCPlayer_1();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00009E5C File Offset: 0x0000805C
		public static VRCAvatarManager smethod_27(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_VRCAvatarManager_0();
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009E74 File Offset: 0x00008074
		public static string smethod_28(this Player player_0)
		{
			return player_0.smethod_11().displayName;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009E90 File Offset: 0x00008090
		public static float smethod_29()
		{
			return USpeaker.field_Internal_Static_Single_1;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000031F6 File Offset: 0x000013F6
		public static void smethod_30(float float_0)
		{
			USpeaker.field_Internal_Static_Single_1 = float_0;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00009EA4 File Offset: 0x000080A4
		public static float smethod_31()
		{
			return USpeaker.field_Internal_Static_Single_0;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000031FE File Offset: 0x000013FE
		public static void smethod_32(float float_0)
		{
			USpeaker.field_Internal_Static_Single_0 = float_0;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00009EB8 File Offset: 0x000080B8
		public static float smethod_33()
		{
			return 1f;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009ECC File Offset: 0x000080CC
		public static float smethod_34()
		{
			return float.MaxValue;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003206 File Offset: 0x00001406
		public static bool smethod_35(this Player player_0)
		{
			return player_0.smethod_10().isMaster;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00009EE0 File Offset: 0x000080E0
		public static int smethod_36(this Player player_0)
		{
			return player_0.smethod_10().playerId;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00009EFC File Offset: 0x000080FC
		public static int smethod_37(this Player player_0)
		{
			int result;
			if (player_0.smethod_8().field_Private_Byte_0 == 0)
			{
				result = 0;
			}
			else
			{
				result = (int)(1000f / (float)player_0.smethod_8().field_Private_Byte_0);
			}
			return result;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009F34 File Offset: 0x00008134
		public static int smethod_38(this Player player_0)
		{
			return (int)player_0.smethod_8().field_Private_Int16_0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00003213 File Offset: 0x00001413
		public static void smethod_39(string string_0)
		{
			new PageAvatar
			{
				field_Public_SimpleAvatarPedestal_0 = new SimpleAvatarPedestal
				{
					field_Internal_ApiAvatar_0 = new ApiAvatar
					{
						id = string_0
					}
				}
			}.ChangeToSelectedAvatar();
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000323C File Offset: 0x0000143C
		public static void smethod_40(bool bool_0)
		{
			if (Class26.collider_0 == null)
			{
				Class26.collider_0 = Class26.smethod_0().GetComponent<Collider>();
			}
			Class26.collider_0.enabled = bool_0;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00003265 File Offset: 0x00001465
		public static void smethod_41(float float_0)
		{
			Class26.smethod_1().smethod_10().SetWalkSpeed(float_0);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003277 File Offset: 0x00001477
		public static void smethod_42()
		{
			Class26.smethod_1().smethod_10().SetWalkSpeed(0f);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000328D File Offset: 0x0000148D
		public static void smethod_43(float float_0)
		{
			Class26.smethod_1().smethod_10().SetRunSpeed(float_0);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000329F File Offset: 0x0000149F
		public static void smethod_44()
		{
			Class26.smethod_1().smethod_10().SetRunSpeed(0f);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000032B5 File Offset: 0x000014B5
		public static void smethod_45(float float_0)
		{
			Class26.smethod_1().smethod_10().SetStrafeSpeed(float_0);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000032C7 File Offset: 0x000014C7
		public static void smethod_46()
		{
			Class26.smethod_1().smethod_10().SetStrafeSpeed(0f);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002312 File Offset: 0x00000512
		public static void smethod_47(object object_0)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009F50 File Offset: 0x00008150
		public static Player smethod_48(int int_0)
		{
			Class26.<>c__DisplayClass59_0 CS$<>8__locals1 = new Class26.<>c__DisplayClass59_0();
			CS$<>8__locals1.int_0 = int_0;
			return Class26.smethod_6().Where(new Func<Player, bool>(CS$<>8__locals1.method_0)).FirstOrDefault<Player>();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009F88 File Offset: 0x00008188
		public static string smethod_49(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.field_Private_UInt64_0.ToString();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009FA8 File Offset: 0x000081A8
		public static Player smethod_50(string string_0)
		{
			Class26.<>c__DisplayClass61_0 CS$<>8__locals1 = new Class26.<>c__DisplayClass61_0();
			CS$<>8__locals1.string_0 = string_0;
			return Class26.smethod_6().Where(new Func<Player, bool>(CS$<>8__locals1.method_0)).FirstOrDefault<Player>();
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009FE0 File Offset: 0x000081E0
		public static Player smethod_51(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_Player_0();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000032DD File Offset: 0x000014DD
		public static bool smethod_52(this Player player_0)
		{
			return player_0.smethod_11().id == APIUser.CurrentUser.id;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00009FF8 File Offset: 0x000081F8
		public static Player smethod_53(string string_0)
		{
			Class26.<>c__DisplayClass64_0 CS$<>8__locals1 = new Class26.<>c__DisplayClass64_0();
			CS$<>8__locals1.string_0 = string_0;
			return Class26.smethod_6().Where(new Func<Player, bool>(CS$<>8__locals1.method_0)).FirstOrDefault<Player>();
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00005210 File Offset: 0x00003410
		public static Animator smethod_54(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.field_Internal_Animator_0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000031F6 File Offset: 0x000013F6
		public static void smethod_55(float float_0)
		{
			USpeaker.field_Internal_Static_Single_1 = float_0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000032F9 File Offset: 0x000014F9
		public static void smethod_56()
		{
			USpeaker.field_Internal_Static_Single_1 = Class26.smethod_33();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002779 File Offset: 0x00000979
		public static bool smethod_57()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0 != null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000A030 File Offset: 0x00008230
		public static Player[] smethod_58()
		{
			return PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.ToArray();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003305 File Offset: 0x00001505
		internal static bool smethod_59()
		{
			return Class26.class26_0 == null;
		}

		// Token: 0x0400013F RID: 319
		private static VRC_EventHandler vrc_EventHandler_0;

		// Token: 0x04000140 RID: 320
		private static Collider collider_0;

		// Token: 0x04000141 RID: 321
		internal static Class26 class26_0;
	}
}
