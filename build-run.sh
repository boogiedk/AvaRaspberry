#!/usr/bin/env bash

echo "Start execute run script"
cd AvaRaspberry/bin/Debug/net5.0/ || exit
( dotnet run AvaRaspberry.dll & )
echo "script is executed"

