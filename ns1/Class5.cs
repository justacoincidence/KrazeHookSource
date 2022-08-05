using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace ns1
{
	// Token: 0x0200001D RID: 29
	internal static class Class5
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000050B8 File Offset: 0x000032B8
		public static byte[] smethod_0(Object object_0)
		{
			byte[] result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, object_0);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000050F0 File Offset: 0x000032F0
		public static byte[] smethod_1(object object_0)
		{
			byte[] result;
			if (object_0 == null)
			{
				result = null;
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, object_0);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005124 File Offset: 0x00003324
		public static T smethod_2<T>(byte[] byte_0)
		{
			T result;
			if (byte_0 == null)
			{
				result = default(T);
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				using (MemoryStream memoryStream = new MemoryStream(byte_0))
				{
					object obj = binaryFormatter.Deserialize(memoryStream);
					result = (T)((object)obj);
				}
			}
			return result;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005180 File Offset: 0x00003380
		public static T smethod_3<T>(object object_0)
		{
			T result;
			if (object_0 == null)
			{
				result = default(T);
			}
			else
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream(object_0);
				object obj = binaryFormatter.Deserialize(memoryStream);
				result = (T)((object)obj);
			}
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000051C4 File Offset: 0x000033C4
		public static T smethod_4<T>(Object object_0)
		{
			return Class5.smethod_2<T>(Class5.smethod_0(object_0));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000051E0 File Offset: 0x000033E0
		public static T smethod_5<T>(object object_0)
		{
			return Class5.smethod_3<T>(Class5.smethod_1(object_0));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002762 File Offset: 0x00000962
		internal static bool smethod_6()
		{
			return Class5.class5_0 == null;
		}

		// Token: 0x04000072 RID: 114
		private static Class5 class5_0;
	}
}
