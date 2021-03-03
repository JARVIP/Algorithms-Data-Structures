class Node:
    def __init__(self, data):
        self.data = data
        self.nextNode = None


class LinkedList:
    def __init__(self):
        self.head = None
        self.numOfNodes = 0

    # O(N) linear running time complexity
    def get_middle_node(self):

        fast_pointer = self.head
        slow_pointer = self.head

        while fast_pointer.nextNode and fast_pointer.nextNode.nextNode:
            fast_pointer = fast_pointer.nextNode.nextNode
            slow_pointer = slow_pointer.nextNode

        return slow_pointer

    # O(1) constant time complexity
    def insert_start(self, data):
        self.numOfNodes = self.numOfNodes + 1
        new_node = Node(data)

        if not self.head:
            self.head = new_node
        else:
            new_node.nextNode = self.head
            self.head = new_node

    # O(N) linear time complexity
    def insert_end(self, data):
        self.numOfNodes = self.numOfNodes + 1
        new_node = Node(data)

        actual_node = self.head

        while actual_node.nextNode is not None:
            actual_node = actual_node.nextNode

        actual_node.nextNode = new_node

    def remove(self, data):
        if self.head is None:
            return
        actual_node = self.head
        previous_node = None

        while actual_node is not None and actual_node.data != data:
            previous_node = actual_node
            actual_node = actual_node.nextNode
        # search miss - the item is not present in the linked list
        if actual_node is None:
            return

        self.numOfNodes = self.numOfNodes - 1
        if previous_node is None:
            self.head = actual_node.nextNode
        else:
            previous_node.nextNode = actual_node.nextNode

    # O(1) constant time complexity
    def size_of_list(self):
        return self.numOfNodes

    # O(N) linear time complexity
    def traverse(self):
        actual_node = self.head
        while actual_node is not None:
            print(actual_node.data)
            actual_node = actual_node.nextNode


if __name__ == '__main__':
    linked_list = LinkedList()

    linked_list.insert_start(10)
    linked_list.insert_start(20)
    linked_list.insert_start(30)
    linked_list.insert_start(40)
    linked_list.insert_start(50)
    linked_list.insert_start(60)
    linked_list.insert_start(70)
    linked_list.insert_start(80)
    linked_list.insert_start(90)
    linked_list.insert_start(100)
    linked_list.insert_start(110)

    print(linked_list.get_middle_node().data)
