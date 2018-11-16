// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Custom.Raven.Interoperability
{
    internal partial class Interop
    {
        internal partial class Kernel32
        {
            [DllImport(Interop.Libraries.Kernel32, SetLastError = true)]
            internal static extern bool CreatePipe(out SafeFileHandle hReadPipe, out SafeFileHandle hWritePipe,
                ref Interop.Kernel32.SECURITY_ATTRIBUTES lpPipeAttributes, int nSize);
        }
    }
}
