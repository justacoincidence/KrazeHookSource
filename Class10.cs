using System;
using KrazeHook.Modules;
using VRC;
using VRC.Core;

// Token: 0x02000026 RID: 38
internal static class Class10
{
	// Token: 0x0600014E RID: 334 RVA: 0x00007474 File Offset: 0x00005674
	internal static void smethod_0()
	{
		Class10.struct0_0 = default(Class0.Struct0);
		Class10.struct0_0.delegate2_0 = new Class0.Delegate2(Class10.<>c.<>c_0.method_0);
		Class10.struct1_0.string_0 = "Loading...";
		Class10.struct1_0.string_2 = "rpclogo";
		Class10.struct1_0.string_3 = (UI.RpcVersions ?? "");
		Class10.struct1_0.string_4 = "vrc_small";
		Class10.struct1_0.string_5 = "VRChat Build: " + UI.VRCbuild;
		Class10.struct1_0.int_0 = 0;
		Class10.struct1_0.int_1 = 0;
		Class10.struct1_0.long_0 = (long)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		Class10.struct1_0.string_6 = Guid.NewGuid().ToString();
		try
		{
			Class0.Discord_Initialize("982677380416028772", ref Class10.struct0_0, true, "");
			Class0.Discord_UpdatePresence(ref Class10.struct1_0);
		}
		catch
		{
		}
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000075A8 File Offset: 0x000057A8
	internal static void smethod_1()
	{
		ApiWorld field_Internal_Static_ApiWorld_ = RoomManager.field_Internal_Static_ApiWorld_0;
		ApiWorldInstance field_Internal_Static_ApiWorldInstance_ = RoomManager.field_Internal_Static_ApiWorldInstance_0;
		switch (field_Internal_Static_ApiWorldInstance_.type)
		{
		case 0:
			Class10.struct1_0.string_0 = "[Public] " + field_Internal_Static_ApiWorld_.name;
			break;
		case 1:
			Class10.struct1_0.string_0 = "[Friends+] " + field_Internal_Static_ApiWorld_.name;
			break;
		case 2:
			Class10.struct1_0.string_0 = "[Friends] " + field_Internal_Static_ApiWorld_.name;
			break;
		case 3:
			Class10.struct1_0.string_0 = "[Invite] " + field_Internal_Static_ApiWorld_.name;
			break;
		case 4:
			Class10.struct1_0.string_0 = "[Invite+] " + field_Internal_Static_ApiWorld_.name;
			break;
		default:
			Class10.struct1_0.string_0 = "Changing Worlds...";
			Class10.struct1_0.string_6 = Guid.NewGuid().ToString();
			Class10.struct1_0.int_1 = 1;
			Class10.struct1_0.int_0 = 1;
			break;
		}
		Class10.struct1_0.string_6 = field_Internal_Static_ApiWorldInstance_.id;
		Class10.struct1_0.int_1 = field_Internal_Static_ApiWorld_.capacity;
		Class10.struct1_0.int_0 = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.Count;
		Class0.Discord_UpdatePresence(ref Class10.struct1_0);
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00002B47 File Offset: 0x00000D47
	internal static void smethod_2()
	{
		Class10.struct1_0.int_0 = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.Count;
		Class0.Discord_UpdatePresence(ref Class10.struct1_0);
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002B6C File Offset: 0x00000D6C
	internal static bool smethod_3()
	{
		return Class10.class10_0 == null;
	}

	// Token: 0x040000EA RID: 234
	internal static Class0.Struct1 struct1_0;

	// Token: 0x040000EB RID: 235
	internal static Class0.Struct0 struct0_0;

	// Token: 0x040000EC RID: 236
	internal static Class10 class10_0;
}
