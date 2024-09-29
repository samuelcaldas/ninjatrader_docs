


NinjaScript \> Language Reference \> Add On \> NTTabPage Class \> GetHeaderPart()






















GetHeaderPart()







| \<\< [Click to Display Table of Contents](getheaderpart.md) \>\> **Navigation:**     [NinjaScript](ninjascript.md) \> [Language Reference](language_reference_wip.md) \> [Add On](add_on.md) \> [NTTabPage Class](nttabpage_class.md) \> GetHeaderPart() | [Previous page](nttabpage_cleanup.md) [Return to chapter overview](nttabpage_class.md) [Next page](nttabpage_restore.md) |
| --- | --- |











## Definition


Indicates the tab header name.


 


## 


## Examples




| ns |
| --- |
| // NTTabPage member. Required for determining the tab header name protected override string GetHeaderPart(string variable) {      // Determine the text for the tab header name      switch (variable)      {          case "@INSTRUMENT": return Instrument \=\= null ? Resource.GuiNewTab : Instrument.MasterInstrument.Name;          case "@INSTRUMENT\_FULL": return Instrument \=\= null ? Resource.GuiNewTab : Instrument.FullName;      }      return variable; } |









