using System;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements.Tooltips;

namespace WTFBlaze
{
	// Token: 0x0200006B RID: 107
	public class QMButtonBase
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0000C934 File Offset: 0x0000AB34
		public GameObject GetGameObject()
		{
			return this.button;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x000038DD File Offset: 0x00001ADD
		public void SetActive(bool state)
		{
			this.button.gameObject.SetActive(state);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000C94C File Offset: 0x0000AB4C
		public void SetLocation(float float_0, float float_1)
		{
			this.button.GetComponent<RectTransform>().anchoredPosition += Vector2.right * (232f * (float_0 + (float)this.initShift[0]));
			this.button.GetComponent<RectTransform>().anchoredPosition += Vector2.down * (210f * (float_1 + (float)this.initShift[1]));
			this.btnTag = string.Concat(new string[]
			{
				"(",
				float_0.ToString(),
				",",
				float_1.ToString(),
				")"
			});
			this.button.name = this.btnQMLoc + "/" + this.btnType + this.btnTag;
			this.button.GetComponent<Button>().name = "KrazeHookButtons-" + this.btnType + this.btnTag;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000038F0 File Offset: 0x00001AF0
		public void SetToolTip(string buttonToolTip)
		{
			this.button.GetComponent<UiTooltip>().field_Public_String_0 = buttonToolTip;
			this.button.GetComponent<UiTooltip>().field_Public_String_1 = buttonToolTip;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000CA50 File Offset: 0x0000AC50
		public void DestroyMe()
		{
			try
			{
				Object.Destroy(this.button);
			}
			catch
			{
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003914 File Offset: 0x00001B14
		public QMButtonBase()
		{
			Class39.smethod_16();
			this.initShift = new int[2];
			base..ctor();
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000392D File Offset: 0x00001B2D
		internal static bool smethod_0()
		{
			return QMButtonBase.qmbuttonBase_0 == null;
		}

		// Token: 0x040001DC RID: 476
		protected GameObject button;

		// Token: 0x040001DD RID: 477
		protected string btnQMLoc;

		// Token: 0x040001DE RID: 478
		protected string btnType;

		// Token: 0x040001DF RID: 479
		protected string btnTag;

		// Token: 0x040001E0 RID: 480
		protected int[] initShift;

		// Token: 0x040001E1 RID: 481
		protected Color OrigBackground;

		// Token: 0x040001E2 RID: 482
		protected Color OrigText;

		// Token: 0x040001E3 RID: 483
		protected int RandomNumb;

		// Token: 0x040001E4 RID: 484
		internal static QMButtonBase qmbuttonBase_0;
	}
}
