//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace System
{
    /// <summary>
    /// Accessor for console streams
    /// </summary>
    public static class Console
    {
        /// <summary>
        /// Put string onto output stream, without new line in the end
        /// </summary>
        /// <param name="value"></param>
        public static void Write(string value) => Diagnostics.Debug.WriteLineNative(value, false);

        /// <summary>
        /// Put string onto output stream, with new line in the end
        /// </summary>
        /// <param name="value"></param>
        public static void WriteLine(string value) => Diagnostics.Debug.WriteLineNative(value, true);
    }
}
