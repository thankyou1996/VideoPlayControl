@echo off
Set "TMPINF=%temp%\TmpInf.inf"
echo [Version]>%TMPINF%
echo Signature = "$Windows NT$">>%TMPINF%
echo [DefaultInstall] >> %TMPINF%
RUNDLL32 SETUPAPI.DLL,InstallHinfSection DefaultInstall 128 %TMPINF%
del %TMPINF% /q