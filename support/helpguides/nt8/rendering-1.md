
NinjaScript \> Language Reference \> Common \> Charts \> Rendering
Rendering
| \<\< [Click to Display Table of Contents](rendering.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Common](common-1.md) \> [Charts](chart-1.md) \> Rendering | [Previous page](width-1.md) [Return to chapter overview](chart-1.md) [Next page](d2dfactory-1.md) |
| --- | --- |
Rendering methods and properties can be useful when carrying out custom drawing tasks for chart objects. Event handlers such as [OnCalculateMinMax()](oncalculateminmax-1.md) and [OnRender()](onrender-1.md) allow you to override behavior at key points in the rendering process.
 
| Notse:  1\.Some rendering methods and properties make use of [SharpDX](http://sharpdx.org/) libraries, which provide a managed framework for working with DirectX technology.  Please see the [SharpDX SDK Reference](sharpdx_sdk_reference-1.md) for more information.2\.For a walk through for using the SharpDX, please see the educational resource [Using SharpDX for Custom Chart Rendering](using_sharpdx_for_custom_chart_rendering-1.md) |
| --- |

## 
## 
## Methods and Properties
| [RenderTarget](rendertarget-1.md) | Creates objects and exposes methods used for drawing in the chart area. |
| --- | --- |
| [ForceRefresh()](forcerefresh-1.md) | Forces OnRender() to be called, which will re\-paint the chart |
| [IsInHitTest](isinhittest-1.md) | Qualifies if object drawn in chart object should be selectable in the hit test procedure |
| [IsSelected](isselected-1.md) | Indicates a chart object is currently selected |
| [IsVisibleOnChart()](isvisibleonchart-1.md) | Indicates a chart object is visible on the chart canvas |
| [MaxValue](maxvalue-1.md) | The maximum value used for the automatic scaling of the y axis |
| [MinValue](minvalue-1.md) | The minimum value used for the automatic scaling of the y axis |
| [OnCalculateMinMax()](oncalculateminmax-1.md) | An event driven method which is called while the chart scale is being updated |
| [OnRender()](onrender-1.md) | Used to render custom drawing to a chart from various chart objects |
| [OnRenderTargetChanged()](onrendertargetchanged-1.md) | Used for efficient handling of SharpDX resources |
| [PanelUI](panelui-1.md) | The chart panel that is configured on the chart's UI |
| [ZOrder](chart_zorder-1.md) | A unique identifier used to control the order in which chart objects are drawn on the chart's Z\-axis |
