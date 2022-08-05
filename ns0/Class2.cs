using System;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200001A RID: 26
	internal class Class2
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00004FF8 File Offset: 0x000031F8
		public static string smethod_0(int int_0)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!§$%&/()=?";
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < int_0; i++)
			{
				text2 += text[random.Next(text.Length - 1)].ToString();
			}
			return text2;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005050 File Offset: 0x00003250
		internal static string smethod_1()
		{
			string result;
			if (!Clipboard.ContainsText())
			{
				result = "";
			}
			else
			{
				result = Clipboard.GetText();
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000026AE File Offset: 0x000008AE
		internal static void smethod_2(string string_0)
		{
			if (Clipboard.ContainsText())
			{
				Clipboard.Clear();
				Clipboard.SetText(string_0);
			}
			Clipboard.SetText(string_0);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class2()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000026C8 File Offset: 0x000008C8
		internal static bool smethod_3()
		{
			return Class2.class2_0 == null;
		}

		// Token: 0x0400006C RID: 108
		private static Class2 class2_0;
	}
}
