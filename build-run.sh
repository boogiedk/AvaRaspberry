#!/usr/bin/env bash

echo "Start execute run script"
cd AvaRaspberry/bin/Release/net5.0/ || exit
( dotnet AvaRaspberry.dll & )
echo "script is executed"

