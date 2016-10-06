# SmartUtils  
Collection of utils things to use with .NET  
  
```
Install-Package SmartUtils
```  
  
Methods
  
-------  
  
- [IntHelper.NTimes](#inthelperntimes)  
- [StringHelper.NTimes](#stringhelperntimes)  
- [DirectoryHelper.GetDirectories](#directoryhelpergetdirectories)  
- [StringHelper.SplitCharByChar](#stringhelper.splitcharbychar)  
  
---  
### IntHelper.NTimes  

Repeat the number (System.Int32) for n times.   
  
```
Console.WriteLine(1.NTimes(3));
```  
Result will be:
```
111
```
---
  
### StringHelper.NTimes  

Repeat the string (System.String) for n times.   
  
```
Console.WriteLine("a".NTimes(3));
```  
Result will be:
```
aaa
```
---
  
### StringHelper.SplitCharByChar  

Split a string char by char.   
  
```
string nome = "SmartUtils";

string[] letras = nome.SplitCharByChar();

foreach (var item in letras)
{
    Console.WriteLine(item);
}
```  
Result will be:
```
S
m
a
r
t
U
t
i
l
s
```
---
  
### DirectoryHelper.GetDirectories  
  
Allow to pass multi search patterns to search at directories.  
  
```
string[] directories = DirectoryHelper.GetDirectories(@"C:\temp", "*packages*|*node_modules*|*bin*|*obj*", SearchOption.AllDirectories);

foreach (var directory in directories)
{
    Console.WriteLine(directory);
}
```  
Result will be:
```
C:\temp\packages
C:\temp\node_modules
C:\temp\bin
C:\temp\obj
```
---
  
### News  
    
- 0.0.1 Created the project, added *IntHelper.NTimes* helper method.
- 0.0.2 Added *StringHelper.NTimes* helper method.  
- 0.0.3 Added *StringHelper.SplitCharByChar* helper method.  
- 0.0.4 Added *DirectoryHelper.GetDirectories* helper method.  
  
Danke  
  