
# Get the dotnet runtime identifier (RID) for the host system

UNAME_S := $(shell uname -s)
ifeq ($(UNAME_S),Linux)
RID_OS := linux
endif
ifeq ($(UNAME_S),Darwin)
RID_OS := osx
endif
ifeq ($(RID_OS),)
$(error Unsupported operating system: $(UNAME_S))
endif

UNAME_P := $(shell uname -p)
ifeq ($(UNAME_P),x86_64)
RID_ARCH := x64
endif
ifneq ($(filter %86,$(UNAME_P)),)
RID_ARCH := x86
endif
ifeq ($(RID_ARCH),)
$(error Unsupported architecture: $(UNAME_S))
endif

export RID := $(RID_OS)-$(RID_ARCH)


all:
	$(MAKE) -C src/CodeGen

clean:
	$(MAKE) -C src/CodeGen clean
