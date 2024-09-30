
NinjaScript \> Language Reference \> Add On \> NumericTextBox
NumericTextBox
| \<\< [Click to Display Table of Contents](numerictextbox.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Add On](add_on-1.md) \> NumericTextBox | [Previous page](ntwindow-1.md) [Return to chapter overview](add_on-1.md) [Next page](onwindowcreated-1.md) |
| --- | --- |
NumericTextBox provides functionality for numeric text boxes to capture user input. This UI element can be defined in XAML for an AddOn if desired, with functionality and logic related to the text box defined in C\#, as in the examples below.
 
| Note:  For a complete, working example of this class in use, download framework example located on our [Developing AddOns Overview](developing_add_ons-1.md) |
| --- |

NumericTextBox inherits from [System.Windows.Controls.Textbox](https://msdn.microsoft.com/en-us/library/system.windows.controls.textbox(v=vs.110).aspx), and the following additional properties can be accessed for an instance the class:
 
| Minimum | Determines the minimum value which can be entered |
| --- | --- |
| Maximum | Determines the maximum value which can be entered |
| ValueType | Determines the System.Type which can be accepted |

## 
## 
## Examples
| ns XAML Definition of the UI Element |
| --- |
| \<!\-\- Create a grid in which to place the NumericTextBox \-\-\> \<Grid\>    \<!\-\- Define a NumericTextBox \-\-\>    \<t:NumericTextBox x:Name\="daysBackSelector" Text\="5" ValueType\="{x:Type system:Int32}" Width\="50" Grid.Column\="2"\>        \<!\-\- Set the margins for the box \-\-\>        \<t:NumericTextBox.Margin\>            \<Thickness Left\="{StaticResource MarginButtonLeft}" Top\="{StaticResource PaddingColumn}" Right\="{StaticResource MarginBase}"/\>        \</t:NumericTextBox.Margin\>    \</t:NumericTextBox\> \</Grid\> |

 
## 
| ns C\# Code Handling Logic |
| --- |
| private NumericTextBox daysBack;   private DependencyObject LoadXAML() {        // Find days back selector        daysBack \= LogicalTreeHelper.FindLogicalNode(pageContent, "daysBackSelector") as NumericTextBox; } |
