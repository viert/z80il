## Zilog Z80 CPU emulation library for .Net

This is a yet another port of libz80 library by Gabriel Gambetta.
The original library can be found at https://github.com/ggambetta/libz80

#### Why?

Making old machines emulators at some point you may realize that in 2018 there are a lot of different languages and environments you can choose from when developing an emulator.
You can freely use whatever you like most and whatever language you know best, however, the best practice is to choose the environment or let's say platform which gives you a
maximum number of features already made in efficient way. 

Building an emulator you'll definitely need some OS window UI, something to work with OpenGL or D3D textures (to emulate old machine screen), something to deal with the keyboard and probably mouse depending on a machine you're trying to emulate. And if you think about it there's such thing as Unity3d which has all of those. Being a game engine, not does it only provides features to create games but it also gives you a nice set of (relatively) low level functions to operate with things mentioned above.

This port is ready to use with Unity3d, however one should keep in mind that to obtain enough speed to emulate CPU (even such an old one like Z80) the only thing you can do is running the CPU emulation in a separate thread which will disallow you to communicate with Unity UI and other classes directly.

Happy hacking!

#### MacOSX build instructions

On MacOSX there's a certain way to build the dll to match Unity3D requirements. Unity Editor requires managed plugins to be built for .Net Framework 3.5 otherwise you won't be able to even use Z80 namespace in your code. I highly recommend to build the DLL using command-line tool mcs like this:

```mcs -target:library -sdk:2 -out:Z80.dll *.cs```

This will build the library with a proper target platform version. Once you have the library file, just drag and drop it to your Assets folder inside Unity Editor. All the references will be created for you automatically so you don't need to update VisualStudio solution properties.

#### Note on Windows building

On Windows the native way to build the dll is to use Visual Studio. However modern versions of VS won't build the code to target .Net 3.5 either as it's considered as legacy. Unless you have an old version of Visual Studio you have to use mcs with `-sdk:2` flag as mentioned in MacOSX build section of this doc to use the library with Unity3D.
