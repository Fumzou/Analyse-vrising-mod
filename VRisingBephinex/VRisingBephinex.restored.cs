using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Core.Logging.Interpolation;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Microsoft.CodeAnalysis;
using ProjectM;
using ProjectM.Network;
using Stunlock.Core;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.InputSystem;
using VRisingBephinex.Components;
using VRisingBephinex.ability;
using VRisingBephinex.components;
using VRisingBephinex.components.creatures;
using VRisingBephinex.components.creatures.model;
using VRisingBephinex.components.esp;
using VRisingBephinex.components.model;
using VRisingBephinex.components.players;
using VRisingBephinex.config;
using VRisingBephinex.gui;
using VRisingBephinex.patch;
using VRisingBephinex.utils;
using XwEvHcIp4EuVbeL17WK;
using h4pwrXy0hRTHCo506Uc;

[assembly: SuppressIldasm]
[assembly: AssemblyTitle("VRisingBephinex")]
[assembly: AssemblyProduct("VRisingBephinex")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyInformationalVersion("1.0.0+6c2d06f66ff7cec867db3f338d4f61b26b3fcf91")]
[assembly: TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName = ".NET 6.0")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyCompany("VRisingBephinex")]
[assembly: AssemblyVersion("1.0.0.0")]
internal class <Module>
{
	private static global::<Module> UIYfyMIWWeNBAHfXP6L;

	internal static void m8DDA5E33A05161A()
	{
		int num = 3;
		int num2 = num;
		TimeSpan timeSpan = default(TimeSpan);
		int days = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				timeSpan = DateTime.Now - new DateTime(2025, 6, 7);
				num2 = 2;
				break;
			case 5:
				if (days > 14)
				{
					num2 = 6;
					if (1814018247 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 4;
			case 2:
				days = timeSpan.Days;
				num2 = 5;
				break;
			default:
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			case 1:
				return;
			case 4:
				if (days > -14)
				{
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	static <Module>()
	{
		jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
		m8DDA5E33A05161A();
	}

	internal static bool OESEaIIBxIBcpncm172()
	{
		return UIYfyMIWWeNBAHfXP6L == null;
	}

	internal static global::<Module> rYERoxI5APMxx2T0rOA()
	{
		return UIYfyMIWWeNBAHfXP6L;
	}
}
namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		internal static EmbeddedAttribute omym1rI2LSrJRLCCnb0;

		public EmbeddedAttribute()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (1427489184 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool KJtYw3IMEBWm7VcgBbX()
		{
			return omym1rI2LSrJRLCCnb0 == null;
		}

		internal static EmbeddedAttribute vN1t1IIhBDXjAONJx12()
		{
			return omym1rI2LSrJRLCCnb0;
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		public readonly byte[] NullableFlags;

		private static NullableAttribute OEoDSqIvjBLG3LC8h1Z;

		public NullableAttribute(byte P_0)
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (10932459 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					NullableFlags = new byte[1] { P_0 };
					num = 0;
					if (1629830925 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public NullableAttribute(byte[] P_0)
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (2144623378 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				NullableFlags = P_0;
				num = 1;
				if (0 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool Xhkqr8ILT6ctSMdfw5c()
		{
			return OEoDSqIvjBLG3LC8h1Z == null;
		}

		internal static NullableAttribute KpBX6gI01y2h00PNsd6()
		{
			return OEoDSqIvjBLG3LC8h1Z;
		}
	}
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		public readonly byte Flag;

		private static NullableContextAttribute t8vvt2IVHJEJXKy5nB2;

		public NullableContextAttribute(byte P_0)
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (962215133 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Flag = P_0;
				num = 0;
				if (374085082 != 0)
				{
					num = 1;
				}
			}
		}

		internal static bool pB1mBVIH8xYHIYWaQZg()
		{
			return t8vvt2IVHJEJXKy5nB2 == null;
		}

		internal static NullableContextAttribute BWJ6IMI9aOSpavKrefa()
		{
			return t8vvt2IVHJEJXKy5nB2;
		}
	}
}
namespace VRisingBephinex
{
	[BepInPlugin("vrising-pvp-extention", "PVPExtention", "1.0.0")]
	public class Plugin : BasePlugin
	{
		private Harmony A9abAqPW9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Plugin wfZCYxw89;

		internal static Plugin PWtxmlINh66pgZZGS2t;

		public static ManualLogSource LogInstance => ((BasePlugin)WjsiYZ2El()).Log;

		[SpecialName]
		[CompilerGenerated]
		internal static Plugin WjsiYZ2El()
		{
			return wfZCYxw89;
		}

		[SpecialName]
		[CompilerGenerated]
		private static void axRp0bXGm(Plugin P_0)
		{
			wfZCYxw89 = P_0;
		}

		public override void Load()
		{
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			int num = 1;
			bool flag = default(bool);
			ManualLogSource log = default(ManualLogSource);
			BepInExInfoLogInterpolatedStringHandler val = default(BepInExInfoLogInterpolatedStringHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
						if (flag)
						{
							num2 = 6;
							continue;
						}
						goto case 4;
					case 5:
						log = ((BasePlugin)this).Log;
						num2 = 8;
						continue;
					case 8:
						val = new BepInExInfoLogInterpolatedStringHandler(23, 0, ref flag);
						num2 = 2;
						if (0 == 0)
						{
							num2 = 9;
						}
						continue;
					case 3:
						new ModConfig(this).Load();
						num2 = 5;
						continue;
					case 1:
						axRp0bXGm(this);
						num2 = 0;
						if (1433983997 != 0)
						{
							num2 = 0;
						}
						continue;
					case 6:
						((BepInExLogInterpolatedStringHandler)val).AppendLiteral("PVPExtention is loaded!");
						num = 4;
						break;
					case 10:
						A9abAqPW9.PatchAll(Assembly.GetExecutingAssembly());
						num2 = 1;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					default:
						((BasePlugin)this).AddComponent<RootComponent>();
						num2 = 7;
						if (1531368356 == 0)
						{
							num2 = 2;
						}
						continue;
					case 4:
						log.LogInfo(val);
						num2 = 2;
						if (171252512 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						return;
					case 7:
						A9abAqPW9 = new Harmony("vrising-pvp-extention");
						num = 10;
						break;
					}
					break;
				}
			}
		}

		public override bool Unload()
		{
			int num = 4;
			bool result = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
					{
						Harmony a9abAqPW = A9abAqPW9;
						if (a9abAqPW != null)
						{
							a9abAqPW.UnpatchSelf();
							num2 = 2;
							break;
						}
						goto end_IL_0012;
					}
					default:
						return result;
					case 2:
					case 3:
						result = true;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}

		public static void LogInfo(string message)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					LogInstance.LogInfo((object)message);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public Plugin()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			((BasePlugin)this)..ctor();
			int num = 0;
			if (1433983997 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool VBr4LHIjHddTpi3xEWv()
		{
			return PWtxmlINh66pgZZGS2t == null;
		}

		internal static Plugin J8ov1dIdbWPWys9IwcR()
		{
			return PWtxmlINh66pgZZGS2t;
		}
	}
}
namespace VRisingBephinex.utils
{
	public static class ColorEx
	{
		public static Color White;

		public static Color Red;

		public static Color Green;

		public static Color Blue;

		public static Color Cyan;

		public static Color Magenta;

		public static Color Yellow;

		public static Color Orange;

		public static Color Purple;

		public static Color Crimson;

		public static Color Cognac;

		public static Color Black;

		public static Color Lime;

		public static Color Teal;

		public static Color Maroon;

		public static Color Olive;

		public static Color Pink;

		public static Color Coral;

		public static Color Indigo;

		public static Color Silver;

		public static Color Violet;

		public static Color DarkGray;

		public static Color LightGray;

		public static Color Gold;

		public static Color DarkRed;

		public static Color DarkGreen;

		internal static ColorEx aU264YI827cib974MnS;

		static ColorEx()
		{
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0432: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0465: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_040a: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			int num = 14;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 22:
						Blue = Color.blue;
						num2 = 14;
						if (1848937442 != 0)
						{
							num2 = 23;
						}
						continue;
					case 14:
						jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
						num2 = 13;
						continue;
					case 15:
						Teal = new Color(0f, 0.5f, 0.5f);
						num2 = 1;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					default:
						Olive = new Color(0.5f, 0.5f, 0f);
						num2 = 20;
						continue;
					case 3:
						Maroon = new Color(0.5f, 0f, 0f);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 21:
						Magenta = Color.magenta;
						num2 = 8;
						if (0 == 0)
						{
							num2 = 16;
						}
						continue;
					case 17:
						Red = Color.red;
						num2 = 9;
						continue;
					case 6:
						Crimson = new Color(0.863f, 0.078f, 0.235f);
						num2 = 10;
						continue;
					case 27:
						Purple = new Color(0.5f, 0f, 0.5f);
						num2 = 6;
						if (519538535 == 0)
						{
							num2 = 2;
						}
						continue;
					case 10:
						Cognac = new Color(0.514f, 0.262f, 0.2f);
						num2 = 8;
						continue;
					case 5:
						Silver = new Color(0.75f, 0.75f, 0.75f);
						num2 = 11;
						continue;
					case 9:
						Green = Color.green;
						num = 22;
						break;
					case 26:
						DarkGray = new Color(0.2f, 0.2f, 0.2f);
						num2 = 12;
						continue;
					case 1:
						return;
					case 4:
						Orange = new Color(1f, 0.5f, 0f);
						num2 = 27;
						continue;
					case 24:
						Coral = new Color(1f, 0.5f, 0.31f);
						num = 25;
						break;
					case 8:
						Black = Color.black;
						num2 = 18;
						if (121889664 == 0)
						{
							num2 = 15;
						}
						continue;
					case 13:
						wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
						num2 = 19;
						continue;
					case 7:
						Gold = new Color(1f, 0.84f, 0f);
						num2 = 28;
						continue;
					case 16:
						Yellow = Color.yellow;
						num2 = 4;
						continue;
					case 28:
						DarkRed = new Color(0.5f, 0f, 0f);
						num = 2;
						break;
					case 18:
						Lime = new Color(0.5f, 1f, 0f);
						num2 = 15;
						continue;
					case 25:
						Indigo = new Color(0.29f, 0f, 0.51f);
						num2 = 5;
						continue;
					case 11:
						Violet = new Color(0.93f, 0.51f, 0.93f);
						num2 = 26;
						if (468683115 == 0)
						{
							num2 = 16;
						}
						continue;
					case 19:
						White = Color.white;
						num2 = 17;
						continue;
					case 23:
						Cyan = Color.cyan;
						num2 = 21;
						continue;
					case 20:
						Pink = new Color(1f, 0.75f, 0.8f);
						num2 = 24;
						continue;
					case 2:
						DarkGreen = new Color(0f, 0.5f, 0f);
						num2 = 1;
						if (1268266038 == 0)
						{
							num2 = 0;
						}
						continue;
					case 12:
						LightGray = new Color(0.8f, 0.8f, 0.8f);
						num2 = 7;
						if (0 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static bool hKUlSCIAiKFJaMNPmgQ()
		{
			return aU264YI827cib974MnS == null;
		}

		internal static ColorEx rglAeBIm8IPWKqeT6A0()
		{
			return aU264YI827cib974MnS;
		}
	}
	public static class DictCache
	{
		public static List<PrefabGUID> CounterAttackGUIDs;

		public static Dictionary<int, float> AbilityDurationDictionary;

		public static readonly Dictionary<int, float> AbilitySpeedDictionary;

		internal static DictCache DDNRVHIJSYLMCUOf5Zx;

		static DictCache()
		{
			//IL_1f1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f40: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f62: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f84: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
					num2 = 2;
					if (0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				case 4:
					jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
					num2 = 3;
					continue;
				case 5:
					AbilityDurationDictionary = new Dictionary<int, float>
					{
						[-2059383344] = 3f,
						[1619421912] = 3.5f,
						[-425480162] = 2.8f,
						[646697719] = 2.8f,
						[-2024307089] = 2.6f,
						[-549357932] = 2.6f,
						[1802235612] = 2f,
						[-1456665278] = 5f,
						[-1709807211] = 1.66666f,
						[1320706811] = 2.5f,
						[-1144749945] = 7f,
						[-137254439] = 2f,
						[1973172284] = 2f,
						[1704098967] = 2.5f,
						[-544841952] = 2.5f,
						[-1015417951] = 3f,
						[388863053] = 6f,
						[606469554] = 2f,
						[-302281354] = 5f,
						[210911413] = 0.8f,
						[-1151659014] = 999f,
						[518003890] = 999f,
						[-706163371] = 999f,
						[1668553037] = 999f,
						[-835404749] = 1.67f,
						[1221985602] = 100f,
						[-2026271555] = 8f,
						[2062119815] = 20f,
						[-806722104] = 25f,
						[-1293624718] = 1.5f,
						[-516285679] = 6f,
						[1839796503] = 25f,
						[-36977253] = 5000f,
						[-789920422] = 2f,
						[1557639506] = 3f,
						[-1306211385] = 6f,
						[-581863994] = 3f,
						[863435029] = 1.5f,
						[-1178781670] = 5f,
						[931744634] = 1.7f,
						[-2093769435] = 6f,
						[-909226674] = 11.6f,
						[-162789018] = 2.2f,
						[980100276] = 2f,
						[1141366098] = 3f,
						[1786941235] = 2.5f,
						[1537903648] = 3f,
						[-2036444563] = 8.05f,
						[1487622444] = 4f,
						[-1082916719] = 3f,
						[-293717845] = 3.1f,
						[730303038] = 8f,
						[844277355] = 7f,
						[-163700765] = 3.5f,
						[-177794527] = 1.3f,
						[-1403266432] = 6.1f,
						[1056001110] = 4f,
						[-973149407] = 2.1f,
						[-1208093184] = 2f,
						[918875818] = 3f,
						[-2082580927] = 2.4f,
						[2105164651] = 2.4f,
						[-1232216724] = 60f,
						[1331385563] = 3.33f,
						[-1661855385] = 3.33f,
						[168757271] = 2.4f,
						[-2046586504] = 60f,
						[346240125] = 3f,
						[-1861609629] = 3f,
						[145204275] = 30f,
						[306992792] = 3f,
						[-442218149] = 2f,
						[682157248] = 2.4f,
						[-561656902] = 3f,
						[1010344901] = 60f,
						[-849143290] = 1f,
						[1399619536] = 2f,
						[-1655280244] = 1.2f,
						[842159268] = 1.5f,
						[783049582] = 3.2f,
						[155874902] = 999f,
						[-2056565435] = 999f,
						[-1251722046] = 999f,
						[-1378558491] = 999f,
						[956142591] = 10f,
						[-917475906] = 7f,
						[290945473] = 4f,
						[-1898964293] = 4f,
						[-1087923572] = 2.5f,
						[-1805100612] = 6.85f,
						[1434448130] = 3f,
						[-1838517125] = 10f,
						[612544982] = 8f,
						[2016926455] = 8f,
						[1938218550] = 0.65f,
						[437005070] = 0.65f,
						[-1319599432] = 0.65f,
						[-114006154] = 0.65f,
						[379512250] = 3f,
						[-1539256101] = 20f,
						[-888561363] = 1.5f,
						[-1965997143] = 3f,
						[1202983170] = 1.5f,
						[1485010433] = 2f,
						[1980757401] = 0.8f,
						[1957897463] = 12f,
						[1242020823] = 15f,
						[1025740289] = 1f,
						[-32784135] = 1f,
						[-372722894] = 2f,
						[301365911] = 0.1f,
						[1236182680] = 1.1f,
						[-1568934921] = 7200f,
						[-1644726473] = 7200f,
						[-1863913590] = 7200f,
						[-69591182] = 7200f,
						[288650884] = 0.5f,
						[598798313] = 4f,
						[1178515572] = 0.1f,
						[-895724561] = 2.5f,
						[-1228698821] = 3f,
						[2104884190] = 2f,
						[1670924570] = 5f,
						[-1402082130] = 45f,
						[31591934] = 14f,
						[-536713174] = 3.5f,
						[-617347533] = 7.8f,
						[-1212587679] = 5f,
						[382843220] = 9f,
						[-574135336] = 2.5f,
						[1593328493] = 2.5f,
						[-970634100] = 3f,
						[-1895487398] = 4f,
						[-1384842305] = 6f,
						[-1006504748] = 7f,
						[-610093433] = 15f,
						[-2078217582] = 2.5f,
						[-1330064109] = 3f,
						[1050345517] = 15f,
						[430516423] = 5f,
						[-1347852248] = 2.5f,
						[1303130448] = 8.25f,
						[1148384259] = 4f,
						[199967204] = 1f,
						[655578962] = 2f,
						[-993971139] = 0.5f,
						[-1381686893] = 3f,
						[824723586] = 2.5f,
						[-1616350290] = 2.5f,
						[-422465852] = 60f,
						[-1054873057] = 300f,
						[1528641670] = 1f,
						[1686380967] = 12f,
						[722131933] = 0.6f,
						[2108303474] = 0.6f,
						[-1227944258] = 12f,
						[-1478879522] = 30f,
						[-2029627518] = 3f,
						[-1669787634] = 3.5f,
						[2083925528] = 4f,
						[-1543261361] = 1.6f,
						[922224629] = 1.5f,
						[1368053381] = 5f,
						[1838786050] = 3f,
						[1860312672] = 2.9f,
						[-1794356035] = 2.9f,
						[2063024278] = 0.01f,
						[-90603923] = 1.5f,
						[1014635843] = 3f,
						[-2118332423] = 3f,
						[974865294] = 6.1f,
						[1508046494] = 5f,
						[1554742526] = 3.5f,
						[948135877] = 3f,
						[1200888291] = 2.5f,
						[-1021521834] = 2.5f,
						[-2018651670] = 3f,
						[-1659518459] = 2f,
						[-1960130324] = 3f,
						[685461747] = 2f,
						[8451661] = 3f,
						[-95638559] = 300f,
						[-55837364] = 1.9f,
						[62714130] = 2.2f,
						[-2092408386] = 2.5f,
						[-865260859] = 2.2f,
						[10056680] = 2.85f,
						[-371809082] = 3f,
						[-2059726287] = 1.6f,
						[-742947136] = 6f,
						[800610886] = 4.5f
					};
					num2 = 0;
					if (760317395 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					CounterAttackGUIDs = new List<PrefabGUID>
					{
						new PrefabGUID(863435029),
						new PrefabGUID(980100276),
						new PrefabGUID(685461747),
						new PrefabGUID(1202983170),
						new PrefabGUID(842159268),
						new PrefabGUID(922224629),
						new PrefabGUID(1399619536)
					};
					num2 = 5;
					if (0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				AbilitySpeedDictionary = new Dictionary<int, float>
				{
					[1106195644] = 20f,
					[-88630604] = 16f,
					[1895752824] = 16f,
					[-518248879] = 16f,
					[-1536831420] = 20f,
					[-1997201513] = 1f,
					[-538723780] = 10f,
					[1015300268] = 28f,
					[-236936957] = 28f,
					[-504877178] = 28f,
					[-1188423561] = 28f,
					[-1555191296] = 28f,
					[13962946] = 28f,
					[45482985] = 28f,
					[1547925762] = 16f,
					[-1478907722] = 18f,
					[1492163222] = 16f,
					[-1779424390] = 24f,
					[-54449418] = 15f,
					[852775925] = 15f,
					[210911413] = 20f,
					[-97131038] = 12f,
					[245223722] = 18f,
					[-822796547] = 18f,
					[-1923988887] = 20f,
					[-571282625] = 20f,
					[1414411227] = 20f,
					[-1889498551] = 14f,
					[-1057568866] = 14f,
					[412191768] = 22f,
					[-1314000343] = 40f,
					[-1634052293] = 15f,
					[1505658358] = 15f,
					[25905050] = 14f,
					[1990270092] = 28f,
					[1919046105] = 28f,
					[-775157186] = 8f,
					[-443292115] = 24f,
					[1200039838] = 24f,
					[-1432574436] = 22f,
					[-254998690] = 22f,
					[904475242] = 3.5f,
					[-236457498] = 30f,
					[-647349550] = 20f,
					[-1869527555] = 30f,
					[133479300] = 26f,
					[1654851767] = 22f,
					[-1696574816] = 24f,
					[1568540580] = 12f,
					[1710491579] = 16f,
					[1616224499] = 25f,
					[-2133295894] = 12f,
					[-697413038] = 3.5f,
					[-2097945594] = 3.5f,
					[-89562779] = 3.5f,
					[-1793771282] = 25f,
					[24236018] = 1f,
					[1639685226] = 3.5f,
					[-2023960376] = 12f,
					[-2088525277] = 12f,
					[806308812] = 18f,
					[98245092] = 12f,
					[182162144] = 10f,
					[-1655280244] = 28f,
					[1360996740] = 22f,
					[220122942] = 22f,
					[1052376507] = 12f,
					[-831307685] = 16f,
					[1053139414] = 18f,
					[230471096] = 150f,
					[1948219540] = 32f,
					[-1500917125] = 150f,
					[2030383324] = 20f,
					[-451382874] = 50f,
					[971050267] = 5f,
					[735387572] = 32f,
					[754939425] = 32f,
					[1390292942] = 32f,
					[-547251218] = 14f,
					[-1664716277] = 5f,
					[-633627968] = 7f,
					[1359059929] = 16f,
					[9780843] = 24f,
					[-2025527763] = 15f,
					[1466221371] = 24f,
					[-1246428843] = 20f,
					[-570986876] = 28f,
					[1980757401] = 36f,
					[1236182680] = 20f,
					[1987282896] = 16f,
					[1128127702] = 40f,
					[-971002557] = 18f,
					[663997624] = 22f,
					[-1442746874] = 12f,
					[-160268834] = 150f,
					[-1862737063] = 150f,
					[1993389565] = 100f,
					[-1585538060] = 12f,
					[-569744009] = 28f,
					[-1416803366] = 28f,
					[-1128026615] = 25f,
					[2013892985] = 25f,
					[1760199795] = 25f,
					[641703489] = 9.5f,
					[1317217367] = 9f,
					[2003309778] = 9f,
					[-1489826027] = 12f,
					[-1269021822] = 12f,
					[1401891474] = 12f,
					[-604324214] = 12f,
					[1366892358] = 12f,
					[1573039480] = 12f,
					[725994358] = 10f,
					[-962223769] = 7f,
					[-1843338005] = 7f,
					[172749816] = 7f,
					[1185001957] = 10f,
					[-1638198301] = 7f,
					[-1636729042] = 7f,
					[631192081] = 7f,
					[-1650372909] = 7f,
					[-259533161] = 14f,
					[1169594249] = 20f,
					[2060866908] = 12f,
					[-41130002] = 12f,
					[-1683127942] = 20f,
					[-1877352340] = 18f,
					[588443066] = 18f,
					[-1057332181] = 20f,
					[210514978] = 24f,
					[-270716581] = 25f,
					[1122509081] = 18f,
					[-840453877] = 32f,
					[-1922271934] = 18f,
					[-1138817994] = 20f,
					[1943859459] = 20f,
					[1747170224] = 28f,
					[760468527] = 14f,
					[1130550623] = 14f,
					[1667340231] = 14f,
					[858823255] = 20f,
					[-103069801] = 13f,
					[1307917235] = 16f,
					[764115278] = 16f,
					[1850455899] = 16f,
					[1138860033] = 20f,
					[1279578598] = 20f,
					[374856501] = 11f,
					[1766367215] = 18f,
					[1245399064] = 22f,
					[-1501966038] = 18f,
					[2137346253] = 16f,
					[863095122] = 20f,
					[1624547915] = 20f,
					[286387494] = 24f,
					[-1783827601] = 24f,
					[-1246832826] = 28f,
					[1552752232] = 28f,
					[1394076868] = 28f,
					[-1684142361] = 28f,
					[-1117218632] = 28f,
					[-819536316] = 28f,
					[-2952395] = 7f,
					[829434562] = 18f,
					[-658144916] = 30f,
					[-960670153] = 12f,
					[-1206492862] = 7f,
					[1585495776] = 7f,
					[395411669] = 20f,
					[-781120203] = 20f,
					[358880096] = 30f,
					[600127133] = 24f,
					[-1771490803] = 15f,
					[-1634790827] = 15f,
					[-1387812876] = 16f,
					[1099578860] = 30f,
					[482243952] = 10f,
					[-962768798] = 10f,
					[1492118429] = 16f,
					[-1829701216] = 2f,
					[1220265215] = 2.25f,
					[-1683701733] = 24f,
					[2122566349] = 24f,
					[1582186993] = 20f,
					[591085978] = 20f,
					[109620751] = 16f,
					[-264576486] = 12f,
					[-796653678] = 12f,
					[-1692167749] = 20f,
					[1827884481] = 20f,
					[-868543514] = 20f,
					[566534594] = 8f,
					[-885632624] = 35f,
					[2005022536] = 35f,
					[-184099139] = 20f,
					[763407667] = 16f,
					[-1637124404] = 16f,
					[589619310] = 16f,
					[1461447134] = 22f,
					[-1664437676] = 22f,
					[899460111] = 22f,
					[1193324531] = 12f,
					[1410692395] = 12f,
					[672449650] = 12f,
					[-1526931129] = 12f,
					[-1135675071] = 18f,
					[779413087] = 18f,
					[1159669581] = 18f,
					[986775615] = 18f,
					[-141328123] = 12f,
					[-1188505466] = 30f,
					[-1763499516] = 22f,
					[972637370] = 20f,
					[314501028] = 18f,
					[-1319556135] = 18f,
					[685461747] = 1f,
					[624673924] = 8f,
					[-254668694] = 22f,
					[558205308] = 28f,
					[1081050588] = 28f,
					[1398193255] = 28f,
					[1364925842] = 30f,
					[-385762093] = 28f,
					[113706722] = 28f,
					[762545500] = 7f,
					[-772809527] = 26f,
					[952288992] = 26f,
					[-1340137049] = 26f,
					[1767267996] = 26f,
					[-1572309340] = 26f,
					[1987705092] = 26f,
					[1739523711] = 24f,
					[-1622040119] = 30f,
					[-31853298] = 28f,
					[601335909] = 28f,
					[-316825244] = 2f,
					[414243770] = 28f,
					[804759750] = 28f,
					[485437428] = 28f,
					[-986524867] = 28f,
					[390014348] = 150f,
					[-991602260] = 30f,
					[10056680] = 20f,
					[-489813362] = 25f,
					[-199320411] = 25f,
					[-71294147] = 25f,
					[-1789599308] = 25f,
					[-7302535] = 25f,
					[917052083] = 25f,
					[124731264] = 25f,
					[2117557264] = 25f,
					[1887484149] = 25f,
					[-83678623] = 25f,
					[1715360639] = 25f,
					[-1376420702] = 32f,
					[-2072416237] = 32f,
					[2070052426] = 25f,
					[676568621] = 25f,
					[871086568] = 25f,
					[16406835] = 40f,
					[-844027985] = 40f,
					[134028684] = 20f,
					[2115290037] = 20f,
					[190216402] = 20f,
					[800610886] = 12f,
					[-1542949990] = 35f
				};
				num2 = 1;
				if (1126510863 == 0)
				{
					num2 = 0;
				}
			}
		}

		internal static bool nPetw0IZaN5QZD2OJKK()
		{
			return DDNRVHIJSYLMCUOf5Zx == null;
		}

		internal static DictCache bGK6VPI1PGduwMWrnAW()
		{
			return DDNRVHIJSYLMCUOf5Zx;
		}
	}
	public static class ESPDrawer
	{
		private static ESPDrawer tEIrfVIFAtsvm16gabg;

		public static void Draw(Vector3 position, string label, Color color, bool useGradiant = false)
		{
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected O, but got Unknown
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			int num = 8;
			int num2 = num;
			bool flag = default(bool);
			GUIStyle val2 = default(GUIStyle);
			int num4 = default(int);
			bool flag2 = default(bool);
			float num5 = default(float);
			Vector3 val = default(Vector3);
			Vector2 val3 = default(Vector2);
			bool flag3 = default(bool);
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					return;
				case 9:
					if (flag)
					{
						num2 = 2;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 21:
					val2.fontSize = num4;
					num2 = 10;
					continue;
				case 3:
					if (flag2)
					{
						num2 = 8;
						if (0 == 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 11;
				case 13:
					num4 = 30 - (int)(num5 * 0.08f);
					num2 = 15;
					if (696790966 == 0)
					{
						num2 = 12;
					}
					continue;
				case 20:
					if (!(val.x > (float)Screen.width))
					{
						num2 = 22;
						continue;
					}
					goto IL_034e;
				case 0:
					return;
				case 14:
					return;
				case 16:
					num3 = ((!(val.y <= 0f)) ? 1 : 0);
					break;
				case 4:
					num4 = 16;
					num2 = 4;
					if (0 == 0)
					{
						num2 = 19;
					}
					continue;
				case 12:
					val2 = new GUIStyle();
					num2 = 13;
					continue;
				case 10:
					val3 = val2.CalcSize(new GUIContent(label));
					num2 = 2;
					continue;
				case 1:
					if (!flag3)
					{
						num2 = 0;
						if (1256719316 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 11:
				case 19:
					val2.normal.textColor = color;
					num2 = 16;
					if (0 == 0)
					{
						num2 = 21;
					}
					continue;
				case 5:
					flag2 = num4 <= 13;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					num5 = Vector3.Distance(position, Vector3.zero);
					num2 = 6;
					continue;
				case 17:
					if (!(val.y > (float)Screen.height))
					{
						num2 = 20;
						if (10932459 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_034e;
				case 2:
					GUI.Label(new Rect(val.x - val3.x / 2f, (float)Screen.height - val.y, val3.x, val3.y), label, val2);
					num2 = 14;
					continue;
				case 18:
					num4 = 13;
					num2 = 11;
					continue;
				case 22:
					if (!(val.x < 0f))
					{
						num2 = 16;
						continue;
					}
					goto IL_034e;
				case 6:
					if (!(val.z < 0f))
					{
						num2 = 17;
						continue;
					}
					goto IL_034e;
				case 8:
					val = Camera.main.WorldToScreenPoint(position);
					num2 = 7;
					continue;
				case 15:
					{
						flag = useGradiant;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					IL_034e:
					num3 = 0;
					break;
				}
				flag3 = (byte)num3 != 0;
				num2 = 1;
				if (0 != 0)
				{
					num2 = 1;
				}
			}
		}

		internal static bool hRy7SUIxDG4UTJPr12H()
		{
			return tEIrfVIFAtsvm16gabg == null;
		}

		internal static ESPDrawer q2JYgPIKMyShWlX0PQW()
		{
			return tEIrfVIFAtsvm16gabg;
		}
	}
	public static class InputSimulator
	{
		internal static InputSimulator ovVyDgIUPF2d6VCxvJk;

		[DllImport("user32.dll", EntryPoint = "mouse_event")]
		private static extern void RvpS0xLb3(uint P_0, uint P_1, uint P_2, uint P_3, uint P_4);

		[DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
		private static extern void BPLGJ1U25(byte P_0, byte P_1, int P_2, int P_3);

		[DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
		private static extern uint gxXw5rWvn(uint P_0, uint P_1);

		public static void LeftClick()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					RvpS0xLb3(2u, 0u, 0u, 0u, 0u);
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					RvpS0xLb3(4u, 0u, 0u, 0u, 0u);
					num2 = 2;
					if (577280904 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		public static void KeyboardPress(byte bVk)
		{
			int num = 2;
			int num2 = num;
			uint num3 = default(uint);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					BPLGJ1U25(bVk, (byte)num3, 2, 0);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					BPLGJ1U25(bVk, (byte)num3, 0, 0);
					num2 = 0;
					if (258562808 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = gxXw5rWvn(bVk, 0u);
					num2 = 1;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool nY6OypIXhGEr4lSaGZ7()
		{
			return ovVyDgIUPF2d6VCxvJk == null;
		}

		internal static InputSimulator I2AdMpIt3NNLDDSc97o()
		{
			return ovVyDgIUPF2d6VCxvJk;
		}
	}
	public static class Utils
	{
		private static Utils sVqD8WIQQnMfuTFlbk1;

		public static PrefabCollectionSystem PrefabsCollection => VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>();

		public static bool IsInView(Vector3 targetPos)
		{
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			int num = 6;
			Vector3 val = default(Vector3);
			Camera main = default(Camera);
			bool result = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 3:
						if (val.z > 0f)
						{
							num2 = 4;
							continue;
						}
						goto IL_012a;
					case 6:
						main = Camera.main;
						num2 = 5;
						if (854369382 == 0)
						{
							num2 = 4;
						}
						continue;
					case 4:
						if (val.x > 0f)
						{
							num2 = 2;
							continue;
						}
						goto IL_012a;
					case 2:
						if (val.x < 1f)
						{
							num2 = 8;
							continue;
						}
						goto IL_012a;
					case 7:
						num3 = ((val.y < 1f) ? 1 : 0);
						break;
					default:
						return result;
					case 5:
						goto end_IL_0012;
					case 8:
						{
							if (val.y > 0f)
							{
								num2 = 7;
								continue;
							}
							goto IL_012a;
						}
						IL_012a:
						num3 = 0;
						break;
					}
					result = (byte)num3 != 0;
					num2 = 0;
					if (171921593 != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				val = main.WorldToViewportPoint(targetPos);
				num = 3;
			}
		}

		internal static bool LJ3W2jIaQPCCGCyo5jb()
		{
			return sVqD8WIQQnMfuTFlbk1 == null;
		}

		internal static Utils uY3mSdIDUV1hdvfQv8a()
		{
			return sVqD8WIQQnMfuTFlbk1;
		}
	}
	public static class VWorld
	{
		private static World mpclTPEVM;

		private static VWorld NbMGdDIq7xuUBOjaMoD;

		public static bool IsReady => Client != null;

		public static World Client
		{
			get
			{
				int num = 3;
				World result = default(World);
				World val = default(World);
				bool flag = default(bool);
				bool flag2 = default(bool);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int num3;
						switch (num2)
						{
						case 13:
							result = mpclTPEVM;
							num2 = 8;
							continue;
						case 11:
							throw new Exception("Tahere is no Cklient world (yet). Dsid you iynstall a czlient mod on the seerver?");
						case 7:
							mpclTPEVM = val;
							num2 = 1;
							if (117793469 == 0)
							{
								num2 = 0;
							}
							continue;
						case 10:
							flag = val == null;
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						case 9:
							val = mo5cpjTYo("Client_0");
							num2 = 10;
							if (0 != 0)
							{
								num2 = 4;
							}
							continue;
						case 4:
						case 8:
						case 12:
							return result;
						case 5:
							if (flag2)
							{
								num2 = 13;
								continue;
							}
							goto case 9;
						case 1:
							result = mpclTPEVM;
							num2 = 4;
							continue;
						case 3:
							if (mpclTPEVM == null)
							{
								goto end_IL_0012;
							}
							goto case 6;
						case 6:
							num3 = (mpclTPEVM.IsCreated ? 1 : 0);
							break;
						default:
							if (!flag)
							{
								num2 = 7;
								continue;
							}
							goto case 11;
						case 2:
							num3 = 0;
							break;
						}
						flag2 = (byte)num3 != 0;
						num2 = 5;
						continue;
						end_IL_0012:
						break;
					}
					num = 2;
				}
			}
		}

		private static World mo5cpjTYo(object P_0)
		{
			int num = 2;
			World result = default(World);
			World val = default(World);
			Enumerator<World> enumerator = default(Enumerator<World>);
			bool flag = default(bool);
			World current = default(World);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 8:
						result = val;
						num = 6;
						break;
					case 1:
						enumerator = World.s_AllWorlds.GetEnumerator();
						num2 = 3;
						continue;
					case 7:
						if (flag)
						{
							num2 = 0;
							if (11098130 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
					case 3:
					case 4:
						if (!enumerator.MoveNext())
						{
							num = 8;
							break;
						}
						goto case 9;
					case 5:
						flag = current.Name == (string?)P_0;
						num = 7;
						break;
					case 9:
						current = enumerator.Current;
						num2 = 5;
						if (1256719316 == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						val = null;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
					case 10:
						return result;
					default:
						val = current;
						num2 = 4;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static bool eZcYxoI6jOBMb00Jy1e()
		{
			return NbMGdDIq7xuUBOjaMoD == null;
		}

		internal static VWorld MoaWN7Iudo9FBQR8wvp()
		{
			return NbMGdDIq7xuUBOjaMoD;
		}
	}
}
namespace VRisingBephinex.patch
{
	[HarmonyPatch(typeof(AbilityCastStarted_SetupAbilityTargetSystem_Shared), "OnUpdate")]
	public class AbilityCastStarted_SetupAbilityTargetSystem_SharedPatch
	{
		internal static AbilityCastStarted_SetupAbilityTargetSystem_SharedPatch hMUbb7Is6POfdUoTTIE;

		public unsafe static void Prefix(AbilityCastStarted_SetupAbilityTargetSystem_Shared __instance)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			EntityManager entityManager = ((ComponentSystemBase)__instance).EntityManager;
			EntityQuery query = __instance._Query;
			NativeArray<Entity> val = ((EntityQuery)(ref query)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
			try
			{
				Enumerator<Entity> enumerator = val.GetEnumerator();
				PlayerCharacter val2 = default(PlayerCharacter);
				while (enumerator.MoveNext())
				{
					Entity current = enumerator.Current;
					if (!((EntityManager)(ref entityManager)).Exists(current) || !((EntityManager)(ref entityManager)).HasComponent<AbilityCastStartedEvent>(current))
					{
						continue;
					}
					AbilityCastStartedEvent componentData = ((EntityManager)(ref entityManager)).GetComponentData<AbilityCastStartedEvent>(current);
					PrefabGUID componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(componentData.Ability);
					AbilityDescription ability = AbilityDatabase.GetAbility(componentData2._Value);
					if (ability == null)
					{
						continue;
					}
					Entity character = componentData.Character;
					DefenceComponent.Instance.OnAbilitCast(character, ability);
					if (!((EntityManager)(ref entityManager)).TryGetComponentData<PlayerCharacter>(character, ref val2))
					{
						continue;
					}
					string playerName = ((object)(*(FixedString64Bytes*)(&val2.Name))/*cast due to .constrained prefix*/).ToString();
					PlayerWrapper? mainPlayer = PlayersManager.Instance.MainPlayer;
					if (mainPlayer != null && mainPlayer.Entity == character)
					{
						AimbotComponent.Instance.ProjectileSpeed = ability.Speed;
						if (!ability.IsAoE && !ability.IsDefence && !ability.IsDash && !ability.IsUltimate)
						{
							AimbotComponent.Instance.AbilityCastingTime += ability.MaxCastTime;
							Plugin.LogInfo("Added ability cast time");
						}
					}
					PlayersManager.Instance.AddPlayerCooldown(playerName, componentData2, ability);
					if (ability.IsDefence)
					{
						PlayersManager.Instance.AddPlayerProtectionTime(playerName, ability.LifeTimeDuration);
					}
				}
			}
			finally
			{
				val.Dispose();
			}
		}

		public AbilityCastStarted_SetupAbilityTargetSystem_SharedPatch()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (760317395 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool vf7N7dIPc6u7rpqhoOA()
		{
			return hMUbb7Is6POfdUoTTIE == null;
		}

		internal static AbilityCastStarted_SetupAbilityTargetSystem_SharedPatch sJNYRDIkwrSKX1WKeWq()
		{
			return hMUbb7Is6POfdUoTTIE;
		}
	}
	[HarmonyPatch(typeof(AbilityInputSystem), "OnUpdate")]
	public class AbilityInputSystemPatch
	{
		internal static AbilityInputSystemPatch oguIuTITSDCLNJlrqnS;

		public static bool Prefix(AbilityInputSystem __instance)
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 3:
				case 4:
					return result;
				default:
					num3 = 1;
					break;
				case 1:
					if (!AimbotComponent.Instance.AimbotDisableInputOnEnemyCounter)
					{
						num2 = 0;
						if (1793150317 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 5:
				{
					AimbotComponent instance = AimbotComponent.Instance;
					if (instance == null)
					{
						num2 = 2;
						if (1126510863 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (instance.IsTargetBlocking)
					{
						num3 = 0;
						break;
					}
					goto case 2;
				}
				case 2:
					num2 = 6;
					continue;
				}
				result = (byte)num3 != 0;
				num2 = 2;
				if (0 == 0)
				{
					num2 = 3;
				}
			}
		}

		public AbilityInputSystemPatch()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ydcfNlIz0NyhKWMOcd0()
		{
			return oguIuTITSDCLNJlrqnS == null;
		}

		internal static AbilityInputSystemPatch c46QnmegCkEcBndJ7u6()
		{
			return oguIuTITSDCLNJlrqnS;
		}
	}
	[HarmonyPatch(typeof(BuffSystem_Spawn_Client), "OnUpdate")]
	public class BuffSystem_Spawn_ClientPatch
	{
		private static PrefabGUID AU3WkowjM;

		private static PrefabGUID UA6BQQALc;

		private static BuffSystem_Spawn_ClientPatch t7yMnxenxwqtCWNknVB;

		[HarmonyPostfix]
		public static void Postfix(BuffSystem_Spawn_Client __instance)
		{
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			int num2 = num;
			Entity current = default(Entity);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			EntityQuery query = default(EntityQuery);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool isEmpty = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 7:
					current = enumerator.Current;
					num2 = 12;
					break;
				case 3:
					return;
				case 11:
					return;
				case 12:
					S9XfIwhV0(current);
					num2 = 4;
					break;
				case 10:
					query = __instance._Query;
					num2 = 9;
					break;
				default:
					val = ((EntityQuery)(ref query)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
					num2 = 2;
					break;
				case 9:
					isEmpty = ((EntityQuery)(ref query)).IsEmpty;
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
				case 5:
					if (!enumerator.MoveNext())
					{
						num2 = 1;
						if (1433983997 != 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 7;
				case 6:
				case 8:
					query = __instance._Query;
					num2 = 0;
					if (1435992043 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (isEmpty)
					{
						return;
					}
					num2 = 8;
					break;
				case 2:
					enumerator = val.GetEnumerator();
					num2 = 5;
					if (1414824122 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private static void S9XfIwhV0(Entity P_0)
		{
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0420: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			int num = 12;
			bool flag4 = default(bool);
			PrefabGUID componentData = default(PrefabGUID);
			bool flag9 = default(bool);
			Attach componentData4 = default(Attach);
			bool flag8 = default(bool);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			bool flag7 = default(bool);
			PrefabGUID componentData2 = default(PrefabGUID);
			bool flag2 = default(bool);
			Entity owner = default(Entity);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			EntityOwner componentData3 = default(EntityOwner);
			bool flag = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 36:
						flag4 = componentData != AU3WkowjM;
						num2 = 5;
						if (0 == 0)
						{
							num2 = 32;
						}
						continue;
					case 35:
						return;
					case 15:
					case 16:
						flag9 = componentData4.Parent == Entity.Null;
						num2 = 31;
						if (2144623378 == 0)
						{
							num2 = 24;
						}
						continue;
					case 18:
						if (flag8)
						{
							num2 = 29;
							continue;
						}
						goto case 3;
					case 32:
						if (!flag4)
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						return;
					case 22:
						return;
					case 34:
						if (mainPlayer == null)
						{
							num2 = 20;
							continue;
						}
						goto case 30;
					case 1:
					case 23:
						flag7 = !P_0.TryGetComponent<PrefabGUID>(out componentData2);
						num = 4;
						break;
					case 7:
						InputSimulator.LeftClick();
						num = 24;
						break;
					case 14:
						if (flag2)
						{
							num2 = 19;
							continue;
						}
						goto case 36;
					case 33:
						return;
					case 4:
						if (!flag7)
						{
							num2 = 0;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 31:
						if (flag9)
						{
							return;
						}
						num2 = 27;
						if (1976142266 == 0)
						{
							num2 = 2;
						}
						continue;
					case 5:
						return;
					case 9:
						return;
					case 19:
						return;
					case 24:
						return;
					case 25:
						return;
					case 29:
						return;
					case 37:
						return;
					case 28:
					{
						flag8 = !owner.TryGetComponent<PlayerCharacter>(out PlayerCharacter _);
						num2 = 18;
						continue;
					}
					case 3:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num2 = 28;
						if (0 == 0)
						{
							num2 = 34;
						}
						continue;
					case 30:
						num3 = ((mainPlayer.Entity != owner) ? 1 : 0);
						goto IL_048c;
					case 13:
						if (flag5)
						{
							num2 = 35;
							continue;
						}
						goto case 6;
					case 2:
					case 27:
						flag2 = !componentData4.Parent.TryGetComponent<PrefabGUID>(out componentData);
						num2 = 8;
						if (171252512 != 0)
						{
							num2 = 14;
						}
						continue;
					case 12:
						flag6 = !P_0.TryGetComponent<Attach>(out componentData4);
						num2 = 11;
						continue;
					case 11:
						if (flag6)
						{
							return;
						}
						num2 = 15;
						continue;
					case 8:
					case 21:
						owner = componentData3.Owner;
						num2 = 28;
						if (1094201023 == 0)
						{
							num2 = 14;
						}
						continue;
					case 6:
						flag = !P_0.TryGetComponent<EntityOwner>(out componentData3);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 17;
						}
						continue;
					default:
						flag5 = componentData2 != UA6BQQALc;
						num2 = 13;
						continue;
					case 10:
						if (flag3)
						{
							num2 = 37;
							continue;
						}
						goto case 7;
					case 17:
						if (flag)
						{
							return;
						}
						num2 = 8;
						continue;
					case 20:
						{
							num3 = 1;
							goto IL_048c;
						}
						IL_048c:
						flag3 = (byte)num3 != 0;
						num2 = 10;
						if (2058589287 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					break;
				}
			}
		}

		public BuffSystem_Spawn_ClientPatch()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (55114885 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static BuffSystem_Spawn_ClientPatch()
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					AU3WkowjM = new PrefabGUID(1559481073);
					num2 = 1;
					if (0 != 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return;
				case 4:
					jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
					num2 = 0;
					if (1531368356 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					UA6BQQALc = new PrefabGUID(1753229314);
					num2 = 2;
					break;
				}
			}
		}

		internal static bool eFfbSDeO0vhOfmwZ7nO()
		{
			return t7yMnxenxwqtCWNknVB == null;
		}

		internal static BuffSystem_Spawn_ClientPatch luTQ86e385dbZJMMD7q()
		{
			return t7yMnxenxwqtCWNknVB;
		}
	}
	[HarmonyPatch(typeof(SendUserInputSystem), "OnUpdate")]
	public class SendUserInputSystemPatch
	{
		public static int Test;

		public static byte[] DiffArray;

		private static bool mIM5TOlB0;

		private static SendUserInputSystemPatch cZ4h29eo47u54YY5c3J;

		public static bool Prefix(SendUserInputSystem __instance)
		{
			int num = 2;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 2:
					result = true;
					num2 = 1;
					if (0 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public static string KeyPressedLog()
		{
			int num = 11;
			string result = default(string);
			string text = default(string);
			bool key2 = default(bool);
			bool key4 = default(bool);
			bool key3 = default(bool);
			bool key = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						result = text.Trim();
						num2 = 6;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 10:
						key2 = Input.GetKey((KeyCode)119);
						num2 = 3;
						continue;
					case 9:
						key4 = Input.GetKey((KeyCode)115);
						num2 = 16;
						if (0 != 0)
						{
							num2 = 14;
						}
						continue;
					case 16:
						if (!key4)
						{
							num2 = 2;
							if (0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 6:
					case 15:
						return result;
					case 3:
						if (key2)
						{
							num2 = 4;
							if (1668386183 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto end_IL_0012;
					case 11:
						text = string.Empty;
						num2 = 10;
						continue;
					case 14:
						text += "D ";
						num2 = 4;
						if (348513258 != 0)
						{
							num2 = 5;
						}
						continue;
					case 1:
						if (key3)
						{
							num2 = 14;
							continue;
						}
						goto case 5;
					case 7:
						text += "A ";
						num2 = 9;
						continue;
					default:
						goto end_IL_0012;
					case 4:
						text += "W ";
						num2 = 0;
						if (2035096834 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
					case 8:
						key3 = Input.GetKey((KeyCode)100);
						num2 = 1;
						if (1629830925 == 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						if (key)
						{
							num2 = 7;
							continue;
						}
						goto case 9;
					case 12:
						break;
					}
					text += "S ";
					num2 = 8;
					continue;
					end_IL_0012:
					break;
				}
				key = Input.GetKey((KeyCode)97);
				num = 13;
			}
		}

		public static short ReadShortLittleEndian(byte[] buffer, int index)
		{
			int num = 5;
			int num2 = num;
			short result = default(short);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = 0;
					num2 = 6;
					if (0 != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					flag = index + 1 >= buffer.Length;
					num2 = 1;
					if (468683115 != 0)
					{
						num2 = 4;
					}
					continue;
				default:
					return result;
				case 4:
					if (flag)
					{
						num2 = 1;
						if (1976142266 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					break;
				}
				result = (short)((buffer[index + 1] << 8) | buffer[index]);
				num2 = 1;
				if (1890823438 != 0)
				{
					num2 = 2;
				}
			}
		}

		public static short ReadShortBigEndian(byte[] buffer, int index)
		{
			int num = 6;
			int num2 = num;
			short result = default(short);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					result = (short)((buffer[index] << 8) | buffer[index + 1]);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if (!flag)
					{
						num2 = 2;
						break;
					}
					goto case 7;
				case 6:
					flag = index + 1 >= buffer.Length;
					num2 = 5;
					break;
				case 7:
					result = 0;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
				case 3:
				case 4:
					return result;
				}
			}
		}

		public static float FixedPointQ1_15(short value)
		{
			int num = 1;
			int num2 = num;
			float result = default(float);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = (float)value / 32768f;
					num2 = 0;
					if (818312125 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public static int ReadIntLittleEndian(byte[] buffer, int index)
		{
			int num = 1;
			bool flag = default(bool);
			int result = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						flag = index + 3 >= buffer.Length;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						result = buffer[index] | (buffer[index + 1] << 8) | (buffer[index + 2] << 16) | (buffer[index + 3] << 24);
						num2 = 2;
						if (1629830925 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						if (flag)
						{
							goto end_IL_0012;
						}
						goto case 4;
					case 2:
					case 3:
					case 5:
						return result;
					case 6:
						result = 0;
						num2 = 5;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 6;
			}
		}

		public static int ReadIntBigEndian(byte[] buffer, int index)
		{
			int num = 2;
			int num2 = num;
			int result = default(int);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 7:
					result = (buffer[index] << 24) | (buffer[index + 1] << 16) | (buffer[index + 2] << 8) | buffer[index + 3];
					num2 = 0;
					if (117793469 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (!flag)
					{
						num2 = 0;
						if (247204215 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					break;
				default:
					return result;
				case 2:
					flag = index + 3 >= buffer.Length;
					num2 = 0;
					if (1268266038 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					break;
				}
				result = 0;
				num2 = 5;
			}
		}

		public static float ReadFloatLittleEndian(byte[] buffer, int index)
		{
			int num = 6;
			float result = default(float);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 2:
					case 3:
						result = BitConverter.ToSingle(buffer, index);
						num2 = 7;
						if (374085082 == 0)
						{
							num2 = 2;
						}
						continue;
					case 6:
						break;
					case 4:
						result = 0f;
						num2 = 0;
						if (1433983997 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						if (!flag)
						{
							num2 = 3;
							continue;
						}
						goto case 4;
					}
					break;
				}
				flag = index + 3 >= buffer.Length;
				num = 5;
			}
		}

		public static float ReadFloatBigEndian(byte[] buffer, int index)
		{
			int num = 1;
			int num2 = num;
			byte[] value = default(byte[]);
			bool flag = default(bool);
			float result = default(float);
			while (true)
			{
				switch (num2)
				{
				case 3:
					value = new byte[4]
					{
						buffer[index + 3],
						buffer[index + 2],
						buffer[index + 1],
						buffer[index]
					};
					num2 = 0;
					if (0 == 0)
					{
						num2 = 6;
					}
					break;
				case 1:
					flag = index + 3 >= buffer.Length;
					num2 = 0;
					if (348513258 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					result = BitConverter.ToSingle(value, 0);
					num2 = 4;
					if (1414824122 != 0)
					{
						num2 = 4;
					}
					break;
				default:
					if (flag)
					{
						num2 = 7;
						break;
					}
					goto case 3;
				case 2:
				case 4:
				case 5:
					return result;
				case 7:
					result = 0f;
					num2 = 2;
					if (0 == 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		}

		public static void DecodeAllTypesAdvanced(byte[] buffer)
		{
			int num = 65;
			int num5 = default(int);
			int num4 = default(int);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			bool flag5 = default(bool);
			float value = default(float);
			int num3 = default(int);
			float num6 = default(float);
			bool flag10 = default(bool);
			float num8 = default(float);
			bool flag7 = default(bool);
			short num7 = default(short);
			short num9 = default(short);
			bool flag2 = default(bool);
			bool flag11 = default(bool);
			float value2 = default(float);
			bool flag9 = default(bool);
			bool flag8 = default(bool);
			bool flag = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag6 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num10;
					int num11;
					switch (num2)
					{
					case 14:
						num5 = ReadIntLittleEndian(buffer, num4);
						num2 = 19;
						continue;
					case 43:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 99;
						continue;
					case 18:
						flag5 = Math.Abs(value) > 0.0001f;
						num2 = 10;
						if (10932459 == 0)
						{
							num2 = 7;
						}
						continue;
					case 15:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 40;
						continue;
					case 50:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 96;
						continue;
					case 7:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num = 24;
						break;
					case 31:
						defaultInterpolatedStringHandler.AppendFormatted(num3);
						num2 = 94;
						continue;
					case 54:
						num10 = ((Math.Abs(num6) < 1000000f) ? 1 : 0);
						goto IL_0e44;
					case 16:
					case 59:
						if (float.IsNaN(num6))
						{
							num2 = 39;
							if (171921593 != 0)
							{
								num2 = 52;
							}
							continue;
						}
						goto case 70;
					case 99:
						defaultInterpolatedStringHandler.AppendLiteral("] FixedPoint Q1.15 BE: ");
						num2 = 44;
						continue;
					case 67:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 88;
						continue;
					case 29:
						if (!flag10)
						{
							num2 = 16;
							continue;
						}
						goto case 62;
					case 21:
						if (!float.IsInfinity(num8))
						{
							num2 = 93;
							continue;
						}
						goto IL_0e36;
					case 47:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 8;
						continue;
					case 40:
					case 41:
						flag7 = num7 != 0;
						num2 = 78;
						continue;
					case 89:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 45;
						if (374085082 == 0)
						{
							num2 = 21;
						}
						continue;
					case 13:
						num9 = ReadShortLittleEndian(buffer, num4);
						num2 = 73;
						continue;
					case 28:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						num2 = 37;
						continue;
					case 74:
						num6 = ReadFloatBigEndian(buffer, num4);
						num2 = 49;
						continue;
					case 9:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num2 = 51;
						continue;
					case 73:
						num7 = ReadShortBigEndian(buffer, num4);
						num2 = 1;
						if (1629830925 != 0)
						{
							num2 = 1;
						}
						continue;
					case 33:
						defaultInterpolatedStringHandler.AppendFormatted(num6, "F6");
						num2 = 48;
						continue;
					case 34:
						flag2 = num5 != 0;
						num = 3;
						break;
					case 71:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 90;
						continue;
					case 90:
						value = FixedPointQ1_15(num9);
						num2 = 17;
						continue;
					case 97:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 59;
						continue;
					case 2:
						num11 = ((Math.Abs(num8) < 1000000f) ? 1 : 0);
						goto IL_0e37;
					case 37:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num2 = 67;
						continue;
					case 78:
						if (flag7)
						{
							num2 = 69;
							continue;
						}
						goto case 90;
					case 23:
						defaultInterpolatedStringHandler.AppendFormatted(num9);
						num2 = 15;
						continue;
					case 88:
						defaultInterpolatedStringHandler.AppendLiteral("] FixedPoint Q1.15 LE: ");
						num2 = 76;
						continue;
					case 64:
						num4 = 0;
						num2 = 91;
						if (0 == 0)
						{
							num2 = 91;
						}
						continue;
					case 62:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 32;
						if (0 != 0)
						{
							num2 = 11;
						}
						continue;
					case 87:
						if (Math.Abs(num6) > 0.0001f)
						{
							num2 = 54;
							if (468683115 == 0)
							{
								num2 = 32;
							}
							continue;
						}
						goto case 52;
					case 57:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 86;
						if (0 != 0)
						{
							num2 = 21;
						}
						continue;
					case 51:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 82;
						continue;
					case 3:
						if (!flag2)
						{
							num2 = 53;
							continue;
						}
						goto case 89;
					case 83:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 0;
						if (1835701918 != 0)
						{
							num2 = 12;
						}
						continue;
					case 68:
						defaultInterpolatedStringHandler.AppendFormatted(num8, "F6");
						num2 = 97;
						continue;
					case 93:
						if (Math.Abs(num8) > 0.0001f)
						{
							num2 = 2;
							if (962215133 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto IL_0e36;
					case 61:
					case 79:
						flag11 = Math.Abs(value2) > 0.0001f;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 6;
						}
						continue;
					case 24:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 42;
						continue;
					case 92:
						defaultInterpolatedStringHandler.AppendLiteral("] Float BE: ");
						num2 = 33;
						continue;
					case 46:
						if (!flag9)
						{
							num = 26;
							break;
						}
						goto case 83;
					case 56:
						defaultInterpolatedStringHandler.AppendFormatted(num7);
						num2 = 60;
						if (0 == 0)
						{
							num2 = 71;
						}
						continue;
					case 17:
						value2 = FixedPointQ1_15(num7);
						num = 18;
						break;
					case 49:
						if (!float.IsNaN(num8))
						{
							num = 21;
							break;
						}
						goto IL_0e36;
					case 6:
						if (!flag11)
						{
							num2 = 60;
							if (247204215 == 0)
							{
								num2 = 49;
							}
							continue;
						}
						goto case 22;
					case 27:
						return;
					case 75:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 92;
						if (0 != 0)
						{
							num2 = 20;
						}
						continue;
					case 69:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 7;
						continue;
					case 53:
					case 98:
						flag8 = num3 != 0;
						num2 = 66;
						continue;
					case 44:
						defaultInterpolatedStringHandler.AppendFormatted(value2, "F6");
						num2 = 25;
						continue;
					default:
						num4++;
						num2 = 63;
						if (962215133 == 0)
						{
							num2 = 55;
						}
						continue;
					case 86:
						defaultInterpolatedStringHandler.AppendLiteral("] Float LE: ");
						num2 = 68;
						if (171921593 == 0)
						{
							num2 = 17;
						}
						continue;
					case 82:
						defaultInterpolatedStringHandler.AppendLiteral("] Int32 BE: ");
						num2 = 31;
						if (1126510863 == 0)
						{
							num2 = 16;
						}
						continue;
					case 84:
						flag = num4 + 1 < buffer.Length;
						num2 = 81;
						continue;
					case 12:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num = 75;
						break;
					case 11:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num = 43;
						break;
					case 66:
						if (!flag8)
						{
							num2 = 20;
							continue;
						}
						goto case 5;
					case 60:
					case 85:
						flag3 = num4 + 3 < buffer.Length;
						num2 = 58;
						if (2058589287 == 0)
						{
							num2 = 30;
						}
						continue;
					case 25:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 85;
						continue;
					case 22:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
						num2 = 11;
						continue;
					case 4:
					{
						byte b = buffer[num4];
						num2 = 84;
						continue;
					}
					case 39:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 98;
						continue;
					case 80:
						if (!flag4)
						{
							num2 = 41;
							continue;
						}
						goto case 47;
					case 63:
					case 91:
						flag6 = num4 < 129;
						num2 = 36;
						continue;
					case 95:
						defaultInterpolatedStringHandler.AppendFormatted(num5);
						num2 = 31;
						if (133732588 != 0)
						{
							num2 = 39;
						}
						continue;
					case 8:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num2 = 50;
						continue;
					case 36:
						if (!flag6)
						{
							num2 = 27;
							if (460822775 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 4;
					case 96:
						defaultInterpolatedStringHandler.AppendLiteral("] Short LE: ");
						num2 = 23;
						continue;
					case 65:
						Console.WriteLine("--- Advanced Universal Decoder Output ---");
						num2 = 64;
						if (1486210346 == 0)
						{
							num2 = 18;
						}
						continue;
					case 48:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 0;
						if (55114885 != 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						if (!flag5)
						{
							num2 = 61;
							if (460822775 == 0)
							{
								num2 = 57;
							}
							continue;
						}
						goto case 28;
					case 1:
						flag4 = num9 != 0;
						num2 = 80;
						continue;
					case 45:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num2 = 77;
						continue;
					case 20:
					case 38:
						num8 = ReadFloatLittleEndian(buffer, num4);
						num2 = 74;
						continue;
					case 32:
						defaultInterpolatedStringHandler.AppendLiteral("[Index ");
						num2 = 57;
						continue;
					case 94:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 38;
						continue;
					case 77:
						defaultInterpolatedStringHandler.AppendFormatted(num4);
						num2 = 30;
						continue;
					case 58:
						if (!flag3)
						{
							num2 = 20;
							if (0 == 0)
							{
								num2 = 35;
							}
							continue;
						}
						goto case 14;
					case 5:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
						num2 = 9;
						continue;
					case 19:
						num3 = ReadIntBigEndian(buffer, num4);
						num2 = 24;
						if (818312125 != 0)
						{
							num2 = 34;
						}
						continue;
					case 42:
						defaultInterpolatedStringHandler.AppendLiteral("] Short BE: ");
						num2 = 56;
						continue;
					case 81:
						if (flag)
						{
							num2 = 13;
							continue;
						}
						goto case 60;
					case 76:
						defaultInterpolatedStringHandler.AppendFormatted(value, "F6");
						num = 72;
						break;
					case 72:
						Console.WriteLine(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 79;
						continue;
					case 30:
						defaultInterpolatedStringHandler.AppendLiteral("] Int32 LE: ");
						num2 = 95;
						continue;
					case 70:
						if (float.IsInfinity(num6))
						{
							num = 55;
							break;
						}
						goto case 87;
					case 52:
					case 55:
						{
							num10 = 0;
							goto IL_0e44;
						}
						IL_0e44:
						flag9 = (byte)num10 != 0;
						num2 = 46;
						continue;
						IL_0e36:
						num11 = 0;
						goto IL_0e37;
						IL_0e37:
						flag10 = (byte)num11 != 0;
						num2 = 29;
						continue;
					}
					break;
				}
			}
		}

		public SendUserInputSystemPatch()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static SendUserInputSystemPatch()
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 5:
						mIM5TOlB0 = false;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					case 4:
						DiffArray = new byte[100000];
						num2 = 0;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
					case 3:
						jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
				Test = 81;
				num = 4;
			}
		}

		internal static bool jC7hZleyG9NPirnwEXr()
		{
			return cZ4h29eo47u54YY5c3J == null;
		}

		internal static SendUserInputSystemPatch FqFS5pe4d1o68BbGgwW()
		{
			return cZ4h29eo47u54YY5c3J;
		}
	}
}
namespace VRisingBephinex.gui
{
	public class AimbotMenu : GUIMenu
	{
		private static AimbotMenu xdECQueI4tw9yMokPdB;

		public AimbotMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("Aimbot Menu", 2);
			int num = 8;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 8:
						_items.Add(new GUIItem("Enabled", AimbotComponent.Instance.Enabled, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.Enabled = value;
									num4 = 0;
									if (0 != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 4;
						continue;
					case 4:
						_items.Add(new GUIItem("NPC", AimbotComponent.Instance.NPC, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.NPC = value;
									num4 = 0;
									if (0 == 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 9;
						continue;
					case 9:
						_items.Add(new GUIItem("Players", AimbotComponent.Instance.Players, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.Players = value;
									num4 = 0;
									if (818312125 == 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num = 6;
						break;
					case 6:
						_items.Add(new GUIItem("Sort By HP", AimbotComponent.Instance.SortByHP, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.SortByHP = value;
									num4 = 0;
									if (0 != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num = 12;
						break;
					case 12:
						_items.Add(new GUIItem("Holding Key", AimbotComponent.Instance.AimbotToggleHolding, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.AimbotToggleHolding = value;
									num4 = 0;
									if (519538535 != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 5;
						continue;
					case 5:
						_items.Add(new GUIItem("Check Enemy Counter", AimbotComponent.Instance.CheckEnemyCounter, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									AimbotComponent.Instance.CheckEnemyCounter = value;
									num4 = 0;
									if (1435992043 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
						num2 = 7;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 7:
						_items.Add(new GUIItem("On Counter - Cancel", AimbotComponent.Instance.AimbotCheckEnemyCounterCancelAttack, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									AimbotComponent.Instance.AimbotCheckEnemyCounterCancelAttack = value;
									num4 = 0;
									if (1814018247 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
						num2 = 0;
						if (117793469 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						_items.Add(new GUIItem("On Counter - Move Cursor", AimbotComponent.Instance.AimbotCheckEnemyCounterMoveCursor, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									AimbotComponent.Instance.AimbotCheckEnemyCounterMoveCursor = value;
									num4 = 0;
									if (0 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
						num2 = 3;
						continue;
					case 3:
						_items.Add(new GUIItem("Disable Input on Counter", AimbotComponent.Instance.AimbotDisableInputOnEnemyCounter, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									AimbotComponent.Instance.AimbotDisableInputOnEnemyCounter = value;
									num4 = 0;
									if (2144623378 != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
						num = 13;
						break;
					case 13:
						_items.Add(new GUIItem("Lock On Target", AimbotComponent.Instance.LockOnTarget, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.LockOnTarget = value;
									num4 = 0;
									if (374085082 != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 1;
						if (2021314568 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						_items.Add(new GUIItem("Distance From Cursor", AimbotComponent.Instance.AimbotCursor, delegate(bool value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.AimbotCursor = value;
									num4 = 0;
									if (0 != 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 11;
						continue;
					case 11:
						_items.Add(new GUIItem("Max Distance", delegate
						{
							int num3 = 2;
							int num4 = num3;
							float maxDistance = default(float);
							string result = default(string);
							while (true)
							{
								object obj;
								switch (num4)
								{
								case 2:
									maxDistance = AimbotComponent.Instance.MaxDistance;
									num4 = 0;
									if (0 == 0)
									{
										num4 = 1;
									}
									continue;
								case 3:
								case 4:
									return result;
								case 1:
									obj = maxDistance.ToString("0.00");
									if (obj == null)
									{
										num4 = 0;
										if (0 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									break;
								default:
									obj = "";
									break;
								}
								result = (string)obj;
								num4 = 3;
							}
						}));
						num = 10;
						break;
					case 10:
						_items.Add(new GUIItem("", AimbotComponent.Instance.MaxDistance, 0f, 30f, delegate(float value)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									return;
								case 1:
									AimbotComponent.Instance.MaxDistance = value;
									num4 = 0;
									if (468683115 == 0)
									{
										num4 = 0;
									}
									break;
								case 0:
									return;
								}
							}
						}));
						num2 = 2;
						continue;
					}
					break;
				}
			}
		}

		internal static bool KIrZd9eeiSCWycO4FFi()
		{
			return xdECQueI4tw9yMokPdB == null;
		}

		internal static AimbotMenu iNPYX0eRJrm86ACyUt0()
		{
			return xdECQueI4tw9yMokPdB;
		}
	}
	public enum GUIItemType
	{
		Button,
		Input,
		CheckBox,
		Label,
		TextBox
	}
	public class GUIItem
	{
		private string qYV2Rw3GK;

		private GUIItemType yTkMvD56T;

		private Rect kOWhJVTtt;

		private Action V6Yv4tLYl;

		private Action<bool> T0OLJP2uy;

		private Action<float> M590vtaRj;

		private Action<string> XU7Vb6ftu;

		private bool YMhH73Thc;

		private Func<string> t1I9Znk2q;

		private float EfxNqyxYl;

		private string Od9j7lKVn;

		private float Ny0djtJF4;

		private float Bta8OWvUH;

		private static GUIItem Ydhyh4ei9etPYtr4G5Y;

		public GUIItem(string name, Action action = null)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			kOWhJVTtt = new Rect(0f, 0f, 0f, 0f);
			Od9j7lKVn = string.Empty;
			base..ctor();
			int num = 0;
			if (0 == 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					V6Yv4tLYl = action;
					num = 1;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				case 2:
					qYV2Rw3GK = name;
					num = 3;
					if (0 != 0)
					{
						num = 3;
					}
					break;
				case 3:
					yTkMvD56T = GUIItemType.Button;
					num = 0;
					if (1848937442 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public GUIItem(string name, bool value, Action<bool> actionBoolean)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			kOWhJVTtt = new Rect(0f, 0f, 0f, 0f);
			Od9j7lKVn = string.Empty;
			base..ctor();
			int num = 0;
			if (0 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					T0OLJP2uy = actionBoolean;
					num = 0;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				case 3:
					yTkMvD56T = GUIItemType.CheckBox;
					num = 4;
					break;
				default:
					qYV2Rw3GK = name;
					num = 3;
					break;
				case 4:
					YMhH73Thc = value;
					num = 2;
					break;
				}
			}
		}

		public GUIItem(string name, Func<string> getStringValueFunk)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			kOWhJVTtt = new Rect(0f, 0f, 0f, 0f);
			Od9j7lKVn = string.Empty;
			base..ctor();
			int num = 0;
			if (1518457776 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 3:
					t1I9Znk2q = getStringValueFunk;
					num = 2;
					break;
				default:
					yTkMvD56T = GUIItemType.Label;
					num = 2;
					if (0 == 0)
					{
						num = 3;
					}
					break;
				case 1:
					qYV2Rw3GK = name;
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		public GUIItem(string name, float value, float min, float max, Action<float> actionFloat)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			kOWhJVTtt = new Rect(0f, 0f, 0f, 0f);
			Od9j7lKVn = string.Empty;
			base..ctor();
			int num = 1;
			if (742265667 != 0)
			{
				num = 6;
			}
			while (true)
			{
				switch (num)
				{
				case 5:
					return;
				case 4:
					Bta8OWvUH = max;
					num = 3;
					break;
				case 1:
					yTkMvD56T = GUIItemType.Input;
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					break;
				case 6:
					qYV2Rw3GK = name;
					num = 0;
					if (852228814 != 0)
					{
						num = 1;
					}
					break;
				case 2:
					Ny0djtJF4 = min;
					num = 4;
					break;
				case 3:
					M590vtaRj = actionFloat;
					num = 1;
					if (1131787544 != 0)
					{
						num = 5;
					}
					break;
				default:
					EfxNqyxYl = value;
					num = 2;
					break;
				}
			}
		}

		public GUIItem(string name, string value, Action<string> actionString)
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			kOWhJVTtt = new Rect(0f, 0f, 0f, 0f);
			Od9j7lKVn = string.Empty;
			base..ctor();
			int num = 3;
			if (1256719316 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					XU7Vb6ftu = actionString;
					num = 0;
					if (317387702 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					yTkMvD56T = GUIItemType.TextBox;
					num = 1;
					if (121889664 == 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				case 3:
					qYV2Rw3GK = name;
					num = 2;
					break;
				case 1:
					Od9j7lKVn = value;
					num = 4;
					if (2035096834 == 0)
					{
						num = 3;
					}
					break;
				}
			}
		}

		public void UpdateRect(Rect rect)
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					kOWhJVTtt = rect;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Draw()
		{
			//IL_043a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			int num = 23;
			float efxNqyxYl = default(float);
			bool flag3 = default(bool);
			bool flag5 = default(bool);
			bool flag = default(bool);
			GUIItemType gUIItemType = default(GUIItemType);
			GUIItemType gUIItemType2 = default(GUIItemType);
			string od9j7lKVn = default(string);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			bool yMhH73Thc = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return;
					case 20:
						efxNqyxYl = EfxNqyxYl;
						num2 = 26;
						continue;
					case 14:
						return;
					case 26:
						EfxNqyxYl = GUI.HorizontalSlider(kOWhJVTtt, EfxNqyxYl, Ny0djtJF4, Bta8OWvUH);
						num = 15;
						break;
					case 3:
						M590vtaRj(EfxNqyxYl);
						num2 = 8;
						continue;
					case 31:
						return;
					case 35:
						return;
					case 10:
						return;
					case 32:
						return;
					case 21:
						return;
					case 15:
						flag3 = efxNqyxYl != EfxNqyxYl;
						num2 = 1;
						if (348513258 != 0)
						{
							num2 = 2;
						}
						continue;
					case 16:
						goto IL_01de;
					case 8:
						return;
					case 18:
						if (!flag5)
						{
							return;
						}
						num2 = 25;
						continue;
					case 17:
						return;
					case 28:
					case 33:
						GUI.Label(kOWhJVTtt, "");
						num2 = 3;
						if (348513258 != 0)
						{
							num2 = 10;
						}
						continue;
					case 29:
						goto IL_0285;
					case 19:
						YMhH73Thc = GUI.Toggle(kOWhJVTtt, YMhH73Thc, qYV2Rw3GK);
						num2 = 12;
						continue;
					case 9:
						T0OLJP2uy(YMhH73Thc);
						num2 = 4;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 27:
						if (!flag)
						{
							num2 = 28;
							continue;
						}
						goto default;
					case 2:
						if (!flag3)
						{
							return;
						}
						num2 = 3;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 30:
						goto IL_034d;
					case 34:
						switch (gUIItemType)
						{
						case GUIItemType.Input:
							break;
						case GUIItemType.Label:
							goto IL_01de;
						case GUIItemType.TextBox:
							goto IL_0285;
						case GUIItemType.CheckBox:
							goto IL_034d;
						default:
							goto IL_037f;
						case GUIItemType.Button:
							goto IL_0494;
						}
						goto case 20;
					case 23:
						gUIItemType2 = yTkMvD56T;
						num2 = 22;
						continue;
					case 22:
						gUIItemType = gUIItemType2;
						num = 34;
						break;
					case 6:
						flag5 = od9j7lKVn != Od9j7lKVn;
						num2 = 18;
						continue;
					case 5:
						if (!flag4)
						{
							return;
						}
						num2 = 24;
						if (460822775 == 0)
						{
							num2 = 9;
						}
						continue;
					case 13:
						Od9j7lKVn = GUI.TextField(kOWhJVTtt, Od9j7lKVn);
						num2 = 6;
						if (0 != 0)
						{
							num2 = 5;
						}
						continue;
					default:
						GUI.Label(kOWhJVTtt, qYV2Rw3GK + ": " + t1I9Znk2q());
						num2 = 32;
						if (1435992043 == 0)
						{
							num2 = 13;
						}
						continue;
					case 1:
						goto IL_0494;
					case 11:
						if (!flag2)
						{
							return;
						}
						num = 9;
						break;
					case 25:
						XU7Vb6ftu(Od9j7lKVn);
						num2 = 21;
						if (0 != 0)
						{
							num2 = 11;
						}
						continue;
					case 12:
						flag2 = yMhH73Thc != YMhH73Thc;
						num2 = 11;
						continue;
					case 7:
						return;
					case 24:
						{
							Action v6Yv4tLYl = V6Yv4tLYl;
							if (v6Yv4tLYl == null)
							{
								num = 35;
								break;
							}
							v6Yv4tLYl();
							num2 = 31;
							continue;
						}
						IL_01de:
						flag = qYV2Rw3GK.Length > 0;
						num2 = 27;
						if (171921593 == 0)
						{
							num2 = 4;
						}
						continue;
						IL_0285:
						od9j7lKVn = Od9j7lKVn;
						num2 = 13;
						continue;
						IL_0494:
						flag4 = GUI.Button(kOWhJVTtt, qYV2Rw3GK);
						num2 = 4;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
						IL_037f:
						num2 = 14;
						if (854369382 == 0)
						{
							num2 = 12;
						}
						continue;
						IL_034d:
						yMhH73Thc = YMhH73Thc;
						num = 19;
						break;
					}
					break;
				}
			}
		}

		internal static bool sAJqHTepwpq3yga9UGT()
		{
			return Ydhyh4ei9etPYtr4G5Y == null;
		}

		internal static GUIItem pCykQ5e7exsRRSdJPO7()
		{
			return Ydhyh4ei9etPYtr4G5Y;
		}
	}
	public class GUIMenu
	{
		private string fsNA3GTvj;

		private bool fAdma8R69;

		private float KoxJxOtMi;

		private float VhHZBqDRT;

		private float x5d1EMWbu;

		protected Rect menuRect;

		protected List<GUIItem> _items;

		private GUIMenu GkfFPnGSn;

		private static GUIMenu uy1PBcebumLMPYmVrwN;

		protected GUIMenu(string name, int childIndex = 1)
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			KoxJxOtMi = 16f;
			VhHZBqDRT = 16f;
			x5d1EMWbu = 232f;
			menuRect = new Rect(20f, 20f, 120f, 50f);
			_items = new List<GUIItem>();
			base..ctor();
			int num = 3;
			if (0 != 0)
			{
				num = 1;
			}
			bool flag = default(bool);
			while (true)
			{
				switch (num)
				{
				default:
					KoxJxOtMi = KoxJxOtMi * (float)childIndex + x5d1EMWbu * (float)(childIndex - 1);
					num = 2;
					if (0 == 0)
					{
						num = 5;
					}
					break;
				case 6:
					if (!flag)
					{
						num = 0;
						if (962215133 != 0)
						{
							num = 0;
						}
						break;
					}
					return;
				case 3:
					fsNA3GTvj = name;
					num = 4;
					break;
				case 1:
					return;
				case 5:
					return;
				case 4:
					flag = childIndex == 1;
					num = 6;
					break;
				}
			}
		}

		public void Draw()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			if (!fAdma8R69)
			{
				CalculateRect();
				fAdma8R69 = true;
			}
			GUI.Box(menuRect, fsNA3GTvj);
			foreach (GUIItem item in _items)
			{
				item.Draw();
			}
			GkfFPnGSn?.Draw();
		}

		public void OpenMenu(GUIMenu menu)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					GkfFPnGSn = menu;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		protected void CalculateRect()
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			float num = KoxJxOtMi + 16f;
			float num2 = VhHZBqDRT + 8f + 25f;
			foreach (GUIItem item in _items)
			{
				item.UpdateRect(new Rect(num, num2, 200f, 30f));
				num2 = num2 + 8f + 30f;
			}
			menuRect = new Rect(KoxJxOtMi, VhHZBqDRT, x5d1EMWbu, num2);
		}

		internal static bool wFqoUkeCUqtQYu6cE3G()
		{
			return uy1PBcebumLMPYmVrwN == null;
		}

		internal static GUIMenu bAwvjHeSLGcih6p3hHH()
		{
			return uy1PBcebumLMPYmVrwN;
		}
	}
	public class DefenceMenu : GUIMenu
	{
		private static DefenceMenu BNB3tyeGVBW33C8PtuL;

		public DefenceMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("Defence Menu", 2);
			_items.Add(new GUIItem("Range Attack Defence", DefenceComponent.Instance.CheckOnRangeAttack, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.CheckOnRangeAttack = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Melee Attack Defence", DefenceComponent.Instance.CheckOnMeleeAttack, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.CheckOnMeleeAttack = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Melee Attach Range", delegate
			{
				int num = 2;
				int num2 = num;
				float meleeAttackRange = default(float);
				string result = default(string);
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 2:
						meleeAttackRange = DefenceComponent.Instance.MeleeAttackRange;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					default:
						return result;
					case 1:
						obj = meleeAttackRange.ToString("0.00");
						if (obj == null)
						{
							num2 = 3;
							continue;
						}
						break;
					case 3:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 4;
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.MeleeAttackRange, 0.1f, 10f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.MeleeAttackRange = value;
						num2 = 0;
						if (742265667 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Melee Attach Angle", delegate
			{
				int num = 2;
				int num2 = num;
				string result = default(string);
				float meleeAttackAngle = default(float);
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						return result;
					case 2:
						meleeAttackAngle = DefenceComponent.Instance.MeleeAttackAngle;
						num2 = 1;
						if (374085082 == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						obj = meleeAttackAngle.ToString("0.00");
						if (obj == null)
						{
							num2 = 3;
							continue;
						}
						break;
					case 3:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 4;
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.MeleeAttackAngle, 30f, 180f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						DefenceComponent.Instance.MeleeAttackAngle = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Player Radius", delegate
			{
				int num = 1;
				int num2 = num;
				string result = default(string);
				float ownRadius = default(float);
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 2:
					case 4:
						return result;
					case 1:
						ownRadius = DefenceComponent.Instance.OwnRadius;
						num2 = 0;
						if (760317395 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						obj = ownRadius.ToString("0.00");
						if (obj == null)
						{
							num2 = 2;
							if (0 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						break;
					case 3:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 4;
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.OwnRadius, 0.1f, 10f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						DefenceComponent.Instance.OwnRadius = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Range Attach Radius", delegate
			{
				int num = 1;
				int num2 = num;
				string result = default(string);
				float projectileRadius = default(float);
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 3:
					case 4:
						return result;
					case 1:
						projectileRadius = DefenceComponent.Instance.ProjectileRadius;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						obj = projectileRadius.ToString("0.00");
						if (obj == null)
						{
							num2 = 2;
							if (0 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 2:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 3;
					}
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.ProjectileRadius, 0.1f, 10f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.ProjectileRadius = value;
						num2 = 0;
						if (2021314568 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Range Tolerance", delegate
			{
				int num = 3;
				int num2 = num;
				string result = default(string);
				float tolerance = default(float);
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						return result;
					case 2:
						obj = tolerance.ToString("0.00");
						if (obj == null)
						{
							num2 = 1;
							if (0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 3:
						tolerance = DefenceComponent.Instance.Tolerance;
						num2 = 2;
						continue;
					case 1:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 0;
					if (121889664 == 0)
					{
						num2 = 0;
					}
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.Tolerance, 0.01f, 1f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.Tolerance = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Range Check Distance", delegate
			{
				int num = 1;
				int num2 = num;
				float maxCheckDistance = default(float);
				string result = default(string);
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						obj = maxCheckDistance.ToString("0.00");
						if (obj == null)
						{
							num2 = 4;
							continue;
						}
						break;
					case 1:
						maxCheckDistance = DefenceComponent.Instance.MaxCheckDistance;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
					case 3:
						return result;
					case 4:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 3;
					if (0 != 0)
					{
						num2 = 2;
					}
				}
			}));
			_items.Add(new GUIItem("", DefenceComponent.Instance.MaxCheckDistance, 0f, 100f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DefenceComponent.Instance.MaxCheckDistance = value;
						num2 = 0;
						if (1362636878 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
		}

		internal static bool IS1TLoewOXjegCQ353i()
		{
			return BNB3tyeGVBW33C8PtuL == null;
		}

		internal static DefenceMenu yyxJ6DecWcA9lqSHCtZ()
		{
			return BNB3tyeGVBW33C8PtuL;
		}
	}
	public class ESPContainerMenu : GUIMenu
	{
		internal static ESPContainerMenu nUnExRelIR4wiihD9CI;

		public ESPContainerMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("ESP Container Menu", 3);
			_items.Add(new GUIItem("Chest", ESPComponent.Instance.ESPContainer.Chest, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPContainer.Chest = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Death Container", ESPComponent.Instance.ESPContainer.DeathContainer, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPContainer.DeathContainer = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Drop Container", ESPComponent.Instance.ESPContainer.PlayerDrop, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPContainer.PlayerDrop = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Resources", ESPComponent.Instance.ESPContainer.ResourceDrop, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPContainer.ResourceDrop = value;
						num2 = 0;
						if (171921593 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Furniture", ESPComponent.Instance.ESPContainer.Furniture, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPContainer.Furniture = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
		}

		internal static bool yrdxieefmfZKcxYJFEH()
		{
			return nUnExRelIR4wiihD9CI == null;
		}

		internal static ESPContainerMenu nieEfFeWHVX4eP8nqgH()
		{
			return nUnExRelIR4wiihD9CI;
		}
	}
	public class ESPMenu : GUIMenu
	{
		private static ESPMenu wJuwCJeBAFO8MNiBiFp;

		public ESPMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("ESP Menu", 2);
			_items.Add(new GUIItem("FieldOfView", delegate
			{
				int num = 2;
				int num2 = num;
				string result = default(string);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
				while (true)
				{
					switch (num2)
					{
					case 3:
					case 4:
						return result;
					case 1:
						defaultInterpolatedStringHandler.AppendFormatted(ESPComponent.Instance.FieldOfView);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
						num2 = 1;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						result = defaultInterpolatedStringHandler.ToStringAndClear();
						num2 = 4;
						break;
					}
				}
			}));
			_items.Add(new GUIItem("", ESPComponent.Instance.FieldOfView, 30f, 120f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.FieldOfView = value;
						num2 = 0;
						if (1256719316 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Blood", ESPComponent.Instance.ESPBlood.Enabled, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPBlood.Enabled = value;
						num2 = 0;
						if (444950165 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Blood Min Quality", delegate
			{
				int num = 3;
				string result = default(string);
				float minBloodQuality = default(float);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						object obj;
						switch (num2)
						{
						case 3:
							goto end_IL_0012;
						default:
							return result;
						case 2:
							obj = minBloodQuality.ToString("0.00");
							if (obj == null)
							{
								num2 = 1;
								if (0 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							break;
						case 1:
							obj = "";
							break;
						}
						result = (string)obj;
						num2 = 4;
						continue;
						end_IL_0012:
						break;
					}
					minBloodQuality = ESPComponent.Instance.ESPBlood.MinBloodQuality;
					num = 2;
				}
			}));
			_items.Add(new GUIItem("", ESPComponent.Instance.ESPBlood.MinBloodQuality, 0f, 100f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPBlood.MinBloodQuality = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Horses", ESPComponent.Instance.ESPHorses.Enabled, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPHorses.Enabled = value;
						num2 = 0;
						if (1433983997 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Horses Min Speed", delegate
			{
				int num = 2;
				int num2 = num;
				string result = default(string);
				float minSpeed = default(float);
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						return result;
					case 1:
						obj = minSpeed.ToString("0.00");
						if (obj == null)
						{
							num2 = 3;
							continue;
						}
						break;
					case 2:
						minSpeed = ESPComponent.Instance.ESPHorses.MinSpeed;
						num2 = 1;
						if (742265667 != 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						obj = "";
						break;
					}
					result = (string)obj;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
				}
			}));
			_items.Add(new GUIItem("", ESPComponent.Instance.ESPHorses.MinSpeed, 0f, 10f, delegate(float value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPHorses.MinSpeed = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Fish", ESPComponent.Instance.ESPFish.Enabled, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPFish.Enabled = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Carriage", ESPComponent.Instance.ESPCarriage.Enabled, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPCarriage.Enabled = value;
						num2 = 0;
						if (1814018247 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Players", delegate
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						OpenMenu(new ESPMenuPlayers());
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Ores", delegate
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						OpenMenu(new ESPOresMenu());
						num2 = 0;
						if (11098130 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Plants", delegate
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						OpenMenu(new ESPMenuPlants());
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Containers", delegate
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						OpenMenu(new ESPContainerMenu());
						num2 = 0;
						if (1629830925 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Debug", DebugComponent.Instance.Enabled, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						DebugComponent.Instance.Enabled = value;
						num2 = 0;
						if (1848937442 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
		}

		[CompilerGenerated]
		private void N4mxJkYV5()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OpenMenu(new ESPMenuPlayers());
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		[CompilerGenerated]
		private void APeKQbVEs()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					OpenMenu(new ESPOresMenu());
					num2 = 0;
					if (11098130 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[CompilerGenerated]
		private void UihUuo7Ni()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OpenMenu(new ESPMenuPlants());
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		[CompilerGenerated]
		private void FBFXmKvh3()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					OpenMenu(new ESPContainerMenu());
					num2 = 0;
					if (1629830925 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool dO7iFVe5D7mR2anyT0P()
		{
			return wJuwCJeBAFO8MNiBiFp == null;
		}

		internal static ESPMenu JuagSWe2Y9QhtxFs26T()
		{
			return wJuwCJeBAFO8MNiBiFp;
		}
	}
	public class ESPMenuPlants : GUIMenu
	{
		internal static ESPMenuPlants Ij6nBEeMeGJAuPEFw1T;

		public ESPMenuPlants()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("ESP Plants Menu", 3);
			int num = 0;
			if (0 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
					return;
				case 1:
					_items.Add(new GUIItem("Blood Rose", ESPComponent.Instance.ESPPlants.BloodRoseEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.BloodRoseEnabled = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 6;
					if (0 == 0)
					{
						num = 7;
					}
					continue;
				case 7:
					_items.Add(new GUIItem("Bleeding Heart", ESPComponent.Instance.ESPPlants.BleedingHeartEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.BleedingHeartEnabled = value;
								num3 = 0;
								if (1976142266 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 2;
					if (0 == 0)
					{
						num = 2;
					}
					continue;
				case 2:
					_items.Add(new GUIItem("Cotton", ESPComponent.Instance.ESPPlants.CottonEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.CottonEnabled = value;
								num3 = 0;
								if (1427489184 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 0;
					if (0 == 0)
					{
						num = 4;
					}
					continue;
				case 4:
					_items.Add(new GUIItem("Corrupted Flower", ESPComponent.Instance.ESPPlants.CorruptedFlowerEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.CorruptedFlowerEnabled = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 9;
					continue;
				case 9:
					_items.Add(new GUIItem("Fire Blossom", ESPComponent.Instance.ESPPlants.FireBlossomEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.FireBlossomEnabled = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 3;
					continue;
				case 3:
					_items.Add(new GUIItem("Ghost Shroom", ESPComponent.Instance.ESPPlants.GhostShroomEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.GhostShroomEnabled = value;
								num3 = 0;
								if (247204215 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 10;
					continue;
				case 10:
					_items.Add(new GUIItem("Hells Clarion", ESPComponent.Instance.ESPPlants.HellsClarionEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.HellsClarionEnabled = value;
								num3 = 0;
								if (0 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 5;
					continue;
				case 5:
					_items.Add(new GUIItem("Moutning Lily", ESPComponent.Instance.ESPPlants.MoutningLilyEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.MoutningLilyEnabled = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 11;
					continue;
				case 11:
					_items.Add(new GUIItem("Snow Flower", ESPComponent.Instance.ESPPlants.SnowFlowerEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.SnowFlowerEnabled = value;
								num3 = 0;
								if (0 == 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					continue;
				case 8:
					_items.Add(new GUIItem("Trippy Shroom", ESPComponent.Instance.ESPPlants.TrippyShroomEnabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlants.TrippyShroomEnabled = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 6;
					continue;
				}
				_items.Add(new GUIItem("Sunflower", ESPComponent.Instance.ESPPlants.SunflowerEnabled, delegate(bool value)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							ESPComponent.Instance.ESPPlants.SunflowerEnabled = value;
							num3 = 0;
							if (2021314568 == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}));
				num = 8;
			}
		}

		internal static bool HAVGhtehSEqXbM32pmY()
		{
			return Ij6nBEeMeGJAuPEFw1T == null;
		}

		internal static ESPMenuPlants Q9Nd1XevjnZPjIyVC04()
		{
			return Ij6nBEeMeGJAuPEFw1T;
		}
	}
	public class ESPMenuPlayers : GUIMenu
	{
		internal static ESPMenuPlayers QRjRxHeLU1t6c3NIUpw;

		public ESPMenuPlayers()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("ESP Players Menu", 3);
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				case 5:
					_items.Add(new GUIItem("Players", ESPComponent.Instance.ESPPlayers.Enabled, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.Enabled = value;
								num3 = 0;
								if (133732588 == 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 4;
					if (1668386183 == 0)
					{
						num = 1;
					}
					continue;
				case 4:
					_items.Add(new GUIItem("Show Ally", ESPComponent.Instance.ESPPlayers.ShowAlly, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowAlly = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 0;
					if (577280904 != 0)
					{
						num = 1;
					}
					continue;
				case 1:
					_items.Add(new GUIItem("Show LvL", ESPComponent.Instance.ESPPlayers.ShowLvL, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowLvL = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 8;
					continue;
				case 8:
					_items.Add(new GUIItem("Show Clan", ESPComponent.Instance.ESPPlayers.ShowClan, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowClan = value;
								num3 = 0;
								if (1032184707 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 7;
					continue;
				case 7:
					_items.Add(new GUIItem("Show Health", ESPComponent.Instance.ESPPlayers.ShowHealth, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowHealth = value;
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 6;
					continue;
				case 6:
					_items.Add(new GUIItem("Show Blood", ESPComponent.Instance.ESPPlayers.ShowBlood, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowBlood = value;
								num3 = 0;
								if (1435992043 != 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					continue;
				case 2:
					_items.Add(new GUIItem("Show Self", ESPComponent.Instance.ESPPlayers.ShowSelf, delegate(bool value)
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								ESPComponent.Instance.ESPPlayers.ShowSelf = value;
								num3 = 0;
								if (1427489184 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 3;
					continue;
				}
				_items.Add(new GUIItem("Show Skills Cooldown", ESPComponent.Instance.ESPPlayers.ShowSkills, delegate(bool value)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							ESPComponent.Instance.ESPPlayers.ShowSkills = value;
							num3 = 0;
							if (0 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}));
				num = 2;
				if (1531368356 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool hbb3kve0SOAJBXH2toQ()
		{
			return QRjRxHeLU1t6c3NIUpw == null;
		}

		internal static ESPMenuPlayers GVpxkgeVNlLkh0S8LF3()
		{
			return QRjRxHeLU1t6c3NIUpw;
		}
	}
	public class ESPOresMenu : GUIMenu
	{
		internal static ESPOresMenu B2FQaZeHvrMuKexJYQo;

		public ESPOresMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("ESP Ores Menu", 3);
			_items.Add(new GUIItem("Quarts", ESPComponent.Instance.ESPOres.OreFilterQuartz, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterQuartz = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Copper", ESPComponent.Instance.ESPOres.OreFilterCopper, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterCopper = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Iron", ESPComponent.Instance.ESPOres.OreFilterIron, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterIron = value;
						num2 = 0;
						if (2058589287 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}));
			_items.Add(new GUIItem("Sulfur", ESPComponent.Instance.ESPOres.OreFilterSulfur, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterSulfur = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("GemFlawless", ESPComponent.Instance.ESPOres.OreFilterGemFlawless, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterGemFlawless = value;
						num2 = 0;
						if (121889664 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			_items.Add(new GUIItem("Silver", ESPComponent.Instance.ESPOres.OreFilterSilver, delegate(bool value)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ESPComponent.Instance.ESPOres.OreFilterSilver = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
		}

		internal static bool YI4qd2e9m8fE20IBuYi()
		{
			return B2FQaZeHvrMuKexJYQo == null;
		}

		internal static ESPOresMenu WASmUWeNrbiuc9mA3aF()
		{
			return B2FQaZeHvrMuKexJYQo;
		}
	}
	public class MainMenu : GUIMenu
	{
		private static MainMenu rHQsyOejLm27n7vQOf6;

		public MainMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("VRising+ by AkcyZe");
			int num = 4;
			while (true)
			{
				switch (num)
				{
				case 4:
					_items.Add(new GUIItem("ESP Menu", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								OpenMenu(new ESPMenu());
								num3 = 0;
								if (0 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}));
					num = 3;
					if (0 != 0)
					{
						num = 0;
					}
					continue;
				case 2:
					_items.Add(new GUIItem("Tweaks Menu", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								OpenMenu(new TweaksMenu());
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 1;
					if (2021314568 == 0)
					{
						num = 1;
					}
					continue;
				case 5:
					return;
				case 3:
					_items.Add(new GUIItem("Aimbot Menu", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								OpenMenu(new AimbotMenu());
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 0;
					if (10932459 == 0)
					{
						num = 0;
					}
					continue;
				case 1:
					_items.Add(new GUIItem("Discord", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								Application.OpenURL("https://discord.gg/9BRBp83ASQ");
								num3 = 0;
								if (0 == 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 5;
					if (1848937442 != 0)
					{
						num = 5;
					}
					continue;
				}
				_items.Add(new GUIItem("Defence Menu", delegate
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							OpenMenu(new DefenceMenu());
							num3 = 0;
							if (0 == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}));
				num = 2;
			}
		}

		[CompilerGenerated]
		private void maCtvNTu2()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					OpenMenu(new ESPMenu());
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		[CompilerGenerated]
		private void LBqQVgROK()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OpenMenu(new AimbotMenu());
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		[CompilerGenerated]
		private void S78aSKX6U()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OpenMenu(new DefenceMenu());
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		[CompilerGenerated]
		private void z9MDsgqm5()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					OpenMenu(new TweaksMenu());
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		internal static bool FXVxPUed4VDj8NOIrFk()
		{
			return rHQsyOejLm27n7vQOf6 == null;
		}

		internal static MainMenu kEV3M1e8aKWuUW1WJ9O()
		{
			return rHQsyOejLm27n7vQOf6;
		}
	}
	public class TweaksMenu : GUIMenu
	{
		internal static TweaksMenu nhvwBYeAPubDB1CHO5g;

		public TweaksMenu()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor("Tweaks Menu", 2);
			int num = 0;
			if (854369382 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				case 3:
					_items.Add(new GUIItem("Remove Fog", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								TweaksComponent.Instance.RemoveFullScreenEffects();
								num3 = 0;
								if (1814018247 == 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 0;
					if (0 == 0)
					{
						num = 2;
					}
					continue;
				case 2:
					_items.Add(new GUIItem("Toggle Day", delegate
					{
						int num2 = 1;
						int num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								TweaksComponent.Instance.ToggleOnlyDay();
								num3 = 0;
								if (760317395 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}));
					num = 1;
					if (2093262890 == 0)
					{
						num = 0;
					}
					continue;
				}
				_items.Add(new GUIItem("Remove Minimap Fog", delegate
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							TweaksComponent.Instance.RemoveMinimapFog();
							num3 = 0;
							if (11098130 == 0)
							{
								num3 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}));
				num = 2;
				if (1185518701 != 0)
				{
					num = 3;
				}
			}
		}

		internal static bool BV0iFbemqUocn5KKqKw()
		{
			return nhvwBYeAPubDB1CHO5g == null;
		}

		internal static TweaksMenu wLgacPeJijGG1Kv7e5D()
		{
			return nhvwBYeAPubDB1CHO5g;
		}
	}
}
namespace VRisingBephinex.config
{
	public class ModConfig
	{
		public static ModConfig Instance;

		private Plugin ohsq1cD12;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<KeyCode> Cow6maOfh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> BATuktyWI;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> gpjsk520M;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> RF6Paps5C;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> woMkjR2SG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> ofVTShd4V;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> Atmz1Ey3f;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> zvLngTeqAH;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> r8VnnM1Cmc;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> IOAnO5FmXc;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> eZWn3pC407;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> DELnoXpyDW;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> Juenya1cYs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> mp8n4LMyMe;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> z8LnI7XyvK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> HasneAXax6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> aE0nRgfiIy;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> R6onYAkdoI;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> lLjnreFuAu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> kKDnEl6iUm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> a3rni1ZStG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> uRQnpkmxW0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> UZCn7NsYMy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> ka6nbkqt10;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> LJonC9sG8H;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> pgYnSclf03;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> PfQnGngVuI;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> UBinwYap8v;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> sERncI0wpP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> iVCnlhFTtU;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> iOPnfBeY7O;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> do6nWxHkNM;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> qyJnB4SMUH;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> SbGn5ogaR2;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> zKSn2KenuA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> QdtnMYkruJ;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> o2mnhD3M6K;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> n94nvxtphx;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<bool> cyqnLpwuCn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<float> hgIn0mdnB3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> JqHnVYDbtd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> jOVnHSysYe;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<KeyCode> HWsn9msCrT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> uIanNnhu6Q;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> o2enj9CStt;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> l4ZndGu5IL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> SX2n8FecJP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> wN3nA8hesY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> mVKnmBDl9L;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> o9KnJxF9ex;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<bool> CRxnZL3cSd;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<float> vObn1EKonl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> xhGnFnE5gL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> FLenxvm8i6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> XlInKeGdLC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<float> unZnUlONuF;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ConfigEntry<float> rhenXqB2qX;


                [CompilerGenerated]
                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                private ConfigEntry<byte> H7PntwOBoF;

                [DebuggerBrowsable(DebuggerBrowsableState.Never)]
                [CompilerGenerated]

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ConfigEntry<byte> H7PntwOBoF;


		internal static ModConfig ko2DJVeZgB12Tfu6Agj;

		public ConfigEntry<KeyCode> FOVToggleKey
		{
			[CompilerGenerated]
			get
			{
				return Cow6maOfh;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						Cow6maOfh = value;
						num2 = 0;
						if (171252512 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersEnabled
		{
			[CompilerGenerated]
			get
			{
				return BATuktyWI;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						BATuktyWI = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersShowLvL
		{
			[CompilerGenerated]
			get
			{
				return gpjsk520M;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						gpjsk520M = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersShowClan
		{
			[CompilerGenerated]
			get
			{
				return RF6Paps5C;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						RF6Paps5C = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersShowHealth
		{
			[CompilerGenerated]
			get
			{
				return woMkjR2SG;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						woMkjR2SG = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersShowBlood
		{
			[CompilerGenerated]
			get
			{
				return ofVTShd4V;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ofVTShd4V = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersShowAlly
		{
			[CompilerGenerated]
			get
			{
				return Atmz1Ey3f;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						Atmz1Ey3f = value;
						num2 = 0;
						if (1518457776 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlayersSkills
		{
			[CompilerGenerated]
			get
			{
				return zvLngTeqAH;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						zvLngTeqAH = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresQuartz
		{
			[CompilerGenerated]
			get
			{
				return r8VnnM1Cmc;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						r8VnnM1Cmc = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresCopper
		{
			[CompilerGenerated]
			get
			{
				return IOAnO5FmXc;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						IOAnO5FmXc = value;
						num2 = 0;
						if (519538535 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresIron
		{
			[CompilerGenerated]
			get
			{
				return eZWn3pC407;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						eZWn3pC407 = value;
						num2 = 0;
						if (1848937442 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresSulfur
		{
			[CompilerGenerated]
			get
			{
				return DELnoXpyDW;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						DELnoXpyDW = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresGemFlawless
		{
			[CompilerGenerated]
			get
			{
				return Juenya1cYs;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						Juenya1cYs = value;
						num2 = 0;
						if (1518457776 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPOresSilver
		{
			[CompilerGenerated]
			get
			{
				return mp8n4LMyMe;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						mp8n4LMyMe = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPHorseEnabled
		{
			[CompilerGenerated]
			get
			{
				return z8LnI7XyvK;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						z8LnI7XyvK = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<float> ESPHorseMinSpeed
		{
			[CompilerGenerated]
			get
			{
				return HasneAXax6;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						HasneAXax6 = value;
						num2 = 0;
						if (2058589287 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPContainerChest
		{
			[CompilerGenerated]
			get
			{
				return aE0nRgfiIy;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						aE0nRgfiIy = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPContainerDeathContainer
		{
			[CompilerGenerated]
			get
			{
				return R6onYAkdoI;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						R6onYAkdoI = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPContainerPlayerDrop
		{
			[CompilerGenerated]
			get
			{
				return lLjnreFuAu;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						lLjnreFuAu = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPContainerResourceDrop
		{
			[CompilerGenerated]
			get
			{
				return kKDnEl6iUm;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						kKDnEl6iUm = value;
						num2 = 0;
						if (747172065 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPContainerFurniture
		{
			[CompilerGenerated]
			get
			{
				return a3rni1ZStG;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						a3rni1ZStG = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPBloodEnabled
		{
			[CompilerGenerated]
			get
			{
				return uRQnpkmxW0;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						uRQnpkmxW0 = value;
						num2 = 0;
						if (1131787544 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<float> ESPBoodMinQuality
		{
			[CompilerGenerated]
			get
			{
				return UZCn7NsYMy;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						UZCn7NsYMy = value;
						num2 = 0;
						if (348513258 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPFish
		{
			[CompilerGenerated]
			get
			{
				return ka6nbkqt10;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ka6nbkqt10 = value;
						num2 = 0;
						if (171252512 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPCarriageEnabled
		{
			[CompilerGenerated]
			get
			{
				return LJonC9sG8H;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						LJonC9sG8H = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsBleedingHeart
		{
			[CompilerGenerated]
			get
			{
				return pgYnSclf03;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						pgYnSclf03 = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsBloodRose
		{
			[CompilerGenerated]
			get
			{
				return PfQnGngVuI;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						PfQnGngVuI = value;
						num2 = 0;
						if (1187184005 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsCotton
		{
			[CompilerGenerated]
			get
			{
				return UBinwYap8v;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						UBinwYap8v = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsCorruptedFlower
		{
			[CompilerGenerated]
			get
			{
				return sERncI0wpP;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						sERncI0wpP = value;
						num2 = 0;
						if (2144623378 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsFireBlossom
		{
			[CompilerGenerated]
			get
			{
				return iVCnlhFTtU;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						iVCnlhFTtU = value;
						num2 = 0;
						if (2144623378 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsGhostShroom
		{
			[CompilerGenerated]
			get
			{
				return iOPnfBeY7O;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						iOPnfBeY7O = value;
						num2 = 0;
						if (1094201023 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsHellsClarion
		{
			[CompilerGenerated]
			get
			{
				return do6nWxHkNM;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						do6nWxHkNM = value;
						num2 = 0;
						if (1486210346 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsMoutningLily
		{
			[CompilerGenerated]
			get
			{
				return qyJnB4SMUH;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						qyJnB4SMUH = value;
						num2 = 0;
						if (1094201023 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsSnowFlower
		{
			[CompilerGenerated]
			get
			{
				return SbGn5ogaR2;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						SbGn5ogaR2 = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsSunflower
		{
			[CompilerGenerated]
			get
			{
				return zKSn2KenuA;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						zKSn2KenuA = value;
						num2 = 0;
						if (10932459 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> ESPPlantsTrippyShroom
		{
			[CompilerGenerated]
			get
			{
				return QdtnMYkruJ;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						QdtnMYkruJ = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotEnabled
		{
			[CompilerGenerated]
			get
			{
				return o2mnhD3M6K;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						o2mnhD3M6K = value;
						num2 = 0;
						if (818312125 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotPlayers
		{
			[CompilerGenerated]
			get
			{
				return n94nvxtphx;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						n94nvxtphx = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotNPC
		{
			[CompilerGenerated]
			get
			{
				return cyqnLpwuCn;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						cyqnLpwuCn = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<float> AimbotMaxDistance
		{
			[CompilerGenerated]
			get
			{
				return hgIn0mdnB3;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						hgIn0mdnB3 = value;
						num2 = 0;
						if (317387702 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotSortByHP
		{
			[CompilerGenerated]
			get
			{
				return JqHnVYDbtd;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						JqHnVYDbtd = value;
						num2 = 0;
						if (1268266038 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotToggleHolding
		{
			[CompilerGenerated]
			get
			{
				return jOVnHSysYe;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						jOVnHSysYe = value;
						num2 = 0;
						if (1131787544 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<KeyCode> AimbotToggleKey
		{
			[CompilerGenerated]
			get
			{
				return HWsn9msCrT;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						HWsn9msCrT = value;
						num2 = 0;
						if (1435650279 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotCheckEnemyCounter
		{
			[CompilerGenerated]
			get
			{
				return uIanNnhu6Q;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						uIanNnhu6Q = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotCheckEnemyCounterMoveCursor
		{
			[CompilerGenerated]
			get
			{
				return o2enj9CStt;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						o2enj9CStt = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotCheckEnemyCounterCancelAttack
		{
			[CompilerGenerated]
			get
			{
				return l4ZndGu5IL;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						l4ZndGu5IL = value;
						num2 = 0;
						if (962215133 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotLockOnTarget
		{
			[CompilerGenerated]
			get
			{
				return SX2n8FecJP;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						SX2n8FecJP = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotDisableInputOnEnemyCounter
		{
			[CompilerGenerated]
			get
			{
				return wN3nA8hesY;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						wN3nA8hesY = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> AimbotCursor
		{
			[CompilerGenerated]
			get
			{
				return mVKnmBDl9L;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						mVKnmBDl9L = value;
						num2 = 0;
						if (258562808 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<bool> DefenceCheckOnRangeAttack
		{
			[CompilerGenerated]
			get
			{
				return o9KnJxF9ex;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						o9KnJxF9ex = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<bool> DefenceCheckOnMeleeAttack
		{
			[CompilerGenerated]
			get
			{
				return CRxnZL3cSd;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						CRxnZL3cSd = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceOwnRadius
		{
			[CompilerGenerated]
			get
			{
				return vObn1EKonl;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						vObn1EKonl = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceProjectileRadius
		{
			[CompilerGenerated]
			get
			{
				return xhGnFnE5gL;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						xhGnFnE5gL = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceTolerance
		{
			[CompilerGenerated]
			get
			{
				return FLenxvm8i6;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						FLenxvm8i6 = value;
						num2 = 0;
						if (2021314568 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceMaxCheckDistance
		{
			[CompilerGenerated]
			get
			{
				return XlInKeGdLC;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						XlInKeGdLC = value;
						num2 = 0;
						if (747172065 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceMeleeAttackRange
		{
			[CompilerGenerated]
			get
			{
				return unZnUlONuF;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						unZnUlONuF = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public ConfigEntry<float> DefenceMeleeAttackAngle
		{
			[CompilerGenerated]
			get
			{
				return rhenXqB2qX;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						rhenXqB2qX = value;
						num2 = 0;
						if (497891482 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

public ConfigEntry<byte> DefenceKey
{
    [CompilerGenerated]
    get
    {
        return H7PntwOBoF;
    }
    [CompilerGenerated]
    set
    {
        int num = 1;
        int num2 = num;
        while (true)
        {
            switch (num2)
            {
                default:
                    return;
                case 1:
                    H7PntwOBoF = value;
                    num2 = 0;
                    if (<Module>{345811dc-be8b-4780-b818-4a956593b791}
                        .m_32fa63a2f47c40cabe232e2a88d38b1e
                        .0 != 0)
                    {
                        num2 = 0;
                    }
                    break;
                case 0:
                    return;
            }
        }
    }
}

public ConfigEntry<string> ESPAimTargetColor { get; private set; }

public Color ParsedAimTargetColor
{
    get
    {
        string text = ESPAimTargetColor.Value.Trim();
        FieldInfo field = typeof(ColorEx)
            .GetField(text, BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase);
        if (field != null && field.FieldType == typeof(Color))
            return (Color)field.GetValue(null);

        Color result;
        if (ColorUtility.TryParseHtmlString(text, out result))
            return result;

        return Color.red;
    }
}


		public ModConfig(Plugin plugin)
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 1;
			if (1976142266 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					Instance = this;
					num = 0;
					if (1976142266 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					ohsq1cD12 = plugin;
					num = 2;
					if (0 != 0)
					{
						num = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Load()
		{
			int num = 56;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						ESPPlayersSkills = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Skills", false, "Show skills");
						num2 = 43;
						if (519538535 == 0)
						{
							num2 = 6;
						}
						continue;
					case 26:
						ESPOresIron = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Iron", false, "Show iron");
						num2 = 7;
						if (1890823438 != 0)
						{
							num2 = 58;
						}
						continue;
					case 49:
						DefenceProjectileRadius = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Projectile Radius", 0.8f, "Projectile radius for defence");
						num2 = 36;
						continue;
					case 43:
						ESPOresQuartz = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Quartz", false, "Show quartz");
						num2 = 51;
						if (0 != 0)
						{
							num2 = 39;
						}
						continue;
					case 9:
						DefenceMaxCheckDistance = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Max Check Distance", 5f, "Maximum distance to check for attacks");
						num2 = 19;
						continue;
					case 31:
						ESPFish = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Fish", "Enabled", false, "Enable ESP for fish");
						num2 = 50;
						continue;
					case 25:
						ESPContainerChest = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Containers", "Chest", false, "Show chests");
						num2 = 38;
						continue;
					case 55:
						ESPPlayersEnabled = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Enabled", false, "Enable ESP for players");
						num2 = 38;
						if (1414824122 != 0)
						{
							num2 = 39;
						}
						continue;
					case 42:
						ESPOresSilver = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Silver", false, "Show silver");
						num = 46;
						break;
					case 16:
						ESPContainerResourceDrop = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Containers", "Resource Drop", false, "Show resource drops");
						num2 = 13;
						if (0 != 0)
						{
							num2 = 13;
						}
						continue;
					case 44:
						ESPPlantsCorruptedFlower = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Corrupted Flower", false, "Show Corrupted Flower");
						num2 = 4;
						continue;
					case 54:
						ESPPlayersShowBlood = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Blood", false, "Show blood");
						num = 3;
						break;
					case 6:
						ESPBoodMinQuality = ((BasePlugin)ohsq1cD12).Config.Bind<float>("ESP Blood", "Min Quality", 0.5f, "Minimum quality to show blood");
						num2 = 53;
						continue;
					case 46:
						ESPHorseEnabled = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Horses", "Enabled", false, "Enable ESP for horses");
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						ESPContainerFurniture = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Containers", "Furniture", false, "Show furniture");
						num2 = 31;
						continue;
					case 39:
						ESPPlayersShowLvL = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Level", false, "Show level");
						num2 = 8;
						continue;
					case 5:
						ESPBloodEnabled = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Blood", "Enabled", false, "Enable ESP for blood");
						num2 = 6;
						continue;
					case 14:
						ESPPlantsCotton = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Cotton", false, "Show Cotton");
						num2 = 22;
						if (1126510863 != 0)
						{
							num2 = 44;
						}
						continue;
					case 36:
						DefenceTolerance = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Tolerance", 0.1f, "Tolerance for defence");
						num2 = 9;
						continue;
					case 45:
						DefenceCheckOnRangeAttack = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Defence", "Check On Range Attack", false, "Enable defence against range attacks");
						num2 = 21;
						continue;
					case 34:
						ESPPlantsBloodRose = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Blood Rose", false, "Show Blood Rose");
						num2 = 14;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 20:
						AimbotMaxDistance = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Aimbot", "Max Distance", 100f, "Maximum distance to aim at");
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 27:
						DefenceOwnRadius = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Own Radius", 1.5f, "Own radius for defence");
						num = 49;
						break;
					case 29:
						AimbotCheckEnemyCounterMoveCursor = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Check Enemy Counter Move Cursor", false, "Move cursor when enemy counter is active");
						num2 = 23;
						continue;
					case 17:
						ESPPlantsTrippyShroom = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Trippy Shroom", false, "Show Trippy Shroom");
						num2 = 5;
						continue;
					case 10:
						AimbotNPC = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "NPC", false, "Enable aimbot for NPC");
						num2 = 20;
						if (2093262890 == 0)
						{
							num2 = 14;
						}
						continue;
					case 57:
						ESPPlantsSnowFlower = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Snow Flower", false, "Show Snow Flower");
						num2 = 24;
						continue;
					case 32:
						AimbotToggleKey = ((BasePlugin)ohsq1cD12).Config.Bind<KeyCode>("Aimbot", "Toggle Key", (KeyCode)301, "Key to toggle aimbot");
						num2 = 22;
						continue;
					case 8:
						ESPPlayersShowClan = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Clan", false, "Show clan");
						num2 = 9;
						if (1531368356 != 0)
						{
							num2 = 11;
						}
						continue;
case 47:
    DefenceKey = ((BasePlugin)ohsq1cD12).Config.Bind<byte>(
        "Defence",
        "Key",
        (byte)67,
        "Key to activate defence"
    );
    num2 = 12;
    continue;

case 48:
    ESPAimTargetColor = ((BasePlugin)ohsq1cD12).Config.Bind<string>(
        "ESP",
        "AimTargetColor",
        "Red",
        "Color for aimed player labels"
    );
    num2 = 1;
    continue;

case 1:
    // …

						AimbotSortByHP = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Sort By HP", false, "Sort targets by HP");
						num2 = 28;
						continue;
					case 56:
						FOVToggleKey = ((BasePlugin)ohsq1cD12).Config.Bind<KeyCode>("FOV", "Toggle Key", (KeyCode)308, "Key to toggle FOV");
						num2 = 55;
						continue;
					case 33:
						ESPOresGemFlawless = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Gem Flawless", false, "Show gem flawless");
						num2 = 42;
						continue;
					case 2:
						ESPPlantsBleedingHeart = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Bleeding Heart", false, "Show Bleeding Heart");
						num2 = 34;
						continue;
					case 48:
						ESPContainerPlayerDrop = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Containers", "Player Drop", false, "Show player drops");
						num2 = 16;
						continue;
					case 52:
						AimbotLockOnTarget = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Lock On Target", false, "Lock on target when aiming");
						num2 = 10;
						if (171921593 != 0)
						{
							num2 = 40;
						}
						continue;
					case 40:
						AimbotDisableInputOnEnemyCounter = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Disable Input On Enemy Counter", false, "Disable input when enemy counter is active");
						num2 = 30;
						continue;
					case 41:
						AimbotPlayers = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Players", false, "Enable aimbot for players");
						num = 10;
						break;
					case 12:
						return;
					case 28:
						AimbotToggleHolding = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Toggle Holding", false, "Hold the toggle key to aim");
						num2 = 9;
						if (1126510863 != 0)
						{
							num2 = 32;
						}
						continue;
					case 51:
						ESPOresCopper = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Copper", false, "Show copper");
						num2 = 10;
						if (0 == 0)
						{
							num2 = 26;
						}
						continue;
					case 23:
						AimbotCheckEnemyCounterCancelAttack = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Check Enemy Counter Cancel Attack", false, "Cancel attack when enemy counter is active");
						num2 = 45;
						continue;
					case 18:
						ESPPlantsGhostShroom = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Ghost Shroom", false, "Show Ghost Shroom");
						num2 = 35;
						continue;
					case 30:
						AimbotCursor = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Cursor", false, "Show cursor when aiming");
						num = 29;
						break;
					case 35:
						ESPPlantsHellsClarion = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Hells Clarion", false, "Show Hells Clarion");
						num2 = 37;
						continue;
					case 19:
						DefenceMeleeAttackRange = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Melee Attack Range", 5f, "Range for melee attacks");
						num2 = 15;
						continue;
					case 38:
						ESPContainerDeathContainer = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Containers", "Death Container", false, "Show death containers");
						num2 = 48;
						if (497891482 == 0)
						{
							num2 = 24;
						}
						continue;
					case 21:
						DefenceCheckOnMeleeAttack = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Defence", "Check On Melee Attack", false, "Enable defence against melee attacks");
						num2 = 25;
						if (133732588 != 0)
						{
							num2 = 27;
						}
						continue;
					case 24:
						ESPPlantsSunflower = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Sunflower", false, "Show Sunflower");
						num2 = 17;
						continue;
					default:
						ESPHorseMinSpeed = ((BasePlugin)ohsq1cD12).Config.Bind<float>("ESP Horses", "Min Speed", 0.5f, "Minimum speed to show horse");
						num = 25;
						break;
					case 11:
						ESPPlayersShowHealth = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Health", false, "Show health");
						num2 = 32;
						if (0 == 0)
						{
							num2 = 54;
						}
						continue;
					case 22:
						AimbotCheckEnemyCounter = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Check Enemy Counter", false, "Check enemy counter before aiming");
						num2 = 3;
						if (0 == 0)
						{
							num2 = 52;
						}
						continue;
					case 3:
						ESPPlayersShowAlly = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Players", "Show Ally", false, "Show ally");
						num2 = 7;
						continue;
					case 53:
						AimbotEnabled = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("Aimbot", "Enabled", false, "Enable aimbot");
						num2 = 41;
						continue;
					case 4:
						ESPPlantsFireBlossom = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Fire Blossom", false, "Show Fire Blossom");
						num2 = 18;
						if (0 != 0)
						{
							num2 = 13;
						}
						continue;
					case 37:
						ESPPlantsMoutningLily = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Plants", "Moutning Lily", false, "Show Moutning Lily");
						num2 = 57;
						continue;
					case 15:
						DefenceMeleeAttackAngle = ((BasePlugin)ohsq1cD12).Config.Bind<float>("Defence", "Melee Attack Angle", 180f, "Angle for melee attacks");
						num2 = 47;
						if (0 != 0)
						{
							num2 = 29;
						}
						continue;
					case 50:
						ESPCarriageEnabled = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Carriage", "Enabled", false, "Enable ESP for carriages");
						num2 = 2;
						continue;
					case 58:
						ESPOresSulfur = ((BasePlugin)ohsq1cD12).Config.Bind<bool>("ESP Ores", "Sulfur", false, "Show sulfur");
						num2 = 33;
						if (1890823438 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				}
			}
		}

		internal static bool x5T0Qoe1FbeXnInVimX()
		{
			return ko2DJVeZgB12Tfu6Agj == null;
		}

		internal static ModConfig XQn0LjeFmTit6POYNUg()
		{
			return ko2DJVeZgB12Tfu6Agj;
		}
	}
}
namespace VRisingBephinex.Components
{
	public class ESPComponent : TweakComponentBase
	{
		public static ESPComponent Instance;

		public ESPContainer ESPContainer;

		public ESPPlayers ESPPlayers;

		public ESPHorses ESPHorses;

		public ESPBlood ESPBlood;

		public ESPOres ESPOres;

		public ESPFish ESPFish;

		public ESPPlants ESPPlants;

		public ESPCarriage ESPCarriage;

		private float GLKnsrya2w;

		private bool No9nPRKfuW;

		public float FieldOfView;

		private List<Entity> Ri6nkwIAFU;

		private static ESPComponent VB8d6uexD8RVfqqwXSP;

		public new PrefabCollectionSystem PrefabCollectionSystem => VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>();

		public float FOV
		{
			get
			{
				int num = 1;
				int num2 = num;
				float result;
				while (true)
				{
					switch (num2)
					{
					case 2:
						result = FieldOfView;
						break;
					case 1:
						if (No9nPRKfuW)
						{
							num2 = 0;
							if (2035096834 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					default:
						result = GLKnsrya2w;
						break;
					}
					break;
				}
				return result;
			}
		}

		[SpecialName]
		private KeyCode ds7nqaA4NK()
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return ModConfig.Instance.FOVToggleKey.Value;
		}

		[SpecialName]
		private void ry6n69Ir83(KeyCode P_0)
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ModConfig.Instance.FOVToggleKey.Value = P_0;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Start()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void InvokeHack()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 8:
						return;
					case 3:
						ESPContainer.Collect();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						ESPPlayers.Collect();
						num2 = 1;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						break;
					case 7:
						ESPFish.Collect();
						num2 = 5;
						continue;
					default:
						ESPOres.Collect();
						num2 = 7;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 5:
						ESPPlants.Collect();
						num2 = 4;
						continue;
					case 6:
						ESPBlood.Collect();
						num2 = 3;
						continue;
					case 4:
						ESPCarriage.Collect();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					break;
				}
				ESPHorses.Collect();
				num = 6;
			}
		}

		public override void UpdateLogic()
		{
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			int num = 6;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag = default(bool);
			bool keyDown = default(bool);
			bool no9nPRKfuW = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						goto end_IL_0012;
					case 3:
						if (!flag2)
						{
							num2 = 17;
							continue;
						}
						goto end_IL_0012;
					case 14:
						flag3 = Camera.main.fieldOfView != FieldOfView;
						num2 = 11;
						continue;
					case 7:
						flag = Camera.main.fieldOfView != GLKnsrya2w;
						num2 = 0;
						if (10932459 == 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
					case 9:
						flag2 = Object.op_Implicit((Object)(object)Camera.main);
						num2 = 3;
						continue;
					case 2:
						return;
					case 8:
						return;
					case 17:
						return;
					case 6:
						ESPPlayers.OnUpdate();
						num2 = 5;
						continue;
					case 5:
						keyDown = Input.GetKeyDown(ds7nqaA4NK());
						num2 = 12;
						if (2035096834 == 0)
						{
							num2 = 10;
						}
						continue;
					case 12:
						if (!keyDown)
						{
							num2 = 1;
							if (1663994158 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 16:
						Camera.main.fieldOfView = FieldOfView;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 10:
						if (no9nPRKfuW)
						{
							num2 = 3;
							if (0 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 14;
					case 11:
						if (!flag3)
						{
							return;
						}
						num2 = 16;
						continue;
					case 15:
						Camera.main.fieldOfView = GLKnsrya2w;
						num2 = 2;
						if (1814018247 != 0)
						{
							num2 = 8;
						}
						continue;
					default:
						if (!flag)
						{
							return;
						}
						num2 = 3;
						if (1032184707 != 0)
						{
							num2 = 15;
						}
						continue;
					case 13:
						break;
					}
					No9nPRKfuW = !No9nPRKfuW;
					num2 = 7;
					if (0 == 0)
					{
						num2 = 9;
					}
					continue;
					end_IL_0012:
					break;
				}
				no9nPRKfuW = No9nPRKfuW;
				num = 10;
			}
		}

		public void OnGUI()
		{
			int num = 11;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						ESPOres.Show();
						num2 = 9;
						if (1890823438 == 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						ESPPlants.Show();
						num2 = 7;
						continue;
					case 5:
						flag = Ri6nkwIAFU.Count > 0;
						num2 = 2;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 11:
						ESPPlayers.Show();
						num2 = 10;
						if (0 != 0)
						{
							num2 = 6;
						}
						continue;
					case 2:
						if (flag)
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						return;
					case 10:
						ESPHorses.Show();
						num2 = 2;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 4:
						return;
					case 7:
						ESPCarriage.Show();
						num2 = 1;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
					case 3:
						ESPBlood.Show();
						num2 = 0;
						if (121889664 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						ESPContainer.Show();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 6;
						}
						continue;
					case 1:
						DrawAll();
						num2 = 4;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 9:
						break;
					}
					break;
				}
				ESPFish.Show();
				num = 8;
			}
		}

		private void zvMnQ3m7IH(Vector3 P_0, string P_1, Color P_2, bool P_3 = false)
		{
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			Vector3 val = default(Vector3);
			bool flag2 = default(bool);
			GUIStyle val3 = default(GUIStyle);
			int num3 = default(int);
			bool flag3 = default(bool);
			float num4 = default(float);
			bool flag = default(bool);
			Vector2 val2 = default(Vector2);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num5;
					switch (num2)
					{
					case 1:
						val = Camera.main.WorldToScreenPoint(P_0);
						num2 = 0;
						if (2048817382 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						if (flag2)
						{
							num2 = 17;
							continue;
						}
						goto case 10;
					case 16:
						val3.fontSize = num3;
						num2 = 11;
						continue;
					case 14:
						if (flag3)
						{
							num2 = 15;
							if (1814018247 == 0)
							{
								num2 = 13;
							}
							continue;
						}
						return;
					case 3:
					case 12:
						val3.normal.textColor = P_2;
						num2 = 16;
						continue;
					default:
						num4 = Vector3.Distance(P_0, Vector3.zero);
						num2 = 5;
						if (0 == 0)
						{
							num2 = 9;
						}
						continue;
					case 2:
						if (flag)
						{
							num2 = 19;
							continue;
						}
						goto case 3;
					case 9:
						if (!(val.z < 0f))
						{
							num2 = 7;
							continue;
						}
						goto IL_032b;
					case 17:
						flag = num3 <= 13;
						num2 = 2;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						num5 = ((!(val.y <= 0f)) ? 1 : 0);
						break;
					case 15:
						val3 = new GUIStyle();
						num2 = 18;
						continue;
					case 18:
						num3 = 30 - (int)(num4 * 0.08f);
						num2 = 6;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 7:
						if (!(val.y > (float)Screen.height))
						{
							num2 = 20;
							continue;
						}
						goto IL_032b;
					case 6:
						flag2 = P_3;
						num2 = 4;
						continue;
					case 11:
						val2 = val3.CalcSize(new GUIContent(P_1));
						num2 = 13;
						continue;
					case 19:
						num3 = 13;
						num2 = 12;
						if (460822775 == 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						if (!(val.x < 0f))
						{
							num2 = 8;
							if (0 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto IL_032b;
					case 13:
						GUI.Label(new Rect(val.x - val2.x / 2f, (float)Screen.height - val.y, val2.x, val2.y), P_1, val3);
						num2 = 4;
						if (247204215 != 0)
						{
							num2 = 21;
						}
						continue;
					case 10:
						num3 = 20;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 20:
						if (!(val.x > (float)Screen.width))
						{
							goto end_IL_0012;
						}
						goto IL_032b;
					case 21:
						return;
						IL_032b:
						num5 = 0;
						break;
					}
					flag3 = (byte)num5 != 0;
					num2 = 14;
					continue;
					end_IL_0012:
					break;
				}
				num = 5;
			}
		}

		public void CollectAll()
		{
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_029c: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Expected O, but got Unknown
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			int num = 7;
			int num2 = num;
			bool flag2 = default(bool);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			EntityQuery val3 = default(EntityQuery);
			Entity current = default(Entity);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			float3 position = default(float3);
			LocalToWorld componentData = default(LocalToWorld);
			bool flag = default(bool);
			EntityManager entityManager = default(EntityManager);
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (flag2)
					{
						num2 = 16;
						if (0 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 3:
					val = ((EntityQuery)(ref val3)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
					num2 = 2;
					if (468683115 == 0)
					{
						num2 = 2;
					}
					break;
				case 13:
					Ri6nkwIAFU.Add(current);
					num2 = 14;
					if (0 != 0)
					{
						num2 = 9;
					}
					break;
				case 17:
					current = enumerator.Current;
					num2 = 12;
					break;
				case 15:
					position = ((LocalToWorld)(ref componentData)).Position;
					num2 = 0;
					if (742265667 != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					flag2 = Ri6nkwIAFU.Count > 0;
					num2 = 6;
					break;
				default:
					flag = Yflna7Pqa9(float3.op_Implicit(position));
					num2 = 1;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 9:
					return;
				case 11:
					return;
				case 8:
				case 10:
				case 14:
					if (!enumerator.MoveNext())
					{
						num2 = 11;
						if (0 == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 17;
				case 12:
					componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
					num2 = 3;
					if (0 == 0)
					{
						num2 = 15;
					}
					break;
				case 1:
					if (flag)
					{
						num2 = 8;
						break;
					}
					goto case 13;
				case 4:
					entityManager = VWorld.Client.EntityManager;
					num2 = 5;
					break;
				case 16:
					Ri6nkwIAFU.Clear();
					num2 = 9;
					break;
				case 5:
				{
					EntityQueryDesc[] array = new EntityQueryDesc[1];
					EntityQueryDesc val2 = new EntityQueryDesc();
					val2.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[2]
					{
						ComponentType.ReadOnly<PrefabGUID>(),
						ComponentType.ReadOnly<LocalToWorld>()
					});
					array[0] = val2;
					val3 = ((EntityManager)(ref entityManager)).CreateEntityQuery((EntityQueryDesc[])(object)array);
					num2 = 3;
					break;
				}
				case 2:
					enumerator = val.GetEnumerator();
					num2 = 10;
					break;
				}
			}
		}

		public void DrawAll()
		{
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num2 = num;
			List<Entity>.Enumerator enumerator = default(List<Entity>.Enumerator);
			Entity current = default(Entity);
			bool flag = default(bool);
			EntityManager entityManager = default(EntityManager);
			bool flag2 = default(bool);
			PrefabGUID componentData = default(PrefabGUID);
			float3 position = default(float3);
			LocalToWorld componentData2 = default(LocalToWorld);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (0 == 0)
								{
									num3 = 1;
								}
								goto IL_0051;
							}
							goto IL_023a;
							IL_023a:
							current = enumerator.Current;
							num3 = 8;
							goto IL_0051;
							IL_0051:
							while (true)
							{
								switch (num3)
								{
								case 11:
									flag = ((EntityManager)(ref entityManager)).Exists(current);
									num3 = 10;
									continue;
								case 14:
									if (!flag2)
									{
										num3 = 2;
										if (0 == 0)
										{
											num3 = 2;
										}
										continue;
									}
									break;
								case 2:
								case 12:
									componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
									num3 = 0;
									if (0 == 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
								{
									position = ((LocalToWorld)(ref componentData2)).Position;
									int num4 = 13;
									num3 = num4;
									continue;
								}
								case 13:
									flag2 = Yflna7Pqa9(float3.op_Implicit(position));
									num3 = 14;
									continue;
								case 8:
									entityManager = VWorld.Client.EntityManager;
									num3 = 11;
									continue;
								case 6:
									zvMnQ3m7IH(float3.op_Implicit(position), text, Color.green);
									num3 = 9;
									continue;
								default:
									text = iBBnDPFmHu(componentData);
									num3 = 6;
									if (0 != 0)
									{
										num3 = 5;
									}
									continue;
								case 4:
								case 9:
								case 15:
									break;
								case 3:
									componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
									num3 = 5;
									continue;
								case 10:
									if (!flag)
									{
										num3 = 11;
										if (1793150317 != 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 3;
								case 7:
									goto IL_023a;
								case 1:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num5 = 0;
						if (55114885 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 0:
					return;
				case 2:
					enumerator = Ri6nkwIAFU.GetEnumerator();
					num2 = 1;
					if (1185518701 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		private static bool Yflna7Pqa9(Vector3 P_0)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			Vector3 val = default(Vector3);
			Camera main = default(Camera);
			Vector3 forward = default(Vector3);
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					val = P_0 - ((Component)main).transform.position;
					num2 = 5;
					break;
				case 2:
					forward = ((Component)main).transform.forward;
					num2 = 1;
					if (577280904 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return result;
				case 5:
					result = Vector3.Dot(forward, val) < 0f;
					num2 = 0;
					if (1414824122 != 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					main = Camera.main;
					num2 = 2;
					if (519538535 != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		private string iBBnDPFmHu(PrefabGUID P_0)
		{
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			PrefabLookupMap prefabLookupMap = default(PrefabLookupMap);
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = default(NativeParallelHashMap<PrefabGUID, Entity>);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				string text;
				while (true)
				{
					switch (num2)
					{
					default:
						prefabLookupMap = PrefabCollectionSystem._PrefabLookupMap;
						num2 = 6;
						continue;
					case 2:
						guidToEntityMap = PrefabCollectionSystem._PrefabLookupMap.GuidToEntityMap;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
					case 4:
						return result;
					case 5:
						text = "GUID Not Found";
						break;
					case 1:
						if (guidToEntityMap.ContainsKey(P_0))
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 6:
						text = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(P_0) + " PrefabGuid(" + ((PrefabGUID)(ref P_0)).GuidHash + ")";
						break;
					}
					break;
				}
				result = text;
				num = 3;
			}
		}

		public ESPComponent()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			ESPContainer = new ESPContainer();
			ESPPlayers = new ESPPlayers();
			ESPHorses = new ESPHorses();
			ESPBlood = new ESPBlood();
			ESPOres = new ESPOres();
			ESPFish = new ESPFish();
			ESPPlants = new ESPPlants();
			ESPCarriage = new ESPCarriage();
			GLKnsrya2w = 60f;
			No9nPRKfuW = false;
			FieldOfView = 60f;
			Ri6nkwIAFU = new List<Entity>();
			base..ctor();
			int num = 0;
			if (1976142266 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool FsoWdPeK73QD1Lo1nj0()
		{
			return VB8d6uexD8RVfqqwXSP == null;
		}

		internal static ESPComponent u4CEBIeU6YAhVppGMIl()
		{
			return VB8d6uexD8RVfqqwXSP;
		}
	}
	public class RootComponent : MonoBehaviour
	{
		public static RootComponent Instance;

		private bool zy0nz1JBKg;

		public string IsMenuShowing;

		private MainMenu hLfOggXEA0;

		private float bbDOn4tht9;

		public bool Active;

		public string IsEnablid;

		private float Pf0OOcp6bh;

		private bool JmSO3sZRNW;

		internal static RootComponent pasnCGeXcEtfB61pLAi;

		public void Start()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					CollectPrefabs();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					hLfOggXEA0 = new MainMenu();
					num2 = 3;
					if (962215133 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					Instance = this;
					num2 = 1;
					if (171252512 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public void Update()
		{
			int num = 9;
			int num2 = num;
			bool keyDown2 = default(bool);
			bool flag = default(bool);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			bool flag4 = default(bool);
			bool keyDown = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 10:
					return;
				case 3:
				case 17:
					keyDown2 = Input.GetKeyDown((KeyCode)287);
					num2 = 4;
					continue;
				case 14:
					if (flag)
					{
						num2 = 19;
						continue;
					}
					goto case 7;
				case 21:
					bbDOn4tht9 = Time.time + 1f;
					num2 = 18;
					continue;
				case 11:
					if (flag3)
					{
						num2 = 13;
						if (1814018247 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					break;
				case 15:
					return;
				case 6:
					zy0nz1JBKg = !zy0nz1JBKg;
					num2 = 2;
					continue;
				case 19:
					SendUserInputSystemPatch.Test = 81;
					num2 = 7;
					continue;
				case 8:
					flag2 = !JmSO3sZRNW;
					num2 = 16;
					continue;
				case 18:
					return;
				case 1:
					flag = SendUserInputSystemPatch.Test > 82;
					num2 = 14;
					continue;
				case 4:
					if (keyDown2)
					{
						num2 = 6;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 13:
					Application.Quit();
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (!flag4)
					{
						num2 = 15;
						continue;
					}
					goto case 21;
				case 2:
					flag3 = !Active;
					num2 = 6;
					if (0 == 0)
					{
						num2 = 11;
					}
					continue;
				case 7:
					flag4 = bbDOn4tht9 < Time.time;
					num2 = 5;
					continue;
				case 9:
					iXAnTvxrLB();
					num2 = 4;
					if (0 == 0)
					{
						num2 = 8;
					}
					continue;
				case 20:
					if (keyDown)
					{
						num2 = 12;
						continue;
					}
					goto case 7;
				case 16:
					if (flag2)
					{
						return;
					}
					num2 = 3;
					continue;
				case 12:
					SendUserInputSystemPatch.Test++;
					num2 = 1;
					if (55114885 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				keyDown = Input.GetKeyDown((KeyCode)286);
				num2 = 20;
			}
		}

		private void iXAnTvxrLB()
		{
			int num = 12;
			bool flag2 = default(bool);
			bool isReady = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 12:
						flag2 = !JmSO3sZRNW;
						num2 = 11;
						continue;
					case 17:
						JmSO3sZRNW = true;
						num2 = 4;
						continue;
					case 18:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<AimbotComponent>();
						num = 2;
						break;
					case 9:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<DefenceComponent>();
						num = 17;
						break;
					case 11:
						if (!flag2)
						{
							num2 = 6;
							continue;
						}
						goto case 15;
					case 13:
						if (!isReady)
						{
							num2 = 19;
							continue;
						}
						goto case 8;
					case 7:
						Pf0OOcp6bh = 0f;
						num2 = 5;
						if (1835701918 == 0)
						{
							num2 = 5;
						}
						continue;
					default:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<TweaksComponent>();
						num2 = 9;
						if (0 == 0)
						{
							num2 = 18;
						}
						continue;
					case 19:
						return;
					case 3:
						if (flag)
						{
							num2 = 7;
							continue;
						}
						return;
					case 2:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<PlayersManager>();
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 15:
						Pf0OOcp6bh += Time.deltaTime;
						num2 = 10;
						continue;
					case 6:
						return;
					case 14:
						return;
					case 4:
						Plugin.LogInfo("PVPExtention is initialized!");
						num2 = 14;
						if (2035096834 == 0)
						{
							num2 = 4;
						}
						continue;
					case 8:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<ESPComponent>();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 16:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<CreaturesManager>();
						num2 = 9;
						continue;
					case 5:
						isReady = VWorld.IsReady;
						num2 = 13;
						if (55114885 == 0)
						{
							num2 = 8;
						}
						continue;
					case 10:
						flag = Pf0OOcp6bh > 1f;
						num2 = 3;
						continue;
					case 1:
						((BasePlugin)Plugin.WjsiYZ2El()).AddComponent<DebugComponent>();
						num2 = 16;
						continue;
					}
					break;
				}
			}
		}

		public void OnGUI()
		{
			int num = 6;
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						return;
					case 7:
						return;
					case 8:
						return;
					case 6:
						goto end_IL_0012;
					default:
						flag = !zy0nz1JBKg;
						num2 = 1;
						if (1433983997 != 0)
						{
							num2 = 3;
						}
						continue;
					case 5:
						if (flag2)
						{
							return;
						}
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						if (flag)
						{
							num2 = 8;
							if (747172065 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						break;
					case 9:
						break;
					}
					MainMenu mainMenu = hLfOggXEA0;
					if (mainMenu == null)
					{
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					mainMenu.Draw();
					num2 = 2;
					if (1185518701 == 0)
					{
						num2 = 1;
					}
					continue;
					end_IL_0012:
					break;
				}
				flag2 = !JmSO3sZRNW;
				num = 5;
			}
		}

		public void CollectPrefabs()
		{
			int num = 2;
			bool isSuccessStatusCode = default(bool);
			HttpResponseMessage result = default(HttpResponseMessage);
			HttpClient httpClient2 = default(HttpClient);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						num2 = 1;
						if (444950165 == 0)
						{
							num2 = 1;
						}
						continue;
					case 1:
						try
						{
							IsEnablid = SearchEntities();
							int num3 = 5;
							if (10932459 == 0)
							{
								num3 = 5;
							}
							while (true)
							{
								switch (num3)
								{
								default:
									goto end_IL_007d;
								case 4:
									isSuccessStatusCode = result.IsSuccessStatusCode;
									num3 = 0;
									if (317387702 != 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									goto end_IL_007d;
								case 8:
									httpClient2 = new HttpClient();
									num3 = 3;
									if (0 != 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									if (!isSuccessStatusCode)
									{
										num3 = 2;
										continue;
									}
									break;
								case 5:
									IsMenuShowing = IsEntityValid(CommonEntitines());
									num3 = 8;
									continue;
								case 3:
								{
									HttpClient httpClient = httpClient2;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(75, 2);
									defaultInterpolatedStringHandler.AppendLiteral("https://vrising-licenses-akcyze.amvera.io/license?token=");
									defaultInterpolatedStringHandler.AppendFormatted(IsEnablid);
									defaultInterpolatedStringHandler.AppendLiteral("&hwid=");
									defaultInterpolatedStringHandler.AppendFormatted(IsMenuShowing);
									defaultInterpolatedStringHandler.AppendLiteral("&game=vrising");
									result = httpClient.GetAsync(defaultInterpolatedStringHandler.ToStringAndClear()).Result;
									num3 = 4;
									continue;
								}
								case 7:
									break;
								case 6:
									return;
								case 0:
									goto end_IL_007d;
								}
								Active = true;
								num3 = 6;
								continue;
								end_IL_007d:
								break;
							}
						}
						catch (Exception)
						{
							int num4 = 1;
							if (1793150317 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									Application.Quit();
									num4 = 0;
									if (11098130 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						break;
					case 3:
						return;
					}
					break;
				}
				Application.Quit();
				num = 3;
			}
		}

		public string SearchEntities()
		{
			int num = 3;
			int num2 = num;
			bool flag = default(bool);
			string result = default(string);
			string text = default(string);
			string directoryName = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (flag)
					{
						num2 = 4;
						break;
					}
					result = File.ReadAllText(text).Trim();
					num2 = 5;
					if (0 != 0)
					{
						num2 = 4;
					}
					break;
				case 6:
					flag = !File.Exists(text);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					throw new FileNotFoundException("Empty License", text);
				case 3:
					directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
					num2 = 2;
					break;
				case 2:
					text = Path.Combine(directoryName, "vrising+.txt");
					num2 = 6;
					break;
				default:
					return result;
				}
			}
		}

		public string IsEntityValid(string hwid)
		{
			int num = 1;
			int num2 = num;
			SHA256 sHA = default(SHA256);
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					sHA = SHA256.Create();
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				default:
					try
					{
						byte[] inArray = sHA.ComputeHash(Encoding.UTF8.GetBytes(hwid));
						int num3 = 1;
						if (0 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								result = Convert.ToHexString(inArray);
								num3 = 0;
								if (0 != 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (sHA == null)
						{
							num4 = 2;
							goto IL_00de;
						}
						goto IL_00f4;
						IL_00f4:
						((IDisposable)sHA).Dispose();
						num4 = 0;
						if (854369382 != 0)
						{
							num4 = 1;
						}
						goto IL_00de;
						IL_00de:
						switch (num4)
						{
						case 2:
							goto end_IL_00c9;
						case 1:
							goto end_IL_00c9;
						}
						goto IL_00f4;
						end_IL_00c9:;
					}
					break;
				}
				break;
			}
			return result;
		}

		public string CommonEntitines()
		{
			int num = 6;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						defaultInterpolatedStringHandler.AppendLiteral("-");
						num2 = 2;
						continue;
					case 5:
						defaultInterpolatedStringHandler.AppendFormatted(SystemInfo.deviceUniqueIdentifier);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						break;
					case 3:
					case 4:
						return result;
					case 2:
						defaultInterpolatedStringHandler.AppendFormatted(SystemInfo.deviceName);
						num2 = 7;
						continue;
					case 6:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
						num2 = 5;
						continue;
					case 7:
						defaultInterpolatedStringHandler.AppendLiteral("-");
						num2 = 0;
						if (1793150317 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						defaultInterpolatedStringHandler.AppendFormatted(SystemInfo.deviceModel);
						num2 = 8;
						continue;
					}
					break;
				}
				result = defaultInterpolatedStringHandler.ToStringAndClear().Replace(" ", "");
				num = 4;
			}
		}

		public RootComponent()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			zy0nz1JBKg = true;
			bbDOn4tht9 = 0f;
			Active = false;
			Pf0OOcp6bh = 0f;
			JmSO3sZRNW = false;
			((MonoBehaviour)this)..ctor();
			int num = 0;
			if (10932459 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool GUTd40etlA5kB4WYv0i()
		{
			return pasnCGeXcEtfB61pLAi == null;
		}

		internal static RootComponent Nmy2eceQUAZBOlZbBZJ()
		{
			return pasnCGeXcEtfB61pLAi;
		}
	}
	public class TweakComponentBase : MonoBehaviour
	{
		public float checkInterval;

		public float checkTimer;

		internal static TweakComponentBase WF0XUTeaiyYWp501yJj;

		protected static PrefabCollectionSystem PrefabCollectionSystem => VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>();

		protected static EntityManager EntityManager => VWorld.Client.EntityManager;

		public void Update()
		{
			int num = 3;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				int num3;
				switch (num2)
				{
				default:
					checkTimer = 0f;
					num2 = 6;
					if (348513258 != 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					if (checkInterval != 0f)
					{
						num2 = 1;
						if (0 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					num3 = 1;
					break;
				case 2:
					checkTimer += Time.deltaTime;
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					if (!flag)
					{
						num2 = 6;
						if (0 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 3:
					UpdateLogic();
					num2 = 2;
					continue;
				case 7:
					InvokeHack();
					num2 = 5;
					continue;
				case 4:
					num3 = ((checkTimer >= checkInterval) ? 1 : 0);
					break;
				case 6:
					return;
				case 5:
					return;
				}
				flag = (byte)num3 != 0;
				num2 = 8;
			}
		}

		public virtual void UpdateLogic()
		{
		}

		public virtual void InvokeHack()
		{
		}

		public TweakComponentBase()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			checkInterval = 1f;
			checkTimer = 0f;
			((MonoBehaviour)this)..ctor();
			int num = 0;
			if (747172065 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool UpgQw9eDrmIKTar9VGk()
		{
			return WF0XUTeaiyYWp501yJj == null;
		}

		internal static TweakComponentBase gRywcdeqtR0Hhvw6yf4()
		{
			return WF0XUTeaiyYWp501yJj;
		}
	}
	public class TweaksComponent : TweakComponentBase
	{
		public static TweaksComponent Instance;

		private static string NeUOoTMKUr;

		private static string PCBOyUEaOs;

		private static string xVeO4s8Jlv;

		private static TweaksComponent h3xnqee6SQLCShsdQPl;

		public void Start()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void RemoveMinimapFog()
		{
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			bool flag = default(bool);
			GameObject val = default(GameObject);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 4:
						break;
					case 3:
						flag = Object.op_Implicit((Object)(object)val);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						val.transform.position = new Vector3(99999f, 99999f, 1f);
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						if (flag)
						{
							num2 = 2;
							if (444950165 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 0:
						return;
					}
					break;
				}
				val = GameObject.Find(NeUOoTMKUr);
				num = 3;
			}
		}

		public void ToggleOnlyDay()
		{
			int num = 4;
			int num2 = num;
			bool flag = default(bool);
			GameObject val = default(GameObject);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					flag = Object.op_Implicit((Object)(object)val);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (flag)
					{
						num2 = 2;
						if (2048817382 == 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 2:
					val.SetActive(true);
					num2 = 0;
					if (962215133 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 4:
					val = GameObject.Find(PCBOyUEaOs);
					num2 = 3;
					break;
				}
			}
		}

		public void RemoveFullScreenEffects()
		{
			int num = 3;
			int num2 = num;
			GameObject val = default(GameObject);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					val.SetActive(!val.activeSelf);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if (flag)
					{
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 1:
					return;
				case 2:
					flag = Object.op_Implicit((Object)(object)val);
					num2 = 4;
					if (2048817382 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					val = GameObject.Find(xVeO4s8Jlv);
					num2 = 2;
					break;
				}
			}
		}

		public TweaksComponent()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (577280904 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static TweaksComponent()
		{
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					PCBOyUEaOs = "SceneLightingGameObjects/VolumeLayer1";
					num2 = 1;
					if (1185518701 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					NeUOoTMKUr = "HUDCanvas(Clone)/HUDClockCanvas/HUDMinimap/MiniMapParent(Clone)/Root/Panel/Mask/CurseDebuffVisualization";
					num2 = 2;
					break;
				case 4:
					wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
					num2 = 3;
					break;
				case 0:
					return;
				case 1:
					xVeO4s8Jlv = "FullscreenEffects";
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
					num2 = 4;
					break;
				}
			}
		}

		internal static bool yKf59yeuCBE9lSftJhZ()
		{
			return h3xnqee6SQLCShsdQPl == null;
		}

		internal static TweaksComponent z0VjWees44jxck72vf8()
		{
			return h3xnqee6SQLCShsdQPl;
		}
	}
}
namespace VRisingBephinex.components
{
	public class AimbotComponent : TweakComponentBase
	{
		public static AimbotComponent Instance;

		public EntityWrapper? TargetEntity;

		private List<EntityWrapper> RC3OifEqjp;

		private bool bPgOpSfhJ0;

		private float a70O7Dykon;

		public Entity PlayerAbility;

		public float ProjectileSpeed;

		public float AbilityCastingTime;

		public bool IsTargetBlocking;

		internal static AimbotComponent k9op5HePY3ZmO2MVPQp;

		public bool Enabled
		{
			get
			{
				return ModConfig.Instance.AimbotEnabled.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotEnabled.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool Players
		{
			get
			{
				return ModConfig.Instance.AimbotPlayers.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotPlayers.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool NPC
		{
			get
			{
				return ModConfig.Instance.AimbotNPC.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotNPC.Value = value;
						num2 = 0;
						if (11098130 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public float MaxDistance
		{
			get
			{
				return ModConfig.Instance.AimbotMaxDistance.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotMaxDistance.Value = value;
						num2 = 0;
						if (55114885 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool SortByHP
		{
			get
			{
				return ModConfig.Instance.AimbotSortByHP.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotSortByHP.Value = value;
						num2 = 0;
						if (2048817382 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool AimbotToggleHolding
		{
			get
			{
				return ModConfig.Instance.AimbotToggleHolding.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotToggleHolding.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public KeyCode AimbotToggleKey
		{
			get
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				return ModConfig.Instance.AimbotToggleKey.Value;
			}
			set
			{
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotToggleKey.Value = value;
						num2 = 0;
						if (1187184005 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool CheckEnemyCounter
		{
			get
			{
				return ModConfig.Instance.AimbotCheckEnemyCounter.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotCheckEnemyCounter.Value = value;
						num2 = 0;
						if (10932459 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool LockOnTarget
		{
			get
			{
				return ModConfig.Instance.AimbotLockOnTarget.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotLockOnTarget.Value = value;
						num2 = 0;
						if (374085082 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool AimbotDisableInputOnEnemyCounter
		{
			get
			{
				return ModConfig.Instance.AimbotDisableInputOnEnemyCounter.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotDisableInputOnEnemyCounter.Value = value;
						num2 = 0;
						if (742265667 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool AimbotCursor
		{
			get
			{
				return ModConfig.Instance.AimbotCursor.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotCursor.Value = value;
						num2 = 0;
						if (348513258 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool AimbotCheckEnemyCounterMoveCursor
		{
			get
			{
				return ModConfig.Instance.AimbotCheckEnemyCounterMoveCursor.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.AimbotCheckEnemyCounterMoveCursor.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool AimbotCheckEnemyCounterCancelAttack
		{
			get
			{
				return ModConfig.Instance.AimbotCheckEnemyCounterCancelAttack.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.AimbotCheckEnemyCounterCancelAttack.Value = value;
						num2 = 0;
						if (1185518701 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public void Awake()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (2048817382 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public override void UpdateLogic()
		{
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_048b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_052f: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			int num = 22;
			bool keyDown = default(bool);
			bool flag3 = default(bool);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag5 = default(bool);
			bool flag8 = default(bool);
			bool aimbotToggleHolding = default(bool);
			bool flag7 = default(bool);
			Vector3 val = default(Vector3);
			float3 newCursorPosition = default(float3);
			bool flag6 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num4;
					int num3;
					switch (num2)
					{
					default:
						return;
					case 22:
						if (Enabled)
						{
							num2 = 21;
							continue;
						}
						num4 = 1;
						goto IL_062b;
					case 29:
						AbilityCastingTime -= Time.deltaTime;
						num2 = 20;
						continue;
					case 38:
						TargetEntity.AimTarget = false;
						num2 = 39;
						continue;
					case 45:
						AbilityCastingTime = 0f;
						num2 = 8;
						continue;
					case 26:
						if (keyDown)
						{
							num = 4;
							break;
						}
						goto case 41;
					case 11:
						if (flag3)
						{
							num2 = 45;
							if (121889664 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 1;
					case 1:
					case 8:
						keyDown = Input.GetKeyDown(AimbotToggleKey);
						num2 = 26;
						if (962215133 == 0)
						{
							num2 = 19;
						}
						continue;
					case 43:
						TargetEntity.AimTarget = true;
						num2 = 13;
						if (0 == 0)
						{
							num2 = 17;
						}
						continue;
					case 37:
						flag = TargetEntity == null;
						num2 = 15;
						if (0 == 0)
						{
							num2 = 28;
						}
						continue;
					case 31:
						return;
					case 6:
						flag2 = TargetEntity != null;
						num2 = 36;
						continue;
					case 9:
					case 32:
						flag5 = AbilityCastingTime > 0f;
						num2 = 19;
						continue;
					case 44:
						return;
					case 20:
						flag3 = AbilityCastingTime <= 0f;
						num2 = 11;
						if (0 != 0)
						{
							num2 = 4;
						}
						continue;
					case 41:
						if (AimbotToggleHolding)
						{
							num2 = 15;
							continue;
						}
						goto case 25;
					case 2:
						if (flag8)
						{
							num2 = 7;
							continue;
						}
						goto case 33;
					case 21:
						num4 = ((!sDNOrE0iJu()) ? 1 : 0);
						goto IL_062b;
					case 19:
						if (!flag5)
						{
							num2 = 1;
							if (1185518701 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 29;
					case 7:
						Application.Quit();
						num2 = 10;
						if (1668386183 != 0)
						{
							num2 = 33;
						}
						continue;
					case 27:
						if (aimbotToggleHolding)
						{
							num2 = 2;
							if (0 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 24;
					case 15:
						if (Input.GetKey(AimbotToggleKey))
						{
							num2 = 23;
							if (317387702 == 0)
							{
								num2 = 22;
							}
							continue;
						}
						goto case 25;
					case 24:
						flag8 = !RootComponent.Instance.Active;
						num2 = 2;
						continue;
					case 40:
						if (!flag7)
						{
							num = 42;
							break;
						}
						goto case 12;
					case 25:
						num3 = (bPgOpSfhJ0 ? 1 : 0);
						goto IL_064d;
					case 18:
						return;
					case 4:
						bPgOpSfhJ0 = !bPgOpSfhJ0;
						num2 = 41;
						continue;
					case 46:
						return;
					case 39:
						TargetEntity = null;
						num2 = 14;
						continue;
					case 5:
						bPgOpSfhJ0 = false;
						num2 = 24;
						if (444950165 == 0)
						{
							num2 = 7;
						}
						continue;
					case 3:
						Mouse.current.WarpCursorPosition(new Vector2(val.x, val.y));
						num2 = 18;
						continue;
					case 0:
						return;
					case 12:
						aimbotToggleHolding = AimbotToggleHolding;
						num2 = 27;
						if (0 != 0)
						{
							num2 = 8;
						}
						continue;
					case 17:
						newCursorPosition = GetNewCursorPosition(TargetEntity);
						num2 = 34;
						if (0 != 0)
						{
							num2 = 33;
						}
						continue;
					case 35:
					case 42:
						IsTargetBlocking = false;
						num2 = 6;
						continue;
					case 10:
						if (flag6)
						{
							return;
						}
						num2 = 13;
						continue;
					case 34:
						flag6 = !Utils.IsInView(float3.op_Implicit(newCursorPosition));
						num2 = 10;
						continue;
					case 14:
						return;
					case 13:
					case 30:
						val = Camera.main.WorldToScreenPoint(float3.op_Implicit(newCursorPosition), (MonoOrStereoscopicEye)2);
						num = 3;
						break;
					case 33:
						TargetEntity = uR1OeYfVu1();
						num2 = 37;
						continue;
					case 16:
						if (flag4)
						{
							return;
						}
						num2 = 9;
						continue;
					case 36:
						if (!flag2)
						{
							num2 = 31;
							if (11098130 == 0)
							{
								num2 = 31;
							}
							continue;
						}
						goto case 38;
					case 28:
						if (flag)
						{
							num2 = 44;
							if (818312125 == 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 43;
					case 23:
						{
							num3 = 1;
							goto IL_064d;
						}
						IL_064d:
						flag7 = (byte)num3 != 0;
						num2 = 37;
						if (2021314568 != 0)
						{
							num2 = 40;
						}
						continue;
						IL_062b:
						flag4 = (byte)num4 != 0;
						num2 = 16;
						if (0 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					break;
				}
			}
		}

		private void RgyOIuVeN7()
		{
			int num = 1;
			bool nPC = default(bool);
			bool players = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						RC3OifEqjp.AddRange(PlayersManager.Instance.Players);
						num2 = 6;
						continue;
					case 2:
						if (nPC)
						{
							num2 = 5;
							if (1268266038 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 4;
					case 4:
						players = Players;
						num = 3;
						break;
					case 8:
						return;
					case 1:
						RC3OifEqjp.Clear();
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						nPC = NPC;
						num2 = 1;
						if (1486210346 != 0)
						{
							num2 = 2;
						}
						continue;
					case 3:
						if (!players)
						{
							num = 8;
							break;
						}
						goto case 7;
					case 5:
						RC3OifEqjp.AddRange(CreaturesManager.Instance.Creatures);
						num2 = 4;
						continue;
					case 6:
						return;
					}
					break;
				}
			}
		}

		private EntityWrapper? uR1OeYfVu1()
		{
			//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0731: Unknown result type (might be due to invalid IL or missing references)
			//IL_066d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0677: Unknown result type (might be due to invalid IL or missing references)
			//IL_067c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0760: Unknown result type (might be due to invalid IL or missing references)
			//IL_0762: Unknown result type (might be due to invalid IL or missing references)
			//IL_0769: Unknown result type (might be due to invalid IL or missing references)
			//IL_076e: Unknown result type (might be due to invalid IL or missing references)
			int num = 44;
			bool flag21 = default(bool);
			float num11 = default(float);
			bool flag4 = default(bool);
			bool flag22 = default(bool);
			EntityWrapper result = default(EntityWrapper);
			float num13 = default(float);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			EntityWrapper entityWrapper2 = default(EntityWrapper);
			float num8 = default(float);
			float num12 = default(float);
			bool flag5 = default(bool);
			EntityWrapper entityWrapper3 = default(EntityWrapper);
			bool lockOnTarget = default(bool);
			List<EntityWrapper>.Enumerator enumerator = default(List<EntityWrapper>.Enumerator);
			bool flag6 = default(bool);
			EntityWrapper current = default(EntityWrapper);
			bool flag14 = default(bool);
			Vector3 val = default(Vector3);
			bool flag12 = default(bool);
			bool flag8 = default(bool);
			bool flag9 = default(bool);
			float num7 = default(float);
			bool flag15 = default(bool);
			bool flag16 = default(bool);
			bool flag17 = default(bool);
			bool flag7 = default(bool);
			bool flag20 = default(bool);
			bool flag19 = default(bool);
			bool flag18 = default(bool);
			bool aimbotCursor = default(bool);
			bool flag10 = default(bool);
			bool flag11 = default(bool);
			bool flag13 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					EntityWrapper entityWrapper;
					int num4;
					int num3;
					switch (num2)
					{
					case 13:
						a70O7Dykon = 0f;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 24:
						if (!flag21)
						{
							num2 = 2;
							continue;
						}
						goto case 34;
					case 14:
						num11 = float.MaxValue;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 41:
						if (flag4)
						{
							num = 19;
							break;
						}
						goto case 48;
					case 28:
						flag22 = a70O7Dykon > 60f;
						num2 = 35;
						continue;
					case 19:
						result = null;
						num2 = 46;
						if (55114885 != 0)
						{
							num2 = 50;
						}
						continue;
					case 6:
						num13 = float.MaxValue;
						num2 = 7;
						if (2035096834 == 0)
						{
							num2 = 2;
						}
						continue;
					case 43:
						if (NPC)
						{
							num2 = 14;
							if (0 == 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 8;
					case 22:
						flag21 = TargetEntity != null;
						num2 = 24;
						continue;
					case 5:
						if (!flag3)
						{
							num2 = 5;
							if (1185518701 != 0)
							{
								num2 = 32;
							}
							continue;
						}
						goto case 30;
					case 23:
						flag2 = RC3OifEqjp.Count == 0;
						num = 9;
						break;
					case 18:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num = 49;
						break;
					case 39:
						entityWrapper2 = null;
						num = 12;
						break;
					case 9:
						if (flag2)
						{
							num2 = 37;
							continue;
						}
						goto case 18;
					case 7:
						num8 = float.MaxValue;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 14;
						}
						continue;
					case 1:
						num12 = float.MaxValue;
						num2 = 3;
						if (0 == 0)
						{
							num2 = 22;
						}
						continue;
					case 38:
						if (!flag5)
						{
							num2 = 33;
							continue;
						}
						goto case 29;
					case 45:
						flag3 = OceOR7j6rs();
						num2 = 5;
						continue;
					case 35:
						if (flag22)
						{
							num2 = 13;
							continue;
						}
						goto case 40;
					case 11:
						entityWrapper = entityWrapper3;
						goto IL_0e68;
					case 40:
						if (entityWrapper2 != null)
						{
							num2 = 4;
							if (577280904 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 11;
					case 48:
						RgyOIuVeN7();
						num2 = 23;
						continue;
					case 2:
					case 42:
						lockOnTarget = LockOnTarget;
						num2 = 10;
						if (0 == 0)
						{
							num2 = 10;
						}
						continue;
					case 8:
						num4 = ((!Players) ? 1 : 0);
						goto IL_0e38;
					case 12:
						entityWrapper3 = null;
						num2 = 6;
						continue;
					case 20:
						num3 = (string.IsNullOrEmpty(RootComponent.Instance.IsMenuShowing) ? 1 : 0);
						goto IL_0e45;
					case 3:
						if (string.IsNullOrEmpty(RootComponent.Instance.IsEnablid))
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 36;
							}
							continue;
						}
						goto case 20;
					case 30:
						result = TargetEntity;
						num2 = 46;
						continue;
					case 34:
						TargetEntity.AimTarget = false;
						num2 = 42;
						continue;
					case 51:
						try
						{
							while (true)
							{
								IL_0b6a:
								int num5;
								if (!enumerator.MoveNext())
								{
									num5 = 6;
									goto IL_0542;
								}
								goto IL_0ac8;
								IL_072f:
								flag6 = !Utils.IsInView(current.Position);
								int num6 = 3;
								goto IL_053e;
								IL_0ac8:
								current = enumerator.Current;
								num6 = 11;
								goto IL_053e;
								IL_053e:
								num5 = num6;
								goto IL_0542;
								IL_0542:
								while (true)
								{
									int num9;
									int num10;
									switch (num5)
									{
									case 2:
										if (flag14)
										{
											num5 = 5;
											if (0 == 0)
											{
												num5 = 9;
											}
											continue;
										}
										goto IL_0b6a;
									case 40:
										val = GetCursorWorldPositionAtHeight(current.Position.y);
										num5 = 1;
										if (0 != 0)
										{
											num5 = 1;
										}
										continue;
									case 9:
										break;
									case 57:
										entityWrapper2 = current;
										num5 = 56;
										if (497891482 == 0)
										{
											num5 = 22;
										}
										continue;
									case 41:
									case 60:
										flag12 = !gvwOYjbje1(current, mainPlayer.ClanName, out flag8);
										num5 = 47;
										continue;
									case 26:
										goto IL_072f;
									case 38:
										if (flag9)
										{
											num5 = 43;
											continue;
										}
										goto case 35;
									case 1:
										num7 = math.distance(float3.op_Implicit(val), float3.op_Implicit(current.Position));
										num5 = 28;
										continue;
									case 14:
										flag15 = !SortByHP;
										num5 = 10;
										if (1433983997 == 0)
										{
											num5 = 0;
										}
										continue;
									case 21:
										if (!flag16)
										{
											num5 = 48;
											continue;
										}
										goto IL_0b6a;
									case 35:
										flag16 = current.HP <= 0f;
										num5 = 0;
										if (1187184005 != 0)
										{
											num5 = 21;
										}
										continue;
									case 34:
										if (flag17)
										{
											num5 = 20;
											continue;
										}
										goto IL_09d0;
									case 31:
										num9 = ((current.HP < num12) ? 1 : 0);
										goto IL_0ca6;
									case 36:
									case 48:
										flag17 = !current.IsValid();
										num5 = 34;
										continue;
									case 5:
										entityWrapper3 = current;
										num5 = 58;
										continue;
									case 3:
										if (!flag6)
										{
											num5 = 41;
											if (374085082 == 0)
											{
												num5 = 12;
											}
											continue;
										}
										goto IL_0b6a;
									case 13:
									case 44:
										if (current.HP > 0f)
										{
											num5 = 31;
											continue;
										}
										num9 = 0;
										goto IL_0ca6;
									case 33:
										num8 = num7;
										num5 = 5;
										if (2058589287 == 0)
										{
											num5 = 1;
										}
										continue;
									case 12:
									case 49:
										flag7 = flag8;
										num5 = 61;
										continue;
									case 4:
										if (!flag20)
										{
											num5 = 52;
											continue;
										}
										goto case 25;
									case 46:
										if (!flag19)
										{
											num5 = 1;
											if (0 == 0)
											{
												num5 = 29;
											}
											continue;
										}
										goto case 39;
									case 39:
										num12 = current.HP;
										num5 = 10;
										if (0 == 0)
										{
											num5 = 30;
										}
										continue;
									case 50:
										goto IL_09d0;
									case 25:
										flag18 = num7 < num13;
										num5 = 0;
										if (0 == 0)
										{
											num5 = 0;
										}
										continue;
									default:
										if (!flag18)
										{
											num5 = 18;
											continue;
										}
										goto case 55;
									case 24:
										aimbotCursor = AimbotCursor;
										num5 = 51;
										continue;
									case 7:
										if (flag10)
										{
											num5 = 1;
											if (0 == 0)
											{
												num5 = 14;
											}
											continue;
										}
										goto IL_0b6a;
									case 42:
										entityWrapper2 = current;
										num5 = 45;
										continue;
									case 30:
										entityWrapper3 = current;
										num5 = 59;
										continue;
									case 27:
										goto IL_0ac8;
									case 17:
										if (!flag11)
										{
											num5 = 8;
											continue;
										}
										goto case 33;
									case 32:
										num10 = ((current.HP < num11) ? 1 : 0);
										goto IL_0c99;
									case 10:
										if (!flag15)
										{
											num5 = 12;
											continue;
										}
										goto IL_0b91;
									case 55:
										num13 = num7;
										num5 = 42;
										continue;
									case 53:
										if (current.HP > 0f)
										{
											num5 = 32;
											continue;
										}
										num10 = 0;
										goto IL_0c99;
									case 8:
									case 15:
									case 18:
									case 19:
									case 20:
									case 29:
									case 37:
									case 43:
									case 45:
									case 54:
									case 56:
									case 58:
									case 59:
										goto IL_0b6a;
									case 22:
										if (flag13)
										{
											num5 = 54;
											continue;
										}
										goto IL_072f;
									case 16:
										goto IL_0b91;
									case 51:
										if (aimbotCursor)
										{
											num5 = 40;
											continue;
										}
										goto case 1;
									case 47:
										if (flag12)
										{
											num5 = 4;
											if (1663994158 != 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto case 24;
									case 23:
									case 52:
										flag11 = num7 < num8;
										num5 = 11;
										if (0 == 0)
										{
											num5 = 17;
										}
										continue;
									case 28:
										flag10 = num7 < MaxDistance;
										num5 = 7;
										continue;
									case 11:
										flag9 = current == null;
										num5 = 38;
										continue;
									case 61:
										if (!flag7)
										{
											num5 = 44;
											continue;
										}
										goto case 53;
									case 6:
										goto end_IL_0b6a;
										IL_0c99:
										flag14 = (byte)num10 != 0;
										num5 = 2;
										continue;
										IL_0ca6:
										flag19 = (byte)num9 != 0;
										num5 = 46;
										continue;
									}
									break;
								}
								num11 = current.HP;
								num6 = 57;
								goto IL_053e;
								IL_0b91:
								flag20 = flag8;
								num6 = 4;
								goto IL_053e;
								IL_09d0:
								flag13 = current.Entity == mainPlayer.Entity;
								num6 = 22;
								goto IL_053e;
								continue;
								end_IL_0b6a:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num14 = 0;
							if (1814018247 != 0)
							{
								num14 = 0;
							}
							switch (num14)
							{
							case 0:
								break;
							}
						}
						goto case 28;
					case 49:
						flag5 = mainPlayer == null;
						num2 = 38;
						if (0 != 0)
						{
							num2 = 31;
						}
						continue;
					case 17:
					case 33:
						val = mainPlayer.Position;
						num2 = 39;
						if (0 != 0)
						{
							num2 = 37;
						}
						continue;
					case 29:
						result = null;
						num2 = 31;
						continue;
					case 16:
					case 27:
					case 32:
						enumerator = RC3OifEqjp.GetEnumerator();
						num2 = 51;
						if (0 != 0)
						{
							num2 = 9;
						}
						continue;
					case 21:
						Application.Quit();
						num2 = 40;
						continue;
					case 10:
						if (!lockOnTarget)
						{
							num2 = 16;
							continue;
						}
						goto case 45;
					case 44:
						a70O7Dykon += Time.deltaTime;
						num2 = 43;
						if (0 != 0)
						{
							num2 = 35;
						}
						continue;
					case 37:
						result = null;
						num2 = 47;
						continue;
					default:
						return result;
					case 26:
						if (flag)
						{
							num2 = 21;
							if (1531368356 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 40;
					case 15:
						num4 = 0;
						goto IL_0e38;
					case 36:
						num3 = 1;
						goto IL_0e45;
					case 4:
						{
							entityWrapper = entityWrapper2;
							goto IL_0e68;
						}
						IL_0e45:
						flag = (byte)num3 != 0;
						num2 = 8;
						if (2093262890 != 0)
						{
							num2 = 26;
						}
						continue;
						IL_0e38:
						flag4 = (byte)num4 != 0;
						num2 = 41;
						continue;
						IL_0e68:
						result = entityWrapper;
						num2 = 25;
						continue;
					}
					break;
				}
			}
		}

		private bool OceOR7j6rs()
		{
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			int num = 14;
			bool result = default(bool);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			bool flag4 = default(bool);
			bool flag3 = default(bool);
			bool flag6 = default(bool);
			Vector3 val2 = default(Vector3);
			bool flag5 = default(bool);
			bool flag2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					Vector3 val;
					switch (num2)
					{
					default:
						if (AimbotCursor)
						{
							num2 = 7;
							continue;
						}
						goto case 2;
					case 5:
						result = false;
						num2 = 27;
						if (1668386183 == 0)
						{
							num2 = 25;
						}
						continue;
					case 2:
						val = mainPlayer.Position;
						break;
					case 1:
					case 17:
					{
						flag4 = !gvwOYjbje1(TargetEntity, mainPlayer.ClanName, out var _);
						num2 = 30;
						continue;
					}
					case 32:
						flag3 = TargetEntity.Entity == Entity.Null;
						num2 = 12;
						if (962215133 != 0)
						{
							num2 = 21;
						}
						continue;
					case 20:
						flag6 = math.distance(float3.op_Implicit(val2), float3.op_Implicit(TargetEntity.Position)) > MaxDistance;
						num2 = 19;
						continue;
					case 18:
						result = false;
						num2 = 25;
						if (1663994158 == 0)
						{
							num2 = 0;
						}
						continue;
					case 22:
						result = false;
						num2 = 4;
						continue;
					case 3:
						result = false;
						num2 = 28;
						continue;
					case 9:
						result = true;
						num2 = 10;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 26:
						flag5 = TargetEntity.HP <= 0f;
						num2 = 15;
						continue;
					case 19:
						if (flag6)
						{
							num2 = 22;
							continue;
						}
						goto case 9;
					case 4:
					case 8:
					case 10:
					case 25:
					case 27:
					case 28:
					case 29:
					case 31:
						return result;
					case 12:
						if (flag2)
						{
							num2 = 5;
							continue;
						}
						goto case 16;
					case 14:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num2 = 12;
						if (0 == 0)
						{
							num2 = 13;
						}
						continue;
					case 16:
						TargetEntity.Update();
						num2 = 32;
						continue;
					case 13:
						flag = mainPlayer == null;
						num2 = 23;
						continue;
					case 24:
						result = false;
						num2 = 31;
						continue;
					case 15:
						if (!flag5)
						{
							num2 = 1;
							if (0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 3;
					case 30:
						if (flag4)
						{
							num2 = 24;
							continue;
						}
						goto default;
					case 21:
						if (flag3)
						{
							num2 = 6;
							continue;
						}
						goto case 26;
					case 6:
						result = false;
						num2 = 8;
						continue;
					case 23:
						if (flag)
						{
							goto end_IL_0012;
						}
						goto case 11;
					case 11:
						flag2 = TargetEntity == null;
						num2 = 12;
						if (258562808 == 0)
						{
							num2 = 6;
						}
						continue;
					case 7:
						val = GetCursorWorldPositionAtHeight(TargetEntity.Position.y);
						break;
					}
					val2 = val;
					num2 = 20;
					continue;
					end_IL_0012:
					break;
				}
				num = 18;
			}
		}

		private bool gvwOYjbje1(EntityWrapper P_0, string P_1, out bool P_2)
		{
			int num = 1;
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			bool result = default(bool);
			bool flag3 = default(bool);
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 19:
						playerWrapper = P_0 as PlayerWrapper;
						num2 = 12;
						if (1835701918 != 0)
						{
							num2 = 17;
						}
						continue;
					case 7:
					case 12:
						result = true;
						num2 = 16;
						continue;
					case 5:
					case 10:
						P_2 = true;
						num2 = 15;
						continue;
					case 14:
						result = false;
						num2 = 9;
						continue;
					case 9:
					case 13:
					case 16:
					case 18:
						return result;
					case 15:
						if (string.IsNullOrEmpty(P_1))
						{
							num2 = 3;
							continue;
						}
						goto case 6;
					case 8:
						if (flag3)
						{
							num2 = 2;
							if (0 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 7;
					case 4:
						if (!flag)
						{
							goto end_IL_0012;
						}
						goto case 14;
					default:
						flag2 = P_0.GetType() == typeof(PlayerWrapper);
						num2 = 11;
						continue;
					case 2:
						result = false;
						num2 = 13;
						continue;
					case 11:
						if (!flag2)
						{
							num2 = 1;
							if (1433983997 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 19;
					case 6:
						num3 = ((playerWrapper.ClanName == P_1) ? 1 : 0);
						break;
					case 17:
						flag = playerWrapper == null;
						num2 = 4;
						continue;
					case 1:
						P_2 = false;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						num3 = 0;
						break;
					}
					flag3 = (byte)num3 != 0;
					num2 = 8;
					if (760317395 == 0)
					{
						num2 = 3;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 5;
			}
		}

		public static Vector3 CalculateLeadDirection(Vector3 playerPos, Vector3 targetPos, Vector3 targetVelocity, float projectileSpeed)
		{
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			int num = 15;
			Vector3 val = default(Vector3);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			float num9 = default(float);
			Vector3 result = default(Vector3);
			bool flag = default(bool);
			float num4 = default(float);
			float num10 = default(float);
			float num8 = default(float);
			float num7 = default(float);
			Vector3 val2 = default(Vector3);
			float num6 = default(float);
			float num11 = default(float);
			float num5 = default(float);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 14:
					{
						float magnitude = ((Vector3)(ref val)).magnitude;
						num2 = 27;
						continue;
					}
					case 1:
						if (flag2)
						{
							num = 13;
							break;
						}
						goto case 23;
					case 19:
						if (flag3)
						{
							num2 = 18;
							continue;
						}
						goto case 29;
					case 8:
						flag3 = num9 < 0f;
						num2 = 19;
						continue;
					case 18:
						result = targetPos;
						num2 = 15;
						if (0 == 0)
						{
							num2 = 28;
						}
						continue;
					case 9:
						flag = num4 < 0f;
						num2 = 22;
						continue;
					case 20:
						num3 = ((projectileSpeed <= 0f) ? 1 : 0);
						goto IL_039c;
					case 16:
						result = targetPos;
						num2 = 4;
						continue;
					case 4:
					case 17:
					case 21:
					case 24:
					case 28:
						return result;
					case 12:
						num9 = num10 * num10 - 4f * num8 * num7;
						num2 = 8;
						continue;
					case 11:
						result = val2;
						num2 = 21;
						continue;
					case 6:
						num10 = 2f * Vector3.Dot(val, targetVelocity);
						num2 = 10;
						continue;
					case 13:
						result = targetPos;
						num2 = 24;
						if (0 != 0)
						{
							num2 = 6;
						}
						continue;
					default:
						num6 = (0f - num10 - num11) / (2f * num8);
						num2 = 2;
						continue;
					case 2:
						num5 = (0f - num10 + num11) / (2f * num8);
						num2 = 4;
						if (247204215 != 0)
						{
							num2 = 5;
						}
						continue;
					case 27:
						if (targetVelocity == Vector3.zero)
						{
							num2 = 3;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 20;
					case 7:
					case 25:
						val2 = targetPos + targetVelocity * num4;
						num2 = 11;
						continue;
					case 26:
						num8 = Vector3.Dot(targetVelocity, targetVelocity) - projectileSpeed * projectileSpeed;
						num2 = 6;
						continue;
					case 29:
						num11 = Mathf.Sqrt(num9);
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						num7 = Vector3.Dot(val, val);
						num = 12;
						break;
					case 15:
						val = targetPos - playerPos;
						num2 = 14;
						if (852228814 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						num4 = math.select(num5, num6, num6 > 0f);
						num2 = 5;
						if (0 == 0)
						{
							num2 = 9;
						}
						continue;
					case 23:
					{
						float num12 = Vector3.Dot(targetVelocity, ((Vector3)(ref val)).normalized);
						num2 = 26;
						continue;
					}
					case 22:
						if (!flag)
						{
							num2 = 7;
							continue;
						}
						goto case 16;
					case 3:
						{
							num3 = 1;
							goto IL_039c;
						}
						IL_039c:
						flag2 = (byte)num3 != 0;
						num2 = 1;
						if (1629830925 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
		}

		public float3 GetNewCursorPosition(EntityWrapper target)
		{
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03db: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0272: Unknown result type (might be due to invalid IL or missing references)
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			int num = 11;
			bool aimbotCheckEnemyCounterCancelAttack = default(bool);
			bool aimbotCheckEnemyCounterMoveCursor = default(bool);
			bool isInDefence = default(bool);
			bool flag = default(bool);
			PlayerWrapper mainPlayer2 = default(PlayerWrapper);
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			float3 result = default(float3);
			Vector3 targetVelocity = default(Vector3);
			EntityManager entityManager = default(EntityManager);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					float3 val;
					int num3;
					int num4;
					switch (num2)
					{
					case 14:
						if (aimbotCheckEnemyCounterCancelAttack)
						{
							num2 = 24;
							if (1793150317 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
					case 23:
						aimbotCheckEnemyCounterMoveCursor = AimbotCheckEnemyCounterMoveCursor;
						num2 = 0;
						if (1094201023 == 0)
						{
							num2 = 0;
						}
						continue;
					default:
						if (aimbotCheckEnemyCounterMoveCursor)
						{
							num2 = 4;
							continue;
						}
						goto case 20;
					case 28:
						val = float3.zero;
						goto IL_03e0;
					case 6:
						if (!isInDefence)
						{
							num2 = 16;
							continue;
						}
						goto case 18;
					case 3:
					case 16:
						IsTargetBlocking = false;
						num2 = 8;
						if (696790966 == 0)
						{
							num2 = 2;
						}
						continue;
					case 20:
						aimbotCheckEnemyCounterCancelAttack = AimbotCheckEnemyCounterCancelAttack;
						num2 = 14;
						if (0 != 0)
						{
							num2 = 3;
						}
						continue;
					case 12:
						if (flag)
						{
							num = 26;
							break;
						}
						goto case 3;
					case 18:
						IsTargetBlocking = true;
						num2 = 23;
						continue;
					case 11:
						mainPlayer2 = PlayersManager.Instance.MainPlayer;
						num2 = 10;
						continue;
					case 17:
						playerWrapper = target as PlayerWrapper;
						num2 = 1;
						if (1126510863 == 0)
						{
							num2 = 1;
						}
						continue;
					case 10:
						if (!CheckEnemyCounter)
						{
							num = 5;
							break;
						}
						goto case 17;
					case 4:
						result = float3.op_Implicit(GetCursorBehindPlayerRelativeToEnemy(mainPlayer2.Position, target.Position, 1f));
						num2 = 13;
						if (0 == 0)
						{
							num2 = 13;
						}
						continue;
					case 27:
						result = float3.op_Implicit(CalculateLeadDirection(mainPlayer2.Position, target.Position, targetVelocity, ProjectileSpeed));
						num2 = 22;
						continue;
					case 24:
						if (!(AbilityCastingTime > 0f))
						{
							num2 = 9;
							continue;
						}
						num3 = 1;
						goto IL_03c2;
					case 13:
					case 15:
					case 22:
						return result;
					case 1:
						num4 = ((playerWrapper != null) ? 1 : 0);
						goto IL_0379;
					case 8:
						entityManager = TweakComponentBase.EntityManager;
						num2 = 2;
						continue;
					case 2:
						if (!((EntityManager)(ref entityManager)).HasComponent<Velocity>(target.Entity))
						{
							num2 = 28;
							continue;
						}
						entityManager = TweakComponentBase.EntityManager;
						num2 = 19;
						continue;
					case 21:
						if (flag2)
						{
							num2 = 25;
							continue;
						}
						goto case 3;
					case 25:
						isInDefence = playerWrapper.IsInDefence;
						num2 = 3;
						if (0 == 0)
						{
							num2 = 6;
						}
						continue;
					case 26:
						InputSimulator.KeyboardPress(88);
						num2 = 3;
						if (1518457776 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						num4 = 0;
						goto IL_0379;
					case 9:
					{
						PlayerWrapper? mainPlayer = PlayersManager.Instance.MainPlayer;
						if (mainPlayer == null)
						{
							num2 = 7;
							continue;
						}
						num3 = ((mainPlayer.CastingTime > 0f) ? 1 : 0);
						goto IL_03c2;
					}
					case 7:
						num3 = 0;
						goto IL_03c2;
					case 19:
						{
							val = ((EntityManager)(ref entityManager)).GetComponentData<Velocity>(target.Entity).Value;
							goto IL_03e0;
						}
						IL_0379:
						flag2 = (byte)num4 != 0;
						num2 = 21;
						continue;
						IL_03e0:
						targetVelocity = float3.op_Implicit(val);
						num2 = 22;
						if (0 == 0)
						{
							num2 = 27;
						}
						continue;
						IL_03c2:
						flag = (byte)num3 != 0;
						num2 = 12;
						continue;
					}
					break;
				}
			}
		}

		public static Vector3 GetCursorBehindPlayerRelativeToEnemy(Vector3 playerPos, Vector3 targetPos, float distance = 2f)
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			int num = 8;
			int num2 = num;
			Vector3 normalized = default(Vector3);
			Vector3 val4 = default(Vector3);
			Vector3 normalized2 = default(Vector3);
			float num3 = default(float);
			Vector3 result = default(Vector3);
			Vector3 val3 = default(Vector3);
			Vector3 val = default(Vector3);
			Vector3 val2 = default(Vector3);
			while (true)
			{
				switch (num2)
				{
				case 7:
					normalized = ((Vector3)(ref val4)).normalized;
					num2 = 2;
					if (0 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					normalized2 = ((Vector3)(ref val4)).normalized;
					num2 = 0;
					if (497891482 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					num3 = Random.Range(-0.5f, 0.5f);
					num2 = 3;
					break;
				case 1:
				case 6:
					return result;
				case 8:
					val4 = targetPos - playerPos;
					num2 = 7;
					if (1094201023 == 0)
					{
						num2 = 3;
					}
					break;
				case 9:
					val3 = playerPos + val * distance;
					num2 = 10;
					if (0 != 0)
					{
						num2 = 2;
					}
					break;
				case 10:
					val4 = Vector3.Cross(Vector3.up, val);
					num2 = 2;
					if (0 == 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					result = val3 + val2;
					num2 = 6;
					if (1435650279 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					val2 = normalized2 * num3;
					num2 = 5;
					break;
				case 2:
					val = -normalized;
					num2 = 9;
					break;
				}
			}
		}

		private bool sDNOrE0iJu()
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = PlayersManager.Instance.MainPlayer != null;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private Vector3 edyOEy1Ipx()
		{
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			Vector3 val = default(Vector3);
			Vector3 result = default(Vector3);
			while (true)
			{
				switch (num2)
				{
				case 3:
					val = Camera.main.ScreenToWorldPoint(val);
					num2 = 1;
					if (1668386183 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					val = Input.mousePosition;
					num2 = 3;
					break;
				case 1:
					result = val;
					num2 = 2;
					break;
				default:
					return result;
				}
			}
		}

		public static Vector3 GetCursorWorldPositionAtHeight(float height)
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			int num = 8;
			int num2 = num;
			bool flag = default(bool);
			Plane val2 = default(Plane);
			Ray val = default(Ray);
			float num3 = default(float);
			Vector3 result = default(Vector3);
			while (true)
			{
				switch (num2)
				{
				case 3:
					flag = ((Plane)(ref val2)).Raycast(val, ref num3);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					result = Vector3.zero;
					num2 = 4;
					if (0 == 0)
					{
						num2 = 6;
					}
					break;
				default:
					result = ((Ray)(ref val)).GetPoint(num3);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 4;
					}
					break;
				case 8:
					((Plane)(ref val2))..ctor(Vector3.up, new Vector3(0f, height, 0f));
					num2 = 7;
					break;
				case 4:
				case 5:
				case 6:
					return result;
				case 1:
					if (flag)
					{
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 7:
					val = Camera.main.ScreenPointToRay(Input.mousePosition);
					num2 = 3;
					break;
				}
			}
		}

		public AimbotComponent()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			TargetEntity = null;
			RC3OifEqjp = new List<EntityWrapper>();
			bPgOpSfhJ0 = false;
			a70O7Dykon = 0f;
			PlayerAbility = Entity.Null;
			ProjectileSpeed = 0f;
			AbilityCastingTime = 0f;
			IsTargetBlocking = false;
			base..ctor();
			int num = 0;
			if (1268266038 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Q0OPC0ekvVx4bL7eJHC()
		{
			return k9op5HePY3ZmO2MVPQp == null;
		}

		internal static AimbotComponent uo1MaveT2TxWnAs0OGd()
		{
			return k9op5HePY3ZmO2MVPQp;
		}
	}
	public class ColorOption
	{
		public string Name;

		public Color Value;

		internal static ColorOption BjuDIvezkaf4fkJk0PH;

		public ColorOption(string name, Color value)
		{
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					Name = name;
					num = 0;
					if (0 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				default:
					Value = value;
					num = 0;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public override string ToString()
		{
			int num = 1;
			int num2 = num;
			string name = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					name = Name;
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return name;
				}
			}
		}

		internal static bool ylIrg7RgTvR1uqrfDNi()
		{
			return BjuDIvezkaf4fkJk0PH == null;
		}

		internal static ColorOption fV8iXORnXmKZgbpnooK()
		{
			return BjuDIvezkaf4fkJk0PH;
		}
	}
	public class DebugComponent : TweakComponentBase
	{
		public static DebugComponent Instance;

		public bool Enabled;

		internal static DebugComponent IQbIcDROBFqFKNAqMUM;

		public void Awake()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (317387702 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void OnGUI()
		{
			//IL_0909: Unknown result type (might be due to invalid IL or missing references)
			//IL_090e: Unknown result type (might be due to invalid IL or missing references)
			//IL_09af: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_09be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_094d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0952: Unknown result type (might be due to invalid IL or missing references)
			//IL_0957: Unknown result type (might be due to invalid IL or missing references)
			//IL_095c: Unknown result type (might be due to invalid IL or missing references)
			//IL_071f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0724: Unknown result type (might be due to invalid IL or missing references)
			//IL_0932: Unknown result type (might be due to invalid IL or missing references)
			//IL_0889: Unknown result type (might be due to invalid IL or missing references)
			//IL_088e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0893: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_082f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0834: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a32: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0877: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_058a: Unknown result type (might be due to invalid IL or missing references)
			//IL_058f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			int num = 36;
			EntityManager manager = default(EntityManager);
			bool flag = default(bool);
			List<CreatureWrapper>.Enumerator enumerator4 = default(List<CreatureWrapper>.Enumerator);
			Vector3 targetVelocity = default(Vector3);
			CreatureWrapper current4 = default(CreatureWrapper);
			Vector3 position5 = default(Vector3);
			Vector3 playerPos = default(Vector3);
			bool flag4 = default(bool);
			List<PlayerWrapper>.Enumerator enumerator3 = default(List<PlayerWrapper>.Enumerator);
			Vector3 position2 = default(Vector3);
			PlayerWrapper current3 = default(PlayerWrapper);
			Vector3 val5 = default(Vector3);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			LocalToWorld componentData2 = default(LocalToWorld);
			Entity current = default(Entity);
			Enumerator<Entity> enumerator2 = default(Enumerator<Entity>);
			float3 position = default(float3);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			List<Buff> list = default(List<Buff>);
			NativeArray<Entity> val4 = default(NativeArray<Entity>);
			NativeArray<Entity> val3 = default(NativeArray<Entity>);
			EntityQuery val2 = default(EntityQuery);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			Buff item = default(Buff);
			Entity current2 = default(Entity);
			PrefabGUID componentData = default(PrefabGUID);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					Vector3 val;
					switch (num2)
					{
					case 10:
						manager = EntityManagerWrapper.Manager;
						num2 = 38;
						continue;
					case 2:
						manager = EntityManagerWrapper.Manager;
						num2 = 1;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 11:
						if (flag)
						{
							num2 = 21;
							continue;
						}
						goto case 6;
					case 24:
						try
						{
							while (true)
							{
								int num7;
								if (!enumerator4.MoveNext())
								{
									int num6 = 6;
									num7 = num6;
									goto IL_012a;
								}
								goto IL_0321;
								IL_012a:
								while (true)
								{
									switch (num7)
									{
									case 3:
										targetVelocity = rdCOb07x9Z(current4.Entity);
										num7 = 4;
										continue;
									case 4:
										position5 = AimbotComponent.CalculateLeadDirection(playerPos, current4.Position, targetVelocity, AimbotComponent.Instance.ProjectileSpeed);
										num7 = 7;
										if (0 == 0)
										{
											num7 = 8;
										}
										continue;
									case 5:
										flag4 = !current4.IsValid();
										num7 = 2;
										continue;
									case 2:
										if (flag4)
										{
											num7 = 0;
											if (117793469 == 0)
											{
												num7 = 0;
											}
											continue;
										}
										goto case 3;
									case 8:
										ESPDrawer.Draw(position5, "X", Color.green);
										num7 = 0;
										if (0 == 0)
										{
											num7 = 7;
										}
										continue;
									case 7:
									{
										Vector3 position4 = current4.Position;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
										defaultInterpolatedStringHandler.AppendFormatted(current4.Name);
										defaultInterpolatedStringHandler.AppendLiteral(" (");
										defaultInterpolatedStringHandler.AppendFormatted<Vector3>(current4.Position);
										defaultInterpolatedStringHandler.AppendLiteral(")");
										ESPDrawer.Draw(position4, defaultInterpolatedStringHandler.ToStringAndClear(), Color.white, useGradiant: true);
										num7 = 1;
										if (1268266038 == 0)
										{
											num7 = 1;
										}
										continue;
									}
									case 9:
										goto IL_0321;
									case 6:
										goto end_IL_0182;
									}
									break;
								}
								continue;
								IL_0321:
								current4 = enumerator4.Current;
								num7 = 5;
								goto IL_012a;
								continue;
								end_IL_0182:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator4/*cast due to .constrained prefix*/).Dispose();
							int num8 = 0;
							if (0 == 0)
							{
								num8 = 0;
							}
							switch (num8)
							{
							case 0:
								break;
							}
						}
						goto case 2;
					case 4:
						try
						{
							while (true)
							{
								int num4;
								if (!enumerator3.MoveNext())
								{
									int num3 = 8;
									num4 = num3;
									goto IL_039b;
								}
								goto IL_062c;
								IL_039b:
								while (true)
								{
									switch (num4)
									{
									case 1:
										position2 = AimbotComponent.CalculateLeadDirection(playerPos, current3.Position, val5, AimbotComponent.Instance.ProjectileSpeed);
										num4 = 4;
										if (0 != 0)
										{
											num4 = 3;
										}
										continue;
									case 3:
									{
										Vector3 position3 = current3.Position;
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 4);
										defaultInterpolatedStringHandler.AppendFormatted(current3.Name);
										defaultInterpolatedStringHandler.AppendLiteral(" (");
										defaultInterpolatedStringHandler.AppendFormatted<Vector3>(current3.Position);
										defaultInterpolatedStringHandler.AppendLiteral(") (");
										defaultInterpolatedStringHandler.AppendFormatted<Vector3>(val5);
										defaultInterpolatedStringHandler.AppendLiteral(") (");
										defaultInterpolatedStringHandler.AppendFormatted(current3.IsInDefence);
										defaultInterpolatedStringHandler.AppendLiteral(")");
										ESPDrawer.Draw(position3, defaultInterpolatedStringHandler.ToStringAndClear(), Color.white, useGradiant: true);
										num4 = 0;
										if (374085082 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									case 9:
										ESPDrawer.Draw(position2, "X", Color.green);
										num4 = 2;
										if (0 == 0)
										{
											num4 = 3;
										}
										continue;
									case 7:
										val5 = rdCOb07x9Z(current3.Entity);
										num4 = 1;
										if (0 != 0)
										{
											num4 = 1;
										}
										continue;
									case 5:
									{
										LocalToWorld componentData3 = ((EntityManager)(ref manager)).GetComponentData<LocalToWorld>(current3.Entity);
										num4 = 9;
										continue;
									}
									case 4:
										manager = EntityManagerWrapper.Manager;
										num4 = 5;
										continue;
									case 10:
										flag3 = !current3.IsValid();
										num4 = 11;
										if (317387702 == 0)
										{
											num4 = 4;
										}
										continue;
									case 11:
										if (flag3)
										{
											num4 = 6;
											continue;
										}
										goto case 7;
									case 2:
										goto IL_062c;
									case 8:
										goto end_IL_056d;
									}
									break;
								}
								continue;
								IL_062c:
								current3 = enumerator3.Current;
								num4 = 10;
								goto IL_039b;
								continue;
								end_IL_056d:
								break;
							}
						}
						finally
						{
							((IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
							int num5 = 0;
							if (0 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						goto case 31;
					case 35:
						if (!flag2)
						{
							num2 = 19;
							if (0 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						return;
					case 38:
						componentData2 = ((EntityManager)(ref manager)).GetComponentData<LocalToWorld>(current);
						num2 = 13;
						if (1413447416 == 0)
						{
							num2 = 11;
						}
						continue;
					case 33:
						manager = EntityManagerWrapper.Manager;
						num2 = 32;
						continue;
					case 8:
					case 37:
						if (enumerator2.MoveNext())
						{
							num2 = 15;
							continue;
						}
						return;
					case 20:
						position = ((LocalToWorld)(ref componentData2)).Position;
						num2 = 5;
						continue;
					case 26:
						if (mainPlayer != null)
						{
							num2 = 21;
							if (0 == 0)
							{
								num2 = 25;
							}
							continue;
						}
						goto case 34;
					case 28:
						enumerator3 = PlayersManager.Instance.Players.GetEnumerator();
						num2 = 1;
						if (0 == 0)
						{
							num2 = 4;
						}
						continue;
					case 31:
						enumerator4 = CreaturesManager.Instance.Creatures.GetEnumerator();
						num2 = 21;
						if (0 == 0)
						{
							num2 = 24;
						}
						continue;
					case 14:
					case 15:
						current = enumerator2.Current;
						num2 = 10;
						continue;
					case 29:
						list = new List<Buff>();
						num2 = 0;
						if (1976142266 != 0)
						{
							num2 = 0;
						}
						continue;
					case 36:
						flag2 = !Enabled;
						num2 = 35;
						continue;
					case 3:
						return;
					case 7:
						return;
					case 30:
						enumerator2 = val4.GetEnumerator();
						num2 = 37;
						continue;
					case 34:
						val = Vector3.zero;
						goto IL_0a5f;
					case 22:
						val3 = ((EntityQuery)(ref val2)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)3));
						num = 29;
						break;
					case 13:
						manager = EntityManagerWrapper.Manager;
						num2 = 9;
						if (577280904 == 0)
						{
							num2 = 2;
						}
						continue;
					case 12:
						val4 = ((EntityQuery)(ref val2)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)3));
						num2 = 29;
						if (2035096834 != 0)
						{
							num2 = 30;
						}
						continue;
					default:
						enumerator = val3.GetEnumerator();
						num2 = 18;
						if (1126510863 == 0)
						{
							num2 = 9;
						}
						continue;
					case 21:
						list.Add(item);
						num2 = 6;
						continue;
					case 17:
						val2 = ((EntityManager)(ref manager)).CreateEntityQuery((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<Buff>() });
						num2 = 22;
						continue;
					case 6:
					case 18:
						if (!enumerator.MoveNext())
						{
							num2 = 24;
							if (0 == 0)
							{
								num2 = 28;
							}
							continue;
						}
						goto case 16;
					case 1:
						val2 = ((EntityManager)(ref manager)).CreateEntityQuery((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<Projectile>() });
						num2 = 6;
						if (2048817382 != 0)
						{
							num2 = 12;
						}
						continue;
					case 19:
					case 23:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num2 = 26;
						continue;
					case 16:
						current2 = enumerator.Current;
						num = 33;
						break;
					case 9:
						componentData = ((EntityManager)(ref manager)).GetComponentData<PrefabGUID>(current);
						num2 = 20;
						continue;
					case 32:
						flag = ((EntityManager)(ref manager)).TryGetComponentData<Buff>(current2, ref item);
						num2 = 11;
						continue;
					case 27:
						manager = EntityManagerWrapper.Manager;
						num2 = 17;
						continue;
					case 25:
						val = mainPlayer.Position;
						goto IL_0a5f;
					case 5:
						{
							ESPDrawer.Draw(float3.op_Implicit(position), EntityManagerWrapper.GetPrefabDevName(componentData) ?? "", Color.white, useGradiant: true);
							num2 = 4;
							if (818312125 != 0)
							{
								num2 = 8;
							}
							continue;
						}
						IL_0a5f:
						playerPos = val;
						num2 = 27;
						continue;
					}
					break;
				}
			}
		}

		private Vector3 rdCOb07x9Z(Entity P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			EntityManager entityManager = TweakComponentBase.EntityManager;
			float3 val;
			if (!((EntityManager)(ref entityManager)).HasComponent<Velocity>(P_0))
			{
				val = float3.zero;
			}
			else
			{
				entityManager = TweakComponentBase.EntityManager;
				val = ((EntityManager)(ref entityManager)).GetComponentData<Velocity>(P_0).Value;
			}
			return float3.op_Implicit(val);
		}

		private Vector3 FiuOCy5LDB()
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num2 = num;
			Vector3 result = default(Vector3);
			Vector3 val = default(Vector3);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 5:
					result = val;
					num2 = 3;
					break;
				case 2:
					val = Input.mousePosition;
					num2 = 1;
					if (444950165 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					val = Camera.main.ScreenToWorldPoint(val);
					num2 = 5;
					break;
				case 1:
					val.z = 10f;
					num2 = 0;
					if (1668386183 != 0)
					{
						num2 = 4;
					}
					break;
				}
			}
		}

		public DebugComponent()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Enabled = false;
			base..ctor();
			int num = 0;
			if (1256719316 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool LiuGNqR3BykA0Scq0Ua()
		{
			return IQbIcDROBFqFKNAqMUM == null;
		}

		internal static DebugComponent dMRlR2RomaEAgiuYqTo()
		{
			return IQbIcDROBFqFKNAqMUM;
		}
	}
	public class DefenceComponent : TweakComponentBase
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass29_0
		{
			public EntityOwner aQwyEfjvWt;

			private static <>c__DisplayClass29_0 FvHNTqY289ywui9gBkb;

			public <>c__DisplayClass29_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (2035096834 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool ILVyrB9pRR(PlayerWrapper p)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				return p.Entity == aQwyEfjvWt.Owner;
			}

			internal static bool pkPwWkYMw6abX1UBPDI()
			{
				return FvHNTqY289ywui9gBkb == null;
			}

			internal static <>c__DisplayClass29_0 S7MVJVYhTSUlZnCyUxd()
			{
				return FvHNTqY289ywui9gBkb;
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass30_0
		{
			public Entity dF8yp9HAKB;

			internal static <>c__DisplayClass30_0 WoNfBcYvKTlEtMvPfBv;

			public <>c__DisplayClass30_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (0 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool X3fyiSpHNf(PlayerWrapper p)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				return p.Entity == dF8yp9HAKB;
			}

			internal static bool R0YMggYLGKNFtgSIKFe()
			{
				return WoNfBcYvKTlEtMvPfBv == null;
			}

			internal static <>c__DisplayClass30_0 RIn4hgY0iPRt0D2IjsD()
			{
				return WoNfBcYvKTlEtMvPfBv;
			}
		}

		public static DefenceComponent Instance;

		private EntityQuery VN4OwgMeHA;

		internal static DefenceComponent sgMlloRy2L2k5aWKmGt;

		public bool CheckOnRangeAttack
		{
			get
			{
				return ModConfig.Instance.DefenceCheckOnRangeAttack.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceCheckOnRangeAttack.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool CheckOnMeleeAttack
		{
			get
			{
				return ModConfig.Instance.DefenceCheckOnMeleeAttack.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceCheckOnMeleeAttack.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public float OwnRadius
		{
			get
			{
				return ModConfig.Instance.DefenceOwnRadius.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceOwnRadius.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public float ProjectileRadius
		{
			get
			{
				return ModConfig.Instance.DefenceProjectileRadius.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.DefenceProjectileRadius.Value = value;
						num2 = 0;
						if (760317395 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public float Tolerance
		{
			get
			{
				return ModConfig.Instance.DefenceTolerance.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceTolerance.Value = value;
						num2 = 0;
						if (1094201023 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public float MaxCheckDistance
		{
			get
			{
				return ModConfig.Instance.DefenceMaxCheckDistance.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.DefenceMaxCheckDistance.Value = value;
						num2 = 0;
						if (962215133 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public float MeleeAttackRange
		{
			get
			{
				return ModConfig.Instance.DefenceMeleeAttackRange.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceMeleeAttackRange.Value = value;
						num2 = 0;
						if (460822775 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public float MeleeAttackAngle
		{
			get
			{
				return ModConfig.Instance.DefenceMeleeAttackAngle.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.DefenceMeleeAttackAngle.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public byte DefenceKey => ModConfig.Instance.DefenceKey.Value;

		public void Awake()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (1783996735 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public override void UpdateLogic()
		{
			//IL_062c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Unknown result type (might be due to invalid IL or missing references)
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0661: Unknown result type (might be due to invalid IL or missing references)
			//IL_0666: Unknown result type (might be due to invalid IL or missing references)
			//IL_05de: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			int num = 51;
			bool flag10 = default(bool);
			<>c__DisplayClass29_0 <>c__DisplayClass29_ = default(<>c__DisplayClass29_0);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			Vector3 position2 = default(Vector3);
			bool flag7 = default(bool);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			bool flag5 = default(bool);
			bool flag11 = default(bool);
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			float3 position = default(float3);
			LocalToWorld component = default(LocalToWorld);
			bool flag8 = default(bool);
			Team componentData = default(Team);
			Team componentData2 = default(Team);
			bool flag2 = default(bool);
			bool flag4 = default(bool);
			bool flag12 = default(bool);
			Entity current = default(Entity);
			bool flag9 = default(bool);
			bool flag13 = default(bool);
			bool flag6 = default(bool);
			bool flag3 = default(bool);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 9:
					case 47:
						flag10 = <>c__DisplayClass29_.aQwyEfjvWt.Owner == mainPlayer.Entity;
						num2 = 1;
						if (497891482 == 0)
						{
							num2 = 1;
						}
						continue;
					case 37:
						position2 = mainPlayer.Position;
						num2 = 19;
						if (1848937442 == 0)
						{
							num2 = 11;
						}
						continue;
					case 39:
						if (flag7)
						{
							num2 = 6;
							if (0 == 0)
							{
								num2 = 27;
							}
							continue;
						}
						goto case 48;
					case 6:
					case 12:
					case 22:
					case 27:
					case 31:
					case 36:
					case 42:
					case 44:
						if (enumerator.MoveNext())
						{
							num2 = 21;
							continue;
						}
						return;
					case 28:
						if (flag5)
						{
							num = 23;
							break;
						}
						goto case 52;
					case 49:
						flag11 = playerWrapper.ClanName == mainPlayer.ClanName;
						num = 34;
						break;
					case 23:
						return;
					case 1:
						if (flag10)
						{
							num2 = 14;
							continue;
						}
						goto case 11;
					case 17:
						position = ((LocalToWorld)(ref component)).Position;
						num2 = 8;
						continue;
					case 45:
						InputSimulator.KeyboardPress(DefenceKey);
						num2 = 44;
						continue;
					case 43:
						flag8 = componentData.Value == componentData2.Value;
						num = 35;
						break;
					case 20:
						if (!flag2)
						{
							num2 = 40;
							continue;
						}
						goto case 6;
					default:
						flag5 = PlayersManager.Instance.MainPlayer == null;
						num2 = 28;
						continue;
					case 15:
						flag4 = playerWrapper != null;
						num2 = 38;
						continue;
					case 11:
						flag12 = current.TryGetComponent<Team>(out componentData);
						num2 = 25;
						continue;
					case 14:
						Plugin.LogInfo("PROJECTILE OWNER IS PLAYER: " + mainPlayer.Name);
						num2 = 42;
						continue;
					case 25:
						if (!flag12)
						{
							num2 = 2;
							if (0 == 0)
							{
								num2 = 29;
							}
							continue;
						}
						goto case 33;
					case 16:
						if (flag9)
						{
							num2 = 49;
							continue;
						}
						goto case 5;
					case 35:
						if (!flag8)
						{
							num2 = 53;
							continue;
						}
						goto case 6;
					case 30:
						if (!flag13)
						{
							num2 = 9;
							continue;
						}
						goto case 6;
					case 38:
						if (flag4)
						{
							num2 = 2;
							continue;
						}
						goto case 5;
					case 34:
						if (flag11)
						{
							num2 = 31;
							continue;
						}
						goto case 5;
					case 50:
						if (!flag6)
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 5:
						flag3 = CTNOSGOH6t(float3.op_Implicit(position), position2, ProjectileRadius, OwnRadius, Tolerance);
						num2 = 24;
						continue;
					case 52:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num2 = 37;
						continue;
					case 48:
						flag13 = !current.TryGetComponent<EntityOwner>(out <>c__DisplayClass29_.aQwyEfjvWt);
						num2 = 30;
						continue;
					case 29:
					case 41:
					case 53:
						playerWrapper = PlayersManager.Instance.Players.Find(<>c__DisplayClass29_.ILVyrB9pRR);
						num2 = 15;
						continue;
					case 13:
					case 40:
						flag9 = !string.IsNullOrEmpty(mainPlayer.ClanName);
						num2 = 16;
						if (1814018247 == 0)
						{
							num2 = 12;
						}
						continue;
					case 46:
						<>c__DisplayClass29_ = new <>c__DisplayClass29_0();
						num2 = 18;
						continue;
					case 8:
						flag7 = Vector3.Distance(float3.op_Implicit(position), position2) > 5f;
						num2 = 14;
						if (0 == 0)
						{
							num2 = 39;
						}
						continue;
					case 4:
						return;
					case 10:
						return;
					case 51:
						flag6 = !CheckOnRangeAttack;
						num2 = 0;
						if (121889664 != 0)
						{
							num2 = 50;
						}
						continue;
					case 7:
					case 21:
						current = enumerator.Current;
						num2 = 17;
						if (0 == 0)
						{
							num2 = 46;
						}
						continue;
					case 26:
						enumerator = val.GetEnumerator();
						num = 6;
						break;
					case 19:
						val = ((EntityQuery)(ref VN4OwgMeHA)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
						num2 = 26;
						continue;
					case 24:
						if (flag3)
						{
							num2 = 45;
							if (55114885 == 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 6;
					case 2:
						flag2 = playerWrapper.Entity == mainPlayer.Entity;
						num = 20;
						break;
					case 3:
						if (flag)
						{
							num2 = 43;
							continue;
						}
						goto case 29;
					case 18:
						component = current.GetComponent<LocalToWorld>();
						num2 = 17;
						continue;
					case 33:
						flag = mainPlayer.Entity.TryGetComponent<Team>(out componentData2);
						num2 = 3;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
			}
		}

		public void OnAbilitCast(Entity entity, AbilityDescription abilityDescription)
		{
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			int num = 18;
			bool flag9 = default(bool);
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			PlayerWrapper mainPlayer = default(PlayerWrapper);
			LocalToWorld componentData = default(LocalToWorld);
			bool flag7 = default(bool);
			bool flag3 = default(bool);
			Vector3 position = default(Vector3);
			<>c__DisplayClass30_0 <>c__DisplayClass30_ = default(<>c__DisplayClass30_0);
			bool flag8 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			bool flag = default(bool);
			bool flag5 = default(bool);
			bool flag6 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 19:
						flag9 = playerWrapper.ClanName == mainPlayer.ClanName;
						num2 = 6;
						continue;
					case 7:
					{
						float3 forward = ((LocalToWorld)(ref componentData)).Forward;
						num = 23;
						break;
					}
					case 39:
						flag7 = !string.IsNullOrEmpty(mainPlayer.ClanName);
						num2 = 0;
						if (1187184005 == 0)
						{
							num2 = 0;
						}
						continue;
					case 26:
						if (flag3)
						{
							num2 = 20;
							if (1433983997 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 10;
					case 30:
						if (abilityDescription.IsUltimate)
						{
							num2 = 20;
							if (1663994158 != 0)
							{
								num2 = 28;
							}
							continue;
						}
						goto case 37;
					case 27:
						position = mainPlayer.Position;
						num2 = 20;
						if (2093262890 != 0)
						{
							num2 = 21;
						}
						continue;
					case 18:
						<>c__DisplayClass30_ = new <>c__DisplayClass30_0();
						num = 17;
						break;
					case 3:
						flag8 = playerWrapper != null;
						num2 = 32;
						continue;
					case 15:
						if (!flag4)
						{
							num2 = 13;
							if (0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 33;
					case 14:
						return;
					case 5:
						if (flag2)
						{
							num2 = 2;
							continue;
						}
						goto case 11;
					case 6:
						if (!flag9)
						{
							num2 = 23;
							if (0 == 0)
							{
								num2 = 35;
							}
							continue;
						}
						return;
					default:
						if (flag7)
						{
							num2 = 19;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 31;
					case 32:
						if (flag8)
						{
							num2 = 8;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 31;
					case 12:
					case 25:
						flag = PlayersManager.Instance.MainPlayer == null;
						num2 = 16;
						if (0 != 0)
						{
							num2 = 15;
						}
						continue;
					case 8:
						flag5 = playerWrapper.Entity == mainPlayer.Entity;
						num2 = 24;
						if (0 == 0)
						{
							num2 = 24;
						}
						continue;
					case 20:
						return;
					case 10:
						flag6 = !<>c__DisplayClass30_.dF8yp9HAKB.TryGetComponent<LocalToWorld>(out componentData);
						num2 = 33;
						if (0 == 0)
						{
							num2 = 34;
						}
						continue;
					case 34:
						if (flag6)
						{
							return;
						}
						num2 = 5;
						if (1696499521 != 0)
						{
							num2 = 25;
						}
						continue;
					case 2:
						return;
					case 31:
					case 35:
					{
						float3 position2 = ((LocalToWorld)(ref componentData)).Position;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					case 24:
						if (flag5)
						{
							num2 = 38;
							continue;
						}
						goto case 39;
					case 1:
						return;
					case 38:
						return;
					case 13:
						return;
					case 17:
						<>c__DisplayClass30_.dF8yp9HAKB = entity;
						num2 = 4;
						continue;
					case 37:
						num3 = (abilityDescription.IsAoE ? 1 : 0);
						goto IL_059e;
					case 36:
						return;
					case 23:
						flag4 = tu7OGCIBbn(float3.op_Implicit(((LocalToWorld)(ref componentData)).Position), float3.op_Implicit(((LocalToWorld)(ref componentData)).Forward), position, MeleeAttackRange, MeleeAttackAngle);
						num2 = 10;
						if (0 == 0)
						{
							num2 = 15;
						}
						continue;
					case 33:
						InputSimulator.KeyboardPress(DefenceKey);
						num2 = 4;
						if (0 == 0)
						{
							num2 = 9;
						}
						continue;
					case 4:
						flag3 = !CheckOnMeleeAttack;
						num2 = 26;
						continue;
					case 11:
						playerWrapper = PlayersManager.Instance.Players.Find(<>c__DisplayClass30_.X3fyiSpHNf);
						num2 = 3;
						continue;
					case 22:
					case 29:
						mainPlayer = PlayersManager.Instance.MainPlayer;
						num2 = 9;
						if (0 == 0)
						{
							num2 = 27;
						}
						continue;
					case 21:
						if (!abilityDescription.IsDash)
						{
							num2 = 30;
							continue;
						}
						goto case 28;
					case 16:
						if (flag)
						{
							return;
						}
						num2 = 29;
						continue;
					case 9:
						return;
					case 28:
						{
							num3 = 1;
							goto IL_059e;
						}
						IL_059e:
						flag2 = (byte)num3 != 0;
						num2 = 5;
						continue;
					}
					break;
				}
			}
		}

		private static bool CTNOSGOH6t(Vector3 P_0, Vector3 P_1, float P_2, float P_3, float P_4 = 0.1f)
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			float num4 = default(float);
			float num3 = default(float);
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 3:
					num4 = P_2 + P_3 + P_4;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					num3 = Vector3.Distance(P_0, P_1);
					num2 = 2;
					if (0 == 0)
					{
						num2 = 3;
					}
					break;
				default:
					result = num3 <= num4;
					num2 = 1;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
				case 2:
					return result;
				}
			}
		}

		private static bool tu7OGCIBbn(Vector3 P_0, Vector3 P_1, Vector3 P_2, float P_3, float P_4)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			int num = 7;
			bool result = default(bool);
			Vector3 val = default(Vector3);
			Vector3 normalized = default(Vector3);
			bool flag = default(bool);
			float num4 = default(float);
			float num3 = default(float);
			float magnitude = default(float);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return result;
					case 7:
						val = P_2 - P_0;
						num = 6;
						break;
					case 1:
					case 12:
						normalized = ((Vector3)(ref val)).normalized;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 11;
						}
						continue;
					case 4:
						result = false;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						if (!flag)
						{
							num2 = 1;
							if (1131787544 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 4;
					case 11:
						num4 = Vector3.Dot(((Vector3)(ref P_1)).normalized, normalized);
						num2 = 3;
						continue;
					case 8:
						result = num3 <= P_4 * 0.5f;
						num = 9;
						break;
					case 6:
						magnitude = ((Vector3)(ref val)).magnitude;
						num2 = 5;
						if (0 != 0)
						{
							num2 = 4;
						}
						continue;
					case 5:
						flag = magnitude > P_3;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 10;
						}
						continue;
					case 3:
						num3 = Mathf.Acos(num4) * 57.29578f;
						num2 = 8;
						if (1668386183 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
			}
		}

		public DefenceComponent()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			EntityManager manager = EntityManagerWrapper.Manager;
			VN4OwgMeHA = ((EntityManager)(ref manager)).CreateEntityQuery((ComponentType[])(object)new ComponentType[2]
			{
				ComponentType.ReadOnly<Projectile>(),
				ComponentType.ReadOnly<LocalToWorld>()
			});
			base..ctor();
			int num = 0;
			if (2144623378 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool DlJtXhR4vO2V1ac4hIF()
		{
			return sgMlloRy2L2k5aWKmGt == null;
		}

		internal static DefenceComponent wJjrjRRId2b78KH3gwM()
		{
			return sgMlloRy2L2k5aWKmGt;
		}
	}
	public static class EntityManagerWrapper
	{
		internal static EntityManagerWrapper wMfYQGReSGcE7AePFJo;

		public static EntityManager Manager => VWorld.Client.EntityManager;

		private static PrefabCollectionSystem aLROlDSJhM => VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>();

		public static NativeArray<Entity> QueryEntities(EntityQueryDesc[] query)
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			int num2 = num;
			NativeArray<Entity> result = default(NativeArray<Entity>);
			EntityQuery val = default(EntityQuery);
			EntityManager manager = default(EntityManager);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = ((EntityQuery)(ref val)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
					num2 = 0;
					if (2058589287 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					val = ((EntityManager)(ref manager)).CreateEntityQuery(query);
					num2 = 1;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					manager = Manager;
					num2 = 3;
					break;
				}
			}
		}

		public static string GetPrefabName(PrefabGUID prefabGuid)
		{
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			string result = default(string);
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = default(NativeParallelHashMap<PrefabGUID, Entity>);
			PrefabLookupMap prefabLookupMap = default(PrefabLookupMap);
			while (true)
			{
				string text;
				switch (num2)
				{
				case 5:
					text = "GUID Not Found";
					break;
				case 1:
				case 4:
					return result;
				case 2:
					if (guidToEntityMap.ContainsKey(prefabGuid))
					{
						num2 = 6;
						continue;
					}
					goto case 5;
				case 3:
					guidToEntityMap = aLROlDSJhM._PrefabLookupMap.GuidToEntityMap;
					num2 = 2;
					if (1435992043 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					prefabLookupMap = aLROlDSJhM._PrefabLookupMap;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(prefabGuid);
					break;
				}
				result = text;
				num2 = 4;
			}
		}

		public static string GetPrefabDevName(PrefabGUID prefabGuid)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = aLROlDSJhM._PrefabLookupMap.GuidToEntityMap;
			string result;
			if (!guidToEntityMap.ContainsKey(prefabGuid))
			{
				result = "GUID Not Found";
			}
			else
			{
				PrefabLookupMap prefabLookupMap = aLROlDSJhM._PrefabLookupMap;
				result = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(prefabGuid) + " PrefabGuid(" + ((PrefabGUID)(ref prefabGuid)).GuidHash + ")";
			}
			return result;
		}

		public static bool HasComponent<T>(this Entity entity) where T : struct
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			EntityManager manager = Manager;
			return ((EntityManager)(ref manager)).HasComponent(entity, new ComponentType(Il2CppType.Of<T>(), (AccessMode)0));
		}

		public static T GetComponent<T>(this Entity entity) where T : struct
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			EntityManager manager = Manager;
			return ((EntityManager)(ref manager)).GetComponentData<T>(entity);
		}

		public static bool TryGetComponent<T>(this Entity entity, out T componentData) where T : struct
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			componentData = default(T);
			if (entity.HasComponent<T>())
			{
				componentData = entity.GetComponent<T>();
				return true;
			}
			return false;
		}

		internal static bool lKavN8RRwb9FXKdLGYh()
		{
			return wMfYQGReSGcE7AePFJo == null;
		}

		internal static EntityManagerWrapper uLZkyERYmKQJswy9GW8()
		{
			return wMfYQGReSGcE7AePFJo;
		}
	}
}
namespace VRisingBephinex.components.players
{
	public class PlayersManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass12_0
		{
			public string INcybw05L7;

			internal static <>c__DisplayClass12_0 Sb2RmXYVoG1L0cIgqOg;

			public <>c__DisplayClass12_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (1187184005 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool qMby77aThf(PlayerWrapper p)
			{
				return p.Name == INcybw05L7;
			}

			internal static bool NUb16dYHWB5xN4Ew2EO()
			{
				return Sb2RmXYVoG1L0cIgqOg == null;
			}

			internal static <>c__DisplayClass12_0 GTkdfUY9yhr6ubZNpLP()
			{
				return Sb2RmXYVoG1L0cIgqOg;
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass13_0
		{
			public string HebySTACmH;

			private static <>c__DisplayClass13_0 Bcp62IYN7F6q0DrLlJy;

			public <>c__DisplayClass13_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool bEiyC7MYqK(PlayerWrapper p)
			{
				return p.Name == HebySTACmH;
			}

			internal static bool so7SKeYjP1X6DY0l73j()
			{
				return Bcp62IYN7F6q0DrLlJy == null;
			}

			internal static <>c__DisplayClass13_0 rFD1daYdVsEmkcAIYRr()
			{
				return Bcp62IYN7F6q0DrLlJy;
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0
		{
			public PrefabGUID sjeywNdyVu;

			internal static <>c__DisplayClass15_0 GHo2jbY8n8lSIxeKg2n;

			public <>c__DisplayClass15_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool XjDyGWG1vp(AbilityDescription ab)
			{
				int num = 1;
				int num2 = num;
				int? spawnPrefab = default(int?);
				int value = default(int);
				while (true)
				{
					switch (num2)
					{
					case 1:
						spawnPrefab = ab.SpawnPrefab;
						num2 = 0;
						if (2144623378 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return spawnPrefab == value;
					default:
						value = sjeywNdyVu._Value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 2;
						}
						break;
					}
				}
			}

			internal static bool weJRUtYAil53eKoJwKC()
			{
				return GHo2jbY8n8lSIxeKg2n == null;
			}

			internal static <>c__DisplayClass15_0 L84TLeYmU8XTxmYPBpd()
			{
				return GHo2jbY8n8lSIxeKg2n;
			}
		}

		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			public PlayerCharacter mWtyWRUUXm;

			public PlayerWrapper PgbyBbqeDQ;

			internal static <>c__DisplayClass16_0 UsrXMRYJ2vNn8pvaCFa;

			public <>c__DisplayClass16_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool KM8ycCi1FZ(PlayerWrapper p)
			{
				return p.Name == ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref mWtyWRUUXm.Name)/*cast due to .constrained prefix*/).ToString();
			}

			internal bool mDLylhDeJH(string e)
			{
				return e == PgbyBbqeDQ.Name;
			}

			internal bool zffyfr6gUy(string e)
			{
				return e == PgbyBbqeDQ.Name;
			}

			internal static bool tAZEHQYZhoTlw23HguH()
			{
				return UsrXMRYJ2vNn8pvaCFa == null;
			}

			internal static <>c__DisplayClass16_0 aOT7v6Y1uy23BsaAPyO()
			{
				return UsrXMRYJ2vNn8pvaCFa;
			}
		}

		public static PlayersManager Instance;

		public List<PlayerWrapper> Players;

		private EntityQueryDesc[] t8AOMQ5guT;

		private EntityQueryDesc[] fcoOh66h15;

		private EntityQueryDesc[] TfdOvspBjG;

		private List<AbilityDescription> iy0OLXRfNR;

		private User IDZO0fMvJS;

		private List<string> wi1OV2c1wb;

		internal static PlayersManager NT0NhrRr0uB47Nj5WGO;

		public PlayerWrapper? MainPlayer
		{
			get
			{
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				int num = 1;
				int num2 = num;
				object result;
				while (true)
				{
					switch (num2)
					{
					case 2:
						result = null;
						break;
					case 1:
						if (IDZO0fMvJS != User.Empty)
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 2;
					default:
						result = Players.FirstOrDefault((PlayerWrapper P_0) => P_0.Name == ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref IDZO0fMvJS.CharacterName)/*cast due to .constrained prefix*/).ToString());
						break;
					}
					break;
				}
				return (PlayerWrapper?)result;
			}
		}

		public void Awake()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					iy0OLXRfNR = AbilityDatabase.GetDefenceAbilities();
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					Instance = this;
					num2 = 1;
					if (1783996735 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Update()
		{
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						break;
					case 3:
						rxOO52WqF5();
						num2 = 2;
						continue;
					case 4:
						L2HOfcBosk();
						num2 = 0;
						if (121889664 != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					case 2:
						BT2OWd2nHM();
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
				OefOBFq84b();
				num = 4;
			}
		}

		public void AddPlayerCooldown(string playerName, PrefabGUID abilityGUID, AbilityDescription abilityDescription)
		{
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			bool flag2 = default(bool);
			<>c__DisplayClass12_0 <>c__DisplayClass12_ = default(<>c__DisplayClass12_0);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 7:
						defaultInterpolatedStringHandler.AppendLiteral("Added cast time: ");
						num2 = 8;
						continue;
					case 4:
						playerWrapper.CastingTime += abilityDescription.MaxCastTime;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
					case 14:
						return;
					case 6:
						playerWrapper.AddCooldown(new PlayerCooldowns(abilityGUID, abilityDescription));
						num2 = 17;
						continue;
					case 16:
						Plugin.LogInfo(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 4;
						continue;
					case 1:
						if (!abilityDescription.IsDash)
						{
							num2 = 1;
							if (0 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto default;
					case 17:
						if (abilityDescription.IsAoE)
						{
							num2 = 11;
							continue;
						}
						goto case 12;
					case 15:
						flag2 = playerWrapper != null;
						num2 = 3;
						continue;
					case 13:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
						num2 = 7;
						continue;
					case 5:
						return;
					case 12:
						if (abilityDescription.IsDefence)
						{
							num2 = 0;
							if (1976142266 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					case 2:
						num3 = ((!abilityDescription.IsUltimate) ? 1 : 0);
						goto IL_026f;
					case 18:
						playerWrapper = Players.FirstOrDefault(<>c__DisplayClass12_.qMby77aThf);
						num2 = 15;
						continue;
					case 9:
						<>c__DisplayClass12_.INcybw05L7 = playerName;
						num2 = 18;
						continue;
					case 8:
						defaultInterpolatedStringHandler.AppendFormatted(abilityDescription.MaxCastTime);
						num = 16;
						break;
					case 10:
						<>c__DisplayClass12_ = new <>c__DisplayClass12_0();
						num2 = 9;
						continue;
					case 3:
						if (!flag2)
						{
							num = 14;
							break;
						}
						goto case 6;
					case 19:
						if (!flag)
						{
							return;
						}
						num2 = 13;
						continue;
					default:
						{
							num3 = 0;
							goto IL_026f;
						}
						IL_026f:
						flag = (byte)num3 != 0;
						num2 = 19;
						continue;
					}
					break;
				}
			}
		}

		public void AddPlayerProtectionTime(string playerName, float protectionTime)
		{
			int num = 11;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			bool flag = default(bool);
			PlayerWrapper playerWrapper = default(PlayerWrapper);
			<>c__DisplayClass13_0 <>c__DisplayClass13_ = default(<>c__DisplayClass13_0);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						defaultInterpolatedStringHandler.AppendLiteral("Adding protection time ");
						num2 = 4;
						if (0 == 0)
						{
							num2 = 4;
						}
						continue;
					case 13:
						if (!flag)
						{
							num2 = 0;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 9;
					case 14:
						playerWrapper.Dev += protectionTime;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 5:
						defaultInterpolatedStringHandler.AppendLiteral(" to player ");
						num2 = 10;
						if (2021314568 != 0)
						{
							num2 = 12;
						}
						continue;
					case 8:
						playerWrapper = Players.FirstOrDefault(<>c__DisplayClass13_.bEiyC7MYqK);
						num2 = 1;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 10:
						break;
					case 7:
						Plugin.LogInfo(defaultInterpolatedStringHandler.ToStringAndClear());
						num2 = 2;
						if (0 == 0)
						{
							num2 = 6;
						}
						continue;
					case 4:
						defaultInterpolatedStringHandler.AppendFormatted(protectionTime);
						num2 = 5;
						continue;
					case 0:
						return;
					case 1:
						return;
					case 6:
						playerWrapper.Kek += protectionTime;
						num2 = 14;
						continue;
					case 9:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
						num2 = 2;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 11:
						<>c__DisplayClass13_ = new <>c__DisplayClass13_0();
						num2 = 10;
						continue;
					case 12:
						defaultInterpolatedStringHandler.AppendFormatted(<>c__DisplayClass13_.HebySTACmH);
						num2 = 7;
						continue;
					case 3:
						flag = playerWrapper != null;
						num2 = 13;
						continue;
					}
					break;
				}
				<>c__DisplayClass13_.HebySTACmH = playerName;
				num = 8;
			}
		}

		private void L2HOfcBosk()
		{
			int num = 1;
			int num2 = num;
			List<PlayerWrapper>.Enumerator enumerator = default(List<PlayerWrapper>.Enumerator);
			PlayerWrapper current = default(PlayerWrapper);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					enumerator = Players.GetEnumerator();
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					while (true)
					{
						IL_00c8:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0080;
						}
						goto IL_009e;
						IL_0080:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 3:
								break;
							case 4:
								goto IL_00c8;
							default:
							{
								current.UpdateProtectionTime(Time.deltaTime);
								int num4 = 4;
								num3 = num4;
								continue;
							}
							case 1:
								current.UpdateCooldowns(Time.deltaTime);
								num3 = 0;
								if (0 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						goto IL_009e;
						IL_009e:
						current = enumerator.Current;
						num3 = 1;
						if (0 == 0)
						{
							num3 = 1;
						}
						goto IL_0080;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num5 = 0;
					if (460822775 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			}
		}

		private unsafe void BT2OWd2nHM()
		{
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			int num = 8;
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			<>c__DisplayClass15_0 <>c__DisplayClass15_ = default(<>c__DisplayClass15_0);
			bool flag = default(bool);
			EntityManager manager = default(EntityManager);
			Entity current = default(Entity);
			EntityOwner val3 = default(EntityOwner);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			PlayerCharacter val2 = default(PlayerCharacter);
			bool flag3 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						val = EntityManagerWrapper.QueryEntities(TfdOvspBjG);
						num2 = 20;
						continue;
					case 17:
						if (flag4)
						{
							num2 = 12;
							if (1435650279 == 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 4;
					default:
						flag2 = iy0OLXRfNR.Any(<>c__DisplayClass15_.XjDyGWG1vp);
						num2 = 9;
						if (0 != 0)
						{
							num2 = 6;
						}
						continue;
					case 1:
						flag = ((EntityManager)(ref manager)).TryGetComponentData<EntityOwner>(current, ref val3);
						num2 = 5;
						continue;
					case 4:
					case 14:
					case 18:
						if (!enumerator.MoveNext())
						{
							num2 = 11;
							continue;
						}
						goto case 13;
					case 11:
						return;
					case 5:
						if (flag)
						{
							num2 = 9;
							if (0 == 0)
							{
								num2 = 16;
							}
							continue;
						}
						goto case 4;
					case 3:
						break;
					case 8:
						wi1OV2c1wb.Clear();
						num2 = 7;
						continue;
					case 19:
						flag4 = ((EntityManager)(ref manager)).TryGetComponentData<PlayerCharacter>(val3.Owner, ref val2);
						num2 = 17;
						if (468683115 == 0)
						{
							num2 = 16;
						}
						continue;
					case 15:
						manager = EntityManagerWrapper.Manager;
						num2 = 1;
						if (747172065 == 0)
						{
							num2 = 1;
						}
						continue;
					case 10:
						if (flag3)
						{
							num2 = 0;
							if (10932459 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 2:
						<>c__DisplayClass15_ = new <>c__DisplayClass15_0();
						num2 = 6;
						continue;
					case 9:
						if (!flag2)
						{
							num2 = 18;
							continue;
						}
						goto case 15;
					case 12:
						wi1OV2c1wb.Add(((object)(*(FixedString64Bytes*)(&val2.Name))/*cast due to .constrained prefix*/).ToString());
						num2 = 4;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						manager = EntityManagerWrapper.Manager;
						num2 = 3;
						continue;
					case 13:
						current = enumerator.Current;
						num2 = 2;
						continue;
					case 16:
						manager = EntityManagerWrapper.Manager;
						num2 = 19;
						if (317387702 == 0)
						{
							num2 = 9;
						}
						continue;
					case 20:
						enumerator = val.GetEnumerator();
						num2 = 14;
						continue;
					}
					break;
				}
				flag3 = ((EntityManager)(ref manager)).TryGetComponentData<PrefabGUID>(current, ref <>c__DisplayClass15_.sjeywNdyVu);
				num = 10;
			}
		}

		private void OefOBFq84b()
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			NativeArray<Entity> val = EntityManagerWrapper.QueryEntities(t8AOMQ5guT);
			foreach (PlayerWrapper player in Players)
			{
				player.Entity = Entity.Null;
			}
			Enumerator<Entity> enumerator2 = val.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				Entity current2 = enumerator2.Current;
				<>c__DisplayClass16_0 CS$<>8__locals12 = new <>c__DisplayClass16_0();
				EntityManager manager = EntityManagerWrapper.Manager;
				CS$<>8__locals12.mWtyWRUUXm = ((EntityManager)(ref manager)).GetComponentData<PlayerCharacter>(current2);
				CS$<>8__locals12.PgbyBbqeDQ = Players.FirstOrDefault((PlayerWrapper p) => p.Name == ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref CS$<>8__locals12.mWtyWRUUXm.Name)/*cast due to .constrained prefix*/).ToString());
				if (CS$<>8__locals12.PgbyBbqeDQ != null)
				{
					CS$<>8__locals12.PgbyBbqeDQ.Entity = current2;
					CS$<>8__locals12.PgbyBbqeDQ.IsInDefence = wi1OV2c1wb.Any((string e) => e == CS$<>8__locals12.PgbyBbqeDQ.Name);
					CS$<>8__locals12.PgbyBbqeDQ.Update();
				}
				else
				{
					CS$<>8__locals12.PgbyBbqeDQ = new PlayerWrapper(current2);
					CS$<>8__locals12.PgbyBbqeDQ.IsInDefence = wi1OV2c1wb.Any((string e) => e == CS$<>8__locals12.PgbyBbqeDQ.Name);
					Players.Add(CS$<>8__locals12.PgbyBbqeDQ);
				}
			}
			val.Dispose();
		}

		private void rxOO52WqF5()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			bool flag = default(bool);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!flag)
					{
						num2 = 4;
						break;
					}
					goto case 6;
				case 1:
					val = EntityManagerWrapper.QueryEntities(fcoOh66h15);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
				{
					EntityManager manager = EntityManagerWrapper.Manager;
					IDZO0fMvJS = ((EntityManager)(ref manager)).GetComponentData<User>(val[0]);
					num2 = 3;
					break;
				}
				case 3:
				case 4:
					val.Dispose();
					num2 = 2;
					if (1131787544 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				default:
					flag = val.Length > 0;
					num2 = 5;
					if (1435650279 == 0)
					{
						num2 = 3;
					}
					break;
				}
			}
		}

		public PlayersManager()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Players = new List<PlayerWrapper>();
			EntityQueryDesc[] array = new EntityQueryDesc[1];
			EntityQueryDesc val = new EntityQueryDesc();
			val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[2]
			{
				ComponentType.ReadOnly<PlayerCharacter>(),
				ComponentType.ReadOnly<Health>()
			});
			array[0] = val;
			t8AOMQ5guT = (EntityQueryDesc[])(object)array;
			EntityQueryDesc[] array2 = new EntityQueryDesc[1];
			val = new EntityQueryDesc();
			val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<User>() });
			array2[0] = val;
			fcoOh66h15 = (EntityQueryDesc[])(object)array2;
			EntityQueryDesc[] array3 = new EntityQueryDesc[1];
			val = new EntityQueryDesc();
			val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<Buff>() });
			array3[0] = val;
			TfdOvspBjG = (EntityQueryDesc[])(object)array3;
			iy0OLXRfNR = new List<AbilityDescription>();
			IDZO0fMvJS = User.Empty;
			wi1OV2c1wb = new List<string>();
			((MonoBehaviour)this)..ctor();
			int num = 0;
			if (1427489184 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		[CompilerGenerated]
		private bool TXhO2eIOGd(PlayerWrapper P_0)
		{
			return P_0.Name == ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref IDZO0fMvJS.CharacterName)/*cast due to .constrained prefix*/).ToString();
		}

		internal static bool Bo6nmwREyjxKf8G96Hh()
		{
			return NT0NhrRr0uB47Nj5WGO == null;
		}

		internal static PlayersManager VqQARvRiQOpZiNfy4gd()
		{
			return NT0NhrRr0uB47Nj5WGO;
		}
	}
}
namespace VRisingBephinex.components.model
{
	public class EntityWrapper
	{
		public Entity Entity;

		public LocalToWorld LocalToWorld;

		public PrefabGUID GUID;

		public Health Health;

		public bool AimTarget;

		private static EntityWrapper mRUv1KRpyXyPWHGiYLW;

		public Vector3 Position => float3.op_Implicit(((LocalToWorld)(ref LocalToWorld)).Position);

		public float HP => math.round(Health.Value);

		public EntityWrapper(Entity entity)
		{
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			AimTarget = false;
			base..ctor();
			int num = 3;
			if (0 == 0)
			{
				num = 3;
			}
			EntityManager manager = default(EntityManager);
			while (true)
			{
				switch (num)
				{
				case 3:
					Entity = entity;
					num = 1;
					if (1835701918 != 0)
					{
						num = 1;
					}
					break;
				case 5:
					return;
				case 1:
					manager = EntityManagerWrapper.Manager;
					LocalToWorld = ((EntityManager)(ref manager)).GetComponentData<LocalToWorld>(entity);
					num = 4;
					break;
				case 2:
					manager = EntityManagerWrapper.Manager;
					num = 0;
					if (1427489184 != 0)
					{
						num = 0;
					}
					break;
				default:
					((EntityManager)(ref manager)).TryGetComponentData<Health>(entity, ref Health);
					num = 5;
					break;
				case 4:
					manager = EntityManagerWrapper.Manager;
					GUID = ((EntityManager)(ref manager)).GetComponentData<PrefabGUID>(entity);
					num = 2;
					if (0 == 0)
					{
						num = 2;
					}
					break;
				}
			}
		}

		public virtual void Update()
		{
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			int num = 7;
			int num2 = num;
			EntityManager manager = default(EntityManager);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 5:
					return;
				case 8:
					manager = EntityManagerWrapper.Manager;
					LocalToWorld = ((EntityManager)(ref manager)).GetComponentData<LocalToWorld>(Entity);
					num2 = 0;
					if (1256719316 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					manager = EntityManagerWrapper.Manager;
					num2 = 4;
					break;
				case 7:
					flag = !IsValid();
					num2 = 6;
					if (742265667 == 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					((EntityManager)(ref manager)).TryGetComponentData<Health>(Entity, ref Health);
					num2 = 2;
					if (1668386183 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					Entity = Entity.Null;
					num2 = 5;
					break;
				default:
					manager = EntityManagerWrapper.Manager;
					GUID = ((EntityManager)(ref manager)).GetComponentData<PrefabGUID>(Entity);
					num2 = 1;
					if (1848937442 == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					if (flag)
					{
						num2 = 3;
						if (0 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 8;
				}
			}
		}

		public bool IsValid()
		{
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			int num2 = num;
			EntityManager manager = default(EntityManager);
			bool result = default(bool);
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 2:
					if (((EntityManager)(ref manager)).Exists(Entity))
					{
						num2 = 0;
						if (1268266038 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					num3 = 0;
					break;
				default:
					num3 = ((Entity != Entity.Null) ? 1 : 0);
					break;
				case 3:
					manager = EntityManagerWrapper.Manager;
					num2 = 2;
					continue;
				case 1:
				case 4:
					return result;
				}
				result = (byte)num3 != 0;
				num2 = 1;
				if (0 != 0)
				{
					num2 = 1;
				}
			}
		}

		public string GetName()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			string prefabName = default(string);
			while (true)
			{
				switch (num2)
				{
				case 1:
					prefabName = GetPrefabName(GUID);
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return prefabName;
				}
			}
		}

		protected string GetPrefabName(PrefabGUID prefabGUID)
		{
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			PrefabLookupMap prefabLookupMap = default(PrefabLookupMap);
			string result = default(string);
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = default(NativeParallelHashMap<PrefabGUID, Entity>);
			while (true)
			{
				int num2 = num;
				string text;
				while (true)
				{
					switch (num2)
					{
					default:
						prefabLookupMap = Utils.PrefabsCollection._PrefabLookupMap;
						num2 = 6;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					case 4:
					case 5:
						return result;
					case 1:
						if (guidToEntityMap.ContainsKey(prefabGUID))
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
					case 3:
						text = "GUID Not Found";
						break;
					case 2:
						guidToEntityMap = Utils.PrefabsCollection._PrefabLookupMap.GuidToEntityMap;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						text = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(prefabGUID);
						break;
					}
					break;
				}
				result = text;
				num = 4;
			}
		}

		internal static bool RKcvOxR7WxLrQKml3q3()
		{
			return mRUv1KRpyXyPWHGiYLW == null;
		}

		internal static EntityWrapper YPTKSTRbkKO5LJPNFnw()
		{
			return mRUv1KRpyXyPWHGiYLW;
		}
	}
}
namespace VRisingBephinex.components.esp
{
	public abstract class ESPBase
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool CI0OHYPpjZ;

		protected List<Entity> _entities;

		private static ESPBase JELsTXRCXkxhRqqJeTo;

		protected static PrefabCollectionSystem PrefabCollectionSystem => VWorld.Client.GetExistingSystemManaged<PrefabCollectionSystem>();

		protected static EntityManager EntityManager => VWorld.Client.EntityManager;

		public virtual bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return CI0OHYPpjZ;
			}
			[CompilerGenerated]
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						CI0OHYPpjZ = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		protected abstract EntityQueryDesc[] query { get; }

		protected abstract Color DefaultColor { get; }

		public virtual void Collect()
		{
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			int num = 13;
			float3 position = default(float3);
			LocalToWorld componentData = default(LocalToWorld);
			EntityManager entityManager = default(EntityManager);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			string prefabName = default(string);
			PrefabGUID componentData2 = default(PrefabGUID);
			bool flag = default(bool);
			Entity current = default(Entity);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag3 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 29:
						position = ((LocalToWorld)(ref componentData)).Position;
						num2 = 20;
						if (0 == 0)
						{
							num2 = 22;
						}
						continue;
					case 2:
						entityManager = EntityManager;
						num2 = 5;
						if (0 == 0)
						{
							num2 = 19;
						}
						continue;
					case 22:
						flag4 = IsBehindCamera(float3.op_Implicit(position));
						num2 = 6;
						continue;
					case 5:
					case 24:
						_entities.Clear();
						num2 = 0;
						if (258562808 != 0)
						{
							num2 = 1;
						}
						continue;
					case 12:
						if (!flag2)
						{
							num2 = 24;
							continue;
						}
						return;
					case 11:
						prefabName = GetPrefabName(componentData2);
						num = 25;
						break;
					case 3:
						if (flag)
						{
							num2 = 28;
							if (0 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 9;
					case 4:
						return;
					case 7:
						return;
					case 8:
					case 21:
						_entities.Add(current);
						num2 = 11;
						if (0 == 0)
						{
							num2 = 15;
						}
						continue;
					case 14:
					case 16:
						current = enumerator.Current;
						num2 = 2;
						continue;
					case 6:
						if (flag4)
						{
							num2 = 20;
							if (1032184707 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 18;
					case 28:
						Application.Quit();
						num2 = 9;
						if (747172065 == 0)
						{
							num2 = 5;
						}
						continue;
					case 1:
						val = SearchEntities(query);
						num2 = 3;
						if (0 == 0)
						{
							num2 = 26;
						}
						continue;
					default:
						if (!flag3)
						{
							num = 8;
							break;
						}
						goto case 10;
					case 27:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 11;
						continue;
					case 19:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num = 29;
						break;
					case 9:
						flag3 = !FilterByName(prefabName);
						num2 = 0;
						if (55114885 != 0)
						{
							num2 = 0;
						}
						continue;
					case 13:
						flag2 = !Enabled;
						num = 12;
						break;
					case 26:
						enumerator = val.GetEnumerator();
						num2 = 23;
						continue;
					case 25:
						if (!string.IsNullOrEmpty(RootComponent.Instance.IsEnablid))
						{
							num2 = 17;
							continue;
						}
						num3 = 1;
						goto IL_03f7;
					case 18:
						entityManager = EntityManager;
						num2 = 27;
						if (0 != 0)
						{
							num2 = 25;
						}
						continue;
					case 17:
						num3 = (string.IsNullOrEmpty(RootComponent.Instance.IsMenuShowing) ? 1 : 0);
						goto IL_03f7;
					case 10:
					case 15:
					case 20:
					case 23:
						{
							if (!enumerator.MoveNext())
							{
								return;
							}
							num = 14;
							break;
						}
						IL_03f7:
						flag = (byte)num3 != 0;
						num2 = 3;
						if (0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
			}
		}

		public virtual void Show()
		{
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			int num = 6;
			int num2 = num;
			bool flag3 = default(bool);
			List<Entity>.Enumerator enumerator = default(List<Entity>.Enumerator);
			bool flag2 = default(bool);
			PrefabGUID componentData2 = default(PrefabGUID);
			EntityManager entityManager = default(EntityManager);
			Entity current = default(Entity);
			float3 position = default(float3);
			LocalToWorld componentData = default(LocalToWorld);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					return;
				case 6:
					flag3 = !Enabled;
					num2 = 5;
					break;
				case 5:
					if (flag3)
					{
						return;
					}
					num2 = 2;
					break;
				case 1:
				case 2:
					enumerator = _entities.GetEnumerator();
					num2 = 4;
					break;
				case 4:
					try
					{
						while (true)
						{
							IL_01d2:
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 4;
								num4 = num3;
								goto IL_00e9;
							}
							goto IL_01a7;
							IL_00e9:
							while (true)
							{
								switch (num4)
								{
								case 4:
									return;
								case 14:
									if (flag2)
									{
										num4 = 0;
										if (317387702 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto IL_01d2;
								case 1:
									componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
									num4 = 9;
									if (0 == 0)
									{
										num4 = 13;
									}
									continue;
								case 2:
									flag2 = ((EntityManager)(ref entityManager)).Exists(current);
									num4 = 14;
									continue;
								case 10:
									break;
								case 3:
								case 11:
									goto IL_01d2;
								case 7:
								case 8:
									entityManager = EntityManager;
									num4 = 0;
									if (0 == 0)
									{
										num4 = 1;
									}
									continue;
								case 15:
									entityManager = EntityManager;
									num4 = 0;
									if (2093262890 != 0)
									{
										num4 = 2;
									}
									continue;
								case 13:
									Draw(float3.op_Implicit(position), HandleName(GetPrefabName(componentData2)), DefaultColor);
									num4 = 11;
									continue;
								case 6:
									componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
									num4 = 1;
									if (0 == 0)
									{
										num4 = 5;
									}
									continue;
								case 12:
									flag = IsBehindCamera(float3.op_Implicit(position));
									num4 = 9;
									continue;
								case 9:
									if (flag)
									{
										goto IL_01d2;
									}
									num4 = 7;
									continue;
								default:
									entityManager = EntityManager;
									num4 = 6;
									continue;
								case 5:
									position = ((LocalToWorld)(ref componentData)).Position;
									num4 = 6;
									if (0 == 0)
									{
										num4 = 12;
									}
									continue;
								}
								break;
							}
							goto IL_01a7;
							IL_01a7:
							current = enumerator.Current;
							num4 = 7;
							if (0 == 0)
							{
								num4 = 15;
							}
							goto IL_00e9;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num5 = 0;
						if (0 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				}
			}
		}

		public virtual void OnUpdate()
		{
		}

		protected virtual string HandleName(string name)
		{
			int num = 2;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					result = name;
					num2 = 1;
					if (171252512 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return result;
				}
			}
		}

		protected virtual bool FilterByName(string name)
		{
			int num = 2;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 2:
					result = true;
					num2 = 1;
					if (696790966 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		protected NativeArray<Entity> SearchEntities(EntityQueryDesc[] query)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			EntityQuery val = default(EntityQuery);
			EntityManager entityManager = default(EntityManager);
			NativeArray<Entity> result = default(NativeArray<Entity>);
			while (true)
			{
				switch (num2)
				{
				default:
					val = ((EntityManager)(ref entityManager)).CreateEntityQuery(query);
					num2 = 3;
					break;
				case 1:
					entityManager = EntityManager;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
				case 4:
					return result;
				case 3:
					result = ((EntityQuery)(ref val)).ToEntityArray(AllocatorHandle.op_Implicit((Allocator)2));
					num2 = 0;
					if (0 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		protected string GetPrefabName(PrefabGUID prefabGuid)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = PrefabCollectionSystem._PrefabLookupMap.GuidToEntityMap;
			string result;
			if (!guidToEntityMap.ContainsKey(prefabGuid))
			{
				result = "GUID Not Found";
			}
			else
			{
				PrefabLookupMap prefabLookupMap = PrefabCollectionSystem._PrefabLookupMap;
				result = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(prefabGuid);
			}
			return result;
		}

		protected string GetPrefabDevName(PrefabGUID prefabGuid)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			NativeParallelHashMap<PrefabGUID, Entity> guidToEntityMap = PrefabCollectionSystem._PrefabLookupMap.GuidToEntityMap;
			string result;
			if (!guidToEntityMap.ContainsKey(prefabGuid))
			{
				result = "GUID Not Found";
			}
			else
			{
				PrefabLookupMap prefabLookupMap = PrefabCollectionSystem._PrefabLookupMap;
				result = ((PrefabLookupMap)(ref prefabLookupMap)).GetName(prefabGuid) + " PrefabGuid(" + ((PrefabGUID)(ref prefabGuid)).GuidHash + ")";
			}
			return result;
		}

		public void Draw(Vector3 position, string label, Color color)
		{
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			int num = 11;
			Vector3 val2 = default(Vector3);
			int num3 = default(int);
			float num4 = default(float);
			GUIStyle val = default(GUIStyle);
			bool flag2 = default(bool);
			Vector2 val3 = default(Vector2);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num5;
					switch (num2)
					{
					default:
						return;
					case 11:
						val2 = Camera.main.WorldToScreenPoint(position);
						num2 = 10;
						if (1435992043 == 0)
						{
							num2 = 10;
						}
						continue;
					case 14:
						num5 = ((!(val2.y <= 0f)) ? 1 : 0);
						break;
					case 2:
						num3 = 30 - (int)(num4 * 0.08f);
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						val.fontSize = num3;
						num2 = 2;
						if (11098130 != 0)
						{
							num2 = 6;
						}
						continue;
					case 4:
						num3 = 13;
						num2 = 5;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						if (!(val2.y > (float)Screen.height))
						{
							num2 = 17;
							continue;
						}
						goto IL_02af;
					case 5:
					case 18:
						val.normal.textColor = color;
						num2 = 8;
						continue;
					case 9:
						if (!flag2)
						{
							num2 = 18;
							continue;
						}
						goto case 4;
					case 17:
						if (!(val2.x > (float)Screen.width))
						{
							num2 = 15;
							continue;
						}
						goto IL_02af;
					case 6:
						val3 = val.CalcSize(new GUIContent(label));
						num2 = 11;
						if (0 == 0)
						{
							num2 = 13;
						}
						continue;
					case 10:
						goto end_IL_0012;
					case 13:
						GUI.Label(new Rect(val2.x - val3.x / 2f, (float)Screen.height - val2.y, val3.x, val3.y), label, val);
						num2 = 0;
						if (1629830925 == 0)
						{
							num2 = 0;
						}
						continue;
					case 15:
						if (!(val2.x < 0f))
						{
							num2 = 14;
							continue;
						}
						goto IL_02af;
					case 12:
						if (!(val2.z < 0f))
						{
							num2 = 3;
							continue;
						}
						goto IL_02af;
					case 1:
						flag2 = num3 <= 13;
						num2 = 9;
						continue;
					case 16:
						if (flag)
						{
							num2 = 7;
							continue;
						}
						return;
					case 0:
						return;
					case 7:
						{
							val = new GUIStyle();
							num2 = 2;
							continue;
						}
						IL_02af:
						num5 = 0;
						break;
					}
					flag = (byte)num5 != 0;
					num2 = 16;
					if (0 != 0)
					{
						num2 = 4;
					}
					continue;
					end_IL_0012:
					break;
				}
				num4 = Vector3.Distance(position, Vector3.zero);
				num = 12;
			}
		}

		protected bool IsBehindCamera(Vector3 position)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = !Utils.IsInView(position);
					num2 = 0;
					if (0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		protected ESPBase()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			CI0OHYPpjZ = false;
			_entities = new List<Entity>();
			base..ctor();
			int num = 0;
			if (133732588 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Pk7yOqRSWT6yl5SeT7U()
		{
			return JELsTXRCXkxhRqqJeTo == null;
		}

		internal static ESPBase bvOh0BRGTyIKGIBNmZh()
		{
			return JELsTXRCXkxhRqqJeTo;
		}
	}
	public class ESPBlood : ESPBase
	{
		private static ESPBlood qCBfmwRwQrGDQIqcPJ9;

		public override bool Enabled
		{
			get
			{
				return ModConfig.Instance.ESPBloodEnabled.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPBloodEnabled.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public float MinBloodQuality
		{
			get
			{
				return ModConfig.Instance.ESPBoodMinQuality.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPBoodMinQuality.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.Any = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<BloodConsumeSource>() });
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.red;

		public override void Collect()
		{
		}

		public override void Show()
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			if (!Enabled)
			{
				return;
			}
			foreach (CreatureWrapper creature in CreaturesManager.Instance.Creatures)
			{
				if (creature.IsValid() && !(creature.HP <= 0f) && !(creature.BloodQuality < MinBloodQuality) && !IsBehindCamera(creature.Position))
				{
					if (creature.IsVBlood)
					{
						Draw(creature.Position, "VBlood", DefaultColor);
						continue;
					}
					Vector3 position = creature.Position;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
					defaultInterpolatedStringHandler.AppendFormatted(creature.BloodName);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted(creature.BloodQuality);
					Draw(position, defaultInterpolatedStringHandler.ToStringAndClear(), DefaultColor);
				}
			}
		}

		public ESPBlood()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (1256719316 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool FTi8GkRcUMrWAxFdoHl()
		{
			return qCBfmwRwQrGDQIqcPJ9 == null;
		}

		internal static ESPBlood oKHWQeRldbd2hskR5Nh()
		{
			return qCBfmwRwQrGDQIqcPJ9;
		}
	}
	public class ESPCarriage : ESPBase
	{
		private List<int> bDxO9OkAbI;

		private static ESPCarriage sHlpD9RfvnHWjr95aDy;

		public override bool Enabled
		{
			get
			{
				return ModConfig.Instance.ESPCarriageEnabled.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPCarriageEnabled.Value = value;
						num2 = 0;
						if (2093262890 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[2]
				{
					ComponentType.ReadOnly<LocalToWorld>(),
					ComponentType.ReadOnly<PrefabGUID>()
				});
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => ColorEx.Violet;

		public override void Collect()
		{
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			int num = 15;
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			LocalToWorld componentData = default(LocalToWorld);
			EntityManager entityManager = default(EntityManager);
			Entity current = default(Entity);
			bool flag3 = default(bool);
			float3 position = default(float3);
			bool flag2 = default(bool);
			PrefabGUID componentData2 = default(PrefabGUID);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 4:
					case 19:
					case 21:
						if (!enumerator.MoveNext())
						{
							num = 23;
							break;
						}
						goto case 1;
					case 20:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num = 17;
						break;
					case 14:
						if (!flag3)
						{
							num2 = 11;
							continue;
						}
						return;
					case 12:
						return;
					case 23:
						return;
					case 22:
						entityManager = ESPBase.EntityManager;
						num2 = 20;
						if (0 != 0)
						{
							num2 = 15;
						}
						continue;
					case 17:
						position = ((LocalToWorld)(ref componentData)).Position;
						num2 = 6;
						continue;
					case 11:
					case 18:
						_entities.Clear();
						num2 = 7;
						continue;
					case 3:
						flag2 = !bDxO9OkAbI.Contains(componentData2._Value);
						num2 = 5;
						continue;
					case 13:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 3;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 7:
						val = SearchEntities(query);
						num2 = 9;
						continue;
					case 8:
						_entities.Add(current);
						num2 = 2;
						if (171252512 == 0)
						{
							num2 = 1;
						}
						continue;
					case 9:
						enumerator = val.GetEnumerator();
						num2 = 19;
						continue;
					case 15:
						flag3 = !Enabled;
						num2 = 14;
						continue;
					case 6:
						flag = IsBehindCamera(float3.op_Implicit(position));
						num2 = 0;
						if (1814018247 != 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
					case 16:
						entityManager = ESPBase.EntityManager;
						num = 13;
						break;
					case 5:
						if (flag2)
						{
							num2 = 4;
							if (0 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 8;
					default:
						if (flag)
						{
							goto case 2;
						}
						num2 = 13;
						if (0 == 0)
						{
							num2 = 16;
						}
						continue;
					case 1:
						current = enumerator.Current;
						num2 = 15;
						if (0 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					break;
				}
			}
		}

		public override void Show()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			if (!Enabled)
			{
				return;
			}
			foreach (Entity entity in _entities)
			{
				EntityManager entityManager = ESPBase.EntityManager;
				if (((EntityManager)(ref entityManager)).Exists(entity))
				{
					entityManager = ESPBase.EntityManager;
					LocalToWorld componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(entity);
					float3 position = ((LocalToWorld)(ref componentData)).Position;
					if (!IsBehindCamera(float3.op_Implicit(position)))
					{
						Draw(float3.op_Implicit(position), "Carriage", DefaultColor);
					}
				}
			}
		}

		public ESPCarriage()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			bDxO9OkAbI = new List<int> { 731857280, -584529203 };
			base..ctor();
			int num = 0;
			if (11098130 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool LIDB5tRWAxRE4Hn5iGi()
		{
			return sHlpD9RfvnHWjr95aDy == null;
		}

		internal static ESPCarriage BpOhaSRBX40hQ21pDuG()
		{
			return sHlpD9RfvnHWjr95aDy;
		}
	}
	public class ESPContainer : ESPBase
	{
		internal static ESPContainer BOhoTwR5EXHCY1WvPJR;

		public override bool Enabled
		{
			get
			{
				int num = 2;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						int result;
						switch (num2)
						{
						default:
							if (!DeathContainer)
							{
								num2 = 3;
								continue;
							}
							goto case 1;
						case 2:
							if (Chest)
							{
								num2 = 0;
								if (0 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto default;
						case 4:
							result = (ResourceDrop ? 1 : 0);
							break;
						case 3:
							if (!PlayerDrop)
							{
								goto end_IL_0012;
							}
							goto case 1;
						case 1:
							result = 1;
							break;
						}
						return (byte)result != 0;
						continue;
						end_IL_0012:
						break;
					}
					num = 4;
				}
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						base.Enabled = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool Chest
		{
			get
			{
				return ModConfig.Instance.ESPContainerChest.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPContainerChest.Value = value;
						num2 = 0;
						if (444950165 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool DeathContainer
		{
			get
			{
				return ModConfig.Instance.ESPContainerDeathContainer.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPContainerDeathContainer.Value = value;
						num2 = 0;
						if (317387702 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool PlayerDrop
		{
			get
			{
				return ModConfig.Instance.ESPContainerPlayerDrop.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPContainerPlayerDrop.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool ResourceDrop
		{
			get
			{
				return ModConfig.Instance.ESPContainerResourceDrop.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPContainerResourceDrop.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool Furniture
		{
			get
			{
				return ModConfig.Instance.ESPContainerFurniture.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPContainerFurniture.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0036: Unknown result type (might be due to invalid IL or missing references)
				//IL_0050: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0085: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[3]
				{
					ComponentType.ReadOnly<LocalToWorld>(),
					ComponentType.ReadOnly<PrefabGUID>(),
					ComponentType.ReadOnly<InventoryOwner>()
				});
				val.None = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[5]
				{
					ComponentType.ReadOnly<BlueprintData>(),
					ComponentType.ReadOnly<DismantleDestroyData>(),
					ComponentType.ReadOnly<TakeDamageInSun>(),
					ComponentType.ReadOnly<ServantEquipment>(),
					ComponentType.ReadOnly<Trader>()
				});
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.yellow;

		public override void Collect()
		{
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0579: Unknown result type (might be due to invalid IL or missing references)
			//IL_072b: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0732: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_07da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0777: Unknown result type (might be due to invalid IL or missing references)
			//IL_077c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
			int num = 40;
			string prefabName = default(string);
			EntityManager entityManager = default(EntityManager);
			bool flag2 = default(bool);
			bool flag7 = default(bool);
			Entity current = default(Entity);
			bool flag6 = default(bool);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag4 = default(bool);
			LocalToWorld componentData2 = default(LocalToWorld);
			float3 position = default(float3);
			bool flag5 = default(bool);
			bool flag3 = default(bool);
			PrefabGUID componentData = default(PrefabGUID);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					int num7;
					int num6;
					int num5;
					int num4;
					switch (num2)
					{
					case 35:
						if (!ResourceDrop)
						{
							num2 = 5;
							continue;
						}
						goto case 31;
					case 19:
						if (prefabName.IndexOf("Chest") == -1)
						{
							num2 = 54;
							continue;
						}
						goto case 23;
					case 9:
					case 52:
						entityManager = ESPBase.EntityManager;
						num2 = 4;
						continue;
					case 40:
						flag2 = !Enabled;
						num2 = 23;
						if (460822775 != 0)
						{
							num2 = 39;
						}
						continue;
					case 33:
						if (flag7)
						{
							num2 = 32;
							if (1793150317 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 35;
					case 31:
						num3 = ((prefabName.IndexOf("Resource_Drop_") != -1) ? 1 : 0);
						goto IL_084f;
					case 56:
						_entities.Add(current);
						num2 = 14;
						continue;
					case 48:
						if (!Chest)
						{
							num2 = 46;
							continue;
						}
						goto case 57;
					case 2:
						return;
					case 49:
						if (!DeathContainer)
						{
							num2 = 47;
							continue;
						}
						goto case 44;
					case 3:
						if (prefabName.IndexOf("Resource_Drop_") == -1)
						{
							num2 = 19;
							continue;
						}
						goto case 23;
					case 53:
						_entities.Add(current);
						num = 41;
						break;
					case 38:
						if (!flag6)
						{
							num2 = 9;
							continue;
						}
						goto case 6;
					case 24:
						if (!(prefabName != "Resource_PlayerEntireInventoryContainer_Drop"))
						{
							num2 = 42;
							continue;
						}
						goto case 22;
					case 7:
						enumerator = val.GetEnumerator();
						num2 = 6;
						continue;
					case 11:
						_entities.Add(current);
						num2 = 1;
						if (0 == 0)
						{
							num2 = 12;
						}
						continue;
					case 59:
						return;
					default:
						val = SearchEntities(query);
						num2 = 7;
						continue;
					case 36:
						if (!flag4)
						{
							num2 = 13;
							if (852228814 == 0)
							{
								num2 = 13;
							}
							continue;
						}
						goto case 11;
					case 54:
						num7 = ((prefabName.IndexOf("_Full") != -1) ? 1 : 0);
						goto IL_0860;
					case 18:
					case 45:
						if (PlayerDrop)
						{
							num2 = 8;
							continue;
						}
						num6 = 0;
						goto IL_0842;
					case 6:
					case 12:
					case 14:
					case 15:
					case 28:
					case 29:
					case 41:
					case 50:
					case 51:
						if (!enumerator.MoveNext())
						{
							return;
						}
						num2 = 17;
						continue;
					case 39:
						if (flag2)
						{
							return;
						}
						num2 = 12;
						if (0 == 0)
						{
							num2 = 27;
						}
						continue;
					case 8:
						num6 = ((prefabName == "Resource_PlayerEntireInventoryContainer_Drop") ? 1 : 0);
						goto IL_0842;
					case 16:
					case 17:
						current = enumerator.Current;
						num2 = 58;
						continue;
					case 44:
						num5 = ((prefabName == "Resource_PlayerDeathContainer_Drop") ? 1 : 0);
						goto IL_0813;
					case 1:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num2 = 43;
						if (1522668693 == 0)
						{
							num2 = 9;
						}
						continue;
					case 13:
					case 55:
						if (!Furniture)
						{
							num2 = 25;
							continue;
						}
						goto case 24;
					case 58:
						entityManager = ESPBase.EntityManager;
						num2 = 1;
						if (1433983997 == 0)
						{
							num2 = 0;
						}
						continue;
					case 20:
					case 27:
						_entities.Clear();
						num2 = 0;
						if (1663994158 == 0)
						{
							num2 = 0;
						}
						continue;
					case 26:
						flag6 = IsBehindCamera(float3.op_Implicit(position));
						num2 = 38;
						continue;
					case 32:
						_entities.Add(current);
						num2 = 29;
						continue;
					case 57:
						num4 = ((prefabName.IndexOf("Chest") != -1) ? 1 : 0);
						goto IL_0835;
					case 30:
						if (!flag5)
						{
							num2 = 2;
							if (2035096834 != 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 53;
					case 10:
						if (!flag3)
						{
							num2 = 14;
							if (11098130 != 0)
							{
								num2 = 45;
							}
							continue;
						}
						goto case 21;
					case 4:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 37;
						continue;
					case 22:
						if (!(prefabName != "Resource_PlayerDeathContainer_Drop"))
						{
							num2 = 23;
							continue;
						}
						goto case 3;
					case 43:
						position = ((LocalToWorld)(ref componentData2)).Position;
						num2 = 25;
						if (0 == 0)
						{
							num2 = 26;
						}
						continue;
					case 21:
						_entities.Add(current);
						num2 = 51;
						continue;
					case 37:
						prefabName = GetPrefabName(componentData);
						num2 = 49;
						continue;
					case 34:
						if (flag)
						{
							num = 56;
							break;
						}
						goto case 48;
					case 47:
						num5 = 0;
						goto IL_0813;
					case 46:
						num4 = 0;
						goto IL_0835;
					case 5:
						num3 = 0;
						goto IL_084f;
					case 23:
					case 25:
					case 42:
						{
							num7 = 0;
							goto IL_0860;
						}
						IL_084f:
						flag4 = (byte)num3 != 0;
						num = 36;
						break;
						IL_0813:
						flag = (byte)num5 != 0;
						num2 = 31;
						if (1131787544 != 0)
						{
							num2 = 34;
						}
						continue;
						IL_0842:
						flag7 = (byte)num6 != 0;
						num2 = 33;
						continue;
						IL_0835:
						flag3 = (byte)num4 != 0;
						num2 = 10;
						continue;
						IL_0860:
						flag5 = (byte)num7 != 0;
						num = 30;
						break;
					}
					break;
				}
			}
		}

		public override void Show()
		{
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0386: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_054c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0449: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num2 = num;
			List<Entity>.Enumerator enumerator = default(List<Entity>.Enumerator);
			float3 position = default(float3);
			LocalToWorld componentData = default(LocalToWorld);
			bool flag2 = default(bool);
			string text2 = default(string);
			EntityManager entityManager = default(EntityManager);
			PrefabGUID componentData2 = default(PrefabGUID);
			Entity current = default(Entity);
			bool flag6 = default(bool);
			bool flag8 = default(bool);
			bool flag5 = default(bool);
			bool flag7 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					try
					{
						while (true)
						{
							IL_05d5:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 27;
								goto IL_0048;
							}
							goto IL_0481;
							IL_0048:
							while (true)
							{
								int num4;
								string text;
								switch (num3)
								{
								case 10:
									position = ((LocalToWorld)(ref componentData)).Position;
									num3 = 3;
									continue;
								case 14:
									flag2 = text2.IndexOf("_Full") != -1;
									num3 = 31;
									continue;
								case 26:
									Draw(float3.op_Implicit(position), text2, Color.yellow);
									num3 = 0;
									if (1522668693 == 0)
									{
										num3 = 0;
									}
									continue;
								case 4:
									entityManager = ESPBase.EntityManager;
									num3 = 13;
									if (0 == 0)
									{
										num3 = 20;
									}
									continue;
								case 25:
									componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
									num3 = 34;
									continue;
								case 24:
									entityManager = ESPBase.EntityManager;
									num3 = 11;
									continue;
								case 13:
								case 33:
									flag6 = text2.IndexOf("Chest") != -1;
									num3 = 17;
									continue;
								case 39:
									Draw(float3.op_Implicit(position), text2, Color.green);
									num3 = 15;
									if (247204215 == 0)
									{
										num3 = 3;
									}
									continue;
								case 3:
									flag8 = IsBehindCamera(float3.op_Implicit(position));
									num3 = 0;
									if (0 == 0)
									{
										num3 = 22;
									}
									continue;
								case 7:
									text2 = "Player Drop";
									num3 = 1;
									if (1268266038 == 0)
									{
										num3 = 1;
									}
									continue;
								case 1:
									Draw(float3.op_Implicit(position), text2, Color.red);
									num3 = 14;
									continue;
								case 35:
									flag5 = text2.IndexOf("Resource_Drop_") != -1;
									num4 = 18;
									goto IL_0044;
								case 21:
									text = "Epic Chest";
									goto IL_06bb;
								case 12:
									Draw(float3.op_Implicit(position), "Furniture", new Color(0.5f, 0.5f, 0f));
									num3 = 30;
									continue;
								case 32:
								case 37:
									entityManager = ESPBase.EntityManager;
									num3 = 25;
									continue;
								case 22:
									if (flag8)
									{
										goto IL_05d5;
									}
									num3 = 37;
									continue;
								case 19:
									if (text2.IndexOf("Simple") <= -1)
									{
										num3 = 21;
										continue;
									}
									text = "Simple Chest";
									goto IL_06bb;
								case 6:
									if (flag7)
									{
										num3 = 7;
										if (0 == 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto case 14;
								case 34:
									text2 = GetPrefabName(componentData2);
									num3 = 16;
									if (0 != 0)
									{
										num3 = 7;
									}
									continue;
								case 2:
									break;
								case 8:
									text2 = "Death Container";
									num3 = 18;
									if (0 == 0)
									{
										num3 = 28;
									}
									continue;
								case 28:
									Draw(float3.op_Implicit(position), text2, Color.red);
									num3 = 23;
									if (460822775 == 0)
									{
										num3 = 20;
									}
									continue;
								case 16:
									flag3 = text2 == "Resource_PlayerDeathContainer_Drop";
									num3 = 29;
									continue;
								case 17:
									if (flag6)
									{
										num3 = 19;
										continue;
									}
									goto case 38;
								case 20:
									componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
									num4 = 10;
									goto IL_0044;
								case 18:
									if (!flag5)
									{
										num3 = 23;
										if (742265667 != 0)
										{
											num3 = 33;
										}
										continue;
									}
									goto case 5;
								case 11:
									flag4 = ((EntityManager)(ref entityManager)).Exists(current);
									num3 = 9;
									if (747172065 != 0)
									{
										num3 = 9;
									}
									continue;
								default:
									goto IL_05d5;
								case 38:
									flag7 = text2 == "Resource_PlayerEntireInventoryContainer_Drop";
									num3 = 6;
									continue;
								case 9:
									if (!flag4)
									{
										num4 = 40;
										goto IL_0044;
									}
									goto case 4;
								case 29:
									if (flag3)
									{
										num3 = 8;
										continue;
									}
									goto case 35;
								case 5:
									text2 = text2.Replace("Drop_", "");
									num3 = 39;
									continue;
								case 31:
									if (flag2)
									{
										num3 = 12;
										if (962215133 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto IL_05d5;
								case 27:
									return;
									IL_06bb:
									text2 = text;
									num3 = 26;
									continue;
									IL_0044:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0481;
							IL_0481:
							current = enumerator.Current;
							num3 = 24;
							goto IL_0048;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num5 = 0;
						if (0 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 3:
					enumerator = _entities.GetEnumerator();
					num2 = 4;
					if (374085082 != 0)
					{
						num2 = 4;
					}
					break;
				case 0:
					return;
				case 5:
					return;
				case 1:
					if (flag)
					{
						num2 = 5;
						break;
					}
					goto case 3;
				case 2:
					flag = !Enabled;
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		protected override bool FilterByName(string name)
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = name.IndexOf("Chest") != -1;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return result;
				}
			}
		}

		protected override string HandleName(string name)
		{
			int num = 2;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				string text;
				switch (num2)
				{
				default:
					return result;
				case 1:
					text = "Epic Chest";
					break;
				case 2:
					if (name.IndexOf("Simple") <= -1)
					{
						num2 = 1;
						if (1522668693 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					text = "Simple Chest";
					break;
				}
				result = text;
				num2 = 3;
			}
		}

		public ESPContainer()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool mv3bgMR2SVFFUIymQHQ()
		{
			return BOhoTwR5EXHCY1WvPJR == null;
		}

		internal static ESPContainer EDP2QgRMV6VQvLenpRe()
		{
			return BOhoTwR5EXHCY1WvPJR;
		}
	}
	public class ESPFish : ESPBase
	{
		private static ESPFish lSvG5QRhjTeNfLrSGbi;

		public override bool Enabled
		{
			get
			{
				return ModConfig.Instance.ESPFish.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPFish.Value = value;
						num2 = 0;
						if (760317395 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<EntityInput>() });
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.green;

		public override void Collect()
		{
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			int num = 16;
			PrefabGUID componentData = default(PrefabGUID);
			EntityManager entityManager = default(EntityManager);
			Entity current = default(Entity);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			bool flag2 = default(bool);
			float3 position = default(float3);
			bool flag3 = default(bool);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag = default(bool);
			LocalToWorld componentData2 = default(LocalToWorld);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 21:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 20;
						continue;
					case 6:
					case 7:
					case 19:
					case 22:
						if (!enumerator.MoveNext())
						{
							num2 = 0;
							if (1185518701 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 13;
					case 23:
						flag2 = IsBehindCamera(float3.op_Implicit(position));
						num2 = 24;
						continue;
					case 16:
						flag3 = !Enabled;
						num = 15;
						break;
					case 11:
						val = SearchEntities(query);
						num2 = 10;
						continue;
					case 14:
						return;
					case 10:
						enumerator = val.GetEnumerator();
						num2 = 22;
						continue;
					default:
						_entities.Clear();
						num2 = 11;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 8:
						if (flag)
						{
							goto case 6;
						}
						num2 = 4;
						if (1433983997 == 0)
						{
							num2 = 3;
						}
						continue;
					case 15:
						if (flag3)
						{
							return;
						}
						num2 = 18;
						continue;
					case 2:
						return;
					case 24:
						if (flag2)
						{
							goto case 6;
						}
						num = 9;
						break;
					case 4:
					case 12:
						_entities.Add(current);
						num2 = 19;
						if (0 != 0)
						{
							num2 = 7;
						}
						continue;
					case 17:
						position = ((LocalToWorld)(ref componentData2)).Position;
						num2 = 23;
						continue;
					case 1:
					case 9:
						entityManager = ESPBase.EntityManager;
						num2 = 14;
						if (1976142266 != 0)
						{
							num2 = 21;
						}
						continue;
					case 5:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num = 17;
						break;
					case 13:
						current = enumerator.Current;
						num2 = 3;
						continue;
					case 20:
						flag = componentData._Value != 1559481073;
						num2 = 5;
						if (0 == 0)
						{
							num2 = 8;
						}
						continue;
					case 3:
						entityManager = ESPBase.EntityManager;
						num2 = 5;
						continue;
					}
					break;
				}
			}
		}

		public override void Show()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			if (!Enabled)
			{
				return;
			}
			foreach (Entity entity in _entities)
			{
				EntityManager entityManager = ESPBase.EntityManager;
				if (((EntityManager)(ref entityManager)).Exists(entity))
				{
					entityManager = ESPBase.EntityManager;
					LocalToWorld componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(entity);
					float3 position = ((LocalToWorld)(ref componentData)).Position;
					if (!IsBehindCamera(float3.op_Implicit(position)))
					{
						Draw(float3.op_Implicit(position), "Fish", DefaultColor);
					}
				}
			}
		}

		public ESPFish()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (1663994158 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool HlNqgPRv6WP4LKaNHpM()
		{
			return lSvG5QRhjTeNfLrSGbi == null;
		}

		internal static ESPFish Kh8XTGRLYncuJQ5UXEf()
		{
			return lSvG5QRhjTeNfLrSGbi;
		}
	}
	public class ESPHorses : ESPBase
	{
		private static ESPHorses BnqHlJR0QFdReXHo6D6;

		public override bool Enabled
		{
			get
			{
				return ModConfig.Instance.ESPHorseEnabled.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPHorseEnabled.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public float MinSpeed
		{
			get
			{
				return ModConfig.Instance.ESPHorseMinSpeed.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPHorseMinSpeed.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.Any = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<Mountable>() });
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.magenta;

		public override void Show()
		{
			//IL_04db: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0644: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0404: Unknown result type (might be due to invalid IL or missing references)
			//IL_0577: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0477: Unknown result type (might be due to invalid IL or missing references)
			//IL_0479: Unknown result type (might be due to invalid IL or missing references)
			//IL_0481: Unknown result type (might be due to invalid IL or missing references)
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			List<Entity>.Enumerator enumerator = default(List<Entity>.Enumerator);
			bool flag4 = default(bool);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			EntityManager entityManager = default(EntityManager);
			bool flag = default(bool);
			PrefabGUID componentData2 = default(PrefabGUID);
			Entity current = default(Entity);
			string label = default(string);
			bool flag3 = default(bool);
			float3 position = default(float3);
			Mountable componentData = default(Mountable);
			bool flag2 = default(bool);
			LocalToWorld componentData3 = default(LocalToWorld);
			string value = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						enumerator = _entities.GetEnumerator();
						num2 = 2;
						if (0 == 0)
						{
							num2 = 2;
						}
						break;
					case 3:
						return;
					default:
						if (flag4)
						{
							goto end_IL_0012;
						}
						goto case 4;
					case 1:
						flag4 = !Enabled;
						num2 = 0;
						if (577280904 == 0)
						{
							num2 = 0;
						}
						break;
					case 5:
						return;
					case 2:
						try
						{
							while (true)
							{
								int num3;
								if (!enumerator.MoveNext())
								{
									num3 = 17;
									goto IL_00da;
								}
								goto IL_04d9;
								IL_00da:
								while (true)
								{
									int num4;
									switch (num3)
									{
									case 17:
										return;
									case 11:
										defaultInterpolatedStringHandler.AppendLiteral(" [A:");
										num4 = 28;
										goto IL_00d6;
									case 23:
									case 26:
										entityManager = ESPBase.EntityManager;
										num3 = 13;
										continue;
									case 25:
										defaultInterpolatedStringHandler.AppendLiteral("]");
										num3 = 8;
										continue;
									case 22:
										entityManager = ESPBase.EntityManager;
										num3 = 4;
										if (1976142266 != 0)
										{
											num3 = 18;
										}
										continue;
									case 3:
										if (!flag)
										{
											num3 = 23;
											continue;
										}
										break;
									case 13:
										componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
										num3 = 0;
										if (0 == 0)
										{
											num3 = 0;
										}
										continue;
									case 8:
										label = defaultInterpolatedStringHandler.ToStringAndClear();
										num4 = 27;
										goto IL_00d6;
									case 12:
										flag3 = IsBehindCamera(float3.op_Implicit(position));
										num3 = 33;
										continue;
									case 4:
									case 20:
									case 21:
									case 30:
										break;
									case 31:
										defaultInterpolatedStringHandler.AppendLiteral("|R:");
										num3 = 10;
										continue;
									case 7:
										defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
										num3 = 6;
										continue;
									case 9:
										defaultInterpolatedStringHandler.AppendLiteral("|S:");
										num3 = 15;
										if (760317395 == 0)
										{
											num3 = 1;
										}
										continue;
									case 10:
										defaultInterpolatedStringHandler.AppendFormatted(componentData.RotationSpeed, "0.0");
										num3 = 25;
										continue;
									case 24:
									case 32:
										entityManager = ESPBase.EntityManager;
										num3 = 14;
										continue;
									case 29:
										if (!flag2)
										{
											num3 = 21;
											continue;
										}
										goto case 2;
									case 16:
										position = ((LocalToWorld)(ref componentData3)).Position;
										num3 = 12;
										if (1663994158 == 0)
										{
											num3 = 9;
										}
										continue;
									case 28:
										defaultInterpolatedStringHandler.AppendFormatted(componentData.Acceleration, "0.0");
										num3 = 9;
										continue;
									case 6:
										defaultInterpolatedStringHandler.AppendFormatted(value);
										num4 = 11;
										goto IL_00d6;
									case 27:
										Draw(float3.op_Implicit(position), label, DefaultColor);
										num3 = 11;
										if (0 == 0)
										{
											num3 = 20;
										}
										continue;
									case 2:
										entityManager = ESPBase.EntityManager;
										num4 = 19;
										goto IL_00d6;
									case 19:
										componentData3 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
										num4 = 16;
										goto IL_00d6;
									case 5:
										goto IL_04d9;
									case 15:
										defaultInterpolatedStringHandler.AppendFormatted(componentData.MaxSpeed, "0.0");
										num3 = 20;
										if (0 == 0)
										{
											num3 = 31;
										}
										continue;
									case 14:
										componentData = ((EntityManager)(ref entityManager)).GetComponentData<Mountable>(current);
										num3 = 1;
										if (0 == 0)
										{
											num3 = 1;
										}
										continue;
									case 33:
										if (flag3)
										{
											break;
										}
										num4 = 32;
										goto IL_00d6;
									case 18:
										flag2 = ((EntityManager)(ref entityManager)).Exists(current);
										num3 = 29;
										continue;
									default:
										value = GetPrefabName(componentData2).Replace("CHAR_", "").Replace("Mount_", "").Replace("_", " ");
										num3 = 1;
										if (0 == 0)
										{
											num3 = 7;
										}
										continue;
									case 1:
										{
											flag = componentData.MaxSpeed < MinSpeed;
											num3 = 3;
											continue;
										}
										IL_00d6:
										num3 = num4;
										continue;
									}
									break;
								}
								continue;
								IL_04d9:
								current = enumerator.Current;
								num3 = 22;
								goto IL_00da;
							}
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num5 = 0;
							if (0 != 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 3;
			}
		}

		public ESPHorses()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (1531368356 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool jph1ckRVTs4NFKdaRGW()
		{
			return BnqHlJR0QFdReXHo6D6 == null;
		}

		internal static ESPHorses jWY8MDRHC75xyJKvbTl()
		{
			return BnqHlJR0QFdReXHo6D6;
		}
	}
	public class ESPOres : ESPBase
	{
		private static ESPOres msY0qOR9Wg8IFDPsdwR;

		public override bool Enabled
		{
			get
			{
				int num = 6;
				int num2 = num;
				int result;
				while (true)
				{
					switch (num2)
					{
					case 8:
						if (OreFilterIron)
						{
							num2 = 4;
							if (1976142266 == 0)
							{
								num2 = 4;
							}
							continue;
						}
						goto case 7;
					case 7:
						if (!OreFilterSulfur)
						{
							num2 = 2;
							if (1435992043 != 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto default;
					case 6:
						if (OreFilterQuartz)
						{
							num2 = 5;
							continue;
						}
						goto case 3;
					case 3:
						if (!OreFilterCopper)
						{
							num2 = 8;
							if (0 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto default;
					case 2:
						if (OreFilterGemFlawless)
						{
							num2 = 0;
							if (460822775 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					case 1:
						result = (OreFilterSilver ? 1 : 0);
						break;
					default:
						result = 1;
						break;
					}
					break;
				}
				return (byte)result != 0;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						base.Enabled = value;
						num2 = 0;
						if (247204215 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool OreFilterQuartz
		{
			get
			{
				return ModConfig.Instance.ESPOresQuartz.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPOresQuartz.Value = value;
						num2 = 0;
						if (1518457776 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool OreFilterCopper
		{
			get
			{
				return ModConfig.Instance.ESPOresCopper.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPOresCopper.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool OreFilterIron
		{
			get
			{
				return ModConfig.Instance.ESPOresIron.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPOresIron.Value = value;
						num2 = 0;
						if (1427489184 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool OreFilterSulfur
		{
			get
			{
				return ModConfig.Instance.ESPOresSulfur.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPOresSulfur.Value = value;
						num2 = 0;
						if (962215133 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool OreFilterGemFlawless
		{
			get
			{
				return ModConfig.Instance.ESPOresGemFlawless.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPOresGemFlawless.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool OreFilterSilver
		{
			get
			{
				return ModConfig.Instance.ESPOresSilver.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPOresSilver.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.Any = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<SpawnPhysicsObjectOnDeath>() });
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.green;

		public override void Collect()
		{
			//IL_07b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0606: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_082b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0830: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0843: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			bool flag5 = default(bool);
			float3 position = default(float3);
			LocalToWorld componentData2 = default(LocalToWorld);
			EntityManager entityManager = default(EntityManager);
			Entity current = default(Entity);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			string prefabName = default(string);
			bool flag2 = default(bool);
			bool flag10 = default(bool);
			bool flag3 = default(bool);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			PrefabGUID componentData = default(PrefabGUID);
			bool flag = default(bool);
			bool flag7 = default(bool);
			bool flag9 = default(bool);
			bool flag8 = default(bool);
			bool flag6 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num5;
					int num3;
					int num7;
					int num9;
					int num10;
					int num4;
					int num6;
					int num8;
					switch (num2)
					{
					case 54:
						flag5 = IsBehindCamera(float3.op_Implicit(position));
						num2 = 46;
						if (0 != 0)
						{
							num2 = 25;
						}
						continue;
					case 41:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num2 = 10;
						if (468683115 != 0)
						{
							num2 = 23;
						}
						continue;
					case 2:
						val = SearchEntities(query);
						num2 = 39;
						continue;
					case 29:
						num5 = ((prefabName.IndexOf("TM_Iron_") != -1) ? 1 : 0);
						goto IL_0962;
					case 44:
						_entities.Add(current);
						num2 = 17;
						if (444950165 != 0)
						{
							num2 = 21;
						}
						continue;
					case 25:
						_entities.Add(current);
						num2 = 9;
						if (0 == 0)
						{
							num2 = 24;
						}
						continue;
					case 12:
						if (flag2)
						{
							num2 = 11;
							continue;
						}
						goto case 33;
					case 42:
						num3 = (string.IsNullOrEmpty(RootComponent.Instance.IsMenuShowing) ? 1 : 0);
						goto IL_09b6;
					case 59:
						if (flag10)
						{
							num2 = 27;
							continue;
						}
						goto case 4;
					case 36:
						if (prefabName.IndexOf("TM_GemFlawless_") == -1)
						{
							num2 = 55;
							continue;
						}
						num7 = 1;
						goto IL_09a9;
					case 1:
						return;
					case 65:
						return;
					case 62:
						num9 = (string.IsNullOrEmpty(RootComponent.Instance.IsMenuShowing) ? 1 : 0);
						goto IL_0984;
					case 40:
						num10 = ((prefabName.IndexOf("TM_Silver_") != -1) ? 1 : 0);
						goto IL_09c7;
					case 9:
						if (flag3)
						{
							num2 = 1;
							if (0 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 67;
					case 17:
					case 66:
						entityManager = ESPBase.EntityManager;
						num2 = 37;
						if (468683115 == 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
					case 7:
					case 8:
					case 14:
					case 21:
					case 24:
					case 28:
					case 31:
					case 45:
					case 50:
					case 56:
						if (!enumerator.MoveNext())
						{
							return;
						}
						num2 = 22;
						continue;
					case 46:
						if (!flag5)
						{
							num2 = 66;
							continue;
						}
						goto case 4;
					case 27:
						Application.Quit();
						num2 = 28;
						continue;
					case 23:
						position = ((LocalToWorld)(ref componentData2)).Position;
						num2 = 45;
						if (0 == 0)
						{
							num2 = 54;
						}
						continue;
					case 37:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 5;
						if (0 != 0)
						{
							num2 = 5;
						}
						continue;
					case 33:
						if (OreFilterGemFlawless)
						{
							num2 = 36;
							continue;
						}
						num7 = 0;
						goto IL_09a9;
					case 26:
						if (!flag)
						{
							num2 = 4;
							if (1531368356 != 0)
							{
								num2 = 8;
							}
							continue;
						}
						goto case 43;
					case 57:
						if (!flag7)
						{
							num2 = 47;
							continue;
						}
						goto case 34;
					case 13:
					case 22:
						current = enumerator.Current;
						num2 = 0;
						if (1848937442 == 0)
						{
							num2 = 0;
						}
						continue;
					case 43:
						Application.Quit();
						num2 = 45;
						continue;
					case 34:
						_entities.Add(current);
						num2 = 3;
						continue;
					case 20:
						if (flag9)
						{
							num2 = 51;
							continue;
						}
						goto case 60;
					case 68:
						num4 = ((prefabName.IndexOf("TM_Sulfur_") != -1) ? 1 : 0);
						goto IL_0991;
					case 11:
						_entities.Add(current);
						num2 = 4;
						continue;
					case 19:
						if (!flag8)
						{
							num2 = 61;
							continue;
						}
						goto case 58;
					case 48:
						num6 = ((prefabName.IndexOf("TM_Copper_") != -1) ? 1 : 0);
						goto IL_0955;
					case 5:
						prefabName = GetPrefabName(componentData);
						num2 = 34;
						if (0 == 0)
						{
							num2 = 49;
						}
						continue;
					case 3:
						if (!string.IsNullOrEmpty(RootComponent.Instance.IsEnablid))
						{
							num2 = 62;
							if (133732588 == 0)
							{
								num2 = 60;
							}
							continue;
						}
						num9 = 1;
						goto IL_0984;
					case 49:
						if (OreFilterQuartz)
						{
							num2 = 27;
							if (55114885 != 0)
							{
								num2 = 38;
							}
							continue;
						}
						num8 = 0;
						goto IL_0948;
					case 47:
					case 53:
						if (!OreFilterSulfur)
						{
							num = 32;
							break;
						}
						goto case 68;
					case 60:
						if (OreFilterSilver)
						{
							num2 = 40;
							if (0 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						num10 = 0;
						goto IL_09c7;
					case 67:
						_entities.Clear();
						num2 = 2;
						if (0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 61:
					case 64:
						if (!OreFilterCopper)
						{
							num2 = 35;
							continue;
						}
						goto case 48;
					case 15:
						if (!flag6)
						{
							num2 = 18;
							continue;
						}
						goto case 25;
					case 6:
						if (!flag4)
						{
							num2 = 31;
							if (0 != 0)
							{
								num2 = 16;
							}
							continue;
						}
						goto case 44;
					default:
						entityManager = ESPBase.EntityManager;
						num2 = 41;
						if (2058589287 == 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						flag3 = !Enabled;
						num = 9;
						break;
					case 38:
						num8 = ((prefabName.IndexOf("TM_Quartz_") != -1) ? 1 : 0);
						goto IL_0948;
					case 39:
						enumerator = val.GetEnumerator();
						num2 = 50;
						continue;
					case 58:
						_entities.Add(current);
						num2 = 56;
						continue;
					case 16:
						if (string.IsNullOrEmpty(RootComponent.Instance.IsEnablid))
						{
							num = 30;
							break;
						}
						goto case 42;
					case 18:
					case 63:
						if (!OreFilterIron)
						{
							num2 = 52;
							if (1629830925 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto case 29;
					case 51:
						_entities.Add(current);
						num2 = 16;
						if (2058589287 == 0)
						{
							num2 = 6;
						}
						continue;
					case 55:
						num7 = ((prefabName.IndexOf("TM_GemRegular") != -1) ? 1 : 0);
						goto IL_09a9;
					case 35:
						num6 = 0;
						goto IL_0955;
					case 52:
						num5 = 0;
						goto IL_0962;
					case 32:
						num4 = 0;
						goto IL_0991;
					case 30:
						{
							num3 = 1;
							goto IL_09b6;
						}
						IL_09b6:
						flag = (byte)num3 != 0;
						num = 26;
						break;
						IL_0962:
						flag7 = (byte)num5 != 0;
						num2 = 45;
						if (0 == 0)
						{
							num2 = 57;
						}
						continue;
						IL_0948:
						flag8 = (byte)num8 != 0;
						num2 = 19;
						continue;
						IL_09a9:
						flag9 = (byte)num7 != 0;
						num2 = 20;
						continue;
						IL_09c7:
						flag4 = (byte)num10 != 0;
						num2 = 6;
						continue;
						IL_0955:
						flag6 = (byte)num6 != 0;
						num2 = 15;
						continue;
						IL_0984:
						flag10 = (byte)num9 != 0;
						num2 = 59;
						continue;
						IL_0991:
						flag2 = (byte)num4 != 0;
						num2 = 12;
						continue;
					}
					break;
				}
			}
		}

		public override void Show()
		{
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			int num = 5;
			int num2 = num;
			bool flag = default(bool);
			List<Entity>.Enumerator enumerator = default(List<Entity>.Enumerator);
			bool flag2 = default(bool);
			string text = default(string);
			PrefabGUID componentData = default(PrefabGUID);
			EntityManager entityManager = default(EntityManager);
			Entity current = default(Entity);
			bool flag3 = default(bool);
			float3 position = default(float3);
			LocalToWorld componentData2 = default(LocalToWorld);
			while (true)
			{
				switch (num2)
				{
				case 5:
					flag = !Enabled;
					num2 = 4;
					continue;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 11;
								goto IL_0073;
							}
							goto IL_03ea;
							IL_0073:
							while (true)
							{
								switch (num3)
								{
								case 13:
									if (flag2)
									{
										num3 = 4;
										if (374085082 != 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 12;
								case 4:
									text = text.Replace("TM_", "").Replace("_Stage0", "").Replace("_Stage1", "")
										.Replace("_Stage2", "")
										.Replace("_Stage3", "")
										.Replace("_Stage4", "")
										.Replace("_01", "")
										.Replace("_02", "")
										.Replace("_03", "")
										.Replace("_04", "")
										.Replace("_Resource", "")
										.Replace("_", " ");
									num3 = 0;
									if (2035096834 != 0)
									{
										num3 = 0;
									}
									continue;
								case 8:
									componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
									num3 = 14;
									continue;
								case 6:
									if (!flag3)
									{
										num3 = 0;
										if (818312125 != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 9;
								case 17:
									position = ((LocalToWorld)(ref componentData2)).Position;
									num3 = 16;
									continue;
								case 1:
								case 3:
								case 15:
									break;
								case 10:
									componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
									num3 = 17;
									continue;
								case 12:
								{
									entityManager = ESPBase.EntityManager;
									int num4 = 8;
									num3 = num4;
									continue;
								}
								case 9:
									entityManager = ESPBase.EntityManager;
									num3 = 10;
									if (0 != 0)
									{
										num3 = 10;
									}
									continue;
								case 14:
									text = GetPrefabName(componentData);
									num3 = 4;
									continue;
								case 5:
									entityManager = ESPBase.EntityManager;
									num3 = 7;
									continue;
								case 2:
									goto IL_03ea;
								case 7:
									flag3 = ((EntityManager)(ref entityManager)).Exists(current);
									num3 = 6;
									continue;
								default:
									Draw(float3.op_Implicit(position), text, DefaultColor);
									num3 = 3;
									continue;
								case 16:
									flag2 = IsBehindCamera(float3.op_Implicit(position));
									num3 = 13;
									if (0 != 0)
									{
										num3 = 12;
									}
									continue;
								case 11:
									return;
								}
								break;
							}
							continue;
							IL_03ea:
							current = enumerator.Current;
							num3 = 5;
							goto IL_0073;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num5 = 0;
						if (1413447416 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 4:
					if (flag)
					{
						num2 = 2;
						continue;
					}
					break;
				case 2:
					return;
				case 1:
					return;
				}
				enumerator = _entities.GetEnumerator();
				num2 = 3;
			}
		}

		public ESPOres()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 0;
			if (0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool xrZcdyRNxK72pwpG5eP()
		{
			return msY0qOR9Wg8IFDPsdwR == null;
		}

		internal static ESPOres jJmF8QRjBufY3pB0c9T()
		{
			return msY0qOR9Wg8IFDPsdwR;
		}
	}
	public class ESPPlants : ESPBase
	{
		private List<int> v3SONF1Y4I;

		private List<int> VLjOjStokH;

		private List<int> iXAOdIEQ12;

		internal static ESPPlants Lf6VDMRd6gBU4cJ4gpa;

		public override bool Enabled
		{
			get
			{
				int num = 15;
				int num2 = num;
				int result;
				while (true)
				{
					switch (num2)
					{
					case 8:
						if (CottonEnabled)
						{
							num2 = 4;
							if (468683115 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						goto case 11;
					case 1:
						if (MoutningLilyEnabled)
						{
							num2 = 3;
							continue;
						}
						goto default;
					case 2:
						if (FireBlossomEnabled)
						{
							num2 = 10;
							if (0 != 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 6;
					case 14:
						if (BloodRoseEnabled)
						{
							num2 = 7;
							continue;
						}
						goto case 8;
					case 5:
						if (SunflowerEnabled)
						{
							num2 = 16;
							if (1435650279 != 0)
							{
								num2 = 16;
							}
							continue;
						}
						goto case 13;
					case 12:
						if (!HellsClarionEnabled)
						{
							num2 = 1;
							if (1362636878 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 3;
					case 11:
						if (CorruptedFlowerEnabled)
						{
							num2 = 3;
							if (0 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto case 2;
					case 15:
						if (!BleedingHeartEnabled)
						{
							num2 = 14;
							continue;
						}
						goto case 3;
					default:
						if (!SnowFlowerEnabled)
						{
							num2 = 3;
							if (2058589287 != 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 3;
					case 13:
						result = (TrippyShroomEnabled ? 1 : 0);
						break;
					case 6:
						if (!GhostShroomEnabled)
						{
							num2 = 12;
							if (0 != 0)
							{
								num2 = 5;
							}
							continue;
						}
						goto case 3;
					case 3:
					case 4:
					case 7:
					case 9:
					case 10:
					case 16:
						result = 1;
						break;
					}
					break;
				}
				return (byte)result != 0;
			}
		}

		public bool BleedingHeartEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsBleedingHeart.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsBleedingHeart.Value = value;
						num2 = 0;
						if (1433983997 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool BloodRoseEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsBloodRose.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsBloodRose.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool CottonEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsCotton.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsCotton.Value = value;
						num2 = 0;
						if (117793469 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool CorruptedFlowerEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsCorruptedFlower.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsCorruptedFlower.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool FireBlossomEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsFireBlossom.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsFireBlossom.Value = value;
						num2 = 0;
						if (1435992043 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool GhostShroomEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsGhostShroom.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsGhostShroom.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool HellsClarionEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsHellsClarion.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsHellsClarion.Value = value;
						num2 = 0;
						if (742265667 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool MoutningLilyEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsMoutningLily.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsMoutningLily.Value = value;
						num2 = 0;
						if (760317395 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool SnowFlowerEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsSnowFlower.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsSnowFlower.Value = value;
						num2 = 0;
						if (962215133 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool SunflowerEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsSunflower.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsSunflower.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool TrippyShroomEnabled
		{
			get
			{
				return ModConfig.Instance.ESPPlantsTrippyShroom.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlantsTrippyShroom.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[2]
				{
					ComponentType.ReadOnly<PrefabGUID>(),
					ComponentType.ReadOnly<LocalToWorld>()
				});
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.green;

		public override void Collect()
		{
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0460: Unknown result type (might be due to invalid IL or missing references)
			//IL_0708: Unknown result type (might be due to invalid IL or missing references)
			//IL_070d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0862: Unknown result type (might be due to invalid IL or missing references)
			//IL_0867: Unknown result type (might be due to invalid IL or missing references)
			//IL_0828: Unknown result type (might be due to invalid IL or missing references)
			//IL_082a: Unknown result type (might be due to invalid IL or missing references)
			//IL_082f: Unknown result type (might be due to invalid IL or missing references)
			//IL_093a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0913: Unknown result type (might be due to invalid IL or missing references)
			//IL_0918: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0813: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Unknown result type (might be due to invalid IL or missing references)
			//IL_081a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			int num = 40;
			bool flag4 = default(bool);
			bool flag11 = default(bool);
			Entity current = default(Entity);
			int value = default(int);
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			bool flag10 = default(bool);
			bool flag2 = default(bool);
			PrefabGUID componentData = default(PrefabGUID);
			bool flag = default(bool);
			float3 position = default(float3);
			LocalToWorld componentData2 = default(LocalToWorld);
			bool flag13 = default(bool);
			bool flag12 = default(bool);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			bool flag6 = default(bool);
			bool flag5 = default(bool);
			bool flag9 = default(bool);
			EntityManager entityManager = default(EntityManager);
			bool flag8 = default(bool);
			bool flag7 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num11;
					int num10;
					int num8;
					int num12;
					int num6;
					int num9;
					int num3;
					int num13;
					int num4;
					int num7;
					int num5;
					switch (num2)
					{
					case 23:
						if (flag4)
						{
							num2 = 46;
							continue;
						}
						goto case 4;
					case 73:
						if (!flag11)
						{
							num2 = 4;
							if (2048817382 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 1;
					case 16:
						_entities.Add(current);
						num2 = 49;
						if (0 != 0)
						{
							num2 = 19;
						}
						continue;
					case 1:
						_entities.Add(current);
						num2 = 41;
						if (962215133 == 0)
						{
							num2 = 15;
						}
						continue;
					case 68:
						num11 = (VLjOjStokH.Contains(value) ? 1 : 0);
						goto IL_0a62;
					case 24:
						num10 = ((value == 912333956) ? 1 : 0);
						goto IL_0a1e;
					case 17:
					case 18:
					case 25:
					case 30:
					case 34:
					case 41:
					case 42:
					case 48:
					case 49:
					case 61:
					case 62:
					case 65:
					case 67:
					case 71:
						if (enumerator.MoveNext())
						{
							num2 = 45;
							continue;
						}
						return;
					case 76:
						_entities.Add(current);
						num2 = 43;
						if (0 == 0)
						{
							num2 = 62;
						}
						continue;
					case 3:
						num8 = ((value == -871557590) ? 1 : 0);
						goto IL_0aa3;
					default:
						_entities.Add(current);
						num2 = 61;
						continue;
					case 2:
						num12 = ((value == -1478081952) ? 1 : 0);
						goto IL_0a6f;
					case 38:
						if (flag10)
						{
							num2 = 76;
							continue;
						}
						goto case 28;
					case 21:
						if (HellsClarionEnabled)
						{
							num2 = 47;
							continue;
						}
						num6 = 0;
						goto IL_0a89;
					case 43:
						if (FireBlossomEnabled)
						{
							num2 = 2;
							continue;
						}
						num12 = 0;
						goto IL_0a6f;
					case 74:
						if (!flag2)
						{
							num = 63;
							break;
						}
						goto case 16;
					case 53:
						_entities.Add(current);
						num2 = 34;
						if (0 != 0)
						{
							num2 = 25;
						}
						continue;
					case 57:
					case 63:
						if (SunflowerEnabled)
						{
							num2 = 6;
							continue;
						}
						num9 = 0;
						goto IL_0ac5;
					case 80:
						value = componentData._Value;
						num = 69;
						break;
					case 8:
						flag = IsBehindCamera(float3.op_Implicit(position));
						num2 = 16;
						if (0 == 0)
						{
							num2 = 81;
						}
						continue;
					case 77:
						_entities.Add(current);
						num = 71;
						break;
					case 66:
						num3 = ((value == -362609585) ? 1 : 0);
						goto IL_0ad6;
					case 59:
						position = ((LocalToWorld)(ref componentData2)).Position;
						num2 = 8;
						continue;
					case 11:
						if (flag13)
						{
							num2 = 5;
							continue;
						}
						goto case 21;
					case 5:
						_entities.Add(current);
						num = 30;
						break;
					case 82:
						num13 = ((value == 1647629126) ? 1 : 0);
						goto IL_0a96;
					case 10:
						if (flag12)
						{
							num2 = 72;
							if (818312125 == 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto case 64;
					case 56:
						val = SearchEntities(query);
						num2 = 54;
						continue;
					case 4:
						if (BloodRoseEnabled)
						{
							num2 = 17;
							if (747172065 != 0)
							{
								num2 = 24;
							}
							continue;
						}
						num10 = 0;
						goto IL_0a1e;
					case 36:
						if (!flag6)
						{
							num2 = 48;
							if (258562808 != 0)
							{
								num2 = 52;
							}
							continue;
						}
						goto case 53;
					case 20:
						if (!flag5)
						{
							num2 = 33;
							continue;
						}
						goto default;
					case 39:
						if (flag9)
						{
							num2 = 13;
							if (0 != 0)
							{
								num2 = 7;
							}
							continue;
						}
						goto case 12;
					case 72:
						_entities.Add(current);
						num2 = 65;
						continue;
					case 19:
						_entities.Add(current);
						num2 = 48;
						continue;
					case 13:
						return;
					case 37:
						return;
					case 69:
						if (!BleedingHeartEnabled)
						{
							num2 = 44;
							continue;
						}
						goto case 79;
					case 22:
					case 52:
						if (!TrippyShroomEnabled)
						{
							num2 = 60;
							continue;
						}
						goto case 66;
					case 40:
						flag9 = !Enabled;
						num2 = 39;
						continue;
					case 12:
						_entities.Clear();
						num2 = 56;
						continue;
					case 83:
						num4 = ((value == -1433121689) ? 1 : 0);
						goto IL_0a7c;
					case 15:
					case 51:
						entityManager = ESPBase.EntityManager;
						num2 = 70;
						if (0 != 0)
						{
							num2 = 67;
						}
						continue;
					case 75:
						if (flag8)
						{
							num2 = 16;
							if (0 == 0)
							{
								num2 = 19;
							}
							continue;
						}
						goto case 43;
					case 29:
					case 33:
						if (CorruptedFlowerEnabled)
						{
							num2 = 68;
							continue;
						}
						num11 = 0;
						goto IL_0a62;
					case 7:
					case 50:
						if (SnowFlowerEnabled)
						{
							num2 = 3;
							if (1427489184 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						num8 = 0;
						goto IL_0aa3;
					case 14:
						if (!flag7)
						{
							num2 = 58;
							continue;
						}
						goto case 78;
					case 28:
						if (MoutningLilyEnabled)
						{
							num2 = 6;
							if (0 == 0)
							{
								num2 = 82;
							}
							continue;
						}
						num13 = 0;
						goto IL_0a96;
					case 70:
						componentData = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(current);
						num2 = 80;
						continue;
					case 35:
						componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(current);
						num2 = 59;
						continue;
					case 27:
					case 45:
						current = enumerator.Current;
						num2 = 55;
						continue;
					case 6:
						num9 = (iXAOdIEQ12.Contains(value) ? 1 : 0);
						goto IL_0ac5;
					case 78:
						_entities.Add(current);
						num2 = 67;
						continue;
					case 9:
						num7 = (v3SONF1Y4I.Contains(value) ? 1 : 0);
						goto IL_0a40;
					case 79:
						num5 = ((value == 26232567) ? 1 : 0);
						goto IL_0a11;
					case 26:
						if (flag3)
						{
							num2 = 77;
							continue;
						}
						goto case 17;
					case 55:
						entityManager = ESPBase.EntityManager;
						num2 = 35;
						continue;
					case 46:
						_entities.Add(current);
						num2 = 25;
						continue;
					case 64:
						if (!GhostShroomEnabled)
						{
							num2 = 32;
							continue;
						}
						goto case 83;
					case 81:
						if (flag)
						{
							goto case 17;
						}
						num2 = 51;
						if (1126510863 == 0)
						{
							num2 = 0;
						}
						continue;
					case 31:
					case 58:
						if (CottonEnabled)
						{
							num2 = 9;
							if (0 != 0)
							{
								num2 = 8;
							}
							continue;
						}
						num7 = 0;
						goto IL_0a40;
					case 54:
						enumerator = val.GetEnumerator();
						num2 = 18;
						if (10932459 == 0)
						{
							num2 = 4;
						}
						continue;
					case 47:
						num6 = ((value == -1058568408) ? 1 : 0);
						goto IL_0a89;
					case 44:
						num5 = 0;
						goto IL_0a11;
					case 32:
						num4 = 0;
						goto IL_0a7c;
					case 60:
						{
							num3 = 0;
							goto IL_0ad6;
						}
						IL_0aa3:
						flag2 = (byte)num8 != 0;
						num2 = 74;
						if (1427489184 == 0)
						{
							num2 = 67;
						}
						continue;
						IL_0a40:
						flag5 = (byte)num7 != 0;
						num2 = 11;
						if (0 == 0)
						{
							num2 = 20;
						}
						continue;
						IL_0ac5:
						flag6 = (byte)num9 != 0;
						num = 36;
						break;
						IL_0a1e:
						flag7 = (byte)num10 != 0;
						num2 = 14;
						if (962215133 == 0)
						{
							num2 = 7;
						}
						continue;
						IL_0a89:
						flag10 = (byte)num6 != 0;
						num2 = 38;
						continue;
						IL_0a11:
						flag4 = (byte)num5 != 0;
						num2 = 23;
						continue;
						IL_0a62:
						flag8 = (byte)num11 != 0;
						num2 = 75;
						continue;
						IL_0a96:
						flag11 = (byte)num13 != 0;
						num2 = 73;
						continue;
						IL_0a7c:
						flag13 = (byte)num4 != 0;
						num2 = 11;
						continue;
						IL_0a6f:
						flag12 = (byte)num12 != 0;
						num2 = 10;
						continue;
						IL_0ad6:
						flag3 = (byte)num3 != 0;
						num2 = 26;
						if (1783996735 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					break;
				}
			}
		}

		public override void Show()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			if (!Enabled)
			{
				return;
			}
			foreach (Entity entity in _entities)
			{
				EntityManager entityManager = ESPBase.EntityManager;
				if (((EntityManager)(ref entityManager)).Exists(entity))
				{
					entityManager = ESPBase.EntityManager;
					LocalToWorld componentData = ((EntityManager)(ref entityManager)).GetComponentData<LocalToWorld>(entity);
					float3 position = ((LocalToWorld)(ref componentData)).Position;
					if (!IsBehindCamera(float3.op_Implicit(position)))
					{
						entityManager = ESPBase.EntityManager;
						PrefabGUID componentData2 = ((EntityManager)(ref entityManager)).GetComponentData<PrefabGUID>(entity);
						Draw(float3.op_Implicit(position), HandleName(GetPrefabName(componentData2)), DefaultColor);
					}
				}
			}
		}

		protected override string HandleName(string name)
		{
			int num = 1;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = name.Replace("TM_Plant_", "").Replace("TM", "").Replace("Plantfiber", "")
						.Replace("Strongblade", "")
						.Replace("_", "")
						.Replace("01", "")
						.Replace("02", "")
						.Replace("03", "")
						.Replace("Pickup", "");
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public ESPPlants()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			v3SONF1Y4I = new List<int> { -1030372628, 247769206, 1049924113 };
			VLjOjStokH = new List<int> { 1216413890, 676475511 };
			iXAOdIEQ12 = new List<int> { 544420990, 263978365, -608256184 };
			base..ctor();
			int num = 0;
			if (0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Y6JxDMR8FMnrpXHIUo5()
		{
			return Lf6VDMRd6gBU4cJ4gpa == null;
		}

		internal static ESPPlants Yld3XoRAAokfbCkjqFH()
		{
			return Lf6VDMRd6gBU4cJ4gpa;
		}
	}
	public class ESPPlayers : ESPBase
	{
		public static ESPPlayers Instance;

		public bool ShowSelf;

		private Color t95OAcZim6;

		internal static ESPPlayers HmjHYxRmOTXh04AZsOa;

		public override bool Enabled
		{
			get
			{
				return ModConfig.Instance.ESPPlayersEnabled.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersEnabled.Value = value;
						num2 = 0;
						if (1435992043 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool ShowLvL
		{
			get
			{
				return ModConfig.Instance.ESPPlayersShowLvL.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersShowLvL.Value = value;
						num2 = 0;
						if (760317395 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool ShowClan
		{
			get
			{
				return ModConfig.Instance.ESPPlayersShowClan.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersShowClan.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool ShowHealth
		{
			get
			{
				return ModConfig.Instance.ESPPlayersShowHealth.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersShowHealth.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool ShowBlood
		{
			get
			{
				return ModConfig.Instance.ESPPlayersShowBlood.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersShowBlood.Value = value;
						num2 = 0;
						if (468683115 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool ShowAlly
		{
			get
			{
				return ModConfig.Instance.ESPPlayersShowAlly.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersShowAlly.Value = value;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool ShowSkills
		{
			get
			{
				return ModConfig.Instance.ESPPlayersSkills.Value;
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						ModConfig.Instance.ESPPlayersSkills.Value = value;
						num2 = 0;
						if (0 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		protected override EntityQueryDesc[] query
		{
			get
			{
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Expected O, but got Unknown
				//IL_0019: Unknown result type (might be due to invalid IL or missing references)
				//IL_001e: Unknown result type (might be due to invalid IL or missing references)
				EntityQueryDesc[] array = new EntityQueryDesc[1];
				EntityQueryDesc val = new EntityQueryDesc();
				val.Any = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<PlayerCharacter>() });
				array[0] = val;
				return (EntityQueryDesc[])(object)array;
			}
		}

		protected override Color DefaultColor => Color.cyan;

		public ESPPlayers()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			t95OAcZim6 = new Color(255f, 165f, 0f, 1f);
			base..ctor();
			int num = 0;
			if (0 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				Instance = this;
				num = 0;
				if (0 == 0)
				{
					num = 1;
				}
			}
		}

		public override void Collect()
		{
		}

		public override void Show()
		{
			//IL_083f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_0898: Unknown result type (might be due to invalid IL or missing references)
			//IL_089d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0905: Unknown result type (might be due to invalid IL or missing references)
			//IL_0696: Unknown result type (might be due to invalid IL or missing references)
			//IL_0533: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
			int num = 6;
			int num2 = num;
			bool flag9 = default(bool);
			List<PlayerWrapper>.Enumerator enumerator = default(List<PlayerWrapper>.Enumerator);
			PlayerWrapper mainPlayer2 = default(PlayerWrapper);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			string text = default(string);
			PlayerWrapper current = default(PlayerWrapper);
			bool showSkills = default(bool);
			bool showLvL = default(bool);
			bool flag6 = default(bool);
			bool flag5 = default(bool);
			bool flag = default(bool);
			bool flag8 = default(bool);
			bool showBlood = default(bool);
			bool flag3 = default(bool);
			bool showClan = default(bool);
			bool showHealth = default(bool);
			bool flag4 = default(bool);
			float num8 = default(float);
			Color color = default(Color);
			bool flag7 = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (flag9)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 6:
					flag9 = !Enabled;
					num2 = 5;
					break;
				default:
					enumerator = PlayersManager.Instance.Players.GetEnumerator();
					num2 = 3;
					if (1696499521 != 0)
					{
						num2 = 4;
					}
					break;
				case 1:
					return;
				case 3:
					return;
				case 2:
					mainPlayer2 = PlayersManager.Instance.MainPlayer;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 52;
								goto IL_00f4;
							}
							goto IL_05ec;
							IL_00f4:
							while (true)
							{
								int num5;
								object value;
								int num7;
								Color val;
								int num4;
								int num6;
								switch (num3)
								{
								case 52:
									return;
								case 50:
									defaultInterpolatedStringHandler.AppendLiteral(") ");
									num3 = 1;
									if (171921593 == 0)
									{
										num3 = 1;
									}
									continue;
								case 68:
									text = current.Name;
									num3 = 34;
									continue;
								case 2:
									showSkills = ShowSkills;
									num3 = 29;
									continue;
								case 54:
									if (!ShowLvL)
									{
										num3 = 19;
										if (1629830925 != 0)
										{
											num3 = 65;
										}
										continue;
									}
									goto case 43;
								case 6:
									text = defaultInterpolatedStringHandler.ToStringAndClear();
									num3 = 21;
									if (1126510863 == 0)
									{
										num3 = 20;
									}
									continue;
								case 3:
									text = string.Format("{0} [{1:0} HP]", new object[2] { text, current.HP });
									num3 = 11;
									if (0 == 0)
									{
										num3 = 14;
									}
									continue;
								case 26:
									defaultInterpolatedStringHandler.AppendLiteral("%) ");
									num3 = 43;
									if (0 == 0)
									{
										num3 = 70;
									}
									continue;
								case 44:
									showLvL = ShowLvL;
									num3 = 4;
									continue;
								case 24:
								case 35:
								case 49:
								case 57:
								case 66:
								case 72:
									break;
								case 39:
									defaultInterpolatedStringHandler.AppendLiteral("|");
									num3 = 19;
									continue;
								case 29:
									if (!showSkills)
									{
										num3 = 49;
										continue;
									}
									goto case 23;
								case 48:
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
									num3 = 64;
									continue;
								case 59:
									if (flag6)
									{
										num3 = 5;
										if (852228814 != 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto case 68;
								case 10:
									defaultInterpolatedStringHandler.AppendLiteral("(");
									num3 = 46;
									continue;
								case 31:
									defaultInterpolatedStringHandler.AppendFormatted(current.BloodQuality);
									num3 = 33;
									continue;
								case 1:
									defaultInterpolatedStringHandler.AppendFormatted(text);
									num3 = 45;
									continue;
								case 15:
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
									num3 = 28;
									continue;
								case 23:
									ShowPlayerSkillsCooldown(float3.op_Implicit(current.Position), current.Cooldowns);
									num3 = 22;
									if (1187184005 != 0)
									{
										num3 = 24;
									}
									continue;
								case 28:
									defaultInterpolatedStringHandler.AppendLiteral("(");
									num3 = 31;
									continue;
								case 25:
									flag5 = !current.IsValid();
									num3 = 9;
									continue;
								case 17:
									num5 = (ShowBlood ? 1 : 0);
									goto IL_0b99;
								case 16:
								{
									PlayerWrapper? mainPlayer = PlayersManager.Instance.MainPlayer;
									if (mainPlayer == null)
									{
										num3 = 15;
										if (0 == 0)
										{
											num3 = 55;
										}
										continue;
									}
									value = mainPlayer.ClanName;
									goto IL_0b40;
								}
								case 62:
									goto IL_05ec;
								case 30:
								case 38:
									flag = string.IsNullOrEmpty(current.Name);
									num3 = 41;
									continue;
								case 5:
									flag8 = !ShowAlly;
									num3 = 27;
									if (1486210346 == 0)
									{
										num3 = 9;
									}
									continue;
								case 22:
									showBlood = ShowBlood;
									num3 = 37;
									continue;
								default:
									defaultInterpolatedStringHandler.AppendFormatted(current.EquipmentLevel);
									num7 = 50;
									goto IL_00f0;
								case 18:
									val = DefaultColor;
									goto IL_0bd0;
								case 43:
									num4 = (ShowBlood ? 1 : 0);
									goto IL_0baa;
								case 60:
									flag3 = !ShowSelf;
									num3 = 71;
									continue;
								case 27:
									if (flag8)
									{
										num3 = 48;
										if (0 == 0)
										{
											num3 = 66;
										}
										continue;
									}
									goto case 68;
								case 8:
								case 21:
								case 42:
								case 67:
								case 69:
									showClan = ShowClan;
									num3 = 32;
									continue;
								case 45:
									text = defaultInterpolatedStringHandler.ToStringAndClear();
									num3 = 67;
									continue;
								case 32:
									if (showClan)
									{
										num3 = 56;
										continue;
									}
									goto case 61;
								case 12:
									text = defaultInterpolatedStringHandler.ToStringAndClear();
									num3 = 8;
									continue;
								case 41:
									if (flag)
									{
										num3 = 57;
										continue;
									}
									goto case 20;
								case 46:
									defaultInterpolatedStringHandler.AppendFormatted(current.EquipmentLevel);
									num3 = 39;
									continue;
								case 61:
									showHealth = ShowHealth;
									num3 = 36;
									continue;
								case 53:
									if (flag4)
									{
										num3 = 51;
										continue;
									}
									goto case 44;
								case 4:
									if (showLvL)
									{
										num3 = 48;
										continue;
									}
									goto case 22;
								case 14:
									num8 = Vector3.Distance(mainPlayer2.Position, current.Position);
									num3 = 62;
									if (0 == 0)
									{
										num3 = 63;
									}
									continue;
								case 63:
									if (!current.AimTarget)
									{
										num7 = 18;
										goto IL_00f0;
									}
val = ModConfig.Instance.ParsedAimTargetColor;

									goto IL_0bd0;
								case 11:
									Draw(current.Position, text, color);
									num3 = 13;
									continue;
								case 51:
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
									num3 = 2;
									if (0 == 0)
									{
										num3 = 10;
									}
									continue;
								case 13:
									Draw(current.Position + new Vector3(0f, -0.5f, 0f), "[" + num8.ToString("0") + " m]", color);
									num3 = 2;
									continue;
								case 34:
									if (ShowLvL)
									{
										num3 = 47;
										continue;
									}
									goto case 17;
								case 7:
									defaultInterpolatedStringHandler.AppendFormatted(text);
									num3 = 6;
									if (0 != 0)
									{
										num3 = 5;
									}
									continue;
								case 36:
									if (showHealth)
									{
										num3 = 3;
										continue;
									}
									goto case 14;
								case 70:
									defaultInterpolatedStringHandler.AppendFormatted(text);
									num3 = 12;
									continue;
								case 58:
									if (flag7)
									{
										num3 = 60;
										if (1486210346 == 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 16;
								case 56:
									text = text + ":" + current.ClanName;
									num7 = 61;
									goto IL_00f0;
								case 37:
									if (!showBlood)
									{
										num3 = 42;
										continue;
									}
									goto case 15;
								case 9:
									if (flag5)
									{
										break;
									}
									num3 = 30;
									continue;
								case 71:
									if (flag3)
									{
										num3 = 72;
										continue;
									}
									goto case 16;
								case 33:
									defaultInterpolatedStringHandler.AppendLiteral(") ");
									num3 = 7;
									if (0 != 0)
									{
										num3 = 6;
									}
									continue;
								case 19:
									defaultInterpolatedStringHandler.AppendFormatted(current.BloodQuality);
									num3 = 26;
									continue;
								case 64:
									defaultInterpolatedStringHandler.AppendLiteral("(");
									num3 = 0;
									if (0 == 0)
									{
										num3 = 0;
									}
									continue;
								case 40:
									if (!flag2)
									{
										num7 = 69;
										goto IL_00f0;
									}
									goto case 54;
								case 20:
									flag7 = current.Name == PlayersManager.Instance.MainPlayer?.Name;
									num3 = 58;
									continue;
								case 55:
									value = null;
									goto IL_0b40;
								case 73:
									num6 = ((current.ClanName == PlayersManager.Instance.MainPlayer?.ClanName) ? 1 : 0);
									goto IL_0b8c;
								case 47:
									num5 = 1;
									goto IL_0b99;
								case 65:
									{
										num4 = 0;
										goto IL_0baa;
									}
									IL_0b40:
									if (!string.IsNullOrEmpty((string?)value))
									{
										num3 = 73;
										continue;
									}
									num6 = 0;
									goto IL_0b8c;
									IL_0baa:
									flag4 = (byte)num4 != 0;
									num3 = 53;
									if (854369382 == 0)
									{
										num3 = 18;
									}
									continue;
									IL_0b8c:
									flag6 = (byte)num6 != 0;
									num3 = 59;
									continue;
									IL_0b99:
									flag2 = (byte)num5 != 0;
									num7 = 40;
									goto IL_00f0;
									IL_00f0:
									num3 = num7;
									continue;
									IL_0bd0:
									color = val;
									num3 = 11;
									continue;
								}
								break;
							}
							continue;
							IL_05ec:
							current = enumerator.Current;
							num3 = 25;
							goto IL_00f4;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num9 = 0;
						if (0 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
				}
			}
		}

		public void ShowPlayerSkillsCooldown(float3 position, List<PlayerCooldowns> cooldowns)
		{
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			int num = 5;
			int num2 = num;
			bool flag2 = default(bool);
			List<PlayerCooldowns>.Enumerator enumerator = default(List<PlayerCooldowns>.Enumerator);
			float num5 = default(float);
			PlayerCooldowns current = default(PlayerCooldowns);
			bool isDash = default(bool);
			bool flag = default(bool);
			bool isUltimate = default(bool);
			AbilityDescription description = default(AbilityDescription);
			bool isDefence = default(bool);
			string prefabName = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 5:
					flag2 = cooldowns.Count == 0;
					num2 = 4;
					if (0 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					enumerator = cooldowns.GetEnumerator();
					num2 = 3;
					break;
				case 6:
					return;
				case 4:
					if (flag2)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 1:
					num5 = -1f;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					try
					{
						while (true)
						{
							IL_04aa:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 11;
								if (0 != 0)
								{
									num3 = 3;
								}
								goto IL_00fb;
							}
							goto IL_02b1;
							IL_02b1:
							current = enumerator.Current;
							num3 = 17;
							goto IL_00fb;
							IL_00fb:
							while (true)
							{
								switch (num3)
								{
								case 11:
									return;
								case 12:
									t95OAcZim6 = Color.green;
									num3 = 5;
									continue;
								case 21:
									if (!isDash)
									{
										num3 = 20;
										continue;
									}
									goto case 6;
								case 4:
									if (!flag)
									{
										num3 = 17;
										if (1256719316 != 0)
										{
											num3 = 19;
										}
										continue;
									}
									goto IL_04aa;
								case 24:
								{
									isUltimate = description.IsUltimate;
									int num4 = 15;
									num3 = num4;
									continue;
								}
								case 1:
								case 19:
									t95OAcZim6 = Color.yellow;
									num3 = 9;
									continue;
								case 10:
								case 18:
									isDefence = description.IsDefence;
									num3 = 23;
									continue;
								case 3:
									flag = prefabName.IndexOf("Primary") != -1;
									num3 = 4;
									continue;
								case 17:
									prefabName = GetPrefabName(current.AbilityGUID);
									num3 = 3;
									continue;
								case 8:
									break;
								case 13:
									isDash = description.IsDash;
									num3 = 21;
									continue;
								case 6:
									t95OAcZim6 = Color.magenta;
									num3 = 7;
									continue;
								case 15:
									if (!isUltimate)
									{
										num3 = 18;
										continue;
									}
									goto default;
								default:
									t95OAcZim6 = Color.red;
									num3 = 16;
									if (497891482 == 0)
									{
										num3 = 8;
									}
									continue;
								case 2:
									num5 += -0.5f;
									num3 = 19;
									if (0 == 0)
									{
										num3 = 22;
									}
									continue;
								case 9:
									description = current.Description;
									num3 = 24;
									continue;
								case 5:
								case 7:
								case 16:
								case 20:
								{
									Vector3 position2 = float3.op_Implicit(position + new float3(0f, num5, 0f));
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
									defaultInterpolatedStringHandler.AppendFormatted(XkjO8mlGIn(prefabName));
									defaultInterpolatedStringHandler.AppendLiteral(": ");
									defaultInterpolatedStringHandler.AppendFormatted(current.Cooldown, "0.0");
									defaultInterpolatedStringHandler.AppendLiteral("s");
									Draw(position2, defaultInterpolatedStringHandler.ToStringAndClear(), t95OAcZim6);
									num3 = 1;
									if (0 == 0)
									{
										num3 = 2;
									}
									continue;
								}
								case 23:
									if (isDefence)
									{
										num3 = 12;
										if (117793469 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 13;
								case 14:
								case 22:
									goto IL_04aa;
								}
								break;
							}
							goto IL_02b1;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num6 = 0;
						if (1268266038 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				}
			}
		}

		private string XkjO8mlGIn(string P_0)
		{
			int num = 6;
			int num2 = num;
			bool flag = default(bool);
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!flag)
					{
						num2 = 4;
						break;
					}
					goto default;
				default:
					result = "Dash";
					num2 = 7;
					break;
				case 3:
				case 4:
					result = P_0.Replace("AB_", "").Replace("_", " ").Replace("Vampire", "")
						.Replace("Cast", "");
					num2 = 1;
					if (247204215 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					flag = P_0.IndexOf("Dash") != -1;
					num2 = 5;
					if (0 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
				case 2:
				case 7:
					return result;
				}
			}
		}

		internal static bool YRRvGJRJbOexdIMgKFJ()
		{
			return HmjHYxRmOTXh04AZsOa == null;
		}

		internal static ESPPlayers BGTtpERZpo0Xjx6PZQQ()
		{
			return HmjHYxRmOTXh04AZsOa;
		}
	}
}
namespace VRisingBephinex.components.creatures
{
	public class CreaturesManager : MonoBehaviour
	{
		public static CreaturesManager Instance;

		public List<CreatureWrapper> Creatures;

		private EntityQueryDesc[] MkGOJHnC58;

		private static CreaturesManager I7ubC0R166rKipw2dL8;

		public void Awake()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Instance = this;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public void Update()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					zfiOmq9XeY();
					num2 = 0;
					if (1435992043 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		private void zfiOmq9XeY()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			Enumerator<Entity> enumerator = default(Enumerator<Entity>);
			NativeArray<Entity> val = default(NativeArray<Entity>);
			Entity current = default(Entity);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 6:
						enumerator = val.GetEnumerator();
						num2 = 7;
						if (0 == 0)
						{
							num2 = 7;
						}
						continue;
					default:
						current = enumerator.Current;
						num2 = 4;
						if (0 == 0)
						{
							num2 = 5;
						}
						continue;
					case 3:
						val.Dispose();
						num2 = 8;
						continue;
					case 8:
						return;
					case 1:
						break;
					case 2:
						val = EntityManagerWrapper.QueryEntities(MkGOJHnC58);
						num2 = 1;
						if (0 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						Creatures.Add(new CreatureWrapper(current));
						num2 = 0;
						if (1486210346 != 0)
						{
							num2 = 4;
						}
						continue;
					case 4:
					case 7:
						if (!enumerator.MoveNext())
						{
							num2 = 3;
							if (11098130 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					}
					break;
				}
				Creatures.Clear();
				num = 6;
			}
		}

		public CreaturesManager()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Creatures = new List<CreatureWrapper>();
			EntityQueryDesc[] array = new EntityQueryDesc[1];
			EntityQueryDesc val = new EntityQueryDesc();
			val.All = Il2CppStructArray<ComponentType>.op_Implicit((ComponentType[])(object)new ComponentType[1] { ComponentType.ReadOnly<BloodConsumeSource>() });
			array[0] = val;
			MkGOJHnC58 = (EntityQueryDesc[])(object)array;
			((MonoBehaviour)this)..ctor();
			int num = 0;
			if (1814018247 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool EgvZOnRFrRx0fmAsoY9()
		{
			return I7ubC0R166rKipw2dL8 == null;
		}

		internal static CreaturesManager lVDx4IRxjHN5UTnSnRI()
		{
			return I7ubC0R166rKipw2dL8;
		}
	}
}
namespace VRisingBephinex.components.creatures.model
{
	public class CreatureWrapper : EntityWrapper
	{
		public BloodConsumeSource Blood;

		public string BloodName;

		public bool IsVBlood;

		internal static CreatureWrapper rdXFpERKLMHCDC5otlC;

		public string Name => GetName();

		public float BloodQuality => math.round(Blood.BloodQuality);

		public CreatureWrapper(Entity entity)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			BloodName = string.Empty;
			base..ctor(entity);
			int num = 3;
			while (true)
			{
				EntityManager manager;
				switch (num)
				{
				case 1:
					return;
				case 3:
					manager = EntityManagerWrapper.Manager;
					Blood = ((EntityManager)(ref manager)).GetComponentData<BloodConsumeSource>(entity);
					num = 2;
					if (444950165 == 0)
					{
						num = 2;
					}
					break;
				case 2:
					BloodName = jQXOZvC6Pg(GetPrefabName(ModifiablePrefabGUID.op_Implicit(Blood.UnitBloodType)));
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					break;
				default:
					manager = EntityManagerWrapper.Manager;
					IsVBlood = ((EntityManager)(ref manager)).HasComponent<VBloodConsumeSource>(Entity);
					num = 0;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public override void Update()
		{
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			int num = 4;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (flag)
						{
							num2 = 0;
							if (374085082 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						return;
					case 4:
						base.Update();
						num2 = 3;
						continue;
					case 3:
						flag = IsValid();
						num2 = 1;
						if (1268266038 == 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						return;
					}
					break;
				}
				EntityManager manager = EntityManagerWrapper.Manager;
				Blood = ((EntityManager)(ref manager)).GetComponentData<BloodConsumeSource>(Entity);
				num = 2;
			}
		}

		private string jQXOZvC6Pg(string P_0)
		{
			int num = 2;
			int num2 = num;
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					result = P_0.Replace("CHAR", "").Replace("_", " ").Replace("BloodType", "");
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return result;
				}
			}
		}

		internal static bool by0pTpRUVqT7jfedNNe()
		{
			return rdXFpERKLMHCDC5otlC == null;
		}

		internal static CreatureWrapper oRS4n4RXSN84y7hreE3()
		{
			return rdXFpERKLMHCDC5otlC;
		}
	}
	public class PlayerCooldowns
	{
		public PrefabGUID AbilityGUID;

		public AbilityDescription Description;

		public float Cooldown;

		private static PlayerCooldowns mjjVShRtA5vlbalDY2x;

		public PlayerCooldowns(PrefabGUID abilityGUID, AbilityDescription abilityDescription)
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			base..ctor();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					AbilityGUID = abilityGUID;
					num = 3;
					break;
				case 3:
					Description = abilityDescription;
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				default:
					Cooldown = abilityDescription.Cooldown;
					num = 1;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public void DecreaseCooldown(float deltaTime)
		{
			int num = 3;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						goto end_IL_0012;
					case 0:
						return;
					case 5:
						return;
					case 3:
						Cooldown -= deltaTime;
						num2 = 2;
						continue;
					case 4:
						if (!flag)
						{
							num2 = 0;
							if (519538535 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 1:
						break;
					}
					Cooldown = 0f;
					num2 = 5;
					continue;
					end_IL_0012:
					break;
				}
				flag = Cooldown < 0f;
				num = 4;
			}
		}

		public bool IsOnCooldown()
		{
			int num = 1;
			int num2 = num;
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 1:
					result = Cooldown > 0f;
					num2 = 0;
					if (133732588 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return result;
				}
			}
		}

		internal static bool OymeKaRQFwF1LA80bQB()
		{
			return mjjVShRtA5vlbalDY2x == null;
		}

		internal static PlayerCooldowns nhL77GRayFv04E36WrR()
		{
			return mjjVShRtA5vlbalDY2x;
		}
	}
	public class PlayerWrapper : EntityWrapper
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass16_0
		{
			public PlayerCooldowns POey2rn1iI;

			private static <>c__DisplayClass16_0 BZXAw6YFvK0tHuJwDeN;

			public <>c__DisplayClass16_0()
			{
				jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
				base..ctor();
				int num = 0;
				if (1518457776 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal bool rZ6y5k9bXa(PlayerCooldowns c)
			{
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_0040: Unknown result type (might be due to invalid IL or missing references)
				int num = 1;
				int num2 = num;
				int result;
				while (true)
				{
					switch (num2)
					{
					default:
						result = (c.IsOnCooldown() ? 1 : 0);
						break;
					case 1:
						if (c.AbilityGUID == POey2rn1iI.AbilityGUID)
						{
							num2 = 0;
							if (962215133 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						result = 0;
						break;
					}
					break;
				}
				return (byte)result != 0;
			}

			internal static bool UtDF8cYxlbAW9WsiFSY()
			{
				return BZXAw6YFvK0tHuJwDeN == null;
			}

			internal static <>c__DisplayClass16_0 C4lCdpYKphNlabi0krp()
			{
				return BZXAw6YFvK0tHuJwDeN;
			}
		}

		public PlayerCharacter PlayerCharacter;

		public Blood Blood;

		public Equipment Equipment;

		public string Name;

		public string ClanName;

		public float Dev;

		public float Kek;

		public bool IsInDefence;

		public float CastingTime;

		public List<PlayerCooldowns> Cooldowns;

		internal static PlayerWrapper eUaMnJRDxR3pOStxC19;

		public float BloodQuality => Blood.Quality;

		public int EquipmentLevel => (int)(((ModifiableFloat)(ref Equipment.ArmorLevel)).Value + ((ModifiableFloat)(ref Equipment.WeaponLevel)).Value + ((ModifiableFloat)(ref Equipment.SpellLevel)).Value);

		public PlayerWrapper(Entity entity)
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Dev = 0f;
			Kek = 1f;
			IsInDefence = false;
			CastingTime = 0f;
			Cooldowns = new List<PlayerCooldowns>();
			base..ctor(entity);
			int num = 1;
			if (10932459 != 0)
			{
				num = 5;
			}
			bool flag = default(bool);
			while (true)
			{
				EntityManager manager;
				switch (num)
				{
				default:
					return;
				case 6:
					flag = string.IsNullOrEmpty(Name);
					num = 0;
					if (0 == 0)
					{
						num = 1;
					}
					break;
				case 4:
					Name = ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref PlayerCharacter.Name)/*cast due to .constrained prefix*/).ToString();
					num = 2;
					break;
				case 5:
					manager = EntityManagerWrapper.Manager;
					PlayerCharacter = ((EntityManager)(ref manager)).GetComponentData<PlayerCharacter>(entity);
					num = 3;
					break;
				case 1:
					if (flag)
					{
						num = 7;
						break;
					}
					return;
				case 0:
					return;
				case 3:
					manager = EntityManagerWrapper.Manager;
					Equipment = ((EntityManager)(ref manager)).GetComponentData<Equipment>(entity);
					num = 4;
					break;
				case 7:
					Entity = Entity.Null;
					num = 0;
					if (0 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					ClanName = ((object)Unsafe.As<FixedString32Bytes, FixedString32Bytes>(ref PlayerCharacter.SmartClanName)/*cast due to .constrained prefix*/).ToString();
					num = 6;
					break;
				}
			}
		}

		public override void Update()
		{
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			int num = 10;
			bool flag2 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				EntityManager manager;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 7:
						Name = ((object)Unsafe.As<FixedString64Bytes, FixedString64Bytes>(ref PlayerCharacter.Name)/*cast due to .constrained prefix*/).ToString();
						num2 = 11;
						continue;
					case 6:
						break;
					case 4:
						manager = EntityManagerWrapper.Manager;
						Equipment = ((EntityManager)(ref manager)).GetComponentData<Equipment>(Entity);
						num2 = 7;
						continue;
					case 0:
						return;
					case 3:
						if (flag2)
						{
							num2 = 6;
							continue;
						}
						return;
					case 10:
						base.Update();
						num2 = 9;
						continue;
					case 9:
						flag2 = IsValid();
						num2 = 2;
						if (0 == 0)
						{
							num2 = 3;
						}
						continue;
					case 1:
						Entity = Entity.Null;
						num2 = 0;
						if (0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 5:
						if (!flag)
						{
							num2 = 0;
							if (0 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 1;
					case 11:
						ClanName = ((object)Unsafe.As<FixedString32Bytes, FixedString32Bytes>(ref PlayerCharacter.SmartClanName)/*cast due to .constrained prefix*/).ToString();
						num2 = 8;
						continue;
					case 2:
						return;
					case 8:
						flag = string.IsNullOrEmpty(Name);
						num2 = 5;
						continue;
					}
					break;
				}
				manager = EntityManagerWrapper.Manager;
				PlayerCharacter = ((EntityManager)(ref manager)).GetComponentData<PlayerCharacter>(Entity);
				num = 4;
			}
		}

		public void AddCooldown(PlayerCooldowns cooldown)
		{
			int num = 7;
			int num2 = num;
			<>c__DisplayClass16_0 <>c__DisplayClass16_ = default(<>c__DisplayClass16_0);
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					return;
				case 7:
					<>c__DisplayClass16_ = new <>c__DisplayClass16_0();
					num2 = 6;
					if (2093262890 == 0)
					{
						num2 = 4;
					}
					break;
				case 2:
					flag = Cooldowns.Any(<>c__DisplayClass16_.rZ6y5k9bXa);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
				case 5:
					Cooldowns.Add(<>c__DisplayClass16_.POey2rn1iI);
					num2 = 0;
					if (1783996735 != 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (flag)
					{
						return;
					}
					num2 = 5;
					if (2093262890 == 0)
					{
						num2 = 3;
					}
					break;
				case 6:
					<>c__DisplayClass16_.POey2rn1iI = cooldown;
					num2 = 2;
					break;
				}
			}
		}

		public void UpdateCooldowns(float deltaTime)
		{
			int num = 3;
			int num3 = default(int);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						return;
					default:
						num3--;
						num2 = 15;
						continue;
					case 7:
						Cooldowns.RemoveAt(num3);
						num2 = 11;
						if (0 != 0)
						{
							num2 = 8;
						}
						continue;
					case 3:
						flag2 = CastingTime > 0f;
						num2 = 2;
						if (0 == 0)
						{
							num2 = 2;
						}
						continue;
					case 5:
						if (!flag3)
						{
							num2 = 0;
							if (0 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 7;
					case 2:
						if (flag2)
						{
							num2 = 8;
							continue;
						}
						goto case 9;
					case 14:
						flag3 = !Cooldowns[num3].IsOnCooldown();
						num2 = 5;
						continue;
					case 1:
					case 13:
						num3 = Cooldowns.Count - 1;
						num2 = 4;
						if (0 == 0)
						{
							num2 = 6;
						}
						continue;
					case 9:
						CastingTime = 0f;
						num2 = 1;
						if (0 == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
						CastingTime -= deltaTime;
						num2 = 13;
						continue;
					case 6:
					case 15:
						break;
					case 4:
						Cooldowns[num3].DecreaseCooldown(deltaTime);
						num2 = 14;
						if (2093262890 == 0)
						{
							num2 = 5;
						}
						continue;
					case 12:
						if (!flag)
						{
							num2 = 10;
							if (1435650279 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					}
					break;
				}
				flag = num3 >= 0;
				num = 12;
			}
		}

		public void UpdateProtectionTime(float deltaTime)
		{
			int num = 3;
			int num2 = num;
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!flag)
					{
						return;
					}
					num2 = 4;
					break;
				case 3:
					Kek -= deltaTime;
					num2 = 2;
					break;
				case 4:
					Kek = 0f;
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					flag = Kek < 0f;
					num2 = 0;
					if (121889664 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool CcwaS1Rq0p6aHkQ7IAd()
		{
			return eUaMnJRDxR3pOStxC19 == null;
		}

		internal static PlayerWrapper tnASdwR6QDOaRX3Zbg0()
		{
			return eUaMnJRDxR3pOStxC19;
		}
	}
}
namespace VRisingBephinex.ability
{
	public static class AbilityDatabase
	{
		public static Dictionary<int, AbilityDescription> _abilities;

		internal static AbilityDatabase q1l1aoRujsPCw0pvCfI;

		public static AbilityDescription? GetAbility(int prefabGuid)
		{
			int num = 4;
			AbilityDescription result = default(AbilityDescription);
			bool flag = default(bool);
			AbilityDescription value = default(AbilityDescription);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						break;
					default:
						return result;
					case 5:
						result = null;
						num2 = 0;
						if (962215133 == 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						flag = _abilities.TryGetValue(prefabGuid, out value);
						num2 = 3;
						continue;
					case 3:
						if (flag)
						{
							num2 = 2;
							continue;
						}
						goto case 5;
					}
					break;
				}
				result = value;
				num = 6;
			}
		}

		public static AbilityDescription? GetAbilityBySpawnPrefab(int spawnPrefab)
		{
			foreach (AbilityDescription value in _abilities.Values)
			{
				if (value.SpawnPrefab != spawnPrefab)
				{
					continue;
				}
				return value;
			}
			return null;
		}

		public static List<AbilityDescription> GetDefenceAbilities()
		{
			int num = 1;
			int num2 = num;
			List<AbilityDescription> result = default(List<AbilityDescription>);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = _abilities.Values.Where((AbilityDescription a) => a.IsDefence).ToList();
					num2 = 0;
					if (0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static AbilityDatabase()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
						num2 = 2;
						if (0 != 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						return;
					case 2:
						break;
					case 1:
						jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
						num2 = 0;
						if (0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				_abilities = new Dictionary<int, AbilityDescription>
				{
					[-1740243185] = new AbilityDescription
					{
						PrefabGuid = -1740243185,
						Name = "AB_BloodBuff_Corrupted_Angel_Dash_Cast",
						SpawnPrefab = 31625836,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1.1f,
						PostCastTime = 0f
					},
					[232166500] = new AbilityDescription
					{
						PrefabGuid = 232166500,
						Name = "AB_BloodBuff_Corrupted_Harpy_Dash_Cast",
						SpawnPrefab = -1055553242,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1.1f,
						PostCastTime = 0f
					},
					[2057555049] = new AbilityDescription
					{
						PrefabGuid = 2057555049,
						Name = "AB_Blood_BloodFountain_Cast",
						SpawnPrefab = 1472352650,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-1412027900] = new AbilityDescription
					{
						PrefabGuid = -1412027900,
						Name = "AB_Blood_BloodFountain_SpellMod_Recast_Cast",
						SpawnPrefab = -198029743,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[337805438] = new AbilityDescription
					{
						PrefabGuid = 337805438,
						Name = "AB_Blood_BloodRage_Cast",
						SpawnPrefab = 1522616113,
						Speed = -1f,
						LifeTimeDuration = 0.1f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.4f
					},
					[863435029] = new AbilityDescription
					{
						PrefabGuid = 863435029,
						Name = "AB_Blood_BloodRite_Cast",
						SpawnPrefab = 154981615,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.2f
					},
					[928544163] = new AbilityDescription
					{
						PrefabGuid = 928544163,
						Name = "AB_Blood_BloodStorm_Cast",
						SpawnPrefab = -429372830,
						Speed = -1f,
						LifeTimeDuration = 3f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 1.5f,
						PostCastTime = 0f
					},
					[-775157186] = new AbilityDescription
					{
						PrefabGuid = -775157186,
						Name = "AB_Blood_CarrionSwarm_Cast_01",
						SpawnPrefab = -593275986,
						Speed = 8f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[795788195] = new AbilityDescription
					{
						PrefabGuid = 795788195,
						Name = "AB_Blood_CrimsonBeam_Cast",
						SpawnPrefab = 372033291,
						Speed = -1f,
						LifeTimeDuration = 3f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-987297406] = new AbilityDescription
					{
						PrefabGuid = -987297406,
						Name = "AB_Blood_HeartStrike_Cast",
						SpawnPrefab = -2007539911,
						Speed = -1f,
						LifeTimeDuration = 0.75f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.7f,
						PostCastTime = 0.5f
					},
					[-443292115] = new AbilityDescription
					{
						PrefabGuid = -443292115,
						Name = "AB_Blood_SanguineCoil_Cast01",
						SpawnPrefab = -1020618296,
						Speed = 24f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.25f
					},
					[1200039838] = new AbilityDescription
					{
						PrefabGuid = 1200039838,
						Name = "AB_Blood_SanguineCoil_Cast02",
						SpawnPrefab = -1020618296,
						Speed = 24f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.25f
					},
					[-1432574436] = new AbilityDescription
					{
						PrefabGuid = -1432574436,
						Name = "AB_Blood_Shadowbolt_Cast",
						SpawnPrefab = 1998252380,
						Speed = 22f,
						LifeTimeDuration = 0.54545456f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[-254998690] = new AbilityDescription
					{
						PrefabGuid = -254998690,
						Name = "AB_Blood_VampiricCurse_Cast",
						SpawnPrefab = 270228277,
						Speed = 22f,
						LifeTimeDuration = 0.54545456f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[-647349550] = new AbilityDescription
					{
						PrefabGuid = -647349550,
						Name = "AB_Chaos_Aftershock_Cast",
						SpawnPrefab = -243208974,
						Speed = 20f,
						LifeTimeDuration = 0.6f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.2f
					},
					[980100276] = new AbilityDescription
					{
						PrefabGuid = 980100276,
						Name = "AB_Chaos_Barrier_Cast",
						SpawnPrefab = -352442632,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = false,
						Cooldown = 11f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[-1869527555] = new AbilityDescription
					{
						PrefabGuid = -1869527555,
						Name = "AB_Chaos_Barrier_Recast_Cast",
						SpawnPrefab = 1963614275,
						Speed = 30f,
						LifeTimeDuration = 7f / 15f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[133479300] = new AbilityDescription
					{
						PrefabGuid = 133479300,
						Name = "AB_Chaos_ChaosBarrage_Cast",
						SpawnPrefab = -800216016,
						Speed = 26f,
						LifeTimeDuration = 2f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 1f,
						PostCastTime = 0.2f
					},
					[-667967135] = new AbilityDescription
					{
						PrefabGuid = -667967135,
						Name = "AB_Chaos_MercilessCharge_Cast",
						SpawnPrefab = 1326012900,
						Speed = -1f,
						LifeTimeDuration = 0.7f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.7f,
						PostCastTime = 0.5f
					},
					[1141366098] = new AbilityDescription
					{
						PrefabGuid = 1141366098,
						Name = "AB_Chaos_PowerSurge_Cast",
						SpawnPrefab = -429891372,
						Speed = -1f,
						LifeTimeDuration = 3f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.15f
					},
					[-2062460405] = new AbilityDescription
					{
						PrefabGuid = -2062460405,
						Name = "AB_Chaos_PowerSurge_Spellmod_Recast_Cast",
						SpawnPrefab = -254603202,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.05f
					},
					[901495348] = new AbilityDescription
					{
						PrefabGuid = 901495348,
						Name = "AB_Chaos_RainOfChaos_Cast",
						SpawnPrefab = -919146370,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = true,
						Cooldown = 12f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.3f
					},
					[925745426] = new AbilityDescription
					{
						PrefabGuid = 925745426,
						Name = "AB_Chaos_Voidquake_Cast",
						SpawnPrefab = -452698233,
						Speed = -1f,
						LifeTimeDuration = 1.2f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.1f,
						PostCastTime = 1.3f
					},
					[-707328735] = new AbilityDescription
					{
						PrefabGuid = -707328735,
						Name = "AB_Chaos_Void_Cast",
						SpawnPrefab = -1734564881,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[1654851767] = new AbilityDescription
					{
						PrefabGuid = 1654851767,
						Name = "AB_Chaos_Volley_Cast",
						SpawnPrefab = 385090887,
						Speed = 22f,
						LifeTimeDuration = 0.85f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.25f
					},
					[1399619536] = new AbilityDescription
					{
						PrefabGuid = 1399619536,
						Name = "AB_FrostBarrier_Cast",
						SpawnPrefab = -146943441,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = false,
						Cooldown = 11f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[1382820959] = new AbilityDescription
					{
						PrefabGuid = 1382820959,
						Name = "AB_FrostBarrier_Recast_Cast",
						SpawnPrefab = 722096580,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.2f
					},
					[-1655280244] = new AbilityDescription
					{
						PrefabGuid = -1655280244,
						Name = "AB_FrostCone_Cast",
						SpawnPrefab = -1285185439,
						Speed = -1f,
						LifeTimeDuration = 1.2f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[-1308029200] = new AbilityDescription
					{
						PrefabGuid = -1308029200,
						Name = "AB_Frost_ArcticLeap_Cast",
						SpawnPrefab = 1611866499,
						Speed = -1f,
						LifeTimeDuration = 1.2f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.15f,
						PostCastTime = 1.3f
					},
					[842159268] = new AbilityDescription
					{
						PrefabGuid = 842159268,
						Name = "AB_Frost_ColdSnap_Cast",
						SpawnPrefab = 685701454,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.2f
					},
					[1360996740] = new AbilityDescription
					{
						PrefabGuid = 1360996740,
						Name = "AB_Frost_CrystalLance_Cast",
						SpawnPrefab = -1339830868,
						Speed = 22f,
						LifeTimeDuration = 0.54545456f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[220122942] = new AbilityDescription
					{
						PrefabGuid = 220122942,
						Name = "AB_Frost_FrostBat_Cast",
						SpawnPrefab = 661536530,
						Speed = 22f,
						LifeTimeDuration = 0.54545456f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.25f
					},
					[-1854250832] = new AbilityDescription
					{
						PrefabGuid = -1854250832,
						Name = "AB_Frost_IceBlockVortex_Cast",
						SpawnPrefab = 1374658841,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.1f,
						PostCastTime = 0.15f
					},
					[-1901852538] = new AbilityDescription
					{
						PrefabGuid = -1901852538,
						Name = "AB_Frost_IceNova_Cast",
						SpawnPrefab = 806451467,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.4f
					},
					[-799654122] = new AbilityDescription
					{
						PrefabGuid = -799654122,
						Name = "AB_Frost_IceNova_SpellMod_Recast_Cast",
						SpawnPrefab = 861860875,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.2f
					},
					[609428826] = new AbilityDescription
					{
						PrefabGuid = 609428826,
						Name = "AB_Illusion_Curse_Cast",
						SpawnPrefab = 218990010,
						Speed = -1f,
						LifeTimeDuration = 0.2f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.25f
					},
					[1202983170] = new AbilityDescription
					{
						PrefabGuid = 1202983170,
						Name = "AB_Illusion_MistTrance_Cast",
						SpawnPrefab = -844883320,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.2f
					},
					[-348776938] = new AbilityDescription
					{
						PrefabGuid = -348776938,
						Name = "AB_Illusion_Mosquito_Cast_Target",
						SpawnPrefab = -2124923660,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = true,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[1485010433] = new AbilityDescription
					{
						PrefabGuid = 1485010433,
						Name = "AB_Illusion_PhantomAegis_Cast",
						SpawnPrefab = 1050324275,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = false,
						Cooldown = 11f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.15f
					},
					[1643258338] = new AbilityDescription
					{
						PrefabGuid = 1643258338,
						Name = "AB_Illusion_PhantomAegis_Recast_Cast",
						SpawnPrefab = -180128064,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.05f
					},
					[1466221371] = new AbilityDescription
					{
						PrefabGuid = 1466221371,
						Name = "AB_Illusion_Serpent_Cast",
						SpawnPrefab = -1687982393,
						Speed = 24f,
						LifeTimeDuration = 0.625f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 1.1f,
						PostCastTime = 0.25f
					},
					[1419608225] = new AbilityDescription
					{
						PrefabGuid = 1419608225,
						Name = "AB_Illusion_SpectralGuardian_Summon_Cast",
						SpawnPrefab = 574130531,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[-1246428843] = new AbilityDescription
					{
						PrefabGuid = -1246428843,
						Name = "AB_Illusion_SpectralWolf_Cast",
						SpawnPrefab = -1640018550,
						Speed = 20f,
						LifeTimeDuration = 0.6f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.2f
					},
					[1017168458] = new AbilityDescription
					{
						PrefabGuid = 1017168458,
						Name = "AB_Illusion_WispDance_Cast",
						SpawnPrefab = 1112914174,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.15f,
						PostCastTime = 0.25f
					},
					[-570986876] = new AbilityDescription
					{
						PrefabGuid = -570986876,
						Name = "AB_Illusion_WispDance_Recast_Cast",
						SpawnPrefab = -2042876438,
						Speed = 28f,
						LifeTimeDuration = 0.7f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.25f
					},
					[1980757401] = new AbilityDescription
					{
						PrefabGuid = 1980757401,
						Name = "AB_Illusion_WraithSpear_Cast",
						SpawnPrefab = 654227177,
						Speed = 36f,
						LifeTimeDuration = 0.375f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.35f
					},
					[286387494] = new AbilityDescription
					{
						PrefabGuid = 286387494,
						Name = "AB_Pistols_ExplosiveShot_Shot_Cast",
						SpawnPrefab = -1274932233,
						Speed = 24f,
						LifeTimeDuration = 1f / 3f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.1f
					},
					[-1783827601] = new AbilityDescription
					{
						PrefabGuid = -1783827601,
						Name = "AB_Pistols_ExplosiveShot_Shot_Recast_Cast",
						SpawnPrefab = -858163982,
						Speed = 24f,
						LifeTimeDuration = 1f / 3f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.1f
					},
					[1356553255] = new AbilityDescription
					{
						PrefabGuid = 1356553255,
						Name = "AB_Pistols_FanTheHammer_Cast",
						SpawnPrefab = -102660349,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.25f
					},
					[-1246832826] = new AbilityDescription
					{
						PrefabGuid = -1246832826,
						Name = "AB_Pistols_Primary_Attack_Cast01",
						SpawnPrefab = -736673188,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.1f
					},
					[1552752232] = new AbilityDescription
					{
						PrefabGuid = 1552752232,
						Name = "AB_Pistols_Primary_Attack_Cast02",
						SpawnPrefab = -1103939573,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.1f
					},
					[1394076868] = new AbilityDescription
					{
						PrefabGuid = 1394076868,
						Name = "AB_Pistols_Primary_Attack_Cast03",
						SpawnPrefab = -1103939573,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.3f
					},
					[-1684142361] = new AbilityDescription
					{
						PrefabGuid = -1684142361,
						Name = "AB_Pistols_Primary_Attack_Mounted_Cast01",
						SpawnPrefab = 352611039,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.1f
					},
					[-1117218632] = new AbilityDescription
					{
						PrefabGuid = -1117218632,
						Name = "AB_Pistols_Primary_Attack_Mounted_Cast02",
						SpawnPrefab = 794485805,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.1f
					},
					[-819536316] = new AbilityDescription
					{
						PrefabGuid = -819536316,
						Name = "AB_Pistols_Primary_Attack_Mounted_Cast03",
						SpawnPrefab = 794485805,
						Speed = 28f,
						LifeTimeDuration = 5f / 14f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.3f
					},
					[-1829701216] = new AbilityDescription
					{
						PrefabGuid = -1829701216,
						Name = "AB_Storm_BallLightning_Cast",
						SpawnPrefab = 1330012711,
						Speed = 2f,
						LifeTimeDuration = 3.25f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-537359230] = new AbilityDescription
					{
						PrefabGuid = -537359230,
						Name = "AB_Storm_BallLightning_Spellmod_Recast_Cast",
						SpawnPrefab = 1883720601,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.15f
					},
					[-159503942] = new AbilityDescription
					{
						PrefabGuid = -159503942,
						Name = "AB_Storm_Cyclone_Cast",
						SpawnPrefab = 1147396247,
						Speed = -1f,
						LifeTimeDuration = 8f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.3f
					},
					[922224629] = new AbilityDescription
					{
						PrefabGuid = 922224629,
						Name = "AB_Storm_Discharge_Cast",
						SpawnPrefab = -755938348,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.2f
					},
					[-1491956067] = new AbilityDescription
					{
						PrefabGuid = -1491956067,
						Name = "AB_Storm_Discharge_Spellmod_Recast_Cast",
						SpawnPrefab = 405724396,
						Speed = -1f,
						LifeTimeDuration = 0.2f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.05f,
						PostCastTime = 0.05f
					},
					[1368053381] = new AbilityDescription
					{
						PrefabGuid = 1368053381,
						Name = "AB_Storm_EyeOfTheStorm_Cast",
						SpawnPrefab = 1538254242,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.7f,
						PostCastTime = 0.3f
					},
					[1697734124] = new AbilityDescription
					{
						PrefabGuid = 1697734124,
						Name = "AB_Storm_EyeOfTheStorm_Recast_Cast",
						SpawnPrefab = -890953469,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = true,
						Cooldown = 150f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.3f,
						PostCastTime = 0.3f
					},
					[-396872793] = new AbilityDescription
					{
						PrefabGuid = -396872793,
						Name = "AB_Storm_LightningTendrils_Cast",
						SpawnPrefab = 259467316,
						Speed = -1f,
						LifeTimeDuration = 0.6f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[1220265215] = new AbilityDescription
					{
						PrefabGuid = 1220265215,
						Name = "AB_Storm_LightningTyphoon_Cast",
						SpawnPrefab = -896298364,
						Speed = -1f,
						LifeTimeDuration = 4f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[1459814320] = new AbilityDescription
					{
						PrefabGuid = 1459814320,
						Name = "AB_Storm_LightningWall_Cast",
						SpawnPrefab = -281608365,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = true,
						Cooldown = 11f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[-1683701733] = new AbilityDescription
					{
						PrefabGuid = -1683701733,
						Name = "AB_Storm_PolarityShift_Cast",
						SpawnPrefab = -1046657693,
						Speed = 24f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.4f
					},
					[1726948631] = new AbilityDescription
					{
						PrefabGuid = 1726948631,
						Name = "AB_Storm_RagingTempest_Cast",
						SpawnPrefab = 161600994,
						Speed = -1f,
						LifeTimeDuration = 0.6f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.7f,
						PostCastTime = 0.3f
					},
					[1838786050] = new AbilityDescription
					{
						PrefabGuid = 1838786050,
						Name = "AB_Storm_RagingTempest_Other_DashOut_Cast",
						SpawnPrefab = 1196714737,
						Speed = -1f,
						LifeTimeDuration = 0.4f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.3f
					},
					[-1960130324] = new AbilityDescription
					{
						PrefabGuid = -1960130324,
						Name = "AB_Unholy_ArmyOfTheDead_Cast",
						SpawnPrefab = -1203200208,
						Speed = -1f,
						LifeTimeDuration = 3f,
						IsAoE = false,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.7f,
						PostCastTime = 0.3f
					},
					[-1188505466] = new AbilityDescription
					{
						PrefabGuid = -1188505466,
						Name = "AB_Unholy_ChainsOfDeath_Cast",
						SpawnPrefab = -662134544,
						Speed = 30f,
						LifeTimeDuration = 1f / 3f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.5f
					},
					[1649739922] = new AbilityDescription
					{
						PrefabGuid = 1649739922,
						Name = "AB_Unholy_CorpseExplosion_Cast",
						SpawnPrefab = 57182092,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.3f
					},
					[-1763499516] = new AbilityDescription
					{
						PrefabGuid = -1763499516,
						Name = "AB_Unholy_CorruptedSkull_Cast",
						SpawnPrefab = 917769627,
						Speed = 22f,
						LifeTimeDuration = 0.54545456f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.2f
					},
					[1506843814] = new AbilityDescription
					{
						PrefabGuid = 1506843814,
						Name = "AB_Unholy_DeathKnightStrike_Cast",
						SpawnPrefab = 1553964211,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.9f,
						PostCastTime = 0.4f
					},
					[-438571790] = new AbilityDescription
					{
						PrefabGuid = -438571790,
						Name = "AB_Unholy_DeathKnight_Cast_Target",
						SpawnPrefab = 959030936,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = true,
						Cooldown = 11f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.2f
					},
					[-432062352] = new AbilityDescription
					{
						PrefabGuid = -432062352,
						Name = "AB_Unholy_DeathKnight_MeleeCombo_Cast01",
						SpawnPrefab = 2108430385,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.7f
					},
					[-2132500072] = new AbilityDescription
					{
						PrefabGuid = -2132500072,
						Name = "AB_Unholy_DeathKnight_MeleeCombo_Cast02",
						SpawnPrefab = 2108430385,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.7f
					},
					[1210009422] = new AbilityDescription
					{
						PrefabGuid = 1210009422,
						Name = "AB_Unholy_FallenAngel_Dash_Cast",
						SpawnPrefab = 792307863,
						Speed = -1f,
						LifeTimeDuration = 8f / 9f,
						IsAoE = false,
						Cooldown = 0.3f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.5f
					},
					[-980937315] = new AbilityDescription
					{
						PrefabGuid = -980937315,
						Name = "AB_Unholy_FallenAngel_MeleeAttack_Cast01",
						SpawnPrefab = 222273439,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.3f
					},
					[-1475031143] = new AbilityDescription
					{
						PrefabGuid = -1475031143,
						Name = "AB_Unholy_FallenAngel_MeleeAttack_Cast02",
						SpawnPrefab = 222273439,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.3f
					},
					[326756215] = new AbilityDescription
					{
						PrefabGuid = 326756215,
						Name = "AB_Unholy_FallenAngel_MeleeAttack_Cast03",
						SpawnPrefab = -1020775974,
						Speed = -1f,
						LifeTimeDuration = 0.2f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1.5f,
						PostCastTime = 0.8f
					},
					[972637370] = new AbilityDescription
					{
						PrefabGuid = 972637370,
						Name = "AB_Unholy_FallenAngel_UnholyBarrage_Cast",
						SpawnPrefab = -1875510860,
						Speed = 20f,
						LifeTimeDuration = 1.6f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.2f
					},
					[314501028] = new AbilityDescription
					{
						PrefabGuid = 314501028,
						Name = "AB_Unholy_SkeletonApprentice_Projectile_Cast_01",
						SpawnPrefab = 681373599,
						Speed = 18f,
						LifeTimeDuration = 8f / 9f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.7f
					},
					[-1319556135] = new AbilityDescription
					{
						PrefabGuid = -1319556135,
						Name = "AB_Unholy_SkeletonApprentice_Projectile_Cast_02",
						SpawnPrefab = 681373599,
						Speed = 18f,
						LifeTimeDuration = 8f / 9f,
						IsAoE = false,
						Cooldown = 1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 1.2f
					},
					[898935418] = new AbilityDescription
					{
						PrefabGuid = 898935418,
						Name = "AB_Unholy_SkeletonWarrior_MeleeAttack_Cast01",
						SpawnPrefab = -1566545914,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 2.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.9f
					},
					[724168605] = new AbilityDescription
					{
						PrefabGuid = 724168605,
						Name = "AB_Unholy_SkeletonWarrior_MeleeAttack_Cast02",
						SpawnPrefab = -1566545914,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 2.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.9f
					},
					[-2054271807] = new AbilityDescription
					{
						PrefabGuid = -2054271807,
						Name = "AB_Unholy_Soulburn_Cast",
						SpawnPrefab = 81992938,
						Speed = -1f,
						LifeTimeDuration = 5f,
						IsAoE = false,
						Cooldown = 9f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1313802242] = new AbilityDescription
					{
						PrefabGuid = 1313802242,
						Name = "AB_Unholy_SummonFallenAngel_Cast",
						SpawnPrefab = -1965470202,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = true,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.2f,
						PostCastTime = 0.3f
					},
					[421353201] = new AbilityDescription
					{
						PrefabGuid = 421353201,
						Name = "AB_Unholy_UnstableArachnid_Cast",
						SpawnPrefab = -1042746138,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = true,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[-274736833] = new AbilityDescription
					{
						PrefabGuid = -274736833,
						Name = "AB_Unholy_UnstableArachnid_Recast_Cast",
						SpawnPrefab = -1042746138,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = true,
						Cooldown = 120f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = true,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[-793767988] = new AbilityDescription
					{
						PrefabGuid = -793767988,
						Name = "AB_Unholy_UnstableArarchnid_Explode_Cast",
						SpawnPrefab = 1712440972,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.8f,
						PostCastTime = 1f
					},
					[824239749] = new AbilityDescription
					{
						PrefabGuid = 824239749,
						Name = "AB_Unholy_UnstableArarchnid_Explode_Small_Cast",
						SpawnPrefab = -728541516,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 1f
					},
					[685461747] = new AbilityDescription
					{
						PrefabGuid = 685461747,
						Name = "AB_Unholy_WardOfTheDamned_Cast",
						SpawnPrefab = 463497101,
						Speed = -1f,
						LifeTimeDuration = 2f,
						IsAoE = false,
						Cooldown = 11f,
						IsDefence = true,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[-771833529] = new AbilityDescription
					{
						PrefabGuid = -771833529,
						Name = "AB_Unholy_WardOfTheDamned_Recast_Cast",
						SpawnPrefab = 1957872578,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.2f
					},
					[1671733210] = new AbilityDescription
					{
						PrefabGuid = 1671733210,
						Name = "AB_Vampire_Axe_Frenzy_Dash_Cast",
						SpawnPrefab = 706730253,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.2f
					},
					[1215815401] = new AbilityDescription
					{
						PrefabGuid = 1215815401,
						Name = "AB_Vampire_Axe_Primary_MeleeAttack_Cast01",
						SpawnPrefab = -1733898626,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.25f
					},
					[1039072868] = new AbilityDescription
					{
						PrefabGuid = 1039072868,
						Name = "AB_Vampire_Axe_Primary_MeleeAttack_Cast02",
						SpawnPrefab = -1192587580,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.25f
					},
					[1822540594] = new AbilityDescription
					{
						PrefabGuid = 1822540594,
						Name = "AB_Vampire_Axe_Primary_MeleeAttack_Cast03",
						SpawnPrefab = -1064937884,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.25f
					},
					[1716063258] = new AbilityDescription
					{
						PrefabGuid = 1716063258,
						Name = "AB_Vampire_Axe_Primary_Mounted_Cast",
						SpawnPrefab = 1213681232,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[624673924] = new AbilityDescription
					{
						PrefabGuid = 624673924,
						Name = "AB_Vampire_Axe_XStrike_Toss_Cast",
						SpawnPrefab = 705543074,
						Speed = 8f,
						LifeTimeDuration = 1.2f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.3f
					},
					[1637102198] = new AbilityDescription
					{
						PrefabGuid = 1637102198,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Cast01",
						SpawnPrefab = 658608536,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[-1149064542] = new AbilityDescription
					{
						PrefabGuid = -1149064542,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Cast02",
						SpawnPrefab = 1985792911,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[1935839696] = new AbilityDescription
					{
						PrefabGuid = 1935839696,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Cast03",
						SpawnPrefab = 1707080361,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[1937113430] = new AbilityDescription
					{
						PrefabGuid = 1937113430,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Unholy_Cast01",
						SpawnPrefab = 1461380343,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[-1633625544] = new AbilityDescription
					{
						PrefabGuid = -1633625544,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Unholy_Cast02",
						SpawnPrefab = -2119173475,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[554782151] = new AbilityDescription
					{
						PrefabGuid = 554782151,
						Name = "AB_Vampire_Claws_Primary_MeleeAttack_Unholy_Cast03",
						SpawnPrefab = 214089400,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.25f,
						PostCastTime = 0.15f
					},
					[1355391975] = new AbilityDescription
					{
						PrefabGuid = 1355391975,
						Name = "AB_Vampire_Claws_Primary_Mounted_Cast",
						SpawnPrefab = 1199194441,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1336763530] = new AbilityDescription
					{
						PrefabGuid = 1336763530,
						Name = "AB_Vampire_Claws_SkeweringLeap_Cast",
						SpawnPrefab = 868920885,
						Speed = -1f,
						LifeTimeDuration = 0.7f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.6f
					},
					[868019555] = new AbilityDescription
					{
						PrefabGuid = 868019555,
						Name = "AB_Vampire_Claws_SkeweringLeap_Unholy_Cast",
						SpawnPrefab = 715237185,
						Speed = -1f,
						LifeTimeDuration = 0.7f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.6f
					},
					[401022955] = new AbilityDescription
					{
						PrefabGuid = 401022955,
						Name = "AB_Vampire_Claws_VaultSlash_Cast",
						SpawnPrefab = -207925621,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.4f
					},
					[1398963271] = new AbilityDescription
					{
						PrefabGuid = 1398963271,
						Name = "AB_Vampire_Claws_VaultSlash_Unholy_Cast",
						SpawnPrefab = -1891034315,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.4f
					},
					[-65317548] = new AbilityDescription
					{
						PrefabGuid = -65317548,
						Name = "AB_Vampire_Crossbow_IceRanger_IceShard_ChannelBarrage_Cast",
						SpawnPrefab = -2125640842,
						Speed = -1f,
						LifeTimeDuration = 2.7f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.2f
					},
					[1510865601] = new AbilityDescription
					{
						PrefabGuid = 1510865601,
						Name = "AB_Vampire_Crossbow_IceShard_Cast",
						SpawnPrefab = 931551669,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.3f
					},
					[1081050588] = new AbilityDescription
					{
						PrefabGuid = 1081050588,
						Name = "AB_Vampire_Crossbow_Primary_Cast",
						SpawnPrefab = 1092920137,
						Speed = 28f,
						LifeTimeDuration = 0.42857143f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[1398193255] = new AbilityDescription
					{
						PrefabGuid = 1398193255,
						Name = "AB_Vampire_Crossbow_Primary_Mounted_Cast",
						SpawnPrefab = -1686893077,
						Speed = 28f,
						LifeTimeDuration = 0.42857143f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[-753601678] = new AbilityDescription
					{
						PrefabGuid = -753601678,
						Name = "AB_Vampire_Crossbow_RainOfBolts_Cast",
						SpawnPrefab = 198834678,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = true,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1364925842] = new AbilityDescription
					{
						PrefabGuid = 1364925842,
						Name = "AB_Vampire_Crossbow_Snapshot_Cast",
						SpawnPrefab = 200910268,
						Speed = 30f,
						LifeTimeDuration = 0.4f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.25f
					},
					[1394178657] = new AbilityDescription
					{
						PrefabGuid = 1394178657,
						Name = "AB_Vampire_Daggers_CallDaggers_Cast",
						SpawnPrefab = 1791596661,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[-385762093] = new AbilityDescription
					{
						PrefabGuid = -385762093,
						Name = "AB_Vampire_Daggers_Primary_Cast",
						SpawnPrefab = 799431121,
						Speed = 28f,
						LifeTimeDuration = 0.15f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.1f
					},
					[113706722] = new AbilityDescription
					{
						PrefabGuid = 113706722,
						Name = "AB_Vampire_Daggers_Primary_Mounted_Cast",
						SpawnPrefab = -778919424,
						Speed = 28f,
						LifeTimeDuration = 9f / 28f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.6f,
						PostCastTime = 0.1f
					},
					[579933189] = new AbilityDescription
					{
						PrefabGuid = 579933189,
						Name = "AB_Vampire_Daggers_RainOfDaggers_Cast",
						SpawnPrefab = -1088240681,
						Speed = -1f,
						LifeTimeDuration = 0.7f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0f
					},
					[-1816524352] = new AbilityDescription
					{
						PrefabGuid = -1816524352,
						Name = "AB_Vampire_GreatSword_Mounted_Cast",
						SpawnPrefab = 2134250054,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-514059081] = new AbilityDescription
					{
						PrefabGuid = -514059081,
						Name = "AB_Vampire_GreatSword_Primary_Moving_Cast01",
						SpawnPrefab = -1394062631,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[-1388765782] = new AbilityDescription
					{
						PrefabGuid = -1388765782,
						Name = "AB_Vampire_GreatSword_Primary_Moving_Cast02",
						SpawnPrefab = -1035287075,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[294272314] = new AbilityDescription
					{
						PrefabGuid = 294272314,
						Name = "AB_Vampire_GreatSword_Primary_Moving_Cast03",
						SpawnPrefab = -1026527015,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.2f
					},
					[-1622040119] = new AbilityDescription
					{
						PrefabGuid = -1622040119,
						Name = "AB_Vampire_Longbow_GuidedArrow_Cast",
						SpawnPrefab = -1787042058,
						Speed = 30f,
						LifeTimeDuration = 13f / 30f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 1f,
						PostCastTime = 0.25f
					},
					[-31853298] = new AbilityDescription
					{
						PrefabGuid = -31853298,
						Name = "AB_Vampire_Longbow_Primary_Cast",
						SpawnPrefab = -159061575,
						Speed = 28f,
						LifeTimeDuration = 9f / 28f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 5f,
						PostCastTime = 0.25f
					},
					[601335909] = new AbilityDescription
					{
						PrefabGuid = 601335909,
						Name = "AB_Vampire_Longbow_Primary_Mounted_Cast",
						SpawnPrefab = 112701587,
						Speed = 28f,
						LifeTimeDuration = 9f / 28f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 5f,
						PostCastTime = 0.25f
					},
					[1650339556] = new AbilityDescription
					{
						PrefabGuid = 1650339556,
						Name = "AB_Vampire_Mace_CrushingBlow_Slam_Cast",
						SpawnPrefab = -815273645,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.65f,
						PostCastTime = 0.4f
					},
					[2094451872] = new AbilityDescription
					{
						PrefabGuid = 2094451872,
						Name = "AB_Vampire_Mace_Primary_MeleeAttack_Cast01",
						SpawnPrefab = 2088529393,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.2f
					},
					[-492074341] = new AbilityDescription
					{
						PrefabGuid = -492074341,
						Name = "AB_Vampire_Mace_Primary_MeleeAttack_Cast02",
						SpawnPrefab = -1082055433,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.2f
					},
					[1014770566] = new AbilityDescription
					{
						PrefabGuid = 1014770566,
						Name = "AB_Vampire_Mace_Primary_MeleeAttack_Cast03",
						SpawnPrefab = -978853222,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.35f,
						PostCastTime = 0.2f
					},
					[-693048327] = new AbilityDescription
					{
						PrefabGuid = -693048327,
						Name = "AB_Vampire_Mace_Primary_Mounted_Cast",
						SpawnPrefab = -43419376,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.45f,
						PostCastTime = 0.3f
					},
					[-856181990] = new AbilityDescription
					{
						PrefabGuid = -856181990,
						Name = "AB_Vampire_Mace_Smack_Cast",
						SpawnPrefab = -759027559,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-316825244] = new AbilityDescription
					{
						PrefabGuid = -316825244,
						Name = "AB_Vampire_Reaper_HowlingReaper_Cast",
						SpawnPrefab = 109680761,
						Speed = 2f,
						LifeTimeDuration = 2.2f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.5f,
						PostCastTime = 0.3f
					},
					[1176579852] = new AbilityDescription
					{
						PrefabGuid = 1176579852,
						Name = "AB_Vampire_Reaper_Primary_MeleeAttack_Cast01",
						SpawnPrefab = -1766314654,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[363287836] = new AbilityDescription
					{
						PrefabGuid = 363287836,
						Name = "AB_Vampire_Reaper_Primary_MeleeAttack_Cast02",
						SpawnPrefab = -323855182,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.2f
					},
					[-131396040] = new AbilityDescription
					{
						PrefabGuid = -131396040,
						Name = "AB_Vampire_Reaper_Primary_MeleeAttack_Cast03",
						SpawnPrefab = -318138984,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0.65f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.5f
					},
					[666559714] = new AbilityDescription
					{
						PrefabGuid = 666559714,
						Name = "AB_Vampire_Reaper_Primary_Mounted_Cast",
						SpawnPrefab = 395001170,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.45f,
						PostCastTime = 0.3f
					},
					[344610321] = new AbilityDescription
					{
						PrefabGuid = 344610321,
						Name = "AB_Vampire_Reaper_TendonSwing_Twist_Cast",
						SpawnPrefab = -1991287544,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.2f
					},
					[-2092408386] = new AbilityDescription
					{
						PrefabGuid = -2092408386,
						Name = "AB_Vampire_Slashers_Camouflage_Main_Cast",
						SpawnPrefab = 252363754,
						Speed = -1f,
						LifeTimeDuration = 2.5f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.2f
					},
					[576817260] = new AbilityDescription
					{
						PrefabGuid = 576817260,
						Name = "AB_Vampire_Slashers_Camouflage_Secondary_Cast",
						SpawnPrefab = -1816671929,
						Speed = -1f,
						LifeTimeDuration = 0.1f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.3f
					},
					[-1731625958] = new AbilityDescription
					{
						PrefabGuid = -1731625958,
						Name = "AB_Vampire_Slashers_ElusiveStrike_Dash_Cast",
						SpawnPrefab = 1109256146,
						Speed = -1f,
						LifeTimeDuration = 0.325f,
						IsAoE = false,
						Cooldown = 10f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0f
					},
					[2138997168] = new AbilityDescription
					{
						PrefabGuid = 2138997168,
						Name = "AB_Vampire_Slashers_Primary_MeleeAttack_Cast01",
						SpawnPrefab = 575476860,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.15f,
						PostCastTime = 0.15f
					},
					[-538471976] = new AbilityDescription
					{
						PrefabGuid = -538471976,
						Name = "AB_Vampire_Slashers_Primary_MeleeAttack_Cast02",
						SpawnPrefab = -916190530,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.1f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.15f,
						PostCastTime = 0.15f
					},
					[-553275783] = new AbilityDescription
					{
						PrefabGuid = -553275783,
						Name = "AB_Vampire_Slashers_Primary_MeleeAttack_Cast03",
						SpawnPrefab = -130408903,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.55f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.15f,
						PostCastTime = 0.15f
					},
					[-799656850] = new AbilityDescription
					{
						PrefabGuid = -799656850,
						Name = "AB_Vampire_Slashers_Primary_Mounted_Cast",
						SpawnPrefab = -1642831673,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[414243770] = new AbilityDescription
					{
						PrefabGuid = 414243770,
						Name = "AB_Vampire_Spear_Harpoon_Throw_Cast",
						SpawnPrefab = 1649391651,
						Speed = 28f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.35f
					},
					[-765309196] = new AbilityDescription
					{
						PrefabGuid = -765309196,
						Name = "AB_Vampire_Spear_Primary_Attack_Cast01",
						SpawnPrefab = -440626857,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.25f
					},
					[-69267758] = new AbilityDescription
					{
						PrefabGuid = -69267758,
						Name = "AB_Vampire_Spear_Primary_Attack_Cast02",
						SpawnPrefab = -738567452,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.25f
					},
					[-1238015847] = new AbilityDescription
					{
						PrefabGuid = -1238015847,
						Name = "AB_Vampire_Spear_Primary_Attack_Cast03",
						SpawnPrefab = 776418067,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.7f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.25f
					},
					[-717860665] = new AbilityDescription
					{
						PrefabGuid = -717860665,
						Name = "AB_Vampire_Spear_Primary_Mounted_Cast",
						SpawnPrefab = 977915645,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.45f,
						PostCastTime = 0.3f
					},
					[-2110227527] = new AbilityDescription
					{
						PrefabGuid = -2110227527,
						Name = "AB_Vampire_Sword_Primary_MeleeAttack_Cast01",
						SpawnPrefab = -259301272,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.15f
					},
					[1894476748] = new AbilityDescription
					{
						PrefabGuid = 1894476748,
						Name = "AB_Vampire_Sword_Primary_MeleeAttack_Cast02",
						SpawnPrefab = 149968785,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.15f
					},
					[-371304967] = new AbilityDescription
					{
						PrefabGuid = -371304967,
						Name = "AB_Vampire_Sword_Primary_MeleeAttack_Cast03",
						SpawnPrefab = 95826761,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.2f,
						PostCastTime = 0.15f
					},
					[-892210814] = new AbilityDescription
					{
						PrefabGuid = -892210814,
						Name = "AB_Vampire_Sword_Primary_Mounted_Cast",
						SpawnPrefab = 2109532896,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[804759750] = new AbilityDescription
					{
						PrefabGuid = 804759750,
						Name = "AB_Vampire_Sword_Shockwave_Main_Cast",
						SpawnPrefab = 1283973178,
						Speed = 28f,
						LifeTimeDuration = 0.5f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.7f,
						PostCastTime = 0.3f
					},
					[1541111960] = new AbilityDescription
					{
						PrefabGuid = 1541111960,
						Name = "AB_Vampire_Sword_Shockwave_Recast_Cast",
						SpawnPrefab = -438334309,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.9f
					},
					[955988738] = new AbilityDescription
					{
						PrefabGuid = 955988738,
						Name = "AB_Vampire_Sword_Whirlwind_Spin_Cast",
						SpawnPrefab = -947984689,
						Speed = -1f,
						LifeTimeDuration = 1.1f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.35f
					},
					[713894552] = new AbilityDescription
					{
						PrefabGuid = 713894552,
						Name = "AB_Vampire_TwinBlades_Javelin_Cast",
						SpawnPrefab = 1080492267,
						Speed = -1f,
						LifeTimeDuration = 1.5f,
						IsAoE = true,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.3f,
						PostCastTime = 0.3f
					},
					[2023216160] = new AbilityDescription
					{
						PrefabGuid = 2023216160,
						Name = "AB_Vampire_TwinBlades_Javelin_Recast_Cast",
						SpawnPrefab = 469216240,
						Speed = -1f,
						LifeTimeDuration = 0.71428573f,
						IsAoE = false,
						Cooldown = 0.5f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.1f,
						PostCastTime = 0.4f
					},
					[-2034127456] = new AbilityDescription
					{
						PrefabGuid = -2034127456,
						Name = "AB_Vampire_TwinBlades_Primary_MeleeAttack_Cast01",
						SpawnPrefab = -1718994272,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1999458981] = new AbilityDescription
					{
						PrefabGuid = 1999458981,
						Name = "AB_Vampire_TwinBlades_Primary_MeleeAttack_Cast02",
						SpawnPrefab = -2005740545,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1603604088] = new AbilityDescription
					{
						PrefabGuid = 1603604088,
						Name = "AB_Vampire_TwinBlades_Primary_MeleeAttack_Cast03",
						SpawnPrefab = 293630107,
						Speed = -1f,
						LifeTimeDuration = 1f,
						IsAoE = false,
						Cooldown = 0.6f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-753800108] = new AbilityDescription
					{
						PrefabGuid = -753800108,
						Name = "AB_Vampire_TwinBlades_Primary_Mounted_Cast",
						SpawnPrefab = 1428493082,
						Speed = -1f,
						LifeTimeDuration = 0.01f,
						IsAoE = false,
						Cooldown = 1.2f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[-1474711270] = new AbilityDescription
					{
						PrefabGuid = -1474711270,
						Name = "AB_Vampire_TwinBlades_SweepingStrike_Cast",
						SpawnPrefab = 438453495,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = false,
						IsUltimate = false,
						MaxCastTime = 0.4f,
						PostCastTime = 0.3f
					},
					[1414033551] = new AbilityDescription
					{
						PrefabGuid = 1414033551,
						Name = "AB_Vampire_VeilOfShadow_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					},
					[967656807] = new AbilityDescription
					{
						PrefabGuid = 967656807,
						Name = "AB_Vampire_VeilOfChaos_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					},
					[-1075372945] = new AbilityDescription
					{
						PrefabGuid = -1075372945,
						Name = "AB_Vampire_VeilOfBones_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					},
					[-1854440738] = new AbilityDescription
					{
						PrefabGuid = -1854440738,
						Name = "AB_Vampire_VeilOfIllusion_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					},
					[-1869058934] = new AbilityDescription
					{
						PrefabGuid = -1869058934,
						Name = "AB_Vampire_VeilOfFrost_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					},
					[-865260859] = new AbilityDescription
					{
						PrefabGuid = -865260859,
						Name = "AB_Vampire_VeilOfStorm_DashCast",
						SpawnPrefab = 924979264,
						Speed = -1f,
						LifeTimeDuration = 0.3f,
						IsAoE = false,
						Cooldown = 8f,
						IsDefence = false,
						IsDash = true,
						IsUltimate = false
					}
				};
				num = 3;
			}
		}

		internal static bool ETI2pyRs9Zst62tA7lK()
		{
			return q1l1aoRujsPCw0pvCfI == null;
		}

		internal static AbilityDatabase J4IP99RPRjnESIWx8cn()
		{
			return q1l1aoRujsPCw0pvCfI;
		}
	}
	public class AbilityDescription
	{
		public int PrefabGuid;

		public string Name;

		public int? SpawnPrefab;

		public float Speed;

		public float LifeTimeDuration;

		public bool IsAoE;

		public float Cooldown;

		public bool IsDefence;

		public bool IsDash;

		public bool IsUltimate;

		public float MaxCastTime;

		public float PostCastTime;

		private static AbilityDescription JMSbbPRkNsy7uMBoceW;

		public AbilityDescription()
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Speed = 0f;
			LifeTimeDuration = 0f;
			MaxCastTime = 0f;
			PostCastTime = 0f;
			base..ctor();
			int num = 0;
			if (747172065 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool hChbvHRTIwvvU4HVWvj()
		{
			return JMSbbPRkNsy7uMBoceW == null;
		}

		internal static AbilityDescription qCM4SmRzrth2iqjnHtt()
		{
			return JMSbbPRkNsy7uMBoceW;
		}
	}
}
internal class <Module>{09D611C0-FB7B-E958-B628-0ADDCF2E3E7D}
{
}
namespace h4pwrXy0hRTHCo506Uc
{
	internal class jiUnG6yLcp99YsGsEb2
	{
		internal class fTOfBQ4BaDeJFXuICOl
		{
			private BinaryReader hcv4v2DGRH;

			public fTOfBQ4BaDeJFXuICOl(Stream P_0)
			{
				hcv4v2DGRH = new BinaryReader(P_0);
			}

			[SpecialName]
			internal Stream EW16BkCWZc()
			{
				return hcv4v2DGRH.BaseStream;
			}

			internal byte[] OBx45DoZNJ(int P_0)
			{
				return hcv4v2DGRH.ReadBytes(P_0);
			}

			internal int bAI42Uyjna(byte[] P_0, int P_1, int P_2)
			{
				return hcv4v2DGRH.Read(P_0, P_1, P_2);
			}

			internal int J8Y4MjDlpQ()
			{
				return hcv4v2DGRH.ReadInt32();
			}

			internal void uR64haY3xP()
			{
				hcv4v2DGRH.Close();
			}
		}

		private delegate void fTJDan4LooR15b5MsfF(object o);

		internal class ktHD5A40BdBlakuTXuh
		{
			internal static string Pfo4VVojse(object P_0, object P_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes((string)P_0);
				byte[] key = new byte[32]
				{
					82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
					51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
					34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
					1, 88
				};
				byte[] iV = RCyy8kLscY(Encoding.Unicode.GetBytes((string)P_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = tTjyQ74K5k();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		private static uint[] J8t4YUBgBt;

		private static RSACryptoServiceProvider Jxj4COdBOb;

		private static byte[] Gdm4SanfKy;

		private static List<int> WRI4ccsCBF;

		private byte[] DSu4fCCDmU;

		private static List<string> vCj4wZmgDD;

		private static object D9s4pOVMhe;

		private static bool U2H4EjR9t0;

		private byte[] wb04W1bZ4f;

		private static Dictionary<int, int> JUg4ivfZcW;

		private static object vUF4GwaqoN;

		private static Assembly oha472keF2;

		private static bool AH24rt4HmK;

		private static int msn4lmUXtF;

		private static byte[] sSM4brY2Nd;

		static jiUnG6yLcp99YsGsEb2()
		{
			J8t4YUBgBt = new uint[64]
			{
				3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
				4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
				3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
				1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
				681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
				2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
				4149444226u, 3174756917u, 718787259u, 3951481745u
			};
			AH24rt4HmK = false;
			U2H4EjR9t0 = false;
			JUg4ivfZcW = null;
			D9s4pOVMhe = new object();
			oha472keF2 = typeof(jiUnG6yLcp99YsGsEb2).Assembly;
			sSM4brY2Nd = new byte[0];
			Jxj4COdBOb = null;
			Gdm4SanfKy = new byte[0];
			vUF4GwaqoN = new object();
			vCj4wZmgDD = null;
			WRI4ccsCBF = null;
			msn4lmUXtF = 0;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		internal jiUnG6yLcp99YsGsEb2()
		{
		}

		private void algrPeDLBj()
		{
		}

		internal static byte[] iH1yVKrnp3(object P_0)
		{
			uint[] array = new uint[16];
			uint num = (uint)((448 - ((Array)P_0).Length * 8 % 512 + 512) % 512);
			if (num == 0)
			{
				num = 512u;
			}
			uint num2 = (uint)(((Array)P_0).Length + num / 8 + 8);
			ulong num3 = (ulong)((Array)P_0).Length * 8uL;
			byte[] array2 = new byte[num2];
			for (int i = 0; i < ((Array)P_0).Length; i++)
			{
				array2[i] = ((byte[])P_0)[i];
			}
			array2[((Array)P_0).Length] |= 128;
			for (int num4 = 8; num4 > 0; num4--)
			{
				array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
			}
			uint num5 = (uint)(array2.Length * 8) / 32u;
			uint num6 = 1732584193u;
			uint num7 = 4023233417u;
			uint num8 = 2562383102u;
			uint num9 = 271733878u;
			for (uint num10 = 0u; num10 < num5 / 16; num10++)
			{
				uint num11 = num10 << 6;
				for (uint num12 = 0u; num12 < 61; num12 += 4)
				{
					array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
				}
				uint num13 = num6;
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				XcuyHdCI7x(ref num6, num7, num8, num9, 0u, 7, 1u, array);
				XcuyHdCI7x(ref num9, num6, num7, num8, 1u, 12, 2u, array);
				XcuyHdCI7x(ref num8, num9, num6, num7, 2u, 17, 3u, array);
				XcuyHdCI7x(ref num7, num8, num9, num6, 3u, 22, 4u, array);
				XcuyHdCI7x(ref num6, num7, num8, num9, 4u, 7, 5u, array);
				XcuyHdCI7x(ref num9, num6, num7, num8, 5u, 12, 6u, array);
				XcuyHdCI7x(ref num8, num9, num6, num7, 6u, 17, 7u, array);
				XcuyHdCI7x(ref num7, num8, num9, num6, 7u, 22, 8u, array);
				XcuyHdCI7x(ref num6, num7, num8, num9, 8u, 7, 9u, array);
				XcuyHdCI7x(ref num9, num6, num7, num8, 9u, 12, 10u, array);
				XcuyHdCI7x(ref num8, num9, num6, num7, 10u, 17, 11u, array);
				XcuyHdCI7x(ref num7, num8, num9, num6, 11u, 22, 12u, array);
				XcuyHdCI7x(ref num6, num7, num8, num9, 12u, 7, 13u, array);
				XcuyHdCI7x(ref num9, num6, num7, num8, 13u, 12, 14u, array);
				XcuyHdCI7x(ref num8, num9, num6, num7, 14u, 17, 15u, array);
				XcuyHdCI7x(ref num7, num8, num9, num6, 15u, 22, 16u, array);
				Bp9y9FADs9(ref num6, num7, num8, num9, 1u, 5, 17u, array);
				Bp9y9FADs9(ref num9, num6, num7, num8, 6u, 9, 18u, array);
				Bp9y9FADs9(ref num8, num9, num6, num7, 11u, 14, 19u, array);
				Bp9y9FADs9(ref num7, num8, num9, num6, 0u, 20, 20u, array);
				Bp9y9FADs9(ref num6, num7, num8, num9, 5u, 5, 21u, array);
				Bp9y9FADs9(ref num9, num6, num7, num8, 10u, 9, 22u, array);
				Bp9y9FADs9(ref num8, num9, num6, num7, 15u, 14, 23u, array);
				Bp9y9FADs9(ref num7, num8, num9, num6, 4u, 20, 24u, array);
				Bp9y9FADs9(ref num6, num7, num8, num9, 9u, 5, 25u, array);
				Bp9y9FADs9(ref num9, num6, num7, num8, 14u, 9, 26u, array);
				Bp9y9FADs9(ref num8, num9, num6, num7, 3u, 14, 27u, array);
				Bp9y9FADs9(ref num7, num8, num9, num6, 8u, 20, 28u, array);
				Bp9y9FADs9(ref num6, num7, num8, num9, 13u, 5, 29u, array);
				Bp9y9FADs9(ref num9, num6, num7, num8, 2u, 9, 30u, array);
				Bp9y9FADs9(ref num8, num9, num6, num7, 7u, 14, 31u, array);
				Bp9y9FADs9(ref num7, num8, num9, num6, 12u, 20, 32u, array);
				SJgyNwlpWS(ref num6, num7, num8, num9, 5u, 4, 33u, array);
				SJgyNwlpWS(ref num9, num6, num7, num8, 8u, 11, 34u, array);
				SJgyNwlpWS(ref num8, num9, num6, num7, 11u, 16, 35u, array);
				SJgyNwlpWS(ref num7, num8, num9, num6, 14u, 23, 36u, array);
				SJgyNwlpWS(ref num6, num7, num8, num9, 1u, 4, 37u, array);
				SJgyNwlpWS(ref num9, num6, num7, num8, 4u, 11, 38u, array);
				SJgyNwlpWS(ref num8, num9, num6, num7, 7u, 16, 39u, array);
				SJgyNwlpWS(ref num7, num8, num9, num6, 10u, 23, 40u, array);
				SJgyNwlpWS(ref num6, num7, num8, num9, 13u, 4, 41u, array);
				SJgyNwlpWS(ref num9, num6, num7, num8, 0u, 11, 42u, array);
				SJgyNwlpWS(ref num8, num9, num6, num7, 3u, 16, 43u, array);
				SJgyNwlpWS(ref num7, num8, num9, num6, 6u, 23, 44u, array);
				SJgyNwlpWS(ref num6, num7, num8, num9, 9u, 4, 45u, array);
				SJgyNwlpWS(ref num9, num6, num7, num8, 12u, 11, 46u, array);
				SJgyNwlpWS(ref num8, num9, num6, num7, 15u, 16, 47u, array);
				SJgyNwlpWS(ref num7, num8, num9, num6, 2u, 23, 48u, array);
				DRNyjNMp4i(ref num6, num7, num8, num9, 0u, 6, 49u, array);
				DRNyjNMp4i(ref num9, num6, num7, num8, 7u, 10, 50u, array);
				DRNyjNMp4i(ref num8, num9, num6, num7, 14u, 15, 51u, array);
				DRNyjNMp4i(ref num7, num8, num9, num6, 5u, 21, 52u, array);
				DRNyjNMp4i(ref num6, num7, num8, num9, 12u, 6, 53u, array);
				DRNyjNMp4i(ref num9, num6, num7, num8, 3u, 10, 54u, array);
				DRNyjNMp4i(ref num8, num9, num6, num7, 10u, 15, 55u, array);
				DRNyjNMp4i(ref num7, num8, num9, num6, 1u, 21, 56u, array);
				DRNyjNMp4i(ref num6, num7, num8, num9, 8u, 6, 57u, array);
				DRNyjNMp4i(ref num9, num6, num7, num8, 15u, 10, 58u, array);
				DRNyjNMp4i(ref num8, num9, num6, num7, 6u, 15, 59u, array);
				DRNyjNMp4i(ref num7, num8, num9, num6, 13u, 21, 60u, array);
				DRNyjNMp4i(ref num6, num7, num8, num9, 4u, 6, 61u, array);
				DRNyjNMp4i(ref num9, num6, num7, num8, 11u, 10, 62u, array);
				DRNyjNMp4i(ref num8, num9, num6, num7, 2u, 15, 63u, array);
				DRNyjNMp4i(ref num7, num8, num9, num6, 9u, 21, 64u, array);
				num6 += num13;
				num7 += num14;
				num8 += num15;
				num9 += num16;
			}
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
			Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
			return array3;
		}

		private static void XcuyHdCI7x(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
		{
			P_0 = P_1 + meJydv2v2K(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + ((uint[])P_7)[P_4] + J8t4YUBgBt[P_6 - 1], P_5);
		}

		private static void Bp9y9FADs9(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
		{
			P_0 = P_1 + meJydv2v2K(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + ((uint[])P_7)[P_4] + J8t4YUBgBt[P_6 - 1], P_5);
		}

		private static void SJgyNwlpWS(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
		{
			P_0 = P_1 + meJydv2v2K(P_0 + (P_1 ^ P_2 ^ P_3) + ((uint[])P_7)[P_4] + J8t4YUBgBt[P_6 - 1], P_5);
		}

		private static void DRNyjNMp4i(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
		{
			P_0 = P_1 + meJydv2v2K(P_0 + (P_2 ^ (P_1 | ~P_3)) + ((uint[])P_7)[P_4] + J8t4YUBgBt[P_6 - 1], P_5);
		}

		private static uint meJydv2v2K(uint P_0, ushort P_1)
		{
			return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
		}

		internal static byte[] RCyy8kLscY(object P_0)
		{
			if (!weVymUvow9())
			{
				return new MD5CryptoServiceProvider().ComputeHash((byte[])P_0);
			}
			return iH1yVKrnp3(P_0);
		}

		private static void FllyA5WFBR()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		internal static bool weVymUvow9()
		{
			if (!AH24rt4HmK)
			{
				kGmyt0ignl();
				AH24rt4HmK = true;
			}
			return U2H4EjR9t0;
		}

		internal byte[] W9kyJreU3u()
		{
			_ = "PgxlNwKkaH0oQpHG8Lf".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] PMZyZsQowj()
		{
			_ = "zVR101h1D3aBbwTsxF".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] riay1UgJJC()
		{
			_ = "tocJq1jX3BfCY83".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] p7NyFi79u5()
		{
			_ = "Mr7g0AKzS5E6giB84".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		public static void ujwyx9fHko(RuntimeTypeHandle P_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(P_0);
				if (JUg4ivfZcW == null)
				{
					lock (D9s4pOVMhe)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(jiUnG6yLcp99YsGsEb2).Assembly.GetManifestResourceStream("eDUsO7rjWt1iasLxsM.NkBteqEgexEsSRfN6X"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						binaryReader.Close();
						if (array.Length != 0)
						{
							int num = array.Length % 4;
							int num2 = array.Length / 4;
							byte[] array2 = new byte[array.Length];
							uint num3 = 0u;
							uint num4 = 0u;
							if (num > 0)
							{
								num2++;
							}
							uint num5 = 0u;
							for (int i = 0; i < num2; i++)
							{
								int num6 = i * 4;
								uint num7 = 255u;
								int num8 = 0;
								if (i == num2 - 1 && num > 0)
								{
									num4 = 0u;
									for (int j = 0; j < num; j++)
									{
										if (j > 0)
										{
											num4 <<= 8;
										}
										num4 |= array[^(1 + j)];
									}
								}
								else
								{
									num5 = (uint)num6;
									num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
								}
								num3 = num3;
								num3 += icPyK7nM46(num3);
								if (i == num2 - 1 && num > 0)
								{
									uint num9 = num3 ^ num4;
									for (int k = 0; k < num; k++)
									{
										if (k > 0)
										{
											num7 <<= 8;
											num8 += 8;
										}
										array2[num6 + k] = (byte)((num9 & num7) >> num8);
									}
								}
								else
								{
									uint num10 = num3 ^ num4;
									array2[num6] = (byte)(num10 & 0xFF);
									array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
									array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
									array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
								}
							}
							array = array2;
							array2 = null;
							int num11 = array.Length / 8;
							fTOfBQ4BaDeJFXuICOl fTOfBQ4BaDeJFXuICOl = new fTOfBQ4BaDeJFXuICOl(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = fTOfBQ4BaDeJFXuICOl.J8Y4MjDlpQ();
								int value = fTOfBQ4BaDeJFXuICOl.J8Y4MjDlpQ();
								dictionary.Add(key, value);
							}
							fTOfBQ4BaDeJFXuICOl.uR64haY3xP();
						}
						JUg4ivfZcW = dictionary;
					}
				}
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
				foreach (FieldInfo fieldInfo in fields)
				{
					int metadataToken = fieldInfo.MetadataToken;
					int num12 = JUg4ivfZcW[metadataToken];
					bool flag = (num12 & 0x40000000) > 0;
					num12 &= 0x3FFFFFFF;
					MethodInfo methodInfo = (MethodInfo)typeof(jiUnG6yLcp99YsGsEb2).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
						continue;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num13 = parameters.Length + 1;
					Type[] array3 = new Type[num13];
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
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					for (int num14 = 0; num14 < num13; num14++)
					{
						switch (num14)
						{
						case 0:
							iLGenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							iLGenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							iLGenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							iLGenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							iLGenerator.Emit(OpCodes.Ldarg_S, num14);
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Tailcall);
					iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					iLGenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private static uint icPyK7nM46(uint P_0)
		{
			return 0u;
		}

		internal static void I9ayUbHaDB()
		{
			if (Debugger.IsAttached)
			{
				throw new Exception("Debugger Detected");
			}
		}

		private static int QnXyXdlPhU()
		{
			return 5;
		}

		internal static void kGmyt0ignl()
		{
			try
			{
				new MD5CryptoServiceProvider();
			}
			catch
			{
				U2H4EjR9t0 = true;
				return;
			}
			try
			{
				U2H4EjR9t0 = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		internal static SymmetricAlgorithm tTjyQ74K5k()
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (weVymUvow9())
			{
				return new AesCryptoServiceProvider();
			}
			try
			{
				return new RijndaelManaged();
			}
			catch
			{
				return new AesCryptoServiceProvider();
			}
		}

		private byte[] UR2yaJhYb5()
		{
			_ = "G7kJTDs6TQJwwnq".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] Gs4yDv1Vjq()
		{
			_ = "zBowKJJNdkwVaH7".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal static void zQFyq1yRvu(object P_0, object P_1, uint P_2, object P_3)
		{
			while (P_2 != 0)
			{
				int num = ((P_2 > (uint)((Array)P_3).Length) ? ((Array)P_3).Length : ((int)P_2));
				((Stream)P_1).Read((byte[])P_3, 0, num);
				FrMy6dk9UH(P_0, P_3, 0, num);
				P_2 -= (uint)num;
			}
		}

		internal static void FrMy6dk9UH(object P_0, object P_1, int P_2, int P_3)
		{
			((HashAlgorithm)P_0).TransformBlock((byte[])P_1, P_2, P_3, (byte[]?)P_1, P_2);
		}

		internal static uint W1SyuvLv3N(uint P_0, int P_1, long P_2, object P_3)
		{
			for (int i = 0; i < P_1; i++)
			{
				((BinaryReader)P_3).BaseStream.Position = P_2 + (i * 40 + 8);
				uint num = ((BinaryReader)P_3).ReadUInt32();
				uint num2 = ((BinaryReader)P_3).ReadUInt32();
				((BinaryReader)P_3).ReadUInt32();
				uint num3 = ((BinaryReader)P_3).ReadUInt32();
				if (num2 <= P_0 && P_0 < num2 + num)
				{
					return num3 + P_0 - num2;
				}
			}
			return 0u;
		}

		internal static void GDBysSrWAm()
		{
			if (Jxj4COdBOb != null)
			{
				return;
			}
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			Jxj4COdBOb = new RSACryptoServiceProvider();
			string location = typeof(jiUnG6yLcp99YsGsEb2).Assembly.Location;
			if (location == null || location.Length == 0)
			{
				return;
			}
			HashAlgorithm hashAlgorithm = null;
			string text = null;
			try
			{
				hashAlgorithm = SHA1.Create();
				text = CryptoConfig.MapNameToOID("SHA1");
				if (!File.Exists(location))
				{
					return;
				}
			}
			catch
			{
				return;
			}
			bool flag = false;
			try
			{
				fTOfBQ4BaDeJFXuICOl fTOfBQ4BaDeJFXuICOl = new fTOfBQ4BaDeJFXuICOl(oha472keF2.GetManifestResourceStream("b38q8cOAmNZhV1lR"));
				fTOfBQ4BaDeJFXuICOl.EW16BkCWZc().Position = 0L;
				byte[] array = fTOfBQ4BaDeJFXuICOl.OBx45DoZNJ((int)fTOfBQ4BaDeJFXuICOl.EW16BkCWZc().Length);
				byte[] rgbKey = new jiUnG6yLcp99YsGsEb2().Gs4yDv1Vjq();
				byte[] rgbIV = new jiUnG6yLcp99YsGsEb2().UR2yaJhYb5();
				SymmetricAlgorithm symmetricAlgorithm = tTjyQ74K5k();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
				Stream stream = GS8yPy34ub();
				CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				Jxj4COdBOb.FromXmlString(Encoding.UTF8.GetString(eZAyzZP0d5(stream)));
				stream.Close();
				cryptoStream.Close();
				fTOfBQ4BaDeJFXuICOl.uR64haY3xP();
			}
			catch
			{
				flag = true;
			}
			if (!flag)
			{
				BinaryReader binaryReader = null;
				try
				{
					FileStream fileStream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.Read);
					binaryReader = new BinaryReader(fileStream);
					byte[] array2 = new byte[65536];
					zQFyq1yRvu(hashAlgorithm, fileStream, 152u, array2);
					bool num = binaryReader.ReadUInt16() != 523;
					int num2 = (num ? 96 : 112);
					fileStream.Position = 152L;
					fileStream.Read(array2, 0, num2);
					array2[64] = 0;
					array2[65] = 0;
					array2[66] = 0;
					array2[67] = 0;
					FrMy6dk9UH(hashAlgorithm, array2, 0, num2);
					fileStream.Read(array2, 0, 128);
					array2[32] = 0;
					array2[33] = 0;
					array2[34] = 0;
					array2[35] = 0;
					array2[36] = 0;
					array2[37] = 0;
					array2[38] = 0;
					array2[39] = 0;
					FrMy6dk9UH(hashAlgorithm, array2, 0, 128);
					long position = fileStream.Position;
					fileStream.Position = 134L;
					int num3 = binaryReader.ReadUInt16();
					fileStream.Position = position;
					zQFyq1yRvu(hashAlgorithm, fileStream, (uint)(num3 * 40), array2);
					long position2 = fileStream.Position;
					if (num)
					{
						fileStream.Position = 360L;
					}
					else
					{
						fileStream.Position = 376L;
					}
					uint num4 = W1SyuvLv3N(binaryReader.ReadUInt32(), num3, position, binaryReader);
					fileStream.Position = num4 + 32;
					uint num5 = binaryReader.ReadUInt32();
					uint num6 = binaryReader.ReadUInt32();
					long num7 = W1SyuvLv3N(num5, num3, position, binaryReader);
					long num8 = num7 + num6;
					fileStream.Position = position2;
					for (int i = 0; i < num3; i++)
					{
						fileStream.Position = position + i * 40 + 16;
						uint num9 = binaryReader.ReadUInt32();
						uint num10 = binaryReader.ReadUInt32();
						fileStream.Position = num10;
						while (num9 != 0)
						{
							long position3 = fileStream.Position;
							if (num7 <= position3 && position3 < num8)
							{
								uint num11 = (uint)(num8 - position3);
								if (num11 >= num9)
								{
									break;
								}
								num9 -= num11;
								fileStream.Position += num11;
								continue;
							}
							if (position3 >= num8)
							{
								zQFyq1yRvu(hashAlgorithm, fileStream, num9, array2);
								break;
							}
							uint num12 = (uint)Math.Min(num7 - position3, num9);
							zQFyq1yRvu(hashAlgorithm, fileStream, num12, array2);
							num9 -= num12;
						}
					}
					hashAlgorithm.TransformFinalBlock(new byte[0], 0, 0);
					fileStream.Position = num7;
					byte[] array3 = binaryReader.ReadBytes((int)num6);
					Array.Reverse(array3);
					try
					{
						flag = !Jxj4COdBOb.VerifyHash(hashAlgorithm.Hash, text, array3);
					}
					catch
					{
					}
				}
				catch
				{
					flag = true;
				}
				try
				{
					binaryReader?.Close();
				}
				catch
				{
				}
			}
			if (flag)
			{
				throw new Exception(typeof(jiUnG6yLcp99YsGsEb2).Assembly.GetName().Name + " is tampered.");
			}
			flag = false;
		}

		private static Stream GS8yPy34ub()
		{
			return new MemoryStream();
		}

		private static byte[] r5xykbSh2p(object P_0)
		{
			using FileStream fileStream = new FileStream((string)P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			int num = 0;
			int num2 = (int)fileStream.Length;
			byte[] array = new byte[num2];
			while (num2 > 0)
			{
				int num3 = fileStream.Read(array, num, num2);
				num += num3;
				num2 -= num3;
			}
			return array;
		}

		internal static object fsfyTsTQXA(object P_0)
		{
			try
			{
				if (File.Exists(((Assembly)P_0).Location))
				{
					return ((Assembly)P_0).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString()))
				{
					return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
						.ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		private static byte[] eZAyzZP0d5(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		internal byte[] WQx4g3pjXu()
		{
			_ = "sjZWcp5ozO8V6eU6".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] IiI4nHGAab()
		{
			_ = "33vGeirfNpHCkVxA6".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Oam4On22qR(object P_0)
		{
			int num = 1;
			int num2 = num;
			BinaryReader binaryReader = default(BinaryReader);
			byte[] array2 = default(byte[]);
			int num7 = default(int);
			int num6 = default(int);
			byte[] array5 = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					binaryReader = new BinaryReader((Stream)P_0);
					num2 = 0;
					if (caC120Il6QhJUxYlgMd())
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					binaryReader.BaseStream.Position = 0L;
					int num3 = 14;
					if (rqDaSCIfBibcCJvS3cF() == null)
					{
						num3 = 56;
					}
					while (true)
					{
						int num5;
						switch (num3)
						{
						case 130:
							return;
						case 228:
							array2[6] = (byte)num7;
							num3 = 137;
							break;
						case 219:
							array2[30] = 165;
							num3 = 3;
							break;
						case 233:
							array2[8] = (byte)num6;
							num3 = 47;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 184;
							}
							break;
						case 107:
							array2[1] = (byte)num6;
							num3 = 121;
							break;
						case 51:
							array2[4] = (byte)num6;
							num3 = 74;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 70;
							}
							break;
						case 81:
							array2[19] = (byte)num6;
							num3 = 201;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 20;
							}
							break;
						case 110:
							array2[2] = (byte)num7;
							num5 = 229;
							goto IL_0074;
						case 191:
							array2[22] = (byte)num7;
							num3 = 52;
							break;
						case 203:
							num7 = 46 + 54;
							num3 = 228;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 85;
							}
							break;
						case 220:
							array2[28] = (byte)num6;
							num3 = 174;
							break;
						case 168:
							num6 = 160 + 33;
							num5 = 6;
							goto IL_0074;
						case 146:
							num7 = 153 - 51;
							num3 = 105;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 65;
							}
							break;
						case 194:
							array2[3] = 115;
							num5 = 151;
							goto IL_0074;
						case 184:
							array2[8] = 158;
							num3 = 177;
							break;
						case 159:
							array2[18] = (byte)num7;
							num3 = 3;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 63;
							}
							break;
						case 30:
							array2[9] = (byte)num7;
							num3 = 231;
							break;
						case 62:
							array2[19] = 187;
							num3 = 105;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 129;
							}
							break;
						case 227:
							num6 = 208 - 69;
							num3 = 123;
							break;
						case 10:
							array2[30] = 163;
							num3 = 134;
							break;
						case 120:
							array2[23] = (byte)num7;
							num3 = 204;
							break;
						case 166:
							array2[4] = (byte)num6;
							num3 = 68;
							break;
						case 106:
							array2[27] = (byte)num7;
							num3 = 94;
							break;
						case 59:
							array2[9] = (byte)num7;
							num5 = 146;
							goto IL_0074;
						case 95:
							array2[22] = 84;
							num3 = 215;
							break;
						case 40:
							num7 = 51 + 2;
							num3 = 76;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 175;
							}
							break;
						case 154:
							array2[5] = (byte)num7;
							num3 = 203;
							break;
						case 19:
							array2[30] = (byte)num7;
							num3 = 99;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 44;
							}
							break;
						case 174:
							array2[28] = 53;
							num5 = 132;
							goto IL_0074;
						case 76:
							array2[8] = (byte)num6;
							num3 = 18;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 17;
							}
							break;
						case 169:
							num6 = 138 - 53;
							num3 = 29;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 19;
							}
							break;
						case 18:
							num7 = 102 + 90;
							num3 = 53;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 135;
							}
							break;
						case 32:
							array2[30] = (byte)num7;
							num3 = 8;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 10;
							}
							break;
						case 15:
							array2[4] = 39;
							num3 = 188;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 185;
							}
							break;
						case 221:
							num6 = 155 - 120;
							num3 = 183;
							break;
						case 44:
							array2[30] = 90;
							num3 = 219;
							break;
						case 101:
							num7 = 231 - 77;
							num3 = 110;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 62;
							}
							break;
						case 131:
							array2[2] = (byte)num7;
							num3 = 46;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 35;
							}
							break;
						case 80:
							array2[3] = 157;
							num3 = 41;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 194;
							}
							break;
						case 78:
							array2[11] = (byte)num7;
							num3 = 200;
							break;
						case 133:
							num7 = 195 - 65;
							num3 = 33;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 197;
							}
							break;
						case 198:
							array2[29] = 152;
							num3 = 54;
							break;
						case 87:
							array2[18] = (byte)num6;
							num3 = 118;
							break;
						case 108:
							num6 = 149 - 49;
							num3 = 91;
							break;
						case 165:
							array2[20] = (byte)num6;
							num3 = 127;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 210;
							}
							break;
						case 52:
							num7 = 143 - 47;
							num3 = 22;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 120;
							}
							break;
						case 105:
							array2[9] = (byte)num7;
							num3 = 167;
							break;
						case 60:
							array2[22] = (byte)num6;
							num3 = 117;
							break;
						case 212:
							num7 = 207 - 69;
							num3 = 223;
							break;
						case 195:
							num6 = 78 + 79;
							num3 = 172;
							break;
						case 187:
							array2[29] = 162;
							num5 = 143;
							goto IL_0074;
						case 143:
							num7 = 197 + 44;
							num3 = 185;
							break;
						case 102:
							num6 = 16 + 45;
							num3 = 164;
							break;
						case 232:
							num7 = 159 - 97;
							num3 = 192;
							break;
						case 153:
							array2[15] = 163;
							num3 = 54;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 141;
							}
							break;
						case 140:
							num6 = 224 - 74;
							num3 = 145;
							break;
						case 33:
							array2[11] = (byte)num6;
							num3 = 13;
							break;
						case 223:
							array2[5] = (byte)num7;
							num3 = 122;
							break;
						case 161:
							array2[14] = 166;
							num3 = 85;
							break;
						case 208:
							array2[12] = 81;
							num3 = 20;
							break;
						case 152:
							array2[7] = 51;
							num3 = 136;
							break;
						case 218:
							array2[16] = (byte)num6;
							num3 = 53;
							break;
						case 69:
							num6 = 188 + 22;
							num3 = 76;
							break;
						case 43:
							array2[1] = 101;
							num3 = 24;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 89;
							}
							break;
						case 164:
							array2[7] = (byte)num6;
							num3 = 0;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 0;
							}
							break;
						case 188:
							num6 = 174 - 58;
							num3 = 51;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 32;
							}
							break;
						case 148:
							num7 = 241 - 80;
							num3 = 32;
							break;
						case 74:
							array2[4] = 140;
							num3 = 72;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 190;
							}
							break;
						case 72:
							array2[19] = (byte)num7;
							num5 = 209;
							goto IL_0074;
						case 142:
							array2[29] = 116;
							num3 = 198;
							break;
						case 226:
							array2[24] = 166;
							num3 = 84;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 26;
							}
							break;
						case 209:
							array2[19] = 107;
							num3 = 5;
							break;
						case 1:
							array2[13] = (byte)num6;
							num3 = 109;
							break;
						case 49:
							array2[5] = 116;
							num3 = 212;
							break;
						case 54:
							array2[29] = 95;
							num3 = 187;
							break;
						case 186:
							array2[0] = (byte)num6;
							num3 = 126;
							break;
						case 96:
							num7 = 15 + 104;
							num3 = 55;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 52;
							}
							break;
						case 175:
							array2[3] = (byte)num7;
							num3 = 28;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 14;
							}
							break;
						case 124:
							array2[13] = 123;
							num3 = 173;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 61;
							}
							break;
						case 17:
							num6 = 183 + 17;
							num3 = 50;
							break;
						case 79:
							num6 = 23 + 91;
							num3 = 199;
							break;
						case 12:
							num6 = 151 - 50;
							num5 = 220;
							goto IL_0074;
						case 75:
							array2[31] = 81;
							num3 = 116;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 55;
							}
							break;
						case 162:
							array2[8] = (byte)num6;
							num5 = 14;
							goto IL_0074;
						case 82:
							array2[11] = (byte)num7;
							num3 = 70;
							break;
						case 89:
							num6 = 189 - 63;
							num3 = 147;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 78;
							}
							break;
						case 65:
							array2[14] = 87;
							num3 = 161;
							break;
						case 114:
							array2[24] = 148;
							num3 = 226;
							break;
						case 70:
							num7 = 4 + 98;
							num5 = 78;
							goto IL_0074;
						case 14:
							num7 = 36 + 29;
							num3 = 104;
							break;
						case 73:
							num6 = 72 - 28;
							num3 = 166;
							break;
						case 207:
							array2[26] = 71;
							num3 = 70;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 115;
							}
							break;
						case 210:
							num6 = 156 - 52;
							num3 = 31;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 12;
							}
							break;
						case 158:
							num6 = 243 - 81;
							num3 = 22;
							break;
						case 58:
							array2[17] = 112;
							num3 = 11;
							break;
						case 183:
							array2[14] = (byte)num6;
							num3 = 153;
							break;
						case 225:
							num7 = 112 + 83;
							num3 = 98;
							break;
						case 21:
							array2[7] = 221;
							num3 = 152;
							break;
						case 41:
							array2[25] = (byte)num7;
							num3 = 55;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 96;
							}
							break;
						case 34:
							array2[22] = 78;
							num3 = 95;
							break;
						case 31:
							array2[20] = (byte)num6;
							num3 = 158;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 0;
							}
							break;
						case 176:
							num7 = 61 + 42;
							num3 = 36;
							break;
						case 217:
							array2[3] = 101;
							num3 = 160;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 131;
							}
							break;
						case 45:
							num7 = 129 - 24;
							num3 = 0;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 39;
							}
							break;
						case 53:
							array2[16] = 135;
							num3 = 27;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 182;
							}
							break;
						case 86:
							num6 = 115 - 1;
							num3 = 4;
							break;
						case 37:
							num7 = 80 + 42;
							num3 = 125;
							break;
						case 132:
							array2[29] = 195;
							num3 = 142;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 60;
							}
							break;
						case 46:
							num7 = 109 + 58;
							num3 = 83;
							break;
						case 145:
							array2[28] = (byte)num6;
							num3 = 12;
							break;
						case 151:
							array2[4] = 63;
							num3 = 15;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 0;
							}
							break;
						case 4:
							array2[11] = (byte)num6;
							num3 = 7;
							break;
						case 155:
							array2[20] = 110;
							num3 = 64;
							break;
						case 5:
							num7 = 65 + 36;
							num3 = 144;
							break;
						case 144:
							array2[19] = (byte)num7;
							num3 = 232;
							break;
						case 111:
							num7 = 215 - 71;
							num3 = 34;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 41;
							}
							break;
						case 206:
							array2[13] = (byte)num7;
							num5 = 178;
							goto IL_0074;
						case 160:
							array2[3] = 167;
							num3 = 80;
							break;
						case 138:
							array2[10] = 135;
							num3 = 97;
							break;
						case 93:
							num7 = 65 + 83;
							num3 = 106;
							break;
						case 230:
							array2[10] = (byte)num7;
							num3 = 227;
							break;
						case 23:
							array2[20] = 206;
							num3 = 71;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 133;
							}
							break;
						case 139:
							array2[26] = (byte)num6;
							num3 = 10;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 47;
							}
							break;
						default:
							num6 = 39 + 119;
							num3 = 92;
							break;
						case 211:
							num7 = 156 - 52;
							num3 = 103;
							break;
						case 185:
							array2[29] = (byte)num7;
							num3 = 44;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 6;
							}
							break;
						case 115:
							num6 = 104 + 54;
							num5 = 139;
							goto IL_0074;
						case 67:
							num6 = 232 - 77;
							num3 = 186;
							break;
						case 167:
							num7 = 187 + 37;
							num3 = 30;
							break;
						case 103:
							array2[9] = (byte)num7;
							num3 = 68;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 156;
							}
							break;
						case 178:
							array2[14] = 196;
							num3 = 65;
							break;
						case 57:
							array2[15] = (byte)num7;
							num3 = 65;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 77;
							}
							break;
						case 134:
							num7 = 70 - 34;
							num5 = 19;
							goto IL_0074;
						case 66:
							array2[0] = 103;
							num3 = 196;
							break;
						case 141:
							array2[15] = 160;
							num3 = 42;
							break;
						case 229:
							array2[2] = 205;
							num3 = 79;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 163;
							}
							break;
						case 28:
							num6 = 202 - 67;
							num3 = 127;
							break;
						case 16:
							array2[0] = (byte)num7;
							num3 = 66;
							break;
						case 68:
							array2[5] = 138;
							num3 = 193;
							break;
						case 197:
							array2[21] = (byte)num7;
							num3 = 88;
							break;
						case 173:
							num6 = 157 - 52;
							num3 = 1;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 1;
							}
							break;
						case 150:
							array2[10] = (byte)num7;
							num3 = 17;
							break;
						case 94:
							array2[27] = 26;
							num3 = 140;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 86;
							}
							break;
						case 121:
							array2[2] = 133;
							num3 = 101;
							break;
						case 48:
							array2[24] = 63;
							num3 = 195;
							break;
						case 202:
							array2[14] = (byte)num7;
							num3 = 57;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 221;
							}
							break;
						case 126:
							num7 = 170 - 56;
							num5 = 16;
							goto IL_0074;
						case 157:
							array2[20] = 118;
							num3 = 155;
							break;
						case 129:
							num6 = 184 - 61;
							num3 = 60;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 81;
							}
							break;
						case 25:
							array2[17] = 87;
							num3 = 31;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 35;
							}
							break;
						case 224:
							array2[7] = 130;
							num5 = 102;
							goto IL_0074;
						case 123:
							array2[10] = (byte)num6;
							num3 = 138;
							break;
						case 55:
							array2[25] = (byte)num7;
							num3 = 27;
							break;
						case 193:
							array2[5] = 165;
							num5 = 49;
							goto IL_0074;
						case 109:
							num7 = 177 + 77;
							num5 = 206;
							goto IL_0074;
						case 201:
							num7 = 58 + 46;
							num5 = 72;
							goto IL_0074;
						case 205:
							num6 = 216 - 72;
							num3 = 3;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 87;
							}
							break;
						case 29:
							array2[25] = (byte)num6;
							num3 = 207;
							break;
						case 214:
							array2[23] = 103;
							num3 = 8;
							break;
						case 136:
							num6 = 92 + 110;
							num3 = 9;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 0;
							}
							break;
						case 8:
							array2[23] = 127;
							num3 = 171;
							break;
						case 91:
							array2[9] = (byte)num6;
							num3 = 211;
							break;
						case 24:
							array2[26] = (byte)num6;
							num3 = 71;
							break;
						case 216:
							array2[23] = (byte)num7;
							num3 = 100;
							break;
						case 85:
							num7 = 243 - 81;
							num3 = 202;
							break;
						case 6:
							array2[6] = (byte)num6;
							num3 = 224;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 130;
							}
							break;
						case 11:
							array2[17] = 247;
							num3 = 205;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 74;
							}
							break;
						case 42:
							num6 = 16 + 3;
							num3 = 196;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 213;
							}
							break;
						case 26:
							array2[0] = 184;
							num3 = 43;
							break;
						case 125:
							array2[16] = (byte)num7;
							num3 = 148;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 176;
							}
							break;
						case 22:
							array2[20] = (byte)num6;
							num3 = 23;
							break;
						case 179:
							num7 = 143 + 30;
							num3 = 57;
							break;
						case 2:
							num6 = 129 - 43;
							num3 = 218;
							break;
						case 128:
							num6 = 130 - 58;
							num5 = 107;
							goto IL_0074;
						case 116:
							array2[31] = 51;
							num3 = 180;
							break;
						case 163:
							num7 = 233 - 77;
							num5 = 131;
							goto IL_0074;
						case 182:
							array2[16] = 181;
							num3 = 25;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 20;
							}
							break;
						case 215:
							num6 = 33 + 33;
							num3 = 10;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 60;
							}
							break;
						case 47:
							array2[26] = 130;
							num3 = 112;
							break;
						case 177:
							num6 = 185 - 61;
							num3 = 162;
							break;
						case 156:
							num7 = 167 - 55;
							num3 = 59;
							break;
						case 231:
							num7 = 186 - 62;
							num3 = 230;
							break;
						case 77:
							array2[16] = 120;
							num3 = 37;
							break;
						case 170:
							array2[6] = 127;
							num3 = 168;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 94;
							}
							break;
						case 7:
							array2[12] = 100;
							num3 = 208;
							break;
						case 27:
							array2[25] = 141;
							num3 = 79;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 34;
							}
							break;
						case 119:
							array2[11] = (byte)num6;
							num3 = 225;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 139;
							}
							break;
						case 117:
							num7 = 14 - 11;
							num3 = 191;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 58;
							}
							break;
						case 36:
							array2[16] = (byte)num7;
							num3 = 2;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 2;
							}
							break;
						case 64:
							num6 = 77 + 64;
							num3 = 32;
							if (rqDaSCIfBibcCJvS3cF() == null)
							{
								num3 = 165;
							}
							break;
						case 63:
							array2[18] = 112;
							num3 = 62;
							break;
						case 104:
							array2[8] = (byte)num7;
							num3 = 69;
							break;
						case 88:
							num6 = 117 + 80;
							num3 = 61;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 24;
							}
							break;
						case 200:
							num6 = 20 + 73;
							num3 = 33;
							break;
						case 100:
							array2[24] = 169;
							num3 = 114;
							break;
						case 20:
							array2[12] = 99;
							num3 = 124;
							break;
						case 92:
							array2[7] = (byte)num6;
							num3 = 21;
							break;
						case 171:
							num7 = 86 - 25;
							num3 = 216;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 24;
							}
							break;
						case 204:
							array2[23] = 168;
							num3 = 66;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 214;
							}
							break;
						case 56:
							array5 = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
							num3 = 222;
							break;
						case 127:
							array2[3] = (byte)num6;
							num3 = 103;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 217;
							}
							break;
						case 149:
							num6 = 159 - 53;
							num5 = 233;
							goto IL_0074;
						case 90:
							array2[0] = 109;
							num3 = 26;
							break;
						case 50:
							array2[10] = (byte)num6;
							num5 = 181;
							goto IL_0074;
						case 35:
							array2[17] = 90;
							num3 = 58;
							break;
						case 135:
							array2[9] = (byte)num7;
							num3 = 108;
							break;
						case 199:
							array2[25] = (byte)num6;
							num3 = 169;
							break;
						case 84:
							array2[24] = 130;
							num3 = 189;
							if (!caC120Il6QhJUxYlgMd())
							{
								num3 = 91;
							}
							break;
						case 98:
							array2[11] = (byte)num7;
							num5 = 86;
							goto IL_0074;
						case 213:
							array2[15] = (byte)num6;
							num3 = 179;
							break;
						case 181:
							num7 = 88 + 62;
							num3 = 45;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 82;
							}
							break;
						case 190:
							array2[4] = 150;
							num3 = 73;
							break;
						case 112:
							num6 = 111 + 107;
							num3 = 24;
							break;
						case 71:
							array2[27] = 138;
							num5 = 93;
							goto IL_0074;
						case 118:
							num7 = 236 - 78;
							num3 = 159;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 75;
							}
							break;
						case 222:
							array2 = new byte[32];
							num3 = 67;
							break;
						case 61:
							array2[21] = (byte)num6;
							num5 = 45;
							goto IL_0074;
						case 83:
							array2[2] = (byte)num7;
							num3 = 40;
							break;
						case 38:
							array2[22] = 84;
							num3 = 34;
							break;
						case 192:
							array2[19] = (byte)num7;
							num3 = 157;
							break;
						case 137:
							array2[6] = 62;
							num3 = 170;
							break;
						case 13:
							num6 = 157 - 52;
							num3 = 119;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 112;
							}
							break;
						case 99:
							array2[31] = 112;
							num3 = 113;
							break;
						case 97:
							num7 = 236 - 78;
							num3 = 141;
							if (caC120Il6QhJUxYlgMd())
							{
								num3 = 150;
							}
							break;
						case 196:
							array2[0] = 84;
							num3 = 90;
							break;
						case 122:
							num7 = 129 - 79;
							num5 = 154;
							goto IL_0074;
						case 147:
							array2[1] = (byte)num6;
							num3 = 128;
							break;
						case 9:
							array2[8] = (byte)num6;
							num3 = 149;
							break;
						case 3:
							array2[30] = 181;
							num3 = 148;
							break;
						case 189:
							array2[24] = 103;
							num3 = 48;
							break;
						case 172:
							array2[25] = (byte)num6;
							num3 = 111;
							if (rqDaSCIfBibcCJvS3cF() != null)
							{
								num3 = 39;
							}
							break;
						case 39:
							array2[21] = (byte)num7;
							num3 = 38;
							break;
						case 113:
							array2[31] = 143;
							num3 = 75;
							break;
						case 180:
							{
								byte[] array = array2;
								byte[] array3 = new byte[16];
								int num4 = 179 - 59;
								array3[0] = (byte)num4;
								array3[0] = 169;
								array3[0] = 90;
								array3[0] = 167;
								array3[1] = 163;
								array3[1] = 98;
								num4 = 60 + 39;
								array3[1] = (byte)num4;
								array3[1] = 23;
								num4 = 196 - 65;
								array3[2] = (byte)num4;
								array3[2] = 96;
								array3[2] = 109;
								num4 = 215 - 71;
								array3[2] = (byte)num4;
								array3[2] = 74;
								array3[2] = 121;
								array3[3] = 90;
								num4 = 101 + 83;
								array3[3] = (byte)num4;
								array3[3] = 108;
								num4 = 131 - 111;
								array3[3] = (byte)num4;
								array3[4] = 110;
								array3[4] = 210;
								array3[4] = 130;
								num4 = 139 + 99;
								array3[4] = (byte)num4;
								array3[5] = 140;
								num4 = 62 + 123;
								array3[5] = (byte)num4;
								array3[5] = 154;
								array3[6] = 148;
								num4 = 167 - 55;
								array3[6] = (byte)num4;
								array3[6] = 157;
								array3[6] = 120;
								num4 = 6 + 27;
								array3[6] = (byte)num4;
								array3[6] = 131;
								num4 = 60 + 39;
								array3[7] = (byte)num4;
								num4 = 209 - 69;
								array3[7] = (byte)num4;
								array3[7] = 151;
								array3[7] = 149;
								num4 = 97 + 98;
								array3[7] = (byte)num4;
								num4 = 203 + 44;
								array3[7] = (byte)num4;
								num4 = 110 + 103;
								array3[8] = (byte)num4;
								array3[8] = 221;
								num4 = 10 + 11;
								array3[8] = (byte)num4;
								num4 = 62 + 90;
								array3[8] = (byte)num4;
								num4 = 91 - 9;
								array3[8] = (byte)num4;
								num4 = 225 - 75;
								array3[9] = (byte)num4;
								array3[9] = 168;
								num4 = 77 + 26;
								array3[9] = (byte)num4;
								array3[9] = 149;
								num4 = 148 + 14;
								array3[9] = (byte)num4;
								num4 = 98 + 100;
								array3[10] = (byte)num4;
								num4 = 38 + 60;
								array3[10] = (byte)num4;
								num4 = 187 - 62;
								array3[10] = (byte)num4;
								array3[10] = 120;
								num4 = 243 - 81;
								array3[10] = (byte)num4;
								array3[10] = 14;
								num4 = 18 + 89;
								array3[11] = (byte)num4;
								num4 = 237 - 79;
								array3[11] = (byte)num4;
								array3[11] = 56;
								num4 = 20 + 31;
								array3[11] = (byte)num4;
								num4 = 156 - 69;
								array3[11] = (byte)num4;
								array3[12] = 108;
								array3[12] = 94;
								num4 = 87 + 121;
								array3[12] = (byte)num4;
								num4 = 23 + 83;
								array3[12] = (byte)num4;
								num4 = 238 - 119;
								array3[12] = (byte)num4;
								array3[13] = 198;
								array3[13] = 92;
								num4 = 135 - 45;
								array3[13] = (byte)num4;
								num4 = 76 + 114;
								array3[13] = (byte)num4;
								array3[13] = 73;
								num4 = 233 - 77;
								array3[14] = (byte)num4;
								num4 = 244 - 81;
								array3[14] = (byte)num4;
								array3[14] = 116;
								array3[14] = 26;
								array3[15] = 109;
								num4 = 152 - 50;
								array3[15] = (byte)num4;
								array3[15] = 129;
								array3[15] = 138;
								num4 = 141 + 108;
								array3[15] = (byte)num4;
								byte[] array4 = array3;
								if (oha472keF2.EntryPoint == null)
								{
									msn4lmUXtF = 80;
								}
								Gdm4SanfKy = new jiUnG6yLcp99YsGsEb2(array, array4).l084oTo8hr(array5);
								num5 = 130;
								goto IL_0074;
							}
							IL_0074:
							num3 = num5;
							break;
						}
					}
				}
				finally
				{
					int num8;
					if (binaryReader == null)
					{
						num8 = 0;
						if (rqDaSCIfBibcCJvS3cF() != null)
						{
							num8 = 0;
						}
						goto IL_298d;
					}
					goto IL_29b6;
					IL_298d:
					switch (num8)
					{
					default:
						goto end_IL_2968;
					case 0:
						goto end_IL_2968;
					case 2:
						break;
					case 1:
						goto end_IL_2968;
					}
					goto IL_29b6;
					IL_29b6:
					((IDisposable)binaryReader).Dispose();
					num8 = 1;
					if (!caC120Il6QhJUxYlgMd())
					{
						num8 = 0;
					}
					goto IL_298d;
					end_IL_2968:;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string xDx43IEi2K(int P_0)
		{
			if (Gdm4SanfKy.Length == 0)
			{
				vCj4wZmgDD = new List<string>();
				WRI4ccsCBF = new List<int>();
				Oam4On22qR(typeof(jiUnG6yLcp99YsGsEb2).GetTypeInfo().Assembly.GetManifestResourceStream("e76hfvnUuLT8Tw03QQ.w56xu2OeVGRUMquo4r"));
				wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			}
			if (msn4lmUXtF < 75)
			{
				MethodBase method = new StackFrame(1).GetMethod();
				if (oha472keF2 != method.DeclaringType.Assembly)
				{
					bool flag = false;
					string name = method.DeclaringType.Assembly.GetName().Name;
					AssemblyName[] referencedAssemblies = oha472keF2.GetReferencedAssemblies();
					foreach (AssemblyName assemblyName in referencedAssemblies)
					{
						if (name == assemblyName.Name)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						throw new Exception();
					}
				}
				msn4lmUXtF++;
			}
			lock (vUF4GwaqoN)
			{
				int num = BitConverter.ToInt32(Gdm4SanfKy, P_0);
				if (num < WRI4ccsCBF.Count && WRI4ccsCBF[num] == P_0)
				{
					return vCj4wZmgDD[num];
				}
				try
				{
					byte[] array = new byte[num];
					Array.Copy(Gdm4SanfKy, P_0 + 4, array, 0, num);
					string text = Encoding.Unicode.GetString(array, 0, array.Length);
					vCj4wZmgDD.Add(text);
					WRI4ccsCBF.Add(P_0);
					Array.Copy(BitConverter.GetBytes(vCj4wZmgDD.Count - 1), 0, Gdm4SanfKy, P_0, 4);
					return text;
				}
				catch
				{
				}
			}
			return "";
		}

		private jiUnG6yLcp99YsGsEb2(byte[] P_0, byte[] P_1)
		{
			DSu4fCCDmU = P_0;
			wb04W1bZ4f = P_1;
		}

		private byte[] l084oTo8hr(byte[] P_0)
		{
			if (P_0.Length == 0)
			{
				return new byte[0];
			}
			int num = P_0.Length % 4;
			int num2 = P_0.Length / 4;
			byte[] array = new byte[P_0.Length];
			int num3 = DSu4fCCDmU.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int i = 0; i < num2; i++)
			{
				int num8 = i % num3;
				int num9 = i * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((DSu4fCCDmU[num7 + 3] << 24) | (DSu4fCCDmU[num7 + 2] << 16) | (DSu4fCCDmU[num7 + 1] << 8) | DSu4fCCDmU[num7]);
				if (i == num2 - 1 && num > 0)
				{
					num6 = 0u;
					uint num10 = 255u;
					int num11 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j > 0)
						{
							num6 <<= 8;
						}
						num6 |= P_0[^(1 + j)];
					}
					num4 += num5;
					num4 += iww4yX1iDE(num4);
					uint num12 = num4 ^ num6;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array[num9 + k] = (byte)((num12 & num10) >> num11);
					}
				}
				else
				{
					num7 = (uint)num9;
					num6 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
					num4 += num5;
					num4 += iww4yX1iDE(num4);
					uint num13 = num4 ^ num6;
					array[num9] = (byte)(num13 & 0xFF);
					array[num9 + 1] = (byte)((num13 & 0xFF00) >> 8);
					array[num9 + 2] = (byte)((num13 & 0xFF0000) >> 16);
					array[num9 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
				}
			}
			return array;
		}

		private uint iww4yX1iDE(uint P_0)
		{
			uint num = P_0;
			uint num2 = 973202305u;
			uint num3 = 1582787682u;
			uint num4 = 1577548636u;
			uint num5 = 332884210u;
			ulong num6 = num4 * 1313243236;
			num6 |= 1;
			num3 = (uint)(num3 * num3 % num6);
			ulong num7 = 1907532890 * num4;
			if (num7 == 0L)
			{
				num7--;
			}
			_ = 698203908u % num7;
			num2 = (uint)(-502326134 - num3);
			ulong num8 = num3 * 183835789;
			num8 |= 1;
			num4 = (uint)(num4 * num4 % num8);
			uint num9 = ((num5 >> 6) | (num5 << 26)) ^ num3;
			uint num10 = num9 & 0xF0F0F0F;
			num5 = ((num9 & 0xF0F0F0F0u) >> 4) | (num10 << 4);
			num ^= num << 3;
			num += num2;
			num ^= num << 11;
			num += num4;
			num ^= num >> 27;
			num += num5;
			return (((num2 << 11) - num3) ^ num4) - num;
		}

		internal static string X3q440vvPH(object P_0)
		{
			"DDO2VeKYjtoEhzWdIyR3D".Trim();
			byte[] array = Convert.FromBase64String((string)P_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		private static byte[] ljr4IgGid2(object P_0)
		{
			return new jiUnG6yLcp99YsGsEb2(new byte[32]
			{
				123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
				183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
				74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
				211, 43
			}, new byte[16]
			{
				117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
				12, 54, 68, 241, 68, 66
			}).l084oTo8hr((byte[])P_0);
		}

		private byte[] M3R4eKwEuZ()
		{
			return null;
		}

		private byte[] bi94R3DXDe()
		{
			return null;
		}

		internal static bool caC120Il6QhJUxYlgMd()
		{
			return (object)null == null;
		}

		internal static object rqDaSCIfBibcCJvS3cF()
		{
			return null;
		}
	}
}
namespace nIlyhV4jWVgQG2OuA4A
{
	[Obfuscation(Feature = "EZNRMERM", Exclude = false, StripAfterObfuscation = false)]
	internal class bDMRKF4NUpcNsGNrxDL : ResourceManager
	{
		private CultureInfo dAo4dqBKVf;

		private Type sc448akgrX;

		private Hashtable Ww74AYdCXW;

		private static Dictionary<string, Assembly> MRb4mAowJs;

		private static bDMRKF4NUpcNsGNrxDL d9AroqrnW5kTun1EA4G;

		public bDMRKF4NUpcNsGNrxDL(string P_0, Assembly P_1)
		{
			jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
			wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
			Ww74AYdCXW = new Hashtable();
			base..ctor(P_0, P_1);
			int num = 1;
			if (true)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				try
				{
					sc448akgrX = P_1.GetType(P_0);
					int num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
					break;
				}
				catch
				{
					int num3 = 0;
					if (true)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					break;
				}
			}
		}

		static bDMRKF4NUpcNsGNrxDL()
		{
			int num = 10;
			int num2 = num;
			BinaryReader binaryReader = default(BinaryReader);
			Stream manifestResourceStream = default(Stream);
			byte[] array = default(byte[]);
			string text = default(string);
			int num6 = default(int);
			int num4 = default(int);
			string[] manifestResourceNames = default(string[]);
			string key = default(string);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 14:
					return;
				default:
					binaryReader = new BinaryReader(manifestResourceStream);
					num2 = 1;
					if (0 == 0)
					{
						num2 = 7;
					}
					break;
				case 6:
					binaryReader.Read(array, 0, array.Length);
					num2 = 5;
					break;
				case 3:
					manifestResourceStream = typeof(bDMRKF4NUpcNsGNrxDL).Assembly.GetManifestResourceStream(text + num6);
					num2 = 11;
					break;
				case 11:
					num6++;
					num2 = 8;
					if (false)
					{
						num2 = 4;
					}
					break;
				case 9:
					wkPEsAIiNcPGupoYPsG.muhrk6WM7x();
					num2 = 1;
					if (false)
					{
						num2 = 1;
					}
					break;
				case 7:
					binaryReader.BaseStream.Position = 0L;
					num2 = 13;
					break;
				case 1:
					MRb4mAowJs = new Dictionary<string, Assembly>();
					num2 = 1;
					if (0 == 0)
					{
						num2 = 15;
					}
					break;
				case 2:
					num6 = 0;
					num2 = 3;
					if (false)
					{
						num2 = 3;
					}
					break;
				case 10:
					jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
					num2 = 9;
					break;
				case 8:
					if (manifestResourceStream == null)
					{
						return;
					}
					num2 = 0;
					if (false)
					{
						num2 = 0;
					}
					break;
				case 5:
					binaryReader.Close();
					num2 = 12;
					break;
				case 15:
					text = "1b24d7e1-0237";
					num2 = 2;
					if (false)
					{
						num2 = 0;
					}
					break;
				case 12:
					try
					{
						Assembly assembly = Assembly.Load(array);
						int num3 = 0;
						if (0 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
							case 7:
								if (num4 >= manifestResourceNames.Length)
								{
									num3 = 1;
									if (true)
									{
										num3 = 3;
									}
									continue;
								}
								break;
							case 4:
								num4++;
								num3 = 2;
								if (true)
								{
									num3 = 7;
								}
								continue;
							default:
								manifestResourceNames = assembly.GetManifestResourceNames();
								num3 = 1;
								if (1 == 0)
								{
									num3 = 1;
								}
								continue;
							case 1:
								num4 = 0;
								num3 = 2;
								continue;
							case 6:
								MRb4mAowJs[key] = assembly;
								num3 = 2;
								if (0 == 0)
								{
									num3 = 4;
								}
								continue;
							case 5:
								break;
							case 3:
								goto end_IL_01e6;
							}
							key = manifestResourceNames[num4];
							num3 = 6;
							continue;
							end_IL_01e6:
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (1 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 13:
					array = new byte[manifestResourceStream.Length];
					num2 = 6;
					break;
				}
			}
		}

		protected override ResourceSet InternalGetResourceSet(CultureInfo P_0, bool P_1, bool P_2)
		{
			ResourceSet resourceSet = Ww74AYdCXW[P_0] as ResourceSet;
			if (resourceSet == null)
			{
				string text = null;
				if (dAo4dqBKVf == null)
				{
					dAo4dqBKVf = ResourceManager.GetNeutralResourcesLanguage(MainAssembly);
				}
				if (dAo4dqBKVf.Equals(P_0))
				{
					P_0 = CultureInfo.InvariantCulture;
				}
				text = GetResourceFileName(P_0);
				Stream manifestResourceStream = MainAssembly.GetManifestResourceStream(text);
				if (manifestResourceStream == null && sc448akgrX != null)
				{
					manifestResourceStream = MainAssembly.GetManifestResourceStream(sc448akgrX, text);
				}
				if (manifestResourceStream == null)
				{
					Assembly value = null;
					MRb4mAowJs.TryGetValue(text, out value);
					if (value != null)
					{
						manifestResourceStream = value.GetManifestResourceStream(text);
						if (manifestResourceStream == null && sc448akgrX != null)
						{
							manifestResourceStream = value.GetManifestResourceStream(sc448akgrX, text);
						}
					}
				}
				if (manifestResourceStream != null)
				{
					resourceSet = new ResourceSet(manifestResourceStream);
					lock (Ww74AYdCXW)
					{
						if (Ww74AYdCXW[P_0] is ResourceSet resourceSet2)
						{
							if (!object.Equals(resourceSet2, resourceSet))
							{
								resourceSet.Dispose();
								resourceSet = resourceSet2;
							}
						}
						else
						{
							Ww74AYdCXW.Add(P_0, resourceSet);
						}
					}
				}
				else
				{
					resourceSet = base.InternalGetResourceSet(P_0, P_1, P_2);
				}
			}
			return resourceSet;
		}

		internal static bool CYXUgqrO3fB0SPKSaDh()
		{
			return d9AroqrnW5kTun1EA4G == null;
		}

		internal static bDMRKF4NUpcNsGNrxDL ABu4cvr3JFhYuXIWU7h()
		{
			return d9AroqrnW5kTun1EA4G;
		}
	}
}
namespace XwEvHcIp4EuVbeL17WK
{
	internal class wkPEsAIiNcPGupoYPsG
	{
		private static bool ExuI7jy33r;

		private static wkPEsAIiNcPGupoYPsG RQH4furoU2pfYeZJBCR;

		internal static void muhrk6WM7x()
		{
			int num = 4;
			int num2 = num;
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					if (Math.Abs(timeSpan.Days) >= 14)
					{
						num2 = 1;
						if (!OP6T14ryKsOGn3qFCIx())
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 4:
					if (ExuI7jy33r)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				case 5:
					ExuI7jy33r = true;
					num2 = 0;
					if (FiADMkr4soxnbVLNp4H() == null)
					{
						num2 = 0;
					}
					break;
				case 1:
					throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
				default:
					timeSpan = DateTime.Now - new DateTime(2025, 6, 7);
					num2 = 2;
					break;
				}
			}
		}

		internal static bool OP6T14ryKsOGn3qFCIx()
		{
			return RQH4furoU2pfYeZJBCR == null;
		}

		internal static wkPEsAIiNcPGupoYPsG FiADMkr4soxnbVLNp4H()
		{
			return RQH4furoU2pfYeZJBCR;
		}
	}
}
internal sealed class <Module>{345811dc-be8b-4780-b818-4a956593b791}
{
	internal static <Module>{345811dc-be8b-4780-b818-4a956593b791} m_32fa63a2f47c40cabe232e2a88d38b1e;

	internal int 0;

	internal int 0;

	internal int 854369382;

	internal int 0;

	internal int 0;

	internal int 1435992043;

	internal int 1814018247;

	internal int 0;

	internal int 55114885;

	internal int 1668386183;

	internal int 760317395;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 1696499521;

	internal int 374085082;

	internal int 0;

	internal int 696790966;

	internal int 1518457776;

	internal int 1185518701;

	internal int 0;

	internal int 2144623378;

	internal int 117793469;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 121889664;

	internal int 1531368356;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 444950165;

	internal int 0;

	internal int 1187184005;

	internal int 0;

	internal int 0;

	internal int 2058589287;

	internal int 0;

	internal int 2021314568;

	internal int 1414824122;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 1629830925;

	internal int 0;

	internal int 1783996735;

	internal int 1094201023;

	internal int 0;

	internal int 497891482;

	internal int 0;

	internal int 1032184707;

	internal int 1268266038;

	internal int 1433983997;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 1835701918;

	internal int 348513258;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 577280904;

	internal int 460822775;

	internal int 519538535;

	internal int 133732588;

	internal int 0;

	internal int 0;

	internal int 247204215;

	internal int 818312125;

	internal int 0;

	internal int 171921593;

	internal int 1793150317;

	internal int 1848937442;

	internal int 1663994158;

	internal int 1522668693;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 1976142266;

	internal int 0;

	internal int 0;

	internal int 742265667;

	internal int 1890823438;

	internal int 0;

	internal int 1413447416;

	internal int 171252512;

	internal int 1131787544;

	internal int 0;

	internal int 0;

	internal int 317387702;

	internal int 0;

	internal int 468683115;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 11098130;

	internal int 747172065;

	internal int 0;

	internal int 0;

	internal int 10932459;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 1427489184;

	internal int 0;

	internal int 2093262890;

	internal int 0;

	internal int 2048817382;

	internal int 0;

	internal int 0;

	internal int 0;

	internal int 962215133;

	internal int 2035096834;

	internal int 1126510863;

	internal int 1362636878;

	internal int 852228814;

	internal int 0;

	internal int 0;

	internal int 258562808;

	internal int 1256719316;

	internal int 1486210346;

	internal int 1435650279;

	internal static <Module>{345811dc-be8b-4780-b818-4a956593b791} SMiLKkr6nvrtcS0ns2N;

	public <Module>{345811dc-be8b-4780-b818-4a956593b791}()
	{
		jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
		base..ctor();
		int num = 0;
		if (true)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static <Module>{345811dc-be8b-4780-b818-4a956593b791}()
	{
		jiUnG6yLcp99YsGsEb2.I9ayUbHaDB();
		vf16a59d22daf48b5948132761acc67c6();
	}

	internal static void vf16a59d22daf48b5948132761acc67c6()
	{
		int num = 87;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 82:
					0 = 0xC89D00 ^ 0xC89D00;
					num = 20;
					break;
				case 15:
					2058589287 = -1656166688 ^ -402951545;
					num2 = 59;
					continue;
				case 102:
					2093262890 = -234112336 ^ -1899031910;
					num2 = 127;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 112;
					}
					continue;
				case 119:
					0 = (--1595912641 + -320810900) ^ 0x4C00822D;
					num2 = 0;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 3;
					}
					continue;
				case 37:
					0 = 0xE62014 ^ 0xE62014;
					num2 = 1;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 1;
					}
					continue;
				case 20:
					0 = -1938485744 ^ -1938485744;
					num2 = 125;
					continue;
				case 11:
					1362636878 = -(-372951538 - -2054104965) ^ -890007005;
					num2 = 13;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 9;
					}
					continue;
				case 32:
					1663994158 = -1861457835 ^ -232595077;
					num2 = 15;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 115;
					}
					continue;
				case 64:
					0 = -85876558 ^ -85876558;
					num2 = 121;
					continue;
				case 76:
					1783996735 = 0x6CF5CE03 ^ 0x6A06F3C;
					num2 = 112;
					continue;
				default:
					0 = 0x56F72A0E ^ 0x56F72A0E;
					num2 = 104;
					continue;
				case 73:
					0 = -(-450082641) ^ 0x1AD3B751;
					num2 = 7;
					continue;
				case 74:
					1835701918 = 0x28572D60 ^ 0x453DBBFE;
					num2 = 91;
					continue;
				case 107:
					0 = -1111201850 ^ -1111201850;
					num2 = 53;
					continue;
				case 26:
					0 = -165528971 ^ -165528971;
					num2 = 14;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 40;
					}
					continue;
				case 116:
					return;
				case 35:
					0 = 0x7CFA1ACC ^ 0x7CFA1ACC;
					num2 = 62;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 95;
					}
					continue;
				case 39:
					55114885 = 0x34BB1E ^ 0x37C479B;
					num = 116;
					break;
				case 13:
					1414824122 = -705243279 ^ -2120067125;
					num2 = 58;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 50;
					}
					continue;
				case 113:
					460822775 = 0x136BB84A ^ 0x81C20BD;
					num2 = 27;
					continue;
				case 5:
					0 = 0x305FE61 ^ 0x305FE61;
					num2 = 39;
					continue;
				case 41:
					0 = 0x458E95F ^ 0x458E95F;
					num2 = 81;
					continue;
				case 110:
					1531368356 = 0x74AFCA4D ^ 0x2FE919E9;
					num2 = 36;
					continue;
				case 21:
					0 = 0x34BB1E ^ 0x34BB1E;
					num2 = 100;
					continue;
				case 63:
					0 = 0x27375C45 ^ 0x27375C45;
					num2 = 33;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 38;
					}
					continue;
				case 53:
					0 = 0xEE894C5 ^ 0xEE894C5;
					num2 = 111;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 118;
					}
					continue;
				case 44:
					742265667 = -85876558 ^ -689982479;
					num2 = 4;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 3;
					}
					continue;
				case 79:
					1518457776 = -1938485744 ^ -688595552;
					num2 = 17;
					continue;
				case 19:
					133732588 = -1209989269 ^ -1340498041;
					num2 = 68;
					continue;
				case 47:
					0 = -1667808272 ^ -1667808272;
					num = 44;
					break;
				case 123:
					0 = -1488285755 ^ -1488285755;
					num2 = 62;
					continue;
				case 90:
					1268266038 = -(2048234894 << 6) ^ 0x3102A8B6;
					num2 = 7;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 15;
					}
					continue;
				case 17:
					1435992043 = -26252051 ^ -1409805562;
					num2 = 51;
					continue;
				case 108:
					0 = -705243279 ^ -705243279;
					num2 = 105;
					continue;
				case 27:
					1433983997 = 0x28572D60 ^ 0x7D2FF69D;
					num2 = 77;
					continue;
				case 14:
					0 = -223900344 ^ -223900344;
					num = 54;
					break;
				case 118:
					2021314568 = 0x136BB84A ^ 0x6B116842;
					num = 83;
					break;
				case 78:
					0 = 0x625F08E8 ^ 0x625F08E8;
					num = 97;
					break;
				case 100:
					0 = -2076141489 ^ -2076141489;
					num = 89;
					break;
				case 88:
					0 = -(-582461978 << 4) ^ 0x2B7AA1A0;
					num2 = 102;
					continue;
				case 18:
					519538535 = 0x598DD68C ^ 0x477A51EB;
					num2 = 35;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 16;
					}
					continue;
				case 59:
					0 = 0x136BB84A ^ 0x136BB84A;
					num2 = 109;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 73;
					}
					continue;
				case 3:
					0 = -234112336 ^ -234112336;
					num2 = 21;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 20;
					}
					continue;
				case 28:
					0 = -1840442781 ^ -1840442781;
					num2 = 3;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 25;
					}
					continue;
				case 60:
					0 = 0xE74A2A0 ^ 0xE74A2A0;
					num2 = 65;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 57;
					}
					continue;
				case 126:
					0 = 0xBE19BC8 ^ 0xBE19BC8;
					num2 = 53;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 78;
					}
					continue;
				case 89:
					0 = -1092523968 ^ -1092523968;
					num2 = 101;
					continue;
				case 65:
					497891482 = 0x6CF5CE03 ^ 0x7158F699;
					num2 = 94;
					continue;
				case 84:
					0 = -1768734307 ^ -1768734307;
					num2 = 40;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 70;
					}
					continue;
				case 115:
					1256719316 = -223900344 ^ -1202745700;
					num2 = 75;
					continue;
				case 103:
					1413447416 = 0x305FE61 ^ 0x573A8099;
					num2 = 93;
					continue;
				case 85:
					852228814 = 0x148ACE5A ^ 0x26413494;
					num = 41;
					break;
				case 6:
					0 = -1209989269 ^ -1209989269;
					num = 120;
					break;
				case 125:
					0 = 0x34BB1E ^ 0x34BB1E;
					num = 119;
					break;
				case 77:
					0 = 0xEE894C5 ^ 0xEE894C5;
					num2 = 39;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 61;
					}
					continue;
				case 45:
					171921593 = 0x6162E060 ^ 0x6B5DB0D9;
					num2 = 12;
					continue;
				case 49:
					0 = -1656166688 ^ -1656166688;
					num2 = 24;
					continue;
				case 58:
					0 = -(1688843097 - -635645281) ^ 0x75731F46;
					num2 = 18;
					continue;
				case 80:
					0 = 0x5A870900 ^ 0x5A870900;
					num2 = 76;
					continue;
				case 67:
					696790966 = -444812070 ^ -856384660;
					num2 = 1;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 37;
					}
					continue;
				case 46:
					0 = 0xE62014 ^ 0xE62014;
					num2 = 19;
					continue;
				case 98:
					1486210346 = -1092523968 ^ -428561046;
					num2 = 48;
					continue;
				case 29:
					0 = 0x68D9291B ^ 0x68D9291B;
					num2 = 111;
					continue;
				case 52:
					0 = 0x305FE61 ^ 0x305FE61;
					num2 = 12;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 14;
					}
					continue;
				case 97:
					0 = 0x625F08E8 ^ 0x625F08E8;
					num2 = 85;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 55;
					}
					continue;
				case 127:
					1848937442 = 0x134A8421 ^ 0x7D7E0FC3;
					num2 = 22;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 1;
					}
					continue;
				case 99:
					0 = 0x458E95F ^ 0x458E95F;
					num2 = 98;
					continue;
				case 95:
					171252512 = -1861457835 ^ -1690733707;
					num2 = 69;
					continue;
				case 4:
					348513258 = 0xE62014 ^ 0x1423C3FE;
					num2 = 82;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 79;
					}
					continue;
				case 69:
					1435650279 = 0x27A86 ^ 0x55903261;
					num2 = 33;
					continue;
				case 61:
					121889664 = -1853743488 ^ -1765671680;
					num = 123;
					break;
				case 34:
					0 = 0x43D52E8B ^ 0x43D52E8B;
					num2 = 96;
					continue;
				case 96:
					444950165 = -1666643903 ^ -2043908396;
					num2 = 113;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 14;
					}
					continue;
				case 101:
					0 = -(0x23BC829A ^ -1186060208) ^ 0x650D5536;
					num2 = 0;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 0;
					}
					continue;
				case 7:
					0 = 0xDFD7 ^ 0xDFD7;
					num2 = 8;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 9;
					}
					continue;
				case 40:
					0 = 0x305FE61 ^ 0x305FE61;
					num2 = 67;
					continue;
				case 104:
					818312125 = 0x34BB1E ^ 0x30F2C8A3;
					num2 = 122;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 31;
					}
					continue;
				case 81:
					0 = 0x7CFA1ACC ^ 0x7CFA1ACC;
					num2 = 49;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 4;
					}
					continue;
				case 2:
					1187184005 = 0x72D697F5 ^ 0x34146A70;
					num2 = 71;
					continue;
				case 9:
					0 = 0x2DFF0DB0 ^ 0x2DFF0DB0;
					num2 = 99;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 1;
					}
					continue;
				case 38:
					1185518701 = 0x27A86 ^ 0x46ABEEEB;
					num2 = 92;
					continue;
				case 71:
					0 = 0x43D52E8B ^ 0x43D52E8B;
					num2 = 55;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 31;
					}
					continue;
				case 114:
					1131787544 = 0x6FF97EAB ^ 0x2C8CCBB3;
					num = 23;
					break;
				case 51:
					258562808 = 0x305FE61 ^ 0xC6CA499;
					num2 = 124;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 88;
					}
					continue;
				case 8:
					0 = -(1688843097 - -635645281) ^ 0x75731F46;
					num2 = 16;
					continue;
				case 31:
					0 = 0x5D9B1442 ^ 0x5D9B1442;
					num2 = 6;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 6;
					}
					continue;
				case 43:
					1668386183 = -1861457835 ^ -226630190;
					num2 = 29;
					continue;
				case 117:
					468683115 = (--1595912641 + -320810900) ^ 0x57EF0B46;
					num = 64;
					break;
				case 36:
					0 = -124007310 ^ -124007310;
					num2 = 106;
					continue;
				case 83:
					1696499521 = -954408704 ^ -1576901055;
					num2 = 39;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 56;
					}
					continue;
				case 62:
					1522668693 = 0x72D697F5 ^ 0x28148360;
					num2 = 8;
					continue;
				case 55:
					0 = -1524336680 ^ -1524336680;
					num2 = 45;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 10;
					}
					continue;
				case 92:
					0 = -(-582461978 << 4) ^ 0x2B7AA1A0;
					num = 103;
					break;
				case 75:
					0 = 0x6CF5CE03 ^ 0x6CF5CE03;
					num = 66;
					break;
				case 24:
					2048817382 = 0x52EDFF84 ^ 0x28F38762;
					num2 = 52;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 41;
					}
					continue;
				case 109:
					1629830925 = 0x4C096000 ^ 0x2D2C5F0D;
					num2 = 57;
					continue;
				case 91:
					962215133 = 0xCCB7D79 ^ 0x359141A4;
					num2 = 63;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 14;
					}
					continue;
				case 12:
					760317395 = (-159078270 - -1268744774) ^ 0x6F75AF1B;
					num2 = 117;
					continue;
				case 25:
					0 = -1146922077 ^ -1146922077;
					num2 = 73;
					continue;
				case 57:
					577280904 = 0xE74A2A0 ^ 0x2C1C3928;
					num2 = 32;
					continue;
				case 16:
					1890823438 = -223900344 ^ -2112610234;
					num2 = 10;
					continue;
				case 122:
					317387702 = -1273049600 ^ -1493942858;
					num2 = 14;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 72;
					}
					continue;
				case 111:
					1032184707 = -1666643903 ^ -1590891582;
					num2 = 5;
					continue;
				case 121:
					0 = -385607243 ^ -385607243;
					num2 = 9;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 80;
					}
					continue;
				case 86:
					0 = 0x52EDFF84 ^ 0x52EDFF84;
					num2 = 84;
					continue;
				case 70:
					1814018247 = 0x5D9B1442 ^ 0x3184AC85;
					num2 = 74;
					continue;
				case 30:
					117793469 = 0x458E95F ^ 0x35D8BE2;
					num2 = 109;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 126;
					}
					continue;
				case 66:
					1427489184 = -1666643903 ^ -910374431;
					num2 = 50;
					continue;
				case 106:
					854369382 = ~(--706686835) ^ -418614038;
					num2 = 2;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 1;
					}
					continue;
				case 42:
					247204215 = -(-372951538 - -2054104965) ^ -1787319526;
					num = 46;
					break;
				case 68:
					747172065 = -1768734307 ^ -1172590212;
					num2 = 26;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 28;
					}
					continue;
				case 87:
					m_32fa63a2f47c40cabe232e2a88d38b1e = new <Module>{345811dc-be8b-4780-b818-4a956593b791}();
					num2 = 86;
					continue;
				case 22:
					0 = 0x74AFCA4D ^ 0x74AFCA4D;
					num2 = 35;
					if (JdEG7YruCNFryg4fxDq())
					{
						num2 = 42;
					}
					continue;
				case 33:
					1976142266 = -1938485744 ^ -105085014;
					num2 = 12;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 26;
					}
					continue;
				case 54:
					2144623378 = --1270302303 ^ 0x34631D4D;
					num2 = 26;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 31;
					}
					continue;
				case 48:
					374085082 = -1853743488 ^ -2016539814;
					num2 = 10;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 11;
					}
					continue;
				case 1:
					0 = -954408704 ^ -954408704;
					num2 = 26;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 47;
					}
					continue;
				case 50:
					0 = -36849249 ^ -36849249;
					num2 = 114;
					continue;
				case 56:
					11098130 = -1861457835 ^ -1851445177;
					num2 = 110;
					continue;
				case 105:
					1094201023 = -1853743488 ^ -793104321;
					num2 = 79;
					continue;
				case 10:
					10932459 = -165528971 ^ -159061346;
					num2 = 60;
					continue;
				case 112:
					2035096834 = -1768734307 ^ -270639969;
					num2 = 108;
					continue;
				case 94:
					0 = (-140436825 - 1022786444) ^ -1163223269;
					num2 = 26;
					if (maaKa0rsYhqe0JmjnNn() == null)
					{
						num2 = 43;
					}
					continue;
				case 72:
					0 = 0x22635EBD ^ 0x22635EBD;
					num2 = 30;
					continue;
				case 93:
					1126510863 = -234112336 ^ -1322349633;
					num2 = 107;
					if (maaKa0rsYhqe0JmjnNn() != null)
					{
						num2 = 65;
					}
					continue;
				case 120:
					0 = 0x2589C3 ^ 0x2589C3;
					num = 34;
					break;
				case 23:
					1793150317 = 0x56F72A0E ^ 0x3C166763;
					num2 = 88;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 10;
					}
					continue;
				case 124:
					0 = 0x10B9DC56 ^ 0x10B9DC56;
					num2 = 90;
					if (!JdEG7YruCNFryg4fxDq())
					{
						num2 = 29;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool JdEG7YruCNFryg4fxDq()
	{
		return SMiLKkr6nvrtcS0ns2N == null;
	}

	internal static <Module>{345811dc-be8b-4780-b818-4a956593b791} maaKa0rsYhqe0JmjnNn()
	{
		return SMiLKkr6nvrtcS0ns2N;
	}
}
