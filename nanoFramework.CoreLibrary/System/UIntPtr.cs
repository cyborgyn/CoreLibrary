//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

using System.Runtime.InteropServices;

namespace System
{
    /// <summary>
    /// A platform-specific type that is used to represent a pointer or a handle.
    /// </summary>
    [NativeType("uintptr_t")]
    [Serializable]
    [ComponentModel.EditorBrowsableAttribute(ComponentModel.EditorBrowsableState.Never)]
    public struct UIntPtr
    {
    }
}
