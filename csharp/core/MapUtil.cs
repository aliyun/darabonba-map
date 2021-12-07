/**
 * This is a map module
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.DarabonbaMap
{
    public class MapUtil 
    {

        public static int? Size(Dictionary<string, object> raw)
        {
            return raw.Count;
        }

        public static List<string> KeySet(Dictionary<string, object> raw)
        {
            List<string> keyList = new List<string>();
            foreach (KeyValuePair<string, object> kvp in raw)
            {
                keyList.Add(kvp.Key);
            }
            return keyList;
        }

    }
}