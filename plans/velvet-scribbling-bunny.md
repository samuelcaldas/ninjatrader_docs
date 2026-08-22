# Plan: NinjaTrader 8 Documentation Conversion, Cleaning, and Markdown Standardization

## Context
The repository consists of 1,560 Markdown files converted from legacy HTML documentation (NinjaTrader 8 / NinjaScript). During the HTML-to-Markdown conversion, several structural, linking, and syntax flaws were introduced:
1. **Broken Code Blocks & Non-Standard Formatting**: 824 files have C# code trapped inside single-cell markdown tables `| ns |\n| --- |\n| code... |` filled with non-breaking spaces (` `), HTML escape leftovers, and unescaped generics (e.g. `ISeries<double>`, `Series<T>`).
2. **HTML Residues & Artifacts**: 1,552 files start with redundant HTML navigation headers/breadcrumbs (`<< [Click to Display Table of Contents](...) >> Navigation: ...`), leftover HTML table artifacts, and empty placeholder files.
3. **Broken & Malformed Links**: 317+ broken link targets across files caused by Windows backslashes (`.\8_0_0_7.md`), links to deleted `-1.md` legacy duplicates (`release_notes-1.md` instead of `release_notes.md`), and URLs truncated before special characters.
4. **File Naming & History Preservation**: Empty or misnamed files (`NT HelpGuide English*.md`, files with parentheses in names) that should be cleanly renamed using `git mv` or removed.

## Recommended Approach
We will build a deterministic, idempotent Python automation pipeline that executes in well-defined phases to clean, transform, and validate all 1,560 markdown files.

---

### Phase 1: File Renaming and Git History Preservation (`git mv`)
1. **Remove Empty Artifact Files**:
   - `NT HelpGuide English.md`, `NT HelpGuide English-2.md`, `NT HelpGuide English-3.md` (0-byte empty files created during export).
2. **Normalize Files with Parentheses / Unusual Characters**:
   - Safely rename using `git mv`:
     - `alert_rearmalert().md` -> `alert_rearmalert.md`
     - `chartbars_tochartstring().md` -> `chartbars_tochartstring.md`
     - `draw_pathtool().md` -> `draw_pathtool.md`
     - `ntmessageboxsimple_show().md` -> `ntmessageboxsimple_show.md`
     - `propagateinstrumentchange().md` -> `propagateinstrumentchange.md`
     - `propagateintervalchange().md` -> `propagateintervalchange.md`
     - `commitment-of-traders-(cot).md` -> `commitment_of_traders_cot.md`
     - `creating-chart-wpf-(ui)-modifi.md` -> `creating_chart_wpf_ui_modifications.md`
3. Update all references in `README.md` and across all `.md` files to match the new paths.

---

### Phase 2: Navigation Header & Residual HTML Cleanup
1. **Strip Legacy Navigation Headers**:
   - Remove the initial table block containing:
     ```markdown
     |  |  |
     | --- | --- |
     | << [Click to Display Table of Contents](...) >> ... | [Previous page](...) ... [Next page](...) |
     ```
   - Convert the top title into a standard markdown `# Title` H1 heading.
2. **Clean HTML Entities & Non-Breaking Spaces**:
   - Replace all ` ` (non-breaking spaces ` `) with standard spaces.
   - Clean HTML tags (`<font>`, `<span>`, `<div>`, `<br>`, `&nbsp;`, `&lt;`, `&gt;`, `&amp;`) and convert where appropriate to markdown formatting (bold, italic, code).

---

### Phase 3: Code Block Standardisation & Syntax Highlighting
1. **Extract and Convert Table-Wrapped Code Blocks (`| ns |`)**:
   - Detect table structures starting with `| ns |\n| --- |\n| <code lines> |`.
   - Unescape markdown pipe escapes (`\|`) and convert into proper fenced codeblocks:
     ```csharp
     // C# code here
     ```
2. **Detect and Fence Unfenced / Indented C# Code Blocks**:
   - Transform standard C# snippets (containing `protected override void`, `public class`, `OnBarUpdate`, `using NinjaTrader`, etc.) into fenced ````csharp``` blocks.
3. **Protect Generic Types**:
   - Ensure generic type signatures like `Series<double>`, `ISeries<T>`, `List<Order>` inside prose are wrapped in backticks (`` `Series<double>` ``) so markdown parsers do not treat them as unclosed HTML tags.

---

### Phase 4: Link & URL Repair
1. **Fix Windows Backslashes**:
   - Convert `[...](.\path.md)` to `[...](path.md)`.
2. **Fix Legacy `-1.md` Reference Links**:
   - Remap broken targets like `release_notes-1.md` -> `release_notes.md`, `addbar-1.md` -> `addbar.md`, etc.
3. **Fix Truncated Parentheses in Links**:
   - Fix targets truncated during export like `[ToChartString()](chartbars_tochartstring()` -> `[ToChartString()](chartbars_tochartstring.md)`.
4. **Update `README.md` and Index Links**:
   - Ensure master index links in `README.md` and `nt8_content.md` resolve accurately to actual files on disk.

---

### Phase 5: Verification & Static Checks
1. **Link Verification Check**:
   - Run an automated check asserting 0 broken relative links across all `.md` files.
2. **Markdown Syntax Linting**:
   - Verify that all code blocks have matching closing fences (```` ``` ````) and proper syntax tags (`csharp`, `json`, `xml`, `text`).
   - Ensure no leftover `| ns |` table artifacts exist.
3. **Git Status Cleanliness**:
   - Run `git status` to verify modified/renamed files are tracked cleanly.

---

## Files Affected
- `README.md`: Master table of contents and index.
- All 1,560 `*.md` files in root.
- Renamed targets (11 special files with parentheses / spaces).
