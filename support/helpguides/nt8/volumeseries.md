


NinjaScript \> Language Reference \> Common \> ISeries\<T\> \> VolumeSeries\<double\>






















VolumeSeries\<double\>







| \<\< [Click to Display Table of Contents](volumeseries.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [ISeries\<T\>](iseriest.md) \> VolumeSeries\<double\> | [Previous page](iseries_times.md) [Return to chapter overview](iseriest.md) [Next page](iseries_volume.md) |
| --- | --- |











## Definition


Represents historical volume data as ISeries\<double\> interface which can be used for custom NinjaScript object calculations


## 




| Note:  In most cases, you will access the historical volume series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical volume series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, which may cause errors when trying to obtain this information.  In those cases, use the Bars.Get...() methods with the absolute bar index, e.g., [Bars.GetVolume()](getvolume.md). |
| --- |



 


 


## Single ISeries\<double\>




| [Volume](iseries_volume.md) | A collection of historical bar volume values. |
| --- | --- |



## 


## 


## Multi\-Time Frame ISeries\<double\>




| [Volumes](iseries_volumes.md) | Holds an array of ISeries\<double\> objects holding historical bar volume. |
| --- | --- |



 








