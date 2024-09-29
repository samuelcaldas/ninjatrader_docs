


NinjaScript \> Language Reference \> Strategy \> OnPositionUpdate()






















OnPositionUpdate()







| \<\< [Click to Display Table of Contents](onpositionupdate.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Strategy](strategy.md) \> OnPositionUpdate() | [Previous page](onorderupdate.md) [Return to chapter overview](strategy.md) [Next page](optimizationperiod.md) |
| --- | --- |











## Definition


An event driven method which is called each time a PositionUpdate is received for the strategy.


## 


•This method is typically called after [OnExecutionUpdate()](onexecutionupdate.md)

•OnPositionUpdate() will update with PositionUpdates that are filtered for the strategy. The strategy [Position](position.md) object is driven by Executions, and is updated as early as [OnExecutionUpdate()](onexecutionupdate.md)

 




| Notes:    •You will NOT receive position updates for manually placed orders, or orders managed by other strategies (including any [ATM strategies](using_atm_strategies.md)) in OnPositionUpdate(). The Account class contains a pre\-built event handler ([PositionUpdate](positionupdate.md)) which can be used to filter position updates on a specified account.  •Its best practice to only work with the passed by value parameters and not reference parameters. This insures that you process each change of the underlying state. •Rithmic and Interactive Brokers Users: When using a NinjaScript strategy it is best practice to only work with passed by value data from OnExecution. Instances of multiple fills at the same time for the same instrument might result in an incorrect OnPositionUpdate, as sequence of events are not guaranteed due to provider API design. For an example on protecting positions with this approach, see [OnExecutionUpdate()](onexecutionupdate.md) |
| --- |



 


 


## Method Return Value


This method does not return a value.


 


## Syntax
You must override the method in your strategy with the following syntax:


 


protected override void OnPositionUpdate(Position position, double averagePrice, int quantity, MarketPosition marketPosition)  

{  

      

}    


 


 


## Method Parameters




| position | A [Position](position.md) object passed by reference representing the current position object |
| --- | --- |
| averageFillPrice | A double value representing the updating average fill price of a position |
| quantity | An int value representing the updating quantity of a position |
| marketPosition | A [MarketPosition](position_marketposition.md) object representing the updating position update provided directly from the broker. This is not the actual Position core position object, but the last change of the market position    Possible values are:   •MarketPosition.Flat•MarketPosition.Long•MarketPosition.Short |



## 


 


## Examples




| ns |
| --- |
| protected override void OnPositionUpdate(Cbi.Position position, double averagePrice,        int quantity, Cbi.MarketPosition marketPosition) {    if (position.MarketPosition \=\= MarketPosition.Flat)    {      // Do something like reset some variables here    } } |



 




| ns |
| --- |
| protected override void OnPositionUpdate(Cbi.Position position, double averagePrice,        int quantity, Cbi.MarketPosition marketPosition) {    Print("The most current MarketPosition is: " \+ position.MarketPosition);   // Flat    Print("This particular position update marketPosition is: " \+ marketPosition); // Long } |



   

Additional Reference Samples  

Additional reference code samples are available the NinjaScript Educational Resources section of our support forum.








