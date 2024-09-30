
NinjaScript > Language Reference > Drawing Tool > SupportsAlerts
SupportsAlerts

| << [Click to Display Table of Contents](supportsalerts.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > SupportsAlerts | [Previous page](onmouseup-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](zordertype-1.md) |
| --- | --- |

## Definition
Determines if the drawing tool can be used for manually configured alerts through the UI.
## 
## Property Value
A bool which when true determines that user can setup an alert based off this drawing tool;  otherwise false. 
 
| Note:  This property is false by default and MUST be overridden upon initialization to allow for manually configured alerts.  You cannot set this during run-time. |
| --- |

## Syntax
## SupportsAlerts
## 
You may choose to override this property using the following syntax:
## 
public override bool SupportsAlerts 

## Examples
| ns |
| --- |
| public override bool SupportsAlerts { get { return true; } } |

