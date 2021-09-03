#!/usr/bin/env bash

echo "Start application run"
cd AvaRaspberry/ &&
nohup dotnet run > /home/pi/Desktop/output.txt 2>&1 &    

