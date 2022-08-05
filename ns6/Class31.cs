using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x0200004A RID: 74
	internal class Class31
	{
		// Token: 0x06000288 RID: 648
		[DllImport("user32.dll")]
		public static extern bool SetWindowText(IntPtr intptr_1, string string_0);

		// Token: 0x06000289 RID: 649
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string string_0, string string_1);

		// Token: 0x0600028A RID: 650 RVA: 0x00003453 File Offset: 0x00001653
		public static IEnumerator smethod_0()
		{
			return new Class31.<ChangeTitle>d__3(0);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class31()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000345B File Offset: 0x0000165B
		// Note: this type is marked as 'beforefieldinit'.
		static Class31()
		{
			Class39.smethod_16();
			Class31.intptr_0 = IntPtr.Zero;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000346C File Offset: 0x0000166C
		internal static bool smethod_1()
		{
			return Class31.class31_0 == null;
		}

		// Token: 0x04000157 RID: 343
		private static IntPtr intptr_0;

		// Token: 0x04000158 RID: 344
		private static Class31 class31_0;
	}
}
