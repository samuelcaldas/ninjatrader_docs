
NinjaScript > Language Reference > Add On > Connection > ReloadAllHistoricalData()

ReloadAllHistoricalData()

| << [Click to Display Table of Contents](reloadallhistoricaldata.md) >> **Navigation:**     [NinjaScript](ninjascript-1.md) > [Language Reference](language_reference_wip-1.md) > [Add On](add_on-1.md) > [Connection](connection_class-1.md) > ReloadAllHistoricalData() | [Previous page](connections_status-1.md) [Return to chapter overview](connection_class-1.md) [Next page](playbackconnection-1.md) |
| --- | --- |
## Definition
To be used only in the OnConnectionStatusUpdate() event.  Forces the data repository to be reloaded for any bars series running in the hosting script after.  Data will be reloaded for any charts currently running which match the hosting scripts bars series (minute, tick, day).  This method will also check and reload the max number of days or bars to load used in every chart running which matches the bars series contained in the script.  Reloading historical data refreshes the UI which will force the NinjaScript object to re-transition to real-time.  This method was designed for reloading historical data after an [OnConnectionStatusUpdate](onconnectionstatusupdate-1.md) event.  
 

| Critical: This method should NOT be called from any of the event methods which access data or any of the OnStateChange() states as it may be called recursively while the hosting object transitions through states.  The designed use case for this method is reloading historical data after a connection update therefore we suggest ONLY using this method in the OnConnectionStatusUpdate method.  Please see the examples below for an demonstration of the intended use case. |
| --- |

## Method Return Value
This method does not return a value
 
## Syntax
ReloadAllHistoricalData()
 
## Parameters
## This method does not take any parameters
## 
 
## Examples

| ns |
| --- |
| //monitor our connection status so our NinjaScript object would know to reload historical data //create a bool which tracks when historical data would need to be reloaded after a connection loss private bool IsReloadAllHistoricalDataNeeded = false; protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate) {                //if the connection status update detects a lost connection    if(connectionStatusUpdate.Status == ConnectionStatus.ConnectionLost)    {      Print("Connection Lost, setting IsReloadAllHistorical Data to true");      // switch the reload data bool to true                  IsReloadAllHistoricalDataNeeded = true;               }             // only if we needed to reload historical data && only after when we have reconnected    else if (IsReloadAllHistoricalDataNeeded && connectionStatusUpdate.Status == ConnectionStatus.Connected )    {      Print("Connection is reconnected, reloading all historical data");      //then reload data and set our bool back to false.      ReloadAllHistoricalData();      IsReloadAllHistoricalDataNeeded = false;    }     } |
