
def selection_sort(nums):

    for i in range(len(nums) - 1):
        index = i

        for j in range(i, len(nums)):
            if nums[j] < nums[index]:
                index = j

        if index != i:
            nums[index], nums[i] = nums[i], nums[index]


if __name__ == "__main__":
    n = [2, 23, 2, -1, 32, 0, 44, 12, 4]
    selection_sort(n)
    print(n)

