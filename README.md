[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Tiancheng Li, he/him

In the break-down activity, I focused on objects and code them seperately to implement their specfic function. During the break down planning seciton, I seperate the game to Player,UI and multiple seeds. Player GameObejct with component script to implement player's methods move(), plant() and change attributes of number of plants left and planted, Canvas GameObject with component script to use method Updatetext() to update texts. Seed as a Prefab with component sprite instantiate() when player call plant. Then I compared it against the plan and linked each plan to my code. Call Update() every frame to detect inputs on the keyboard to implete players move() and Plant(). every time Plant() was been called instantiate one seed Prefab and change players attributes of number of plants left and planted. Update() called every frame to update changes to texts by use method UpdateText().To implment all required function in the break down plan. My plan changed after view professor's plan. Before I viewed it I think I can change the value of remained and planted seed by calculate the number of instantiated seed Prefab. After I viewed it I realize that I can add two int variable and simply add and subtract them.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
