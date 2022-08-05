using System;
using UnityEngine;
using UnityEngine.XR;
using VRC.Animation;

namespace ns3
{
	// Token: 0x0200002C RID: 44
	internal class Class12
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00007B54 File Offset: 0x00005D54
		public static void smethod_0()
		{
			VRCPlayer field_Internal_Static_VRCPlayer_ = VRCPlayer.field_Internal_Static_VRCPlayer_0;
			if (!(field_Internal_Static_VRCPlayer_ == null))
			{
				if (Class12.vrcmotionState_0 == null)
				{
					Class12.vrcmotionState_0 = field_Internal_Static_VRCPlayer_.GetComponent<VRCMotionState>();
				}
				if (Class12.bool_0)
				{
					Transform transform = field_Internal_Static_VRCPlayer_.transform;
					if (!XRDevice.isPresent)
					{
						float num = Input.GetKey(304) ? (Class13.float_1 * 2f) : Class13.float_1;
						Transform transform2 = Camera.main.transform;
						transform.position += transform2.forward * Time.deltaTime * Input.GetAxis("Vertical") * num;
						transform.position += transform2.right * Time.deltaTime * Input.GetAxis("Horizontal") * num;
						if (!Input.GetKey(306) && Input.GetKey(113))
						{
							transform.position -= new Vector3(0f, Time.deltaTime * num, 0f);
						}
						if (!Input.GetKey(306) && Input.GetKey(101))
						{
							transform.position += new Vector3(0f, Time.deltaTime * num, 0f);
						}
					}
					else
					{
						transform.position += transform.forward * Time.deltaTime * Input.GetAxis("Vertical") * Class13.float_1;
						transform.position += transform.right * Time.deltaTime * Input.GetAxis("Horizontal") * Class13.float_1;
						transform.position += new Vector3(0f, Time.deltaTime * Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") * Class13.float_1);
					}
					VRCMotionState vrcmotionState = Class12.vrcmotionState_0;
					if (vrcmotionState != null)
					{
						vrcmotionState.Reset();
					}
				}
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000022C0 File Offset: 0x000004C0
		public Class12()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002C30 File Offset: 0x00000E30
		internal static bool smethod_1()
		{
			return Class12.class12_0 == null;
		}

		// Token: 0x040000FA RID: 250
		public static bool bool_0;

		// Token: 0x040000FB RID: 251
		internal static VRCMotionState vrcmotionState_0;

		// Token: 0x040000FC RID: 252
		private static Class12 class12_0;
	}
}
