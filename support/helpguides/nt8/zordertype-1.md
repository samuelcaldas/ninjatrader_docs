
NinjaScript > Language Reference > Drawing Tool > ZOrderType
ZOrderType

| << [Click to Display Table of Contents](zordertype.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Drawing Tool](drawing_tools-1.md) > ZOrderType | [Previous page](supportsalerts-1.md) [Return to chapter overview](drawing_tools-1.md) [Next page](import_type-1.md) |
| --- | --- |

## Definition
Determines the order in which the drawing tool will be rendered. This will help control the [ZOrder](chart_zorder-1.md) index between chart objects
## 
## Property Value
An enum determining the drawing tool's ZOrder type.  Possible values are:
 
| DrawingToolZOrder.Normal | Default behavior, drawing tools are rendered as they appear in the [ZOrder](chart_zorder-1.md) index |
| --- | --- |
| DrawingToolZOrder.AlwaysDrawnFirst | Ensures the drawing tool is always the first to be rendered |
| DrawingToolZOrder.AlwaysDrawnLast | Ensures the drawing tool is always the last object to be rendered |

## 
## 
## Syntax
ZOrderType

## Examples
| ns |
| --- |
| protected override void OnStateChange() {    if (State == State.SetDefaults)    {      Name               = @"My Drawing Tool";                 // always draw this last       ZOrderType           = DrawingToolZOrder.AlwaysDrawnLast;    }    else if (State == State.Configure)    {    } } |

