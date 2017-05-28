/*
 * Copyright (c) 2017 David Lechner <david@lechnology.com>
 * 
 * This software is released under the MIT License.
 * https://opensource.org/licenses/MIT
 */

#include <poll.h>
#include <gnu/lib-names.h>

#include "codegen.h"

static void generateSyscall(FILE *f)
{
    println("public static partial class Syscall");
    println("{");
    indent_inc();

    println("const string LibraryName = \"%s\";", LIBC_SO);

    indent_dec();
    println("}");
}

static void generatePoll(FILE *f)
{
    print_summary("The bits that may be set/returned in <see cref=\"PollFD.Events\" /> and <see cref=\"PollFD.REvents\" />");
    println("[Flags]");
    println("public enum PollEvents : short");
    println("{");
    indent_inc();

    print_summary("There is data to read.");
    println("%s = 0x%04x,", str(POLLIN), POLLIN);
    println();
    print_summary("There is urgent data to read.");
    println("%s = 0x%04x,", str(POLLPRI), POLLPRI);
    println();
    print_summary("Writing is now possible.");
    println("%s = 0x%04x,", str(POLLOUT), POLLOUT);
    println();
    print_summary("Error condition (only returned in revents; ignored in events).");
    println("%s = 0x%04x,", str(POLLERR), POLLERR);
    println();
    print_summary("Hang up (only returned in revents; ignored in events).");
    println("%s = 0x%04x,", str(POLLHUP), POLLHUP);
    println();
    print_summary("Invalid request: fd not open (only returned in revents; ignored in events).");
    println("%s = 0x%04x,", str(POLLNVAL), POLLNVAL);

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
    println("namespace %s", "DandyFX.Unix");
    println("{");
    indent_inc();

    generateSyscall(f);
    println();
    generatePoll(f);

    indent_dec();
    println("}");

    return 0;
}
