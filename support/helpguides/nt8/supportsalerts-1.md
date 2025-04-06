



SupportsAlerts

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\supportsalerts.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  SupportsAlerts | [Previous page](onmouseup-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](zordertype-1.htm) |

Definition
----------

Determines if the drawing tool can be used for manually configured alerts through the UI.

Property Value
--------------

A bool which when true determines that user can setup an alert based off this drawing tool;  otherwise false.

|  |
| --- |
| Note:  This property is false by default and MUST be overridden upon initialization to allow for manually configured alerts.  You cannot set this during run-time. |

Syntax
------

SupportsAlerts
--------------

You may choose to override this property using the following syntax:

public override bool SupportsAlerts

Examples
--------

| ns |
| --- |
| public override bool SupportsAlerts { get { return true; } } |