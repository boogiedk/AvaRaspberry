#!/usr/bin/env bash

echo "Start application run"
cd AvaRaspberry/ && dotnet build
sudo setsid -w dotnet run
echo "Start sleep"
sleep 20s
echo "exit"

