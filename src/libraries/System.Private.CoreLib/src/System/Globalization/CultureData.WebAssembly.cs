// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Globalization
{
    internal sealed partial class CultureData
    {
        private static void JSEnumCultures()
        {
            Interop.Globalization.GetLocalesJS();
        }
    }
}
