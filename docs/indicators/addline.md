# AddLine()

## Definition

Adds line objects on a chart.

```csharp
State.Configure. Calling AddLine() in this manner should be reserved for special cases.
Please see the examples below.
```
## Methods and Properties

| Name / Option | Description |
| --- | --- |
| AreLinesConfigurable | line(s) used in an indicator are configurable from within the indicator dialog window. |
| Line Class | Objects derived from the Line class are used to characterize how an oscillator line is visually displayed (plotted) on a chart. |
| Lines | A collection holding all of the Line objects that define the visualization characteristics oscillator lines of the indicator. |

## Syntax

AddLine(Brushname)  
AddLine(Strokename)

 

> State.Configure

## Parameters

| Name / Option | Description |
| --- | --- |
| brush | Brush object used to construct the line |
| name | string value representing the name of the line |
| stroke | Stroke object used to construct the line |
| value | double value representing the value the line will be drawn at |

## Examples

![Ns](../images/ns.png)

![Ns](../images/ns.png)

|  | Defining a single UI configurable static line |
| --- | --- |
|  | OnStateChange()  {        State.SetDefaults)  {       // Adds an oscillator line at a value of 30  );  }  } |

 

|  | Indicator which dynamically adds a line in State.Configure |
| --- | --- |
|  | OnStateChange()  {  State.SetDefaults)  {  ;     // logical property which user can set  ;  // Default brush selection pushed to the UI  Brushes.Red;  }  State.Configure)  {  // if user enables logical property  (UseSpecialMode)  {  // add line using default selected brush and special line name  );  }  else  {  // otherwise use default selected brush and regular line name  );  }  }  }        [XmlIgnore]  }     } |