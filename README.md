# WebApi.Mono

POC WebApi sous Mono/Linux/Docker : scheduling de taches avec FluentScheduler et auto-hebergement Owin.

## Structure

| Fichier / Dossier | Role |
|-|-|
| `WebScheduler/Dockerfile` | Image Docker Mono |
| `WebScheduler/Program.cs` | Point d'entree (Owin self-hosted) |
| `WebScheduler/MyJob.cs` | Definition des jobs |
| `WebScheduler/Startup.cs` | Configuration Owin |
| `WebScheduler/ScheduledTasks.cs` | Taches planifiees FluentScheduler |
| `WebScheduler/Tools/` | Utilitaires |

## Stack

- C# / Mono
- Owin (self-hosted)
- FluentScheduler
- Docker / Linux
