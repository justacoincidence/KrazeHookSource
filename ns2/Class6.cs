using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using VRC;
using VRC.SDKBase;

namespace ns2
{
	// Token: 0x0200001E RID: 30
	internal static class Class6
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000051FC File Offset: 0x000033FC
		public static Player smethod_0()
		{
			return Player.Method_Internal_Static_get_Player_0();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005210 File Offset: 0x00003410
		public static Animator smethod_1(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.field_Internal_Animator_0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005228 File Offset: 0x00003428
		public static VRCPlayer smethod_2(this Player player_0)
		{
			return player_0._vrcplayer;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005240 File Offset: 0x00003440
		public static VRCPlayer smethod_3(this PlayerNet playerNet_0)
		{
			return playerNet_0._vrcPlayer;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005258 File Offset: 0x00003458
		public static VRCPlayerApi smethod_4(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_VRCPlayerApi_0();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005270 File Offset: 0x00003470
		public static VRCPlayerApi smethod_5(this PlayerNet playerNet_0)
		{
			return playerNet_0.smethod_3().smethod_4();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000276C File Offset: 0x0000096C
		public static bool smethod_6(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.smethod_4().IsUserInVR();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002779 File Offset: 0x00000979
		public static bool smethod_7()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0 != null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000528C File Offset: 0x0000348C
		public static VRCPlayerApi smethod_8(this Player player_0)
		{
			return player_0.field_Private_VRCPlayerApi_0;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002783 File Offset: 0x00000983
		public static bool smethod_9(this Player player_0)
		{
			return player_0.smethod_8().IsUserInVR();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000052A4 File Offset: 0x000034A4
		public static int smethod_10(this Player player_0)
		{
			return player_0.smethod_8().playerId;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000052C0 File Offset: 0x000034C0
		public static string smethod_11()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0.id;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000052DC File Offset: 0x000034DC
		public static bool smethod_12()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7";
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005308 File Offset: 0x00003508
		public static bool smethod_13()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe";
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005334 File Offset: 0x00003534
		public static Player smethod_14(int int_0)
		{
			Class6.<>c__DisplayClass17_0 CS$<>8__locals1 = new Class6.<>c__DisplayClass17_0();
			CS$<>8__locals1.int_0 = int_0;
			return Class6.smethod_17().Where(new Func<Player, bool>(CS$<>8__locals1.method_0)).FirstOrDefault<Player>();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002790 File Offset: 0x00000990
		public static void smethod_15(GameObject gameObject_0)
		{
			if (Class6.smethod_18(gameObject_0) != Class6.smethod_0())
			{
				Networking.SetOwner(Class6.smethod_0().field_Private_VRCPlayerApi_0, gameObject_0);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000536C File Offset: 0x0000356C
		public static PlayerManager smethod_16()
		{
			return PlayerManager.field_Private_Static_PlayerManager_0;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005380 File Offset: 0x00003580
		public static List<Player> smethod_17()
		{
			return Class6.smethod_16().field_Private_List_1_Player_0.ToArray().ToList<Player>();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000053A4 File Offset: 0x000035A4
		public static Player smethod_18(GameObject gameObject_0)
		{
			foreach (Player player in Class6.smethod_17())
			{
				if (player.field_Private_VRCPlayerApi_0.IsOwner(gameObject_0))
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005408 File Offset: 0x00003608
		public static List<Player> smethod_19(this PlayerManager playerManager_0)
		{
			return playerManager_0.field_Private_List_1_Player_0;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005420 File Offset: 0x00003620
		public static Player smethod_20(this PlayerManager playerManager_0, int int_0)
		{
			List<Player> list = playerManager_0.smethod_19();
			foreach (Player player in list.ToArray())
			{
				if (player.smethod_8().playerId == int_0)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005420 File Offset: 0x00003620
		public static Player smethod_21(this PlayerManager playerManager_0, int int_0)
		{
			List<Player> list = playerManager_0.smethod_19();
			foreach (Player player in list.ToArray())
			{
				if (player.smethod_8().playerId == int_0)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000027B4 File Offset: 0x000009B4
		// Note: this type is marked as 'beforefieldinit'.
		static Class6()
		{
			Class39.smethod_16();
			Class6.string_0 = "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe";
			Class6.string_1 = "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7";
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000027CF File Offset: 0x000009CF
		internal static bool smethod_22()
		{
			return Class6.class6_0 == null;
		}

		// Token: 0x04000073 RID: 115
		public static string string_0;

		// Token: 0x04000074 RID: 116
		public static string string_1;

		// Token: 0x04000075 RID: 117
		private static Class6 class6_0;
	}
}
