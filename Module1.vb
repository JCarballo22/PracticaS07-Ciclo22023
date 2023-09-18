Module Module1

    Sub Main()
        'FunLen()
        'FunSpace()
        'FunLeft()
        'FunRight()
        'FunMid()
        'FunReplace()
        'FunUCase()
        'FunLCase()
        'CondiAnidada()
        SelectCase()
    End Sub

    Sub FunLen()
        Dim texto As String = "Hola estudiantes de Programación II"
        Console.WriteLine(texto)
        Dim contarTexto As Integer = Len(texto)
        Console.WriteLine(contarTexto)

    End Sub

    Sub FunSpace()
        Dim variableEspacios As String

        variableEspacios = Space(7)
        Console.WriteLine(variableEspacios)
        variableEspacios = "Programación II" & Space(10) & "cicloII-23"
        Console.WriteLine(variableEspacios)

    End Sub

    Sub FunLeft()
        Dim textoleft As String = "Las grandes oportunidades nacen de haber sabido aprovechar las pequeña"
        Console.WriteLine(textoleft)
        Dim subTexto As String = Left(textoleft, 30)
        Console.WriteLine(subTexto)

    End Sub

    Sub FunRight()
        Dim textoRight As String = "Las grandes oportunidades nacen de haber sabido aprovechar las pequeña"
        Console.WriteLine(textoRight)
        Dim subTexto As String = Right(textoRight, 30)
        Console.WriteLine(subTexto)

    End Sub

    Sub FunMid()
        Dim texto As String = "Comprender la importancia de las funciones"
        Console.WriteLine(texto)
        Dim variable1 As String = Mid(texto, 12)
        Console.WriteLine(variable1)
        Dim variable2 As String = Mid(texto, 12, 14)
        Console.WriteLine(variable2)
        Dim variable3 As String = Mid(texto, 4, 10)
        Console.WriteLine(variable3)

    End Sub

    Sub FunReplace()
        Dim texto As String = "Los Estudiantes de la UNAB  5"
        Console.WriteLine(texto)

        'Dim textoReemplazar As String = Replace(texto, "o", "a")
        'Dim textoReemplazar As String = Replace(texto, "Estudiantes", "Alumnos/as")
        'Dim textoReemplazar As String = Replace(texto, "5", "10")
        'Dim textoReemplazar As String = Replace(texto, "Los Estudiantes de la", "Estos jovenes van a la")
        texto = texto.Replace("Estudiantes", "Alumnos/as")
        'Console.WriteLine(textoReemplazar)
        Console.WriteLine(texto)
    End Sub

    Sub FunUCase()
        Dim texto As String = "Feliz día del Programador"
        Console.WriteLine(texto)
        Dim textoMayus As String = UCase(texto)
        Console.WriteLine(textoMayus)
        Dim texto1 As String = "Feliz día del Programador"
        Console.WriteLine(texto1)
        texto1 = texto1.ToUpper()
        Console.WriteLine(texto1)

    End Sub

    Sub FunLCase()
        Dim texto As String = "FELIZ DÍA DE LA INDEPENCIA PATRIA"
        Console.WriteLine(texto)
        Dim textoMinus As String = LCase(texto)
        Console.WriteLine(textoMinus)
        Dim texto1 As String = "FELIZ DÍA DE LA INDEPENCIA PATRIA"
        Console.WriteLine(texto1)
        texto1 = texto1.ToLower()
        Console.WriteLine(texto1)

    End Sub

    Sub CondiAnidada()
        Dim entero = False
        Console.WriteLine("Estudiante por favor ingrese un numero entre 1 y 999: ")
        Dim num = Integer.Parse(Console.ReadLine())
        If num >= 1 And num <= 9 Then
            Console.WriteLine("Estudiante tu numero ingresado " & num & " es de tipo unidad")
            entero = True
        Else
            If num >= 10 And num <= 99 Then
                Console.WriteLine("Estudiante tu numero ingresado " & num & " es de tipo decenas")
                entero = True
            Else
                If num >= 100 And num <= 999 Then
                    Console.WriteLine("Estudiante tu numero ingresado " & num & " es de tipo centenas")
                    entero = True
                End If
            End If
        End If
        If entero = False Then
            Console.WriteLine("Estudiante el numero solicitado debe estar entre 1 y 999")
        End If

    End Sub

    Sub SelectCase()
        Console.WriteLine("Usuario brinda un numero entre 1 y 7")
        Dim diaN = Integer.Parse(Console.ReadLine())

        Select Case diaN
            Case 1
                Console.WriteLine("Usted selecciono Lunes y ingreso el numero: " & diaN)
            Case 2
                Console.WriteLine("Usted selecciono Martes y ingreso el numero: " & diaN)
            Case 3
                Console.WriteLine("Usted selecciono Miercoles y ingreso el numero:  " & diaN)
            Case 4
                Console.WriteLine("Usted selecciono Jueves y ingreso el numero: " & diaN)
            Case 5
                Console.WriteLine("Usted selecciono Viernes y ingreso el numero: " & diaN)
            Case 6
                Console.WriteLine("Usted selecciono Sábado y ingreso el numero: " & diaN)
            Case 7
                Console.WriteLine("Usted selecciono Domingo y ingreso el numero: " & diaN)
            Case Else
                Console.WriteLine("Usted no ingreso un numero entre 1 y 7 pero usted ingreso: " & diaN)
        End Select

        Console.WriteLine("Usuario ingresa un dia de la semana")
        Dim diaS = LCase(Console.ReadLine())

        Select Case diaS
            Case "lunes"
                Console.WriteLine("Usted selecciono Lunes")
            Case "martes"
                Console.WriteLine("Usted selecciono Martes")
            Case "miercoles"
                Console.WriteLine("Usted selecciono Miercoles")
            Case "jueves"
                Console.WriteLine("Usted selecciono Jueves")
            Case "viernes"
                Console.WriteLine("Usted selecciono Viernes")
            Case "sábado"
                Console.WriteLine("Usted selecciono Sábado")
            Case "domingo"
                Console.WriteLine("Usted selecciono Domingo")
            Case Else
                Console.WriteLine("Usted no ingreso un dia correcto de la semana")
        End Select


    End Sub

End Module
