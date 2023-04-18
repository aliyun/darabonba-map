

import * as $tea from '@alicloud/tea-typescript';
import 'mocha';
import assert from 'assert';
import client from '../src/client'
describe('Tea Util', function () {
  const test = { name: '小黑', age: 2, isLife: true, love: ['吃', '睡', '跑'] }
  it('size should ok', function () {
    assert.strictEqual(0, client.size({}));
    const result = client.size(test)
    assert.strictEqual(4, result);
  });

  it('keySet should ok', function () {
    assert.deepStrictEqual([], client.keySet({}));
    var res = client.keySet(test);
    assert.deepStrictEqual(['name', 'age', 'isLife', 'love'], res);
  });
})