#!/usr/bin/env bash

echo "Start build"
cd AvaRaspberry/ && dotnet build
echo "Start run"
dotnet run
