# AGENTS.md

## Repository working rules

You must keep these project documents up to date whenever relevant code or architecture changes:
- AI_CONTEXT.md
- AI_TASKS.md
- AI_PROMPTS.md

## Update rules

### 1. AI_CONTEXT.md
Update when any of the following changes:
- project architecture
- tech stack
- module boundaries
- API routes
- database schema
- repository structure
- data flow or aggregation rules

### 2. AI_TASKS.md
Update when any of the following changes:
- current development stage
- next-step priorities
- completed tasks
- blocked items
- handoff suggestions
- refactor / migration plans

### 3. AI_PROMPTS.md
Update when any of the following changes:
- recommended Codex prompts
- task templates
- implementation prompts
- debugging prompts
- migration prompts
- validation / review prompts

## Mandatory workflow for every task

Before coding:
1. Read AI_CONTEXT.md, AI_TASKS.md, and AI_PROMPTS.md.
2. If they are outdated, update them first or alongside the code change.

After coding:
1. Check whether the change affects context, tasks, or prompt templates.
2. If yes, update the relevant markdown files in the same diff.
3. In the final summary, explicitly list which of the three files were updated and why.

## Scope control
- Keep documentation updates concise and factual.
- Do not rewrite the whole file unless necessary.
- Preserve existing structure and headings when possible.