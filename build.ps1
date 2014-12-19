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

#archive the old scripts into a zip file in the root of c:\mmbot
write-host "Creating an archive"
Set-Location c:\mmbot
Get-Childitem c:\mmbot\scripts -Recurse | Write-Zip -IncludeEmptyDirectories -OutputPath C:\mmbot\scriptsarchive.zip

#delete all existing scripts
write-host "Deleting all scripts on the target"
Remove-Item c:\mmbot\scripts\*

#copy over all the new scripts
write-host "Copying over new scripts"
Set-Location C:\mmbot-scripts
Copy-Item c:\mmbot-scripts\scripts\* -Destination c:\mmbot\scripts

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