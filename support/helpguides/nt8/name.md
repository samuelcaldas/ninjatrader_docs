



Name

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](name.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Common](common.htm) >  Name | [Previous page](isvisible.htm) [Return to chapter overview](common.htm) [Next page](triggercustomevent.htm) |

Definition
----------

Determines the listed name of the NinjaScript object.

Property Value
--------------

A string value.

Syntax
------

Name

 

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {          if (State == State.SetDefaults)     {       Name                 = "Examples indicator";       Description           = @"An example of an indicator used for documentation purposes";           }  } |