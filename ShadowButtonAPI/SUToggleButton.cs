using System;

namespace ShadowButtonAPI
{
	// Token: 0x02000065 RID: 101
	public class SUToggleButton
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00003765 File Offset: 0x00001965
		public SUToggleButton(string text, string toolTip, Action<bool> action)
		{
			Class39.smethod_16();
			this.quickMenuStuff_0 = new QuickMenuStuff();
			base..ctor();
			new QMToggleButton(this.quickMenuStuff_0.selectedUserMenuQM.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UserActions").transform, text, toolTip, action);
		}

		// Token: 0x040001BB RID: 443
		private QuickMenuStuff quickMenuStuff_0;
	}
}
