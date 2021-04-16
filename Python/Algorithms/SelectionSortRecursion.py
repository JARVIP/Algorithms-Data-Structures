class SelectionSortRecursion:

    def __init__(self, nums):
        self.nums = nums

    def find_min(self, a, i, j):

        # i: index of the first item we have to consider (index<i are in their sorted positions)
        # j: the index of the last item
        # when we have considered all the items - we return with i (which is the index of the minimum)
        if i == j:
            return i

        # it is a linear search so we have to consider the items one by one
        # this is why we call the function recursively with i+1 (index of the next item)
        z = self.find_min(a, i + 1, j)

        # we have considered the base case and we have to compare the items (item with index i and item with index z)
        # and of course we are looking for the minimum (so we return with the index of the smallest value)
        return i if a[i] < a[z] else z

    def sort(self):
        self.selection_sort(self.nums)

    def selection_sort(self, nums, actual_index=0):

        # we have considered all the items so we are done
        if actual_index == len(nums):
            return

        # find the index of the min item (linear search in O(N) running time)
        min_index = self.find_min(nums, actual_index, len(nums) - 1)

        # swap the item with the min item (actual index and min index)
        if min_index != actual_index:
            nums[min_index], nums[actual_index] = nums[actual_index], nums[min_index]

        # do next iteration (tail recursion)
        self.selection_sort(nums, actual_index + 1)


if __name__ == '__main__':
    n = [6, 3, -2, 0, 10, 9, 11]
    print(n)
    sort = SelectionSortRecursion(n)
    sort.sort()
    print(sort.nums)