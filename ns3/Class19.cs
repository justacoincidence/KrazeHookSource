using System;
using System.Collections;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using ns0;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ns3
{
	// Token: 0x02000035 RID: 53
	internal class Class19
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00002ECC File Offset: 0x000010CC
		public static void smethod_0()
		{
			MelonCoroutines.Start(Class19.smethod_2());
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000081D8 File Offset: 0x000063D8
		public static void smethod_1()
		{
			for (int i = 0; i < Class19.udonBehaviour_0.Length; i++)
			{
				foreach (KeyValuePair<string, List<uint>> keyValuePair in Class19.udonBehaviour_0[i]._eventTable)
				{
					Class19.udonBehaviour_0[i].SendCustomNetworkEvent(0, keyValuePair.key);
				}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002ED9 File Offset: 0x000010D9
		private static IEnumerator smethod_2()
		{
			int num;
			for (int i = 0; i < Class1.smethod_0().Length; i = num + 1)
			{
				if (!(Class1.smethod_0()[i].smethod_5().id == Class1.smethod_3().smethod_5().id))
				{
					int j = 0;
					if (j < Class3.udonBehaviour_0.Length)
					{
						foreach (string name in Class3.udonBehaviour_0[j]._eventTable.Keys)
						{
							Networking.SetOwner(Class1.smethod_0()[i].smethod_14(), Class3.udonBehaviour_0[j].gameObject);
							Class3.udonBehaviour_0[j].SendCustomNetworkEvent(1, name);
							yield return new WaitForSeconds(0.25f);
							name = null;
						}
						Dictionary<string, List<uint>>.KeyCollection.Enumerator enumerator = null;
						yield return new WaitForSeconds(0.25f);
					}
					yield return new WaitForSeconds(0.25f);
					break;
				}
				num = i;
			}
			yield return new WaitForSeconds(0.25f);
			yield break;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class19()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002EE1 File Offset: 0x000010E1
		// Note: this type is marked as 'beforefieldinit'.
		static Class19()
		{
			Class39.smethod_16();
			Class19.udonBehaviour_0 = Object.FindObjectsOfType<UdonBehaviour>();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002EF7 File Offset: 0x000010F7
		internal static bool smethod_3()
		{
			return Class19.class19_0 == null;
		}

		// Token: 0x0400010F RID: 271
		private static UdonBehaviour[] udonBehaviour_0;

		// Token: 0x04000110 RID: 272
		private static Class19 class19_0;
	}
}
