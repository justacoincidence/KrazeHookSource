using System;
using UnityEngine;
using UnityEngine.UI;

namespace WTFBlaze
{
	// Token: 0x02000071 RID: 113
	public class QMSlider
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0000D85C File Offset: 0x0000BA5C
		public QMSlider(QMNestedButton location, float posX, float posY, string sliderLabel, float minValue, float maxValue, float defaultValue, Action<float> sliderAction, Color? labelColor = null)
		{
			Class39.smethod_16();
			base..ctor();
			this.method_0(location.GetMenuObject().transform, posX, posY, sliderLabel, minValue, maxValue, defaultValue, sliderAction, labelColor);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D894 File Offset: 0x0000BA94
		public QMSlider(QMTabMenu location, float posX, float posY, string sliderLabel, float minValue, float maxValue, float defaultValue, Action<float> sliderAction, Color? labelColor = null)
		{
			Class39.smethod_16();
			base..ctor();
			this.method_0(location.GetMenuObject().transform, posX, posY, sliderLabel, minValue, maxValue, defaultValue, sliderAction, labelColor);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000D8CC File Offset: 0x0000BACC
		public QMSlider(Transform location, float posX, float posY, string sliderLabel, float minValue, float maxValue, float defaultValue, Action<float> sliderAction, Color? labelColor = null)
		{
			Class39.smethod_16();
			base..ctor();
			this.method_0(location, posX, posY, sliderLabel, minValue, maxValue, defaultValue, sliderAction, labelColor);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000D8FC File Offset: 0x0000BAFC
		private void method_0(Transform transform_0, float float_0, float float_1, string string_0, float float_2, float float_3, float float_4, Action<float> action_0, Color? nullable_0 = null)
		{
			QMSlider.<>c__DisplayClass7_0 CS$<>8__locals1 = new QMSlider.<>c__DisplayClass7_0();
			CS$<>8__locals1.qmslider_0 = this;
			CS$<>8__locals1.float_0 = float_3;
			this.slider = Object.Instantiate<GameObject>(APIUtils.GetSliderTemplate(), transform_0);
			this.slider.transform.localScale = new Vector3(1f, 1f, 1f);
			this.slider.name = string.Format("{0}-QMSlider-{1}", "KrazeHookButtons", APIUtils.RandomNumbers());
			this.label = Object.Instantiate<GameObject>(GameObject.Find("UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/LevelText"), this.slider.transform);
			this.label.name = "QMSlider-Label";
			this.label.transform.localScale = new Vector3(1f, 1f, 1f);
			this.label.GetComponent<RectTransform>().sizeDelta = new Vector2(360f, 50f);
			this.label.GetComponent<RectTransform>().anchoredPosition = new Vector2(10.4f, 55f);
			this.sliderComp = this.slider.GetComponent<Slider>();
			this.sliderComp.wholeNumbers = true;
			this.sliderComp.onValueChanged = new Slider.SliderEvent();
			this.sliderComp.onValueChanged.AddListener(action_0);
			this.sliderComp.onValueChanged.AddListener(new Action<float>(CS$<>8__locals1.method_0));
			this.text = this.label.GetComponent<Text>();
			this.text.resizeTextForBestFit = false;
			if (nullable_0 != null)
			{
				this.SetLabelColor(nullable_0.Value);
			}
			this.SetLocation(new Vector2(float_0, float_1));
			this.SetLabelText(string_0);
			this.SetValue(float_2, CS$<>8__locals1.float_0, float_4);
			BlazesButtonAPI.allQMSliders.Add(this);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00003BBE File Offset: 0x00001DBE
		public void SetLocation(Vector2 location)
		{
			this.slider.GetComponent<RectTransform>().anchoredPosition = location;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003BD1 File Offset: 0x00001DD1
		public void SetLabelText(string label)
		{
			this.text.text = label;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00003BDF File Offset: 0x00001DDF
		public void SetLabelColor(Color color)
		{
			this.text.color = color;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003BED File Offset: 0x00001DED
		public void SetValue(float min, float max, float current)
		{
			this.sliderComp.minValue = min;
			this.sliderComp.maxValue = max;
			this.sliderComp.value = current;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
		public GameObject GetGameObject()
		{
			return this.slider;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003C13 File Offset: 0x00001E13
		internal static bool smethod_0()
		{
			return QMSlider.qmslider_0 == null;
		}

		// Token: 0x04000203 RID: 515
		protected GameObject slider;

		// Token: 0x04000204 RID: 516
		protected GameObject label;

		// Token: 0x04000205 RID: 517
		protected Slider sliderComp;

		// Token: 0x04000206 RID: 518
		protected Text text;

		// Token: 0x04000207 RID: 519
		internal static QMSlider qmslider_0;
	}
}
