



OnNextInstrument()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\onnextinstrument.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Import Type](import_type-1.htm) >  OnNextInstrument() | [Previous page](import_type-1.htm) [Return to chapter overview](import_type-1.htm) [Next page](onnextdatapoint-1.htm) |

Definifition
------------

The OnNextInstrument() method is called at the beginning of the import process for each file that is being imported.  This method is only called after it has determined the file contains a valid instrument.

Method Return Value
-------------------

This method does not return a value.

Syntax
------

See example below. The NinjaScript code wizard automatically generates the method syntax for you.

Example
-------

| ns |
| --- |
| private int currentInstrumentIdx = -1;     public string[] FileNames   { get; set; }     protected override void OnNextInstrument()  {     if (FileNames == null)         return;            // Try to read from file into the FileNames array created above         // Log an error and continue if the data is unreadable         try         {             reader = new StreamReader(FileNames[currentInstrumentIdx]);         }         catch (Exception exp)         {             NinjaScript.Log(FileNames[currentInstrumentIdx], exp.Message, LogLevel.Error);             continue;         }  } |