using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace ns6
{
	// Token: 0x02000051 RID: 81
	internal class Class35
	{
		// Token: 0x060002AA RID: 682 RVA: 0x0000B138 File Offset: 0x00009338
		internal static Image smethod_0(string string_0)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
				if (text.EndsWith(".png") && text.Contains(string_0))
				{
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
					MemoryStream memoryStream = new MemoryStream();
					manifestResourceStream.CopyTo(memoryStream);
					return Image.FromStream(memoryStream);
				}
			}
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000B1B4 File Offset: 0x000093B4
		internal static Sprite smethod_1(Image image_0)
		{
			Sprite result;
			if (image_0 == null)
			{
				result = null;
			}
			else
			{
				MemoryStream memoryStream = new MemoryStream();
				image_0.Save(memoryStream, ImageFormat.Png);
				Texture2D texture2D = new Texture2D(1024, 1024);
				Sprite sprite2;
				if (ImageConversion.LoadImage(texture2D, memoryStream.ToArray()))
				{
					Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2((float)(texture2D.width / 2), (float)(texture2D.height / 2)), 100000f, 1000U, 0, default(Vector4), false);
					sprite2 = sprite;
				}
				else
				{
					sprite2 = null;
				}
				result = sprite2;
			}
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class35()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000353A File Offset: 0x0000173A
		internal static bool smethod_2()
		{
			return Class35.class35_0 == null;
		}

		// Token: 0x0400016F RID: 367
		private static Class35 class35_0;
	}
}
