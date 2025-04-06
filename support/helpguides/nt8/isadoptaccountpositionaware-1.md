



IsAdoptAccountPositionAware

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\isadoptaccountpositionaware.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Strategy](strategy-1.htm) >  IsAdoptAccountPositionAware | [Previous page](includetradehistoryinbacktest-1.htm) [Return to chapter overview](strategy-1.htm) [Next page](isexitonsessionclosestrategy-1.htm) |

Definition
----------

Determines if the strategy is programmed in a manner capable of handling  real-world account positions. Once set to true, your strategy's "[Start behavior](startbehavior-1.htm)" options will include an additional parameter named "Adopt account position" which can bet set at run-time.  Only set to true if you have specifically programmed your strategy to be able to adopt account positions.

Property Value
--------------

This property returns true if the strategy can adopt account positions; otherwise, false. Default is set to false.

|  |
| --- |
| Note:  This property should ONLY be set from the [OnStateChange()](onstatechange-1.htm) method during State.SetDefaults. |

Syntax
------

IsAdoptAccountPositionAware

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)       {           IsAdoptAccountPositionAware = true;       }  } |