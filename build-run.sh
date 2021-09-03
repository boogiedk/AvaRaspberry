#!/usr/bin/env bash

echo "Stat application build"
cd AvaRaspberry/ && dotnet build
echo "Start application run"
dotnet run
