//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using System.Runtime.InteropServices;

namespace System
{
    /// <summary>
    /// Represents a field using an internal metadata token.
    /// </summary>
    [Serializable]
    public struct RuntimeFieldHandle
    {
        internal UIntPtr size__;
        [NativeValue("const void*", SymbolName = "const void*")]
        internal global::@void field__;
    }
}
