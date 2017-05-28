// Copyright (c) 2017 David Lechner <david@lechnology.com>
// 
// This software is released under the MIT License.
// https://opensource.org/licenses/MIT

using System;
using Xunit;

namespace DandyFX.Unix.Test
{
    public class SyscallTests
    {
        [Fact]
        public void PollTest()
        {
            var fds = new PollFD[1];
            fds[0].Fd = -1;
            fds[0].Events = PollEvents.POLLIN;
            // you wouldn't really set REvents in normal usage, but the call
            // to poll() always sets REvents, so we are using this to test that
            // P/Invoke is marshalling the changed value back.
            fds[0].REvents = (PollEvents)(-1);
            var ret = Syscall.Poll(fds, 0);
            Assert.Equal(0, ret);
            Assert.Equal((PollEvents)0, fds[0].REvents);

            Assert.Throws<ArgumentNullException>(() => Syscall.Poll(null));
        }
    }
}
