import unittest

from alibabacloud_darabonba_map.client import Client


class TestClient(unittest.TestCase):
    def test_size(self):
        self.assertEqual(0, Client.size({}))
        map = {'py': 1, 'js': 2, 'go': 3, 'c': [1, 2, 3], 'java': {'test': 4}}
        self.assertEqual(5, Client.size(map))

    def test_key_set(self):
        self.assertEqual([], Client.key_set({}))
        map = {'py': 1, 'js': 2, 'go': 3, 'c': [1, 2, 3], 'java': {'test': 4}}
        expected = ['py', 'js', 'go', 'c', 'java']
        self.assertEqual(expected, Client.key_set(map))