using System;

namespace ShadowButtonAPI
{
	// Token: 0x02000066 RID: 102
	public class SULabel
	{
		// Token: 0x0600030E RID: 782 RVA: 0x000037A5 File Offset: 0x000019A5
		public SULabel(float float_0, float float_1, string content)
		{
			Class39.smethod_16();
			this.quickMenuStuff_0 = new QuickMenuStuff();
			base..ctor();
			new QMLabel(this.quickMenuStuff_0.selectedUserMenuQM.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_UserActions").transform, float_0, float_1, content);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000037E5 File Offset: 0x000019E5
		internal static bool smethod_0()
		{
			return SULabel.sulabel_0 == null;
		}

		// Token: 0x040001BC RID: 444
		private QuickMenuStuff quickMenuStuff_0;

		// Token: 0x040001BD RID: 445
		internal static SULabel sulabel_0;
	}
}
