package com.aliyun.darabonba.map;

import org.junit.Assert;
import org.junit.Test;

import java.util.HashMap;
import java.util.Map;

public class ClientTest {
    @Test
    public void sizeTest() {
        Map<String, String> map = new HashMap<>();
        Assert.assertEquals(0, Client.size(map).longValue());
        map.put("test1", "test1");
        map.put("test2", "test2");
        Assert.assertEquals(2, Client.size(map).longValue());
    }

    @Test
    public void keySetTest() {
        Map<String, String> map = new HashMap<>();
        Assert.assertEquals(0, Client.keySet(map).size());
        map.put("test1", "test1");
        map.put("test2", "test2");
        Assert.assertEquals(2, Client.keySet(map).size());
    }
}
