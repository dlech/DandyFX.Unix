// Copyright (c) 2017 David Lechner <david@lechnology.com>
// 
// This software is released under the MIT License.
// https://opensource.org/licenses/MIT

using System;
using Xunit;

namespace DandyFX.Unix.Test
{
    public class StdlibTests
    {
        [Fact]
        public void TestStrerror()
        {
            var msg = Stdlib.Strerror((int)Errno.EINVAL);
            Assert.Equal("Invalid argument", msg);
        }

        [Fact]
        public void TestDeviceID()
        {
            var id = new DeviceID(1, 2);
            Assert.Equal(1u, id.Major);
            Assert.Equal(2u, id.Minor);
        }
    }
}
