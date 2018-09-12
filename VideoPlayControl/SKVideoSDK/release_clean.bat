@echo off
@for /r %%i in (
*.aps *.idb *.ncb *.obj *.pch *.sbr *.tmp *.pdb *.bsc *.ilk *.res *.log *.lib *.pgd *.htm
*.sdf *.dep *.ipch *.tlog *.exp *.hpj *.opt *.mdp *.plg *.clw *.user *.h264 *.mp4
*.ipdb *.iobj
) do del /f /q "%%i"
@echo 清理完成！
@pause>nul