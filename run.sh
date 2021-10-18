#!/usr/bin/env bash

echo "Started run project script."

# Configure linux machine

# Explicitly setting DISPLAY=:0 is usually a way to access a machine's local display from outside the local session
export DISPLAY=:0

cd AvaRaspberry/bin/Release/net5.0/ || exit

# Decrypt AppSettings config with help Github Secrets 
gpg --quiet --batch --yes --decrypt --passphrase="$SECRET_PASSPHRASE" \
--output appsettings.json appsettings.json.gpg

# Run
( dotnet AvaRaspberry.dll & )
echo "Run project script is executed."

