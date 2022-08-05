using System;
using System.Collections.Generic;

namespace WTFBlaze
{
	// Token: 0x0200006A RID: 106
	public class BlazesButtonAPI
	{
		// Token: 0x06000326 RID: 806 RVA: 0x000022C0 File Offset: 0x000004C0
		public BlazesButtonAPI()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000389A File Offset: 0x00001A9A
		// Note: this type is marked as 'beforefieldinit'.
		static BlazesButtonAPI()
		{
			Class39.smethod_16();
			BlazesButtonAPI.allQMSingleButtons = new List<QMSingleButton>();
			BlazesButtonAPI.allQMNestedButtons = new List<QMNestedButton>();
			BlazesButtonAPI.allQMToggleButtons = new List<QMToggleButton>();
			BlazesButtonAPI.allQMTabMenus = new List<QMTabMenu>();
			BlazesButtonAPI.allQMSliders = new List<QMSlider>();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000038D3 File Offset: 0x00001AD3
		internal static bool smethod_0()
		{
			return BlazesButtonAPI.blazesButtonAPI_0 == null;
		}

		// Token: 0x040001D5 RID: 469
		public const string Identifier = "KrazeHookButtons";

		// Token: 0x040001D6 RID: 470
		public static List<QMSingleButton> allQMSingleButtons;

		// Token: 0x040001D7 RID: 471
		public static List<QMNestedButton> allQMNestedButtons;

		// Token: 0x040001D8 RID: 472
		public static List<QMToggleButton> allQMToggleButtons;

		// Token: 0x040001D9 RID: 473
		public static List<QMTabMenu> allQMTabMenus;

		// Token: 0x040001DA RID: 474
		public static List<QMSlider> allQMSliders;

		// Token: 0x040001DB RID: 475
		private static BlazesButtonAPI blazesButtonAPI_0;
	}
}
