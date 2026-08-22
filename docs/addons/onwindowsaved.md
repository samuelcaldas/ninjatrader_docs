# OnWindowSaved()

## Definition

Called when the window is saved to a workspace, which is called before [OnWindowDestroyed()](onwindowdestroyed.md).  This method is used to save any custom XElement data associated with your window.

## Method Return Value

This method does not return a value

## Syntax

## OnWindowSaved(Window window, XElement element)

 

## Parameters

| Name / Option | Description |
| --- | --- |
| window | A [Window](https://msdn.microsoft.com/en-us/library/system.windows.window(v=vs.110).aspx) object which is being saved to the workspace |
| element | A [XElement](https://msdn.microsoft.com/en-us/library/system.xml.linq.xelement(v=vs.110).aspx) object representing the workspace being saved |

## Examples

![Ns](../images/ns.png)

```csharp
protected override void OnWindowSaved(Window window, XElement element)
{
    Print("OnWindowSaved for " + window.GetHashCode());
    // create a new XElement to save the last state of a custom button to the workspace
    XElement xml = new XElement("SampleAddOn", new XElement("ButtonState", true));
    // e.g.,
    // <SampleAddOn>
    //
    <ButtonState>true</ButtonState>
    // </SampleAddOn>
    // add the new element to the workspace which can be restored later
    element.Add(xml);
    //Don't forget to call the base OnWindowSaved method after you've finished your operation.
    base.OnWindowSaved(window, element);
}
```