Class MainWindow
    Private Sub fill1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles fill1.MouseDown, fill2.MouseDown, fill3.MouseDown, fill4.MouseDown, fill5.MouseDown, fill6.MouseDown, fill7.MouseDown, fill8.MouseDown, fill9.MouseDown, fill10.MouseDown, fill11.MouseDown, fill12.MouseDown, fill13.MouseDown, fill14.MouseDown, fill15.MouseDown, fill16.MouseDown
        brush1.Fill = sender.fill
    End Sub

    Private Sub p00_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles p00.MouseDown, p01.MouseDown, p02.MouseDown, p03.MouseDown, p04.MouseDown, p05.MouseDown, p06.MouseDown, p07.MouseDown, p08.MouseDown, p09.MouseDown, p10.MouseDown, p11.MouseDown, p12.MouseDown, p13.MouseDown, p14.MouseDown, p15.MouseDown, p16.MouseDown, p17.MouseDown, p18.MouseDown, p19.MouseDown, p20.MouseDown, p21.MouseDown, p22.MouseDown, p23.MouseDown, p24.MouseDown, p25.MouseDown, p26.MouseDown, p27.MouseDown, p28.MouseDown, p29.MouseDown, p30.MouseDown, p31.MouseDown, p32.MouseDown, p33.MouseDown, p34.MouseDown, p35.MouseDown, p36.MouseDown, p37.MouseDown, p38.MouseDown, p39.MouseDown, p40.MouseDown, p41.MouseDown, p42.MouseDown, p43.MouseDown, p44.MouseDown, p45.MouseDown, p46.MouseDown, p47.MouseDown, p48.MouseDown, p49.MouseDown, p50.MouseDown, p51.MouseDown, p52.MouseDown, p53.MouseDown, p54.MouseDown, p55.MouseDown, p56.MouseDown, p57.MouseDown, p58.MouseDown, p59.MouseDown, p60.MouseDown, p61.MouseDown, p62.MouseDown, p63.MouseDown, p64.MouseDown, p65.MouseDown, p66.MouseDown, p67.MouseDown, p68.MouseDown, p69.MouseDown, p70.MouseDown, p71.MouseDown, p72.MouseDown, p73.MouseDown, p74.MouseDown, p75.MouseDown, p76.MouseDown, p77.MouseDown, p78.MouseDown, p79.MouseDown, p80.MouseDown, p81.MouseDown, p81.MouseDown, p82.MouseDown, p83.MouseDown, p84.MouseDown, p85.MouseDown, p86.MouseDown, p87.MouseDown, p88.MouseDown, p89.MouseDown, p90.MouseDown, p91.MouseDown, p92.MouseDown, p93.MouseDown, p94.MouseDown, p95.MouseDown, p96.MouseDown, p97.MouseDown, p98.MouseDown, p99.MouseDown
        sender.fill = brush1.Fill
    End Sub

    Private Sub p00_MouseMove(sender As Object, e As MouseEventArgs) Handles p00.MouseMove, p01.MouseMove, p02.MouseMove, p03.MouseMove, p04.MouseMove, p05.MouseMove, p06.MouseMove, p07.MouseMove, p08.MouseMove, p09.MouseMove, p10.MouseMove, p11.MouseMove, p12.MouseMove, p13.MouseMove, p14.MouseMove, p15.MouseMove, p16.MouseMove, p17.MouseMove, p18.MouseMove, p19.MouseMove, p20.MouseMove, p21.MouseMove, p22.MouseMove, p23.MouseMove, p24.MouseMove, p25.MouseMove, p26.MouseMove, p27.MouseMove, p28.MouseMove, p29.MouseMove, p30.MouseMove, p31.MouseMove, p32.MouseMove, p33.MouseMove, p34.MouseMove, p35.MouseMove, p36.MouseMove, p37.MouseMove, p38.MouseMove, p39.MouseMove, p40.MouseMove, p41.MouseMove, p42.MouseMove, p43.MouseMove, p44.MouseMove, p45.MouseMove, p46.MouseMove, p47.MouseMove, p48.MouseMove, p49.MouseMove, p50.MouseMove, p51.MouseMove, p52.MouseMove, p53.MouseMove, p54.MouseMove, p55.MouseMove, p56.MouseMove, p57.MouseMove, p58.MouseMove, p59.MouseMove, p60.MouseMove, p61.MouseMove, p62.MouseMove, p63.MouseMove, p64.MouseMove, p65.MouseMove, p66.MouseMove, p67.MouseMove, p68.MouseMove, p69.MouseMove, p70.MouseMove, p71.MouseMove, p72.MouseMove, p73.MouseMove, p74.MouseMove, p75.MouseMove, p76.MouseMove, p77.MouseMove, p78.MouseMove, p79.MouseMove, p80.MouseMove, p81.MouseMove, p81.MouseMove, p82.MouseMove, p83.MouseMove, p84.MouseMove, p85.MouseMove, p86.MouseMove, p87.MouseMove, p88.MouseMove, p89.MouseMove, p90.MouseMove, p91.MouseMove, p92.MouseMove, p93.MouseMove, p94.MouseMove, p95.MouseMove, p96.MouseMove, p97.MouseMove, p98.MouseMove, p99.MouseMove
        If chkdrag.IsChecked Then
            sender.fill = brush1.Fill
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        For index = 0 To 99
            getRect(index).Fill = New SolidColorBrush(Colors.White)
        Next
    End Sub
    Private Function getRect(i As Integer) As Rectangle
        Dim s As String
        If i < 10 Then
            s = "p0" & i
        Else
            s = "p" & i
        End If
        For Each u In Grid1.Children

            If u.name.Startswith(s) Then
                Return u
            End If
        Next
        Return Nothing
    End Function

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        For index = 0 To 49
            getRect(index).Fill = brush1.Fill
        Next
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        For index = 50 To 99
            getRect(index).Fill = brush1.Fill
        Next
    End Sub
End Class
