# LuhnAlgorithm

# Card Number Validator

This program validates a card number based on a specific algorithm. It processes a sequence of 16 digits, doubles every second digit (starting from the left), sums the digits of any number greater than or equal to 10, and finally sums all the digits. If the total sum is 80, the card number is considered valid; otherwise, it is considered invalid.

## Purpose

This code can be used to check if a sequence of digits, such as a credit or debit card number, follows a specific validation algorithm. It's useful for verifying card numbers in systems that require a custom validation logic.

## How it Works

The validation algorithm follows these steps:

1. **Input**: The program takes an array of 16 numbers.
2. **Double every second digit**: Starting from the first digit (index 0), every second digit is multiplied by 2.
3. **Sum the digits**: If the result of doubling a number is greater than or equal to 10, the program sums the digits of that number.
4. **Calculate total sum**: All numbers are then summed together.
5. **Validation**: If the total sum equals 80, the card number is deemed valid; otherwise, it is invalid.

## Example

Consider the following array of card numbers:
The steps performed are:

1. **Double every second digit**:
    - Doubling the first digit (4) → `8`
    - Doubling the third digit (3) → `6`
    - Doubling the fifth digit (8) → `16` (sum of digits → `1 + 6 = 7`)
    - Doubling the seventh digit (4) → `8`
    - Doubling the ninth digit (1) → `2`
    - Doubling the eleventh digit (7) → `14` (sum of digits → `1 + 4 = 5`)
    - Doubling the thirteenth digit (5) → `10` (sum of digits → `1 + 0 = 1`)
    - Doubling the fifteenth digit (0) → `0`

2. **Sum all digits**:
    - `8 + 1 + 6 + 7 + 7 + 9 + 8 + 7 + 2 + 1 + 5 + 5 + 1 + 9 + 0 + 4 = 80`

3. **Validation**:
    - Since the total is `80`, the card number is considered valid.

## Usage

To run the program, simply execute the C# file in your environment.

### Example Output

If the card number is valid: Valid Card Number
