// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace Custom.Raven.Interoperability
{
    internal partial class Interop
    {
        internal partial class Kernel32
        {
            [DllImport(Interop.Libraries.Kernel32, CharSet = CharSet.Unicode, SetLastError = true,
                EntryPoint = "K32EnumProcesses")]
            internal static extern bool EnumProcesses(int[] processIds, int size, out int needed);
        }
    }
}
