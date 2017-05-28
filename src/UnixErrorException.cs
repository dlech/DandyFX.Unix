// Copyright (c) 2017 David Lechner <david@lechnology.com>
// 
// This software is released under the MIT License.
// https://opensource.org/licenses/MIT

using System;

using static DandyFX.Unix.Stdlib;

namespace DandyFX.Unix
{
    /// <summary>
    /// Exception that encapsulates a system error code
    /// </summary>
    public class UnixErrorException : Exception
    {
        /// <summary>
        /// Gets the error code.
        /// </summary>
        public Errno Code { get; private set; }

        /// <summary>
        /// Gets the message associated with the error code.
        /// </summary>
        public override string Message => LazyMessage.Value;
        Lazy<string> LazyMessage;

        /// <summary>
        /// Create a new UnixErrorException with the give error code.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        public UnixErrorException(int code)
        {
            Code = (Errno)code;
            LazyMessage = new Lazy<string> (() => Strerror(code));
        }
    }
}
