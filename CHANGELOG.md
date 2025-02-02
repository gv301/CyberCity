
# Change Log  
All notable changes to this project will be documented in this file.
      
The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## [Unreleased]
### Added

### Changed

### Deprecated

### Removed

### Fixed

### Security

## [2.2.7](https://github.com/aadamhuda/CyberCity/commit/d924def9cb8753e9d7f8aa96a954af7651be556e) - 2023-01-07
### Added
- Added invisible wall to city map where player could jump off edge ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Edited reposition character to immediately reassign player controller rather than onClick ~ [@aadamhuda](https://github.com/aadamhuda)
- Change movement values to avoid movement bug ~ [@aadamhuda](https://github.com/aadamhuda)
- Buffed item spawn rate ~ [@aadamhuda](https://github.com/aadamhuda)
- Migrated mouse clicks to new input system ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed default music volume to 0.5 ~ [@gv301](https://github.com/gv301)
### Fixed
- Fixed enemy spawning issue in City level ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed running back bug ~ [@gv301](https://github.com/gv301)
- Fixed master volume and effects volume in battle ~ [@gv301](https://github.com/gv301)
- Fixed enemies sliding affter narrative end ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed enemies running on the spot whilst in narrative ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed all volume slider scaling to work as intended ~ [@gv301](https://github.com/gv301)

## [2.2.6](https://github.com/aadamhuda/CyberCity/commit/ee815c0cb5e33b1400a1da4144229a2fa7a30cef) - 2023-01-06
### Added
- Enabled the player follow ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added more difficulty settings, enemies out of battle see more in harder difficulties and see further ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Also theyre faster when chasing
- Added narrative for cargo level ~ [@aadamhuda](https://github.com/aadamhuda)
- Added narrative for city level ~ [@aadamhuda](https://github.com/aadamhuda)
- Added narrative for battle tutorial ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Change the settings fonts ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Changed pause to escape button instead of P ~ [@gv301](https://github.com/gv301)
### Fixed
- Fixed the narrative on save ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Fixed heal working with not enough mana ~ [@gv301](https://github.com/gv301)
- Fixed slow run error message ~ [@gv301](https://github.com/gv301)
- Fixed an issue where an enemy wouldnt spawn in WebGl ~ [@Ibraheem717](https://github.com/Ibraheem717)

## [2.2.5](https://github.com/aadamhuda/CyberCity/commit/61119a4cb8c934446de66a309c248c74d12e6920) - 2023-01-06
### Added
- Added footsteps to effects volume ~ [@aadamhuda](https://github.com/aadamhuda)
- Added difficulties that change enemy HP and item spawn rate ~ [@aadamhuda](https://github.com/aadamhuda)
- Added difficulty options in the main menu ~ [@aadamhuda](https://github.com/aadamhuda)
- Added an error message to the loading screen if it takes more than 10 seconds ~ [@aadamhuda](https://github.com/aadamhuda)
- Make item spawner method destroy the base item ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Edited first enemy animator to only contain idle ~ [@aadamhuda](https://github.com/aadamhuda)
- Increased the inital spawn height of the player to 1.5 ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed a logic error with player frozen, it would use the index of enemy target rather than player tracker ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed
- Removed enumerator from loadscene and renamed the method ~ [@aadamhuda](https://github.com/aadamhuda)

## [2.2.4](https://github.com/aadamhuda/CyberCity/commit/b9ce0c4a285cda2a5511db0c308c6f86d107ad1c) - 2023-01-06
### Added
- Added effect fix ~ [@gv301](https://github.com/gv301)
- Added narative scripts to objects ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added an endscreen once the player collects all 8 clues ~ [@Ibraheem717](https://github.com/Ibraheem717)
- When saving pop-up appears if the user isn't near a checkpoint ~ [@Ibraheem717](https://github.com/Ibraheem717)
- When saving pop-up appears if the user doesn't have any data saved on that location ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Main menu checks if there is any last save data otherwise load game isnt an option ~ [@Ibraheem717](https://github.com/Ibraheem717)
- ItemName + 1 appears if the item already exists in the inventory ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added functionality to settings ~ [@aadamhuda](https://github.com/aadamhuda)
- Added audio mixer ~ [@aadamhuda](https://github.com/aadamhuda)
- Completed effects ~ [@gv301](https://github.com/gv301)
  - Also added effects for debuffs, fire, poison, and ice
- Added in battle tutorial for first enemy, disables attack buttons for the tutorial and then re enables them once complete ~ [@aadamhuda](https://github.com/aadamhuda)
  - Tutorial uses narrative system
  - If the enemy is not the tutorial enemy, then in battle, the narrative menu will be destroyed
### Changed
- Updated effects ~ [@gv301](https://github.com/gv301)
- Enemies don't only attack weak players unless they have to ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Moved clue and item interaction over to unity new input system (press 'E' to collect item or clue) ~ [@aadamhuda](https://github.com/aadamhuda)
- Moved enemy engagement over to unity new input system (press 'F' to engage) ~ [@aadamhuda](https://github.com/aadamhuda)
- Moved changing targets in battle control over to unity new input system ('A' and 'D') ~ [@aadamhuda](https://github.com/aadamhuda)
- Moved save menu and pause menu control 'o' 'p' over to new input system ~ [@aadamhuda](https://github.com/aadamhuda)
- The player can now quit to main menu from endgame screen ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Updates input system to 1.4.4 ~ [@aadamhuda](https://github.com/aadamhuda)
- Settings can now adjust master audio, music audio and effects audio volumes ~ [@aadamhuda](https://github.com/aadamhuda)
### Deprecated
- Temporarily removed enemy move learning AI ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed
- Removed everything from settings barring sensitivity and volume ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Fixed
- Fixed enemy attack animations ~ [@gv301](https://github.com/gv301)
- Fixed ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Load game from menu would start from the beginning
  - Load game wouldn't load the correct level
- Fixed boxes in endgame screen ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Fix targeting system null error ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed error with slowrun ~ [@gv301](https://github.com/gv301)

## [2.2.3](https://github.com/aadamhuda/CyberCity/commit/c1856cf780729ed259088abfdff9ad82e5a1ff7b) - 2023-01-03
### Added
- Player can now save on specific save locations and load save locations ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Player can continue from last save if possible ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added footsteps ~ [@gv301](https://github.com/gv301)
### Changed
- Configured attributes (strengths and weaknesses) for enemy and player ~ [@aadamhuda](https://github.com/aadamhuda)
- Configured players and enemies all to have 3 types of attacks ~ [@aadamhuda](https://github.com/aadamhuda)
- Updated input system and camera ~ [@gv301](https://github.com/gv301)
- Changed main menu, loading, battle, narrative canvas to 1920x1080 ~ [@aadamhuda](https://github.com/aadamhuda)
### Deprecated
- compressed textures and meshes to create appropriate file size to avoid using git LFS since incompatible with pages  ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed

### Fixed

### Security

## [2.2.2](https://github.com/aadamhuda/CyberCity/commit/a3016ee37b3918496ed190ce185efbbf4a2d6f18) - 2023-01-03
### Added
- Added 'Enemy Info' Button ~ [@aadamhuda](https://github.com/aadamhuda)
- Added a MP cost for healing ~ [@aadamhuda](https://github.com/aadamhuda)
- Added character names to prefab ~ [@aadamhuda](https://github.com/aadamhuda)
- Added new image to main menu ~ [@aadamhuda](https://github.com/aadamhuda)
- Spheres now appear above checkpoints when player is able to save
- After winning a battle a win screen appears ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - The player can choose to continue
- After losing a battle a lose screen appears ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - The player can choose return to last save
  - The player can choose to quit to menu
- Players can inspect attributes of enemy and player during battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added loading scence ~ [@aadamhuda](https://github.com/aadamhuda)
  - Before loading a level, the game will reroute to loading scene
  - Only added for in between levels, not battles, since its too time consuming
### Removed
- Removed quit button from main menu and added load button ~ [@aadamhuda](https://github.com/aadamhuda)

## [2.2.1](https://github.com/aadamhuda/CyberCity/commit/1e2e25ebf99ddf0886aa2959aca2c00321e8ab02) - 2023-01-01
### Added
- Added bow and shoot effect ~ [@gv301](https://github.com/gv301)
- Added main menu music ~ [@aadamhuda](https://github.com/aadamhuda)
- Added items maxEther and Ether to useable items ~ [@aadamhuda](https://github.com/aadamhuda)
- Added models to Clues, Items ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - When entering a safe area, narrative pops indicating the player is near a safe area
  - When seeing first enemy, the game pauses and instructions are given ( currently diabled )
  - When nearby enemies, items and clues and indicator appears above their heads indicating the player can interact with thm
  - When entering a safe a green bar appears indicator the player can save
- Add icons to player HUD ~ [@aadamhuda](https://github.com/aadamhuda)
- Drawn buttons ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added item images to item menu ~ [@aadamhuda](https://github.com/aadamhuda)
- Added designs for enemy health indicators ~ [@aadamhuda](https://github.com/aadamhuda)
- Drawn win and lose screens ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Players can now save by pressing 'S' in save area ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Changed
- Changed fonts for battle UI to rajdhani font ~ [@aadamhuda](https://github.com/aadamhuda)
- Remodeled Pause Screen ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Changed MC name to 'Nadiya' from 'Eve'~ [@Ibraheem717](https://github.com/Ibraheem717)
### Removed
- Removed guard button ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- Fixed an issue where collecting a clue will leave the player stuck ~ [@Ibraheem717](https://github.com/Ibraheem717)

## [2.2.0](https://github.com/aadamhuda/CyberCity/commit/a47e2aa5f057044180fd9545e6044db6cc110872) - 2022-12-31
### Added
- Added walls/ buildings on city level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added checkpoints to city level map ~ [@sarahbrah7](https://github.com/sarahbrah7) 
- Added a material to the flooring in the city level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Lighting added to city level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added gate to city level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Made a cargo level environment for the battle scene ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Made a city level environment for the battle scene ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added enemies and item spawner in new environment ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added navmesh to new env ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added a sceneshift to move to City Level from Cargo level ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - A pad at the end of cargo level
  - pressing left click will take the player to the next level
- Save & Load now remembers the player scene level ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added functionality to use save data to load correct environment for battle scene based on the level they are on ~ [@aadamhuda](https://github.com/aadamhuda)
- Added different effects for different attacks ~ [@gv301](https://github.com/gv301)
- Drawn characters for dialogue ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Drawn loading screens for city level and cargo level ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added narrative ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Narrative when spawning
  - Narrative when picking up items
- When seeing the first enemy and instruction is given ~ [@Ibraheem717](https://github.com/Ibraheem717)
- All effects except bow and shooting completed ~ [@gv301](https://github.com/gv301)
- Drawn items ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Drawn pause screen ~ [@sarahbrah7](https://github.com/sarahbrah7)
### Changed
- Changed the spawn points in the battle scene to invisible ~ [@aadamhuda](https://github.com/aadamhuda)
- Player attacks enemy when engaging ~ [@gv301](https://github.com/gv301)
- First enemy no longer moves ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Fixed
- Fixed issue where main menu takes you directly into battle ~ [@aadamhuda](https://github.com/aadamhuda)

## [2.1.0](https://github.com/aadamhuda/CyberCity/releases/tag/v2.1.0) - 2022-12-26
### Added
- Added enemies and enemy paths to new enviroment ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added navmesh to new enviroment ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added attack effect animations and sound ~ [@gv301](https://github.com/gv301)
  - Currently completed fire
- Doors now animate ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - When the player has collected 2 clues the first door will open
  - The secound will open on 4 clues
  - The doors will remain open if the player has collected clues
- Added invisible walls to prevent the player from falling off the map ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added floor map to the city level ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Enemies now remember player attributes ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Whenever enemies attack players they log their attack
  - The attack is specific to each companion and affinity
  - The enemies now attack players with known weaknesses
  - Otherwise they'll attack randomly
### Changed
- Updated sword models ~ [@gv301](https://github.com/gv301)
- Scene changes ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Scenes now are changed with names rather than index
  - To change scene use the getter method in SaveData and get the right scene 
  - All scene will be stored in SaveData 

## [2.0.0](https://github.com/aadamhuda/CyberCity/commit/5debe407f5656ddf563416298ebb115cb68bbd18) - 2022-12-24
### Added
- Added item spawner ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
  - If you duplicate item spawner object, you can add a floor panel and the number of pickups and it will randomly create the pickups on the surface
- Added audio and sensitivity ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added sounds to animations ~ [@gv301](https://github.com/gv301)
  - Player heal and attack animation sounds
  - Enemy attack animation sound
- Mouse sensitivity slider now changes camera sensitivity ~ [@gv301](https://github.com/gv301)
- Added reaction animations to being hit ~ [@gv301](https://github.com/gv301)
- Created a battle animator which handles animations and audio ~ [@gv301](https://github.com/gv301)
- Added floor map of the cargo level ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added multiple enemy models, and more enemy types  for enemy variety ~ [@aadamhuda](https://github.com/aadamhuda)
- Added random enemy system which randomly picks the types of the three enemies that the player will face in battle ~ [@aadamhuda](https://github.com/aadamhuda)
- When picking up items, it will appear in inventory ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - To access inventory, Pause then click inventory
  - Right now there's no inventory label so click the empty one
- Inventory is loaded onto battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Player can save on checkpoints ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Loads on most recent save 
  - Save takes in account of:
    - Enemies killed
    - Items taken
    - Player save location
    - Clues 
- Added MP system, attacks have an MP cost and cannot be used if the user has insufficient Magic Points ~ [@aadamhuda](https://github.com/aadamhuda)
- Linked MP system to the Player HUD for real time status of the Players Magic points ~ [@aadamhuda](https://github.com/aadamhuda)
- Added MP save after a battle ~ [@aadamhuda](https://github.com/aadamhuda)
- Added walls to the cargo level ~ [@sarahbrah7](https://github.com/sarahbrah7)
  - Using assets
- Added checkpoints to the cargo level ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added a 4th clue (in code and cargo level environment) ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added gates to the cargo level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Cargo level map sky lighting is set as "stormy" using skybox asset ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added lights to walls throughout the cargo level map ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added sword equip and unequip with sword model ~ [@gv301](https://github.com/gv301)
- Added colliders to environment models ~ [@aadamhuda](https://github.com/aadamhuda)
### Deprecated 
- Reverted player movement to old input system ~ [@gv301](https://github.com/gv301)
### Fixed
- Fixed an issue where killing all enemies with the bow, will still cause battle to continue ~ [@Ibraheem717](https://github.com/Ibraheem717)

## [1.11.1](https://github.com/aadamhuda/CyberCity/commit/100816f745117ea34f7408243ff777666494f39a) - 2022-12-08
### Added
- Added animation for player to revert back to idle when revived ~ [@aadamhuda](https://github.com/aadamhuda)
- Added walls in checkpoints, so player cannot run out ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Fixed
- Fixed bug with rotation on the start of player turn ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed an issue where using an ice attack on a frozen enemy will unfreeze them ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.11.0](https://github.com/aadamhuda/CyberCity/commit/00f6f4381aca777e4f95f3133a05aed961a35f7b) - 2022-12-07
### Added
- Enemies can now use a set of moves ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Players and enemies can now be vulnerable or resistant to type of moves
### Changed
- Remodelled Damage ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Units have resistances and vulnerbilities
  - When attacking an enemy, the enemy checks the type of attack
  - If the enemy is resitant it'll resist 25% of damage and vice versa
  - Damage is stored in a dict

## [1.10.0](https://github.com/aadamhuda/CyberCity/commit/1eae4ed02bd005b454e818c0b0274b80deec1b82) - 2022-12-07
### Added
- Added shoot animation and updated animation speeds ~ [@gv301](https://github.com/gv301)
- Added heal animation ~ [@gv301](https://github.com/gv301)
- Added downed animation for players ~ [@gv301](https://github.com/gv301)
- Added death animation for enemies ~ [@gv301](https://github.com/gv301)
- Added feature: when health item is being used, downed players are unable to be selected ~ [@aadamhuda](https://github.com/aadamhuda)
  - When revive items are selected to be used, then players who aren’t downed are unable to be selected
  - When players are selecting an item, they are able to cancel the selected item by pressing the cancel button, this goes back to item select   
### Changed
- Reworked item menu to fit new HUD ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed item usage: only one item can be used per round ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.9.0](https://github.com/aadamhuda/CyberCity/commit/28767556b80e5c68575d944d9c1d533fdfe81834) - 2022-12-05
### Added
- Added new HUD elements ~ [@aadamhuda](https://github.com/aadamhuda)
  - New designed buttons
  - Abilities menu which now shows the individual abilities rather than using a change attack button
  - Added sprites which will hold player health, Magic points and an icon 
- Added a new tracking system which uses keys A and D to change enemy. Also shows visually the current chosen enemy ~ [@aadamhuda](https://github.com/aadamhuda)
- Added music for out of battle scene and in battle scene ~ [@aadamhuda](https://github.com/aadamhuda)
- Added main menu fonts ~ [@aadamhuda](https://github.com/aadamhuda)
- Added health bars to battle GUI ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Changed player and enemy damage values for balancing ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed
- Removed old HUD elements ~ [@aadamhuda](https://github.com/aadamhuda)
  - Player and enemy names
  - Player and enemy HP
  - Battle Buttons

## [1.8.0](https://github.com/aadamhuda/CyberCity/commit/15b893e0a885bff8c1c2755d84752db42bc73737) - 2022-12-02
### Added
- Added battle inventory and using items ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added checkpoint areas ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Press 'm' to save location in checkpoint 
- Added burn and freeze attack animation ~ [@gv301](https://github.com/gv301)

## [1.7.0](https://github.com/aadamhuda/CyberCity/commit/76132d25a5f4c7dfeb1a5330558fb5ae3adcdd43) - 2022-11-30
### Added
- Added battle camera ~ [@aadamhuda](https://github.com/aadamhuda)
  - Camera will change to each players perspective on their turn
- Added downed state for player ~ [@aadamhuda](https://github.com/aadamhuda)
  - Players objects will not be removed in battle but rather theyll be put into a downed state, this prepares for the ability for players to be revived in battle using items
- Added inventory menu with button items and scrollbar to pause menu prefab ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Inventory has fucntionality but sizing bug on the buttons ~ [@sarahbrah7](https://github.com/sarahbrah7)
### Changed
- Changed how enemies spawn ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - They now instantiate
  - Depending on the difficulty
### Removed
- Removed functions to remove player from array - no longer needed, player now has 'downed variable' ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- Sizing bug fixed within inventory ~ [@sarahbrah7](https://github.com/sarahbrah7)

## [1.6.0](https://github.com/aadamhuda/CyberCity/commit/a4dc0149e005a62920db4adb20cbfda5bee6c044) - 2022-11-20
### Added
- Made a pause screen scene with buttons (save, load, settings, exit) ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Player presses p in prototype and battle scenes and now access pause menu gameobject ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Exit button in pause screen redirects user to main menu ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Resume button added ~ [@sarahbrah7](https://github.com/sarahbrah7)
### Changed
- Pause screen no longer a scene but now a gameobject within the protoype and battle scenes ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Resume button now resumes the game instead of load button resuming the game ~ [@sarahbrah7](https://github.com/sarahbrah7)
### Fixed
- Camera faces player direction ~ [@gv301](https://github.com/gv301)
- changed resume timescale from 0.1f to 1f (causing slowness on resume) ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.5.0](https://github.com/aadamhuda/CyberCity/commit/44b9deb4ec70b1c9ac7a4d4f0a93caca750441c4) - 2022-11-21
### Added
- Added companion models with animations using player animation controller ~ [@aadamhuda](https://github.com/aadamhuda)
  - Companion 1, 2, 3
- Added attack type label ~ [@aadamhuda](https://github.com/aadamhuda)
- Player engages battle with health they ended with in last battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Changed
- Enemies now have set paths ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Cleaned up HUD elements ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed
- Removed camera in enemy weapon model ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- PlayersHealth saves after each battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Fixed restart battle (Game would crash as enemies targeted non-existing player) ~ [@Ibraheem717](https://github.com/Ibraheem717)

## [1.4.0](https://github.com/aadamhuda/CyberCity/commit/c0561ea44561819e207c32c4305ff312e985dc1e) - 2022-11-16
### Added
- Added jump animation ~ [@gv301](https://github.com/gv301)
- Player faces currently targeted enemy ~ [@gv301](https://github.com/gv301)
- Player moves towards enemy when attacking ~ [@gv301](https://github.com/gv301)
- Added out of battle enemy model ~ [@aadamhuda](https://github.com/aadamhuda)
- Added animations for enemy model ~ [@aadamhuda](https://github.com/aadamhuda)
  - Hit, walk, run
- Added in battle enemy models, no animations ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Player runs backwards towards original position after attacking ~ [@gv301](https://github.com/gv301)
- Player now performs a melee attack animation for a normal attack ~ [@gv301](https://github.com/gv301)
- Added all types of attacks ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
  - Player1: normal, shoot, curse (if cursed, do less damage)
  - Player2: normal, fire, burn
  - Player3: normal, grass, poison
  - Player4: normal, water, freeze
- added an attack indicator which shows the current attack type selected on screen ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
### Changed
- Reworked battle animation controller and improved animation smoothness ~ [@gv301](https://github.com/gv301)
### Fixed
- Fixed frozen checks, enemy now applies damage to player when not frozen ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.3.0](https://github.com/aadamhuda/CyberCity/commit/ced73e9c4bd1afc8010ad22e7da76c51dcb8cf20) - 2022-11-16
### Added
- Added multiple players in battle scene ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Player turn now rotates between each player
  - Before switching to enemies, where they will have all their turns
- Added three types of attacks ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
  - Normal: the one we had in prototype
  - Burn
  - Freeze
- Added changeAttackButton: change attack type ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added new player model with animations for player movement ~ [@gv301](https://github.com/gv301)
### Changed
- Enemy now attack random player ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Each player has a HUD, highlighted when using them ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Player model changed ~ [@gv301](https://github.com/gv301)
- Player movements are now animated with idle, walking, and running animations ~ [@gv301](https://github.com/gv301)
- Added one more type of attack called shoot (multi-attack): smaller damage than other attacks, but all the enemies get damaged ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
### Deprecated
- Enemy now attack random player ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Fixed
- Fixed issue with players having 0 health on battle start ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.2.2](https://github.com/aadamhuda/CyberCity/commit/b13895ee07957ebf073990e310515d487f648bb6) - 2022-11-08
### Changed
- Changed cursor lock mode to locked from confined ~ [@aadamhuda](https://github.com/aadamhuda) & [@gv301](https://github.com/gv301)

## [1.2.1](https://github.com/aadamhuda/CyberCity/commit/26d03ab771461bc81f7bfedc06f65c44d92a5dc2) - 2022-11-06
### Added
- Added confined cursor lock state ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Changle clue colour to yellow ~ [@aadamhuda](https://github.com/aadamhuda)
- Change in battle player model to match out of battle player model ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- Camera fixed, no longer goes through walls ~ [@gv301](https://github.com/gv301)
- Fixed restart after completing the game ~ [@gv301](https://github.com/gv301)

## [1.2.0](https://github.com/aadamhuda/CyberCity/commit/124b1789e10248e3d021cc1a096feb6cdf6366bc) - 2022-11-06
### Added
- Main menu scene made ~ [@sarahbrah7](https://github.com/sarahbrah7)
  - With a play game button which goes to the game scene (not battle scene)
  - With an exit game button which exits the game
- Added message when near clue, "press k to interact" ~ [@aadamhuda](https://github.com/aadamhuda)
- Added escape to battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Player can escape battle but will start at the beginning
- Added wait times for escape ~ [@aadamhuda](https://github.com/aadamhuda)
- Created restart button ~ [@aadamhuda](https://github.com/aadamhuda)
  - Restart button instantiates a prefab on player death only, to allow player to restart the battle ~ [@aadamhuda](https://github.com/aadamhuda)
### Changed
- Player presses 'x' and now goes to main menu instead of quitting ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Changed escape key to escape button ~ [@aadamhuda](https://github.com/aadamhuda)
- Reordered the buttons in order of use ~ [@aadamhuda](https://github.com/aadamhuda)
- Reduced the multiplier when enemy attacks you out of battle to 15% extra rather than 33% ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- When accessing game from main menu, variables are all initialised to default/spawn values ~ [@aadamhuda](https://github.com/aadamhuda)
- Clues no longer respawn after battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Fixed bug where players could escape after losing battle ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed clue counter issue, where clue counter would reset after every battle, stopping player from winning ~ [@aadamhuda](https://github.com/aadamhuda)
- Fixed bug where enemy will still attack if player has died ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.1.0](https://github.com/aadamhuda/CyberCity/commit/9eeebcaaf2631df35f68091041883f32df00925e) - 2022-11-05
### Added
- Press 'k' alongside going to the clue to pick it up ~ [@sarahbrah7](https://github.com/sarahbrah7)
### Changed
- Three clues now needed to finish game ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Changed heal value to random integer between 60 and 100 ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed player damage to 35 ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed enemy damage to 20 ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- Fixed health subtracting float values when enemy attacks you out of battle ~ [@aadamhuda](https://github.com/aadamhuda)

## [1.0.0](https://github.com/aadamhuda/CyberCity/commit/0430efa53e206c1d156a4e18d0ac4544077c4967) - 2022-11-03
### Added
- Created a win and start room ~ [@sarahbrah7](https://github.com/sarahbrah7)
- When a clue is picked the game freezes and the user is prompted to quit ~ [@sarahbrah7](https://github.com/sarahbrah7)
  - The game quits if user presses 'x'
- Made health bars over the player and enemies ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added free look camera using Cinemachine ~ [@gv301](https://github.com/gv301)
- Added prototype Scene - the main scene for main environment in prototype ~ [@aadamhuda](https://github.com/aadamhuda)
- Added Enumerator BattleStates which now control game flow using the following states ~ [@aadamhuda](https://github.com/aadamhuda)
  - START, PLAYERTURN, ENEMYTURN, WIN, LOSE
- Added heal functionality - allows player to heal by a certain amount of heal in battle ~ [@aadamhuda](https://github.com/aadamhuda)
- Added specific spawn points for player and enemy sprites ~ [@aadamhuda](https://github.com/aadamhuda)
- Added player and enemy prefabs ~ [@aadamhuda](https://github.com/aadamhuda)
- Added functionality for battle to spawn player and enemy based on prefabs ~ [@aadamhuda](https://github.com/aadamhuda)
- Added short intervals between turns and combat events ~ [@aadamhuda](https://github.com/aadamhuda)
- Added a feature which disables player abilities during an enemy turn ~ [@aadamhuda](https://github.com/aadamhuda)
- Added HUD ~ [@aadamhuda](https://github.com/aadamhuda)
- Added parent class BattleUnit ~ [@aadamhuda](https://github.com/aadamhuda)
- Added multiple enemies to the maze ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Each enemy has their own Alive and Death state ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Enemies roam the maze ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added run feature, player can now run while holding shift ~ [@gv301](https://github.com/gv301)
- Once enemies can see. If they detect players they chase then engage combat to them ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Battles started by enemies causes extra damage to be taken ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Changed
- Changed room into a maze ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Updated player model to match collider (removed arms) ~ [@gv301](https://github.com/gv301)
- Changed TurnController to BattleSystem ~ [@aadamhuda](https://github.com/aadamhuda)
- Buttons in battle now have an onClick function in BattleSystem script ~ [@aadamhuda](https://github.com/aadamhuda)
- HUD elements now have a separate canvas to buttons ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed PlayerAttack class to Player and EnemyAttack class to Enemy ~ [@aadamhuda](https://github.com/aadamhuda)
- Player and Enemy classes are children to BattleUnit ~ [@aadamhuda](https://github.com/aadamhuda)
### Deprecated
- Temporarily disabled exit button ~ [@aadamhuda](https://github.com/aadamhuda)
- Temporarily disabled restart button ~ [@aadamhuda](https://github.com/aadamhuda)
### Removed
- Removed Game loop ~ [@aadamhuda](https://github.com/aadamhuda)
- Removed health bars ~ [@aadamhuda](https://github.com/aadamhuda)
- Removed Guard functionality (due to feedback) ~ [@aadamhuda](https://github.com/aadamhuda)
- Removed Guard button script ~ [@aadamhuda](https://github.com/aadamhuda)
- Removed Attack Button script ~ [@aadamhuda](https://github.com/aadamhuda)
- Removed Change Target script ~ [@aadamhuda](https://github.com/aadamhuda)
### Fixed
- Using Unity's built in CharacterController instead of Rigidbody (no physics necessary) Made player movement smoother. also takes into account camera direction ~ [@gv301](https://github.com/gv301)
  - Player can now jump
- Player only resets position when they win ~ [@Ibraheem717](https://github.com/Ibraheem717)

## [0.0.0](https://github.com/aadamhuda/CyberCity/tree/f5995418d057d2d20d219b8d4cce686b3b783b9d) - 2022-10-25
### Added
- README file added to the repository
- CHANGELOG file added to the repository and records all updates to the game
- Finished basic player movement and camera ~ [@gv301](https://github.com/gv301)
- Created a change scene into and out of battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
  - Return to 'out of battle' by pressing green button
- Game records last position before going to battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added ChangeTargetButton, AttackButton, GuardButton ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added enemy attacks ~ [@HinaMatsuzaki](https://github.com/HinaMatsuzaki)
- Added a pop-up to indicate attack ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Added clues ~ [@gv301](https://github.com/gv301)
- Added walls to environment ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Added health limit, so player health doesnt drop below 0 ~ [@aadamhuda](https://github.com/aadamhuda)
   - Player object disables after death 
- Added restart button ~ [@aadamhuda](https://github.com/aadamhuda)
   - Restart button is auto disabled in battle, and will enable on player death
- Added win screen if player picks up clue ~ [@sarahbrah7](https://github.com/sarahbrah7)
- Enemy sprites disable once they reach 0 health ~ [@aadamhuda](https://github.com/aadamhuda)
- Added health limit for enemies, they cannot drop below 0 health ~ [@aadamhuda](https://github.com/aadamhuda)
- Added scene change once all enemies are defeated in battle ~ [@aadamhuda](https://github.com/aadamhuda)
- Added death to enemy outside of battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
### Changed
- Updated the player movement now so it works better, when you want to go down before you would reverse, now you move forward in whichever direction ~ [@gv301](https://github.com/gv301)
- Reduced enemy damage from 20 to 1 ~ [@aadamhuda](https://github.com/aadamhuda)
- Added walls onto main scene, removed from battle ~ [@Ibraheem717](https://github.com/Ibraheem717)
- Changed enemy damage to 15 from 1 ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed player health from from 100 to 150 ~ [@aadamhuda](https://github.com/aadamhuda)
- Changed player damage from 20 to 50 ~ [@aadamhuda](https://github.com/aadamhuda)
### Deprecated
- Reverted back to intial player movement implementation with transform as opposed to rigidbody ~ [@gv301](https://github.com/gv301)
  - Due to the implementation of a free look camera that is controllable by holding right click on the mouse and dragging.
- Reverted to WASD movement system ~ [@gv301](https://github.com/gv301)
  - Free look disabled as a result 
### Fixed
- Connect the input actions to it so it works with keyboard and controller and other control schemes in the input manager ~ [@gv301](https://github.com/gv301)
