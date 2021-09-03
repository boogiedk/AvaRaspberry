#!/usr/bin/env bash

echo "Start application run"
cd AvaRaspberry/ && dotnet build
dotnet run &

