using System;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace WTFBlaze
{
	// Token: 0x0200006C RID: 108
	public class QMSingleButton : QMButtonBase
	{
		// Token: 0x06000330 RID: 816 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public QMSingleButton(QMNestedButton btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, bool halfBtn = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = btnMenu.GetMenuName();
			if (halfBtn)
			{
				btnYLocation -= 0.21f;
			}
			this.method_0(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip);
			if (halfBtn)
			{
				this.button.GetComponentInChildren<RectTransform>().sizeDelta /= new Vector2(1f, 2f);
				this.button.GetComponentInChildren<TextMeshProUGUI>().rectTransform.anchoredPosition = new Vector2(0f, 22f);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CB14 File Offset: 0x0000AD14
		public QMSingleButton(string btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, bool halfBtn = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = btnMenu;
			if (halfBtn)
			{
				btnYLocation -= 0.21f;
			}
			this.method_0(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip);
			if (halfBtn)
			{
				this.button.GetComponentInChildren<RectTransform>().sizeDelta /= new Vector2(1f, 2f);
				this.button.GetComponentInChildren<TextMeshProUGUI>().rectTransform.anchoredPosition = new Vector2(0f, 22f);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		public QMSingleButton(QMTabMenu btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, bool halfBtn = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = btnMenu.GetMenuName();
			if (halfBtn)
			{
				btnYLocation -= 0.21f;
			}
			this.method_0(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip);
			if (halfBtn)
			{
				this.button.GetComponentInChildren<RectTransform>().sizeDelta /= new Vector2(1f, 2f);
				this.button.GetComponentInChildren<TextMeshProUGUI>().rectTransform.anchoredPosition = new Vector2(0f, 22f);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CC34 File Offset: 0x0000AE34
		private protected void method_0(float float_0, float float_1, string string_0, Action action_0, string string_1)
		{
			this.btnType = "SingleButton";
			this.button = Object.Instantiate<GameObject>(APIUtils.SingleButtonTemplate(), GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/" + this.btnQMLoc).transform, true);
			this.RandomNumb = APIUtils.RandomNumbers();
			this.button.GetComponentInChildren<TextMeshProUGUI>().fontSize = 30f;
			this.button.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 176f);
			this.button.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68f, 796f);
			this.button.transform.Find("Icon").GetComponentInChildren<Image>().gameObject.SetActive(false);
			this.button.GetComponentInChildren<TextMeshProUGUI>().rectTransform.anchoredPosition += new Vector2(0f, 50f);
			this.initShift[0] = 0;
			this.initShift[1] = 0;
			base.SetLocation(float_0, float_1);
			this.SetButtonText(string_0);
			base.SetToolTip(string_1);
			this.SetAction(action_0);
			this.OrigText = this.button.GetComponentInChildren<TextMeshProUGUI>().color;
			base.SetActive(true);
			BlazesButtonAPI.allQMSingleButtons.Add(this);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000CD84 File Offset: 0x0000AF84
		public void SetBackgroundImage(Sprite newImg)
		{
			this.button.transform.Find("Background").GetComponent<Image>().sprite = newImg;
			this.button.transform.Find("Background").GetComponent<Image>().overrideSprite = newImg;
			this.method_1();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00003937 File Offset: 0x00001B37
		public void SetButtonText(string buttonText)
		{
			this.button.GetComponentInChildren<TextMeshProUGUI>().text = buttonText;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000394A File Offset: 0x00001B4A
		public void SetAction(Action buttonAction)
		{
			this.button.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			if (buttonAction != null)
			{
				this.button.GetComponent<Button>().onClick.AddListener(DelegateSupport.ConvertDelegate<UnityAction>(buttonAction));
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00003982 File Offset: 0x00001B82
		public void SetInteractable(bool newState)
		{
			this.button.GetComponent<Button>().interactable = newState;
			this.method_1();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000399B File Offset: 0x00001B9B
		public void ClickMe()
		{
			this.button.GetComponent<Button>().onClick.Invoke();
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		public Image GetBackgroundImage()
		{
			return this.button.transform.Find("Background").GetComponent<Image>();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000039B2 File Offset: 0x00001BB2
		private void method_1()
		{
			this.button.SetActive(false);
			this.button.SetActive(true);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000039CC File Offset: 0x00001BCC
		internal static bool smethod_1()
		{
			return QMSingleButton.qmsingleButton_0 == null;
		}

		// Token: 0x040001E5 RID: 485
		internal static QMSingleButton qmsingleButton_0;
	}
}
