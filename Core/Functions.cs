using System;
using System.Collections;
using MelonLoader;

namespace KrazeHook.Core
{
	// Token: 0x0200004E RID: 78
	public static class Functions
	{
		// Token: 0x0600029D RID: 669 RVA: 0x000034B0 File Offset: 0x000016B0
		public static void Start(this IEnumerator source)
		{
			MelonCoroutines.Start(source);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000034B9 File Offset: 0x000016B9
		public static void Stop(this IEnumerator source)
		{
			MelonCoroutines.Stop(source);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000034C1 File Offset: 0x000016C1
		internal static bool smethod_0()
		{
			return Functions.functions_0 == null;
		}

		// Token: 0x04000167 RID: 359
		private static Functions functions_0;
	}
}
