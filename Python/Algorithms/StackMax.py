class Stack:

    def __init__(self):
        # use one stack for enqueue operation
        self.stack = []
        # use another stack for dequeue operation
        self.max_stack = []

    def push(self, data):
        # push the new item onto the stack
        self.stack.append(data)

        # first item is the same in both stacks
        if len(self.stack) == 1:
            self.max_stack.append(data)
            return

        # if the item is the largest one so far: we insert it onto the stack
        # stack[-1] is the peek operation: returns the last item we have inserted
        if data > self.max_stack[-1]:
            self.max_stack.append(data)
        else:
            self.max_stack.append(self.max_stack[-1])

    # getting items
    def pop(self):
        self.max_stack.pop()
        return self.max_stack.pop()

    def get_max_item(self):
        return self.max_stack.pop()


if __name__ == '__main__':
    max_stack = Stack()
    max_stack.push(10000)
    max_stack.push(5)
    max_stack.push(1)
    max_stack.push(12)
    max_stack.push(100)

    max_stack.get_max_item()
