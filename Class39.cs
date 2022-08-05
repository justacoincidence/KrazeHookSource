using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200007A RID: 122
internal class Class39
{
	// Token: 0x06000383 RID: 899 RVA: 0x00002312 File Offset: 0x00000512
	private void method_0()
	{
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
	internal static byte[] smethod_0(object object_3)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - object_3.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)object_3.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)object_3.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < object_3.Length; i++)
		{
			array2[i] = object_3[i];
		}
		byte[] array3 = array2;
		int num4 = object_3.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class39.smethod_1(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class39.smethod_1(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class39.smethod_1(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class39.smethod_1(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class39.smethod_1(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class39.smethod_1(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class39.smethod_1(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class39.smethod_1(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class39.smethod_1(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class39.smethod_1(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class39.smethod_1(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class39.smethod_1(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class39.smethod_1(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class39.smethod_1(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class39.smethod_1(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class39.smethod_1(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class39.smethod_2(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class39.smethod_2(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class39.smethod_2(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class39.smethod_2(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class39.smethod_2(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class39.smethod_2(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class39.smethod_2(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class39.smethod_2(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class39.smethod_2(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class39.smethod_2(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class39.smethod_2(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class39.smethod_2(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class39.smethod_2(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class39.smethod_2(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class39.smethod_2(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class39.smethod_2(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class39.smethod_3(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class39.smethod_3(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class39.smethod_3(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class39.smethod_3(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class39.smethod_3(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class39.smethod_3(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class39.smethod_3(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class39.smethod_3(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class39.smethod_3(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class39.smethod_3(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class39.smethod_3(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class39.smethod_3(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class39.smethod_3(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class39.smethod_3(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class39.smethod_3(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class39.smethod_3(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class39.smethod_4(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class39.smethod_4(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class39.smethod_4(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class39.smethod_4(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class39.smethod_4(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class39.smethod_4(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class39.smethod_4(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class39.smethod_4(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class39.smethod_4(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class39.smethod_4(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class39.smethod_4(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class39.smethod_4(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class39.smethod_4(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class39.smethod_4(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class39.smethod_4(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class39.smethod_4(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00003C75 File Offset: 0x00001E75
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class39.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_3[(int)uint_5] + Class39.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00003C9E File Offset: 0x00001E9E
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class39.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_3[(int)uint_5] + Class39.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00003CC7 File Offset: 0x00001EC7
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class39.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_3[(int)uint_5] + Class39.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00003CED File Offset: 0x00001EED
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_3)
	{
		uint_1 = uint_2 + Class39.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_3[(int)uint_5] + Class39.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00003D14 File Offset: 0x00001F14
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00003D26 File Offset: 0x00001F26
	internal static bool smethod_6()
	{
		if (!Class39.bool_1)
		{
			Class39.smethod_8();
			Class39.bool_1 = true;
		}
		return Class39.bool_2;
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00003D3F File Offset: 0x00001F3F
	internal Class39()
	{
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0000E514 File Offset: 0x0000C714
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num13;
			uint num12 = num13 = num4;
			num13 ^= num13 >> 3;
			num13 += 51526599U;
			num13 ^= num13 << 3;
			num13 += 3106313727U;
			num13 ^= num13 >> 26;
			num13 += 1782664105U;
			num13 = 1477964798U - num13;
			num4 = num12 + (uint)num13;
			if (i == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num14 & num9) >> num10);
				}
			}
			else
			{
				uint num15 = num4 ^ num11;
				array[num6] = (byte)(num15 & 255U);
				array[num6 + 1] = (byte)((num15 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num15 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num15 & 4278190080U) >> 24);
			}
		}
		Class39.byte_1 = array;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x0000E700 File Offset: 0x0000C900
	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm result = null;
		if (Class39.smethod_6())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}
		return result;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x0000E758 File Offset: 0x0000C958
	internal static void smethod_8()
	{
		try
		{
			Class39.bool_2 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00003D47 File Offset: 0x00001F47
	internal static byte[] smethod_9(byte[] byte_2)
	{
		if (!Class39.smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class39.smethod_0(byte_2);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x0000E784 File Offset: 0x0000C984
	internal static void smethod_10(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class39.smethod_11(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00003D62 File Offset: 0x00001F62
	internal static void smethod_11(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
	internal static uint smethod_12(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002312 File Offset: 0x00000512
	internal static void smethod_13()
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x0000E81C File Offset: 0x0000CA1C
	public static void smethod_14(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class39.dictionary_0 == null)
			{
				object obj = Class39.object_0;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class39).Assembly.GetManifestResourceStream("KLR2LgLYLRU48FjYKn.JlU3hyM4UxqiN2ZuBO"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							num10 ^= num10 >> 3;
							num10 += 51526599U;
							num10 ^= num10 << 3;
							num10 += 3106313727U;
							num10 ^= num10 >> 26;
							num10 += 1782664105U;
							num10 = 1477964798U - num10;
							num3 = num9 + (uint)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num11 & num5) >> num6);
								}
							}
							else
							{
								uint num12 = num3 ^ num7;
								array2[num4] = (byte)(num12 & 255U);
								array2[num4 + 1] = (byte)((num12 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num12 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num12 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num13 = array.Length / 8;
						Class39.Class41 @class = new Class39.Class41(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class39.dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num14 = Class39.dictionary_0[metadataToken];
					bool flag2 = (num14 & 1073741824) > 0;
					num14 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(Class39).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num15 = parameters.Length + 1;
						Type[] array3 = new Type[num15];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num16 = 0; num16 < num15; num16++)
						{
							switch (num16)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num16);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00003D70 File Offset: 0x00001F70
	private static uint smethod_15(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00002312 File Offset: 0x00000512
	internal static void smethod_16()
	{
	}

	// Token: 0x06000397 RID: 919 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
	private static void smethod_17(object object_3, int int_6)
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x0000ED10 File Offset: 0x0000CF10
	internal static string smethod_18(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0000ED40 File Offset: 0x0000CF40
	private static void smethod_19()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600039A RID: 922 RVA: 0x0000ED68 File Offset: 0x0000CF68
	private static Delegate smethod_20(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x0600039B RID: 923 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
	internal static object smethod_21(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x0600039C RID: 924
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x0600039D RID: 925
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x0600039E RID: 926 RVA: 0x0000EED8 File Offset: 0x0000D0D8
	private static IntPtr smethod_22(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class39.delegate10_0 == null)
		{
			Class39.delegate10_0 = (Class39.Delegate10)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Find ".Trim() + "ResourceA"), typeof(Class39.Delegate10));
		}
		return Class39.delegate10_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x0000EF30 File Offset: 0x0000D130
	private static IntPtr smethod_23(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class39.delegate11_0 == null)
		{
			Class39.delegate11_0 = (Class39.Delegate11)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Virtual ".Trim() + "Alloc"), typeof(Class39.Delegate11));
		}
		return Class39.delegate11_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0000EF8C File Offset: 0x0000D18C
	private static int smethod_24(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class39.delegate12_0 == null)
		{
			Class39.delegate12_0 = (Class39.Delegate12)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class39.Delegate12));
		}
		return Class39.delegate12_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
	private static int smethod_25(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class39.delegate13_0 == null)
		{
			Class39.delegate13_0 = (Class39.Delegate13)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Virtual ".Trim() + "Protect"), typeof(Class39.Delegate13));
		}
		return Class39.delegate13_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x0000F050 File Offset: 0x0000D250
	private static IntPtr smethod_26(uint uint_1, int int_6, uint uint_2)
	{
		if (Class39.delegate14_0 == null)
		{
			Class39.delegate14_0 = (Class39.Delegate14)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Open ".Trim() + "Process"), typeof(Class39.Delegate14));
		}
		return Class39.delegate14_0(uint_1, int_6, uint_2);
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
	private static int smethod_27(IntPtr intptr_4)
	{
		if (Class39.delegate15_0 == null)
		{
			Class39.delegate15_0 = (Class39.Delegate15)Marshal.GetDelegateForFunctionPointer(Class39.GetProcAddress(Class39.smethod_28(), "Close ".Trim() + "Handle"), typeof(Class39.Delegate15));
		}
		return Class39.delegate15_0(intptr_4);
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00003D7C File Offset: 0x00001F7C
	private static IntPtr smethod_28()
	{
		if (Class39.intptr_1 == IntPtr.Zero)
		{
			Class39.intptr_1 = Class39.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class39.intptr_1;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0000F100 File Offset: 0x0000D300
	private static byte[] smethod_29(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00003DB2 File Offset: 0x00001FB2
	internal static byte[] smethod_30(MemoryStream memoryStream_0)
	{
		return ((MemoryStream)memoryStream_0).ToArray();
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x0000F160 File Offset: 0x0000D360
	private static byte[] smethod_31(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class39.smethod_7();
		symmetricAlgorithm.Key = new byte[]
		{
			179,
			221,
			33,
			237,
			19,
			38,
			31,
			237,
			36,
			128,
			133,
			100,
			70,
			245,
			14,
			220,
			252,
			43,
			115,
			164,
			186,
			206,
			141,
			103,
			30,
			178,
			108,
			176,
			240,
			94,
			175,
			55
		};
		symmetricAlgorithm.IV = new byte[]
		{
			37,
			56,
			105,
			223,
			33,
			130,
			175,
			32,
			211,
			64,
			186,
			222,
			138,
			188,
			248,
			129
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class39.smethod_30(stream);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x0000F1CC File Offset: 0x0000D3CC
	private unsafe static int smethod_32(object object_3)
	{
		char* ptr = object_3;
		if (ptr != null)
		{
			ptr += RuntimeHelpers.OffsetToStringData / 2;
		}
		int num = 5381;
		int num2 = 5381;
		char* ptr2 = ptr;
		int num3;
		while ((num3 = (int)(*ptr2)) != 0)
		{
			num = ((num << 5) + num ^ num3);
			num3 = (int)ptr2[1];
			if (num3 == 0)
			{
				break;
			}
			num2 = ((num2 << 5) + num2 ^ num3);
			ptr2 += 2;
		}
		return num + num2 * 1566083941;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000F234 File Offset: 0x0000D434
	internal static bool smethod_33(string string_1, string string_2)
	{
		if (string_1 == string_2)
		{
			return true;
		}
		if (string_1 == null || string_2 == null)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		int num2 = 0;
		if (string_1.StartsWith(Class39.string_0))
		{
			flag = true;
			num = (int)(string_1[4] | (int)string_1[5] << 8 | (int)string_1[6] << 16 | (int)string_1[7] << 24);
		}
		if (string_2.StartsWith(Class39.string_0))
		{
			flag2 = true;
			num2 = (int)(string_2[4] | (int)string_2[5] << 8 | (int)string_2[6] << 16 | (int)string_2[7] << 24);
		}
		if (!flag && !flag2)
		{
			return false;
		}
		if (!flag)
		{
			num = Class39.smethod_32(string_1);
		}
		if (!flag2)
		{
			num2 = Class39.smethod_32(string_2);
		}
		return num == num2;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00003DBF File Offset: 0x00001FBF
	private byte[] method_2()
	{
		return null;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00003DBF File Offset: 0x00001FBF
	private byte[] method_3()
	{
		return null;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00003DC2 File Offset: 0x00001FC2
	private byte[] method_4()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00003DDD File Offset: 0x00001FDD
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00003DF8 File Offset: 0x00001FF8
	private byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00003E13 File Offset: 0x00002013
	private byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00003E2E File Offset: 0x0000202E
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00003E49 File Offset: 0x00002049
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00003E64 File Offset: 0x00002064
	internal byte[] method_10()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00003E7F File Offset: 0x0000207F
	internal byte[] method_11()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00003E9A File Offset: 0x0000209A
	internal static bool smethod_34()
	{
		return null == null;
	}

	// Token: 0x0400021A RID: 538
	private static bool bool_0;

	// Token: 0x0400021B RID: 539
	internal static Assembly assembly_0;

	// Token: 0x0400021C RID: 540
	private static bool bool_1;

	// Token: 0x0400021D RID: 541
	private static bool bool_2;

	// Token: 0x0400021E RID: 542
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0;

	// Token: 0x0400021F RID: 543
	private static int int_0;

	// Token: 0x04000220 RID: 544
	private static List<int> list_0;

	// Token: 0x04000221 RID: 545
	private static int[] int_1;

	// Token: 0x04000222 RID: 546
	private static int int_2;

	// Token: 0x04000223 RID: 547
	private static IntPtr intptr_0;

	// Token: 0x04000224 RID: 548
	[Class39.Attribute0(typeof(Class39.Attribute0.IDCAEIOAFAINPJBDOFOMEPDDMNAMPKPPGADG<object>[]))]
	private static bool bool_3;

	// Token: 0x04000225 RID: 549
	internal static Hashtable hashtable_0;

	// Token: 0x04000226 RID: 550
	private static Class39.Delegate10 delegate10_0;

	// Token: 0x04000227 RID: 551
	private static Class39.Delegate11 delegate11_0;

	// Token: 0x04000228 RID: 552
	private static Class39.Delegate13 delegate13_0;

	// Token: 0x04000229 RID: 553
	private static IntPtr intptr_1;

	// Token: 0x0400022A RID: 554
	private static IntPtr intptr_2;

	// Token: 0x0400022B RID: 555
	private static Class39.Delegate15 delegate15_0;

	// Token: 0x0400022C RID: 556
	private static object object_0;

	// Token: 0x0400022D RID: 557
	private static object object_1;

	// Token: 0x0400022E RID: 558
	private static bool bool_4;

	// Token: 0x0400022F RID: 559
	private static long long_0;

	// Token: 0x04000230 RID: 560
	private static IntPtr intptr_3;

	// Token: 0x04000231 RID: 561
	private static long long_1;

	// Token: 0x04000232 RID: 562
	private static byte[] byte_0;

	// Token: 0x04000233 RID: 563
	private static Class39.Delegate12 delegate12_0;

	// Token: 0x04000234 RID: 564
	internal static Class39.Delegate8 delegate8_0;

	// Token: 0x04000235 RID: 565
	private static object object_2;

	// Token: 0x04000236 RID: 566
	private static byte[] byte_1;

	// Token: 0x04000237 RID: 567
	internal static Class39.Delegate8 delegate8_1;

	// Token: 0x04000238 RID: 568
	private static bool bool_5;

	// Token: 0x04000239 RID: 569
	private static int int_3;

	// Token: 0x0400023A RID: 570
	private static uint[] uint_0;

	// Token: 0x0400023B RID: 571
	private static int int_4;

	// Token: 0x0400023C RID: 572
	private static SortedList sortedList_0;

	// Token: 0x0400023D RID: 573
	private static bool bool_6;

	// Token: 0x0400023E RID: 574
	private static string string_0;

	// Token: 0x0400023F RID: 575
	private static Class39.Delegate14 delegate14_0;

	// Token: 0x04000240 RID: 576
	private static List<string> list_1;

	// Token: 0x04000241 RID: 577
	private static int int_5;

	// Token: 0x04000242 RID: 578
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x0200007B RID: 123
	// (Invoke) Token: 0x060003B6 RID: 950
	private delegate void Delegate7(object object_0);

	// Token: 0x0200007C RID: 124
	internal class Attribute0 : Attribute
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00003EA0 File Offset: 0x000020A0
		public Attribute0(object object_0)
		{
		}

		// Token: 0x0200007D RID: 125
		internal class IDCAEIOAFAINPJBDOFOMEPDDMNAMPKPPGADG<T>
		{
			// Token: 0x060003BA RID: 954 RVA: 0x000022C0 File Offset: 0x000004C0
			public IDCAEIOAFAINPJBDOFOMEPDDMNAMPKPPGADG()
			{
				Class39.smethod_16();
				base..ctor();
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00003EA8 File Offset: 0x000020A8
			internal static bool smethod_0()
			{
				return Class39.Attribute0.IDCAEIOAFAINPJBDOFOMEPDDMNAMPKPPGADG<T>.object_0 == null;
			}

			// Token: 0x04000243 RID: 579
			internal static object object_0;
		}
	}

	// Token: 0x0200007E RID: 126
	internal class Class40
	{
		// Token: 0x060003BC RID: 956 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class39.smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class39.smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x0200007F RID: 127
	// (Invoke) Token: 0x060003BF RID: 959
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate8(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x02000080 RID: 128
	// (Invoke) Token: 0x060003C3 RID: 963
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate9();

	// Token: 0x02000081 RID: 129
	internal struct Struct5
	{
		// Token: 0x04000244 RID: 580
		internal bool bool_0;

		// Token: 0x04000245 RID: 581
		internal byte[] byte_0;
	}

	// Token: 0x02000082 RID: 130
	internal class Class41
	{
		// Token: 0x060003C6 RID: 966 RVA: 0x00003EB2 File Offset: 0x000020B2
		public Class41(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00003EC6 File Offset: 0x000020C6
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00003ED3 File Offset: 0x000020D3
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00003EE1 File Offset: 0x000020E1
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00003EF1 File Offset: 0x000020F1
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00003EFE File Offset: 0x000020FE
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x04000246 RID: 582
		private BinaryReader binaryReader_0;
	}

	// Token: 0x02000083 RID: 131
	// (Invoke) Token: 0x060003CD RID: 973
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate10(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x02000084 RID: 132
	// (Invoke) Token: 0x060003D1 RID: 977
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate11(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x02000085 RID: 133
	// (Invoke) Token: 0x060003D5 RID: 981
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate12(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x02000086 RID: 134
	// (Invoke) Token: 0x060003D9 RID: 985
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate13(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x02000087 RID: 135
	// (Invoke) Token: 0x060003DD RID: 989
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate14(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x02000088 RID: 136
	// (Invoke) Token: 0x060003E1 RID: 993
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate15(IntPtr ptr);

	// Token: 0x02000089 RID: 137
	[Flags]
	private enum Enum1
	{

	}
}
