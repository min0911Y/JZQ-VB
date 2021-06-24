





Module Module1



    '每个按钮点下的值
    '''
    ''' b代表白
    ''' 
    ''' a代表黑
    Public a1%
    Public a2%
    Public a3%
    Public a4%
    Public a5%
    Public a6%
    Public a7%
    Public a8%
    Public a9%


    Public b1%
    Public b2%
    Public b3%
    Public b4%
    Public b5%
    Public b6%
    Public b7%
    Public b8%
    Public b9%
    Public ai%
    Public Sub _intw_()
        If a1 = 1 Then
            Form1.Button1.Text = "1"
            Form1.Button19.Text = "1"
        End If
        If a2 = 1 Then
            Form1.Button2.Text = "2"
            Form1.Button20.Text = "2"
        End If
        If a3 = 1 Then
            Form1.Button3.Text = "3"
            Form1.Button21.Text = "3"
        End If
        If a4 = 1 Then
            Form1.Button4.Text = "4"
            Form1.Button22.Text = "4"
        End If
        If a5 = 1 Then
            Form1.Button5.Text = "5"
            Form1.Button23.Text = "5"
        End If
        If a6 = 1 Then
            Form1.Button6.Text = "6"
            Form1.Button24.Text = "6"
        End If
        If a7 = 1 Then
            Form1.Button7.Text = "7"
            Form1.Button25.Text = "7"

        End If
        If a8 = 1 Then
            Form1.Button8.Text = "8"
            Form1.Button26.Text = "8"
        End If
        If a9 = 1 Then
            Form1.Button9.Text = "9"
            Form1.Button27.Text = "9"
        End If

        If b1 = 1 Then
            Form1.Button19.Text = "一"
            Form1.Button1.Text = "一"
        End If
        If b2 = 1 Then
            Form1.Button20.Text = "二"
            Form1.Button2.Text = "二"
        End If
        If b3 = 1 Then
            Form1.Button21.Text = "三"
            Form1.Button3.Text = "三"
        End If
        If b4 = 1 Then
            Form1.Button22.Text = "四"
            Form1.Button4.Text = "四"
        End If
        If b5 = 1 Then
            Form1.Button23.Text = "五"
            Form1.Button5.Text = "五"
        End If
        If b6 = 1 Then
            Form1.Button24.Text = "六"
            Form1.Button6.Text = "六"
        End If
        If b7 = 1 Then
            Form1.Button25.Text = "七"
            Form1.Button7.Text = "七"
        End If
        If b8 = 1 Then
            Form1.Button26.Text = "八"
            Form1.Button8.Text = "八"
        End If
        If b9 = 1 Then
            Form1.Button27.Text = "九"
            Form1.Button9.Text = "九"

        End If
    End Sub
    Public Sub _show_(x)
        '显示函数
        If x = 1 Then
            Form1.Button19.Visible = True
            Form1.Button20.Visible = True
            Form1.Button21.Visible = True
            Form1.Button22.Visible = True
            Form1.Button23.Visible = True
            Form1.Button24.Visible = True
            Form1.Button25.Visible = True
            Form1.Button26.Visible = True
            Form1.Button27.Visible = True
        ElseIf x = 2 Then
            Form1.Button1.Visible = True
            Form1.Button2.Visible = True
            Form1.Button3.Visible = True
            Form1.Button4.Visible = True
            Form1.Button5.Visible = True
            Form1.Button6.Visible = True
            Form1.Button7.Visible = True
            Form1.Button8.Visible = True
            Form1.Button9.Visible = True
        End If
    End Sub
    Public Sub _hide_(x)
        '藏匿函数
        If x = 1 Then
            Form1.Button19.Visible = False
            Form1.Button20.Visible = False
            Form1.Button21.Visible = False
            Form1.Button22.Visible = False
            Form1.Button23.Visible = False
            Form1.Button24.Visible = False
            Form1.Button25.Visible = False
            Form1.Button26.Visible = False
            Form1.Button27.Visible = False
        ElseIf x = 2 Then
            Form1.Button1.Visible = False
            Form1.Button2.Visible = False
            Form1.Button3.Visible = False
            Form1.Button4.Visible = False
            Form1.Button5.Visible = False
            Form1.Button6.Visible = False
            Form1.Button7.Visible = False
            Form1.Button8.Visible = False
            Form1.Button9.Visible = False
        End If
    End Sub
    Public Sub _re_()
        '一个废弃的重启函数 

        Form1.Button10.Visible = False
        Form1.Button11.Visible = False
        Form1.Button12.Visible = False
        Form1.Button13.Visible = False
        Form1.Button14.Visible = False
        Form1.Button15.Visible = False
        Form1.Button16.Visible = False
        Form1.Button17.Visible = False
        Form1.Button18.Visible = False

        Form1.Button1.Visible = True
        Form1.Button2.Visible = True
        Form1.Button3.Visible = True
        Form1.Button4.Visible = True
        Form1.Button5.Visible = True
        Form1.Button6.Visible = True
        Form1.Button7.Visible = True
        Form1.Button8.Visible = True
        Form1.Button9.Visible = True


        Form1.Button1.Enabled = True

        Form1.Button2.Enabled = True
        Form1.Button3.Enabled = True
        Form1.Button4.Enabled = True
        Form1.Button5.Enabled = True
        Form1.Button6.Enabled = True
        Form1.Button7.Enabled = True
        Form1.Button8.Enabled = True
        Form1.Button8.Enabled = True
        Form1.Button9.Enabled = True


        Form1.Button19.Enabled = True

        Form1.Button20.Enabled = True
        Form1.Button21.Enabled = True
        Form1.Button22.Enabled = True
        Form1.Button23.Enabled = True
        Form1.Button24.Enabled = True
        Form1.Button25.Enabled = True
        Form1.Button26.Enabled = True

        Form1.Button27.Enabled = True


        a1 = 0
        a2 = 0
        a3 = 0
        a4 = 0
        a5 = 0
        a6 = 0
        a7 = 0
        a8 = 0
        a9 = 0

        b1 = 0
        b2 = 0
        b3 = 0
        b4 = 0
        b5 = 0
        b6 = 0
        b7 = 0
        b8 = 0
        b9 = 0
        Form1.Button1.Text = "1"


        Form1.Button2.Text = "2"
        Form1.Button3.Text = "3"
        Form1.Button4.Text = "4"
        Form1.Button5.Text = "5"
        Form1.Button6.Text = "6"
        Form1.Button7.Text = "7"
        Form1.Button8.Text = "8"
        Form1.Button9.Text = "9"





        Form1.Button19.Text = "一"
        Form1.Button20.Text = "二"
        Form1.Button21.Text = "三"
        Form1.Button22.Text = "四"
        Form1.Button23.Text = "五"
        Form1.Button24.Text = "六"
        Form1.Button25.Text = "七"
        Form1.Button26.Text = "八"
        Form1.Button27.Text = "九"

        _hide_(1)
        _show_(2)
        Form1.Button1.Enabled = True

        Form1.Button2.Enabled = True
        Form1.Button3.Enabled = True
        Form1.Button4.Enabled = True
        Form1.Button5.Enabled = True
        Form1.Button6.Enabled = True
        Form1.Button7.Enabled = True
        Form1.Button8.Enabled = True
        Form1.Button8.Enabled = True
        Form1.Button9.Enabled = True


        Form1.Button19.Enabled = True

        Form1.Button20.Enabled = True
        Form1.Button21.Enabled = True
        Form1.Button22.Enabled = True
        Form1.Button23.Enabled = True
        Form1.Button24.Enabled = True
        Form1.Button25.Enabled = True
        Form1.Button26.Enabled = True

        Form1.Button27.Enabled = True
    End Sub
    Public Sub _str_()

        '一个废弃的 用随机数做的ai



        Randomize()


        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
        If ai = 1 And a1 = 1 Then
            While ai = 1 And a1 = 1
                Randomize()
                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
            End While
        Else
            If ai = 2 And a2 = 1 Then
                While ai = 2 And a2 = 1
                    Randomize()
                    ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                End While
            Else
                If ai = 3 And a3 = 1 Then
                    While ai = 3 And a3 = 1
                        Randomize()
                        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                    End While
                Else
                    If ai = 4 And a4 = 1 Then
                        While ai = 4 And a4 = 1
                            Randomize()
                            ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                        End While
                    Else
                        If ai = 5 And a5 = 1 Then
                            While ai = 5 And a5 = 1
                                Randomize()
                                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                            End While
                        Else
                            If ai = 6 And a6 = 1 Then
                                While ai = 6 And a6 = 1
                                    Randomize()
                                    ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                End While
                            Else
                                If ai = 7 And a7 = 1 Then
                                    While ai = 7 And a7 = 1
                                        Randomize()
                                        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                    End While
                                Else
                                    If ai = 8 And a8 = 1 Then
                                        While ai = 8 And a8 = 1
                                            Randomize()
                                            ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                        End While
                                    Else
                                        If ai = 9 And a9 = 1 Then
                                            While ai = 9 And a9 = 1
                                                Randomize()
                                                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                            End While

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If ai = 1 Then
            Form1.Button1.Enabled = False
            b1 = 1


        Else
            If ai = 2 Then
                Form1.Button2.Enabled = False
                b2 = 1
            Else
                If ai = 3 Then
                    Form1.Button3.Enabled = False
                    b3 = 1
                Else
                    If ai = 4 Then
                        Form1.Button4.Enabled = False
                        b4 = 1
                    Else
                        If ai = 5 Then
                            Form1.Button5.Enabled = False
                            b5 = 1
                        Else
                            If ai = 6 Then
                                Form1.Button6.Enabled = False
                                b6 = 1
                            Else
                                If ai = 7 Then
                                    Form1.Button7.Enabled = False
                                    b7 = 1
                                Else
                                    If ai = 8 Then
                                        Form1.Button8.Enabled = False
                                        b8 = 1
                                    Else
                                        If ai = 9 Then
                                            Form1.Button9.Enabled = False
                                            b9 = 1


                                        End If


                                    End If


                                End If


                            End If


                        End If


                    End If


                End If


            End If


        End If
    End Sub

    Public Sub _intr_()
        If a1 = 1 And a2 = 1 And a3 = 1 Or a4 = 1 And a5 = 1 And a6 = 1 Or a7 = 1 And a8 = 1 And a9 = 1 Or a1 = 1 And a4 = 1 And a7 = 1 Or a2 = 1 And a5 = 1 And a8 = 1 Or a3 = 1 And a6 = 1 And a9 = 1 Or a1 = 1 And a5 = 1 And a9 = 1 Or a3 = 1 And a5 = 1 And a7 = 1 Then
            '检测黑是否胜利

            a1 = 0

            a2 = 0
            a3 = 0
            a4 = 0
            a5 = 0

            a6 = 0
            a7 = 0
            a8 = 0
            a9 = 0

            Dim Re_b%


            Re_b = MsgBox("黑赢了", 64 + 4)
            If Re_b = 6 Then
                Application.Restart()
                End
            Else
                End
            End If





        ElseIf b1 = 1 And b2 = 1 And b3 = 1 Or b4 = 1 And b5 = 1 And b6 = 1 Or b7 = 1 And b8 = 1 And b9 = 1 Or b1 = 1 And b4 = 1 And b7 = 1 Or b2 = 1 And b5 = 1 And b8 = 1 Or b3 = 1 And b6 = 1 And b9 = 1 Or b1 = 1 And b5 = 1 And b9 = 1 Or b3 = 1 And b5 = 1 And b7 = 1 Then
            '检测白是否胜利

            b1 = 0

            b2 = 0
            b3 = 0
            b4 = 0
            b5 = 0

            b6 = 0
            b7 = 0
            b8 = 0
            b9 = 0
            Dim Re_w%
            Re_w = MsgBox("白赢了", 64 + 4)
            If Re_w = 6 Then
                Application.Restart()
                End
            Else
                End
            End If





        Else
            '都没胜利的情况 

        End If
    End Sub
    Public Sub _int_()
        'ai的随机数

        Randomize()

        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
        If ai = 1 And a1 = 1 Then
            While ai = 1 And a1 = 1
                Randomize()
                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
            End While
        Else
            If ai = 2 And a2 = 1 Then
                While ai = 2 And a2 = 1
                    Randomize()
                    ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                End While
            Else
                If ai = 3 And a3 = 1 Then
                    While ai = 3 And a3 = 1
                        Randomize()
                        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                    End While
                Else
                    If ai = 4 And a4 = 1 Then
                        While ai = 4 And a4 = 1
                            Randomize()
                            ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                        End While
                    Else
                        If ai = 5 And a5 = 1 Then
                            While ai = 5 And a5 = 1
                                Randomize()
                                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                            End While
                        Else
                            If ai = 6 And a6 = 1 Then
                                While ai = 6 And a6 = 1
                                    Randomize()
                                    ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                End While
                            Else
                                If ai = 7 And a7 = 1 Then
                                    While ai = 7 And a7 = 1
                                        Randomize()
                                        ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                    End While
                                Else
                                    If ai = 8 And a8 = 1 Then
                                        While ai = 8 And a8 = 1
                                            Randomize()
                                            ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                        End While
                                    Else
                                        If ai = 9 And a9 = 1 Then
                                            While ai = 9 And a9 = 1
                                                Randomize()
                                                ai = Int(Int(9 - 1 + 0) * Rnd() + 0)
                                            End While

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If



    End Sub


End Module
