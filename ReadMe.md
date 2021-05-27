# Raindrops

Write a function that takes an input number (n) and returns a string, the contents of which depend on the numbers factors:

- If the number has a factor of 3, output 'Pling'
- If the number has a factor of 5, output 'Plang'
- If the number has a factor of 7, output 'Plong'
- If the number does not have any of the above as a factor simply return the numbers digits

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'

Also need to write tests to cover expected range of inputs and outputs. Ensuring the tests are covering edge cases.

## Method Body

![MethodBody](/Images/MethodBody.png)

The above Image shows the Method solution for PlingPlangPlong. The method itself is simple enough, as described earlier the method takes an input of a number (n) and returns a string depending on the numbers factors. 

The method uses a string builder to append the results onto as numbers are able to have multiple factors. It then checks if the number given is a factor of 3, 5 and 7 and if so appends the appropriate word onto the string. If the number has no factors the string will have the number appended to it. 

This is done through a series of IF statements using the modulus operator. This checks if the remainder is 0 and if so it is then a factor of that number and has the corresponding string appended to the string builder. The reason this is done with multiple if statements is to check each factor against the number input to allow for numbers with multiple factors.

## Tests

The test framework I have used for this is NUnit. This will allow me to write tests to ensure that the method itself works as intended. Throughout my tests I will be abiding by the best practices and ensuring that the naming of the tests follows this. The naming standards I will be following are documented here (https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices) but are also as follows.

The name of the tests should consist of three parts:

- The name of the method being tested
- The scenario under which is being tested
- The expected behaviour when the scenario is invoked 

![BasicUnitTests](/Images/BasicUnitTests.png)

The above is the first tests I wrote to test the "basic" functionality of the method. These tests are checking all of the IF statements within the method and are ensuring the correct string is returned when the value is passed. These tests simply input a number that is a factor of 3, 5 or 7 and check if the returned string is correct. The final test the checks if the number is returned as a string if the number given is not a factor.

As you can see by the test explorer on the left hand side all these tests pass.

