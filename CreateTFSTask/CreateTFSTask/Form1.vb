Imports System
Imports Microsoft.TeamFoundation.Client
Imports Microsoft.TeamFoundation.WorkItemTracking.Client
Public Class frmCreateTask
    Private Const tfsServerName As String = "http://tfs.bluedoor.local:8080/tfs"
    Private Const workSpacePath As String = "D:\Bluedoor Files\WealthNET TFS"
    Private Const myProject As String = "Wealth.net 200708-001 UAT"
    Private myWorkItemStore As Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItemStore
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim collectionUri As Uri
        collectionUri = New Uri(tfsServerName)
        Try
          
            ValidateFields()
            'Dim tpc As New TfsTeamProjectCollection(collectionUri)
            'Dim workItemStore As WorkItemStore
            'workItemStore = tpc.GetService(Of WorkItemStore)()
            Dim teamProject As Project
            teamProject = myWorkItemStore.Projects(myProject)
            Dim workItemType As WorkItemType
            workItemType = teamProject.WorkItemTypes("Task")
            Dim userStory As New Microsoft.TeamFoundation.WorkItemTracking.Client.WorkItem(workItemType)
            userStory.IterationPath = txtJIRAID.Text
            userStory.Description = txtDescription.Text
            userStory.Title = txtTitle.Text
            userStory.Fields("Client").Value = "OMWOPEN"
            userStory.Fields("TaskType").Value = "Defect"
            userStory.Fields("Timesheet Project").Value = "POLE - Warranty"
            userStory.Fields("Timesheet Task").Value = "OMW-OD"
            userStory.Fields("Tags").Value = "OMW-OD"
            userStory.Fields("Defect Type").Value = "Existing Issue in Prior Release"
            userStory.Fields("Iteration Path 1").Value = "Wealth.net 200708-001 UAT"
            userStory.Tags = txtJIRAID.Text
            userStory.Validate()
            If userStory.IsValid() Then
                userStory.Save()
                LoadTasks()
                MessageBox.Show(userStory.Id.ToString)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to create a new TFS Task.")
        End Try

    End Sub

    Private Sub frmCreateTask_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If myWorkItemStore Is Nothing Then
            Try
                Dim teamProjectCollection As TfsTeamProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(New Uri(tfsServerName))
                myWorkItemStore = DirectCast(teamProjectCollection.GetService(GetType(WorkItemStore)), WorkItemStore)
            Catch ex As Exception
                MessageBox.Show("TFS IS OFFLINE")
            End Try
        End If
        LoadTasks()
    End Sub

    Private Sub btnGetHistory_Click(sender As Object, e As EventArgs) Handles btnGetHistory.Click

        LoadTasks()

    End Sub

    Private Sub LoadTasks()
        'Dim teamProjectCollection As TfsTeamProjectCollection = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(New Uri(tfsServerName))

        'Dim workItemStore = DirectCast(teamProjectCollection.GetService(GetType(WorkItemStore)), WorkItemStore)

        Dim project = myWorkItemStore.Projects(myProject)
        Dim queryHierarchy As QueryHierarchy = project.QueryHierarchy
        Dim queryFolder = TryCast(queryHierarchy, QueryFolder)
        Dim queryItem As QueryItem = queryFolder("My Queries")
        queryFolder = TryCast(queryItem, QueryFolder)

        If queryFolder IsNot Nothing Then
            Dim myQuery = TryCast(queryFolder("POLE-Warranty"), QueryDefinition)
            If myQuery IsNot Nothing Then
                Dim wiCollection = myWorkItemStore.Query(myQuery.QueryText)
                For Each workItem As WorkItem In wiCollection
                    Console.WriteLine(workItem.Title)
                Next
                dgvQueryHistory.AutoGenerateColumns = False
                dgvQueryHistory.DataSource = wiCollection
            End If
        End If
    End Sub

    Private Sub ValidateFields()
        If String.IsNullOrEmpty(txtTitle.Text) Then
            MessageBox.Show("Please provide a title.")
            Return
        End If
        If String.IsNullOrEmpty(txtDescription.Text) Then
            MessageBox.Show("Please provide a Description.")
            Return
        End If
        If String.IsNullOrEmpty(txtJIRAID.Text) Then
            MessageBox.Show("Please provide JIRA task ID.")
            Return
        End If
    End Sub
End Class
