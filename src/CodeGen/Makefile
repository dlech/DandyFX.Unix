
ifeq ($(RID),)
# we don't want to write over the wrong files
$(error RID is not specified)
endif

all: ../$(RID)/Stdlib.cs ../$(RID)/Syscall.cs

Stdlib: Stdlib.o codegen.h

Syscall: Syscall.o codegen.h

../$(RID)/%.cs: %
	./$< $@

clean:
	rm -f *.o
	rm -f Stdlib
	rm -f Syscall
