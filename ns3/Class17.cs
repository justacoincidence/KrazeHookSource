using System;
using System.Threading.Tasks;
using IKMod.Config;
using ns0;
using RootMotion.FinalIK;
using UnityEngine;
using VRC;
using VRC.DataModel;

namespace ns3
{
	// Token: 0x02000032 RID: 50
	internal class Class17
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00002D08 File Offset: 0x00000F08
		private static NeckMouseRotator smethod_0()
		{
			return Player.Method_Internal_Static_get_Player_0()._vrcplayer.GetComponent<GamelikeInputController>().field_Protected_NeckMouseRotator_0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002D1E File Offset: 0x00000F1E
		public static void smethod_1()
		{
			Class17.neckRange_0 = Class17.smethod_0().field_Public_NeckRange_0;
			Class17.smethod_0().field_Public_NeckRange_0 = new NeckRange(float.MinValue, float.MaxValue, 0f);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002D4D File Offset: 0x00000F4D
		public static void smethod_2()
		{
			Class17.smethod_0().field_Public_NeckRange_0 = Class17.neckRange_0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002D5E File Offset: 0x00000F5E
		public static void smethod_3()
		{
			Class17.string_0 = Class1.smethod_4().smethod_23().id;
			Class1.smethod_3().smethod_18(true);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002D7F File Offset: 0x00000F7F
		public static void smethod_4()
		{
			Class1.smethod_30(Class17.string_0);
			Class1.smethod_3().smethod_18(false);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002D96 File Offset: 0x00000F96
		public static void smethod_5()
		{
			Task.Run(new Action(Class17.<>c.<>c_0.method_0));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000080C4 File Offset: 0x000062C4
		public static void smethod_6()
		{
			Animator field_Internal_Animator_ = Player.Method_Internal_Static_get_Player_0()._vrcplayer.field_Internal_Animator_0;
			field_Internal_Animator_.enabled = !field_Internal_Animator_.enabled;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002DBD File Offset: 0x00000FBD
		public static void smethod_7()
		{
			RuntimeConfig.rightArm = true;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002DC5 File Offset: 0x00000FC5
		public static void smethod_8()
		{
			RuntimeConfig.rightArm = false;
			Class17.smethod_11().GetComponentInChildren<VRIK>().solver.rightArm.positionWeight = 0f;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002DEB File Offset: 0x00000FEB
		public static void smethod_9()
		{
			RuntimeConfig.leftArm = true;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002DF3 File Offset: 0x00000FF3
		public static void smethod_10()
		{
			RuntimeConfig.leftArm = false;
			Class17.smethod_11().GetComponentInChildren<VRIK>().solver.leftArm.positionWeight = 0f;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000055AC File Offset: 0x000037AC
		public static VRCPlayer smethod_11()
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002E19 File Offset: 0x00001019
		public static void smethod_12()
		{
			RuntimeConfig.noNeck = true;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002E21 File Offset: 0x00001021
		public static void smethod_13()
		{
			RuntimeConfig.noNeck = false;
			Class17.smethod_11().GetComponentInChildren<VRIK>().solver.hasNeck = true;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002E3E File Offset: 0x0000103E
		public static void smethod_14()
		{
			USpeaker.field_Internal_Static_Single_1 = float.MaxValue;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002E4A File Offset: 0x0000104A
		public static void smethod_15()
		{
			USpeaker.field_Internal_Static_Single_1 = 1f;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class17()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002E56 File Offset: 0x00001056
		internal static bool smethod_16()
		{
			return Class17.class17_0 == null;
		}

		// Token: 0x04000108 RID: 264
		private static NeckRange neckRange_0;

		// Token: 0x04000109 RID: 265
		private static string string_0;

		// Token: 0x0400010A RID: 266
		internal static Class17 class17_0;
	}
}
