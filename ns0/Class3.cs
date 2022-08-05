using System;
using System.Collections.Generic;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;

namespace ns0
{
	// Token: 0x0200001B RID: 27
	internal class Class3
	{
		// Token: 0x0600009B RID: 155 RVA: 0x000026D2 File Offset: 0x000008D2
		public static string smethod_0()
		{
			return RoomManager.field_Internal_Static_ApiWorldInstance_0.instanceId;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000026DE File Offset: 0x000008DE
		public static string smethod_1()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0.id;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000026EA File Offset: 0x000008EA
		public static string smethod_2()
		{
			return Class1.smethod_3().smethod_5().location;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000026FB File Offset: 0x000008FB
		public static ApiWorld smethod_3()
		{
			return RoomManager.field_Internal_Static_ApiWorld_0;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002702 File Offset: 0x00000902
		public static ApiWorldInstance smethod_4()
		{
			return RoomManager.field_Internal_Static_ApiWorldInstance_0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002709 File Offset: 0x00000909
		public static void smethod_5()
		{
			Class3.vrc_Pickup_0 = Object.FindObjectsOfType<VRC_Pickup>();
			Class3.udonBehaviour_0 = Object.FindObjectsOfType<UdonBehaviour>();
			Class3.vrc_Trigger_0 = Object.FindObjectsOfType<VRC_Trigger>();
			Class1.dictionary_0 = new Dictionary<int, Player>();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class3()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002742 File Offset: 0x00000942
		internal static bool smethod_6()
		{
			return Class3.class3_0 == null;
		}

		// Token: 0x0400006D RID: 109
		public static VRC_Pickup[] vrc_Pickup_0;

		// Token: 0x0400006E RID: 110
		public static UdonBehaviour[] udonBehaviour_0;

		// Token: 0x0400006F RID: 111
		public static VRC_Trigger[] vrc_Trigger_0;

		// Token: 0x04000070 RID: 112
		internal static Class3 class3_0;
	}
}
