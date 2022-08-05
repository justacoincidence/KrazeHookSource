using System;
using ns0;
using TMPro;
using UnityEngine;
using VRC;

// Token: 0x02000052 RID: 82
internal class Class36 : MonoBehaviour
{
	// Token: 0x060002AE RID: 686 RVA: 0x00003544 File Offset: 0x00001744
	public Class36(IntPtr intptr_0)
	{
		Class39.smethod_16();
		this.int_0 = 0;
		base..ctor(intptr_0);
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000B264 File Offset: 0x00009464
	private void Start()
	{
		Transform transform = Object.Instantiate<Transform>(base.gameObject.transform.Find("Contents/Quick Stats"), base.gameObject.transform.Find("Contents"));
		transform.parent = base.gameObject.transform.Find("Contents");
		transform.gameObject.SetActive(true);
		this.textMeshProUGUI_0 = transform.Find("Trust Text").GetComponent<TextMeshProUGUI>();
		this.textMeshProUGUI_0.color = Color.white;
		transform.Find("Trust Icon").gameObject.SetActive(false);
		transform.Find("Performance Icon").gameObject.SetActive(false);
		transform.Find("Performance Text").gameObject.SetActive(false);
		transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
		this.imageThreeSlice_0 = base.gameObject.transform.Find("Contents/Main/Background").GetComponent<ImageThreeSlice>();
		this.imageThreeSlice_0._sprite = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Main/Glow").GetComponent<ImageThreeSlice>()._sprite;
		this.imageThreeSlice_0.color = Color.blue;
		this.byte_0 = this.player_0._playerNet.field_Private_Byte_0;
		this.byte_1 = this.player_0._playerNet.field_Private_Byte_1;
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000B3CC File Offset: 0x000095CC
	private void Update()
	{
		if (this.byte_0 == this.player_0._playerNet.field_Private_Byte_0 && this.byte_1 == this.player_0._playerNet.field_Private_Byte_1)
		{
			this.int_0++;
		}
		else
		{
			this.int_0 = 0;
		}
		this.byte_0 = this.player_0._playerNet.field_Private_Byte_0;
		this.byte_1 = this.player_0._playerNet.field_Private_Byte_1;
		string text = "<color=green>STABLE</color>";
		if (this.int_0 > 70)
		{
			text = "<color=yellow>STEADY</color>";
		}
		if (this.int_0 > 150)
		{
			text = "<color=#ffa600>LAGGING</color>";
		}
		if (this.int_0 > 230)
		{
			text = "<color=#ff0000>CRASHED</color>";
		}
		this.textMeshProUGUI_0.text = string.Concat(new string[]
		{
			"[",
			this.player_0.smethod_28(),
			"]",
			(!this.player_0.smethod_15()) ? "" : "  [<color=#a052ff>HOST</color>] ",
			" [",
			text,
			"]  [FPS: ",
			this.player_0.smethod_26(),
			"]  [Ping: ",
			this.player_0.smethod_27(),
			"]  ",
			(!this.player_0.smethod_22()) ? "" : " [<color=#ff0000>Client Monkey</color>]",
			string.Format(" [<color=#00a6ff>{0}</color>]", this.player_0.smethod_16())
		});
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00003559 File Offset: 0x00001759
	internal static bool smethod_0()
	{
		return Class36.class36_0 == null;
	}

	// Token: 0x04000170 RID: 368
	public Player player_0;

	// Token: 0x04000171 RID: 369
	private byte byte_0;

	// Token: 0x04000172 RID: 370
	private byte byte_1;

	// Token: 0x04000173 RID: 371
	private int int_0;

	// Token: 0x04000174 RID: 372
	private TextMeshProUGUI textMeshProUGUI_0;

	// Token: 0x04000175 RID: 373
	private ImageThreeSlice imageThreeSlice_0;

	// Token: 0x04000176 RID: 374
	internal static Class36 class36_0;
}
