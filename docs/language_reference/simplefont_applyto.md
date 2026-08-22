# ApplyTo()

## Definition

Applies a custom [SimpleFont](simplefont_class.md) object's properties (family, size, and style) to a [Windows Control](https://msdn.microsoft.com/en-us/library/system.windows.controls.control(v=vs.110).aspx)

## Method Return Value

## This method does not return a value.

## Syntax

<SimpleFont>.ApplyTo(DependencyObject target)

| Name / Option | Description |
| --- | --- |
| target | The [DependencyObject](https://msdn.microsoft.com/en-us/library/system.windows.dependencyobject(v=vs.110).aspx) to apply the SimpleFont object |

## Examples

![Ns](../images/ns.png)

```csharp
// Define the custom button control object
System.Windows.Controls.Button myButton = new System.Windows.Controls.Button
{
    Name = "myButton",
    Content = "Buy",
    Foreground = Brushes.White,
    Background = Brushes.Green,
};
// Create a custom SimpleFont object and then apply it to the button
SimpleFont myFont = new SimpleFont("Consolas", 22);
myFont.ApplyTo(myButton);
```