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
}
