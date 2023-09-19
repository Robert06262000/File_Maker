'TODO: Create A Project Class
'TODO: Create A Json file for the Project Class
'TODO: Refactor writeFile procedure to take a string for data input
'TODO: move the input variable up to the global class variable access
'TODO: Seralize Project Class
'TODO: Deseralize The Project json Class
'TODO: Use snippets (insert comment) to add comments to procedures and functions
'TODO: Refactor your code to create subfolders in a separate procedure

'Done: 1, 2, 11'

Imports Newtonsoft.Json
Module Module1
    Dim ProjectName As String
    Dim FullDirectory As String

    Sub Main()

        Dim input As String = 0
        While input <> "exit"
            Console.WriteLine("please enter product name.")
            ProjectName = Console.ReadLine
            Console.WriteLine("Please enter a command  Exit | create")

            input = Console.ReadLine.ToString()
            If input = "create" Then
                CreateNewStuff()
            End If
        End While

    End Sub

    Private Sub CreateNewStuff()
        Dim newFolderPath As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        If ProjectName = "" Then
            ProjectName = " Not Set\"
        End If
        CreateProjectFolder(newFolderPath, ProjectName)
        newFolderPath += "\" + ProjectName
        FullDirectory = newFolderPath
        CreateProjectFolder(newFolderPath, "\Art")
        CreateProjectFolder(newFolderPath, "\Script")
        CreateProjectFolder(newFolderPath, "\Documentation")
        WriteFile("ReadMe.txt", newFolderPath)
        WriteFile("Art\Art_ReadMe.txt", newFolderPath)
        WriteFile("Script\Script_ReadMe.txt", newFolderPath)
        WriteFile("Documentation\Doc_ReadMe.txt", newFolderPath)
        CreateProjectFolder($"{newFolderPath}\Art", "Animations")
        CreateProjectFolder($"{newFolderPath}\Art\Animations", "AnimationClips")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips", "UI")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips\UI", "Menu")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips\UI", "HUD")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips\UI", "Dialogue")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips", "VFX")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips\VFX", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\AnimationClips\VFX", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Animations", "Animators")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators", "UI")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators\UI", "Menu")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators\UI", "HUD")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators\UI", "Dialogue")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators", "VFX")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators\VFX", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Animations\Animators\VFX", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Animations", "Timeline")
        CreateProjectFolder($"{newFolderPath}\Art", "Materials")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "Environment")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "PhysicsMaterials")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "UI")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\UI", "Menu")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\UI", "HUD")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\UI", "Dialogue")
        CreateProjectFolder($"{newFolderPath}\Art\Materials", "VFX")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\VFX", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\VFX", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\VFX", "Environment")
        CreateProjectFolder($"{newFolderPath}\Art\Materials\VFX", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art", "Sprites")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "AnimatedSprites")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "Environment")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "Icons")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "UI")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\UI", "HUD")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\UI", "Menu")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "Utilities")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites", "VFX")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\VFX", "Player")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\VFX", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\VFX", "Environment")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\VFX", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Art\Sprites\VFX", "Utilities")
        CreateProjectFolder($"{newFolderPath}\Art", "TileMapPalettes")
        CreateProjectFolder($"{newFolderPath}\Art\TileMapPalettes", "TileSets")
        CreateProjectFolder(newFolderPath, "\Audio")
        CreateProjectFolder($"{newFolderPath}\Audio", "Player")
        CreateProjectFolder($"{newFolderPath}\Audio\Player", "Attacks")
        CreateProjectFolder($"{newFolderPath}\Audio\Player\Attacks", "Melee")
        CreateProjectFolder($"{newFolderPath}\Audio\Player\Attacks", "Ranged")
        CreateProjectFolder($"{newFolderPath}\Audio\Player", "Emotes")
        CreateProjectFolder($"{newFolderPath}\Audio\Player", "Locomotion")
        CreateProjectFolder($"{newFolderPath}\Audio\Player", "Speech")
        CreateProjectFolder($"{newFolderPath}\Audio", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Audio", "Environment")
        CreateProjectFolder($"{newFolderPath}\Audio", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Audio", "FX")
        CreateProjectFolder($"{newFolderPath}\Audio", "Mixers")
        CreateProjectFolder($"{newFolderPath}\Audio", "Music")
        CreateProjectFolder($"{newFolderPath}\Audio", "UI")
        CreateProjectFolder(newFolderPath, "\Documentation")
        CreateProjectFolder($"{newFolderPath}\Documentation", "Sources")
        CreateProjectFolder($"{newFolderPath}\Documentation\Sources", "Components")
        CreateProjectFolder($"{newFolderPath}\Documentation\Sources", "Guides")
        CreateProjectFolder(newFolderPath, "\Prefabs")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "Audio")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "Player")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "Environment")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "Interactables")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "SceneControl")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "UIPrefabs")
        CreateProjectFolder($"{newFolderPath}\Prefabs", "VFX")
        CreateProjectFolder($"{newFolderPath}\Prefabs\VFX", "Player")
        CreateProjectFolder($"{newFolderPath}\Prefabs\VFX", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Prefabs\VFX", "Environment")
        CreateProjectFolder($"{newFolderPath}\Prefabs\VFX", "Interactables")
        CreateProjectFolder(newFolderPath, "\Scenes")
        CreateProjectFolder($"{newFolderPath}\Scenes", "UI")
        CreateProjectFolder($"{newFolderPath}\Scenes", "Utilities")
        CreateProjectFolder($"{newFolderPath}\Scenes", "Zones")
        CreateProjectFolder(newFolderPath, "\Macros")
        CreateProjectFolder(newFolderPath, "\Script")
        CreateProjectFolder($"{newFolderPath}\Script", "UI")
        CreateProjectFolder($"{newFolderPath}\Script", "Utility")
        CreateProjectFolder($"{newFolderPath}\Script", "AI")
        CreateProjectFolder($"{newFolderPath}\Script", "Audio")
        CreateProjectFolder($"{newFolderPath}\Script", "Character")
        CreateProjectFolder($"{newFolderPath}\Script\Character", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script\Character", "MonoBehaviours")
        CreateProjectFolder($"{newFolderPath}\Script\Character", "StateMachineBehaviours")
        CreateProjectFolder($"{newFolderPath}\Script\Character\StateMachineBehaviours", "Enemies")
        CreateProjectFolder($"{newFolderPath}\Script\Character\StateMachineBehaviours", "Player")
        CreateProjectFolder($"{newFolderPath}\Script", "Core")
        CreateProjectFolder($"{newFolderPath}\Script", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script\Editor", "PackageManagerAssembly")
        CreateProjectFolder($"{newFolderPath}\Script\Editor\PackageManagerAssembly", "PackageManagerAssembly")
        CreateProjectFolder($"{newFolderPath}\Script", "Effect")
        CreateProjectFolder($"{newFolderPath}\Script", "Localization")
        CreateProjectFolder($"{newFolderPath}\Script\Localization", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script", "Objects")
        CreateProjectFolder($"{newFolderPath}\Script\Objects", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script", "SceneManagement")
        CreateProjectFolder($"{newFolderPath}\Script\SceneManagement", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script", "TimeLine")
        CreateProjectFolder($"{newFolderPath}\Script\TimeLine", "Editor")
        CreateProjectFolder($"{newFolderPath}\Script\TimeLine\ScrollingText", "Editor")
        CreateProjectFolder(newFolderPath, "\Models")
        CreateProjectFolder(newFolderPath, "\Graphs")
        CreateProjectFolder($"{newFolderPath}\Graphs", "Macro")
        CreateProjectFolder($"{newFolderPath}\Graphs", "Flow")
        CreateProjectFolder($"{newFolderPath}\Graphs", "State")
        CreateProjectFolder(newFolderPath, "\Sounds")
        CreateProjectFolder(newFolderPath, "\Utilities")
        Console.WriteLine("Project created in: " + FullDirectory)
    End Sub

    Private Sub WriteFile(fileName As String, location As String)
        If fileName <> "" Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(location + "\" + fileName + ".txt", True)
            file.WriteLine("This is a readme file for the team")
            file.Close()
        End If

    End Sub

    Sub CreateProjectFolder(newFolderPath As String, ProjectName As String)
        My.Computer.FileSystem.CreateDirectory(newFolderPath + ProjectName)
    End Sub

End Module