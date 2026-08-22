# Working With Commission Templates

The Commission Templates to be applied to different trading accounts configured in NinjaTrader. These templates can be used to set minimum and per-unit commissions for all instruments of a certain type, or to set specific commissions for individual instruments, which will override any commissions set for the instrument type.

![tog_plus]()Managing commission templates

> Adding Commission Templates The add button at the bottom of the "Templates" section of the window. A new template will be created with a default name, and specific commissions can then be saved for the template using the steps in the sections below.    Once a new template has been added, you can edit it's name by selecting it in the list in the "Templates" section, then entering a name in the "Name" field within the "Properties" section.    Commissions2    1) The add button is clicked    2) A new template with a default name is added to the list    3) The template name can be changed in the "Properties" section    Copying Commission Templates  There may be an instance in which you need to maintain two copies of a copy button. A new copy will appear in the list, allowing you to make any necessary changes.    Removing Commission Templates  To remove a remove button.

![tog_plus]()Managing commissions per instrument type

|  |  |
| --- | --- |
| Adding Commissions Per Instrument Type To add a commission for an entire asset class (instrument type), first select an asset class listed in the "Commission Per Instrument Type" grid, then click the edit button. Alternatively, you can double-click on any row in the grid to open the OK.    Commissions3    |  | | --- | | Notes:  Forex instrument types, "Per-unit commission" should be divided by the accounts FX lot size per trade.  For example, if your commissions were $0.06 per 1000 FX lot, you would use "0.00006" as the Per-unit commission value (e.g., 0.06 / 1000) | |

![tog_plus]()Managing instrument-specific commissions

|  |  |
| --- | --- |
| Adding Instrument-Specific Commissions To add commissions for specific instruments, first click the add button below the "Commission Per Instrument" section to open the OK.    Commissions4    |  | | --- | | Notes:  Forex instrument types, "Per-unit" commission should be divided by the account FX lot size per trade.  For example, if your commissions were $0.06 per 1000 FX lot, you would use "0.00006" as the Per-unit commission value (e.g., 0.06 / 1000) |     Editing Instrument-Specific Commissions To edit an instrument-specific commission, first select it in the list of instrument-specific commissions for your chosen edit button. You can then follow the process outlined above to change the instrument or commission values.   Removing Instrument-Specific Commissions To remove an instrument-specific commission, first select it in the list of instrument-specific commissions for your chosen remove button.    Commissions5    1) The edit button can be used to edit an existing instrument-specific commission.    2) The remove button can be used to remove an instrument-specific commission. |
