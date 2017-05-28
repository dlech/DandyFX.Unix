// Copyright (c) 2017 David Lechner <david@lechnology.com>
// 
// This software is released under the MIT License.
// https://opensource.org/licenses/MIT

using System;
using System.Runtime.InteropServices;

using nfds_t = System.UIntPtr;

namespace DandyFX.Unix
{
    /// <summary>
    /// Encapsulates a file descriptor for use with <see cref="Syscall.Poll" />.
    /// </summary>
    public struct PollFD
    {
        /// <summary>
        /// File descriptor
        /// </summary>
        public int Fd;

        /// <summary>
        /// Requested events
        /// </summary>
        public PollEvents Events;

        /// <summary>
        /// Returned events
        /// </summary>
        public PollEvents REvents;
    }

    /// <summary>
    /// Unix system call function wrappers.
    /// </summary>
    public static partial class Syscall
    {
        [DllImport(LibraryName, SetLastError = true)]
        static extern int poll([In, Out]PollFD[] fds, nfds_t nfds, int timeout);

        /// <summary>
        /// Wait for some event on a file descriptor.
        /// </summary>
        /// <param name="fds">
        /// The set of file descriptors to be monitored.
        /// </param>
        /// <param name="timeout">
        /// The number of milliseconds that poll() should block waiting for a file descriptor to  become ready.
        /// </param>
        /// <returns>
        /// The number of structures which have nonzero revents fields.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="fds" /> is <c>null</c>
        /// </exception>
        /// <exception cref="UnixErrorException">
        /// Thrown if there was an error
        /// </exception>
        public static int Poll(PollFD[] fds, int timeout = -1)
        {
            if (fds == null) {
                throw new ArgumentNullException(nameof(fds));
            }
            var ret = poll(fds, (nfds_t)fds.Length, timeout);
            if (ret == -1) {
                throw new UnixErrorException(Marshal.GetLastWin32Error());
            }
            return ret;
        }
    }
}
