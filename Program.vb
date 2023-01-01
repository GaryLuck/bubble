Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        dim n = 1000000
        dim a(n) as Integer
        dim i as Integer
        dim j as integer
        dim x as integer

        FOR i = 1 TO 10
            a(i) = n - i
            console.write(str$(a(i)))
        NEXT I
        console.writeline("")
        console.writeline("--------------------")

        FOR i = 1 TO n-1
            FOR j = 1 TO n-1
                IF a(j) > a(j+1) 
                    x = a(j): 
                    a(j) = a(j+1)
                    a(j+1) = x
                end if
            next j
        next i

        FOR i = 1 to 10
            console.write(str$(a(i)))
        next i

        console.writeline("")

    End Sub
End Module
