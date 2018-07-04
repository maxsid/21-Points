Public Class Form1
    Public xod, a, b As Integer
    ' ****************************
    '          Инфобар
    '*****************************
    Public Sub Pob()
            If Val(MyBall.Text) > 21 And Val(PCBall.Text) <= 21 Then
            Talk.Text = "У вас перебор!"
                LoseBall.Text = Val(LoseBall.Text) + 1
            Else
                If Val(MyBall.Text) <= 21 And Val(PCBall.Text) > 21 Then
                Talk.Text = "У соперника перебор!"
                    WinBall.Text = Val(WinBall.Text) + 1
            Else
                If Val(MyBall.Text) > 21 And Val(PCBall.Text) > 21 Then
                    Talk.Text = "Пербор у всех! Ничья."
                    DrowBall.Text = Val(DrowBall.Text) + 1
                Else
                    If Val(MyBall.Text) < Val(PCBall.Text) Then
                        Talk.Text = "У соперника больше очков!"
                        LoseBall.Text = Val(LoseBall.Text) + 1
                    Else
                        If Val(MyBall.Text) > Val(PCBall.Text) Then
                            Talk.Text = "У вас больше очков!"
                            WinBall.Text = Val(WinBall.Text) + 1
                        Else
                            If Val(MyBall.Text) = Val(PCBall.Text) Then
                                Talk.Text = "Ничья!"
                                DrowBall.Text = Val(DrowBall.Text) + 1
                            Else

                            End If
                        End If
                    End If
                End If
            End If
        End If
        PictureBox4.Visible = True
        Talk.Visible = True
    End Sub
    Public Sub obn()
        ' ****************************
        '     первый вброс кубиков
        '*****************************
        If xod = 1 Then
            ' ****************************
            '         левый кубик
            '*****************************
            If a = 1 Then gk1.Image = WindowsApplication1.My.Resources._1
            If a = 2 Then gk1.Image = WindowsApplication1.My.Resources._2
            If a = 3 Then gk1.Image = WindowsApplication1.My.Resources._3
            If a = 4 Then gk1.Image = WindowsApplication1.My.Resources._4
            If a = 5 Then gk1.Image = WindowsApplication1.My.Resources._5
            If a = 6 Then gk1.Image = WindowsApplication1.My.Resources._6
            ' ****************************
            '        правый кубик
            '*****************************
            If b = 1 Then gk1_2.Image = WindowsApplication1.My.Resources._1_2
            If b = 2 Then gk1_2.Image = WindowsApplication1.My.Resources._2_2
            If b = 3 Then gk1_2.Image = WindowsApplication1.My.Resources._3_2
            If b = 4 Then gk1_2.Image = WindowsApplication1.My.Resources._4_2
            If b = 5 Then gk1_2.Image = WindowsApplication1.My.Resources._5_2
            If b = 6 Then gk1_2.Image = WindowsApplication1.My.Resources._6_2
        End If
        ' ****************************
        '     второй вброс кубиков
        '*****************************
        If xod = 2 Then
            ' ****************************
            '         левый кубик
            '*****************************
            If a = 1 Then gk2.Image = WindowsApplication1.My.Resources._1
            If a = 2 Then gk2.Image = WindowsApplication1.My.Resources._2
            If a = 3 Then gk2.Image = WindowsApplication1.My.Resources._3
            If a = 4 Then gk2.Image = WindowsApplication1.My.Resources._4
            If a = 5 Then gk2.Image = WindowsApplication1.My.Resources._5
            If a = 6 Then gk2.Image = WindowsApplication1.My.Resources._6
            If b = 1 Then gk2_2.Image = WindowsApplication1.My.Resources._1_2
            If b = 2 Then gk2_2.Image = WindowsApplication1.My.Resources._2_2
            If b = 3 Then gk2_2.Image = WindowsApplication1.My.Resources._3_2
            If b = 4 Then gk2_2.Image = WindowsApplication1.My.Resources._4_2
            If b = 5 Then gk2_2.Image = WindowsApplication1.My.Resources._5_2
            If b = 6 Then gk2_2.Image = WindowsApplication1.My.Resources._6_2
        End If
        ' ****************************
        '     третий вброс кубиков
        '*****************************
        If xod = 3 Then
            ' ****************************
            '         левый кубик
            '*****************************
            If a = 1 Then gk3.Image = WindowsApplication1.My.Resources._1
            If a = 2 Then gk3.Image = WindowsApplication1.My.Resources._2
            If a = 3 Then gk3.Image = WindowsApplication1.My.Resources._3
            If a = 4 Then gk3.Image = WindowsApplication1.My.Resources._4
            If a = 5 Then gk3.Image = WindowsApplication1.My.Resources._5
            If a = 6 Then gk3.Image = WindowsApplication1.My.Resources._6
            ' ****************************
            '        правый кубик
            '*****************************
            If b = 1 Then gk3_2.Image = WindowsApplication1.My.Resources._1_2
            If b = 2 Then gk3_2.Image = WindowsApplication1.My.Resources._2_2
            If b = 3 Then gk3_2.Image = WindowsApplication1.My.Resources._3_2
            If b = 4 Then gk3_2.Image = WindowsApplication1.My.Resources._4_2
            If b = 5 Then gk3_2.Image = WindowsApplication1.My.Resources._5_2
            If b = 6 Then gk3_2.Image = WindowsApplication1.My.Resources._6_2
        End If

    End Sub
    ' ****************************
    '     компьютер, формула
    '*****************************
    Public Sub II()
        If (Val(MyBall.Text) <= 21 And Val(MyBall.Text) > Val(PCBall.Text)) Or xod = 1 Then
            a = Int(Rnd() * 6) + 1
            b = Int(Rnd() * 6) + 1
            PCBall.Text = Val(PCBall.Text) + a + b
            obn()  
        End If
    End Sub
    Public Sub Clears()
        gk1.Image = Nothing
        gk1.Image = Nothing
        gk1.Image = Nothing
        gk1.Image = Nothing
        gk1.Image = Nothing
        gk1.Image = Nothing
        gk1_2.Image = Nothing
        gk1_2.Image = Nothing
        gk1_2.Image = Nothing
        gk1_2.Image = Nothing
        gk1_2.Image = Nothing
        gk1_2.Image = Nothing
        gk2.Image = Nothing
        gk2.Image = Nothing
        gk2.Image = Nothing
        gk2.Image = Nothing
        gk2.Image = Nothing
        gk2.Image = Nothing
        gk2_2.Image = Nothing
        gk2_2.Image = Nothing
        gk2_2.Image = Nothing
        gk2_2.Image = Nothing
        gk2_2.Image = Nothing
        gk2_2.Image = Nothing
        gk3.Image = Nothing
        gk3.Image = Nothing
        gk3.Image = Nothing
        gk3.Image = Nothing
        gk3.Image = Nothing
        gk3.Image = Nothing
        gk3_2.Image = Nothing
        gk3_2.Image = Nothing
        gk3_2.Image = Nothing
        gk3_2.Image = Nothing
        gk3_2.Image = Nothing
        gk3_2.Image = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        AllowTransparency = True
        PictureBox1.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        PictureBox3.BackColor = Color.Transparent
        gk1.BackColor = Color.Transparent
        gk1_2.BackColor = Color.Transparent
        gk2.BackColor = Color.Transparent
        gk2_2.BackColor = Color.Transparent
        gk3.BackColor = Color.Transparent
        gk3_2.BackColor = Color.Transparent
        MyBall.BackColor = Color.Transparent
        PCBall.BackColor = Color.Transparent
        WinBall.BackColor = Color.Transparent
        DrowBall.BackColor = Color.Transparent
        LoseBall.BackColor = Color.Transparent
        PictureBox4.BackColor = Color.Transparent
    End Sub
    ' ****************************
    '       кнопка игра
    '*****************************
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox4.Visible = False
        Talk.Visible = False
        PictureBox2.Enabled = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox1.Left = 160
        PictureBox1.Top = 305

        Clears()
        MyBall.Text = 0
        PCBall.Text = 0
        xod = 0
    End Sub
    ' ****************************
    '         кнопка еще
    '*****************************
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox3.Enabled = True
        xod = xod + 1
        If xod < 4 Then
1:          a = Int(Rnd() * 6) + 1
            b = Int(Rnd() * 6) + 1
            If a = 0 Or b = 0 Then GoTo 1
            obn()
            MyBall.Text = Val(MyBall.Text) + a + b
        Else
            MsgBox("Максимум 3 хода")
        End If
    End Sub
    ' ****************************
    '        кнопка стоп
    '*****************************
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Clears()
        For xod = 1 To 3
            II()
        Next
        Pob()
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        If LoseBall.Text >= 10 Then
            Talk.Visible = True
            Talk.Text = "Вы проиграли игру!"
            LoseBall.Text = 0
            DrowBall.Text = 0
            WinBall.Text = 0
        End If
        If WinBall.Text >= 10 Then
            Talk.Visible = True
            Talk.Text = "Вы выиграли игру!"
            LoseBall.Text = 0
            DrowBall.Text = 0
            WinBall.Text = 0
        End If
        If DrowBall.Text >= 10 Then
            Talk.Visible = True
            Talk.Text = "Игра закончилась ничьей!"
            LoseBall.Text = 0
            DrowBall.Text = 0
            WinBall.Text = 0
        End If
    End Sub
End Class
