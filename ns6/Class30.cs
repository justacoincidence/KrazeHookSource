using System;
using UnityEngine;
using UnityEngine.UI;

namespace ns6
{
	// Token: 0x02000049 RID: 73
	internal static class Class30
	{
		// Token: 0x06000286 RID: 646 RVA: 0x0000A0F8 File Offset: 0x000082F8
		public static void smethod_0()
		{
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent").transform.localPosition = new Vector3(-98.0401f, 115.42f, 0f);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel").gameObject.SetActive(false);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").gameObject.SetActive(false);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/RingGlow").GetComponent<Image>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/Rectangle").gameObject.SetActive(false);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/InnerDashRing").GetComponent<Image>().color = new Color(0f, 0f, 200f, 0.8f);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/MidRing").GetComponent<Image>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ProgressLine").GetComponent<Image>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Outline>().enabled = false;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ArrowRight").gameObject.SetActive(false);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ArrowLeft").gameObject.SetActive(false);
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/BodyText").GetComponent<Text>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/HighPercent").GetComponent<Text>().color = Color.blue;
			GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/LowPercent").GetComponent<Text>().color = Color.blue;
			Button component = GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ButtonMiddle").GetComponent<Button>();
			ColorBlock colors = component.colors;
			colors.normalColor = new Color(0f, 0f, 200f, 0.6f);
			colors.highlightedColor = new Color(0f, 0f, 200f, 0.9f);
			colors.pressedColor = new Color(0f, 0f, 100f, 1f);
			colors.disabledColor = new Color(0f, 0f, 0f, 0.3f);
			colors.selectedColor = new Color(0f, 0f, 200f, 0.8f);
			component.colors = colors;
			GameObject.Find("/UserInterface").transform.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003449 File Offset: 0x00001649
		internal static bool smethod_1()
		{
			return Class30.class30_0 == null;
		}

		// Token: 0x04000156 RID: 342
		internal static Class30 class30_0;
	}
}
