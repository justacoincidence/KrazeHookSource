using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace ShadowButtonAPI
{
	// Token: 0x02000054 RID: 84
	public class QMMenu
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000B61C File Offset: 0x0000981C
		public QMMenu(string menuName, string pageTitle, bool root = true, bool backButton = true)
		{
			Class39.smethod_16();
			base..ctor();
			GameObject gameObject = Object.Instantiate<GameObject>(QMMenu.qmStuff.quickMenu.transform.Find("Container/Window/QMParent/Menu_DevTools").gameObject, QMMenu.qmStuff.quickMenu.transform.Find("Container/Window/QMParent"));
			gameObject.name = "Menu_" + menuName;
			gameObject.transform.SetSiblingIndex(5);
			gameObject.SetActive(false);
			Object.Destroy(gameObject.GetComponent<DevMenu>());
			this.page = gameObject.AddComponent<UIPage>();
			this.page.field_Public_String_0 = menuName;
			this.page.field_Private_Boolean_1 = true;
			this.page.field_Protected_MenuStateController_0 = QMMenu.qmStuff.menuStateController;
			this.page.field_Private_List_1_UIPage_0 = new List<UIPage>();
			this.page.field_Private_List_1_UIPage_0.Add(this.page);
			if (!root)
			{
				this.page.field_Public_Boolean_0 = true;
				try
				{
					gameObject.transform.Find("Scrollrect/Scrollbar").gameObject.SetActive(true);
					gameObject.transform.Find("Scrollrect").GetComponent<ScrollRect>().enabled = true;
					gameObject.transform.Find("Scrollrect").GetComponent<ScrollRect>().verticalScrollbar = gameObject.transform.Find("Scrollrect/Scrollbar").GetComponent<Scrollbar>();
					gameObject.transform.Find("Scrollrect").GetComponent<ScrollRect>().verticalScrollbarVisibility = 1;
				}
				catch
				{
				}
			}
			QMMenu.qmStuff.menuStateController.field_Private_Dictionary_2_String_UIPage_0.Add(menuName, this.page);
			if (root)
			{
				List<UIPage> list = QMMenu.qmStuff.menuStateController.field_Public_ArrayOf_UIPage_0.ToList<UIPage>();
				list.Add(this.page);
				QMMenu.qmStuff.menuStateController.field_Public_ArrayOf_UIPage_0 = list.ToArray();
			}
			TextMeshProUGUI componentInChildren = gameObject.GetComponentInChildren<TextMeshProUGUI>(true);
			componentInChildren.text = pageTitle;
			this.menuContents = gameObject.transform.Find("Scrollrect/Viewport/VerticalLayoutGroup/Buttons");
			for (int i = 0; i < this.menuContents.transform.childCount; i++)
			{
				Object.Destroy(this.menuContents.transform.GetChild(i).gameObject);
			}
			if (backButton)
			{
				GameObject gameObject2 = gameObject.transform.Find("Header_DevTools/LeftItemContainer/Button_Back").gameObject;
				gameObject2.SetActive(true);
				gameObject2.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
				gameObject2.GetComponent<Button>().onClick.AddListener(new Action(this.method_0));
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000357E File Offset: 0x0000177E
		public void OpenMenu()
		{
			QMMenu.qmStuff.menuStateController.Method_Public_Void_String_UIContext_Boolean_TransitionType_0(this.page.field_Public_String_0, null, false, 0);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000359D File Offset: 0x0000179D
		public void CloseMenu()
		{
			this.page.Method_Public_Virtual_New_Void_0();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000035AA File Offset: 0x000017AA
		// Note: this type is marked as 'beforefieldinit'.
		static QMMenu()
		{
			Class39.smethod_16();
			QMMenu.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000035BB File Offset: 0x000017BB
		[CompilerGenerated]
		private void method_0()
		{
			this.page.Method_Protected_Virtual_New_Void_0();
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000035C8 File Offset: 0x000017C8
		internal static bool smethod_0()
		{
			return QMMenu.qmmenu_0 == null;
		}

		// Token: 0x0400017B RID: 379
		public static QuickMenuStuff qmStuff;

		// Token: 0x0400017C RID: 380
		public UIPage page;

		// Token: 0x0400017D RID: 381
		public Transform menuContents;

		// Token: 0x0400017E RID: 382
		private static QMMenu qmmenu_0;
	}
}
