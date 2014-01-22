Set fso = CreateObject("Scripting.FileSystemObject")

Set infile  = fso.OpenTextFile("infile.txt")
Set outfile = fso.OpenTextFile("outfile.txt", 2, True)

If Not infile.AtEndOfStream Then outfile.Write infile.ReadLine
Do Until infile.AtEndOfStream
  outfile.Write " -connect Bone_KAO " & infile.ReadLine
Loop
infile.Close
outfile.Close

