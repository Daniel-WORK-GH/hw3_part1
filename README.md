# Assignment part 1
I chose to make the 2 suggestion - make the score stationary and make the screen the same size for every aspect ratio.

I removed the label under the player and added a canvas with text. Next i modified the [ScoreAdder](https://github.com/Daniel-WORK-GH/hw3_part1/blob/master/Assets/Scripts/3-collisions/ScoreAdder.cs) 
to work with TMP_Text.

After the score was counting i made the canvas a single ton by name using the give [script](https://github.com/Daniel-WORK-GH/hw3_part1/blob/master/Assets/Scripts/4-levels/SingletonByName.cs). After that i had to make sure the canvas will update its camera when switching levels so the text could show, i made a simple class called [CanvasCameaUpdater](https://github.com/Daniel-WORK-GH/hw3_part1/blob/master/Assets/Scripts/CanvasCameaUpdater.cs).

After the score and canvas were done i only had to make the screen the same size on all devices. I found a froum that talked about this issue so i made [ScreenSizeKeeper](https://github.com/Daniel-WORK-GH/hw3_part1/blob/master/Assets/Scripts/ScreenSizeKeeper.cs).
