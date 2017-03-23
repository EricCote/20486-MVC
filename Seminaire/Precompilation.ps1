#
#précompilation.ps1
#Le but du script est de précompiler les compilateurs "Roslyn" pour qu'ils soient plus rapides.
#il faut avoir compilé au moins une fois pour que le script fonctionne.
#csc.exe:          compilateur de .cshtml
#vbc.exe:          compilateur de .vbhtml
#vbcsCompiler.exe: compilateur de .aspx et autres
#csi.exe:          ligne de commande interactive en c#

cd .\seminaire\bin\roslyn

#32 bit
& C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install csc.exe
& C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install vbc.exe
& C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install vbcscompiler.exe
& C:\Windows\Microsoft.NET\Framework\v4.0.30319\ngen.exe install csi.exe

#64 bit	
& C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe install csc.exe
& C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe install vbc.exe
& C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe install vbcscompiler.exe
& C:\Windows\Microsoft.NET\Framework64\v4.0.30319\ngen.exe install csi.exe



