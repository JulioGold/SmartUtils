# SmartUtils  
Collection of utils things to use with .NET  
  
```
Install-Package SmartUtils
```  
  
Methods
  
-------  
  
- [IntHelper.NTimes](#inthelperntimes)  
- [StringHelper.NTimes](#stringhelperntimes)  
- [StringHelper.SplitCharByChar](#stringhelpersplitcharbychar)  
- [DirectoryHelper.GetDirectories](#directoryhelpergetdirectories)  
- [StringHelper.GetHash](#stringhelpergethash)  
- [StringHelper.NormalizeWhitespace](#stringhelpernormalizewhitespace)  
- [StringHelper.Numbers](#stringhelpernumbers)  
- [StringHelper.Join](#stringhelperjoin)  
- [StringHelper.JoinWithoutNullOrEmpty](#stringhelperjoinwithoutnullorempty)  
- [StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace](#stringhelperjoinwithoutnulloremptyorwhitespace)  
- [StringHelper.RemoveAccents](#stringhelperremoveaccents)  
- [IntHelper.IsPrime](#inthelperisprime)  
- [SmartUtils.CheckHasNull](#smartutilscheckhasnull)  
  
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
### StringHelper.GetHash  

Get a hash of an string.   
  
```
Console.WriteLine("SmartUtils".GetHash());
```  
Result will be:
```
vt/cEBO9y0rflBFpaZWaq+ziDRuIU2ndqYJc1MehbWM=
```
---
### StringHelper.NormalizeWhitespace  

Normalize an text with just one whitespace.  
  
```
Console.WriteLine("        SmartUtils    is     a cool        thing!".NormalizeWhitespace());
```  
Result will be:
```
 SmartUtils is a cool thing!
```
---
### StringHelper.Numbers  

Get just the numbers.  
  
```
Console.WriteLine("Smart4Utils2".Numbers());
```  
Result will be:
```
 42
```
---
### StringHelper.Join  

Join a list with a predicate condition.  
  
```
Console.WriteLine(StringHelper.Join(", ", ((Func<string, bool>)((word) => !String.IsNullOrEmpty(word) && !String.IsNullOrWhiteSpace(word))) , new string[] { "Smart", "Utils", "   ", "" }));
```  
Result will be:
```
Smart, Utils
```
---
### StringHelper.JoinWithoutNullOrEmpty  

Join a list without null or empty objects.  
  
```
Console.WriteLine(StringHelper.JoinWithoutNullOrEmpty(", ", new string[] { "Smart", "Utils", "   ", "" }));
```  
Result will be:
```
Smart, Utils,
```
---
### StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace  

Join a list without null or empty or with just white spaces objects.  
  
```
Console.WriteLine(StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace(", ", new string[] { "Smart", "Utils", "   ", "" }));
```  
Result will be:
```
Smart, Utils
```
---
### StringHelper.RemoveAccents  

Remove accentuation of an text.  
  
```
Console.WriteLine("áéíóú,àèìòù,äëïöü,âêîôû,ÁÉÍÓÚ,ÀÈÌÒÙ,ÄËÏÖÜ,ÂÊÎÔÛ".RemoveAccents());
```  
Result will be:
```
aeiou,aeiou,aeiou,aeiou,aeiou,aeiou,aeiou,aeiou
```
---
### IntHelper.IsPrime  

Check if the passed number is prime numebr or not.   
  
```
Console.WriteLine(7.IsPrime());
Console.WriteLine(14.IsPrime());
Console.WriteLine(19.IsPrime());
```  
Result will be:
```
True
False
True
```
---
### SmartUtils.CheckHasNull  

Check if the parameters list has a null.   
  
```
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(null, 1));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(null, null));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(1, "A"));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(1, null));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { null, 1 }));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { null, null }));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { 1, "A" }));
Console.WriteLine(SmartUtils.SmartUtils.CheckHasNull(new List<object> { 1, null }));
```  
Result will be:
```
True
True
False
True
True
True
False
True
```
---
  
### News  
    
- 0.0.1 Created the project, added *IntHelper.NTimes* helper method.
- 0.0.2 Added *StringHelper.NTimes* helper method.  
- 0.0.3 Added *StringHelper.SplitCharByChar* helper method.  
- 0.0.4 Added *DirectoryHelper.GetDirectories* helper method.  
- 0.0.5 Added *StringHelper.GetHash* helper method.  
- 0.0.6 Added *StringHelper.NormalizeWhitespace* helper method.  
- 0.0.7 Added *StringHelper.Numbers* helper method.  
- 0.0.8 Added *StringHelper.Join* helper method.
- 0.0.9 Added *StringHelper.JoinWithoutNullOrEmpty* helper method.    
- 0.0.10 Added *StringHelper.JoinWithoutNullOrEmptyOrWhiteSpace* helper method.  
- 0.0.11 Added *StringHelper.RemoveAccents* helper method.  
- 0.0.12 Added *IntHelper.IsPrime* helper method.  
- 0.0.13 Added *SmartUtils.CheckHasNull* helper method.  
  
Danke  
  