# Python Opening Tool

Python Opening Tool is a program that can be used to open Python Source Files. When you open a Python file with Python Opening Tool it will open a window with three buttons. One button opens your file in VS Code, one opens it in Visual Studio, and one runs the file.

note: This application is for Windows only as it uses WinForms.

## How to set it up:

### 1 Download:
Download Python Opening Tool. You can put it anywhere this is not the final executable and you will delete these files after.

### 2 Compile (only do this step if you downloaded the code not the executable directly)
To compile the code you just downloaded you need to first download .NET from https://dotnet.microsoft.com/en-us/download (if you already have .NET just skip this step). Download the installer and install .NET. Open the terminal in the folder you downloaded Python Opening Tool and run this command:
```
dotnet publish
```
This compiles the code into an executable.

This also creates two new folders, one called obj and one called bin. Go into bin\Release\net10.0-windows7.0\publish, you will see the compiled code. Copy ALL the files and paste them into a safe spot like a folder on your C: drive call PythonOpeningTool. You also need to copy and paste visualStudioPath.txt (from the same directory as this README) into that folder.

### 3 How to open code with this:
In File Explorer right click any Python File (.py). Click "Open with". Click "Choose another app". Scroll down and click "Choose an app on your PC". Navigate to where you saved Python Opening Tool and click "Open". You will be put back where you got when you clicked "Choose another app" except this time Python Opening Tool will be an option. Click it and select "Always" if you want it as you default app. If you want to use it only every so often click "Just once" it will stay there for later. You can now open Python files with Python Opening Tool. If you didn't download .NET for compiling the code (or you don't already have it) and instead just downloaded the executable then a window will pop up telling you to download .NET. The window will tell you what to do. (I think .NET is required for apps that use WinForms which is why it asks you to install it but thats just my guess.)

### 4 Tell File Explorer to call Python files "Python Source Files" (optional):
By default, File Explorer takes the file extention (py), capitalizes it (PY), and adds "File" to the end (PY File). If you want File Explorer to call them Python Source Files then follow these two steps:

#### 1:
Open the terminal, paste this in, then press Enter:

```
reg add "HKCR\Applications\PythonOpeningTool.exe" /v FriendlyTypeName /d "Python Source File" /f
reg add "HKCU\Software\Classes\Applications\PythonOpeningTool.exe" /v FriendlyTypeName /d "Python Source File" /f
```

note: You can just right click to paste it.

#### 2:
Open Task Manager and find File Explorer (it will be called Windows Explorer) and right click it (you can hold control to stop all the apps from moving around). Once you right click File Explorer, press restart. Your taskbar will disappear but once it comes back it's ready.
Python files will now be called "Python Source Files"

### If Visual Studio option doesn't work:
If the button that opens the file in Visual Studio doesn't work it's simply because you didn't install Visual Studio where Python Opening Tool thinks you did. To fix it you need to know where your Visual Studio is located. Open Visual Studio and right click it in your taskbar. Right click the tiny one now. Click "Properties". This will open a window with details about Visual Studio. Near the middle it will say "Target: " then the path. Highlight that path and copy it. In the same directory as PythonOpeningTool.exe and this README.md file there is a file called visualStudioPath.txt. Open it. Delete the path in it and paste in yours. When you press the button now, it should work.

The icon used for the executable is a trademark of the Python Software Foundation. This tool is an independent project.