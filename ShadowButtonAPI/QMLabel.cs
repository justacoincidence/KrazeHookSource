using System;
using TMPro;
using UnityEngine;

namespace ShadowButtonAPI
{
	// Token: 0x02000053 RID: 83
	public class QMLabel
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0000B564 File Offset: 0x00009764
		public QMLabel(Transform menu, float float_0, float float_1, string contents)
		{
			Class39.smethod_16();
			base..ctor();
			this.label = Object.Instantiate<GameObject>(QMLabel.qmStuff.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks").gameObject, menu);
			this.label.name = contents;
			this.label.transform.localPosition = new Vector3(float_0, float_1, 0f);
			this.text = this.label.GetComponentInChildren<TextMeshProUGUI>();
			this.text.text = contents;
			this.text.enableAutoSizing = true;
			this.text.color = Color.white;
			this.label.gameObject.SetActive(false);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00003563 File Offset: 0x00001763
		// Note: this type is marked as 'beforefieldinit'.
		static QMLabel()
		{
			Class39.smethod_16();
			QMLabel.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003574 File Offset: 0x00001774
		internal static bool smethod_0()
		{
			return QMLabel.qmlabel_0 == null;
		}

		// Token: 0x04000177 RID: 375
		public static QuickMenuStuff qmStuff;

		// Token: 0x04000178 RID: 376
		public TextMeshProUGUI text;

		// Token: 0x04000179 RID: 377
		public GameObject label;

		// Token: 0x0400017A RID: 378
		internal static QMLabel qmlabel_0;
	}
}
