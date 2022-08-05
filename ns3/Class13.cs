using System;
using KrazeHook;
using UnhollowerBaseLib;
using UnityEngine;
using VRC.SDKBase;

namespace ns3
{
	// Token: 0x0200002D RID: 45
	internal class Class13
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00007D7C File Offset: 0x00005F7C
		public static void smethod_0()
		{
			Networking.LocalPlayer.SetWalkSpeed(Networking.LocalPlayer.GetWalkSpeed() * Class13.float_0);
			Networking.LocalPlayer.SetRunSpeed(Networking.LocalPlayer.GetRunSpeed() * Class13.float_0);
			Networking.LocalPlayer.SetStrafeSpeed(Networking.LocalPlayer.GetStrafeSpeed() * Class13.float_0);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002C3A File Offset: 0x00000E3A
		public static void smethod_1()
		{
			Networking.LocalPlayer.SetWalkSpeed(2f);
			Networking.LocalPlayer.SetRunSpeed(4f);
			Networking.LocalPlayer.SetStrafeSpeed(2f);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007DD8 File Offset: 0x00005FD8
		public static void smethod_2()
		{
			Class12.bool_0 = true;
			Il2CppArrayBase<Collider> il2CppArrayBase = Resources.FindObjectsOfTypeAll<Collider>();
			foreach (Collider collider in il2CppArrayBase)
			{
				if (collider.name.Contains("VRCPlayer"))
				{
					collider.enabled = false;
				}
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007E40 File Offset: 0x00006040
		public static void smethod_3()
		{
			Class12.bool_0 = false;
			Il2CppArrayBase<Collider> il2CppArrayBase = Resources.FindObjectsOfTypeAll<Collider>();
			foreach (Collider collider in il2CppArrayBase)
			{
				if (collider.name.Contains("VRCPlayer"))
				{
					collider.enabled = true;
				}
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00007EA8 File Offset: 0x000060A8
		public static void smethod_4()
		{
			if (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").Method_Public_get_Boolean_2() && !Networking.LocalPlayer.IsPlayerGrounded())
			{
				Vector3 velocity = Networking.LocalPlayer.GetVelocity();
				velocity.y = Networking.LocalPlayer.GetJumpImpulse();
				Networking.LocalPlayer.SetVelocity(velocity);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002C69 File Offset: 0x00000E69
		public static void smethod_5()
		{
			Main.InfJump = true;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002C71 File Offset: 0x00000E71
		public static void smethod_6()
		{
			Main.InfJump = false;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class13()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002C79 File Offset: 0x00000E79
		internal static bool smethod_7()
		{
			return Class13.class13_0 == null;
		}

		// Token: 0x040000FD RID: 253
		public static float float_0;

		// Token: 0x040000FE RID: 254
		public static float float_1;

		// Token: 0x040000FF RID: 255
		internal static Class13 class13_0;
	}
}
