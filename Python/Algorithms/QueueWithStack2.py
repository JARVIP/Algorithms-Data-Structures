class Queue:

    def __init__(self):
        # use one stack for the operations
        self.stack = []

    # adding an item to the queue is  O(1) operation
    def enqueue(self, data):
        self.stack.append(data)

    # NOTE: we use 2 stacks again but instead of explicitly define the second stack
    # we use the call-stack of program (stack memory of execution stack)
    def dequeue(self):

        # base case for the recursive methd calls the first item
        # is what we are after (this is what we need for queue's dequeue operation)
        if len(self.stack) == 1:
            return  self.stack.pop()

        # we keep popping the items until we find the last one
        item = self.stack.pop()

        # we call the method recursively until we find the first item we have inserted
        dequeued_item = self.dequeue()

        # after we find the item we have to reinsert the items one by one
        self.stack.append(item)

        # this is the item we are looking for
        return dequeued_item


if __name__ == '__main__':
    queue = Queue()

    queue.enqueue(10)
    queue.enqueue(14)
    queue.enqueue(13)
    queue.enqueue(12)

    print(queue.dequeue())



