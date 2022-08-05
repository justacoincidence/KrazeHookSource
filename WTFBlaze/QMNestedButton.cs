using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace WTFBlaze
{
	// Token: 0x0200006E RID: 110
	public class QMNestedButton
	{
		// Token: 0x06000346 RID: 838 RVA: 0x00003A51 File Offset: 0x00001C51
		public QMNestedButton(QMNestedButton location, float posX, float posY, string btnText, string toolTipText, string menuTitle, bool halfButton = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = location.GetMenuName();
			this.method_0(false, btnText, posX, posY, toolTipText, menuTitle, halfButton);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003A7B File Offset: 0x00001C7B
		public QMNestedButton(string location, float posX, float posY, string btnText, string toolTipText, string menuTitle, bool halfButton = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = location;
			this.method_0(location.StartsWith("Menu_"), btnText, posX, posY, toolTipText, menuTitle, halfButton);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003AAA File Offset: 0x00001CAA
		public QMNestedButton(QMTabMenu location, float posX, float posY, string btnText, string toolTipText, string menuTitle, bool halfButton = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = location.GetMenuName();
			this.method_0(false, btnText, posX, posY, toolTipText, menuTitle, halfButton);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D05C File Offset: 0x0000B25C
		private void method_0(bool bool_0, string string_0, float float_0, float float_1, string string_1, string string_2, bool bool_1)
		{
			QMNestedButton.<>c__DisplayClass11_0 CS$<>8__locals1 = new QMNestedButton.<>c__DisplayClass11_0();
			CS$<>8__locals1.bool_0 = bool_0;
			CS$<>8__locals1.qmnestedButton_0 = this;
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
			if (CS$<>8__locals1.bool_0)
			{
				List<UIPage> list = APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
				list.Add(this.MenuPage);
				APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().field_Public_ArrayOf_UIPage_0 = list.ToArray();
			}
			this.MenuObject.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup").DestroyChildren();
			this.MenuTitleText = this.MenuObject.GetComponentInChildren<TextMeshProUGUI>(true);
			this.MenuTitleText.text = string_2;
			this.IsMenuRoot = CS$<>8__locals1.bool_0;
			this.BackButton = this.MenuObject.transform.GetChild(0).Find("LeftItemContainer/Button_Back").gameObject;
			this.BackButton.SetActive(true);
			this.BackButton.GetComponentInChildren<Button>().onClick = new Button.ButtonClickedEvent();
			this.BackButton.GetComponentInChildren<Button>().onClick.AddListener(new Action(CS$<>8__locals1.method_0));
			this.MenuObject.transform.GetChild(0).Find("RightItemContainer/Button_QM_Expand").gameObject.SetActive(false);
			this.MainButton = new QMSingleButton(this.btnQMLoc, float_0, float_1, string_0, new Action(this.OpenMe), string_1, bool_1);
			for (int i = 0; i < this.MenuObject.transform.childCount; i++)
			{
				if (this.MenuObject.transform.GetChild(i).name != "Header_H1" && this.MenuObject.transform.GetChild(i).name != "ScrollRect")
				{
					Object.Destroy(this.MenuObject.transform.GetChild(i).gameObject);
				}
			}
			this.MenuObject.transform.Find("ScrollRect").GetComponent<ScrollRect>().enabled = false;
			BlazesButtonAPI.allQMNestedButtons.Add(this);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public void OpenMe()
		{
			APIUtils.GetQuickMenuInstance().Method_Public_get_MenuStateController_0().Method_Public_Void_String_UIContext_Boolean_TransitionType_0(this.MenuPage.field_Public_String_0, null, false, 0);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003AF3 File Offset: 0x00001CF3
		public void CloseMe()
		{
			this.MenuPage.Method_Public_Virtual_New_Void_0();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D35C File Offset: 0x0000B55C
		public string GetMenuName()
		{
			return this.MenuName;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D374 File Offset: 0x0000B574
		public GameObject GetMenuObject()
		{
			return this.MenuObject;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D38C File Offset: 0x0000B58C
		public QMSingleButton GetMainButton()
		{
			return this.MainButton;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D3A4 File Offset: 0x0000B5A4
		public GameObject GetBackButton()
		{
			return this.BackButton;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003B00 File Offset: 0x00001D00
		internal static bool smethod_0()
		{
			return QMNestedButton.qmnestedButton_0 == null;
		}

		// Token: 0x040001ED RID: 493
		protected string btnQMLoc;

		// Token: 0x040001EE RID: 494
		protected GameObject MenuObject;

		// Token: 0x040001EF RID: 495
		protected TextMeshProUGUI MenuTitleText;

		// Token: 0x040001F0 RID: 496
		protected UIPage MenuPage;

		// Token: 0x040001F1 RID: 497
		protected bool IsMenuRoot;

		// Token: 0x040001F2 RID: 498
		protected GameObject BackButton;

		// Token: 0x040001F3 RID: 499
		protected QMSingleButton MainButton;

		// Token: 0x040001F4 RID: 500
		protected string MenuName;

		// Token: 0x040001F5 RID: 501
		internal static QMNestedButton qmnestedButton_0;
	}
}
