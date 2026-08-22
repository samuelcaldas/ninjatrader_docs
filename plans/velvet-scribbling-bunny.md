# Plan: GitHub Actions CI/CD for Automated GitHub Wiki Deployment

## Context
The documentation has been reorganized under `docs/`, with all relative links repaired and a custom wiki staging engine (`tools/deploy_wiki.py`) in place.
The user requested a **CI/CD pipeline** that:
1. Runs validation tests (`verify_docs.py` and `python3 -m unittest discover -s tests`) on every push and pull request touching `docs/`, `README.md`, `tools/`, or `tests/`.
2. Automatically builds, stages, and deploys the entire documentation, images, `_Sidebar.md`, `Home.md`, and `_Footer.md` to GitHub Wiki on pushes to the `markdown` branch (and via manual `workflow_dispatch`).

---

## 1. Workflow Architecture (`.github/workflows/deploy-wiki.yml`)

### Triggers
- `push`:
  - Branches: `markdown`, `master`, `main`
  - Paths: `docs/**`, `README.md`, `tools/**`, `tests/**`, `.github/workflows/deploy-wiki.yml`
- `pull_request`:
  - Branches: `markdown`, `master`, `main`
  - Paths: `docs/**`, `README.md`, `tools/**`, `tests/**`
- `workflow_dispatch`: Manual trigger with optional force-deploy input.

### Job 1: `validate`
Runs on all PRs and pushes to guarantee documentation and link integrity before any deployment occurs:
1. Checkout repository with full depth.
2. Set up Python 3.11.
3. Run `python3 tools/verify_docs.py` (asserts 0 broken links and 0 missing image assets).
4. Run `python3 -m unittest discover -s tests` (asserts clean repo root, docs categories, images, and wiki distribution generation).

### Job 2: `deploy-wiki`
Runs on `push` to default branch (and `workflow_dispatch`) after `validate` succeeds:
1. Checkout repository.
2. Set up Python 3.11.
3. Stage Wiki distribution: `python3 tools/deploy_wiki.py --stage-only`.
4. Deploy to Wiki remote using `GITHUB_TOKEN` / Personal Access Token / SSH key:
   - Configures git author.
   - Pushes `.wiki_dist/` to `https://x-access-token:${{ secrets.GITHUB_TOKEN }}@github.com/${{ github.repository }}.wiki.git` (or falls back with helpful action log if wiki repository is pending first-page initialization in GitHub Web UI).

---

## 2. Implementation Steps

1. **Update `tools/deploy_wiki.py`**:
   - Add support for token-based authentication via environment variable `GH_TOKEN` / `GITHUB_TOKEN`.
   - Add CLI flags `--stage-only`, `--token <token>`, and `--dry-run` to make deployment seamless in both local and CI environments.
2. **Create Workflow File (`.github/workflows/deploy-wiki.yml`)**:
   - Write standard GitHub Actions definition with permissions: `contents: write`, `wiki: write` (or repo scope).
   - Multi-step validation, staging, and wiki push.
3. **Verify Locally & In Test Suite**:
   - Run `python3 -m unittest discover -s tests` to ensure all tests pass.
   - Validate YAML syntax with python.

---

## 3. Verification & Acceptance Criteria
- [ ] `.github/workflows/deploy-wiki.yml` is valid YAML and follows security best practices.
- [ ] `tools/deploy_wiki.py` supports running cleanly in GitHub Actions with token authentication.
- [ ] Local tests (`python3 -m unittest discover -s tests`) and link validation (`python3 tools/verify_docs.py`) pass 100%.
- [ ] Workflow is triggered on push and workflow_dispatch.
