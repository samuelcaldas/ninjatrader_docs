


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> IsValidDataPoint()






















IsValidDataPoint()







| \<\< [Click to Display Table of Contents](isvaliddatapoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> IsValidDataPoint() | [Previous page](getvalueat.md) [Return to chapter overview](iseriest.md) [Next page](isvaliddatapointat.md) |
| --- | --- |











## Definition


Indicates if the specified input is set at a barsAgo value relative to the current bar.  Please also see the [Reset()](reset.md) method for more information.


 




| Notes:  •If called directly from the instance of the NinjaScript object, the value returned corresponds to the Input Series (e.g., Close, High, Low, SMA, etc.)•When checking a [Bar](bars.md) or [PriceSeries](priceseries.md), IsValidDataPoint() returns true as long as the barAgo value falls between 0 and the total count for that series.  These are special series which always contain a value set at every slot index for multi\-series scripting purposes (e.g., comparing two price series with various session templates, or one series has more ticks than the other)•For a [Value](value.md) series or custom [Series\<T\>](seriest.md), IsValidDataPoint() returns true or false depending on if you have set a value at that index location |
| --- |



 


 


## Method Return Value


A bool value, when true indicates that specified data point is set; otherwise false.


 


## Syntax


IsValidDataPoint(int barsAgo)


ISeries\<T\>.IsValidDataPoint(int barsAgo)


 




| Warning:  Calling IsValidDataPoint() will only work a MaximumBarsLookBackInfinite series.  Attempting to check IsValidDataPoint() MaximumBarsLookBack256 series throw an error.  Please check the Log tab of the Control Center. In addition since this method references BarsAgo data, and therefore cannot be used during [OnRender (see note 5\)](onrender.md).\- instead please use the [IsValidDataPointAt](isvaliddatapointat.md) during OnRender. |
| --- |



 


   

Parameters




| barsAgo | An int representing from the current bar the number of historical bars the method will check. |
| --- | --- |



 


 


## Examples




| ns |
| --- |
| protected override void OnBarUpdate() {    // only set plot value if hosted indicator is not reset    if(SMA(20).IsValidDataPoint(0))      MyPlot\[0] \= SMA(20)\[0];      } |









