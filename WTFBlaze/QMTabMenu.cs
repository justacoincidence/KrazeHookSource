using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using VRC.UI.Elements;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Menus;
using VRC.UI.Elements.Tooltips;

namespace WTFBlaze
{
	// Token: 0x02000070 RID: 112
	public class QMTabMenu
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00003B14 File Offset: 0x00001D14
		public QMTabMenu(string toolTipText, string menuTitle, Sprite img = null)
		{
			Class39.smethod_16();
			base..ctor();
			this.method_0(toolTipText, menuTitle, img);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D448 File Offset: 0x0000B648
		private void method_0(string string_0, string string_1, Sprite sprite_0 = null)
		{
			this.MenuName = string.Format("{0}-Menu-{1}", "KrazeHookButtons", APIUtils.RandomNumbers());
			this.MenuObject = Object.Instantiate<GameObject>(APIUtils.GetMenuPageTemplate(), APIUtils.GetMenuPageTemplate().transform.parent);
			this.MenuObject.name = this.MenuName;
			this.MenuObject.SetActive(false);
			Object.DestroyImmediate(this.MenuObject.GetComponent<LaunchPadQMMenu>());
			this.MenuPage = this.MenuObject.AddComponent<UIPage>();
			this.MenuPage.field_Public_String_0 = this.MenuName;
			this.MenuPage.field_Private_Boolean_1 = true;
			this.MenuPage.field_Protected_MenuStateController_0 = APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0();
			this.MenuPage.field_Private_List_1_UIPage_0 = new List<UIPage>();
			this.MenuPage.field_Private_List_1_UIPage_0.Add(this.MenuPage);
			APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().field_Private_Dictionary_2_String_UIPage_0.Add(this.MenuName, this.MenuPage);
			List<UIPage> list = APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
			list.Add(this.MenuPage);
			APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().field_Public_ArrayOf_UIPage_0 = list.ToArray();
			this.MenuObject.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup").DestroyChildren();
			this.MenuTitleText = this.MenuObject.GetComponentInChildren<TextMeshProUGUI>(true);
			this.MenuTitleText.text = string_1;
			this.MenuObject.transform.GetChild(0).Find("RightItemContainer/Button_QM_Expand").gameObject.SetActive(false);
			for (int i = 0; i < this.MenuObject.transform.childCount; i++)
			{
				if (this.MenuObject.transform.GetChild(i).name != "Header_H1" && this.MenuObject.transform.GetChild(i).name != "ScrollRect")
				{
					Object.Destroy(this.MenuObject.transform.GetChild(i).gameObject);
				}
			}
			this.MenuObject.transform.Find("ScrollRect").GetComponent<ScrollRect>().enabled = false;
			this.MainButton = Object.Instantiate<GameObject>(APIUtils.GetTabButtonTemplate(), APIUtils.GetTabButtonTemplate().transform.parent);
			this.MainButton.name = string.Format("{0}-{1}", "KrazeHookButtons", APIUtils.RandomNumbers());
			this.MenuTabComp = this.MainButton.GetComponent<MenuTab>();
			this.MenuTabComp.field_Private_MenuStateController_0 = APIUtils.GetMenuStateControllerInstance();
			this.MenuTabComp.field_Public_String_0 = this.MenuName;
			this.MenuTabComp.GetComponent<StyleElement>().field_Private_Selectable_0 = this.MenuTabComp.GetComponent<Button>();
			this.BadgeObject = this.MainButton.transform.GetChild(0).gameObject;
			this.BadgeText = this.BadgeObject.GetComponentInChildren<TextMeshProUGUI>();
			this.MainButton.GetComponent<Button>().onClick.AddListener(new Action(this.method_1));
			this.SetToolTip(string_0);
			if (sprite_0 != null)
			{
				this.SetImage(sprite_0);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000D77C File Offset: 0x0000B97C
		public void SetImage(Sprite newImg)
		{
			this.MainButton.transform.Find("Icon").GetComponent<Image>().sprite = newImg;
			this.MainButton.transform.Find("Icon").GetComponent<Image>().overrideSprite = newImg;
			this.MainButton.transform.Find("Icon").GetComponent<Image>().color = Color.white;
			this.MainButton.transform.Find("Icon").GetComponent<Image>().m_Color = Color.white;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003B2A File Offset: 0x00001D2A
		public void SetToolTip(string newText)
		{
			this.MainButton.GetComponent<UiTooltip>().field_Public_String_0 = newText;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00003B3D File Offset: 0x00001D3D
		public void SetIndex(int newPosition)
		{
			this.MainButton.transform.SetSiblingIndex(newPosition);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003B50 File Offset: 0x00001D50
		public void SetActive(bool newState)
		{
			this.MainButton.SetActive(newState);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003B5E File Offset: 0x00001D5E
		public void SetBadge(bool showing = true, string text = "")
		{
			if (!(this.BadgeObject == null) && !(this.BadgeText == null))
			{
				this.BadgeObject.SetActive(showing);
				this.BadgeText.text = text;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D814 File Offset: 0x0000BA14
		public string GetMenuName()
		{
			return this.MenuName;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D82C File Offset: 0x0000BA2C
		public GameObject GetMenuObject()
		{
			return this.MenuObject;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D844 File Offset: 0x0000BA44
		public GameObject GetMainButton()
		{
			return this.MainButton;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00003B97 File Offset: 0x00001D97
		[CompilerGenerated]
		private void method_1()
		{
			this.MenuTabComp.GetComponent<StyleElement>().field_Private_Selectable_0 = this.MenuTabComp.GetComponent<Button>();
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00003BB4 File Offset: 0x00001DB4
		internal static bool smethod_0()
		{
			return QMTabMenu.qmtabMenu_0 == null;
		}

		// Token: 0x040001F9 RID: 505
		protected string btnQMLoc;

		// Token: 0x040001FA RID: 506
		protected GameObject MenuObject;

		// Token: 0x040001FB RID: 507
		protected TextMeshProUGUI MenuTitleText;

		// Token: 0x040001FC RID: 508
		protected UIPage MenuPage;

		// Token: 0x040001FD RID: 509
		protected GameObject MainButton;

		// Token: 0x040001FE RID: 510
		protected GameObject BadgeObject;

		// Token: 0x040001FF RID: 511
		protected TextMeshProUGUI BadgeText;

		// Token: 0x04000200 RID: 512
		protected MenuTab MenuTabComp;

		// Token: 0x04000201 RID: 513
		protected string MenuName;

		// Token: 0x04000202 RID: 514
		internal static QMTabMenu qmtabMenu_0;
	}
}
