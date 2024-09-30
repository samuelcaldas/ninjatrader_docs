
NinjaScript \> Language Reference \> Market Analyzer Column \> DataType
DataType
| \<\< [Click to Display Table of Contents](datatype.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Market Analyzer Column](market_analyzer_column-1.md) \> DataType | [Previous page](currentvalue-1.md) [Return to chapter overview](market_analyzer_column-1.md) [Next page](formatdecimals-1.md) |
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

