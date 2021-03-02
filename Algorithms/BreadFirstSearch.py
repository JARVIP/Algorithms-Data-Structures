
class Node:

    def __init__(self, name):
        self.name = name
        self.adjacency_list = []
        self.visited = False


def BFS(starting_node):
    # FIFO
    queue = [starting_node]

    # we keep iterating until the queue becomes empty
    while queue:

        # remove and return the first item we have inserted into the list
        actual_node = queue.pop(0)
        actual_node.visited = True
        print(actual_node.name)

        for n in actual_node.adjacency_list:
            if not n.visited:
                queue.append(n)


if __name__ == "__main__":

    node1 = Node("A")
    node2 = Node("B")
    node3 = Node("C")
    node4 = Node("D")
    node5 = Node("E")

    node1.adjacency_list.append(node2)
    node1.adjacency_list.append(node3)
    node2.adjacency_list.append(node4)
    node4.adjacency_list.append(node5)

    BFS(node1)
