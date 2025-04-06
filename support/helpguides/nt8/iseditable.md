



IsEditable

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](iseditable.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Market Analyzer Column](market_analyzer_column.htm) >  IsEditable | [Previous page](formatdecimals.htm) [Return to chapter overview](market_analyzer_column.htm) [Next page](onrender2.htm) |

Definition
----------

Determines if a Market Analyzer Column is editable.

Property Value
--------------

This property returns true if the Market Analyzer Column can be edited; otherwise, false.

Syntax
------

IsEditable

Example
-------

| ns |
| --- |
| protected override void OnStateChange()  {      if (State == State.SetDefaults)      {           DataType   = typeof(string);            IsEditable = true;      }  } |