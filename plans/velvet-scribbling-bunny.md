# Plan: Clean Broken / Layout Tables, Remove Empty Rows/Columns, and Format Markdown Code

## Context
During the original legacy conversion from Help & Manual HTML to Markdown:
1. **Layout Tables & Ghost Headers**: Help & Manual nested toggle boxes, layout grids, and callout panels were converted into wide Markdown tables with up to 300 empty columns (`| | | ... | \n | --- | --- | ... |`) or ghost tables with 0 data rows.
2. **Inline / Mangled Callouts**: Nested notes/tips generated inline artifacts like `| | --- | | Tip: ... |` inside markdown code blocks and body text.
3. **Mangled Fences in Complex Pages**: A few large articles (such as `docs/drawing_tools/using_sharpdx_for_custom_chart_rendering.md`, `docs/drawing_tools/sharpdx_color.md`, and `docs/drawing_tools/working_with_drawing_tools__ob.md`) have collapsed sections where C# code blocks and table headers were intermingled.
4. **Unlabeled Code Fences**: Fences missing `csharp`, `xml`, or `text` language tags.

All changes will be validated against the ground truth in `origin/HTML` (`git show origin/HTML:support/helpguides/nt8/<file>.htm`) to ensure **zero data loss** while producing clean, idiomatic GitHub-flavored Markdown.

---

## 1. Scope & Strategy

### A. Remove Empty Ghost Tables (0 data rows)
- Identify all tables where header is empty (`| | |`) and separator is empty with no actual data rows.
- Remove these ghost layout artifacts cleanly from all markdown files.

### B. Convert Layout Wrapper Tables & Multi-Column Ghost Separators
- In Release Notes (`docs/release_notes/*.md`): Promote the real header row (e.g. `Issue # | Status | Category | Comments` or `Feature # | Status | Category | Comments`) to the table header, eliminating the redundant empty row.
- In Core Docs: Replace 2-column key-value / parameter / enum tables having empty headers with proper semantic headers (`| Parameter | Description |` or `| Property | Description |` or `| Value | Description |`).

### C. Repair Mangled Multi-Section Pages
- **`docs/drawing_tools/using_sharpdx_for_custom_chart_rendering.md`**:
  - Reconstruct clean subheadings for `SharpDX Vectors and Charting Coordinates`, `SharpDX Brush Resources`, `SharpDX RenderTarget`, `SharpDX Lines and Shapes`, and `SharpDX Text Rendering`.
  - Extract callout notes into blockquotes (`> **Note:** ...`, `> **Tip:** ...`, `> **Warning:** ...`).
  - Format all C# sample snippets with clean ` ```csharp ` code fences.
- **`docs/drawing_tools/sharpdx_color.md`**:
  - Clean the 285-column ghost separator and format the "Colors by name" table into a clean 2-column table (`| Color Constant | Description |`).
- **`docs/drawing_tools/working_with_drawing_tools__ob.md`**:
  - Convert the collapsed layout sections into proper `### Subheadings` and clean Markdown bulleted lists.

### D. Code Block Beautification
- Ensure all code blocks across `docs/` have appropriate syntax highlighting (`csharp`, `xml`, `json`, `bash`).
- Ensure no code fences are unclosed or incorrectly nested.

---

## 2. Implementation Steps

1. **Develop Custom Cleaning Engine (`tools/clean_tables.py`)**:
   - Parse all `.md` files in `docs/`.
   - Normalize Release Notes tables by shifting real headers to row 1.
   - Clean ghost empty-table rows (`| | | ... |`).
   - Clean inline callout artifacts (`| | --- | | Tip:` -> `> **Tip:**`).
   - Format unlabeled code fences.
2. **Deep-Clean & Format Complex Direct2D / UI Documents**:
   - Clean and verify `docs/drawing_tools/using_sharpdx_for_custom_chart_rendering.md`.
   - Clean and verify `docs/drawing_tools/sharpdx_color.md`.
   - Clean and verify `docs/drawing_tools/working_with_drawing_tools__ob.md`.
   - Clean and verify `docs/language_reference/multi-time_frame__instruments.md`.
3. **Run Validation & Test Suite**:
   - `python3 tools/verify_docs.py` (0 broken links or missing images).
   - `python3 -m unittest discover -s tests` (all unit tests pass).
   - Verify Wiki staging via `python3 tools/deploy_wiki.py --stage-only`.

---

## 3. Verification & Acceptance Criteria
- [ ] No wide ghost tables (with 4+ empty columns or empty separators) remain in `docs/`.
- [ ] All table headers are semantic and properly populated.
- [ ] Code blocks are cleanly formatted with `csharp`, `xml`, or `text` language specifiers.
- [ ] No content or text from `origin/HTML` is lost.
- [ ] `verify_docs.py` and `unittest` pass 100%.
