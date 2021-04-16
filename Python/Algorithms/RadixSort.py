ITEMS_IN_BASKET = 10

class RadixSort:
    def __init__(self, data):
        self.data = data

    def get_digits(self):
        return len(str(max(self.data)))

    def sort(self):
        for digit in range(self.get_digits()):
            self.counting_sort(digit)

    def counting_sort(self, d):
        count_array = [[] for _ in range(ITEMS_IN_BASKET)]

        for num in self.data:
            index = (num // (10 ** d)) % 10
            count_array[index].append(num)

        z = 0
        for i in  range(len(count_array)):
            while len(count_array[i]) > 0:
                self.data[z] = count_array[i].pop(0)
                z += 1



if __name__ == '__main__':
    n = [1, 5, 3, 325, 10, 100, 1000]
    radix_sort = RadixSort(n)
    radix_sort.sort()
    print(radix_sort.data)
