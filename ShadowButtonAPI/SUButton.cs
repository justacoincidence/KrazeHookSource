using System;
using UnityEngine;

namespace ShadowButtonAPI
{
	// Token: 0x02000064 RID: 100
	public class SUButton
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0000C56C File Offset: 0x0000A76C
		public SUButton(string text, string toolTip, Sprite sprite, Action action)
		{
			Class39.smethod_16();
			this.quickMenuStuff_0 = new QuickMenuStuff();
			base..ctor();
			new QMSingleButton(this.quickMenuStuff_0.selectedUserMenuQM.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UserActions").transform, text, toolTip, sprite, action);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000375B File Offset: 0x0000195B
		internal static bool smethod_0()
		{
			return SUButton.subutton_0 == null;
		}

		// Token: 0x040001B9 RID: 441
		private QuickMenuStuff quickMenuStuff_0;

		// Token: 0x040001BA RID: 442
		internal static SUButton subutton_0;
	}
}
