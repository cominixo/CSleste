This is Celeste Classic written in C# that runs in the new full game. 
 - The actual C# port is located in `Classic.cs` and tries to be as close to 1-1 with the original LUA code as it can.
 - The `Emulator.cs` runs the game inside of a Celeste Scene. It references various Celeste & XNA APIs.
 - The Emulator references some art assets which exist in the Graphics folder.
 - The PICO-8 Name and Logo is owned by Lexaloffle Games LLP

You can play Celeste Classic and view its LUA code here:
https://www.lexaloffle.com/bbs/?tid=2145

# This fork
This fork was made to run with this [open-source Monocle engine](https://bitbucket.org/MattThorson/monocle-engine/), just clone it and put its folder in the main folder (this one). Graphics folder and the Content folder from the Monocle Engine should be moved to ./bin/Debug/netcoreapp2.0/ (I'm too lazy to make this work properly).

Of course, credits to Noel Berry and Matt Thorson for both the original source code and the Monocle Engine.
