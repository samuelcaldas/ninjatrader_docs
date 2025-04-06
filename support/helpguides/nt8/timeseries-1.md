



TimeSeries<DateTime>

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\timeseries.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Common](common-1.htm) > [ISeries<T>](iseriest-1.htm) >  TimeSeries<DateTime> | [Previous page](weighteds-1.htm) [Return to chapter overview](iseriest-1.htm) [Next page](iseries_time-1.htm) |

Definition
----------

Represents historical time stamps as an ISeries<DateTime> interface which can be used for custom NinjaScript object calculations.

|  |
| --- |
| Note:  In most cases, you will access the historical time series using a core event handler such as OnBarUpdate.  For more advance developers, you may find situations where you wish to access historical time series outside of the core event methods, such as your own custom mouse click.  In these advanced scenarios, you may run into situations where the barsAgo pointer is not in sync with the current bar, which may cause errors when trying to obtain this information.  In those cases, use the Bars.Get...() methods with the absolute bar index, e.g., [Bars.GetTime()](gettime-1.htm), etc. |

Single ISeries<DateTime>
------------------------

|  |  |
| --- | --- |
| Time | A collection of historical bar time stamp values. |

Multi-Time Frame ISeries<DateTime>
----------------------------------

|  |  |
| --- | --- |
| Times | Holds an array of ISeries<DateTime> objects holding historical bar times |