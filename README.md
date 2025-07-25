# Tasker
a task/ to do list app coded in C# with an SQLite database

#how to run
download the release-build.zip and unpack
run the tasker.exe to run the program

#how to compile
if you are using the source code, use visual studio to build the app

#database
SQLite is used as the database for portability and the database file is named as tasklist.db

#known issues
whenever a task is added and the program is closed the next opening of the program also adds the time to the already added tasks, this probably occured with the switch from MySQL to SQLite, which will be fixed in a future release.
