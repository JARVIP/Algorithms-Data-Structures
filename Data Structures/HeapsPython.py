import heapq

nums = [4, 7, 3, -2, 1, 0]
heap = []

# heapq.heapify(nums)

for value in nums:
    heapq.heappush(heap, value)

while heap:
    print(heapq.heappop(heap))
