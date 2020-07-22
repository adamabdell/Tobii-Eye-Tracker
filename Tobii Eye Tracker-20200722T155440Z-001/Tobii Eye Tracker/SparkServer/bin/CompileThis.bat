@echo off
for %%A in (*.java) do (
	echo 		Compiling" %%A
	javac %%A
	echo.
)
