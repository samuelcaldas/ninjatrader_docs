
NinjaScript > Language Reference > Strategy > StartBehavior

StartBehavior

| << [Click to Display Table of Contents](startbehavior.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Strategy](strategy.md) > StartBehavior | [Previous page](slippage.md) [Return to chapter overview](strategy.md) [Next page](stoptargethandling.md) |
| --- | --- |
## Definition
Sets the start behavior of the strategy. See [Syncing Account Positions](syncing_account_positions.md) for more information.
 

| Note:  In order to use AdoptAccountPosition you will need to first set [IsAdoptAccountPositionAware](isadoptaccountpositionaware.md) to true. Please be sure that your strategy is specifically programmed in a manner that can accommodate account positions before using this mode. |
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
| protected override void OnStateChange() {      if (State == State.SetDefaults)      {          StartBehavior = StartBehavior.WaitUntilFlat;      } } |

