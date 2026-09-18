Module Program
    Sub Main()
        Dim a, b, c As Integer
        While True
            Console.Write("Nhap a: ")
            Try
                a = Integer.Parse(Console.ReadLine())
                Exit While 'Thoat vong lap neu nhap dung'
            Catch
                Console.WriteLine("Loi roi! Vui long nhap so.")
            End Try
        End While

        While True
            Console.Write("Nhap b: ")
            Try
                b = Integer.Parse(Console.ReadLine())
                Exit While
            Catch
                Console.WriteLine("Loi roi! Vui long nhap so.")
            End Try
        End While

        While True
            Console.Write("Nhap c: ")
            Try
                c = Integer.Parse(Console.ReadLine())
                Exit While
            Catch
                Console.WriteLine("Loi roi! Vui long nhap so.")
            End Try
        End While
        
        Dim tong As Integer = a + b + c
        Console.WriteLine("Tong 3 so la: " & tong)
    End Sub
End Module