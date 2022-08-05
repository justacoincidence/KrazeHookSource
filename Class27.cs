using System;
using System.Collections;
using MelonLoader;
using MezHud;

// Token: 0x02000045 RID: 69
internal class Class27
{
	// Token: 0x0600026C RID: 620 RVA: 0x00003368 File Offset: 0x00001568
	public static void smethod_0()
	{
		if (!Class27.bool_0)
		{
			MelonLogger.Msg("[ANTI-CRASH] Enabled");
			MezHudLog.Msg("[ANTI-CRASH] Enabled", 3f);
		}
		else
		{
			MelonLogger.Msg("[ANTI-CRASH] Disabled");
			MezHudLog.Msg("[ANTI-CRASH] Disabled", 3f);
		}
	}

	// Token: 0x0600026D RID: 621 RVA: 0x000033A8 File Offset: 0x000015A8
	public static IEnumerator smethod_1()
	{
		return new Class27.<AviFixer>d__2(0);
	}

	// Token: 0x0600026E RID: 622 RVA: 0x000022C0 File Offset: 0x000004C0
	public Class27()
	{
		Class39.smethod_16();
		base..ctor();
	}

	// Token: 0x0600026F RID: 623 RVA: 0x000033B0 File Offset: 0x000015B0
	internal static bool smethod_2()
	{
		return Class27.class27_0 == null;
	}

	// Token: 0x04000148 RID: 328
	public static bool bool_0;

	// Token: 0x04000149 RID: 329
	private static Class27 class27_0;
}
