Public Class Form1
    Const 加 As Integer = 1
    Const 减 As Integer = 2
    Const 乘 As Integer = 3
    Const 除 As Integer = 4

    Structure 分数型
        Public 分子 As Integer
        Public 分母 As Integer
    End Structure

    Function 分数负号移分子(被修改分数 As 分数型) As 分数型
        Dim 分数 As 分数型 = 被修改分数
        If (被修改分数.分子 <> 0 And 被修改分数.分母 < 0) Then
            分数 = 分数赋值(-被修改分数.分子, -被修改分数.分母)
        End If
        Return (分数)
    End Function

    Function 分数赋值(分子 As Integer, 分母 As Integer) As 分数型
        Dim 分数 As 分数型
        分数.分子 = 分子
        分数.分母 = 分母
        Return (分数)
    End Function

    Function 分数是否有意义(欲检查的分数 As 分数型) As Boolean
        If (欲检查的分数.分母 = 0) Then
            Return (False)
        End If
        Return (True)
    End Function

    Function 分数运算(分数1 As 分数型, 运算法则 As Integer, 分数2 As 分数型) As 分数型
        Dim 分数 As 分数型
        Dim 分数数组(2) As 分数型
        分数 = 分数赋值(0, 0)
        If (分数是否有意义(分数1) = False Or 分数是否有意义(分数2) = False) Then
            Return (分数)
        End If
        If (运算法则 = 加 Or 运算法则 = 减) Then
            分数数组 = 通分(分数1, 分数2)
            分数1.分子 = 分数数组(0).分子
            分数1.分母 = 分数数组(0).分母
            分数2.分子 = 分数数组(1).分子
            分数2.分母 = 分数数组(1).分母
            分数.分母 = 分数数组(1）.分母
            If (运算法则 = 加) Then
                分数.分子 = 分数1.分子 + 分数2.分子
            Else
                分数.分子 = 分数1.分子 - 分数2.分子
            End If
            Return (分数)
        End If
        If (运算法则 = 乘) Then
            分数.分子 = 分数1.分子 * 分数2.分子
            分数.分母 = 分数1.分母 * 分数2.分母
            分数 = 约分(分数)
            Return (分数)
        End If
        If (运算法则 = 除) Then
            分数.分子 = 分数1.分子 * 分数2.分母
            分数.分母 = 分数1.分母 * 分数2.分子
            分数 = 约分(分数)
            Return (分数)
        End If
    End Function

    Function 取最大公因数(数1 As Integer, 数2 As Integer) As Integer
        Dim 操作数甲 As Integer = 数1
        Dim 操作数乙 As Integer = 数2
        Dim 中间数 As Integer
        While (操作数乙 <> 0)
            中间数 = 操作数甲 Mod 操作数乙
            操作数甲 = 操作数乙
            操作数乙 = 中间数
        End While
        Return (操作数甲)
    End Function

    Function 取最小公倍数(数1 As Integer, 数2 As Integer) As Integer
        Dim 操作数甲 As Integer = 数1
        Dim 操作数乙 As Integer = 数2
        Dim 中间数 As Integer = 操作数甲
        While (中间数 Mod 操作数乙 <> 0)
            中间数 = 中间数 + 操作数甲
        End While
        Return (中间数)
    End Function

    Function 通分(分数1 As 分数型, 分数2 As 分数型) As 分数型()
        Dim 通分后分数(2) As 分数型
        Dim 最小公倍数 As Integer
        If (分数是否有意义(分数1) = False Or 分数是否有意义(分数2) = False) Then
            通分后分数(0) = 分数1
            通分后分数(1) = 分数2
            Return (通分后分数)
        End If
        分数1 = 约分(分数1)
        分数2 = 约分(分数2)
        通分后分数(0).分子 = 分数1.分子
        通分后分数(1).分子 = 分数2.分子
        最小公倍数 = 取最小公倍数(Math.Abs(分数1.分母), Math.Abs(分数2.分母))
        通分后分数(0).分母 = 最小公倍数
        通分后分数(1).分母 = 最小公倍数
        通分后分数(0).分子 = 通分后分数(0).分子 * 最小公倍数 / 分数1.分母
        通分后分数(1).分子 = 通分后分数(1).分子 * 最小公倍数 / 分数2.分母
        通分后分数(0) = 分数负号移分子(通分后分数(0))
        通分后分数(1) = 分数负号移分子(通分后分数(1))
        Return (通分后分数)
    End Function

    Function 约分(分数 As 分数型) As 分数型
        Dim 最大公因数 As Integer
        If (分数是否有意义(分数)) Then
            分数 = 分数负号移分子(分数)
            最大公因数 = 取最大公因数(Math.Abs(分数.分子), Math.Abs(分数.分母))
            分数 = 分数赋值(分数.分子 / 最大公因数, 分数.分母 / 最大公因数)
        End If
        Return (分数)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim 分数1 As 分数型
        Dim 分数2 As 分数型
        Dim 得数 As 分数型
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            分数1.分子 = TextBox1.Text
            分数1.分母 = TextBox2.Text
            分数2.分子 = TextBox3.Text
            分数2.分母 = TextBox4.Text
            得数 = 分数运算(分数1, 加, 分数2)
            If (得数.分子 = 0 And 得数.分母 = 0) Then
                Return
            End If
            TextBox5.Text = 得数.分子
            TextBox6.Text = 得数.分母
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim 分数1 As 分数型
        Dim 分数2 As 分数型
        Dim 得数 As 分数型
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            分数1.分子 = TextBox1.Text
            分数1.分母 = TextBox2.Text
            分数2.分子 = TextBox3.Text
            分数2.分母 = TextBox4.Text
            得数 = 分数运算(分数1, 减, 分数2)
            If (得数.分子 = 0 And 得数.分母 = 0) Then
                Return
            End If
            TextBox5.Text = 得数.分子
            TextBox6.Text = 得数.分母
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim 分数1 As 分数型
        Dim 分数2 As 分数型
        Dim 得数 As 分数型
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            分数1.分子 = TextBox1.Text
            分数1.分母 = TextBox2.Text
            分数2.分子 = TextBox3.Text
            分数2.分母 = TextBox4.Text
            得数 = 分数运算(分数1, 乘, 分数2)
            If (得数.分子 = 0 And 得数.分母 = 0) Then
                Return
            End If
            TextBox5.Text = 得数.分子
            TextBox6.Text = 得数.分母
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim 分数1 As 分数型
        Dim 分数2 As 分数型
        Dim 得数 As 分数型
        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            分数1.分子 = TextBox1.Text
            分数1.分母 = TextBox2.Text
            分数2.分子 = TextBox3.Text
            分数2.分母 = TextBox4.Text
            得数 = 分数运算(分数1, 除, 分数2)
            If (得数.分子 = 0 And 得数.分母 = 0) Then
                Return
            End If
            TextBox5.Text = 得数.分子
            TextBox6.Text = 得数.分母
        End If
    End Sub
End Class
