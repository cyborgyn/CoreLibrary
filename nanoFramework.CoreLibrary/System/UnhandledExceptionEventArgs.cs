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
        private object _Exception;
        private bool _IsTerminating;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="exception">The thrown exception to handle</param>
        /// <param name="isTerminating">Flag if application is terminating</param>
        public UnhandledExceptionEventArgs(object exception, bool isTerminating) : base()
        {
            this._Exception = exception;
            this._IsTerminating = isTerminating;
        }

        /// <summary>
        /// Returns the Exception object
        /// </summary>
        public object ExceptionObject
        {
            get
            {
                return this._Exception;
            }
        }

        /// <summary>
        /// Flag if application is terminating
        /// </summary>
        public bool IsTerminating
        {
            get
            {
                return this._IsTerminating;
            }
        }
    }
}
#endif