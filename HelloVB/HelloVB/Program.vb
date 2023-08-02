Imports System

Module Program
    Sub Main()
        'VB VAriables'

        ' Dim hello As String = "Hello Sring" '

        'Course Variables'
        Dim visBasic As Integer
        Dim mobileApp As Integer
        Dim comLaw As Integer
        Dim result As Integer
        Dim creditPerCourse As Integer
        Dim totalCourses As Integer
        Dim totalCredit As Integer 'used as cumAvg in others' code'

        Dim wVisBasic As Integer
        Dim wMobileApp As Integer
        Dim wComLaw As Integer
        Dim totalWMark As Integer

        ' Course Scores/Marks '
        creditPerCourse = 3
        totalCourses = 3

        visBasic = 80
        mobileApp = 85
        comLaw = 55
        wVisBasic = visBasic * creditPerCourse

        wMobileApp = mobileApp * creditPerCourse

        wComLaw = comLaw * creditPerCourse

        totalWMark = wVisBasic + wMobileApp + wComLaw
        totalCredit = creditPerCourse * totalCourses

        result = totalWMark / totalCredit

        Console.WriteLine("Hello VB!")
        Console.WriteLine("Your CWA is: " & result)
        If result >= 70 Then
            Console.WriteLine("You have First Class!")
        Else Console.WriteLine("You are below FC")
        End If


        Console.WriteLine("End of Program")

        Console.ReadLine()

    End Sub
End Module
