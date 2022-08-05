using System;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace WTFBlaze
{
	// Token: 0x02000073 RID: 115
	public static class APIUtils
	{
		// Token: 0x0600036D RID: 877 RVA: 0x0000DB4C File Offset: 0x0000BD4C
		public static QuickMenu GetQuickMenuInstance()
		{
			if (APIUtils.quickMenu_0 == null)
			{
				APIUtils.quickMenu_0 = Resources.FindObjectsOfTypeAll<QuickMenu>()[0];
			}
			return APIUtils.quickMenu_0;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000DB80 File Offset: 0x0000BD80
		public static MenuStateController GetMenuStateControllerInstance()
		{
			if (APIUtils.menuStateController_0 == null)
			{
				APIUtils.menuStateController_0 = APIUtils.GetQuickMenuInstance().GetComponent<MenuStateController>();
			}
			return APIUtils.menuStateController_0;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public static GameObject SingleButtonTemplate()
		{
			if (APIUtils.gameObject_0 == null)
			{
				Il2CppArrayBase<Button> componentsInChildren = APIUtils.GetQuickMenuInstance().GetComponentsInChildren<Button>(true);
				foreach (Button button in componentsInChildren)
				{
					if (button.name == "Button_Screenshot")
					{
						APIUtils.gameObject_0 = button.gameObject;
					}
				}
			}
			return APIUtils.gameObject_0;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public static GameObject GetMenuPageTemplate()
		{
			if (APIUtils.gameObject_2 == null)
			{
				APIUtils.gameObject_2 = GameObject.Find("UserInterface").transform.Find("Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard").gameObject;
			}
			return APIUtils.gameObject_2;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000DC74 File Offset: 0x0000BE74
		public static GameObject GetTabButtonTemplate()
		{
			if (APIUtils.gameObject_1 == null)
			{
				APIUtils.gameObject_1 = GameObject.Find("UserInterface").transform.Find("Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings").gameObject;
			}
			return APIUtils.gameObject_1;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
		public static GameObject GetSliderTemplate()
		{
			if (APIUtils.gameObject_3 == null)
			{
				APIUtils.gameObject_3 = GameObject.Find("UserInterface").transform.Find("MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider").gameObject;
			}
			return APIUtils.gameObject_3;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		public static GameObject GetSliderLabelTemplate()
		{
			if (APIUtils.gameObject_4 == null)
			{
				APIUtils.gameObject_4 = GameObject.Find("UserInterface").transform.Find("MenuContent/Screens/Settings/AudioDevicePanel/LevelText").gameObject;
			}
			return APIUtils.gameObject_4;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000DD40 File Offset: 0x0000BF40
		public static Sprite GetOnIconSprite()
		{
			if (APIUtils.sprite_0 == null)
			{
				APIUtils.sprite_0 = GameObject.Find("UserInterface").transform.Find("Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon").GetComponent<Image>().sprite;
			}
			return APIUtils.sprite_0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public static Sprite GetOffIconSprite()
		{
			if (APIUtils.sprite_1 == null)
			{
				APIUtils.sprite_1 = GameObject.Find("UserInterface").transform.Find("Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo/Icon_Off").GetComponent<Image>().sprite;
			}
			return APIUtils.sprite_1;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public static int RandomNumbers()
		{
			return APIUtils.random_0.Next(100000, 999999);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00003C27 File Offset: 0x00001E27
		public static void DestroyChildren(this Transform transform)
		{
			transform.DestroyChildren(null);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		public static void DestroyChildren(this Transform transform, Func<Transform, bool> exclude)
		{
			for (int i = transform.childCount - 1; i >= 0; i--)
			{
				if (exclude == null || exclude(transform.GetChild(i)))
				{
					Object.DestroyImmediate(transform.GetChild(i).gameObject);
				}
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003C30 File Offset: 0x00001E30
		// Note: this type is marked as 'beforefieldinit'.
		static APIUtils()
		{
			Class39.smethod_16();
			APIUtils.random_0 = new Random();
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003C41 File Offset: 0x00001E41
		internal static bool smethod_0()
		{
			return APIUtils.apiutils_0 == null;
		}

		// Token: 0x0400020B RID: 523
		private static readonly Random random_0;

		// Token: 0x0400020C RID: 524
		private static QuickMenu quickMenu_0;

		// Token: 0x0400020D RID: 525
		private static MenuStateController menuStateController_0;

		// Token: 0x0400020E RID: 526
		private static GameObject gameObject_0;

		// Token: 0x0400020F RID: 527
		private static GameObject gameObject_1;

		// Token: 0x04000210 RID: 528
		private static GameObject gameObject_2;

		// Token: 0x04000211 RID: 529
		private static GameObject gameObject_3;

		// Token: 0x04000212 RID: 530
		private static GameObject gameObject_4;

		// Token: 0x04000213 RID: 531
		private static Sprite sprite_0;

		// Token: 0x04000214 RID: 532
		private static Sprite sprite_1;

		// Token: 0x04000215 RID: 533
		private static APIUtils apiutils_0;
	}
}
