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

For the testing of this project I have attempted to follow good testing conventions for clear, readable and understandable code, during the process I have tried to employ some characteristics of a good test which are;  

- **Fast**  => A good test case is one that doesn’t take long to run
- **Isolated**  => An isolated test suite contains tests that run without impacting other tests in the suite.  
- **Expressive** => The easy-to-read nature of test cases make them a great form of documentation. tests should always be descriptive of the features that are being tested.
- **Maintainable** => The best way to keep tests maintainable is to be organized, follow coding best practices, and develop a consistent process that works!
- **Reliable** => A reliable test suite is one that provides consistent feedback, regardless of changes that may occur outside the scope of a given test. An unreliable test suite may have tests that fail intermittently, with no helpful feedback about changes that haver been made in the applications.
- **Repeatable** => Test code should be repeatable for methods or paths with the same or similar outcomes in order to save time.

```c#
 `[Test]
        public void Plong_IfNumberEnteredEqualsZero_ReturnPlingPlangPlong()
        {
            Assert.That("PlingPlangPlong", Is.EqualTo(Plang.Plong(0)));
        }`  
```

When testing I was focused more on coverage and quality. the above test gives an idea of the coverage I was trying to achieve. Starting my tests off at an input of 0 gives a good base on which to begin the testing.

The below test shows my minimalist approach to these tests. by minimalist I am referring to the low number I have put to start the testing of this particular path. By using the simplest possible number I can verify the behaviour that I am currently testing.

```c#
`[TestCase(-1, "-1")]
        [TestCase(-1, "-1")]
        [TestCase(34, "34")]
        [TestCase(-34, "-34")]
        [TestCase(19, "19")]
        public void Plong_IfNumberHasNoRelevantFactor_ReturnNumber(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }`
```

This is an example of repeatable code in tests as you can see the code above and below is almost identical with only a small amount of minor differences, differences include the test case numbers and expected numbers, other than that the skeleton of the unit tests remain the same.

Note - The name has also changed, where I was going along with the three step naming system before; The name of the method being tested, The scenario under which it's being tested, The expected behaviour when the scenario is invoked. The cases following this will omit the name of the method being tested, this Is because there is only 1 method being tested and therefore there is no need to continue to add the method name as it just adds more characters to the document. That being said in any normal project the name of the method is vital and should not be omitted.

```c#
[TestCase(5, "Plang")]
        [TestCase(-5, "Plang")]
        [TestCase(25, "Plang")]
        [TestCase(-25, "Plang")]
        public void IfNumberHasAFactorOf5_ReturnPlang(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }`

`[TestCase(-7, "Plong")]
        [TestCase(7, "Plong")]
        [TestCase(49, "Plong")]
        [TestCase(-49, "Plong")]
        public void IfNumberHasAFactorOf7_ReturnPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }
```

I have used `[TestCase]`  in these test instead of the  `[Test]` used in the first test for readability and efficiency purposes, without the use if `TestCase` the work space would be crowded because of the sheer number of unit tests for each case. By doing this I have avoided multiple asserts whilst using parameterized tests making code as clean as possible so that even a non programmer can understand what is happening

Note - I have gone with the constraint-based Assert model which uses a single method of the Assert class for all assertions. The logic necessary to carry out each assertion is embedded in the constraint object passed as the second parameter to that method. I have chosen this over the classic model because it simplifies everything into 1 single universal assertion method and even though it may be irrelevant in this context it provides more information on the error than the normal `Assert..AreEqual` and is a good habit to get into for future adventures.

***Below are a few more cases to show coverage of different paths***

```c#
`//All 3 Together
        [TestCase(105, "PlingPlangPlong")]
        [TestCase(-105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        [TestCase(-210, "PlingPlangPlong")]
        public void IfNumberHasAFactorOf357_ReturnPlingPlangPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }`
```

```c#
`[TestCase(35, "PlangPlong")]
        [TestCase(-35, "PlangPlong")]
        [TestCase(140, "PlangPlong")]
        [TestCase(-140, "PlangPlong")]
        public void IfNumberHasAFactorOf5_7_ReturnPlangPlong(int input, string expectedResult)
        {
            var result = Plang.Plong(input);
            Assert.That(expectedResult, Is.EqualTo(result));
        }`      
```



# Comments