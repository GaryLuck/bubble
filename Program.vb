Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        dim x as single
        dim n = 100000
        dim a(n) as Integer
        dim i as Integer
        dim j as integer
        'dim x as integer

        'FOR i = 1 TO n
            x=1
           ' console.write(str$(a(i)))
        'NEXT I
        'console.writeline("")
        console.writeline("--------------------")

        FOR i = 1 TO n-1
            FOR j = 1 TO n-1
              '  IF a(j) > a(j+1) 
               '     x = a(j): 
               '     a(j) = a(j+1)
                    x=1
                'end if
            next j
        next i

       ' FOR i = 1 to n
        '    console.write(str$(a(i)))
       ' next i

        'console.writeline("")

    End Sub
End Module
