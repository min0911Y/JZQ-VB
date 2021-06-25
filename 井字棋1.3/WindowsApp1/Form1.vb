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

        Button1.Font = New System.Drawing.Font("黑体", 26)
        Button2.Font = New System.Drawing.Font("黑体", 26)
        Button3.Font = New System.Drawing.Font("黑体", 26)
        Button4.Font = New System.Drawing.Font("黑体", 26)
        Button5.Font = New System.Drawing.Font("黑体", 26)
        Button6.Font = New System.Drawing.Font("黑体", 26)
        Button7.Font = New System.Drawing.Font("黑体", 26)
        Button8.Font = New System.Drawing.Font("黑体", 26)
        Button9.Font = New System.Drawing.Font("黑体", 26)

        Button19.Font = New System.Drawing.Font("黑体", 26)
        Button20.Font = New System.Drawing.Font("黑体", 26)
        Button21.Font = New System.Drawing.Font("黑体", 26)
        Button22.Font = New System.Drawing.Font("黑体", 26)
        Button23.Font = New System.Drawing.Font("黑体", 26)
        Button24.Font = New System.Drawing.Font("黑体", 26)
        Button25.Font = New System.Drawing.Font("黑体", 26)
        Button26.Font = New System.Drawing.Font("黑体", 26)
        Button27.Font = New System.Drawing.Font("黑体", 26)

















        Button1.Text = ""


        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""


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

        Button19.Text = ""
        Button20.Text = ""
        Button21.Text = ""
        Button22.Text = ""
        Button23.Text = ""
        Button24.Text = ""
        Button25.Text = ""
        Button26.Text = ""
        Button27.Text = ""
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
        _LIVE_()




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

        _LIVE_()


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
        _LIVE_()


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
        _LIVE_()




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
        _LIVE_()
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
        _LIVE_()

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
        _LIVE_()




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
        _LIVE_()





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
        _LIVE_()


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        b1 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()



        Button1.Enabled = False
        Button19.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        b2 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button2.Enabled = False
        Button20.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        b3 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button3.Enabled = False
        Button21.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        b4 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()



        Button4.Enabled = False
        Button22.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        b5 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button5.Enabled = False
        Button23.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        b6 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button6.Enabled = False
        Button24.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        b7 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button7.Enabled = False
        Button25.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        b8 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button8.Enabled = False
        Button26.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        b9 = 1

        _intr_()

        _hide_(1)
        _show_(2)
        _intw_()


        Button9.Enabled = False
        Button27.Enabled = False
        _LIVE_()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        MsgBox("版本号：1.2.1" + vbCr + "更新内容：更新了UI" + vbCr + vbCr + "版本号：1.3" + vbCr + "更新了和棋的检测", 64， "更新日志")

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Application.Restart()

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        MsgBox("在框内连成3子则为胜利，X为黑棋，先手，O为白棋，后手")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("井字棋" + vbCr + "版本：1.3 已开源"， 64)

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)
        _LIVE_()

    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles Button31.Click
        End

    End Sub
End Class




