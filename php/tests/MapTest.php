<?php

namespace AlibabaCloud\Darabonba\MapUtil\Tests;

use AlibabaCloud\Darabonba\MapUtil\MapUtil;
use PHPUnit\Framework\TestCase;

/**
 * @internal
 * @coversNothing
 */
class MapTest extends TestCase
{
    public function test()
    {
        $this->assertEquals(
            3,
            MapUtil::size([
                'key' => 'value',
                'key1' => 'value1',
                'key2' => 'value2',
            ])
        );

        $this->assertEquals(
            0,
            MapUtil::size([ ])
        );

        $this->assertEquals(
            3,
            \count(MapUtil::keySet([
                'key' => 'value',
                'key1' => 'value1',
                'key2' => 'value2',
            ]))
        );

        $this->assertEquals(
            [],
            MapUtil::keySet([])
        );
    }
}
