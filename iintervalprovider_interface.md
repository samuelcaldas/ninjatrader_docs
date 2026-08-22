# IIntervalProvider Interface

When creating your [NTTabPage](nttabpage_class.md), if you wish to use the [interval link](linking_windows.md), be sure to implement the IIntervalProvider interface.

## Examples

```csharp
public class MyWindowTabPage : NTTabPage, IIntervalProvider
{
    public MyWindowTabPage()
    {
        /\* Define the content for our NTTabPage. We can load loose XAML to define controls and layouts
        if we so choose here as well.
        Note: XAML with event handlers defined inside WILL FAIL when attempted to load.
        Note: XAML with "inline code" WILL FAIL when attempted to load \*/
    }
    // IIntervalProvider member
    public BarsPeriod BarsPeriod { get; set; }
    // Be sure to include all the required NTTabPage members as well
}
```
