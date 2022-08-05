using System;
using System.Collections;
using MelonLoader;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using VRC;

namespace ns3
{
	// Token: 0x0200002F RID: 47
	internal class Class15
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00002CB8 File Offset: 0x00000EB8
		public static void smethod_0()
		{
			ClassInjector.RegisterTypeInIl2Cpp<Class15.Class16>();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007F80 File Offset: 0x00006180
		public static void smethod_1()
		{
			foreach (PortalInternal portalInternal in Object.FindObjectsOfType<PortalInternal>())
			{
				Class15.Class16 @class;
				if (portalInternal.field_Private_Int32_0 == Player.Method_Internal_Static_get_Player_0().Method_Public_get_Int32_0() && !portalInternal.gameObject.TryGetComponent<Class15.Class16>(ref @class))
				{
					Class15.Class16 class2 = portalInternal.gameObject.AddComponent<Class15.Class16>();
					MelonCoroutines.Start(class2.method_0());
				}
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008008 File Offset: 0x00006208
		public static void smethod_2()
		{
			foreach (PortalInternal portalInternal in Object.FindObjectsOfType<PortalInternal>())
			{
				if (portalInternal.field_Private_Int32_0 != -1)
				{
					Object.DestroyImmediate(portalInternal.gameObject);
				}
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class15()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002CBF File Offset: 0x00000EBF
		internal static bool smethod_3()
		{
			return Class15.class15_0 == null;
		}

		// Token: 0x04000102 RID: 258
		internal static Class15 class15_0;

		// Token: 0x02000030 RID: 48
		public class Class16 : MonoBehaviour
		{
			// Token: 0x06000196 RID: 406 RVA: 0x00002CC9 File Offset: 0x00000EC9
			[HideFromIl2Cpp]
			public IEnumerator method_0()
			{
				Class15.Class16.<SetTimer>d__0 <SetTimer>d__ = new Class15.Class16.<SetTimer>d__0(0);
				<SetTimer>d__.<>4__this = this;
				return <SetTimer>d__;
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000022D7 File Offset: 0x000004D7
			public Class16(IntPtr intptr_0)
			{
				Class39.smethod_16();
				base..ctor(intptr_0);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00002CD8 File Offset: 0x00000ED8
			internal static bool smethod_0()
			{
				return Class15.Class16.class16_0 == null;
			}

			// Token: 0x04000103 RID: 259
			internal static Class15.Class16 class16_0;
		}
	}
}
