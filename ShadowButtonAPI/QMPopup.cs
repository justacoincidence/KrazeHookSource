using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace ShadowButtonAPI
{
	// Token: 0x02000056 RID: 86
	public static class QMPopup
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00002312 File Offset: 0x00000512
		public static void HideCurrentPopup(this VRCUiPopupManager vrcUiPopupManager)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000035FA File Offset: 0x000017FA
		public static void ShowStandardPopup(this VRCUiPopupManager vrcUiPopupManager, string title, string content, Action<VRCUiPopup> onCreated = null)
		{
			QMPopup.ShowUiStandardPopup1(title, content, onCreated);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000360E File Offset: 0x0000180E
		public static void ShowStandardPopup(this VRCUiPopupManager vrcUiPopupManager, string title, string content, string buttonText, Action buttonAction, Action<VRCUiPopup> onCreated = null)
		{
			QMPopup.ShowUiStandardPopup2(title, content, buttonText, buttonAction, onCreated);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000362B File Offset: 0x0000182B
		public static void ShowStandardPopup(this VRCUiPopupManager vrcUiPopupManager, string title, string content, string string_0, Action button1Action, string string_1, Action button2Action, Action<VRCUiPopup> onCreated = null)
		{
			QMPopup.ShowUiStandardPopup3(title, content, string_0, button1Action, string_1, button2Action, onCreated);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00003651 File Offset: 0x00001851
		public static void ShowStandardPopupV2(this VRCUiPopupManager vrcUiPopupManager, string title, string content, string buttonText, Action buttonAction, Action<VRCUiPopup> onCreated = null)
		{
			QMPopup.ShowUiStandardPopupV21(title, content, buttonText, buttonAction, onCreated);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000366E File Offset: 0x0000186E
		public static void ShowStandardPopupV2(this VRCUiPopupManager vrcUiPopupManager, string title, string content, string string_0, Action button1Action, string string_1, Action button2Action, Action<VRCUiPopup> onCreated = null)
		{
			QMPopup.ShowUiStandardPopupV22(title, content, string_0, button1Action, string_1, button2Action, onCreated);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000B908 File Offset: 0x00009B08
		public static void ShowInputPopup(this VRCUiPopupManager vrcUiPopupManager, string title, string preFilledText, InputField.InputType inputType, bool keypad, string buttonText, Action<string, List<KeyCode>, Text> buttonAction, Action cancelAction, string boxText = "Enter text....", bool closeOnAccept = true, Action<VRCUiPopup> onCreated = null, bool startOnLeft = false, int characterLimit = 0)
		{
			QMPopup.ShowUiInputPopup(title, preFilledText, inputType, keypad, buttonText, buttonAction, cancelAction, boxText, closeOnAccept, onCreated, startOnLeft, characterLimit);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003694 File Offset: 0x00001894
		public static void ShowAlert(this VRCUiPopupManager vrcUiPopupManager, string title, string content, float timeout)
		{
			QMPopup.ShowUiAlertPopup(title, content, timeout);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000B93C File Offset: 0x00009B3C
		public static QMPopup.ShowUiInputPopupAction ShowUiInputPopup
		{
			get
			{
				QMPopup.ShowUiInputPopupAction result;
				if (QMPopup.showUiInputPopupAction_0 != null)
				{
					result = QMPopup.showUiInputPopupAction_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_0));
					QMPopup.showUiInputPopupAction_0 = (QMPopup.ShowUiInputPopupAction)Delegate.CreateDelegate(typeof(QMPopup.ShowUiInputPopupAction), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiInputPopupAction_0;
				}
				return result;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		public static QMPopup.ShowUiStandardPopup1Action ShowUiStandardPopup1
		{
			get
			{
				QMPopup.ShowUiStandardPopup1Action result;
				if (QMPopup.showUiStandardPopup1Action_0 != null)
				{
					result = QMPopup.showUiStandardPopup1Action_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_2));
					QMPopup.showUiStandardPopup1Action_0 = (QMPopup.ShowUiStandardPopup1Action)Delegate.CreateDelegate(typeof(QMPopup.ShowUiStandardPopup1Action), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiStandardPopup1Action_0;
				}
				return result;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000BA34 File Offset: 0x00009C34
		public static QMPopup.ShowUiStandardPopup2Action ShowUiStandardPopup2
		{
			get
			{
				QMPopup.ShowUiStandardPopup2Action result;
				if (QMPopup.showUiStandardPopup2Action_0 != null)
				{
					result = QMPopup.showUiStandardPopup2Action_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_4));
					QMPopup.showUiStandardPopup2Action_0 = (QMPopup.ShowUiStandardPopup2Action)Delegate.CreateDelegate(typeof(QMPopup.ShowUiStandardPopup2Action), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiStandardPopup2Action_0;
				}
				return result;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		public static QMPopup.ShowUiStandardPopup3Action ShowUiStandardPopup3
		{
			get
			{
				QMPopup.ShowUiStandardPopup3Action result;
				if (QMPopup.showUiStandardPopup3Action_0 != null)
				{
					result = QMPopup.showUiStandardPopup3Action_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_6));
					QMPopup.showUiStandardPopup3Action_0 = (QMPopup.ShowUiStandardPopup3Action)Delegate.CreateDelegate(typeof(QMPopup.ShowUiStandardPopup3Action), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiStandardPopup3Action_0;
				}
				return result;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0000BB2C File Offset: 0x00009D2C
		public static QMPopup.ShowUiStandardPopupV21Action ShowUiStandardPopupV21
		{
			get
			{
				QMPopup.ShowUiStandardPopupV21Action result;
				if (QMPopup.showUiStandardPopupV21Action_0 != null)
				{
					result = QMPopup.showUiStandardPopupV21Action_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_8));
					QMPopup.showUiStandardPopupV21Action_0 = (QMPopup.ShowUiStandardPopupV21Action)Delegate.CreateDelegate(typeof(QMPopup.ShowUiStandardPopupV21Action), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiStandardPopupV21Action_0;
				}
				return result;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		public static QMPopup.ShowUiStandardPopupV22Action ShowUiStandardPopupV22
		{
			get
			{
				QMPopup.ShowUiStandardPopupV22Action result;
				if (QMPopup.showUiStandardPopupV22Action_0 != null)
				{
					result = QMPopup.showUiStandardPopupV22Action_0;
				}
				else
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_10));
					QMPopup.showUiStandardPopupV22Action_0 = (QMPopup.ShowUiStandardPopupV22Action)Delegate.CreateDelegate(typeof(QMPopup.ShowUiStandardPopupV22Action), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiStandardPopupV22Action_0;
				}
				return result;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000BC24 File Offset: 0x00009E24
		public static QMPopup.ShowUiAlertPopupAction ShowUiAlertPopup
		{
			get
			{
				QMPopup.ShowUiAlertPopupAction result;
				if (QMPopup.showUiAlertPopupAction_0 == null)
				{
					MethodInfo method = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(new Func<MethodInfo, bool>(QMPopup.<>c.<>c_0.method_12));
					QMPopup.showUiAlertPopupAction_0 = (QMPopup.ShowUiAlertPopupAction)Delegate.CreateDelegate(typeof(QMPopup.ShowUiAlertPopupAction), VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0(), method);
					result = QMPopup.showUiAlertPopupAction_0;
				}
				else
				{
					result = QMPopup.showUiAlertPopupAction_0;
				}
				return result;
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000036A3 File Offset: 0x000018A3
		// Note: this type is marked as 'beforefieldinit'.
		static QMPopup()
		{
			Class39.smethod_16();
			QMPopup.qmStuff = new QuickMenuStuff();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000036B4 File Offset: 0x000018B4
		internal static bool smethod_0()
		{
			return QMPopup.qmpopup_0 == null;
		}

		// Token: 0x04000183 RID: 387
		public static QuickMenuStuff qmStuff;

		// Token: 0x04000184 RID: 388
		private static QMPopup.ShowUiInputPopupAction showUiInputPopupAction_0;

		// Token: 0x04000185 RID: 389
		private static QMPopup.ShowUiStandardPopup1Action showUiStandardPopup1Action_0;

		// Token: 0x04000186 RID: 390
		private static QMPopup.ShowUiStandardPopup2Action showUiStandardPopup2Action_0;

		// Token: 0x04000187 RID: 391
		private static QMPopup.ShowUiStandardPopup3Action showUiStandardPopup3Action_0;

		// Token: 0x04000188 RID: 392
		private static QMPopup.ShowUiStandardPopupV21Action showUiStandardPopupV21Action_0;

		// Token: 0x04000189 RID: 393
		private static QMPopup.ShowUiStandardPopupV22Action showUiStandardPopupV22Action_0;

		// Token: 0x0400018A RID: 394
		private static QMPopup.ShowUiAlertPopupAction showUiAlertPopupAction_0;

		// Token: 0x0400018B RID: 395
		private static QMPopup qmpopup_0;

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060002D1 RID: 721
		public delegate void ShowUiInputPopupAction(string title, string initialText, InputField.InputType inputType, bool isNumeric, string confirmButtonText, Action<string, List<KeyCode>, Text> onComplete, Action onCancel, string placeholderText = "Enter text...", bool closeAfterInput = true, Action<VRCUiPopup> onPopupShown = null, bool startOnLeft = false, int characterLimit = 0);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060002D5 RID: 725
		public delegate void ShowUiStandardPopup1Action(string title, string body, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060002D9 RID: 729
		public delegate void ShowUiStandardPopup2Action(string title, string body, string middleButtonText, Action middleButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060002DD RID: 733
		public delegate void ShowUiStandardPopup3Action(string title, string body, string leftButtonText, Action leftButtonAction, string rightButtonText, Action rightButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060002E1 RID: 737
		public delegate void ShowUiStandardPopupV21Action(string title, string body, string middleButtonText, Action middleButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060002E5 RID: 741
		public delegate void ShowUiStandardPopupV22Action(string title, string body, string leftButtonText, Action leftButtonAction, string rightButtonText, Action rightButtonAction, Action<VRCUiPopup> onPopupShown = null);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x060002E9 RID: 745
		public delegate void ShowUiAlertPopupAction(string title, string body, float timeout);
	}
}
