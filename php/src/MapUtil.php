<?php

// This file is auto-generated, don't edit it. Thanks.
// namespace AlibabaCloud\Darabonba\Array;

// use \Exception;

namespace AlibabaCloud\Darabonba\MapUtil;

/**
 * This is a array module.
 */
class MapUtil
{
    /**
     * @param array $raw
     *
     * @return int
     */
    public static function size($raw)
    {
        if (!isset($raw)) {
            throw new \InvalidArgumentException('not a valid value for parameter');
        }

        return count($raw);
    }

    /**
     * @param array $raw
     *
     * @return string[]
     */
    public static function keySet($raw)
    {
        if (!isset($raw)) {
            throw new \InvalidArgumentException('not a valid value for parameter');
        }
        return array_keys($raw);
    }
}
