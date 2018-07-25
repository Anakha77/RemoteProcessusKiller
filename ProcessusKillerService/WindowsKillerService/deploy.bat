"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe" -u "F:\Services\KillerService\WindowsKillerService.exe"

copy ProcessusKillerService.dll F:\Services\KillerService\ProcessusKillerService.dll
copy WindowsKillerService.exe F:\Services\KillerService\WindowsKillerService.exe
copy WindowsKillerService.exe.Config F:\Services\KillerService\WindowsKillerService.exe.Config

"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\InstallUtil.exe" -i "F:\Services\KillerService\WindowsKillerService.exe"

net start "Windows Killer Service"