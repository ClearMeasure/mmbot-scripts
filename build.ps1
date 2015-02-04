$ErrorActionPreference = "Stop"

#$rootDir = "T:\TeamCity\buildAgent\work\b388614f6c9b6eba"
$rootDir = $PSScriptRoot

write-host $PSScriptRoot

$rootScriptsDir = $rootDir + "\scripts"
$targetDir = "c:\mmbot"
$targetScriptsDir = $targetDir + "\scripts"

#stop the service if it is running
try
{
    write-host "Attempting to stop the service"
    #cmd --% /c sc stop MMBotService
    Stop-Service -name "MMBotService"
    #(Get-WmiObject -class win32_service -filter "name = 'MMBotService'").StopService()
}
catch
{
    write-host "Unable to stop service, likely already stopped"
}

try
{
    #delete all existing scripts
    write-host "Deleting all scripts on the target"
    Set-Location $targetDir
    Remove-Item $("$targetScriptsDir\*")
}
catch
{
    write-host "Deleting all the existing scripts failed"
}


try
{
    #copy over all the new scripts
    write-host "Copying over new scripts"
    Set-Location $rootDir
    write-host "Copying from " $rootScriptsDir
    write-host "to " $targetScriptsDir
    Copy-Item $("$rootScriptsDir\*") -Destination $targetScriptsDir
    write-host "Copying completed"
}
catch
{
    write-host "Copying script files failed"
}

write-host "starting service"

#start the service
try
{
    write-host "Attempting to start the service"
    #cmd --% /c sc start MMBotService
    Start-Service -name "MMBotService"
    #(Get-WmiObject -class win32_service -filter "name = 'MMBotService'").StartService()
}
catch
{
    write-host "Starting the service failed"
}
