# AddPastedOffset()

## Definition

A [virtual method](https://msdn.microsoft.com/en-us/library/9fkccyh4.aspx) which is called every time a DrawingTool is copied and pasted to a chart.  The default behavior will offset the chart anchors price value down by 1, percent. However, this behavior can be overridden for your custom drawing tool if desired.

 

## Method Return Value

This method does not return a value

## Syntax

You must override this method using the following syntax:

chartScale)  
{  
   
}

## Method Parameters

| Name / Option | Description |
| --- | --- |
| panel | A ChartPanel representing the the panel for the chart |
| chartScale | A ChartScale representing the Y-axis |

## Examples

> chartScale)  {        Anchors)  {  //bump each anchor 1 minute to the right  anchor.Time;                       }
