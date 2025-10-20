@echo off
set /p commit_message=Enter Commit Message (main): 
git add *
git commit -m "%commit_message%"
git branch -M main
git push origin main
pause
