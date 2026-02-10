@echo off
chcp 65001
echo 正在编译烟花程序...
echo.

:: 检查必要文件
if not exist "1.c" (
    echo 错误: 找不到源文件 1.c
    pause
    exit /b 1
)

if not exist "music.wav" (
    echo 警告: 找不到音乐文件 music.wav
    echo 程序将运行但没有背景音乐
)

:: 直接编译主程序（跳过资源文件）
echo 正在编译主程序...
gcc -O2 -o fireworks.exe 1.c -lwinmm -luser32 -lgdi32

if errorlevel 1 (
    echo 编译失败！
    echo 错误代码: %errorlevel%
    pause
    exit /b 1
)

if exist "fireworks.exe" (
    echo.
    echo 编译成功！
    echo 生成的文件: fireworks.exe
    echo.
    echo 运行说明：
    echo 1. 确保 music.wav 文件在同一目录
    echo 2. 双击 fireworks.exe 运行程序
    echo 3. 按 ESC 键退出程序
) else (
    echo 编译失败：未生成可执行文件
)

echo.
pause