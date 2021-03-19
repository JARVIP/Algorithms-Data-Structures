def insertion_sort(nums):
    for i in range(len(nums)):
        j = i
        
        while j > 0 and nums[j - 1] > nums[j]:
            nums[j - 1], nums[j] = nums[j], nums[j - 1]
            j = j - 1


if __name__ == "__main__":
    n = [1, 3, 4, 4, 13, 323, -5, 3, 2, 3, 4]
    insertion_sort(n)
    print(n)
