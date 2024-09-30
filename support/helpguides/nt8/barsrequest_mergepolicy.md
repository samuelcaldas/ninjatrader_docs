
NinjaScript > Language Reference > Add On > BarsRequest > MergePolicy
MergePolicy
| << [Click to Display Table of Contents](barsrequest_mergepolicy.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Add On](add_on.md) > [BarsRequest](barsrequest.md) > MergePolicy | [Previous page](request.md) [Return to chapter overview](barsrequest.md) [Next page](connection_class.md) |
| --- | --- |
## Definition
Determines the merge policy of the bars request.
 
| Notes: - This property is ONLY applicable to Futures contracts- General information regrading merge policies can be found from the [Market Data Configuration](merge_policy.md) section- For an Instruments configured merge policy, please see the [MasterInstrument.MergePolicy](merge_policy.md) property |
| --- |

## Property Value
Represents the MergePolicy used for the bars request.
 
Possible values are:
 
| DoNotMerge | No merge policy is applied |
| --- | --- |
| MergeBackAdjusted | Merge policy is applied between contracts along with rollover offsets |
| MergeNonBackAdjusted | Merge policy is applied between contracts without offsets |
| UseGlobalSettings | Uses the value configured from Tools -> Options -> Market Data |
| UseDefault | Uses the default values configured for the [MasterInstrument](masterinstrument.md) |

## Syntax
MergePolicy
## 
## Example
| ns |
| --- |
| // request the last 365 1 day bars BarsRequest useGlobalRequest = new BarsRequest(Instrument.GetInstrument("ES 09-16"), 365); useGlobalRequest.BarsPeriod = new BarsPeriod { BarsPeriodType = BarsPeriodType.Day, Value = 1 };   // use the merge policy the user has configured as their global setting useGlobalRequest.MergePolicy = MergePolicy.UseGlobalSettings; useGlobalRequest.Request(new Action<BarsRequest, ErrorCode, string>((barsRequest, errorCode, errorMessage) =>{      Print("bars returned=" + barsRequest.Bars.Count);   }));   // dispose of the bars request if we are done with it useGlobalRequest.Dispose(); |

