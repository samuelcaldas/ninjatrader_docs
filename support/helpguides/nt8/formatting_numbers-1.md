
NinjaScript > Educational Resources > Tips > Formatting numbers

Formatting numbers

| << [Click to Display Table of Contents](formatting_numbers.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Educational Resources](educational_resources-1.md) > [Tips](tips-1.md) > Formatting numbers | [Previous page](floating-point_arithmetic-1.md) [Return to chapter overview](tips-1.md) [Next page](how_do_i_resolve_ninjascript_p-1.md) |
| --- | --- |
String formatting on numbers is very useful for creating readable output. This can be done through the use of the number object's ToString() method.
 
A common practice is printing out mathematical operations with the use of the ToString() method on the double object. What usually happens is the printing of a long string containing all the decimal places existing in the double. This sometimes makes output cluttered and hard to read. Luckily, C# has a robust set of string formatting options available to make the string more comprehendible.
 
Here is a list of common formatting options available in the ToString() method:

| ns |
| --- |
| double c = 10.25693; Print("No formatting: " + c.ToString()); Print("Currency formatting: " + c.ToString("C")); Print("Exponential formatting: " + c.ToString("E")); Print("Fixed-point formatting: " + c.ToString("F2")); Print("General formatting: " + c.ToString("G")); Print("Percent formatting: " + c.ToString("P0")); Print("Formatted to 2 decimal places: " + c.ToString("N2")); Print("Formatted to 3 decimal places: " + c.ToString("N3")); Print("Formatted to 4 decimal places: " + c.ToString("N4")); |
 
The corresponding output is as follows:

| ns |
| --- |
| No formatting: 10.25693 Currency formatting: $10.26 Exponential formatting: 1.025693E+001 Fixed-point formatting: 10.26 General formatting: 10.25693 Percent formatting: 1,026 % Formatted to 2 decimal places: 10.26 Formatted to 3 decimal places: 10.257 Formatted to 4 decimal places: 10.2569 |
 
For custom formatting you can use the following:

| ns |
| --- |
| double phoneNumber = 9165551022; Print("Phone number: " + phoneNumber.ToString("(###) ### - ####")); |
 
Corresponding output:

| ns |
| --- |
| Phone number: (916) 555 - 1022 |
 
For more information on general string formatting the Microsoft documentation may be of use. Many other resources can be found online through a Google search as well.
[https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
[https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings) 
