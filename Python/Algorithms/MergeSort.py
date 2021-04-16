def merge_sort(nums):
    # define the base case : that we keep splitting the lists until
    # the sub lists have just 1 item-arrays with a  single item i sorted by defoult
    if len(nums) == 1:
        return

    middle_index = len(nums) // 2
    left_half = nums[:middle_index]
    right_half = nums[middle_index:]

    merge_sort(left_half)
    merge_sort(right_half)

    # conquer  phase

    i = 0
    j = 0
    k = 0

    while i < len(left_half) and j < len(right_half):
        if left_half[i] < right_half[j]:
            nums[k] = left_half[i]
            i = i + 1
        else:
            nums[k] = right_half[j]
            j = j + 1

        k = k + 1

    # after that  there may be additional items in the left(right) subbarray

    while i < len(left_half):
        nums[k] = left_half[i]
        i = i + 1
        k = k + 1

    while j < len(right_half):
        nums[k] = right_half[j]
        j = j + 1
        k = k + 1


if __name__ == '__main__':
    my_list = [1, 5, -2, 3, 32, 3, 1, 5, 3, -5, -3]
    merge_sort(my_list)
    print(my_list)
