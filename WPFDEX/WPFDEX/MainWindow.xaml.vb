Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Shinobird.Visibility = Visibility.Visible
        Visas.Visibility = Visibility.Hidden
        Snake.Visibility = Visibility.Hidden
        visasb.Visibility = Visibility.Hidden
        birdb.Visibility = Visibility.Hidden
        snakeb.Visibility = Visibility.Hidden
        back.Visibility = Visibility.Visible
        Zach.Text = "Activate effects on the return of spirits monsters during the end phase. Then ritual summon either shinobird baron or shinobird baroness to return either backrow card and summon from deck or return monsters and summon from the hand. Comebine these ability with Stars Align Above the Shrine to ritual summon during your opponents turn and manage to add materials for the ritual summon during the end phase."
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Shinobird.Visibility = Visibility.Hidden
        Visas.Visibility = Visibility.Visible
        Snake.Visibility = Visibility.Hidden
        visasb.Visibility = Visibility.Hidden
        birdb.Visibility = Visibility.Hidden
        snakeb.Visibility = Visibility.Hidden
        back.Visibility = Visibility.Visible
        Zach.Text = "5 sub archetypes, uses fusion, synchro, xyz, link, pendulum. "
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Shinobird.Visibility = Visibility.Hidden
        Visas.Visibility = Visibility.Hidden
        Snake.Visibility = Visibility.Visible
        visasb.Visibility = Visibility.Hidden
        birdb.Visibility = Visibility.Hidden
        snakeb.Visibility = Visibility.Hidden
        back.Visibility = Visibility.Visible
        Zach.Text = "TERRIBLE meta, ash got banned so trash, combos with DB, pyro type monster"
    End Sub

    Private Sub back_Click(sender As Object, e As RoutedEventArgs) Handles back.Click
        Shinobird.Visibility = Visibility.Visible
        Visas.Visibility = Visibility.Visible
        Snake.Visibility = Visibility.Visible
        visasb.Visibility = Visibility.Visible
        birdb.Visibility = Visibility.Visible
        snakeb.Visibility = Visibility.Visible
        back.Visibility = Visibility.Hidden
    End Sub
End Class
