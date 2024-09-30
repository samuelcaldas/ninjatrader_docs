
NinjaScript \> Language Reference \> Import Type \> OnNextDataPoint()

OnNextDataPoint()

| \<\< [Click to Display Table of Contents](onnextdatapoint.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Import Type](import_type-1.md) \> OnNextDataPoint() | [Previous page](onnextinstrument-1.md) [Return to chapter overview](import_type-1.md) [Next page](indicator-1.md) |
| --- | --- |
## Definifition
The OnNextDataPoint() method is called for each line of data contained in the file being imported. This method is only called if the import type determines that the file has a valid data point, and will continue to be called until it reaches the end of the file, or until the data point is no longer valid.
## 
## Method Return Value
This method does not return a value.
## 
## Syntax
See example below. The NinjaScript code wizards automatically generate the method syntax for you.
 
## Example

| ns |
| --- |
| private StreamReader reader;          protected override void OnNextDataPoint() {    if (reader \=\= null)        return;      // Continually read data using the StreamReader defined above    while (true)    {        DataPointString \= reader.ReadLine();        // Additional data formatting here    } } |
