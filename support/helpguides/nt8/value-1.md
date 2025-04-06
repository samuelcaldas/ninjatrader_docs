



Value

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\value.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [PriceSeries<double>](priceseries-1.htm) >  Value | [Previous page](typicals-1.htm) [Return to chapter overview](priceseries-1.htm) [Next page](values-1.htm) |

Definition
----------

A collection of historical references to the first ISeries object Values[0] in the indicator. This is the primary indicator value (synched to the primary series in case of a [MultiSeries](multi-time_frame__instruments-1.htm) indicator)

Property Value
--------------

An ISeries<double> object.

Syntax
------

Value

Examples
--------

| ns |
| --- |
| // OnBarUpdate method of a custom indicator  protected override void OnBarUpdate()  {       // Ensures we have enough bars loaded for our indicator       if (CurrentBar < 1)           return;          // Evaluates the indicator primary value 1 bar ago and sets the value of the indicator       // for the current bar being evaluated       if (Value[1] < High[0] - Low[0])           Value[0] = High[0] - Low[0];       else           Value[0] = High[0] - Close[0];  } |