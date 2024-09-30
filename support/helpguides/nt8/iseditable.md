
NinjaScript \> Language Reference \> Market Analyzer Column \> IsEditable
IsEditable
| \<\< [Click to Display Table of Contents](iseditable.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Market Analyzer Column](market_analyzer_column.md) \> IsEditable | [Previous page](formatdecimals.md) [Return to chapter overview](market_analyzer_column.md) [Next page](onrender2.md) |
| --- | --- |
## Definition
Determines if a Market Analyzer Column is editable.
 
## Property Value
This property returns true if the Market Analyzer Column can be edited; otherwise, false.
 
## Syntax
IsEditable
## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           DataType   \= typeof(string);           IsEditable \= true;      } } |
