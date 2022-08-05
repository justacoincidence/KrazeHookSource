using System;
using IKMod.Config;
using RootMotion.FinalIK;
using UnityEngine;

namespace IKMod.IKHandler
{
	// Token: 0x0200000D RID: 13
	public class IKComponent : MonoBehaviour
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000022D7 File Offset: 0x000004D7
		public IKComponent(IntPtr ptr)
		{
			Class39.smethod_16();
			base..ctor(ptr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003F18 File Offset: 0x00002118
		private void Update()
		{
			if (!(VRCPlayer.field_Internal_Static_VRCPlayer_0 == null))
			{
				if (this.vrik_0 == null)
				{
					this.vrik_0 = base.gameObject.GetComponentInChildren<VRIK>();
				}
				if (RuntimeConfig.tPose)
				{
					this.vrik_0.animator.enabled = false;
				}
				if (RuntimeConfig.twist)
				{
					this.vrik_0.fixTransforms = false;
					this.vrik_0.animator.enabled = false;
				}
				if (RuntimeConfig.noNeck)
				{
					this.vrik_0.solver.hasNeck = false;
				}
				if (RuntimeConfig.noChest)
				{
					this.vrik_0.solver.hasChest = false;
				}
				if (RuntimeConfig.leftArm)
				{
					this.vrik_0.solver.leftArm.positionWeight = 1f;
				}
				if (RuntimeConfig.rightArm)
				{
					this.vrik_0.solver.rightArm.positionWeight = 1f;
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022E5 File Offset: 0x000004E5
		internal static bool smethod_0()
		{
			return IKComponent.ikcomponent_0 == null;
		}

		// Token: 0x0400001D RID: 29
		private VRIK vrik_0;

		// Token: 0x0400001E RID: 30
		internal static IKComponent ikcomponent_0;
	}
}
