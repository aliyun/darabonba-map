/**
 * This is a map module
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;


namespace AlibabaCloud.DarabonbaMap
{
    public class MapUtil 
    {

        public static int Size(IDictionary raw)
        {
            if (raw == null)
            {
                return 0;
            }
            return raw.Count;
        }

        public static List<string> KeySet(IDictionary raw)
        {
            List<string> keyList = new List<string>();
            if (raw == null)
            {
                return keyList;
            }
            Dictionary<string, object> dict = raw.Keys.Cast<string>().ToDictionary(key => key, key => raw[key]);
            foreach (KeyValuePair<string, object> kvp in dict)
            {
                keyList.Add(kvp.Key);
            }
            return keyList;
        }

    }
}