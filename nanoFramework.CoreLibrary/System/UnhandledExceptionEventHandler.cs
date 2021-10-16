using System;

#if (NANOCLR_APPDOMAINS)
namespace System
{
    /// <summary>
    /// Delegate to handle AppDomain.UnhandledException event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    [Serializable]
    public delegate void UnhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e);
}
#endif