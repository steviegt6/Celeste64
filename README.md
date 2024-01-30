# Unnamed Celeste 64 Fork

This is a fork of [*Celeste 64: Fragments of the Mountain*](https://maddymakesgamesinc.itch.io/celeste64), a game made by the original Celeste developers in under 2 weeks for Celeste's 6th Anniversary.

## Installation

### Prerequitsites

 - You need [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

### Building

 - Clone this repo, make sure NuGet packages are found with `dotnet restore`,
 - run `Celeste64.csproj` with `dotnet run` or `dotnet build`.

## License

"Unnamed Celeste 64 Fork" is a fork of *Celeste 64: Fragments of the Mountain*, which may be found at [its GitHub repository](https://github.com/ExOK/Celeste64). Its original licensing terms are as follows:

 - The Celeste IP and everything in the `Content` folder are owned by [Maddy Makes Games, Inc](https://www.maddymakesgames.com/), and no ownership is claimed whatsoever by C64.
 - The `Source` folder, with exceptions where noted, is [licensed under MIT](LICENSE).
 - The `Source/Audio/FMOD` folder contains bindings and binaries from FMOD.

"Unnamed Celeste 64 Fork" rearranges files, but files originally within the `Content` and the Celeste IP remain under ownership of [Maddy Makes Games, Inc](https://www.maddymakesgames.com/) and no ownership is claimed or insinuated through any usage in our fork.

FMOD bindings and binaries have been moved to `src/Celeste64/Audio/FMOD`, and the `Source` folder has been renamed to `src`. All source code, unless otherwise specified or licensed to by FMOD, [licensed under MIT](LICENSE).

### Libraries

 - [Foster](https://github.com/FosterFramework/Foster) + [SDL2](https://github.com/libsdl-org/sdl): input/windowing/rendering
 - [SledgeFormats](https://github.com/LogicAndTrick/sledge-formats): parsing TrenchBroom level formats
 - [SharpGLTF](https://github.com/vpenades/SharpGLTF): parsing and animating glTF2 models
 - [FMOD](https://www.fmod.com): for music and sound effects

### Tools

 - [TrenchBroom](https://trenchbroom.github.io/): for level editing
 - [Blender](https://www.blender.org/): for creating 3D models
 - [Aseprite](https://www.aseprite.org/): for drawing textures

### Resources

 - [khronos glTF Tutorials](https://github.khronos.org/glTF-Tutorials/gltfTutorial/gltfTutorial_020_Skins.html#the-joint-matrices): to figure out how mesh skins/bones work
 - [LearnOpenGL](https://learnopengl.com/Advanced-OpenGL/Depth-testing): for general rendering concepts/normalizing depth
 - [Kenny's Input Prompts](https://kenney.nl/assets/input-prompts): for UI button prompts
 - [Renogare](https://www.dafont.com/renogare.font): font for text

### *Celeste 64: Fragments of the Mountain* was created by:
 - [Maddy Thorson](http://maddymakesgames.com/),
 - [Noel Berry](https://noelberry.ca),
 - [Amora B.](https://amorabettany.com),
 - [Pedro "Saint11" Medeiros](http://saint11.org/),
 - [Power Up Audio](https://powerupaudio.com/),
 - [Lena Raine](https://lena.fyi/),
 - & [Heidy Motta](https://www.heidy.page/).
