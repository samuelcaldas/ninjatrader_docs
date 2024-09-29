


NinjaScript \> Educational Resources \> Tips \> Checking for Null References






















Checking for Null References







| \<\< [Click to Display Table of Contents](checking_for_null_references.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Educational Resources](educational_resources.md) \> [Tips](tips.md) \> Checking for Null References | [Previous page](adding_indicators_to_strategie.md) [Return to chapter overview](tips.md) [Next page](creating_user_defined_input_pa.md) |
| --- | --- |











A common object\-oriented programming error is not checking for null references on your object variables This will cause an "Object reference not set to an instance of an object" error.


 


For example:


You create a variable that holds an Order object


 




| ns |
| --- |
| private Order entryOrder \= null; |



 


But in the OnBarUpdate() method you do not check if this variable as been assigned an Order object, thus when trying to access object properties it fails and yields the "Object reference not set" error since the variable is null.


 




| ns |
| --- |
| protected override void OnBarUpdate() {      if (entryOrder.Filled \> 0)          // Do something } |



 


This will generate an error because you cannot access the object or any of its properties yet. You must always check if an object variable is null before attempting to access the object.


 




| ns |
| --- |
| protected override void OnBarUpdate() {      if (entryOrder \=\= null)      {          entryOrder \= EnterLong();      }      else if (entryOrder !\= null)      {          if (entryOrder.Filled \> 0)                // Do something      } } |









