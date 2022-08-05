using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShadowButtonAPI
{
	// Token: 0x02000055 RID: 85
	public class QMNestedButton
	{
		// Token: 0x060002BB RID: 699 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public QMNestedButton(Transform perant, string name, Sprite icon = null)
		{
			Class39.smethod_16();
			base..ctor();
			this.menu = new QMMenu(name, name, false, true);
			this.menuTransform = this.menu.menuContents;
			new QMSingleButton(perant, name, name, icon, new Action(this.method_0));
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000035D2 File Offset: 0x000017D2
		// Note: this type is marked as 'beforefieldinit'.
		static QMNestedButton()
		{
			Class39.smethod_16();
			QMNestedButton.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000035E3 File Offset: 0x000017E3
		[CompilerGenerated]
		private void method_0()
		{
			this.menu.OpenMenu();
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000035F0 File Offset: 0x000017F0
		internal static bool smethod_0()
		{
			return QMNestedButton.qmnestedButton_0 == null;
		}

		// Token: 0x0400017F RID: 383
		public static QuickMenuStuff qmStuff;

		// Token: 0x04000180 RID: 384
		public QMMenu menu;

		// Token: 0x04000181 RID: 385
		public Transform menuTransform;

		// Token: 0x04000182 RID: 386
		internal static QMNestedButton qmnestedButton_0;
	}
}
