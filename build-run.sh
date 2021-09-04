#!/usr/bin/env bash

echo "Start execute run script"
cd AvaRaspberry/bin/Release/net5.0/ || exit
export DISPLAY=:0 # Explicitly setting DISPLAY=:0 is usually a way to access a machine's local display from outside the local session
( dotnet AvaRaspberry.dll & )
echo "Script is executed"

