// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.darabonba.map;

import com.aliyun.tea.*;

import java.util.ArrayList;
import java.util.List;

public class Client {

    public static Integer size(java.util.Map<String, ?> raw) {
        if (null == raw) {
            throw new IllegalArgumentException("not a valid value for parameter");
        }
        return raw.size();
    }

    public static List<String> keySet(java.util.Map<String, ?> raw) {
        if (null == raw) {
            throw new IllegalArgumentException("not a valid value for parameter");
        }
        return new ArrayList<>(raw.keySet());
    }
}
