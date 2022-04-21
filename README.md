
# GloverModManager

Mod Manager for the 2022 Steam port of Glover. This only works for n64 version at the moment I think.
Please post new mods on the reddit or discord.

https://www.reddit.com/r/glovermods/

https://discord.gg/6yJJThVdZm

## Installation
Download from the releases page https://github.com/GaryFrazier/GloverModManager/releases
Extract the folder anywhere you desire.

## Making/Downloading Mods
When you start up the mod manager, select the directory for your Glover install, the folder must be the one with Glover.exe in it.

 It will create two folders in the install directory: backup, and mods
 
 The backup folder will hold the data in case you need to revert mods, do not touch.
 
 The mods folder is where you will place mods you create or download.

For more advanced mods (changing the exe), please use the binary diff/patch tools
https://github.com/GaryFrazier/bsdiff

If you are confused please request a tutorial video and I will make one.

### folder structure
For a mod to work, it MUST match the folder structure of the files in the "data" folder in order to replace files correctly. For example, if you want to replace this texture:

    {glover install dir}\data\textures\generic\TitleScreen\saveslot.bmp

Then for your mod, you must have a folder structure like this with the replaced files:

    {glover install dir}\mods\{YOUR MOD NAME}\textures\generic\TitleScreen\saveslot.bmp
You may put as many replaced files in your mod as long as the folder structure and file names match. To share your mod, just archive the {YOUR MOD NAME} folder, and tell others to extract that folder to the "mods" folder so it looks like the example above.

## Load Mods
Select the directory for your Glover install, the folder must be the one with Glover.exe in it

A checklist with appear with all of the mod folders in this folder

	{glover install directory}/mods 
Check the ones you want to install, order matters, the first ones you check will have higher priority. You can see the priority order below the checkboxes. If your mods have conflicting files, ones with higher priority will overwrite.

When ready hit the load mods button and it will copy the files over. Then you can simply  start up the game.


## Unload Mods
Ensure you have the glover directory selected, and you did not mess with the backup folder. Then just hit the reset mod button and it will revert all changes. Any files not in the base game will still remain for now.

## Troubleshooting
Try running as administrator
