# SmartUtils  
Collection of utils things to use with .NET  
  
```
Install-Package SmartUtils
```  
  
Methods
  
-------  
  
- [IntHelper.NTimes](#inthelperntimes)  
- [StringHelper.NTimes](#stringhelperntimes)  
  
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
  
### News  
    
- 0.0.1 Created the project, added *IntHelper.NTimes* helper method.
- 0.0.2 Added *StringHelper.NTimes* helper method.  
- 0.0.3 Added *StringHelper.SplitCharByChar* helper method.  
  
Danke  
  