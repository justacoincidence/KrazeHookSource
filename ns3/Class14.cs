using System;
using MelonLoader;
using ns0;
using UnityEngine;
using VRC;

namespace ns3
{
	// Token: 0x0200002E RID: 46
	internal class Class14
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00007F00 File Offset: 0x00006100
		public static void smethod_0()
		{
			if (Class14.bool_0)
			{
				try
				{
					for (int i = 0; i < Class1.smethod_0().Length; i++)
					{
						Class14.smethod_1(Class1.smethod_0()[i], true);
					}
					return;
				}
				catch
				{
					MelonLogger.Msg("Failed to start ESP");
					return;
				}
			}
			if (!Class14.bool_0)
			{
				for (int j = 0; j < Class1.smethod_0().Length; j++)
				{
					Class14.smethod_1(Class1.smethod_0()[j], false);
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002C83 File Offset: 0x00000E83
		public static void smethod_1(Component component_0, bool bool_1)
		{
			HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().Method_Public_Void_Renderer_Boolean_0(component_0.transform.Find("SelectRegion").GetComponent<Renderer>(), bool_1);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002CA5 File Offset: 0x00000EA5
		public void method_0(Player player_0)
		{
			Class14.smethod_1(player_0, true);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class14()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002CAE File Offset: 0x00000EAE
		internal static bool smethod_2()
		{
			return Class14.class14_0 == null;
		}

		// Token: 0x04000100 RID: 256
		public static bool bool_0;

		// Token: 0x04000101 RID: 257
		private static Class14 class14_0;
	}
}
