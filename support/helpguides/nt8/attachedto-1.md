
NinjaScript > Language Reference > Drawing Tool > AttachedTo

AttachedTo
| << [Click to Display Table of Contents](attachedto.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > AttachedTo | [Previous page](anchors-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](chartanchor-1.md) |
| --- | --- |
## Definition
An object which holds information regarding where the drawing tool is attached.
 
## Available Properties
| AttachedToType | An enum representing the type of object the drawing to is attached.  Possible values are: - Bars - The chart bars of the parent chart- GlobalInstrument - The bars of an instrument crossed all charts- Indicator - A NinjaScript indicator- Strategy - A NinjaScript strategy |
| --- | --- |
| ChartObject | A ChartObject interface such an indicator, strategy, chart bars |
| DisplayName | A string value indicating the name of the object the drawing tool is attached |
| Instrument | The [Instrument](instrument-1.md) that the drawing tool is attached |

## 
## 
## Syntax
AttachedTo

## Examples
| ns |
| --- |
| if (AttachedTo.AttachedToType == AttachedToType.Indicator)    // do something |
