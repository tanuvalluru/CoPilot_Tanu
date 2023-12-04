def generate_fibonacci(terms):
    a, b = 0, 1

    print(a, b, end=" ")

    for _ in range(2, terms):
        c = a + b
        print(c, end=" ")
        a, b = b, c

# Call the function
generate_fibonacci(10)