﻿using Microsoft.VisualC;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#pragma warning disable CS0618 // 'MiscellaneousBitsAttribute' is obsolete: 'Microsoft.VisualC.dll is an obsolete assembly and exists only for backwards compatibility.'
[MiscellaneousBits(65)]
#pragma warning restore CS0618 // 'MiscellaneousBitsAttribute' is obsolete: 'Microsoft.VisualC.dll is an obsolete assembly and exists only for backwards compatibility.'
[NativeCppClass]
#pragma warning disable CS0618 // 'DebugInfoInPDBAttribute' is obsolete: 'Microsoft.VisualC.dll is an obsolete assembly and exists only for backwards compatibility.'
[DebugInfoInPDB]
#pragma warning restore CS0618 // 'DebugInfoInPDBAttribute' is obsolete: 'Microsoft.VisualC.dll is an obsolete assembly and exists only for backwards compatibility.'
[StructLayout(LayoutKind.Sequential, Size = 68)]
public struct DummyGrannyTransform
{
}