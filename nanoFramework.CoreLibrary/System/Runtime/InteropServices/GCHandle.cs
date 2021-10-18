using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
    [NativeType("intptr_t", SymbolName = "intptr_t")]
    public class GCHandle
    {
        public Object Target
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
            [MethodImpl(MethodImplOptions.InternalCall)]
            set;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern void Free();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern IntPtr AddrOfPinnedObject();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static GCHandle Alloc(Object value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern static GCHandle Alloc(Object value, GCHandleType type);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern override bool Equals(object obj);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern override int GetHashCode();
    }
}
