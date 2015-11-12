Module Module1

    Sub Main()
        Dim keyin, guess, count, min, max As Integer
        count = 0
        min = 0
        max = 1000
        '建立亂數物件 r
        Dim r As New Random
        '透過亂數物件 r 的 Next 方法產生 1-999 之間的亂數並指定給 guess
        guess = r.Next(1, 1000)
        Console.WriteLine(" 猜數字遊戲")
        : Console.WriteLine()
        Do
            Console.Write("猜數子範圍 {0} < ? < {1} ：", min, max)
            keyin = Val(Console.ReadLine) '透過 Val 將輸入的資料轉成數值
            count += 1
            If keyin >= 1 And keyin < 1000 Then
                If keyin = guess Then
                    Console.WriteLine("賓果!猜對了, 答案是 {0}", guess)
                    Exit Do
                ElseIf keyin > guess Then
                    max = keyin '將目前輸入的數字 keyin 指定給 max
                    Console.Write("再小一點!!")
                ElseIf keyin < guess Then
                    min = keyin '將目前輸入的數字 keyin 指定給 min
                    Console.Write("再大一點!!")
                End If
                Console.WriteLine(" 您猜了 {0} 次", count)
                Console.WriteLine()
            Else
                Console.WriteLine("請輸入提示範圍內的數字!")
            End If
        Loop While True
        Console.ReadLine()

    End Sub
End Module
