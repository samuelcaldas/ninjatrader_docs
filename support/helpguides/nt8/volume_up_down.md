



Volume Up Down

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](volume_up_down.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) > [System Indicator Methods](indicators.htm) >  Volume Up Down | [Previous page](volume_rate_of_change_vroc.htm) [Return to chapter overview](indicators.htm) [Next page](vortex.htm) |

Description
-----------

Variation of the [VOL](volume.htm) (Volume) indicator that colors the volume histogram different color depending if the current bar is up or down bar.

Syntax
------

VolumeUpDown()  
VolumeUpDown(ISeries<double> input)

 

Returns default value  
VolumeUpDown()[int barsAgo]  
VolumeUpDown(ISeries<double> input)[int barsAgo]

Return Value
------------

double; Accessing this method via an index value [int barsAgo] returns the indicator value of the referenced bar.

Parameters
----------

|  |  |
| --- | --- |
| input | Indicator source data ([?](valid_input_data_for_indicator.htm)) |

Example
-------

| ns |
| --- |
| // Prints the current value VolumeUpDown  double value = VolumeUpDown()[0];  Print("The current Volume value is " + value.ToString()); |

Source Code
-----------

You can view this indicator method source code by selecting the menu New > NinjaScript Editor > Indicators within the NinjaTrader Control Center window.