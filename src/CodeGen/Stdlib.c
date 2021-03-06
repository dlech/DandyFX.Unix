/**
 * Copyright (c) 2017 David Lechner <david@lechnology.com>
 * 
 * This software is released under the MIT License.
 * https://opensource.org/licenses/MIT
 */

#include <errno.h>
#include <gnu/lib-names.h>

#include "codegen.h"

#define NAMESPACE "DandyFX.Unix"

static void generateStdlib(FILE *f)
{
    println("public static partial class Stdlib");
    println("{");
    indent_inc();

    println("internal const string LibraryName = \"%s\";", LIBC_SO);

    indent_dec();
    println("}");
}

static void generateErrno(FILE *f)
{
    print_summary("List of the error names that are defined on Linux");
    println("public enum Errno");
    println("{");
    indent_inc();

    print_summary("Argument list too long");
    println("%s = %d,", str(E2BIG), E2BIG);
    println();
    print_summary("Permission denied");
    println("%s = %d,", str(EACCES), EACCES);
    println();
    print_summary("Address already in use");
    println("%s = %d,", str(EADDRINUSE), EADDRINUSE);
    println();
    print_summary("Address not available");
    println("%s = %d,", str(EADDRNOTAVAIL), EADDRNOTAVAIL);
    println();
    print_summary("Address family not supported");
    println("%s = %d,", str(EAFNOSUPPORT), EAFNOSUPPORT);
    println();
    print_summary("Resource temporarily unavailable (may be the same value as EWOULDBLOCK)");
    println("%s = %d,", str(EAGAIN), EAGAIN);
    println();
    print_summary("Connection already in progress");
    println("%s = %d,", str(EALREADY), EALREADY);
    println();
    print_summary("Invalid exchange");
    println("%s = %d,", str(EBADE), EBADE);
    println();
    print_summary("Bad file descriptor");
    println("%s = %d,", str(EBADF), EBADF);
    println();
    print_summary("File descriptor in bad state");
    println("%s = %d,", str(EBADFD), EBADFD);
    println();
    print_summary("Bad message");
    println("%s = %d,", str(EBADMSG), EBADMSG);
    println();
    print_summary("Invalid request descriptor");
    println("%s = %d,", str(EBADR), EBADR);
    println();
    print_summary("Invalid request code");
    println("%s = %d,", str(EBADRQC), EBADRQC);
    println();
    print_summary("Invalid slot");
    println("%s = %d,", str(EBADSLT), EBADSLT);
    println();
    print_summary("Device or resource busy");
    println("%s = %d,", str(EBUSY), EBUSY);
    println();
    print_summary("Operation canceled");
    println("%s = %d,", str(ECANCELED), ECANCELED);
    println();
    print_summary("No child processes");
    println("%s = %d,", str(ECHILD), ECHILD);
    println();
    print_summary("Channel number out of range");
    println("%s = %d,", str(ECHRNG), ECHRNG);
    println();
    print_summary("Communication error on send");
    println("%s = %d,", str(ECOMM), ECOMM);
    println();
    print_summary("Connection aborted");
    println("%s = %d,", str(ECONNABORTED), ECONNABORTED);
    println();
    print_summary("Connection refused");
    println("%s = %d,", str(ECONNREFUSED), ECONNREFUSED);
    println();
    print_summary("Connection reset");
    println("%s = %d,", str(ECONNRESET), ECONNRESET);
    println();
    print_summary("Resource deadlock avoided");
    println("%s = %d,", str(EDEADLK), EDEADLK);
    println();
    print_summary("Synonym for EDEADLK");
    println("%s = %d,", str(EDEADLOCK), EDEADLOCK);
    println();
    print_summary("Destination address required");
    println("%s = %d,", str(EDESTADDRREQ), EDESTADDRREQ);
    println();
    print_summary("Mathematics argument out of domain of function");
    println("%s = %d,", str(EDOM), EDOM);
    println();
    print_summary("Disk quota exceeded");
    println("%s = %d,", str(EDQUOT), EDQUOT);
    println();
    print_summary("File exists");
    println("%s = %d,", str(EEXIST), EEXIST);
    println();
    print_summary("Bad address");
    println("%s = %d,", str(EFAULT), EFAULT);
    println();
    print_summary("File too large");
    println("%s = %d,", str(EFBIG), EFBIG);
    println();
    print_summary("Host is down");
    println("%s = %d,", str(EHOSTDOWN), EHOSTDOWN);
    println();
    print_summary("Host is unreachable");
    println("%s = %d,", str(EHOSTUNREACH), EHOSTUNREACH);
    println();
    print_summary("Identifier removed");
    println("%s = %d,", str(EIDRM), EIDRM);
    println();
    print_summary("Illegal byte sequence");
    println("%s = %d,", str(EILSEQ), EILSEQ);
    println();
    print_summary("Operation in progress");
    println("%s = %d,", str(EINPROGRESS), EINPROGRESS);
    println();
    print_summary("Interrupted function call");
    println("%s = %d,", str(EINTR), EINTR);
    println();
    print_summary("Invalid argument");
    println("%s = %d,", str(EINVAL), EINVAL);
    println();
    print_summary("Input/output error");
    println("%s = %d,", str(EIO), EIO);
    println();
    print_summary("Socket is connected");
    println("%s = %d,", str(EISCONN), EISCONN);
    println();
    print_summary("Is a directory");
    println("%s = %d,", str(EISDIR), EISDIR);
    println();
    print_summary("Is a named type file");
    println("%s = %d,", str(EISNAM), EISNAM);
    println();
    print_summary("Key has expired");
    println("%s = %d,", str(EKEYEXPIRED), EKEYEXPIRED);
    println();
    print_summary("Key was rejected by service");
    println("%s = %d,", str(EKEYREJECTED), EKEYREJECTED);
    println();
    print_summary("Key has been revoked");
    println("%s = %d,", str(EKEYREVOKED), EKEYREVOKED);
    println();
    print_summary("Level 2 halted");
    println("%s = %d,", str(EL2HLT), EL2HLT);
    println();
    print_summary("Level 2 not synchronized");
    println("%s = %d,", str(EL2NSYNC), EL2NSYNC);
    println();
    print_summary("Level 3 halted");
    println("%s = %d,", str(EL3HLT), EL3HLT);
    println();
    print_summary("Level 3 halted");
    println("%s = %d,", str(EL3RST), EL3RST);
    println();
    print_summary("Cannot access a needed shared library");
    println("%s = %d,", str(ELIBACC), ELIBACC);
    println();
    print_summary("Accessing a corrupted shared library");
    println("%s = %d,", str(ELIBBAD), ELIBBAD);
    println();
    print_summary("Attempting to link in too many shared libraries");
    println("%s = %d,", str(ELIBMAX), ELIBMAX);
    println();
    print_summary("lib section in a.out corrupted");
    println("%s = %d,", str(ELIBSCN), ELIBSCN);
    println();
    print_summary("Cannot exec a shared library directly");
    println("%s = %d,", str(ELIBEXEC), ELIBEXEC);
    println();
    print_summary("Too many levels of symbolic links");
    println("%s = %d,", str(ELOOP), ELOOP);
    println();
    print_summary("Wrong medium type");
    println("%s = %d,", str(EMEDIUMTYPE), EMEDIUMTYPE);
    println();
    print_summary("Too many open files");
    println("%s = %d,", str(EMFILE), EMFILE);
    println();
    print_summary("Too many links");
    println("%s = %d,", str(EMLINK), EMLINK);
    println();
    print_summary("Message too long");
    println("%s = %d,", str(EMSGSIZE), EMSGSIZE);
    println();
    print_summary("Multihop attempted");
    println("%s = %d,", str(EMULTIHOP), EMULTIHOP);
    println();
    print_summary("Filename too long");
    println("%s = %d,", str(ENAMETOOLONG), ENAMETOOLONG);
    println();
    print_summary("Network is down");
    println("%s = %d,", str(ENETDOWN), ENETDOWN);
    println();
    print_summary("Connection aborted by network");
    println("%s = %d,", str(ENETRESET), ENETRESET);
    println();
    print_summary("Network unreachable");
    println("%s = %d,", str(ENETUNREACH), ENETUNREACH);
    println();
    print_summary("Too many open files in system");
    println("%s = %d,", str(ENFILE), ENFILE);
    println();
    print_summary("No buffer space available");
    println("%s = %d,", str(ENOBUFS), ENOBUFS);
    println();
    print_summary("No message is available on the STREAM head read queue");
    println("%s = %d,", str(ENODATA), ENODATA);
    println();
    print_summary("No such device");
    println("%s = %d,", str(ENODEV), ENODEV);
    println();
    print_summary("No such file or directory");
    println("%s = %d,", str(ENOENT), ENOENT);
    println();
    print_summary("Exec format error");
    println("%s = %d,", str(ENOEXEC), ENOEXEC);
    println();
    print_summary("Required key not available");
    println("%s = %d,", str(ENOKEY), ENOKEY);
    println();
    print_summary("No locks available");
    println("%s = %d,", str(ENOLCK), ENOLCK);
    println();
    print_summary("Link has been severed");
    println("%s = %d,", str(ENOLINK), ENOLINK);
    println();
    print_summary("No medium found");
    println("%s = %d,", str(ENOMEDIUM), ENOMEDIUM);
    println();
    print_summary("Not enough space");
    println("%s = %d,", str(ENOMEM), ENOMEM);
    println();
    print_summary("No message of the desired type");
    println("%s = %d,", str(ENOMSG), ENOMSG);
    println();
    print_summary("Machine is not on the network");
    println("%s = %d,", str(ENONET), ENONET);
    println();
    print_summary("Package not installed");
    println("%s = %d,", str(ENOPKG), ENOPKG);
    println();
    print_summary("Protocol not available");
    println("%s = %d,", str(ENOPROTOOPT), ENOPROTOOPT);
    println();
    print_summary("No space left on device");
    println("%s = %d,", str(ENOSPC), ENOSPC);
    println();
    print_summary("No STREAM resources");
    println("%s = %d,", str(ENOSR), ENOSR);
    println();
    print_summary("Not a STREAM");
    println("%s = %d,", str(ENOSTR), ENOSTR);
    println();
    print_summary("Function not implemented");
    println("%s = %d,", str(ENOSYS), ENOSYS);
    println();
    print_summary("Block device required");
    println("%s = %d,", str(ENOTBLK), ENOTBLK);
    println();
    print_summary("The socket is not connected");
    println("%s = %d,", str(ENOTCONN), ENOTCONN);
    println();
    print_summary("Not a directory");
    println("%s = %d,", str(ENOTDIR), ENOTDIR);
    println();
    print_summary("Directory not empty");
    println("%s = %d,", str(ENOTEMPTY), ENOTEMPTY);
    println();
    print_summary("Not a socket");
    println("%s = %d,", str(ENOTSOCK), ENOTSOCK);
    println();
    print_summary("Operation not supported");
    println("%s = %d,", str(ENOTSUP), ENOTSUP);
    println();
    print_summary("Inappropriate I/O control operation");
    println("%s = %d,", str(ENOTTY), ENOTTY);
    println();
    print_summary("Name not unique on network");
    println("%s = %d,", str(ENOTUNIQ), ENOTUNIQ);
    println();
    print_summary("No such device or address");
    println("%s = %d,", str(ENXIO), ENXIO);
    println();
    print_summary("Operation not supported on socket");
    println("%s = %d,", str(EOPNOTSUPP), EOPNOTSUPP);
    println();
    print_summary("Value too large to be stored in data type");
    println("%s = %d,", str(EOVERFLOW), EOVERFLOW);
    println();
    print_summary("Operation not permitted");
    println("%s = %d,", str(EPERM), EPERM);
    println();
    print_summary("Protocol family not supported");
    println("%s = %d,", str(EPFNOSUPPORT), EPFNOSUPPORT);
    println();
    print_summary("Broken pipe");
    println("%s = %d,", str(EPIPE), EPIPE);
    println();
    print_summary("Protocol error");
    println("%s = %d,", str(EPROTO), EPROTO);
    println();
    print_summary("Protocol not supported");
    println("%s = %d,", str(EPROTONOSUPPORT), EPROTONOSUPPORT);
    println();
    print_summary("Protocol wrong type for socket");
    println("%s = %d,", str(EPROTOTYPE), EPROTOTYPE);
    println();
    print_summary("Result too large");
    println("%s = %d,", str(ERANGE), ERANGE);
    println();
    print_summary("Remote address changed");
    println("%s = %d,", str(EREMCHG), EREMCHG);
    println();
    print_summary("Object is remote");
    println("%s = %d,", str(EREMOTE), EREMOTE);
    println();
    print_summary("Remote I/O error");
    println("%s = %d,", str(EREMOTEIO), EREMOTEIO);
    println();
    print_summary("Interrupted system call should be restarted");
    println("%s = %d,", str(ERESTART), ERESTART);
    println();
    print_summary("Read-only filesystem");
    println("%s = %d,", str(EROFS), EROFS);
    println();
    print_summary("Cannot send after transport endpoint shutdown");
    println("%s = %d,", str(ESHUTDOWN), ESHUTDOWN);
    println();
    print_summary("Invalid seek");
    println("%s = %d,", str(ESPIPE), ESPIPE);
    println();
    print_summary("Socket type not supported");
    println("%s = %d,", str(ESOCKTNOSUPPORT), ESOCKTNOSUPPORT);
    println();
    print_summary("No such process");
    println("%s = %d,", str(ESRCH), ESRCH);
    println();
    print_summary("Stale file handle");
    println("%s = %d,", str(ESTALE), ESTALE);
    println();
    print_summary("Streams pipe error");
    println("%s = %d,", str(ESTRPIPE), ESTRPIPE);
    println();
    print_summary("Timer expired");
    println("%s = %d,", str(ETIME), ETIME);
    println();
    print_summary("Connection timed out");
    println("%s = %d,", str(ETIMEDOUT), ETIMEDOUT);
    println();
    print_summary("Text file busy");
    println("%s = %d,", str(ETXTBSY), ETXTBSY);
    println();
    print_summary("Structure needs cleaning");
    println("%s = %d,", str(EUCLEAN), EUCLEAN);
    println();
    print_summary("Protocol driver not attached");
    println("%s = %d,", str(EUNATCH), EUNATCH);
    println();
    print_summary("Too many users");
    println("%s = %d,", str(EUSERS), EUSERS);
    println();
    print_summary("Operation would block (may be same value as EAGAIN)");
    println("%s = %d,", str(EWOULDBLOCK), EWOULDBLOCK);
    println();
    print_summary("Improper link");
    println("%s = %d,", str(EXDEV), EXDEV);
    println();
    print_summary("Exchange full");
    println("%s = %d,", str(EXFULL), EXFULL);

    indent_dec();
    println("}");
}

int main(int argc, char **argv)
{
    FILE *f = parse_args(argc, argv);

    print_header();
    println();
    println("using System;");
    println();
    println("namespace %s", NAMESPACE);
    println("{");
    indent_inc();

    generateStdlib(f);
    println();
    generateErrno(f);

    indent_dec();
    println("}");

    return 0;
}
