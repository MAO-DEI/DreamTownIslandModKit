# AGENTS.md

## Repository working rules

You must keep these project documents up to date whenever relevant changes occur:

- AI_CONTEXT.md
- AI_TASKS.md
- AI_PROMPTS.md
- docs/DEVELOPMENT_ENV.md
- 
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

## Mandatory workflow for every task

Before coding:

1. Read:
   - AI_CONTEXT.md
   - AI_TASKS.md
   - AI_PROMPTS.md
   - docs/DEVELOPMENT_ENV.md

2. If any document is outdated, update it before or alongside the code change.

After coding:

1. Check whether the change affects:
   - project context
   - development environment
   - current tasks
   - prompt templates

2. Update all relevant markdown files in the same commit.

3. In the final summary, explicitly list:
   - which markdown files were updated;
   - why they were updated;
   - whether DEVELOPMENT_ENV.md requires any manual action from the developer.

## Scope control
- Keep documentation updates concise and factual.
- Do not rewrite the whole file unless necessary.
- Preserve existing structure and headings when possible.
  
### 4. docs/DEVELOPMENT_ENV.md

Update when any of the following changes:

- development tools
- IDE configuration
- .NET SDK version
- BepInEx version
- Harmony version
- Unity version
- IL2CPP / Mono runtime information
- operating system requirements
- project dependencies
- required downloads
- download links
- installation procedures
- environment verification commands
- version detection commands
- compatibility notes
- known issues
- troubleshooting steps
- lessons learned during setup
  
## Documentation policy

The repository documentation is part of the source code.

Every implementation should keep the documentation synchronized.

Priority:

1. docs/DEVELOPMENT_ENV.md
2. AI_CONTEXT.md
3. AI_TASKS.md
4. AI_PROMPTS.md
5. README.md (if user-facing behavior changes)

## Never lose setup knowledge

Whenever a setup issue, compatibility problem, installation pitfall, or debugging experience is solved, document it in docs/DEVELOPMENT_ENV.md.

Do not assume the same issue will be remembered in future conversations.