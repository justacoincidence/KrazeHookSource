using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WTFBlaze
{
	// Token: 0x0200006D RID: 109
	public class QMToggleButton : QMButtonBase
	{
		// Token: 0x0600033C RID: 828 RVA: 0x000039D6 File Offset: 0x00001BD6
		public QMToggleButton(QMNestedButton location, float btnXPos, float btnYPos, string btnText, Action onAction, Action offAction, string btnToolTip, bool defaultState = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = location.GetMenuName();
			this.method_0(btnXPos, btnYPos, btnText, onAction, offAction, btnToolTip, defaultState);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003A01 File Offset: 0x00001C01
		public QMToggleButton(string location, float btnXPos, float btnYPos, string btnText, Action onAction, Action offAction, string btnToolTip, bool defaultState = false)
		{
			Class39.smethod_16();
			base..ctor();
			this.btnQMLoc = location;
			this.method_0(btnXPos, btnYPos, btnText, onAction, offAction, btnToolTip, defaultState);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000CE04 File Offset: 0x0000B004
		private void method_0(float float_0, float float_1, string string_0, Action action_0, Action action_1, string string_1, bool bool_0)
		{
			this.btnType = "ToggleButton";
			this.button = Object.Instantiate<GameObject>(APIUtils.SingleButtonTemplate(), GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/" + this.btnQMLoc).transform, true);
			this.RandomNumb = APIUtils.RandomNumbers();
			this.button.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 176f);
			this.button.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68f, 796f);
			this.btnTextComp = this.button.GetComponentInChildren<TextMeshProUGUI>(true);
			this.btnComp = this.button.GetComponentInChildren<Button>(true);
			this.btnComp.onClick = new Button.ButtonClickedEvent();
			this.btnComp.onClick.AddListener(new Action(this.method_1));
			this.btnImageComp = this.button.transform.Find("Icon").GetComponentInChildren<Image>(true);
			this.initShift[0] = 0;
			this.initShift[1] = 0;
			base.SetLocation(float_0, float_1);
			this.SetButtonText(string_0);
			this.SetButtonActions(action_0, action_1);
			base.SetToolTip(string_1);
			base.SetActive(true);
			this.currentState = bool_0;
			Sprite sprite = (!this.currentState) ? APIUtils.GetOffIconSprite() : APIUtils.GetOnIconSprite();
			this.btnImageComp.sprite = sprite;
			this.btnImageComp.overrideSprite = sprite;
			BlazesButtonAPI.allQMToggleButtons.Add(this);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000CF80 File Offset: 0x0000B180
		private void method_1()
		{
			this.currentState = !this.currentState;
			Sprite sprite = (!this.currentState) ? APIUtils.GetOffIconSprite() : APIUtils.GetOnIconSprite();
			this.btnImageComp.sprite = sprite;
			this.btnImageComp.overrideSprite = sprite;
			if (this.currentState)
			{
				this.OnAction();
			}
			else
			{
				this.OffAction();
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003937 File Offset: 0x00001B37
		public void SetButtonText(string buttonText)
		{
			this.button.GetComponentInChildren<TextMeshProUGUI>().text = buttonText;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003A27 File Offset: 0x00001C27
		public void SetButtonActions(Action onAction, Action offAction)
		{
			this.OnAction = onAction;
			this.OffAction = offAction;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		public void SetToggleState(bool newState, bool shouldInvoke = false)
		{
			try
			{
				Sprite sprite = (!newState) ? APIUtils.GetOffIconSprite() : APIUtils.GetOnIconSprite();
				this.btnImageComp.sprite = sprite;
				this.btnImageComp.overrideSprite = sprite;
				this.currentState = newState;
				if (shouldInvoke)
				{
					if (newState)
					{
						this.OnAction();
					}
					else
					{
						this.OffAction();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003A37 File Offset: 0x00001C37
		public void ClickMe()
		{
			this.method_1();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00003A3F File Offset: 0x00001C3F
		public bool GetCurrentState()
		{
			return this.currentState;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003A47 File Offset: 0x00001C47
		internal static bool smethod_1()
		{
			return QMToggleButton.qmtoggleButton_0 == null;
		}

		// Token: 0x040001E6 RID: 486
		protected TextMeshProUGUI btnTextComp;

		// Token: 0x040001E7 RID: 487
		protected Button btnComp;

		// Token: 0x040001E8 RID: 488
		protected Image btnImageComp;

		// Token: 0x040001E9 RID: 489
		protected bool currentState;

		// Token: 0x040001EA RID: 490
		protected Action OnAction;

		// Token: 0x040001EB RID: 491
		protected Action OffAction;

		// Token: 0x040001EC RID: 492
		internal static QMToggleButton qmtoggleButton_0;
	}
}
