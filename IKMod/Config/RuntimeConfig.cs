using System;

namespace IKMod.Config
{
	// Token: 0x0200000E RID: 14
	public class RuntimeConfig
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000022C0 File Offset: 0x000004C0
		public RuntimeConfig()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022EF File Offset: 0x000004EF
		internal static bool smethod_0()
		{
			return RuntimeConfig.runtimeConfig_0 == null;
		}

		// Token: 0x0400001F RID: 31
		public static bool tPose;

		// Token: 0x04000020 RID: 32
		public static bool noNeck;

		// Token: 0x04000021 RID: 33
		public static bool noChest;

		// Token: 0x04000022 RID: 34
		public static bool twist;

		// Token: 0x04000023 RID: 35
		public static bool leftArm;

		// Token: 0x04000024 RID: 36
		public static bool rightArm;

		// Token: 0x04000025 RID: 37
		private static RuntimeConfig runtimeConfig_0;
	}
}
