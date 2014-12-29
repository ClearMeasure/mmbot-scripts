$rootDir = "T:\TeamCity\buildAgent\work\b388614f6c9b6eba"
$rootScriptsDir = $rootDir + "\scripts"
$targetDir = "c:\mmbot"
$targetScriptsDir = $targetDir + "\scripts"

write-host $rootDir
write-host $rootScriptDir

#stop the service if it is running
try
{
    write-host "Attempting to stop the service"
    cmd --% /c sc stop MMBotService
}
catch
{
    write-host "Unable to stop service, likely already stopped"
}


#delete all existing scripts
write-host "Deleting all scripts on the target"
Set-Location $targetDir
#Remove-Item $("$targetScriptsDir\*")
write-host $("$targetScriptsDir\*")

#copy over all the new scripts
write-host "Copying over new scripts"
Set-Location $rootDir

write-host "Current directory is " $rootDir
write-host "Copying from " $rootScriptsDir
write-host "to " $targetScriptsDir

Copy-Item $("$rootScriptsDir\*") -Destination $targetScriptsDir
write-host $("$rootScriptsDir\*") -Destination $targetScriptsDir

#start the servic
try
{
    write-host "Attempting to start the service"
    cmd --% /c sc start MMBotService
}
catch
{
    write-host "Starting the service failed"
}