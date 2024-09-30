
NinjaScript \> Language Reference \> Market Analyzer Column \> DataType
DataType
| \<\< [Click to Display Table of Contents](datatype.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Market Analyzer Column](market_analyzer_column.md) \> DataType | [Previous page](currentvalue.md) [Return to chapter overview](market_analyzer_column.md) [Next page](formatdecimals.md) |
| --- | --- |
## Definition
Determines the data type displayed in a Market Analyzer Column.
 
## Syntax
DataType
## 
## Example
| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {           DataType   \= typeof(string);           IsEditable \= true;      } } |

