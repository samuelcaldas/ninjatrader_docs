
NinjaScript > Language Reference > Common > Charts > Rendering > ForceRefresh()
ForceRefresh()
| << [Click to Display Table of Contents](forcerefresh.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Common](common-1.md) > [Charts](chart-1.md) > [Rendering](rendering-1.md) > ForceRefresh() | [Previous page](dxextensions_tovector2-1.md) [Return to chapter overview](rendering-1.md) [Next page](isinhittest-1.md) |
| --- | --- |
## Definition
Resets an internal marker used to determine if the chart visuals need to re-render.
 
[ChartControl](chartcontrol-1.md) runs a timed event every 250ms to determine the chart needs to be updated. If it does, the [OnRender()](onrender-1.md) method is called. Under normal circumstances, the marker used to call OnRender() will be reset after the following conditions:
 
- [OnBarUpdate()](onbarupdate-1.md) event

- [OnConnectionStatusUpdate()](onconnectionstatusupdate-1.md) event

- User clicks on the chart

- Drawing object(s) have been removed from the chart

- Strategy enabled/disabled on chart

- ChartTrader enabled/disabled

 
In most cases, the conditions listed above should be satisfactory for rendering standard and custom chart objects; however for more advance programming concepts, there may be other situations you run into which would NOT force the chart to refresh (e.g., a user interacting with a custom control ).  In these special cases, you can use the ForceRefresh() method to re-queue the render event.

| Note:  As the chart is optimized on a timer, calling ForceRefresh() will NOT immediately trigger a render event.   Calling ForceRefesh() simply re-queues the render event to trigger during the next timed event.  In other words, it may take up to 250ms for the render event to function. |
| --- |
 
## 
## Method Return Value
This method does not return a value
## 
## Syntax
ForceRefresh()
## 
 
| Warning:  Excessive calls to ForceRefresh() and OnRender() can carry an impact on general application performance.  You should only call ForceRefresh() if the chart truly needs to be visually updated.  It is NOT recommended to invalidate the chart control directly as this could cause issues with threading which result in dead locks. |
| --- |
## 
## 
## Method Parameters
This method does not accept any parameters
 
## Examples
| ns |
| --- |
| DateTime lastTimeCalled = DateTime.MinValue;   private void MyCustomMethod() {    // if it has been longer than one second since the last time    // this method was called update the chart visually    if (Core.Globals.Now.Subtract(lastTimeCalled).Seconds >= 1)    {      ForceRefresh();      lastTimeCalled = Core.Globals.Now;    } } |

