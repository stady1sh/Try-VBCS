
''' <summary>
''' Enumから値や名前の取得
''' </summary>
Public Class C001


    Public Enum animal
        dog = 1
        cat = 2
        bear = 3
        monkey = 4
    End Enum

    Public Sub GetValues()

        '' 列挙型の定数の値を配列で取得（Array型）
        Dim values = GetType(animal).GetEnumValues

        For Each value As String In values
            MessageBox.Show(value)
        Next

    End Sub

    Public Sub GetValue()

        Dim value As Integer = animal.bear

        MessageBox.Show(value)

    End Sub

    Public Sub GetNames()

        '' 列挙型の名前を配列で取得（String型）
        Dim values As String() = GetType(animal).GetEnumNames()

        For Each value In values
            MessageBox.Show(value)
        Next

    End Sub

    Public Sub GetName()

        '' 列挙型から、値の一致する名前を取得（String型）
        Dim value As String = GetType(animal).GetEnumName(animal.bear)

        MessageBox.Show(value)

    End Sub

End Class
