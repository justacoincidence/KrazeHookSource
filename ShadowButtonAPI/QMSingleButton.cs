using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Tooltips;

namespace ShadowButtonAPI
{
	// Token: 0x0200005F RID: 95
	public class QMSingleButton
	{
		// Token: 0x060002FD RID: 765 RVA: 0x0000C044 File Offset: 0x0000A244
		public QMSingleButton(Transform parent, string text, string toolTip, Sprite Icon, Action action)
		{
			Class39.smethod_16();
			base..ctor();
			GameObject gameObject = Object.Instantiate<GameObject>(QMSingleButton.qmStuff.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Emojis").gameObject, parent);
			gameObject.transform.parent = parent;
			gameObject.name = text + "_Shadow_Button";
			gameObject.transform.Find("Text_H4").gameObject.GetComponent<TextMeshProUGUI>().text = text;
			if (Icon != null)
			{
				gameObject.transform.Find("Icon").GetComponent<Image>().sprite = Icon;
			}
			else
			{
				Object.Destroy(gameObject.transform.Find("Icon").GetComponent<Image>());
			}
			gameObject.GetComponent<UiTooltip>().field_Public_String_0 = toolTip;
			Button component = gameObject.GetComponent<Button>();
			component.onClick = new Button.ButtonClickedEvent();
			component.onClick.AddListener(action);
			gameObject.SetActive(true);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000036D9 File Offset: 0x000018D9
		// Note: this type is marked as 'beforefieldinit'.
		static QMSingleButton()
		{
			Class39.smethod_16();
			QMSingleButton.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000036EA File Offset: 0x000018EA
		internal static bool smethod_0()
		{
			return QMSingleButton.qmsingleButton_0 == null;
		}

		// Token: 0x0400019C RID: 412
		public static QuickMenuStuff qmStuff;

		// Token: 0x0400019D RID: 413
		private static QMSingleButton qmsingleButton_0;
	}
}
