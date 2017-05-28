// Copyright (c) 2017 David Lechner <david@lechnology.com>
// 
// This software is released under the MIT License.
// https://opensource.org/licenses/MIT

using System;
using System.Runtime.InteropServices;

namespace DandyFX.Unix
{
    /// <summary>
    /// Standard C library function wrappers
    /// </summary>
    public static partial class Stdlib
    {
        static object strerrorLock = new object();

        [DllImport(LibraryName, SetLastError = true)]
        static extern IntPtr strerror(int errnum);

        /// <summary>
        /// Return string describing error number
        /// </summary>
        public static string Strerror(int errnum)
        {
            // TODO: could use strerror_t instead to be thread-safe
            lock (strerrorLock) {
                var ptr = strerror(errnum);
                // TODO: is it possible to have other text encodings?
                // this should work for ASCII
                return Marshal.PtrToStringAnsi(ptr);
            }
        }
    }

    /// <summary>
    /// A device ID.
    /// </summary>
    public struct DeviceID
    {
        UIntPtr value;

        /// <summary>
        /// Major number identifying the class of device
        /// </summary>
        public uint Major => gnu_dev_major(value);

        /// <summary>
        /// Minor number identifying the specific instance
        /// </summary>
        public uint Minor => gnu_dev_minor(value);


        /// <summary>
        /// Create a new device ID.
        /// </summary>
        public DeviceID(uint major, uint minor)
        {
            value = gnu_dev_makedev(major, minor);
        }

        [DllImport(Stdlib.LibraryName)]
        static extern UIntPtr gnu_dev_makedev(uint major, uint minor);

        [DllImport(Stdlib.LibraryName)]
        static extern uint gnu_dev_major(UIntPtr dev);

        [DllImport(Stdlib.LibraryName)]
        static extern uint gnu_dev_minor(UIntPtr dev);
    }
}
