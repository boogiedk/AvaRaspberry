#!/usr/bin/env bash

echo "Start application run"
cd AvaRaspberry/ && dotnet build
dotnet run &
echo "Start sleep"
sleep 120s
echo "exit"

