



IgnoresUserInput

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\ignoresuserinput.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Drawing Tool](drawing_tools-1.htm) >  IgnoresUserInput | [Previous page](ignoressnapping-1.htm) [Return to chapter overview](drawing_tools-1.htm) [Next page](isattachedtoninjascript-1.htm) |

Definition  
Determines if the drawing tool can be clicked on by the user.

Property Value
--------------

A bool value which wen true if the drawing tool cannot not be interacted with by a user; otherwise false.  Default is set to false.

Syntax
------

IgnoresUserInput

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {       if (State == State.SetDefaults)      {               IgnoresUserInput = true; // Set this to true to make the drawing object non-interactive      }      else if (State == State.Configure)      {         }  } |