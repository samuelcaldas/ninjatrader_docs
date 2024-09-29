


NinjaScript \> Language Reference \> Common \> Charts \> Rendering






















Rendering







| \<\< [Click to Display Table of Contents](rendering.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Common](common.md) \> [Charts](chart.md) \> Rendering | [Previous page](width.md) [Return to chapter overview](chart.md) [Next page](d2dfactory.md) |
| --- | --- |











Rendering methods and properties can be useful when carrying out custom drawing tasks for chart objects. Event handlers such as [OnCalculateMinMax()](oncalculateminmax.md) and [OnRender()](onrender.md) allow you to override behavior at key points in the rendering process.


 




| Notse:  1\.Some rendering methods and properties make use of [SharpDX](http://sharpdx.org/) libraries, which provide a managed framework for working with DirectX technology.  Please see the [SharpDX SDK Reference](sharpdx_sdk_reference.md) for more information.2\.For a walk through for using the SharpDX, please see the educational resource [Using SharpDX for Custom Chart Rendering](using_sharpdx_for_custom_chart_rendering.md) |
| --- |



## 


## 


## Methods and Properties




| [RenderTarget](rendertarget.md) | Creates objects and exposes methods used for drawing in the chart area. |
| --- | --- |
| [ForceRefresh()](forcerefresh.md) | Forces OnRender() to be called, which will re\-paint the chart |
| [IsInHitTest](isinhittest.md) | Qualifies if object drawn in chart object should be selectable in the hit test procedure |
| [IsSelected](isselected.md) | Indicates a chart object is currently selected |
| [IsVisibleOnChart()](isvisibleonchart.md) | Indicates a chart object is visible on the chart canvas |
| [MaxValue](maxvalue.md) | The maximum value used for the automatic scaling of the y axis |
| [MinValue](minvalue.md) | The minimum value used for the automatic scaling of the y axis |
| [OnCalculateMinMax()](oncalculateminmax.md) | An event driven method which is called while the chart scale is being updated |
| [OnRender()](onrender.md) | Used to render custom drawing to a chart from various chart objects |
| [OnRenderTargetChanged()](onrendertargetchanged.md) | Used for efficient handling of SharpDX resources |
| [PanelUI](panelui.md) | The chart panel that is configured on the chart's UI |
| [ZOrder](chart_zorder.md) | A unique identifier used to control the order in which chart objects are drawn on the chart's Z\-axis |









