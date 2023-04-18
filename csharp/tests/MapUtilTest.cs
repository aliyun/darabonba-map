using System;
using System.Collections.Generic;
using AlibabaCloud.DarabonbaMap;


using Xunit;

namespace tests
{
    public class MapUtilTest
    {
        [Fact]
        public void Test_Size()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            Assert.Equal(0, MapUtil.Size(dic));
            dic.Add("testNull", null);
            dic.Add("testExist", "testExist");
            dic.Add("test", "test");
            Assert.Equal(3, MapUtil.Size(dic));
        }

        public void Test_KeySet()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            List<string> list = MapUtil.KeySet(dic);
            Assert.Equal(0, list.Count);
            dic.Add("testNull", null);
            dic.Add("testExist", "testExist");
            dic.Add("test", "test");
            list = MapUtil.KeySet(dic);
            Assert.Equal(3, list.Count);
            Assert.Equal("testNull", list[0]);
        }
    }

}
