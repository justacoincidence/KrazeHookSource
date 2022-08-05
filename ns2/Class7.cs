using System;
using VRC;
using VRC.Core;

namespace ns2
{
	// Token: 0x02000020 RID: 32
	internal static class Class7
	{
		// Token: 0x060000C9 RID: 201 RVA: 0x000027F3 File Offset: 0x000009F3
		public static bool smethod_0(this Player player_0)
		{
			return player_0.field_Private_APIUser_0 != null && APIUser.CurrentUser != null && APIUser.CurrentUser.friendIDs.Contains(player_0.field_Private_APIUser_0.id);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005488 File Offset: 0x00003688
		public static int smethod_1(this VRCPlayer vrcplayer_0)
		{
			return (vrcplayer_0.Method_Public_get_PlayerNet_0().Method_Public_get_Byte_0() == 0) ? 0 : ((int)(1000f / (float)vrcplayer_0.Method_Public_get_PlayerNet_0().Method_Public_get_Byte_0()));
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000054BC File Offset: 0x000036BC
		public static short smethod_2(this VRCPlayer vrcplayer_0)
		{
			return vrcplayer_0.Method_Public_get_PlayerNet_0().field_Private_Int16_0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000054D8 File Offset: 0x000036D8
		public static string smethod_3(this VRCPlayer vrcplayer_0)
		{
			string arg;
			if (vrcplayer_0.smethod_2() > 75)
			{
				if (vrcplayer_0.smethod_2() >= 75 && vrcplayer_0.smethod_2() <= 150)
				{
					arg = "<color=#ffa500ff>";
				}
				else
				{
					arg = "<color=#ff0000ff>";
				}
			}
			else
			{
				arg = "<color=#008000ff>";
			}
			return string.Format("{0}{1}</color>", arg, vrcplayer_0.smethod_2());
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005544 File Offset: 0x00003744
		public static string smethod_4(this VRCPlayer vrcplayer_0)
		{
			string arg;
			if (vrcplayer_0.smethod_1() >= 80)
			{
				arg = "<color=#008000ff>";
			}
			else if (vrcplayer_0.smethod_1() <= 80 && vrcplayer_0.smethod_1() >= 30)
			{
				arg = "<color=#ffa500ff>";
			}
			else
			{
				arg = "<color=#ff0000ff>";
			}
			return string.Format("{0}{1}</color>", arg, vrcplayer_0.smethod_1());
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002821 File Offset: 0x00000A21
		internal static bool smethod_5()
		{
			return Class7.class7_0 == null;
		}

		// Token: 0x04000078 RID: 120
		private static Class7 class7_0;
	}
}
