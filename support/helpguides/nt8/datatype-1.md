



DataType

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\datatype.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Market Analyzer Column](market_analyzer_column-1.htm) >  DataType | [Previous page](currentvalue-1.htm) [Return to chapter overview](market_analyzer_column-1.htm) [Next page](formatdecimals-1.htm) |

Definition
----------

Determines the data type displayed in a Market Analyzer Column.

Syntax
------

DataType

Example
-------

| ns |
| --- |
| protected override void OnStateChange()  {      if (State == State.SetDefaults)      {           DataType   = typeof(string);            IsEditable = true;      }  } |