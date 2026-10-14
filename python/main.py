"""Assignment 1: Review of Programming Fundamentals (Python)."""


def calculator():
    print("\n--- Two-number calculator ---")
    try:
        first = float(input("Enter the first number: "))
        second = float(input("Enter the second number: "))
    except ValueError:
        print("Please enter valid numbers.")
        return

    operation = input("Choose an operation (+, -, *, /): ").strip()
    if operation == "+":
        result = first + second
    elif operation == "-":
        result = first - second
    elif operation == "*":
        result = first * second
    elif operation == "/":
        if second == 0:
            print("Error: Cannot divide by zero.")
            return
        result = first / second
    else:
        print("Invalid operation.")
        return

    print(f"Result: {result:g}")


def temperature_converter():
    print("\n--- Temperature converter ---")
    direction = input("Enter C for Celsius to Fahrenheit or F for Fahrenheit to Celsius: ").strip().upper()
    if direction not in ("C", "F"):
        print("Invalid conversion direction.")
        return

    try:
        temperature = float(input("Enter the temperature: "))
    except ValueError:
        print("Please enter a valid temperature.")
        return

    if direction == "C":
        converted = temperature * 1.8 + 32
        print(f"{temperature:g}°C = {converted:g}°F")
    else:
        converted = (temperature - 32) / 1.8
        print(f"{temperature:g}°F = {converted:g}°C")


def student_grade_average():
    print("\n--- Student grade average ---")
    try:
        count = int(input("How many grades? "))
    except ValueError:
        print("Please enter a whole number.")
        return

    if count <= 0:
        print("The number of grades must be greater than zero.")
        return

    total = 0.0
    for index in range(1, count + 1):
        while True:
            try:
                grade = float(input(f"Enter grade {index} (1-6): "))
                if 1 <= grade <= 6:
                    total += grade
                    break
                print("Grade must be between 1 and 6.")
            except ValueError:
                print("Please enter a valid grade.")

    average = total / count
    print(f"Average: {average:.2f}")
    if average >= 3.0:
        print("The student passed.")
    else:
        print("The student failed.")


def main():
    while True:
        print("\n=== Assignment 1: Programming Fundamentals ===")
        print("1. Two-number calculator")
        print("2. Temperature converter")
        print("3. Student grade average")
        print("0. Exit")
        choice = input("Select a task: ").strip()

        if choice == "1":
            calculator()
        elif choice == "2":
            temperature_converter()
        elif choice == "3":
            student_grade_average()
        elif choice == "0":
            print("Goodbye!")
            break
        else:
            print("Invalid menu option. Please try again.")


if __name__ == "__main__":
    main()
