



IsDefault

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](isdefault.htm) >>  **Navigation:**  [NinjaScript](ninjascript.htm) > [Language Reference](language_reference_wip.htm) > [Share Service](share_service.htm) >  IsDefault | [Previous page](isconfigured.htm) [Return to chapter overview](share_service.htm) [Next page](isimageattachmentsupported.htm) |

Definition
----------

Sets the default Share Service used when the type of sharing service is selected.

For example, if you are using two different email adapters, you may set one to be the default when the user selects the email sharing service.  Setting this property as the default would only apply to any email adapters and would not apply to any other types of sharing services which have their own respective default adapter.

Property Value
--------------

A bool value that represents if the current adapter is default Share Service used for that type of sharing service.

|  |
| --- |
| Warning:  This property should ONLY bet set from the [OnStateChange()](onstatechange.htm) method during State.SetDefaults |

Syntax
------

Default

Examples
--------

| ns |
| --- |
| protected override void OnStateChange()  {                          if (State == State.SetDefaults)  {  Default        = false;  }  } |