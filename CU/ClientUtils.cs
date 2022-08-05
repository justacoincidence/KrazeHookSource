using System;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.XR;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.SDKBase;
using VRC.UI;
using VRC.UI.Elements.Menus;

namespace KrazeHook.CU
{
	// Token: 0x02000028 RID: 40
	public static class ClientUtils
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000055AC File Offset: 0x000037AC
		public static VRCPlayer LocalPlayer
		{
			get
			{
				return VRCPlayer.field_Internal_Static_VRCPlayer_0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000076FC File Offset: 0x000058FC
		public static APIUser CurrentUser
		{
			get
			{
				return APIUser.CurrentUser;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00007710 File Offset: 0x00005910
		public static VRCUiManager VRCUiManager
		{
			get
			{
				return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00007724 File Offset: 0x00005924
		public static VRCUiPopupManager VRCUiPopupManager
		{
			get
			{
				return VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0();
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00007738 File Offset: 0x00005938
		public static List<Player> GetPlayers
		{
			get
			{
				return PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00007754 File Offset: 0x00005954
		public static PageWorldInfo GetPageWorldInfo
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/WorldInfo").GetComponent<PageWorldInfo>();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00007774 File Offset: 0x00005974
		public static PageAvatar GetPageAvatar
		{
			get
			{
				return GameObject.Find("UserInterface/MenuContent/Screens/Avatar").GetComponent<PageAvatar>();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00007794 File Offset: 0x00005994
		public static ApiWorld GetApiWorld
		{
			get
			{
				return RoomManager.field_Internal_Static_ApiWorld_0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000077A8 File Offset: 0x000059A8
		public static ApiWorldInstance GetApiWorldInstance
		{
			get
			{
				return RoomManager.field_Internal_Static_ApiWorldInstance_0;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002B91 File Offset: 0x00000D91
		public static bool IsInRoom()
		{
			return ClientUtils.GetApiWorld != null && ClientUtils.GetApiWorldInstance != null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000077BC File Offset: 0x000059BC
		public static VRCPlayer GetQMSelectedUser()
		{
			IUser field_Private_IUser_ = Object.FindObjectOfType<SelectedUserMenuQM>().field_Private_IUser_0;
			return ClientUtils.GetPlayerByUserID(field_Private_IUser_.Method_Public_Abstract_Virtual_New_get_String_0())._vrcplayer;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000077E8 File Offset: 0x000059E8
		public static Player GetPlayerByUserID(string userID)
		{
			foreach (Player player in ClientUtils.GetPlayers)
			{
				if (player.field_Private_APIUser_0.id == userID)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00007830 File Offset: 0x00005A30
		public static Player GetPlayerByActorID(int actorID)
		{
			foreach (Player player in ClientUtils.GetPlayers)
			{
				if (player.field_Private_VRCPlayerApi_0.playerId == actorID)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00007874 File Offset: 0x00005A74
		public static bool SelfIsInVR()
		{
			bool result;
			if (!XRDevice.isPresent)
			{
				result = Environment.CommandLine.ToLower().Split(new char[]
				{
					' '
				}, StringSplitOptions.RemoveEmptyEntries).Any(new Func<string, bool>(ClientUtils.<>c.<>c_0.method_0));
			}
			else
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000078CC File Offset: 0x00005ACC
		public static Player GetMaster()
		{
			foreach (Player player in ClientUtils.GetPlayers)
			{
				if (player.Method_Public_get_VRCPlayerApi_0().isMaster)
				{
					return player;
				}
			}
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000790C File Offset: 0x00005B0C
		public static string GetJoinID()
		{
			return ClientUtils.GetApiWorldInstance.id;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public static void JoinRoom(string fullID)
		{
			Networking.GoToRoom(fullID);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002BAE File Offset: 0x00000DAE
		public static void JoinRoom(string worldID, string instanceID)
		{
			ClientUtils.JoinRoom(worldID + ":" + instanceID);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00007928 File Offset: 0x00005B28
		public static APIUser smethod_0(this Player source)
		{
			return source.field_Private_APIUser_0;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005228 File Offset: 0x00003428
		public static VRCPlayer GetVRCPlayer(this Player source)
		{
			return source._vrcplayer;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000528C File Offset: 0x0000348C
		public static VRCPlayerApi GetVRCPlayerApi(this Player source)
		{
			return source.field_Private_VRCPlayerApi_0;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007940 File Offset: 0x00005B40
		public static PlayerNet GetPlayerNet(this Player source)
		{
			return source._playerNet;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007958 File Offset: 0x00005B58
		public static ApiAvatar GetMainAvatar(this Player source)
		{
			return source.Method_Public_get_ApiAvatar_0();
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00007970 File Offset: 0x00005B70
		public static ApiAvatar GetFallbackAvatar(this Player source)
		{
			return source._vrcplayer.Method_Public_get_ApiAvatar_0();
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000798C File Offset: 0x00005B8C
		public static Player GetPhotonPlayer(this Player source)
		{
			return source.field_Private_Player_0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000079A4 File Offset: 0x00005BA4
		public static string GetTrustRank(this APIUser Instance)
		{
			string result;
			if (!Instance.hasModerationPowers && !Instance.tags.Contains("admin_moderator"))
			{
				if (Instance.hasSuperPowers || Instance.tags.Contains("admin_"))
				{
					result = "Admin User";
				}
				else if (Instance.hasVeteranTrustLevel)
				{
					result = "Trusted";
				}
				else if (!Instance.hasTrustedTrustLevel)
				{
					if (Instance.hasKnownTrustLevel)
					{
						result = "User";
					}
					else if (!Instance.hasBasicTrustLevel && !Instance.isNewUser)
					{
						if (Instance.hasNegativeTrustLevel || Instance.tags.Contains("system_probable_troll"))
						{
							result = "NegativeTrust";
						}
						else
						{
							result = (Instance.hasVeryNegativeTrustLevel ? "VeryNegativeTrust" : "Visitor");
						}
					}
					else
					{
						result = "New User";
					}
				}
				else
				{
					result = "Known";
				}
			}
			else
			{
				result = "Moderation User";
			}
			return result;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002BC1 File Offset: 0x00000DC1
		internal static bool smethod_1()
		{
			return ClientUtils.clientUtils_0 == null;
		}

		// Token: 0x040000F0 RID: 240
		internal static ClientUtils clientUtils_0;
	}
}
