/*
 * Copyright (c) 2017 David Lechner <david@lechnology.com>
 * 
 * This software is released under the MIT License.
 * https://opensource.org/licenses/MIT
 */

#ifndef __CODEGEN_H__
#define __CODEGEN_H__

#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#define MAX_INDENT_SIZE 64
#define INDENTATION "    "

#define str(s) #s // convert identifier to string
#define println(fmt, ...) fprintf(f, "%s" fmt "\n", indent, ##__VA_ARGS__)

#define print_header() \
    println("// This file is generated. Do not edit directly.")

#define print_summary(s)      \
    println("/// <summary>"); \
    println("/// " s);        \
    println("/// </summary>");


static char indent[MAX_INDENT_SIZE];

static inline void indent_inc(void)
{
    strncat(indent, INDENTATION, MAX_INDENT_SIZE);
}

static inline void indent_dec(void)
{
    size_t len1, len2;

    len1 = strlen(indent);
    len2 = strlen(INDENTATION);
    if (len1 >= len2) {
        indent[len1 - len2] = '\0';
    }
    else {
        fprintf(stderr, "Indent imbalance!\n");
        indent[0] = '\0';
    }
}

static inline FILE *parse_args(int argc, char **argv)
{
    FILE *f;

    if (argc != 2) {
        fprintf(stderr, "Requires one argument.\n");
        exit(1);
    }

    if (argv[1][0] == '-') {
        if (!strcmp(argv[1], "--stdout")) {
            f = stdout;
        }
	else {
            fprintf(stderr, "Unknown option.\n");
            exit(1);
        }
    }
    else {
        f = fopen(argv[1], "w");
        if (!f) {
            perror("Failed to open file: ");
            exit(1);
        }
    }

    return f;
}

#endif /* __CODEGEN_H__ */
