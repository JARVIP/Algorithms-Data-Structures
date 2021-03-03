def is_min_heap(heap):
    # there is no need to check th leaf nodes
    num_items = (len(heap) - 2) // 2

    for i in range(num_items):

        # we have to check the heap property
        # the parent must be smaller than the children
        if heap[i] > heap[2 * i + 1] or heap[i] > heap[2 * i + 2]:
            return False

    return True


if __name__ == "__main__":
    n = [3, 2, 3, 4, 5]

    print(is_min_heap(n))
