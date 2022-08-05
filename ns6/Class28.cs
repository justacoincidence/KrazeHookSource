using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace ns6
{
	// Token: 0x02000047 RID: 71
	internal class Class28
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public static List<Class28.Class29> smethod_0()
		{
			WebClient webClient = new WebClient();
			return JsonConvert.DeserializeObject<List<Class28.Class29>>(webClient.DownloadString("https://url"));
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class28()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000033E0 File Offset: 0x000015E0
		internal static bool smethod_1()
		{
			return Class28.class28_0 == null;
		}

		// Token: 0x0400014F RID: 335
		internal static Class28 class28_0;

		// Token: 0x02000048 RID: 72
		public class Class29
		{
			// Token: 0x0600027A RID: 634 RVA: 0x000033EA File Offset: 0x000015EA
			[CompilerGenerated]
			public string method_0()
			{
				return this.string_0;
			}

			// Token: 0x0600027B RID: 635 RVA: 0x000033F2 File Offset: 0x000015F2
			[CompilerGenerated]
			public void method_1(string string_2)
			{
				this.string_0 = string_2;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x000033FB File Offset: 0x000015FB
			[CompilerGenerated]
			public string method_2()
			{
				return this.string_1;
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00003403 File Offset: 0x00001603
			[CompilerGenerated]
			public void method_3(string string_2)
			{
				this.string_1 = string_2;
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0000340C File Offset: 0x0000160C
			[CompilerGenerated]
			public float method_4()
			{
				return this.float_0;
			}

			// Token: 0x0600027F RID: 639 RVA: 0x00003414 File Offset: 0x00001614
			[CompilerGenerated]
			public void method_5(float float_3)
			{
				this.float_0 = float_3;
			}

			// Token: 0x06000280 RID: 640 RVA: 0x0000341D File Offset: 0x0000161D
			[CompilerGenerated]
			public float method_6()
			{
				return this.float_1;
			}

			// Token: 0x06000281 RID: 641 RVA: 0x00003425 File Offset: 0x00001625
			[CompilerGenerated]
			public void method_7(float float_3)
			{
				this.float_1 = float_3;
			}

			// Token: 0x06000282 RID: 642 RVA: 0x0000342E File Offset: 0x0000162E
			[CompilerGenerated]
			public float method_8()
			{
				return this.float_2;
			}

			// Token: 0x06000283 RID: 643 RVA: 0x00003436 File Offset: 0x00001636
			[CompilerGenerated]
			public void method_9(float float_3)
			{
				this.float_2 = float_3;
			}

			// Token: 0x06000284 RID: 644 RVA: 0x000022C0 File Offset: 0x000004C0
			public Class29()
			{
				Class39.smethod_16();
				base..ctor();
			}

			// Token: 0x06000285 RID: 645 RVA: 0x0000343F File Offset: 0x0000163F
			internal static bool smethod_0()
			{
				return Class28.Class29.class29_0 == null;
			}

			// Token: 0x04000150 RID: 336
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04000151 RID: 337
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string string_1;

			// Token: 0x04000152 RID: 338
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private float float_0;

			// Token: 0x04000153 RID: 339
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private float float_1;

			// Token: 0x04000154 RID: 340
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private float float_2;

			// Token: 0x04000155 RID: 341
			internal static Class28.Class29 class29_0;
		}
	}
}
