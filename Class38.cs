using System;
using System.Reflection;

// Token: 0x02000078 RID: 120
internal class Class38
{
	// Token: 0x0600037B RID: 891 RVA: 0x0000DE48 File Offset: 0x0000C048
	internal static void smethod_0(int typemdt)
	{
		Type type = Class38.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class38.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x0600037C RID: 892 RVA: 0x000022C0 File Offset: 0x000004C0
	public Class38()
	{
		Class39.smethod_16();
		base..ctor();
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00003C4B File Offset: 0x00001E4B
	// Note: this type is marked as 'beforefieldinit'.
	static Class38()
	{
		Class39.smethod_16();
		Class38.module_0 = typeof(Class38).Assembly.ManifestModule;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00003C6B File Offset: 0x00001E6B
	internal static bool smethod_1()
	{
		return Class38.class38_0 == null;
	}

	// Token: 0x04000218 RID: 536
	internal static Module module_0;

	// Token: 0x04000219 RID: 537
	internal static Class38 class38_0;

	// Token: 0x02000079 RID: 121
	// (Invoke) Token: 0x06000380 RID: 896
	internal delegate void Delegate6(object object_0);
}
