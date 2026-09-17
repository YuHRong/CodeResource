# License: https://bit.ly/3oLErEI

# Define a function named 'test' that takes a list 'nums' as input
def test(nums):
    # Check if the count of 19 in 'nums' is equal to 2 and the count of 5 is greater than or equal to 3
    return nums.count(19) == 2 and nums.count(5) >= 3

# Create a list 'nums' with specific elements
nums = [19, 19, 15, 5, 3, 5, 5, 2]

# Print the original list
print("Original list:")
print(nums)

# Print the result of the test function applied to the 'nums' list
print("Check two occurrences of nineteen and at least three occurrences of five in the said list:")
print(test(nums))

# Create a different list 'nums' with specific elements
nums = [19, 15, 15, 5, 3, 3, 5, 2]

# Print the original list
print("\nOriginal list:")
print(nums)

# Print the result of the test function applied to the modified 'nums' list
print("Check two occurrences of nineteen and at least three occurrences of five in the said list:")
print(test(nums))

# Create another list 'nums' with specific elements
nums = [19, 19, 5, 5, 5, 5, 5]

# Print the original list
print("\nOriginal list:")
print(nums)

# Print the result of the test function applied to the modified 'nums' list
print("Check two occurrences of nineteen and at least three occurrences of five in the said list:")
print(test(nums))
