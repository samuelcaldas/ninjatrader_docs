


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> IsValidDataPointAt()






















IsValidDataPointAt()







| \<\< [Click to Display Table of Contents](isvaliddatapointat.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [ISeries\<T\>](iseriest-1.md) \> IsValidDataPointAt() | [Previous page](isvaliddatapoint-1.md) [Return to chapter overview](iseriest-1.md) [Next page](maximumbarslookback-1.md) |
| --- | --- |











## Definition


Indicates if the specified input is set at a specified bar index value.  Please also see the [Reset()](reset-1.md) method for more information.


 




| Notes:  •If called directly from the instance of the NinjaScript object, the value returned corresponds to the Inputs Series (e.g., Close, High, Low, SMA, etc.)•When checking a [Bar](bars-1.md) or [PriceSeries](priceseries-1.md), IsValidDataPoint() returns true as long as the barIndex value falls between 0 and the total count for that series.  These are special series which always contain a value set at every slot index for multi\-series scripting purposes (e.g., comparing two price series with various session templates, or one series has more ticks than the other)•For a [Value](value-1.md) series or custom [Series\<T\>](seriest-1.md), IsValidDataPoint() returns true or false depending on if you have set a value at that index location |
| --- |



 


## 


## Method Return Value


A bool value, when true indicates that specified data point is set; otherwise false.


 




| Warning:  Calling IsValidDataPointAt() will only work a MaximumBarsLookBackInfinite series.  Attempting to check IsValidDataPointAt() MaximumBarsLookBack256 series throw an error.  Please check the Log tab of the Control Center |
| --- |



 


 


## Syntax


IsValidDataPointAt(int barIndex)


ISeries\<T\>.IsValidDataPointAt(int barIndex)


   

Parameters




| barIndex | An int representing an absolute bar index value |
| --- | --- |



## 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // only set plot value if hosted indicator is not reset    if(SMA(20).IsValidDataPointAt(CurrentBar))      MyPlot\[0] \= SMA(20)\[0];      } |









