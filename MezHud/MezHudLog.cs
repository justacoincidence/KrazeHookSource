using System;
using System.Collections;
using MelonLoader;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MezHud
{
	// Token: 0x02000067 RID: 103
	public class MezHudLog
	{
		// Token: 0x06000310 RID: 784 RVA: 0x000037EF File Offset: 0x000019EF
		public static IEnumerator MakeUI()
		{
			while (RoomManager.field_Internal_Static_ApiWorld_0 == null)
			{
				yield return new WaitForSeconds(1f);
			}
			GameObject GUI;
			(GUI = GameObject.Find("/UserInterface").transform.Find("UnscaledUI/HudContent_Old/Hud/AlertTextParent/Capsule").gameObject).SetActive(true);
			GameObject text = GUI.transform.Find("Text").gameObject;
			yield return new WaitForEndOfFrame();
			GUI.transform.localPosition = MezHudLog.vector3_0;
			Object.DestroyImmediate(GUI.transform.GetComponent<HorizontalLayoutGroup>());
			Object.DestroyImmediate(GUI.transform.GetComponent<ContentSizeFitter>());
			Object.DestroyImmediate(GUI.transform.GetComponent<ContentSizeFitter>());
			Object.DestroyImmediate(GUI.transform.GetComponent<ImageThreeSlice>());
			GUI.gameObject.AddComponent<ContentSizeFitter>().horizontalFit = 2;
			GUI.gameObject.AddComponent<VerticalLayoutGroup>().spacing = MezHudLog.float_0;
			TextMeshProUGUI textMesh = text.GetComponent<TextMeshProUGUI>();
			textMesh.color = MezHudLog.color_0;
			textMesh.alignment = 513;
			textMesh.text = string.Format("<color={0}>[{1}][{2}]:</color> ", MezHudLog.string_1, DateTime.Now, MezHudLog.string_0);
			yield return new WaitForEndOfFrame();
			text.SetActive(false);
			yield break;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000037F7 File Offset: 0x000019F7
		public static void Msg(string Text, float Timer)
		{
			MelonCoroutines.Start(MezHudLog.smethod_0(Text, 1, Timer));
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003807 File Offset: 0x00001A07
		public static void Error(string Text, float Timer)
		{
			MelonCoroutines.Start(MezHudLog.smethod_0(Text, 2, Timer));
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00003817 File Offset: 0x00001A17
		public static void Warn(string Text, float Timer)
		{
			MelonCoroutines.Start(MezHudLog.smethod_0(Text, 3, Timer));
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00003827 File Offset: 0x00001A27
		private static IEnumerator smethod_0(string string_2, int int_0, float float_1)
		{
			MezHudLog.<MezText>d__9 <MezText>d__ = new MezHudLog.<MezText>d__9(0);
			<MezText>d__.Text = string_2;
			<MezText>d__.TextType = int_0;
			<MezText>d__.timeBeforeDeletion = float_1;
			return <MezText>d__;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000022C0 File Offset: 0x000004C0
		public MezHudLog()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		// Note: this type is marked as 'beforefieldinit'.
		static MezHudLog()
		{
			Class39.smethod_16();
			MezHudLog.string_0 = "KrazeHook";
			MezHudLog.string_1 = "#005eff";
			MezHudLog.color_0 = new Color(1f, 1f, 1f, 1f);
			MezHudLog.vector3_0 = new Vector3(55f, -300f, 0f);
			MezHudLog.float_0 = 30f;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00003844 File Offset: 0x00001A44
		internal static bool smethod_1()
		{
			return MezHudLog.mezHudLog_0 == null;
		}

		// Token: 0x040001BE RID: 446
		private static string string_0;

		// Token: 0x040001BF RID: 447
		private static string string_1;

		// Token: 0x040001C0 RID: 448
		private static Color color_0;

		// Token: 0x040001C1 RID: 449
		private static Vector3 vector3_0;

		// Token: 0x040001C2 RID: 450
		private static float float_0;

		// Token: 0x040001C3 RID: 451
		private static MezHudLog mezHudLog_0;
	}
}
