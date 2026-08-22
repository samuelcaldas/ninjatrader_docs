# Using OnOrderUpdate() and OnExecution() methods to submit protective orders

The OnOrderUpdate() and OnExecutionUpdate() methods are reserved for experienced programmers.

Instead of using Set() methods to submit stop-loss and profit target orders, you can submit and update them manually through the use of Order and Execution objects in the OnOrderUpdate() and OnExecutionUpdate() methods.

The OnOrderUpdate() method is updated whenever the state of an order changes which allows you to submit and control your stop-loss and profit target orders the instant your entry order is filled.

The OnExecutionUpdate() method is updated whenever you receive an execution or a fill on your orders. This method provides you the fastest possible submission of protective orders. Utilizing the increased granularity provided in these advanced methods can be advantageous to you by providing you with maximum control of how your stop-loss and profit target orders behave.

## Key concepts in this example

- Submitting live-until-cancelled entry orders

- Modifying stop-loss order to breakeven after a certain amount in profit

## Important related documentation

- [[[Order](order.md)

- [[[Execution](execution.md)

- [[[OnOrderUpdate()](onorderupdate.md)

- [[[OnExecutionUpdate()](onexecutionupdate.md)

- [[[SetStopLoss()](setstoploss.md)

- [[[SetProfitTarget()](setprofittarget.md)

## Import instructions

1.Download the file contained in this Help Guide topic to your PC desktop

2.From the Control Center window, select the menu Tools > Import > NinjaScript

3.Select the downloaded file

[[[SampleOnOrderUpdate\_NT8.zip](https://ninjatrader.com/support/helpGuides/nt8/samples/SampleOnOrderUpdate_NT8.zip)
