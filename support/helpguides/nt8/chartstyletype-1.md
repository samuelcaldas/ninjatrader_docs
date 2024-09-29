


NinjaScript \> Language Reference \> Chart Style \> ChartStyleType






















ChartStyleType







| \<\< [Click to Display Table of Contents](chartstyletype.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Chart Style](chart_style-1.md) \> ChartStyleType | [Previous page](barwidthui-1.md) [Return to chapter overview](chart_style-1.md) [Next page](downbrush-1.md) |
| --- | --- |











## Definition


Defines a unique identifier value used to register a custom ChartStyle.  There are 11 default ChartStyles which come with NinjaTrader which are reserved per the table on this page under the Parameters section of this page.


 




| Note: The ChartStyle property can allow a large number of ChartStyles to be registered on a single user's installation (up to 2,147,483,647\).  However it's important to note that it is still possible for two installed ChartStyles on a user's computer to conflict should they be register to the same enumerator value. In this case, NinjaTrader will ignore the conflicting ChartStyle type and information pertaining to this conflict will be displayed on the [Log tab](log_tab2-1.md) of the  NinjaTrader Control Center.   Added 1/31/2018 : We advise users to use values larger then 1023 when selecting an enum. As NinjaTrader from time to time may add a new enum value in that range which may cause conflicts. |
| --- |



 


## Property  Value


A enum value representing the ChartStyle to be registered. 


 




| Tip: It is recommended to pick high, unique enumeration value to avoid conflict from other ChartStyles that may be used by a single installation. |
| --- |



 


## Syntax


You must cast ChartStyleType from an int using the following syntax:


(ChartStyleType) 80;


 


## Parameters


Reserved enumeration values are listed below:


 




| 0 | Box |
| --- | --- |
| 1 | CandleStick |
| 2 | LineOnClose |
| 3 | OHLC |
| 4 | PointAndFigure |
| 5 | KagiLine |
| 6 | OpenClose |
| 7 | Mountain |
| 8 | Volumetric |
| 9 | HollowCandleStick |
| 10 | Equivolume |



## 


 


## Examples




| ns |
| --- |
| protected override void OnStateChange() {    if (State \=\= State.SetDefaults)    {      Name           \= "Example ChartStyle";                  ChartStyleType \= (ChartStyleType) 80;      BarWidth       \= 1;    } } |









