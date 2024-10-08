﻿
NinjaScript > Language Reference > Common > OnConnectionStatusUpdate()

OnConnectionStatusUpdate()

| << [Click to Display Table of Contents](onconnectionstatusupdate.md) >> **Navigation:**     [NinjaScript](ninjascript.md) > [Language Reference](language_reference_wip.md) > [Common](common.md) > OnConnectionStatusUpdate() | [Previous page](update.md) [Return to chapter overview](common.md) [Next page](connectionstatuseventargs.md) |
| --- | --- |
## Definition
An event driven method used which is called for every change in connection status.
 
## Method Return Value
This method does not return a value.
 
## Syntax
You must override the method in your indicator with the following syntax:
## 
protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate)  

{  

   

}

## Method Parameters

| connectionStatusUpdate | A [ConnectionStatusEventArgs](connectionstatuseventargs.md) object representing the most recent update in connection. |
| --- | --- |
| Status | Represents the status of the key adapter functionality. If the adapter supports live orders it will set Status to Disconnected when its order system is not connected. |
| PriceStatus | Represents the status of the price feed. |
## 
## 
## Examples

| ns |
| --- |
| //Prints the status of the order system protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate) {    if(connectionStatusUpdate.Status == ConnectionStatus.Connected)    {      Print("Connected for orders at " + DateTime.Now);    }        else if(connectionStatusUpdate.Status == ConnectionStatus.ConnectionLost)    {      Print("Connection for orders lost at: " + DateTime.Now);    } }   //Prints the status of the price feed protected override void OnConnectionStatusUpdate(ConnectionStatusEventArgs connectionStatusUpdate) {    if(connectionStatusUpdate.PriceStatus == ConnectionStatus.Connected)    {      Print("Connected to price feed at " + DateTime.Now);    }        else if(connectionStatusUpdate.PriceStatus == ConnectionStatus.ConnectionLost)    {      Print("Connection to price feed lost at: " + DateTime.Now);    } } |
