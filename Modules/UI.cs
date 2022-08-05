using System;
using ns6;
using WTFBlaze;

namespace KrazeHook.Modules
{
	// Token: 0x02000024 RID: 36
	public class UI : KModule
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00005C64 File Offset: 0x00003E64
		public override void QuickMenuInit()
		{
			QMTabMenu qmtabMenu = new QMTabMenu(UI.KrazeText + " By Kraze", UI.KrazeText + " " + UI.VersionTxt, Class35.smethod_1(Class35.smethod_0("Klogowhite")));
			QMNestedButton qmnestedButton = new QMNestedButton(qmtabMenu, 1f, 0f, "Worlds", "Opens the menu for World options", "Worlds", false);
			QMNestedButton qmnestedButton2 = new QMNestedButton(qmnestedButton, 1f, 0f, "Among Us", "", "Among Us", false);
			new QMSingleButton(qmnestedButton2, 1f, 0f, "Start game", new Action(UI.<>c.<>c_0.method_0), "", false);
			new QMSingleButton(qmnestedButton2, 2f, 0f, "End Game", new Action(UI.<>c.<>c_0.method_1), "", false);
			new QMSingleButton(qmnestedButton2, 3f, 0f, "Log Impostor", new Action(UI.<>c.<>c_0.method_2), "", false);
			new QMSingleButton(qmnestedButton2, 4f, 0f, "Skip Voting", new Action(UI.<>c.<>c_0.method_3), "", false);
			new QMSingleButton(qmnestedButton2, 1f, 1f, "Kill All", new Action(UI.<>c.<>c_0.method_4), "", false);
			new QMSingleButton(qmnestedButton2, 2f, 1f, "Impostor Win", new Action(UI.<>c.<>c_0.method_5), "", false);
			new QMSingleButton(qmnestedButton2, 3f, 1f, "Crewmate Win", new Action(UI.<>c.<>c_0.method_6), "", false);
			new QMSingleButton(qmnestedButton2, 4f, 1f, "Eject All", new Action(UI.<>c.<>c_0.method_7), "", false);
			QMNestedButton btnMenu = new QMNestedButton(qmnestedButton2, 1f, 2f, "Map Options", "Opens the menu for exploiting on the Among Us Map", "Map Options", false);
			new QMSingleButton(btnMenu, 1f, 0f, "Hit Electrical", new Action(UI.<>c.<>c_0.method_8), "", false);
			new QMSingleButton(btnMenu, 2f, 0f, "Finish Tasks", new Action(UI.<>c.<>c_0.method_9), "", false);
			new QMSingleButton(btnMenu, 3f, 0f, "Hit Oxcygen", new Action(UI.<>c.<>c_0.method_10), "", false);
			new QMSingleButton(btnMenu, 4f, 0f, "Hit Reactor", new Action(UI.<>c.<>c_0.method_11), "", false);
			new QMSingleButton(btnMenu, 1f, 1f, "Hit Coms", new Action(UI.<>c.<>c_0.method_12), "", false);
			new QMSingleButton(btnMenu, 2f, 1f, "Shut Doors", new Action(UI.<>c.<>c_0.method_13), "", false);
			new QMSingleButton(btnMenu, 3f, 1f, "Sabotage All", new Action(UI.<>c.<>c_0.method_14), "", false);
			new QMSingleButton(btnMenu, 4f, 1f, "Repair All", new Action(UI.<>c.<>c_0.method_15), "", false);
			QMNestedButton btnMenu2 = new QMNestedButton(qmnestedButton, 2f, 0f, "Murder 4", "", "Murder 4", false);
			new QMSingleButton(btnMenu2, 1f, 0f, "Start game", new Action(UI.<>c.<>c_0.method_16), "", false);
			new QMSingleButton(btnMenu2, 2f, 0f, "End Game", new Action(UI.<>c.<>c_0.method_17), "", false);
			new QMSingleButton(btnMenu2, 3f, 0f, "Bystander Win", new Action(UI.<>c.<>c_0.method_18), "", false);
			new QMSingleButton(btnMenu2, 4f, 0f, "Murder Win", new Action(UI.<>c.<>c_0.method_19), "", false);
			new QMSingleButton(btnMenu2, 1f, 1f, "Kill All", new Action(UI.<>c.<>c_0.method_20), "", false);
			new QMSingleButton(btnMenu2, 2f, 1f, "TP Frag", new Action(UI.<>c.<>c_0.method_21), "", false);
			new QMSingleButton(btnMenu2, 3f, 1f, "TP Revolver", new Action(UI.<>c.<>c_0.method_22), "", false);
			new QMSingleButton(btnMenu2, 4f, 1f, "Give Knife", new Action(UI.<>c.<>c_0.method_23), "", false);
			new QMSingleButton(btnMenu2, 1f, 2f, "Give Luger", new Action(UI.<>c.<>c_0.method_24), "", false);
			new QMSingleButton(btnMenu2, 2f, 2f, "Give Shotty", new Action(UI.<>c.<>c_0.method_25), "", false);
			new QMSingleButton(btnMenu2, 3f, 2f, "Give Bear Trap", new Action(UI.<>c.<>c_0.method_26), "", false);
			new QMSingleButton(btnMenu2, 4f, 2f, "Blind All", new Action(UI.<>c.<>c_0.method_27), "", false);
			new QMSingleButton(btnMenu2, 1f, 3f, "Find Clues", new Action(UI.<>c.<>c_0.method_28), "", false);
			new QMSingleButton(btnMenu2, 2f, 3f, "Give Murder All", new Action(UI.<>c.<>c_0.method_29), "", false);
			new QMSingleButton(btnMenu2, 3f, 3f, "Minigame", new Action(UI.<>c.<>c_0.method_30), "", false);
			new QMSingleButton(btnMenu2, 4f, 3f, "Lights Out", new Action(UI.<>c.<>c_0.method_31), "", false);
			new QMSingleButton(qmnestedButton, 3f, 0f, "Hit Everything", new Action(UI.<>c.<>c_0.method_32), "Sends all Udon events for Murder 4 or Among Us", false);
			QMNestedButton qmnestedButton3 = new QMNestedButton(qmtabMenu, 2f, 0f, "Self", "Opens the menu for Self options", "Self", false);
			new QMToggleButton(qmnestedButton3, 1f, 0f, "Hide Self", new Action(UI.<>c.<>c_0.method_33), new Action(UI.<>c.<>c_0.method_34), "", false);
			new QMToggleButton(qmnestedButton3, 2f, 0f, "Head Flipper", new Action(UI.<>c.<>c_0.method_35), new Action(UI.<>c.<>c_0.method_36), "", false);
			new QMSingleButton(qmnestedButton3, 3f, 0f, "Download VRCA", new Action(UI.<>c.<>c_0.method_37), "Downloads your current avatar's VRCA file", false);
			QMNestedButton qmnestedButton4 = new QMNestedButton(qmnestedButton3, 1f, 1f, "Player IK", "Mess with your player's IK", "Player IK", false);
			new QMSingleButton(qmnestedButton4, 1f, 0f, "T-Pose\nToggle", new Action(UI.<>c.<>c_0.method_38), "You already know ;)", false);
			new QMToggleButton(qmnestedButton4, 3f, 0f, "Lift Right Hand", new Action(UI.<>c.<>c_0.method_39), new Action(UI.<>c.<>c_0.method_40), "Makes you hold up your right hand", false);
			new QMToggleButton(qmnestedButton4, 2f, 0f, "Lift Left Hand", new Action(UI.<>c.<>c_0.method_41), new Action(UI.<>c.<>c_0.method_42), "Makes you hold up your left hand", false);
			new QMToggleButton(qmnestedButton4, 4f, 0f, "Break Neck", new Action(UI.<>c.<>c_0.method_43), new Action(UI.<>c.<>c_0.method_44), "Break that shit", false);
			new QMToggleButton(qmnestedButton3, 4f, 0f, "Loud Mic", new Action(UI.<>c.<>c_0.method_45), new Action(UI.<>c.<>c_0.method_46), "Makes you loud asf for no reason", false);
			QMNestedButton qmnestedButton5 = new QMNestedButton(qmtabMenu, 3f, 0f, "Instance", "Opens the menu for Instance options", "Instance", false);
			new QMToggleButton(qmnestedButton5, 1f, 0f, "Crash PC", new Action(UI.<>c.<>c_0.method_47), new Action(UI.<>c.<>c_0.method_48), "Kills the lobby with a PC Crash avatar", false);
			new QMToggleButton(qmnestedButton5, 2f, 0f, "Crash Quest", new Action(UI.<>c.<>c_0.method_49), new Action(UI.<>c.<>c_0.method_50), "Kills quest users with an avatar", false);
			new QMSingleButton(qmnestedButton5, 3f, 0f, "Copy World ID", new Action(UI.<>c.<>c_0.method_51), "Copy the current world's ID", false);
			new QMSingleButton(qmnestedButton5, 4f, 0f, "Join World ID", new Action(UI.<>c.<>c_0.method_52), "Join a world via the ID copied to your clipboard", false);
			new QMSingleButton(qmnestedButton5, 1f, 1f, "Rejoin World", new Action(UI.<>c.<>c_0.method_53), "This is pointless since there is already have a rejoin button built into VRChat", false);
			new QMSingleButton(qmnestedButton5, 2f, 1f, "Download VRCW", new Action(UI.<>c.<>c_0.method_54), "Rip a world and save it to your VRCW folder in KrazeHook", false);
			new QMSingleButton(qmnestedButton5, 3f, 1f, "Inf Portals", new Action(UI.<>c.<>c_0.method_55), "No more portal timers", false);
			new QMSingleButton(qmnestedButton5, 4f, 1f, "Kill Portals", new Action(UI.<>c.<>c_0.method_56), "Deletes all portals GLOBALLY", false);
			new QMSingleButton(qmnestedButton5, 1f, 2f, "Udon Kill", new Action(UI.<>c.<>c_0.method_57), "This will kill all udon for everyone", false);
			QMNestedButton location = new QMNestedButton(qmtabMenu, 4f, 0f, "Security " + UI.WIPTxt, "Opens the menu for Security options", "Security " + UI.WIPTxt, false);
			new QMToggleButton(location, 1f, 0f, "Avatar Checks", new Action(UI.<>c.<>c_0.method_58), new Action(UI.<>c.<>c_0.method_59), "Protects you against unsafe avatars", false);
			new QMToggleButton(location, 2f, 0f, "Photon Checks", new Action(UI.<>c.<>c_0.method_60), new Action(UI.<>c.<>c_0.method_61), "Protects you against unsafe photon events", false);
			new QMToggleButton(location, 3f, 0f, "Leave On Admin Join", new Action(UI.<>c.<>c_0.method_62), new Action(UI.<>c.<>c_0.method_63), "Makes you leave the lobby when an Admin joins", false);
			QMNestedButton location2 = new QMNestedButton(qmtabMenu, 1f, 1f, UI.ExpMenu ?? "", "Opens the menu for " + UI.ExpMenu, UI.ExpMenu ?? "", false);
			new QMToggleButton(location2, 1f, 0f, "Event 1", new Action(UI.<>c.<>c_0.method_64), new Action(UI.<>c.<>c_0.method_65), "Sends a loud earrape event via your mic", false);
			QMNestedButton btnMenu3 = new QMNestedButton(qmtabMenu, 2f, 1f, "Utilities", "Opens the menu for Utils", "Utilities", false);
			new QMSingleButton(btnMenu3, 1f, 0f, "Join Discord", new Action(UI.<>c.<>c_0.method_66), "Please join <3", false);
			new QMSingleButton(btnMenu3, 3f, 0f, "Client Verions", new Action(UI.<>c.<>c_0.method_67), "Tells you the client version", false);
			new QMSingleButton(btnMenu3, 2f, 0f, "Clear VRAM", new Action(UI.<>c.<>c_0.method_68), "Helps boost FPS in game", false);
			QMNestedButton location3 = new QMNestedButton(qmtabMenu, 3f, 1f, "Movement", "Opens the menu for Movement hacks", "Movement", false);
			new QMToggleButton(location3, 1f, 0f, "Flight", new Action(UI.<>c.<>c_0.method_69), new Action(UI.<>c.<>c_0.method_70), "Allows you to fly anywhere", false);
			new QMToggleButton(location3, 2f, 0f, "Speed Hack", new Action(UI.<>c.<>c_0.method_71), new Action(UI.<>c.<>c_0.method_72), "Makes you run at any speed", false);
			new QMToggleButton(location3, 3f, 0f, "Inf Jump", new Action(UI.<>c.<>c_0.method_73), new Action(UI.<>c.<>c_0.method_74), "NO LIMITS!", false);
			new QMSlider(location3, -510f, -550f, "Walk Speed Slider", 0.1f, 55f, 25f, new Action<float>(UI.<>c.<>c_0.method_75), null);
			new QMSlider(location3, -510f, -730f, "Flight Speed Slider", 0.1f, 55f, 25f, new Action<float>(UI.<>c.<>c_0.method_76), null);
			QMNestedButton qmnestedButton6 = new QMNestedButton(qmtabMenu, 4f, 3f, UI.SetsMenu ?? "", "Opens the menu for " + UI.SetsMenu, UI.SetsMenu ?? "", false);
			new QMSingleButton(qmtabMenu, 1f, 3f, "Quit", new Action(UI.<>c.<>c_0.method_77), "", false);
			new QMSingleButton(qmtabMenu, 2f, 3f, "Restart", new Action(UI.<>c.<>c_0.method_78), "", false);
			new QMToggleButton(qmnestedButton6, 1f, 0f, "Keybinds", new Action(UI.<>c.<>c_0.method_79), new Action(UI.<>c.<>c_0.method_80), "Toggles the client's keybinds", false);
			new QMToggleButton(qmnestedButton6, 2f, 0f, "Disable Discord RPC", new Action(UI.<>c.<>c_0.method_81), new Action(UI.<>c.<>c_0.method_82), "Turns on or off the discord status of the client", false);
			new QMSingleButton(qmnestedButton6, 3f, 0f, "Uncap FPS", new Action(UI.<>c.<>c_0.method_83), "Inf frames", false);
			new QMSingleButton(qmnestedButton6, 4f, 0f, "Cap FPS", new Action(UI.<>c.<>c_0.method_84), "Caps to defualt frame rate", false);
			new QMSingleButton(qmnestedButton6, 1f, 1f, "Fullscreen", new Action(UI.<>c.<>c_0.method_85), "", false);
			new QMSingleButton(qmnestedButton6, 2f, 1f, "Windowed", new Action(UI.<>c.<>c_0.method_86), "", false);
			QMNestedButton qmnestedButton7 = new QMNestedButton("Menu_SelectedUser_Local", 1.5f, -0.56f, UI.KrazeText ?? "", "Opens the select user menu", UI.KrazeText + " " + UI.WIPTxt, true);
			new QMSingleButton(qmnestedButton7, 2f, 0f, "Download VRCA", new Action(UI.<>c.<>c_0.method_87), "Download this user's avatar", false);
			new QMSingleButton(qmnestedButton7, 3f, 0f, "Spam Items", new Action(UI.<>c.<>c_0.method_88), "Spams items to user's head", false);
			QMNestedButton qmnestedButton8 = new QMNestedButton(qmnestedButton7, 1f, 0f, "Player Attach", "Opens the playe attach menu", "Player Attach", false);
			new QMSingleButton(qmnestedButton8, 1f, 0f, "Chest", new Action(UI.<>c.<>c_0.method_89), null, false);
			new QMSingleButton(qmnestedButton8, 2f, 0f, "Right Hand", new Action(UI.<>c.<>c_0.method_90), null, false);
			new QMSingleButton(qmnestedButton8, 3f, 0f, "Left Hand", new Action(UI.<>c.<>c_0.method_91), null, false);
			new QMSingleButton(qmnestedButton8, 4f, 0f, "Head", new Action(UI.<>c.<>c_0.method_92), null, false);
			new QMToggleButton(qmnestedButton8, 1f, 1f, "Orbit", new Action(UI.<>c.<>c_0.method_93), new Action(UI.<>c.<>c_0.method_94), "Spin around a player and annoy them", false);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002849 File Offset: 0x00000A49
		public UI()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000732C File Offset: 0x0000552C
		// Note: this type is marked as 'beforefieldinit'.
		static UI()
		{
			Class39.smethod_16();
			UI.KrazeText = "<color=#ffffff>Kraze</color><color=#005eff>Hook</color>";
			UI.KrazeTextUtils = "<color=#ffffff>Kraze</color><color=#005eff>Hook</color> <color=#ffffff>Utils</color>";
			UI.ExpMenu = "<color=#ff0000>Exploits</color>";
			UI.SetsMenu = "<color=#ffd500>Settings</color>";
			UI.VersionTxt = "<color=#09ff00>[v4.2]</color>";
			UI.RpcVersions = "v4.2";
			UI.VRCbuild = "1205";
			UI.WIPTxt = "<color=#ffd500>[W.I.P]</color>";
			UI.BrokenTxt = "<color=#ff0000>[BROKEN]</color>";
			UI.BanTxt = "<color=#ff0000>[BANNABLE]</color>";
			UI.Lovensetxt = "<color=#ff75fa>Lovense</color>";
			UI.USpeakExploit = null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002856 File Offset: 0x00000A56
		internal static bool smethod_1()
		{
			return UI.ui_0 == null;
		}

		// Token: 0x0400007C RID: 124
		public static string KrazeText;

		// Token: 0x0400007D RID: 125
		public static string KrazeTextUtils;

		// Token: 0x0400007E RID: 126
		public static string ExpMenu;

		// Token: 0x0400007F RID: 127
		public static string SetsMenu;

		// Token: 0x04000080 RID: 128
		public static string VersionTxt;

		// Token: 0x04000081 RID: 129
		public static string RpcVersions;

		// Token: 0x04000082 RID: 130
		public static string VRCbuild;

		// Token: 0x04000083 RID: 131
		public static string WIPTxt;

		// Token: 0x04000084 RID: 132
		public static string BrokenTxt;

		// Token: 0x04000085 RID: 133
		public static string BanTxt;

		// Token: 0x04000086 RID: 134
		public static string Lovensetxt;

		// Token: 0x04000087 RID: 135
		public static object USpeakExploit;

		// Token: 0x04000088 RID: 136
		internal static UI ui_0;
	}
}
