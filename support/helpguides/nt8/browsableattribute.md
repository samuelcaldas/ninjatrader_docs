﻿
NinjaScript > Language Reference > Common > Attributes > BrowsableAttribute
BrowsableAttribute
| << [Click to Display Table of Contents](browsableattribute.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > [Attributes](attributes.md) > BrowsableAttribute | [Previous page](attributes.md) [Return to chapter overview](attributes.md) [Next page](categoryorderattribute.md) |
| --- | --- |
## Definition
Determines if the following declared property displays in the NinjaTrader UI's property grid.  By default, all public properties in a NinjaScript object display, however this behavior can be changed by setting the Browsable attribute to false.
 
| Note: The BrowsableAttribute object is a general purpose attribute made available from the .NET Framework. The information on this page is written to demonstrate how you may use this object within NinjaScript conventions used with the NinjaTrader UI's property grid (e.g., an indicator dialog).  There are more methods and properties that you can learn about from MSDN's [BrowsableAttribute Class](https://msdn.microsoft.com/en-us/library/system.componentmodel.browsableattribute(v=vs.110).aspx) which are NOT covered in this topic; as such there is NO guarantee they will work with the NinjaTrader UI's property grids. |
| --- |

## Syntax
[Browsable(bool)]
 
## Parameters
## A bool which sets a value indicating if a property is browsable; default value is true
## 
## Examples
| ns |
| --- |
| #region Properties      // do not show this value on the UI's property grid [Browsable(false)] public bool MyBool    { get; set; }   #endregion |

