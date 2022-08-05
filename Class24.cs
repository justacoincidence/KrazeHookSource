using System;
using MelonLoader;
using VRC;
using VRC.Core;
using VRC.UI;

// Token: 0x0200003D RID: 61
internal class Class24
{
	// Token: 0x0600020F RID: 527 RVA: 0x000097DC File Offset: 0x000079DC
	public static void smethod_0()
	{
		ApiAvatar apiAvatar = Class24.player_0.Method_Public_get_ApiAvatar_0();
		if (!(apiAvatar.releaseStatus != "private"))
		{
			MelonLogger.Error("Attempted to clone private avatar! (ID: " + apiAvatar.id + ")");
		}
		else
		{
			new PageAvatar
			{
				field_Public_SimpleAvatarPedestal_0 = new SimpleAvatarPedestal
				{
					field_Internal_ApiAvatar_0 = new ApiAvatar
					{
						id = apiAvatar.id
					}
				}
			}.ChangeToSelectedAvatar();
			MelonLogger.Msg("Cloned player avatar. (ID: " + apiAvatar.id + ")");
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x000022C0 File Offset: 0x000004C0
	public Class24()
	{
		Class39.smethod_16();
		base..ctor();
	}

	// Token: 0x06000211 RID: 529 RVA: 0x000030B5 File Offset: 0x000012B5
	// Note: this type is marked as 'beforefieldinit'.
	static Class24()
	{
		Class39.smethod_16();
		Class24.player_0 = new Player();
	}

	// Token: 0x06000212 RID: 530 RVA: 0x000030C6 File Offset: 0x000012C6
	internal static bool smethod_1()
	{
		return Class24.class24_0 == null;
	}

	// Token: 0x0400012B RID: 299
	public static Player player_0;

	// Token: 0x0400012C RID: 300
	internal static Class24 class24_0;
}
