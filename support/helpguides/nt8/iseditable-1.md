
NinjaScript > Language Reference > Market Analyzer Column > IsEditable
IsEditable
| << [Click to Display Table of Contents](iseditable.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Market Analyzer Column](market_analyzer_column-1.md) > IsEditable | [Previous page](formatdecimals-1.md) [Return to chapter overview](market_analyzer_column-1.md) [Next page](onrender2-1.md) |
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
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {           DataType   = typeof(string);           IsEditable = true;      } } |
