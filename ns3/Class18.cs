using System;
using UnityEngine;

namespace ns3
{
	// Token: 0x02000034 RID: 52
	internal class Class18
	{
		// Token: 0x060001B6 RID: 438 RVA: 0x00002E7B File Offset: 0x0000107B
		public static void smethod_0()
		{
			Class0.Discord_Shutdown();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002E82 File Offset: 0x00001082
		public static void smethod_1()
		{
			Class10.smethod_0();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002E89 File Offset: 0x00001089
		public static void smethod_2()
		{
			Application.targetFrameRate = 90;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002E92 File Offset: 0x00001092
		public static void smethod_3()
		{
			Application.targetFrameRate = 900;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002E9E File Offset: 0x0000109E
		public static void Fullscreen()
		{
			Screen.SetResolution(int.MaxValue, int.MaxValue, true);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002EB0 File Offset: 0x000010B0
		public static void Windowed()
		{
			Screen.SetResolution(1920, 1080, false);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class18()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002EC2 File Offset: 0x000010C2
		internal static bool smethod_4()
		{
			return Class18.class18_0 == null;
		}

		// Token: 0x0400010E RID: 270
		private static Class18 class18_0;
	}
}
