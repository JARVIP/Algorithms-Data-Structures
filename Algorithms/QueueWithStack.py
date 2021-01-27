class Queue:

    def __init__(self):
        # use one stack for enqueue operation
        self.enqueue_stack = []
        # use another stack for the dequeue operation
        self.dequeue_stack = []

    # adding an item to the queue is O(1) operation
    def enqueue(self, data):
        self.enqueue_stack.append(data)

    # getting items
    def dequeue(self):

        # maybe there are no items in the stacks
        if len(self.enqueue_stack) == 0 and len(self.dequeue_stack) == 0:
            raise  Exception("Stack are empty...")

        # if the dequeue_stack is empty we have to add items O(N) time
        if len(self.dequeue_stack) == 0:
            while len(self.enqueue_stack) != 0:
                self.dequeue_stack.append(self.enqueue_stack.pop())

        # otherwise we just have to pop off an item in O(1)
        return self.dequeue_stack.pop()


if __name__ == '__main__':
    queue = Queue()

    queue.enqueue(10)
    queue.enqueue(14)
    queue.enqueue(13)
    queue.enqueue(12)

    print(len(queue.enqueue_stack))
    print(len(queue.dequeue_stack))

    print(queue.dequeue())

    print(len(queue.enqueue_stack))
    print(len(queue.dequeue_stack))