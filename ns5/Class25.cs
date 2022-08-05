using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using MelonLoader;
using MezHud;
using UnityEngine;
using VRC;
using VRC.DataModel;
using VRC.UI.Elements.Menus;

namespace ns5
{
	// Token: 0x0200003E RID: 62
	internal class Class25
	{
		// Token: 0x06000213 RID: 531 RVA: 0x000030D0 File Offset: 0x000012D0
		public static IEnumerator smethod_0()
		{
			return new Class25.<CheckNullPlayer>d__11(0);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00009868 File Offset: 0x00007A68
		public static void smethod_1()
		{
			for (int i = 0; i < Class25.keyCode_0.Length; i++)
			{
				if (Class25.player_1 != null && Input.GetKeyDown(Class25.keyCode_0[i]))
				{
					Class26.smethod_40(true);
					Class25.player_1 = null;
					Class25.bool_0 = false;
					Class25.bool_1 = false;
				}
			}
			if (Class25.player_1 != null && Class26.smethod_0() != null && !Class25.bool_0)
			{
				Class26.smethod_1().transform.position = new Vector3(Class25.player_1.smethod_26().smethod_54().GetBoneTransform(Class25.humanBodyBones_0[(int)Class25.vector3_1.x]).position.x, Class25.player_1.smethod_26().smethod_54().GetBoneTransform(Class25.humanBodyBones_0[(int)Class25.vector3_1.y]).position.y, Class25.player_1.smethod_26().smethod_54().GetBoneTransform(Class25.humanBodyBones_0[(int)Class25.vector3_1.z]).position.z);
			}
			if (Class25.player_1 != null && Class26.smethod_0() != null && Class25.bool_0)
			{
				Class26.smethod_1().transform.position = new Vector3(Class25.player_1.smethod_26().smethod_54().GetBoneTransform(Class25.humanBodyBones_0[(int)Class25.vector3_1.x]).position.x + Class25.vector3_0.x, Class25.vector3_0.y, Class25.player_1.smethod_26().smethod_54().GetBoneTransform(Class25.humanBodyBones_0[(int)Class25.vector3_1.z]).position.z + Class25.vector3_0.z);
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00009A44 File Offset: 0x00007C44
		public static Player smethod_2()
		{
			IUser field_Private_IUser_ = Object.FindObjectOfType<SelectedUserMenuQM>().field_Private_IUser_0;
			return Class26.smethod_53(field_Private_IUser_.Method_Public_Abstract_Virtual_New_get_String_0());
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00009A6C File Offset: 0x00007C6C
		public static void smethod_3(Vector3 vector3_2, Vector3 vector3_3 = default(Vector3), bool bool_2 = false)
		{
			try
			{
				Player player = Class25.player_0;
				if (!player.smethod_26().smethod_54().isHuman)
				{
					MelonLogger.Msg("The player is not able to be attached to");
					MezHudLog.Msg("The player is not able to be attached to", 2.5f);
				}
				else
				{
					if (Class25.player_1 != null)
					{
						if (!bool_2)
						{
							Class25.player_1 = null;
							Class25.bool_0 = false;
							Class25.bool_1 = false;
						}
						if (bool_2)
						{
							Class25.player_1 = null;
							Class25.bool_1 = false;
						}
					}
					Class25.vector3_1.x = vector3_2.x;
					Class25.vector3_1.y = vector3_2.y;
					Class25.vector3_1.z = vector3_2.z;
					Class25.vector3_0.x = vector3_3.x;
					Class25.vector3_0.y = vector3_3.y;
					Class25.vector3_0.z = vector3_3.z;
					Class25.player_1 = Class25.player_0;
					Class26.smethod_40(false);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00009B6C File Offset: 0x00007D6C
		public static void smethod_4()
		{
			MethodInfo[] array = typeof(NetworkManager).GetMethods().Where(new Func<MethodInfo, bool>(Class25.<>c.<>c_0.method_0)).ToArray<MethodInfo>();
			try
			{
				Class25.harmony_0.Patch(AccessTools.Method(typeof(NetworkManager), array[1].Name, null, null), Class25.smethod_5("OnPlayerLeft"), null, null, null, null);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("Error Patching OnPlayerLeft => " + ex.Message);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00009C10 File Offset: 0x00007E10
		private static HarmonyMethod smethod_5(string string_0)
		{
			return new HarmonyMethod(typeof(Class25).GetMethod(string_0, BindingFlags.Static | BindingFlags.NonPublic));
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class25()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00009C38 File Offset: 0x00007E38
		// Note: this type is marked as 'beforefieldinit'.
		static Class25()
		{
			Class39.smethod_16();
			Class25.harmony_0 = new Harmony("AttachPatchez");
			Class25.float_0 = 0f;
			Class25.float_1 = 2f;
			Class25.keyCode_0 = new KeyCode[]
			{
				32,
				345
			};
			HumanBodyBones[] array = new HumanBodyBones[12];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.FDF94C1E30F3B93CE4FDBC8D15A62A56AC5208D4D50BD4E3E5CD3CC90104C05C).FieldHandle);
			Class25.humanBodyBones_0 = array;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000030D8 File Offset: 0x000012D8
		internal static bool smethod_6()
		{
			return Class25.class25_0 == null;
		}

		// Token: 0x0400012D RID: 301
		public static Player player_0;

		// Token: 0x0400012E RID: 302
		public static Harmony harmony_0;

		// Token: 0x0400012F RID: 303
		public static Player player_1;

		// Token: 0x04000130 RID: 304
		public static bool bool_0;

		// Token: 0x04000131 RID: 305
		public static bool bool_1;

		// Token: 0x04000132 RID: 306
		public static float float_0;

		// Token: 0x04000133 RID: 307
		public static float float_1;

		// Token: 0x04000134 RID: 308
		public static Vector3 vector3_0;

		// Token: 0x04000135 RID: 309
		public static Vector3 vector3_1;

		// Token: 0x04000136 RID: 310
		private static readonly KeyCode[] keyCode_0;

		// Token: 0x04000137 RID: 311
		public static HumanBodyBones[] humanBodyBones_0;

		// Token: 0x04000138 RID: 312
		internal static Class25 class25_0;
	}
}
