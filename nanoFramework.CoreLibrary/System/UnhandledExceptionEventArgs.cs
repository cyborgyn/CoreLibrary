using System;

#if (NANOCLR_APPDOMAINS)
namespace System
{
    /// <summary>
    /// Arguments of the unhandled exception handler
    /// </summary>
    [Serializable]
    public class UnhandledExceptionEventArgs : EventArgs
    {
        private object exception__;
        private bool isTerminating__;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="exception">The thrown exception to handle</param>
        /// <param name="isTerminating">Flag if application is terminating</param>
        public UnhandledExceptionEventArgs(object exception, bool isTerminating) : base()
        {
            this.exception__ = exception;
            this.isTerminating__ = isTerminating;
        }

        /// <summary>
        /// Returns the Exception object
        /// </summary>
        public object ExceptionObject
        {
            get
            {
                return this.exception__;
            }
        }

        /// <summary>
        /// Flag if application is terminating
        /// </summary>
        public bool IsTerminating
        {
            get
            {
                return this.isTerminating__;
            }
        }
    }
}
#endif