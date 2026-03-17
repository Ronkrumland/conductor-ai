# conductor-ai

Locally-hosted .NET orchestration API providing scoped, authenticated access to home automation, media, and environmental systems for AI agents and local LLMs.

## Status

Under active development

## Integrations

- Philips Hue
- Windows Media Controls (SMTC)
- NWS Weather

## Coming Soon

- Ollama tool use orchestration
- Scoped API key authentication
- Stream Deck integration

## Roadmap

### v0.1.0 - Core

- [x] Philips Hue integration
- [x] Windows Media Controls
- [x] NWS Weather
- [ ] Scoped API key authentication

### v0.2.0 - AI Integration  

- [ ] Ollama tool use orchestration
- [ ] Natural language device control

### v0.3.0 - Extended Integrations

- [ ] Spotify search and queue
- [ ] Stream Deck plugin

### v1.0.0 - Non-Developer Ready

- [ ] First-run setup wizard
- [ ] Windows installer
- [ ] No configuration file editing required

## Setup

Copy the example and fill in your values (from the repo root):

```bash
cp ConductorAI.Api/appsettings.json ConductorAI.Api/appsettings.Development.json
```

Then edit `appsettings.Development.json` in `ConductorAI.Api/` with your local configuration.
Never commit `appsettings.Development.json` — it contains sensitive values
and is excluded by .gitignore.
