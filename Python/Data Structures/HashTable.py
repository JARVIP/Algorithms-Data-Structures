class Hashtable:

    def __init__(self):
        # based on the load factor we may change the size of the underlying data structure (dynamic resizing)
        self.capacity = 10
        self.keys = [None] * self.capacity
        self.values = [None] * self.capacity

    # hash value (index of the array based on the key)
    def hash_function(self, key):

        hash_sum = 0

        for letter in key:
            hash_sum = hash_sum + ord(letter)

        return hash_sum % self.capacity

    def insert(self, key, data):

        # we have to find valid location for the data
        index = self.hash_function(key)

        # there may be collisions
        while self.keys[index] is not None:
            # we have to update the value if the key is already present
            if self.keys[index] == key:
                self.values[index] = data
                return

            # do linear probing
            index = (index + 1) % self.capacity

        self.keys[index] = key
        self.values[index] = data

    def get(self, key):
        # we have to find valid location for the data
        index = self.hash_function(key)
        # there may be collisions
        while self.keys[index] is not None:
            # we have to update the value if the key is already present
            if self.keys[index] == key:
                return self.values[index]

            # do linear probing
            index = (index + 1) % self.capacity

        return None


if __name__ == '__main__':
    table = Hashtable()
    table.insert("Adam", 23)
    table.insert("Kevin", 45)
    table.insert("Daniel", 34)
    table.insert("Oleg", 34)

    print(table.get("Oleg"))
