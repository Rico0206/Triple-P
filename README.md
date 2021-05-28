# Project Goals

The Project Goals Where As Follows -

Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of 3, output 'Pling'
- if the number has a factor of 5, output 'Plang'
- if the number has a factor of 7, output 'Plong'
- if the number does not have any of the above as a factor simply return the numbers digits

Create tests to provide as much coverage as many possible roots as possible

## Tools Used

**Tools** used for this project are 

- Nunit - a unit testing framework for all .NET languages with a strong TDD focus. Nunit was chosen because it is my favoured testing framework, along with the fact that I am accustomed  to Nunit more benefits  include its fast testing time which is a blessing for testers with multiple test and its is open source with very good support which works for this project

- Windows - Operating System developed and published by Microsoft. Although it is now cross platform .NET is originally made for windows.

- Visual Studio 2019 (Community) - is an *IDE* that has a creative launching pad that can be used to edit, debug, and build code.  favoured IDE for obvious reasons but some benefits include Windows-based programming tools, .NET go to developing instrument and VS is well structured, easy-to-use interface.

- Typora - favoured markdown editor / markdown reader. Personal favourite md reader / writer, it has a minimalist feel to it and is clear and concise.

- .Net 5.0 - a cross platform and open-source development platform.

# Program

The program consists of a  single simple method that consists of a single method that takes in an integer input and returns a string based on the condition that it has a factor of 3, 5 or 7.

`public static string Plong(int input)` => code snippet shows integer input, method has been made static because that there is no need to instantiate as this will only ever be used for testing.

`string ans = null;` => string declared as null to be changed depending on the conditions that are met, could have used a string builder but for the purpose, focus of this exercise concatenating the string `ans` is the simplest way to get the desired effect.

`if (input % 3 == 0)
 {
	ans += "Pling";
 }
if (input % 5 == 0)
 {
	ans += "Plang";
 }
	if (input % 7 == 0)
 {
	ans += "Plong";
``}`

The above snippet shows the main body of the method which shows the conditions and their outcomes. the project goal is to find out if the input is a factor of 3,5 and 7. a factor is simply a multiple of, therefore using the modulus sign we can find the remainder of the number and if it is equal to 0 then it is in-fact a factor of and should be concatenated onto by the relevant condition and passed onto the next condition.

`return _ = ans ?? (_ = input.ToString());` => The is the final condition and return statement all in one using a ternary conditional operator. This final condition un-simplified states that if `ans ` is null then turn input into a string and make `ans` equal to input, therefore returning a string version of the input.

# Tests

For the testing of this project I have attempted to follow good testing conventions for clear, readable and understandable code

I have tried to follow the 5 characteristics of a good test

- **Fast**. 
- **Isolated**.
- **Repeatable**. 
- **Self-Checking**. 
- **Timely**. 

## Code coverage

The name of your test should consist of three parts:

- The name of the method being tested.
- The scenario under which it's being tested.
- The expected behavior when the scenario is invoked.



- Naming standards are important because they explicitly express the intent of the test.

Arrange 

Act 

Assert



### Avoid multiple asserts

When writing your tests, try to only include one Assert per test. Common approaches to using only one assert include:

- Create a separate test for each assert.
- Use parameterized tests.

# Comments