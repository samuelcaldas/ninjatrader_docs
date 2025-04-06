



Volume

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\iseries_volume.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) > [VolumeSeries<double>](volumeseries-1.htm) >  Volume | [Previous page](volumeseries-1.htm) [Return to chapter overview](volumeseries-1.htm) [Next page](iseries_volumes-1.htm) |

Definition
----------

A collection of historical bar volume values.

 

|  |
| --- |
| Note:    For working with [Cryptocurrency instruments](instrumenttype-1.htm) which report volume fractional, please use the [VOL()](volume-1.htm) indicator series, or store the volume for your script in a custom variable and convert alongside our [VOL()](volume-1.htm) indicator (Instrument.MasterInstrument.InstrumentType == InstrumentType.CryptoCurrency ? Core.Globals.ToCryptocurrencyVolume((long)Volume[0]) : Volume[0]). |

Property Value
--------------

An ISeries<double> object. Accessing this property via an index [int barsAgo] returns a double value representing the volume of the referenced bar.

Syntax
------

Volume  
Volume[int barsAgo]

Examples
--------

| ns |
| --- |
| // OnBarUpdate method  protected override void OnBarUpdate()  {       // Is current volume greater than twice the prior bar's volume       if (Volume[0] > Volume[1] \* 2)           Print("We have increased volume");          // Is the current volume greater than the 20 period moving average of volume       if (Volume[0] > SMA(Volume, 20)[0])           Print("Increasing volume");  } |