// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace Custom.Raven.Interoperability
{
    internal partial class Interop
    {
        internal partial class User32
        {
            [DllImport(Interop.Libraries.User32, ExactSpelling = true)]
            public static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);

            [DllImport(Interop.Libraries.User32, ExactSpelling = true)]
            public static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);
        }
    }
}
