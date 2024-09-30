
NinjaScript \> Language Reference \> Strategy \> StartBehavior

StartBehavior

| \<\< [Click to Display Table of Contents](startbehavior.md) \>\> **Navigation:**     [NinjaScript](ninjascript-1.md) \> [Language Reference](language_reference_wip-1.md) \> [Strategy](strategy-1.md) \> StartBehavior | [Previous page](slippage-1.md) [Return to chapter overview](strategy-1.md) [Next page](stoptargethandling-1.md) |
| --- | --- |
## Definition
Sets the start behavior of the strategy. See [Syncing Account Positions](syncing_account_positions-1.md) for more information.
 

| Note:  In order to use AdoptAccountPosition you will need to first set [IsAdoptAccountPositionAware](isadoptaccountpositionaware-1.md) to true. Please be sure that your strategy is specifically programmed in a manner that can accommodate account positions before using this mode. |
| --- |
 
## Property Value
An enum value that determines how the strategy behaves; Default value is set to StartBehavior.WaitUntilFlat.  Possible values are:
## 

| StartBehavior.AdoptAccountPosition |
| --- |
| StartBehavior.ImmediatelySubmit |
| StartBehavior.ImmediatelySubmitSynchronizeAccount |
| StartBehavior.WaitUntilFlat |
| StartBehavior.WaitUntilFlatSynchronizeAccount |
 
## Syntax
StartBehavior

## 
## Examples

| ns |
| --- |
| protected override void OnStateChange() {      if (State \=\= State.SetDefaults)      {          StartBehavior \= StartBehavior.WaitUntilFlat;      } } |

