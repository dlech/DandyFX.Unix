// This file is generated. Do not edit directly.

using System;

namespace DandyFX.Unix
{
    public static partial class Stdlib
    {
        internal const string LibraryName = "libc.so.6";
    }
    
    /// <summary>
    /// List of the error names that are defined on Linux
    /// </summary>
    public enum Errno
    {
        /// <summary>
        /// Argument list too long
        /// </summary>
        E2BIG = 7,
        
        /// <summary>
        /// Permission denied
        /// </summary>
        EACCES = 13,
        
        /// <summary>
        /// Address already in use
        /// </summary>
        EADDRINUSE = 98,
        
        /// <summary>
        /// Address not available
        /// </summary>
        EADDRNOTAVAIL = 99,
        
        /// <summary>
        /// Address family not supported
        /// </summary>
        EAFNOSUPPORT = 97,
        
        /// <summary>
        /// Resource temporarily unavailable (may be the same value as EWOULDBLOCK)
        /// </summary>
        EAGAIN = 11,
        
        /// <summary>
        /// Connection already in progress
        /// </summary>
        EALREADY = 114,
        
        /// <summary>
        /// Invalid exchange
        /// </summary>
        EBADE = 52,
        
        /// <summary>
        /// Bad file descriptor
        /// </summary>
        EBADF = 9,
        
        /// <summary>
        /// File descriptor in bad state
        /// </summary>
        EBADFD = 77,
        
        /// <summary>
        /// Bad message
        /// </summary>
        EBADMSG = 74,
        
        /// <summary>
        /// Invalid request descriptor
        /// </summary>
        EBADR = 53,
        
        /// <summary>
        /// Invalid request code
        /// </summary>
        EBADRQC = 56,
        
        /// <summary>
        /// Invalid slot
        /// </summary>
        EBADSLT = 57,
        
        /// <summary>
        /// Device or resource busy
        /// </summary>
        EBUSY = 16,
        
        /// <summary>
        /// Operation canceled
        /// </summary>
        ECANCELED = 125,
        
        /// <summary>
        /// No child processes
        /// </summary>
        ECHILD = 10,
        
        /// <summary>
        /// Channel number out of range
        /// </summary>
        ECHRNG = 44,
        
        /// <summary>
        /// Communication error on send
        /// </summary>
        ECOMM = 70,
        
        /// <summary>
        /// Connection aborted
        /// </summary>
        ECONNABORTED = 103,
        
        /// <summary>
        /// Connection refused
        /// </summary>
        ECONNREFUSED = 111,
        
        /// <summary>
        /// Connection reset
        /// </summary>
        ECONNRESET = 104,
        
        /// <summary>
        /// Resource deadlock avoided
        /// </summary>
        EDEADLK = 35,
        
        /// <summary>
        /// Synonym for EDEADLK
        /// </summary>
        EDEADLOCK = 35,
        
        /// <summary>
        /// Destination address required
        /// </summary>
        EDESTADDRREQ = 89,
        
        /// <summary>
        /// Mathematics argument out of domain of function
        /// </summary>
        EDOM = 33,
        
        /// <summary>
        /// Disk quota exceeded
        /// </summary>
        EDQUOT = 122,
        
        /// <summary>
        /// File exists
        /// </summary>
        EEXIST = 17,
        
        /// <summary>
        /// Bad address
        /// </summary>
        EFAULT = 14,
        
        /// <summary>
        /// File too large
        /// </summary>
        EFBIG = 27,
        
        /// <summary>
        /// Host is down
        /// </summary>
        EHOSTDOWN = 112,
        
        /// <summary>
        /// Host is unreachable
        /// </summary>
        EHOSTUNREACH = 113,
        
        /// <summary>
        /// Identifier removed
        /// </summary>
        EIDRM = 43,
        
        /// <summary>
        /// Illegal byte sequence
        /// </summary>
        EILSEQ = 84,
        
        /// <summary>
        /// Operation in progress
        /// </summary>
        EINPROGRESS = 115,
        
        /// <summary>
        /// Interrupted function call
        /// </summary>
        EINTR = 4,
        
        /// <summary>
        /// Invalid argument
        /// </summary>
        EINVAL = 22,
        
        /// <summary>
        /// Input/output error
        /// </summary>
        EIO = 5,
        
        /// <summary>
        /// Socket is connected
        /// </summary>
        EISCONN = 106,
        
        /// <summary>
        /// Is a directory
        /// </summary>
        EISDIR = 21,
        
        /// <summary>
        /// Is a named type file
        /// </summary>
        EISNAM = 120,
        
        /// <summary>
        /// Key has expired
        /// </summary>
        EKEYEXPIRED = 127,
        
        /// <summary>
        /// Key was rejected by service
        /// </summary>
        EKEYREJECTED = 129,
        
        /// <summary>
        /// Key has been revoked
        /// </summary>
        EKEYREVOKED = 128,
        
        /// <summary>
        /// Level 2 halted
        /// </summary>
        EL2HLT = 51,
        
        /// <summary>
        /// Level 2 not synchronized
        /// </summary>
        EL2NSYNC = 45,
        
        /// <summary>
        /// Level 3 halted
        /// </summary>
        EL3HLT = 46,
        
        /// <summary>
        /// Level 3 halted
        /// </summary>
        EL3RST = 47,
        
        /// <summary>
        /// Cannot access a needed shared library
        /// </summary>
        ELIBACC = 79,
        
        /// <summary>
        /// Accessing a corrupted shared library
        /// </summary>
        ELIBBAD = 80,
        
        /// <summary>
        /// Attempting to link in too many shared libraries
        /// </summary>
        ELIBMAX = 82,
        
        /// <summary>
        /// lib section in a.out corrupted
        /// </summary>
        ELIBSCN = 81,
        
        /// <summary>
        /// Cannot exec a shared library directly
        /// </summary>
        ELIBEXEC = 83,
        
        /// <summary>
        /// Too many levels of symbolic links
        /// </summary>
        ELOOP = 40,
        
        /// <summary>
        /// Wrong medium type
        /// </summary>
        EMEDIUMTYPE = 124,
        
        /// <summary>
        /// Too many open files
        /// </summary>
        EMFILE = 24,
        
        /// <summary>
        /// Too many links
        /// </summary>
        EMLINK = 31,
        
        /// <summary>
        /// Message too long
        /// </summary>
        EMSGSIZE = 90,
        
        /// <summary>
        /// Multihop attempted
        /// </summary>
        EMULTIHOP = 72,
        
        /// <summary>
        /// Filename too long
        /// </summary>
        ENAMETOOLONG = 36,
        
        /// <summary>
        /// Network is down
        /// </summary>
        ENETDOWN = 100,
        
        /// <summary>
        /// Connection aborted by network
        /// </summary>
        ENETRESET = 102,
        
        /// <summary>
        /// Network unreachable
        /// </summary>
        ENETUNREACH = 101,
        
        /// <summary>
        /// Too many open files in system
        /// </summary>
        ENFILE = 23,
        
        /// <summary>
        /// No buffer space available
        /// </summary>
        ENOBUFS = 105,
        
        /// <summary>
        /// No message is available on the STREAM head read queue
        /// </summary>
        ENODATA = 61,
        
        /// <summary>
        /// No such device
        /// </summary>
        ENODEV = 19,
        
        /// <summary>
        /// No such file or directory
        /// </summary>
        ENOENT = 2,
        
        /// <summary>
        /// Exec format error
        /// </summary>
        ENOEXEC = 8,
        
        /// <summary>
        /// Required key not available
        /// </summary>
        ENOKEY = 126,
        
        /// <summary>
        /// No locks available
        /// </summary>
        ENOLCK = 37,
        
        /// <summary>
        /// Link has been severed
        /// </summary>
        ENOLINK = 67,
        
        /// <summary>
        /// No medium found
        /// </summary>
        ENOMEDIUM = 123,
        
        /// <summary>
        /// Not enough space
        /// </summary>
        ENOMEM = 12,
        
        /// <summary>
        /// No message of the desired type
        /// </summary>
        ENOMSG = 42,
        
        /// <summary>
        /// Machine is not on the network
        /// </summary>
        ENONET = 64,
        
        /// <summary>
        /// Package not installed
        /// </summary>
        ENOPKG = 65,
        
        /// <summary>
        /// Protocol not available
        /// </summary>
        ENOPROTOOPT = 92,
        
        /// <summary>
        /// No space left on device
        /// </summary>
        ENOSPC = 28,
        
        /// <summary>
        /// No STREAM resources
        /// </summary>
        ENOSR = 63,
        
        /// <summary>
        /// Not a STREAM
        /// </summary>
        ENOSTR = 60,
        
        /// <summary>
        /// Function not implemented
        /// </summary>
        ENOSYS = 38,
        
        /// <summary>
        /// Block device required
        /// </summary>
        ENOTBLK = 15,
        
        /// <summary>
        /// The socket is not connected
        /// </summary>
        ENOTCONN = 107,
        
        /// <summary>
        /// Not a directory
        /// </summary>
        ENOTDIR = 20,
        
        /// <summary>
        /// Directory not empty
        /// </summary>
        ENOTEMPTY = 39,
        
        /// <summary>
        /// Not a socket
        /// </summary>
        ENOTSOCK = 88,
        
        /// <summary>
        /// Operation not supported
        /// </summary>
        ENOTSUP = 95,
        
        /// <summary>
        /// Inappropriate I/O control operation
        /// </summary>
        ENOTTY = 25,
        
        /// <summary>
        /// Name not unique on network
        /// </summary>
        ENOTUNIQ = 76,
        
        /// <summary>
        /// No such device or address
        /// </summary>
        ENXIO = 6,
        
        /// <summary>
        /// Operation not supported on socket
        /// </summary>
        EOPNOTSUPP = 95,
        
        /// <summary>
        /// Value too large to be stored in data type
        /// </summary>
        EOVERFLOW = 75,
        
        /// <summary>
        /// Operation not permitted
        /// </summary>
        EPERM = 1,
        
        /// <summary>
        /// Protocol family not supported
        /// </summary>
        EPFNOSUPPORT = 96,
        
        /// <summary>
        /// Broken pipe
        /// </summary>
        EPIPE = 32,
        
        /// <summary>
        /// Protocol error
        /// </summary>
        EPROTO = 71,
        
        /// <summary>
        /// Protocol not supported
        /// </summary>
        EPROTONOSUPPORT = 93,
        
        /// <summary>
        /// Protocol wrong type for socket
        /// </summary>
        EPROTOTYPE = 91,
        
        /// <summary>
        /// Result too large
        /// </summary>
        ERANGE = 34,
        
        /// <summary>
        /// Remote address changed
        /// </summary>
        EREMCHG = 78,
        
        /// <summary>
        /// Object is remote
        /// </summary>
        EREMOTE = 66,
        
        /// <summary>
        /// Remote I/O error
        /// </summary>
        EREMOTEIO = 121,
        
        /// <summary>
        /// Interrupted system call should be restarted
        /// </summary>
        ERESTART = 85,
        
        /// <summary>
        /// Read-only filesystem
        /// </summary>
        EROFS = 30,
        
        /// <summary>
        /// Cannot send after transport endpoint shutdown
        /// </summary>
        ESHUTDOWN = 108,
        
        /// <summary>
        /// Invalid seek
        /// </summary>
        ESPIPE = 29,
        
        /// <summary>
        /// Socket type not supported
        /// </summary>
        ESOCKTNOSUPPORT = 94,
        
        /// <summary>
        /// No such process
        /// </summary>
        ESRCH = 3,
        
        /// <summary>
        /// Stale file handle
        /// </summary>
        ESTALE = 116,
        
        /// <summary>
        /// Streams pipe error
        /// </summary>
        ESTRPIPE = 86,
        
        /// <summary>
        /// Timer expired
        /// </summary>
        ETIME = 62,
        
        /// <summary>
        /// Connection timed out
        /// </summary>
        ETIMEDOUT = 110,
        
        /// <summary>
        /// Text file busy
        /// </summary>
        ETXTBSY = 26,
        
        /// <summary>
        /// Structure needs cleaning
        /// </summary>
        EUCLEAN = 117,
        
        /// <summary>
        /// Protocol driver not attached
        /// </summary>
        EUNATCH = 49,
        
        /// <summary>
        /// Too many users
        /// </summary>
        EUSERS = 87,
        
        /// <summary>
        /// Operation would block (may be same value as EAGAIN)
        /// </summary>
        EWOULDBLOCK = 11,
        
        /// <summary>
        /// Improper link
        /// </summary>
        EXDEV = 18,
        
        /// <summary>
        /// Exchange full
        /// </summary>
        EXFULL = 54,
    }
}
