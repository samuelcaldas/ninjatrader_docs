# NTMessageBoxSimple.Show()

﻿

    NinjaScript > Language Reference > Add On > NTMessageBoxSimple.Show()

NTMessageBoxSimple.Show()

## Definition

Creates a message box window.

 

[](https://docs.microsoft.com/en-us/dotnet/api/system.windows.messagebox?view=netframework-4.8)

> **Note:** For more information on using MessageBox windows, please see  .NET MessageBox Class Documentation

 

## Method Return Value

MessageBoxResult; an enum representing the button press used to close the MessageBox window

 

## Syntax

NTMessageBoxSimple.Show(Window input, string messageTxt, string caption, MessageBoxButton buttonSet, MessageBoxImage icon)

 

##  

Parameters

| parent | A Window (DependencyObject) which represents the owning window |
| --- | --- |
| messageTxt | The message body of the MessageBox window |
| caption | The header of the MessageBox window |
| buttonSet | A MesageBoxButton enum determining the buttons used for the MessageBox window |
| icon | A MesageBoxImage enum determining the icon used for the MessageBox window |

##  

 

## Examples

##

|  |
| --- |
| // Create a MessageBox window from a Chart<br>ChartControl.Dispatcher.InvokeAsync(new Action(() => {      <br>   NinjaTrader.Gui.Tools.NTMessageBoxSimple.Show(Window.GetWindow(ChartControl.OwnerChart as DependencyObject), "Message Body", "Message Header", MessageBoxButton.OK, MessageBoxImage.None);<br>})); |

 

##

|  |
| --- |
| // Create a MessageBox window from a button press in an AddOn<br>private void OnMenuItemClick(object sender, RoutedEventArgs e)<br>{<br>    NinjaTrader.Gui.Tools.NTMessageBoxSimple.Show(Window.GetWindow(e.Source as DependencyObject), "Message Body", "Message Header", MessageBoxButton.OK, MessageBoxImage.None);<br>} |