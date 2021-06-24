Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '初始化程序

        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button18.Visible = False





        '''为与黑白棋区分
        '''黑棋为阿拉伯数字
        '''白棋为汉字







        Button1.Text = "1"


        Button2.Text = "2"
        Button3.Text = "3"
        Button4.Text = "4"
        Button5.Text = "5"
        Button6.Text = "6"
        Button7.Text = "7"
        Button8.Text = "8"
        Button9.Text = "9"


        '废弃的旧ui方案 可酌情调用 bug较多
        Button10.Text = "o"
        Button11.Text = "o"
        Button12.Text = "o"
        Button13.Text = "o"
        Button14.Text = "o"
        Button15.Text = "o"
        Button16.Text = "o"
        Button17.Text = "o"
        Button18.Text = "o"

        Button19.Text = "一"
        Button20.Text = "二"
        Button21.Text = "三"
        Button22.Text = "四"
        Button23.Text = "五"
        Button24.Text = "六"
        Button25.Text = "七"
        Button26.Text = "八"
        Button27.Text = "九"
        _hide_(1)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a1 = 1

        _intr_() '检测是否胜利
        _hide_(2) '隐藏黑棋界面
        _show_(1) '显示白棋界面
        _intw_()
        Button1.Visible = True
        Button1.Enabled = False
        Button19.Visible = False
        Button19.Enabled = False





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        a2 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button2.Visible = True
        Button2.Enabled = False
        Button20.Visible = False
        Button20.Enabled = False




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        a3 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button3.Visible = True
        Button3.Enabled = False
        Button21.Visible = False
        Button21.Enabled = False



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        a4 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button4.Visible = True
        Button4.Enabled = False
        Button22.Visible = False
        Button22.Enabled = False





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        a5 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button23.Visible = False
        Button5.Visible = True
        Button5.Enabled = False
        Button23.Visible = False
        Button23.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        a6 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button6.Visible = True
        Button6.Enabled = False
        Button24.Visible = False
        Button24.Enabled = False


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        a7 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button7.Visible = True
        Button7.Enabled = False
        Button25.Visible = False
        Button25.Enabled = False





    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        a8 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button8.Visible = True
        Button8.Enabled = False
        Button26.Visible = False
        Button26.Enabled = False





    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        a9 = 1

        _intr_()
        _hide_(2)
        _show_(1)
        _intw_()
        Button9.Visible = True
        Button9.Enabled = False
        Button27.Visible = False
        Button27.Enabled = False


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        b1 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()



        Button1.Enabled = False
        Button19.Enabled = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        b2 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button2.Enabled = False
        Button20.Enabled = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        b3 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button3.Enabled = False
        Button21.Enabled = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        b4 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()



        Button4.Enabled = False
        Button22.Enabled = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        b5 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button5.Enabled = False
        Button23.Enabled = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        b6 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button6.Enabled = False
        Button24.Enabled = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        b7 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button7.Enabled = False
        Button25.Enabled = False
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        b8 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button8.Enabled = False
        Button26.Enabled = False
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        b9 = 1

        _intr_()
        _hide_(1)
        _show_(2)
        _intw_()


        Button9.Enabled = False
        Button27.Enabled = False
    End Sub
End Class

