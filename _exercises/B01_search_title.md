---
title: B01 - Search title
number: 4
status: drafty
authors: marc
lesson: 2
---

We have a arbitrary array of title and want to get the first title from our own search query.[^solution]

[^solution]:
    You can find the solution to this task [Here](https://github.com/satkowski/csharp-solutions/tree/master/02_grundlagen_2/b01_title_search.cs).
    
### Step 1

Create a array of `strings` and fill it with arbitrary book titles.

### Step 2

Create a new `static` method that need the array and a extra string (the search query) as parameter.

It should get you the first appearence of a matching title string and if none was found it returns an empty string.

*Hint: To test if a string contains contains another string use the `Contains()`[^contains] method. This method is case sensetiv.*

[^contains]:
    [MSDN Site](https://msdn.microsoft.com/de-de/library/dy85x1sa%28v=vs.110%29.aspx) for stringobject`.Contains()`
    
### Step 3

Change the `Main` method to the new algorithm.

The user should enter a arbitrary search query. The programm only accept a search query if it has more than 2 characters in it.[^string_length]

[^string_length]:
    You can get the length of a string with the `Length` property of the string. ([MSDN Site](https://msdn.microsoft.com/de-de/library/system.string.length%28v=vs.110%29.aspx))
    
### Step 4

If a title was found it should be printed on the console. Else the programm should print "No title was found.".