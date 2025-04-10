



AddLine()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\addline.md) >>  **Navigation:**  [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Indicator](indicator-1.md) >  AddLine() | [Previous page](indicator-1.md) [Return to chapter overview](indicator-1.md) [Next page](arelinesconfigurable-1.md) |

Definition
----------

Adds line objects on a chart.

|  |
| --- |
| State.Configure. Calling AddLine() in this manner should be reserved for special cases.  Please see the examples below. |

Methods and Properties
----------------------

|  |  |
| --- | --- |
| AreLinesConfigurable | line(s) used in an indicator are configurable from within the indicator dialog window. |
| Line Class | Objects derived from the Line class are used to characterize how an oscillator line is visually displayed (plotted) on a chart. |
| Lines | A collection holding all of the Line objects that define the visualization characteristics oscillator lines of the indicator. |

Syntax
------

AddLine(Brushname)  
AddLine(Strokename)

 

|  |
| --- |
| State.Configure |

Parameters
----------

|  |  |
| --- | --- |
| brush | Brush object used to construct the line |
| name | string value representing the name of the line |
| stroke | Stroke object used to construct the line |
| value | double value representing the value the line will be drawn at |

Examples
--------

|  | Defining a single UI configurable static line |
| --- | --- |
|  | OnStateChange()  {        State.SetDefaults)  {       // Adds an oscillator line at a value of 30  );  }  } |

 

|  | Indicator which dynamically adds a line in State.Configure |
| --- | --- |
|  | OnStateChange()  {  State.SetDefaults)  {  ;     // logical property which user can set  ;  // Default brush selection pushed to the UI  Brushes.Red;  }  State.Configure)  {  // if user enables logical property  (UseSpecialMode)  {  // add line using default selected brush and special line name  );  }  else  {  // otherwise use default selected brush and regular line name  );  }  }  }        [XmlIgnore]  }     } |