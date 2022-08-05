using System;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
internal class Class0
{
	// Token: 0x06000001 RID: 1
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_Initialize(string string_0, ref Class0.Struct0 struct0_0, bool bool_0, string string_1);

	// Token: 0x06000002 RID: 2
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_Shutdown();

	// Token: 0x06000003 RID: 3
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_RunCallbacks();

	// Token: 0x06000004 RID: 4
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_UpdatePresence(ref Class0.Struct1 struct1_0);

	// Token: 0x06000005 RID: 5
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_ClearPresence();

	// Token: 0x06000006 RID: 6
	[DllImport("KrazeHook/Dependencies/discord-rpc.dll", CallingConvention = CallingConvention.Cdecl)]
	protected internal static extern void Discord_Respond(string string_0, Class0.Enum0 enum0_0);

	// Token: 0x06000007 RID: 7 RVA: 0x000022C0 File Offset: 0x000004C0
	public Class0()
	{
		Class39.smethod_16();
		base..ctor();
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000022CD File Offset: 0x000004CD
	internal static bool smethod_0()
	{
		return Class0.class0_0 == null;
	}

	// Token: 0x04000001 RID: 1
	internal static Class0 class0_0;

	// Token: 0x02000003 RID: 3
	internal struct Struct0
	{
		// Token: 0x04000002 RID: 2
		internal Class0.Delegate0 delegate0_0;

		// Token: 0x04000003 RID: 3
		internal Class0.Delegate1 delegate1_0;

		// Token: 0x04000004 RID: 4
		internal Class0.Delegate2 delegate2_0;

		// Token: 0x04000005 RID: 5
		internal Class0.Delegate3 delegate3_0;

		// Token: 0x04000006 RID: 6
		internal Class0.Delegate4 delegate4_0;

		// Token: 0x04000007 RID: 7
		internal Class0.Delegate5 delegate5_0;
	}

	// Token: 0x02000004 RID: 4
	[Serializable]
	internal struct Struct1
	{
		// Token: 0x04000008 RID: 8
		internal string string_0;

		// Token: 0x04000009 RID: 9
		internal string string_1;

		// Token: 0x0400000A RID: 10
		internal long long_0;

		// Token: 0x0400000B RID: 11
		internal long long_1;

		// Token: 0x0400000C RID: 12
		internal string string_2;

		// Token: 0x0400000D RID: 13
		internal string string_3;

		// Token: 0x0400000E RID: 14
		internal string string_4;

		// Token: 0x0400000F RID: 15
		internal string string_5;

		// Token: 0x04000010 RID: 16
		internal string string_6;

		// Token: 0x04000011 RID: 17
		internal int int_0;

		// Token: 0x04000012 RID: 18
		internal int int_1;

		// Token: 0x04000013 RID: 19
		internal string string_7;

		// Token: 0x04000014 RID: 20
		internal string string_8;

		// Token: 0x04000015 RID: 21
		internal string string_9;

		// Token: 0x04000016 RID: 22
		internal bool bool_0;

		// Token: 0x04000017 RID: 23
		internal string string_10;
	}

	// Token: 0x02000005 RID: 5
	[Serializable]
	internal struct Struct2
	{
		// Token: 0x04000018 RID: 24
		public string string_0;

		// Token: 0x04000019 RID: 25
		public string string_1;

		// Token: 0x0400001A RID: 26
		public string string_2;

		// Token: 0x0400001B RID: 27
		public string string_3;
	}

	// Token: 0x02000006 RID: 6
	public enum Enum0
	{

	}

	// Token: 0x02000007 RID: 7
	// (Invoke) Token: 0x0600000A RID: 10
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate0();

	// Token: 0x02000008 RID: 8
	// (Invoke) Token: 0x0600000E RID: 14
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate1(int errorCode, string message);

	// Token: 0x02000009 RID: 9
	// (Invoke) Token: 0x06000012 RID: 18
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate2(int errorCode, string message);

	// Token: 0x0200000A RID: 10
	// (Invoke) Token: 0x06000016 RID: 22
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate3(string secret);

	// Token: 0x0200000B RID: 11
	// (Invoke) Token: 0x0600001A RID: 26
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate4(string secret);

	// Token: 0x0200000C RID: 12
	// (Invoke) Token: 0x0600001E RID: 30
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	protected internal delegate void Delegate5(ref Class0.Struct2 request);
}
