Команды сборки и запуска:
С: gcc -Wall -Wextra -pedantic main.c -o main.exe; if ($?) { .\main.exe }
C++: g++ -std=c++17 -Wall -Wextra -pedantic main.cpp -o main.exe; if ($?) { .\main.exe }
Python: python3 main.py
JavaScript: node main.js
TypeScript: tsc main.ts --outDir dist; if ($?) { node dist/main.js }s
Java: javac Main.java; if ($?) { java Main }
C#: dotnet run
F#: dotnet run
Rust: rustc main.rs -o main.exe; if ($?) { .\main.exe }
Go: go run main.go
Bash: bash main.sh
Prolog: swipl -q -s main.pl -g main -t halt
Assembler: gcc main.s; if ($?) { .\a.exe }