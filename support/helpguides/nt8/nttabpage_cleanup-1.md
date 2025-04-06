



CleanUp()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\nttabpage_cleanup.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [NTTabPage Class](nttabpage_class-1.htm) >  CleanUp() | [Previous page](nttabpage_class-1.htm) [Return to chapter overview](nttabpage_class-1.htm) [Next page](getheaderpart-1.htm) |

Definition
----------

Unregisters LinkControls ([IInstrumentProvider](iintervalprovider_interface-1.htm) [IIntervalProvider)](iintervalprovider_interface-1.htm) and calls Cleanup() on ICleanable controls on the NTTabPage. Override this to, e.g., unsubscribe from events or perform any other cleanup operations when the tab is closed.

|  |
| --- |
| Note:  When overriding Cleanup(), it is strongly recommended when you call base.Cleanup() which ensures any link controls are also unregistered.  The base implementation will also handle cleaning up any controls which implement ICleanable: [AccountSelector](accountselector-1.htm), [AtmStrategySelector](atmstrategyselector-1.htm), [InstrumentSelector](instrumentselector-1.htm), [IntervalSelector](intervalselector-1.htm), [TifSelector](tifselector-1.htm) |

Method Return Value
-------------------

This method does not return a value

Syntax
------

public override void Cleanup()

{

}

Parameters
----------

This method does not accept any parameters

Examples
--------

| ns |
| --- |
| public override void Cleanup()  {     // unregister from any custom events     Connection.ConnectionStatusUpdate                   -= OnConnectionStatusUpdate;          // a call to base.Cleanup() will loop through the visual tree looking for all ICleanable children     // i.e., AccountSelector, AtmStrategySelector, InstrumentSelector, IntervalSelector, TifSelector,     // as well as unregister any link control events        base.Cleanup();  } |