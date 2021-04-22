REM https://wiki.inkscape.org/wiki/index.php/Using_the_Command_Line
FOR %%a IN (*.svg) DO "C:\Program Files\Inkscape\bin\inkscape.exe" %%a --export-filename="%%~na.png"

REM https://imagemagick.org/script/convert.php
magick.exe .\AppIconDark.png .\AppIconDark.ico
magick.exe .\AppIconLight.png .\AppIconLight.ico
