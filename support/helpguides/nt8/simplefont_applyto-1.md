﻿
NinjaScript > Language Reference > Common > SimpleFont > ApplyTo()

ApplyTo()

| << [Click to Display Table of Contents](simplefont_applyto.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [SimpleFont](simplefont_class-1.md) > ApplyTo() | [Previous page](simplefont_class-1.md) [Return to chapter overview](simplefont_class-1.md) [Next page](simplefont_todirectwritetextformat-1.md) |
| --- | --- |
## Definition
Applies a custom [SimpleFont](simplefont_class-1.md) object's properties (family, size, and style) to a [Windows Control](https://msdn.microsoft.com/en-us/library/system.windows.controls.control(v=vs.110).aspx)
## 
## Method Return Value
## This method does not return a value.
 
## Syntax
<SimpleFont>.ApplyTo(DependencyObject target)
 

| target | The [DependencyObject](https://msdn.microsoft.com/en-us/library/system.windows.dependencyobject(v=vs.110).aspx) to apply the SimpleFont object |
| --- | --- |

## Examples

| ns |
| --- |
| // Define the custom button control object System.Windows.Controls.Button myButton = new System.Windows.Controls.Button {    Name = "myButton",    Content = "Buy",    Foreground = Brushes.White,    Background = Brushes.Green, };   // Create a custom SimpleFont object and then apply it to the button SimpleFont myFont = new SimpleFont("Consolas", 22);   myFont.ApplyTo(myButton); |
