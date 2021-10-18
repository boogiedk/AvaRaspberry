[CmdletBinding()]
Param(
    [Parameter(Position=0,Mandatory=$false,ValueFromRemainingArguments=$true)]
    [string[]]$BuildArguments
)

Write-Output "Started run project script."
cd AvaRaspberry/
dotnet run --no-build

Write-Output "Run project script is executed."
