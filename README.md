# UB-ModelsBuilderTest
Testing the Models build API functionality

Effectively just a clean install of Umbraco with the starterkit.

Username and password: test@test.com

Models Builder API installed.
Visual Studio extension used to create models in dll project.

Issue occurs in ExamineStartup.cs lines 58 and 59. Despite a check for having a value on line 55, the variable on line 58 ends up as null.
