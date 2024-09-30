
NinjaScript > Language Reference > SuperDOM Column > OnRestoreValues()

OnRestoreValues()

| << [Click to Display Table of Contents](onrestorevalues.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [SuperDOM Column](superdom_column.md) > OnRestoreValues() | [Previous page](superdomcolumn_onrender.md) [Return to chapter overview](superdom_column.md) [Next page](sharpdx_sdk_reference.md) |
| --- | --- |
## Definition
Called when the column is restored (e.g. from a workspace).  All public properties in a SuperDOM Column are saved to the workspace upon closing and selecting save.  You may choose to do something explicit with a certain property when the OnRestoreValues() method is called.
 
## Method Return Value
This method does not return a value
 
## Syntax
## You may override the method in your SuperDOM column with the following syntax:
## 
public override void OnRestoreValues()  

{  

     

}
## 
## Parameters
This method does not require any parameters
## 
## Examples

| ns |
| --- |
| public override void OnRestoreValues() {    // Do something with the restored values. Can also trigger a repaint via OnPropertyChanged() } |
