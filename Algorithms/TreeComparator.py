class TreeComparator(object):

    def compare_trees(self, node1, node2):
        if not node1 or not node2:
            return node1 == node2

        if node1.data is not node2.data:
            return False
        return self.compare_trees(node1.leftChild, node2.leftChild) \
               and self.compare_trees(node1.rightChild, node2.rightChild)


class Node:
    def __init__(self, data, parent):
        self.data = data
        self.leftChild = None
        self.rightChild = None
        self.parent = parent


class BinarySearchTree:

    def __init__(self):
        self.root = None


if __name__ == '__main__':
    bst1 = BinarySearchTree()
    bst1.insert(10)
    bst1.insert(5)
    bst1.insert(66)
    bst1.insert(-5)
    bst1.insert(34)
    bst1.insert(1000)

    bst2 = BinarySearchTree()
    bst2.insert(6)
    bst2.insert(5)
    bst2.insert(66)
    bst2.insert(-5)
    bst2.insert(34)
    bst2.insert(1000)
    comparator = TreeComparator()
    print(comparator.compare_trees(bst1.root, bst2.root))
