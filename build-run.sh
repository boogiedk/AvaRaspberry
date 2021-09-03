#!/usr/bin/env bash

echo "Start application run"
sleep 20s
cd AvaRaspberry/ &&
dotnet run &
sleep 10s
echo "Exit"
exit 0    

