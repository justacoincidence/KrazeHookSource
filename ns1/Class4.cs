using System;
using ExitGames.Client.Photon;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using VRC;

namespace ns1
{
	// Token: 0x0200001C RID: 28
	internal static class Class4
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x00005074 File Offset: 0x00003274
		public static void smethod_0(byte byte_0, object object_0, RaiseEventOptions raiseEventOptions_0, SendOptions sendOptions_0)
		{
			Object object_ = Class5.smethod_5<Object>(object_0);
			Class4.smethod_2(byte_0, object_, raiseEventOptions_0, sendOptions_0);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005094 File Offset: 0x00003294
		public static Dictionary<int, Player> smethod_1()
		{
			return Player.Method_Internal_Static_get_Player_0().Method_Public_get_Player_0().Method_FamOrAssem_get_Room_0().Method_Public_get_Dictionary_2_Int32_Player_0();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000274C File Offset: 0x0000094C
		public static void smethod_2(byte byte_0, Object object_0, RaiseEventOptions raiseEventOptions_0, SendOptions sendOptions_0)
		{
			PhotonNetwork.Method_Private_Static_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(byte_0, object_0, raiseEventOptions_0, sendOptions_0);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002758 File Offset: 0x00000958
		internal static bool smethod_3()
		{
			return Class4.class4_0 == null;
		}

		// Token: 0x04000071 RID: 113
		internal static Class4 class4_0;
	}
}
