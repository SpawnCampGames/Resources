### ⛓️‍💥 ROLLBACK UNITY HUB BEFORE FORCED CLOUD STORAGE (version 3.13)

Find Archived Unity Hub Downloads here:
:link: https://github.com/jchu634/UnityHubArchive 💾

- Remove Hub with Add/Remove Programs.
- Install older version of Hub via the archive download.

Then to ensure they won't just auto update without your consent:

- To Disable Auto-Updates
  - Make sure Unity Hub is fully closed (not open in task manager)
  - Navigate to where your Hub is installed.. `C:\Program Files\Unity\Hub\Editor`
  - Go into the `resource` folder and rename or remove `app-update.yml`
  - Relaunch the Unity Hub.. (you shouldn't see the notification at top anymore)
