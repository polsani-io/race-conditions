counter = 0

def main():
    increment_counter()
    print(f"The final value of counter is: {counter}")

def increment_counter():
    global counter
    for _ in range(1000000):
        counter += 1

if __name__ == "__main__":
    main()
