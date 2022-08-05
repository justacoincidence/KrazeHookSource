using System;
using KrazeHook;
using UnityEngine;

// Token: 0x02000021 RID: 33
internal static class Class8
{
	// Token: 0x060000CF RID: 207 RVA: 0x000055AC File Offset: 0x000037AC
	public static VRCPlayer smethod_0()
	{
		return VRCPlayer.field_Internal_Static_VRCPlayer_0;
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000055C0 File Offset: 0x000037C0
	public static KeyCode smethod_1()
	{
		string text = Main.melonPreferences_Entry_6.Value;
		if (string.IsNullOrWhiteSpace(text))
		{
			text = "LeftAlt";
		}
		if (text.Length == 1)
		{
			text = text.ToUpper();
		}
		else
		{
			text = char.ToUpper(text[0]).ToString() + text.Substring(1);
		}
		KeyCode keyCode;
		return Enum.TryParse<KeyCode>(text, out keyCode) ? keyCode : 308;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00005630 File Offset: 0x00003830
	public static bool smethod_2(KeyCode keyCode_0, bool bool_0 = false, bool bool_1 = false)
	{
		bool flag = !bool_0;
		bool flag2 = !bool_1;
		if (bool_0 && (Input.GetKey(306) || Input.GetKey(305)))
		{
			flag = true;
		}
		if (bool_1 && (Input.GetKey(304) || Input.GetKey(303)))
		{
			flag2 = true;
		}
		return flag && flag2 && Input.GetKey(keyCode_0);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000569C File Offset: 0x0000389C
	public static bool smethod_3(KeyCode keyCode_0, bool bool_0 = false, bool bool_1 = false)
	{
		bool flag = !bool_0;
		bool flag2 = !bool_1;
		if (bool_0 && (Input.GetKey(306) || Input.GetKey(305)))
		{
			flag = true;
		}
		if (bool_1 && (Input.GetKey(304) || Input.GetKey(303)))
		{
			flag2 = true;
		}
		return flag && flag2 && Input.GetKeyDown(keyCode_0);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00005708 File Offset: 0x00003908
	public static bool smethod_4(KeyCode keyCode_0, bool bool_0 = false, bool bool_1 = false)
	{
		bool flag = !bool_0;
		bool flag2 = !bool_1;
		if (bool_0 && (Input.GetKey(306) || Input.GetKey(305)))
		{
			flag = true;
		}
		if (bool_1 && (Input.GetKey(304) || Input.GetKey(303)))
		{
			flag2 = true;
		}
		return flag && flag2 && Input.GetKeyUp(keyCode_0);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00005774 File Offset: 0x00003974
	public static bool smethod_5(int int_0, bool bool_0 = false, bool bool_1 = false)
	{
		bool flag = !bool_0;
		bool flag2 = !bool_1;
		if (bool_0 && (Input.GetKey(306) || Input.GetKey(305)))
		{
			flag = true;
		}
		if (bool_1 && (Input.GetKey(304) || Input.GetKey(303)))
		{
			flag2 = true;
		}
		return flag && flag2 && Input.GetMouseButtonDown(int_0);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x000057E0 File Offset: 0x000039E0
	public static float smethod_6(string string_0, bool bool_0 = false, bool bool_1 = false)
	{
		bool flag = !bool_0;
		bool flag2 = !bool_1;
		if (bool_0 && (Input.GetKey(306) || Input.GetKey(305)))
		{
			flag = true;
		}
		if (bool_1 && (Input.GetKey(304) || Input.GetKey(303)))
		{
			flag2 = true;
		}
		float result;
		if (!flag || !flag2)
		{
			result = 0f;
		}
		else
		{
			result = Input.GetAxis(string_0);
		}
		return result;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x0000282B File Offset: 0x00000A2B
	internal static bool smethod_7()
	{
		return Class8.class8_0 == null;
	}

	// Token: 0x04000079 RID: 121
	private static Class8 class8_0;
}
