.NET Resource File NewLine
==========================


Carriage Returns and Line Feeds cannot be inlined into .Net Resource Files. 
If you type "\n" that literal will appear in the final string.
When creating a new line in a resource string you need to use SHIFT + ENTER in Visual Studio.
This is a Console application demonstating this.

StackOverflow Question
http://stackoverflow.com/questions/931114/carriage-return-line-feed-in-net-resource-file-app-globalresources
