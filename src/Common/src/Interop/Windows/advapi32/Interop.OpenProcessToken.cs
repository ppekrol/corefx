// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using Custom.Raven.Microsoft.Win32.SafeHandles;

namespace Custom.Raven.Interoperability
{
    internal partial class Interop
    {
        internal partial class Advapi32
        {
            [DllImport(Interop.Libraries.Advapi32, CharSet = CharSet.Unicode, SetLastError = true)]
            internal static extern bool OpenProcessToken(SafeProcessHandle ProcessHandle, int DesiredAccess,
                out SafeTokenHandle TokenHandle);
        }
    }
}
