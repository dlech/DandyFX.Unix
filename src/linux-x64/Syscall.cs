// This file is generated. Do not edit directly.

using System;

namespace DandyFX.Unix
{
    public static partial class Syscall
    {
        const string LibraryName = "libc.so.6";
    }
    
    /// <summary>
    /// The bits that may be set/returned in <see cref="PollFD.Events" /> and <see cref="PollFD.REvents" />
    /// </summary>
    [Flags]
    public enum PollEvents : short
    {
        /// <summary>
        /// There is data to read.
        /// </summary>
        POLLIN = 0x0001,
        
        /// <summary>
        /// There is urgent data to read.
        /// </summary>
        POLLPRI = 0x0002,
        
        /// <summary>
        /// Writing is now possible.
        /// </summary>
        POLLOUT = 0x0004,
        
        /// <summary>
        /// Error condition (only returned in revents; ignored in events).
        /// </summary>
        POLLERR = 0x0008,
        
        /// <summary>
        /// Hang up (only returned in revents; ignored in events).
        /// </summary>
        POLLHUP = 0x0010,
        
        /// <summary>
        /// Invalid request: fd not open (only returned in revents; ignored in events).
        /// </summary>
        POLLNVAL = 0x0020,
    }
}
