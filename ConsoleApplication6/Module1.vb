Module Module1

    Sub Main()
        Dim W, H As Integer
        Console.Write("身高(公分) ")
        H = Console.ReadLine
        Console.Write("體重(公斤) ")
        W = Console.ReadLine
        Console.WriteLine("你的BMI值為" & (W / H ^ 2) * 10000)
        Console.ReadLine()
    End Sub

End Module
