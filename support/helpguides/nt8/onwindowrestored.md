﻿
NinjaScript > Language Reference > Add On > OnWindowRestored()

OnWindowRestored()

| << [Click to Display Table of Contents](onwindowrestored.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > OnWindowRestored() | [Previous page](onwindowdestroyed.md) [Return to chapter overview](add_on.md) [Next page](onwindowsaved.md) |
| --- | --- |
## Definition
Called when the window is restored from a workspace, which is called after [OnWindowCreated()](onwindowcreated.md).  This method is used to recall any custom XElement data from the workspace by referencing a window.   Please also see [OnWindowSaved()](onwindowsaved.md) for information on how to store custom XElement data when a window is saved.
## 
## Method Return Value
This method does not return a value
 
## Syntax
OnWindowRestored(Window window, XElement element)
 
## Parameters

| window | A [Window](https://msdn.microsoft.com/en-us/library/system.windows.window(v=vs.110).aspx) object which is being restored from a workspace |
| --- | --- |
| element | The [XElement](https://msdn.microsoft.com/en-us/library/system.xml.linq.xelement(v=vs.110).aspx) object representing the workspace being restored |
## 
## 
## Examples

| ns |
| --- |
| protected override void OnWindowRestored(Window window, XElement element) {       Print("OnWindowRestored for " + window.GetHashCode());       // locate the worksapces "SampleAddOn" elemenet which was created and saved earlier using the OnWindowSaved() method    XElement sampleAddOnElement = element.Element("SampleAddOn");      // do not do anything if that element does not exist    if (sampleAddOnElement == null)      return;        // loop through all the contents of the "SampleAddOn" element    foreach (XElement content in sampleAddOnElement.Elements())    {        // find the "ButtonState" content, restore it's value and set that as our tracked buttonState        if (content.Name == "ButtonState")        {            bool buttonState = false;            bool.TryParse(content.Value, out buttonState);              continue;        }        //Parse additional elements here    }      //Don't forget to call the base OnWindowRestored method after you're done.      base.OnWindowRestored(window, element); } |
