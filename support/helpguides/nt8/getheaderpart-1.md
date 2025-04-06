



GetHeaderPart()

|  |  |
| --- | --- |
| << [Click to Display Table of Contents](.\getheaderpart.htm) >>  **Navigation:**  [NinjaScript](ninjascript-1.htm) > [Language Reference](language_reference_wip-1.htm) > [Add On](add_on-1.htm) > [NTTabPage Class](nttabpage_class-1.htm) >  GetHeaderPart() | [Previous page](nttabpage_cleanup-1.htm) [Return to chapter overview](nttabpage_class-1.htm) [Next page](nttabpage_restore-1.htm) |

Definition
----------

Indicates the tab header name.

Examples
--------

| ns |
| --- |
| // NTTabPage member. Required for determining the tab header name  protected override string GetHeaderPart(string variable)  {      // Determine the text for the tab header name      switch (variable)      {          case "@INSTRUMENT": return Instrument == null ? Resource.GuiNewTab : Instrument.MasterInstrument.Name;          case "@INSTRUMENT\_FULL": return Instrument == null ? Resource.GuiNewTab : Instrument.FullName;      }      return variable;  } |