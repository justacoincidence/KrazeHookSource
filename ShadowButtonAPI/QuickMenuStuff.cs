using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace ShadowButtonAPI
{
	// Token: 0x02000063 RID: 99
	public class QuickMenuStuff
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0000C360 File Offset: 0x0000A560
		public QuickMenuStuff()
		{
			Class39.smethod_16();
			base..ctor();
			this.quickMenu = Resources.FindObjectsOfTypeAll<QuickMenu>().First<QuickMenu>();
			this.menuStateController = this.quickMenu.gameObject.GetComponent<MenuStateController>();
			this.Button_WorldsIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon").GetComponent<Image>();
			this.Button_AvatarsIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon").GetComponent<Image>();
			this.Button_SocialIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon").GetComponent<Image>();
			this.Button_SafetyIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon").GetComponent<Image>();
			this.Button_GoHomeIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon").GetComponent<Image>();
			this.Button_RespawnIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon").GetComponent<Image>();
			this.StandIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>();
			this.Panel_NoNotifications_MessageIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon").gameObject.GetComponent<Image>();
			this.Button_NameplateVisibleIcon = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button A/Icon").GetComponent<Image>();
			this.selectedUserMenuQM = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_SelectedUser_Local").GetComponent<SelectedUserMenuQM>();
			this.tabMenuTemplat = this.quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools");
			this.Menu_DevTools = this.quickMenu.transform.Find("Container/Window/QMParent/Menu_DevTools");
			this.QMParent = this.quickMenu.transform.Find("Container/Window/QMParent");
			this.page_Buttons_QM = this.quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
			this.Menu_Dashboard = this.quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003751 File Offset: 0x00001951
		internal static bool smethod_0()
		{
			return QuickMenuStuff.quickMenuStuff_0 == null;
		}

		// Token: 0x040001A7 RID: 423
		public Image Button_WorldsIcon;

		// Token: 0x040001A8 RID: 424
		public Image Button_AvatarsIcon;

		// Token: 0x040001A9 RID: 425
		public Image Button_SocialIcon;

		// Token: 0x040001AA RID: 426
		public Image Button_SafetyIcon;

		// Token: 0x040001AB RID: 427
		public Image Panel_NoNotifications_MessageIcon;

		// Token: 0x040001AC RID: 428
		public Image Button_NameplateVisibleIcon;

		// Token: 0x040001AD RID: 429
		public Image Button_GoHomeIcon;

		// Token: 0x040001AE RID: 430
		public Image Button_RespawnIcon;

		// Token: 0x040001AF RID: 431
		public Image StandIcon;

		// Token: 0x040001B0 RID: 432
		public QuickMenu quickMenu;

		// Token: 0x040001B1 RID: 433
		public SelectedUserMenuQM selectedUserMenuQM;

		// Token: 0x040001B2 RID: 434
		public MenuStateController menuStateController;

		// Token: 0x040001B3 RID: 435
		public Transform tabMenuTemplat;

		// Token: 0x040001B4 RID: 436
		public Transform Menu_DevTools;

		// Token: 0x040001B5 RID: 437
		public Transform Menu_Dashboard;

		// Token: 0x040001B6 RID: 438
		public Transform QMParent;

		// Token: 0x040001B7 RID: 439
		public Transform page_Buttons_QM;

		// Token: 0x040001B8 RID: 440
		internal static QuickMenuStuff quickMenuStuff_0;
	}
}
