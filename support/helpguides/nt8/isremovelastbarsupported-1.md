


NinjaScript \> Language Reference \> Bars Type \> IsRemoveLastBarSupported






















IsRemoveLastBarSupported







| \<\< [Click to Display Table of Contents](isremovelastbarsupported.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Bars Type](bars_type-1.md) \> IsRemoveLastBarSupported | [Previous page](icon_barstype-1.md) [Return to chapter overview](bars_type-1.md) [Next page](barstype_istimebased-1.md) |
| --- | --- |











## Definition


Determines if the bars type can use the [RemoveLastBar()](removelastbar-1.md) method when true, otherwise an exception will be thrown. Bar Types which use remove last bar concepts CANNOT be used with [Tick Replay](tick_replay-1.md), and as a result Tick Replay will be disabled on the UI when IsRemoveLastBarSupported is set to true.


## 




| Note:  This property is read\-only, but may be overridden in a custom bar type. |
| --- |



 


 


## Syntax


IsRemoveLastBarSupported


 


## Property value


A bool determining if the BarsType can remove the last; default value is false.


## 


## Examples




| ns |
| --- |
| // allows RemoveLastBar() to be called public override bool IsRemoveLastBarSupported { get { return true; } } |









