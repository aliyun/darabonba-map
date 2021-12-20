// This file is auto-generated, don't edit it. Thanks.
/**
 * This is a map module
 */
package client

import (
	"sort"
	"testing"

	"github.com/alibabacloud-go/tea/tea"
	"github.com/alibabacloud-go/tea/utils"
)

func Test_Size(t *testing.T) {
	mp := map[string]interface{}{
		"a":  "b",
		"c":  "d",
		"中国": "北京",
	}
	result := Size(mp)
	utils.AssertEqual(t, 3, tea.IntValue(result))
}

func Test_KeySize(t *testing.T) {
	mp := map[string]interface{}{
		"a":  "b",
		"c":  "d",
		"中国": "北京",
	}
	result := KeySet(mp)
	res := tea.StringSliceValue(result)
	sort.Strings(res)
	utils.AssertEqual(t, []string{"a", "c", "中国"}, res)
	m := map[string]*string{
		"2": tea.String("1"),
		"1": tea.String("2"),
		"6": tea.String("6"),
	}
	result = KeySet(m)
	res = tea.StringSliceValue(result)
	sort.Strings(res)
	utils.AssertEqual(t, []string{"1", "2", "6"}, res)

	ma := map[string]string{
		"4": "4",
		"2": "2",
		"6": "6",
	}
	result = KeySet(ma)
	res = tea.StringSliceValue(result)
	sort.Strings(res)
	utils.AssertEqual(t, []string{"2", "4", "6"}, res)
}
