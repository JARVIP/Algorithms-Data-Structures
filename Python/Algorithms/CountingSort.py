

class CountingSort:

    def __init__(self, data):
        self.data = data
        self.count_array = [0 for _ in range(max(data) - min(data) + 1)]

    def sort(self):
        min_value = min(self.data)
        for i in range(len(self.data)):
            self.count_array[self.data[i] - min_value] += 1

        z = 0
        for i in range(min(self.data), max(self.data) + 1):
            while self.count_array[i - min_value] > 0:
                self.data[z] = i
                z += 1
                self.count_array[i-min_value] -= 1


if __name__ == '__main__':
    n = [4, 6, 3, 43, 1, -4]
    counting_sort = CountingSort(n)
    counting_sort.sort()
    print(counting_sort.data)
