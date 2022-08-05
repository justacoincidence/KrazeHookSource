using System;
using KrazeHook;
using MelonLoader;
using UnityEngine;
using UnityEngine.XR;

// Token: 0x02000022 RID: 34
internal class Class9
{
	// Token: 0x060000D7 RID: 215 RVA: 0x00005854 File Offset: 0x00003A54
	private static GameObject smethod_0()
	{
		if (Main._reticleObj == null)
		{
			Main._reticleObj = GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/ReticleParent");
		}
		return Main._reticleObj;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00005884 File Offset: 0x00003A84
	private static GameObject smethod_1()
	{
		if (Main._hudVoiceIcon == null)
		{
			Main._hudVoiceIcon = GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/VoiceDotParent");
		}
		return Main._hudVoiceIcon;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000058B4 File Offset: 0x00003AB4
	public static void smethod_2()
	{
		Main.melon = MelonPreferences.CreateCategory("DesktopFOV", "MelonLoader");
		Main.melonPreferences_Entry_3 = Main.melon.CreateEntry<float>("DefaultFOV", 60f, "Field of View", null, false, false, null, null);
		Main.melonPreferences_Entry_4 = Main.melon.CreateEntry<float>("FOVChangeAmount", 1f, "Change FOV Amount", null, false, false, null, null);
		Main.melonPreferences_Entry_5 = Main.melon.CreateEntry<float>("ZoomMultiplier", 6f, "Zoom Multiplier", null, false, false, null, null);
		Main.melonPreferences_Entry_0 = Main.melon.CreateEntry<bool>("HideReticleWhenZoomed", true, "Hide Reticle While Zoomed?", null, false, false, null, null);
		Main.melonPreferences_Entry_1 = Main.melon.CreateEntry<bool>("EnableZoom", true, "Enable Zoom Feature", null, false, false, null, null);
		Main.melonPreferences_Entry_6 = Main.melon.CreateEntry<string>("ZoomKeybind", "X", "Zoom Keybind", null, false, false, null, null);
		Main.melonPreferences_Entry_2 = Main.melon.CreateEntry<bool>("disableCTRLZoom", false, "Disable CTRL Zoom Feature", null, false, false, null, null);
		MelonLogger.Msg("[Ctrl + ScrollWheel] -> " + (Main.melonPreferences_Entry_2.Value ? "Function Disabled" : "Increase or decrease field of view"));
		MelonLogger.Msg("[Ctrl + ClickMiddleMouse] -> Reset field of view");
		Main._zKey = Class8.smethod_1();
		if (Main.melonPreferences_Entry_1.Value)
		{
			MelonLogger.Msg("[" + Main.melonPreferences_Entry_6.Value + " Key] -> Zoom");
		}
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00005A24 File Offset: 0x00003C24
	public static void smethod_3()
	{
		if (!(Class8.smethod_0() == null) && !XRDevice.isPresent)
		{
			if (!Application.isFocused && Main._isZoomed)
			{
				Main._isZoomed = false;
				Main.melonPreferences_Entry_3.Value = Main._preZoom;
				Class9.smethod_0().SetActive(true);
				Class9.smethod_1().SetActive(true);
			}
			if (Class8.smethod_6("Mouse ScrollWheel", true, false) < 0f)
			{
				Main.melonPreferences_Entry_3.Value += Main.melonPreferences_Entry_4.Value;
			}
			if (Class8.smethod_6("Mouse ScrollWheel", true, false) > 0f)
			{
				Main.melonPreferences_Entry_3.Value -= Main.melonPreferences_Entry_4.Value;
			}
			if (Class8.smethod_5(2, true, false))
			{
				Main.melonPreferences_Entry_3.Value = 60f;
			}
			if (!Class8.smethod_2(Main._zKey, false, false) || !Main.melonPreferences_Entry_1.Value || Main._isZoomed)
			{
				if (Class8.smethod_4(Main._zKey, false, false) && Main.melonPreferences_Entry_1.Value && Main._isZoomed)
				{
					Main._isZoomed = false;
					Main.melonPreferences_Entry_3.Value = Main._preZoom;
					Class9.smethod_0().SetActive(true);
					Class9.smethod_1().SetActive(true);
				}
			}
			else
			{
				Main._isZoomed = true;
				Main._preZoom = Main.melonPreferences_Entry_3.Value;
				Main.melonPreferences_Entry_3.Value /= Main.melonPreferences_Entry_5.Value;
				if (Main.melonPreferences_Entry_0.Value)
				{
					Class9.smethod_0().SetActive(false);
					Class9.smethod_1().SetActive(false);
				}
			}
			if (!Main.melonPreferences_Entry_2.Value && ((Class8.smethod_4(306, false, false) || Class8.smethod_4(305, false, false)) && !Main._isZoomed && Main._lastFOV != Main.melonPreferences_Entry_3.Value))
			{
				MelonLogger.Msg(string.Format("FOV Changed: {0}", Main.melonPreferences_Entry_3.Value));
				Main._lastFOV = Main.melonPreferences_Entry_3.Value;
			}
			if (Camera.main != null)
			{
				Camera.main.fieldOfView = Main.melonPreferences_Entry_3.Value;
			}
		}
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000022C0 File Offset: 0x000004C0
	public Class9()
	{
		Class39.smethod_16();
		base..ctor();
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002835 File Offset: 0x00000A35
	internal static bool smethod_4()
	{
		return Class9.class9_0 == null;
	}

	// Token: 0x0400007A RID: 122
	private static Class9 class9_0;
}
