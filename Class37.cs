using System;
using ShadowButtonAPI;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Tooltips;

// Token: 0x02000060 RID: 96
internal class Class37
{
	// Token: 0x06000300 RID: 768 RVA: 0x0000C138 File Offset: 0x0000A338
	public Class37(string string_0, string string_1, string string_2, Sprite sprite_0 = null)
	{
		Class39.smethod_16();
		base..ctor();
		Class37.<>c__DisplayClass3_0 CS$<>8__locals1 = new Class37.<>c__DisplayClass3_0();
		this.qmmenu_0 = new QMMenu(string_0, string_1, true, false);
		this.transform_0 = this.qmmenu_0.menuContents;
		CS$<>8__locals1.gameObject_0 = Object.Instantiate<GameObject>(Class37.quickMenuStuff_0.quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools").gameObject, Class37.quickMenuStuff_0.quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup"));
		CS$<>8__locals1.gameObject_0.name = string_0 + "Tab";
		MenuTab component = CS$<>8__locals1.gameObject_0.GetComponent<MenuTab>();
		component.field_Private_MenuStateController_0 = Class37.quickMenuStuff_0.menuStateController;
		component.field_Public_String_0 = string_0;
		Image component2 = CS$<>8__locals1.gameObject_0.transform.Find("Icon").GetComponent<Image>();
		CS$<>8__locals1.gameObject_0.GetComponent<UiTooltip>().field_Public_String_0 = string_2;
		component2.sprite = sprite_0;
		CS$<>8__locals1.gameObject_0.GetComponent<StyleElement>().field_Private_Selectable_0 = CS$<>8__locals1.gameObject_0.GetComponent<Button>();
		CS$<>8__locals1.gameObject_0.GetComponent<Button>().onClick.AddListener(new Action(CS$<>8__locals1.method_0));
		CS$<>8__locals1.gameObject_0.SetActive(true);
	}

	// Token: 0x06000301 RID: 769 RVA: 0x000036F4 File Offset: 0x000018F4
	// Note: this type is marked as 'beforefieldinit'.
	static Class37()
	{
		Class39.smethod_16();
		Class37.quickMenuStuff_0 = new QuickMenuStuff();
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00003705 File Offset: 0x00001905
	internal static bool smethod_0()
	{
		return Class37.class37_0 == null;
	}

	// Token: 0x0400019E RID: 414
	public static QuickMenuStuff quickMenuStuff_0;

	// Token: 0x0400019F RID: 415
	public QMMenu qmmenu_0;

	// Token: 0x040001A0 RID: 416
	public Transform transform_0;

	// Token: 0x040001A1 RID: 417
	private static Class37 class37_0;
}
