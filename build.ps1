[CmdletBinding()]
Param(
    [Parameter(Position=0,Mandatory=$false,ValueFromRemainingArguments=$true)]
    [string[]]$BuildArguments
)

Write-Output "Started build and run project script."
dotnet restore
dotnet build --configuration Release 
cd AvaRaspberry/
dotnet run --no-build

Write-Output "Build and run project script is executed."
