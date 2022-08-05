using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Tooltips;

namespace ShadowButtonAPI
{
	// Token: 0x02000062 RID: 98
	public class QMToggleButton
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000C274 File Offset: 0x0000A474
		public QMToggleButton(Transform parent, string text, string toolTip, Action<bool> action)
		{
			Class39.smethod_16();
			base..ctor();
			GameObject gameObject = Object.Instantiate<GameObject>(QMToggleButton.qmStuff.quickMenu.transform.Find("Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo").gameObject, parent);
			gameObject.transform.parent = parent;
			gameObject.name = text + "_Shadow_ToggleButton";
			gameObject.transform.Find("Text_H4").gameObject.GetComponent<TextMeshProUGUI>().text = text;
			gameObject.transform.Find("Icon_On").GetComponent<Image>().sprite = QMToggleButton.qmStuff.Panel_NoNotifications_MessageIcon.sprite;
			gameObject.GetComponent<UiTooltip>().field_Public_String_0 = toolTip;
			this.toggleButton = gameObject.GetComponent<Toggle>();
			this.toggleButton.onValueChanged = new Toggle.ToggleEvent();
			this.toggleButton.onValueChanged.AddListener(action);
			gameObject.SetActive(true);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00003736 File Offset: 0x00001936
		// Note: this type is marked as 'beforefieldinit'.
		static QMToggleButton()
		{
			Class39.smethod_16();
			QMToggleButton.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003747 File Offset: 0x00001947
		internal static bool smethod_0()
		{
			return QMToggleButton.qmtoggleButton_0 == null;
		}

		// Token: 0x040001A4 RID: 420
		public static QuickMenuStuff qmStuff;

		// Token: 0x040001A5 RID: 421
		public Toggle toggleButton;

		// Token: 0x040001A6 RID: 422
		internal static QMToggleButton qmtoggleButton_0;
	}
}
