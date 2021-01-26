def find_diplicates(nums):

    for num in nums:
        if nums[abs(num)] >= 0:
            nums[abs(num)] = -nums[abs(num)]
        else:
            print('Repetition found %s' % str(abs(num)))


if __name__ == '__main__':
    # This Method Caanot handle values < 0!!!
    n = [2, 6, 5, 1, 4, 3, 5, 2]
    find_diplicates(n)
