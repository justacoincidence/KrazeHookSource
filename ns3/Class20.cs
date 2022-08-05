using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;

namespace ns3
{
	// Token: 0x02000037 RID: 55
	internal class Class20
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00002F27 File Offset: 0x00001127
		public static void smethod_0()
		{
			Process.Start(Class20.string_0);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000083EC File Offset: 0x000065EC
		public static void smethod_1()
		{
			List<string> list = PlayerManager.Method_Public_Static_get_PlayerManager_0().Method_Public_get_ArrayOf_Player_0().Where(new Func<Player, bool>(Class20.<>c.<>c_0.method_0)).Select(new Func<Player, ApiAvatar>(Class20.<>c.<>c_0.method_1)).Where(new Func<ApiAvatar, bool>(Class20.<>c.<>c_0.method_2)).Select(new Func<ApiAvatar, string>(Class20.<>c.<>c_0.method_3)).ToList<string>();
			Dictionary<string, AssetBundleDownload> dictionary = new Dictionary<string, AssetBundleDownload>();
			AssetBundleDownloadManager assetBundleDownloadManager = AssetBundleDownloadManager.Method_Internal_Static_get_AssetBundleDownloadManager_PDM_0();
			foreach (string text in assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0.Keys)
			{
				dictionary.Add(text, assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0[text]);
			}
			foreach (string text2 in dictionary.Keys)
			{
				AssetBundleDownload assetBundleDownload = assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0[text2];
				if (!assetBundleDownload.field_Private_String_0.Contains("wrld_") && !list.Contains(text2))
				{
					assetBundleDownloadManager.field_Private_Dictionary_2_String_AssetBundleDownload_0.Remove(text2);
					if (assetBundleDownload.field_Private_GameObject_0 != null)
					{
						Object.DestroyImmediate(assetBundleDownload.field_Private_GameObject_0, true);
					}
				}
			}
			dictionary.Clear();
			Resources.UnloadUnusedAssets();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class20()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002F34 File Offset: 0x00001134
		// Note: this type is marked as 'beforefieldinit'.
		static Class20()
		{
			Class39.smethod_16();
			Class20.string_0 = "https://discord.gg/RmmMuDH64s";
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002F45 File Offset: 0x00001145
		internal static bool smethod_2()
		{
			return Class20.class20_0 == null;
		}

		// Token: 0x04000118 RID: 280
		public static string string_0;

		// Token: 0x04000119 RID: 281
		private static Class20 class20_0;
	}
}
