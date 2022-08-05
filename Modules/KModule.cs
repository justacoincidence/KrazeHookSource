using System;
using VRC;
using VRC.Core;

namespace KrazeHook.Modules
{
	// Token: 0x02000023 RID: 35
	public abstract class KModule
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void Start()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void QuickMenuInit()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void SocialMenuInit()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void vmethod_0()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void PlayerJoined(Player player)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void PlayerLeft(Player player)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void SceneLoaded(int buildIndex, string sceneName)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void WorldLoaded(ApiWorld world, ApiWorldInstance instance)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002312 File Offset: 0x00000512
		public virtual void LocalPlayerLoaded(APIUser apiUser)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000022C0 File Offset: 0x000004C0
		protected KModule()
		{
			Class39.smethod_16();
			base..ctor();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000283F File Offset: 0x00000A3F
		internal static bool smethod_0()
		{
			return KModule.kmodule_0 == null;
		}

		// Token: 0x0400007B RID: 123
		internal static KModule kmodule_0;
	}
}
