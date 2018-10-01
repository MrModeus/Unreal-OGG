# Unreal-OGG (forked to attempt 4.20 compatible version)
## DOES NOT WORK. Compiles. 
The code is compiling in VS 2017 for UE 4.20.2, but there is a crash bug when playing an ogg file. Ogg can be succcessfully imported and even loaded, but when trying to play the loaded sound, there is a crash happening inside of XAudio2.dll.
```Assertion failed: Wave->GetPrecacheState() == ESoundWavePrecacheState::Done [File:D:\Build\++UE4\Sync\Engine\Source\Runtime\Windows\XAudio2\Private\XAudio2Buffer.cpp] [Line: 364]```
## Features
- Allows importing and playing OGG files In UE4
- Master Branch allows you to Import OGG files and played using a LoadOGG Asset function (fast call)
- (Not yet worked on) USoundWave Branch allows same functionality (more or less) as importing a wav file
