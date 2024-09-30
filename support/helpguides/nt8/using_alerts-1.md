
Operations > Alerts > Using Alerts
Using Alerts

| << [Click to Display Table of Contents](using_alerts.md) >> **Navigation:**     [Operations](operations-1.md) > [Alerts](alerts-1.md) > Using Alerts | [Previous page](alerts-1.md) [Return to chapter overview](alerts-1.md) [Next page](alerts_dialog-1.md) |
| --- | --- |

## What can an alert do?
When an alert condition is triggered, you can define exactly how the alert behaves allowing you to:
- Display a custom message on the [Alerts Log](alerts_log-1.md)

- Play a sound

- Share content to a specific [Sharing Service](general_section-1.md)

- Display a Pop Up Dialog with a custom message

- Submit a custom order*

 
| Notes:  1) While an alert will give you the ability to submit custom orders, they are natively limited in the type of account and order management information that is available.  If you are interested in developing a more complex system for an automated trading approach, please see our Help Guide articles on developing an [Automated NinjaScript Strategy](strategy-1.md). 2) Alerts are not intended to be used with Playback while using an increased speed. Alerts are checked every 200 milliseconds, so using them in Playback could result in an alert not triggering. |
| --- |

 
## What kind of information can be used for an alert?
Alerts will always work in real-time, giving you access to a wide variety of information you have currently setup in your workspace.  However, the type of information that is available for an alert will depend on where the alert was setup.  For example, a Market Analyzer is real-time only and does not display historical values, therefore it would not be possible to create an alert based on a historical bar or indicator value.  In contrast, a Chart does display historical bar data, therefore a chart alert would be able to use historical bar data to be considering in a specific alert condition used for indicators and other data series.
 
## Chart Alerts
- Access to historical data allowing you to compare real-time indicator and data series values to previous values (bars ago)

- Manually configured chart objects and drawing tools

- Multiple data series such as additional instruments and time frames

- Ability to make time comparisons 

## Market / Hot list Analyzer Alerts
- Real-time data only

- Fundamental data such as Earnings Per Share, 52 week high/low, Settlement Price, etc can be used

- Access to account information such as instrument and account position information such Realized/Unrealized PnL, Position size, Position avg price, etc.
