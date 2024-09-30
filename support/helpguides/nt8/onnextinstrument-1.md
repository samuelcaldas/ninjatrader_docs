
NinjaScript > Language Reference > Import Type > OnNextInstrument()

OnNextInstrument()

| << [Click to Display Table of Contents](onnextinstrument.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Import Type](import_type-1.md) > OnNextInstrument() | [Previous page](import_type-1.md) [Return to chapter overview](import_type-1.md) [Next page](onnextdatapoint-1.md) |
| --- | --- |
## Definifition
The OnNextInstrument() method is called at the beginning of the import process for each file that is being imported.  This method is only called after it has determined the file contains a valid instrument.
## 
## Method Return Value
This method does not return a value.
## 
## Syntax
See example below. The NinjaScript code wizard automatically generates the method syntax for you.
 
## Example

| ns |
| --- |
| private int currentInstrumentIdx = -1;   public string[] FileNames  { get; set; }   protected override void OnNextInstrument() {    if (FileNames == null)        return;          // Try to read from file into the FileNames array created above        // Log an error and continue if the data is unreadable        try        {            reader = new StreamReader(FileNames[currentInstrumentIdx]);        }        catch (Exception exp)        {            NinjaScript.Log(FileNames[currentInstrumentIdx], exp.Message, LogLevel.Error);            continue;        } } |
