cellent Coding Dojo Sample Codes
=================

Projekt beinhaltet alle durchgeführten Coding Dojos. Programmiert werden die Dojos aktuell in C# in Framework 4.5

### Eingesetze Tools und Frameworks

* [Visual Studio 2015](https://www.visualstudio.com/de-de/vs-2015-product-editions.aspx)
* [xUnit](https://www.nuget.org/packages/xunit)
* [FluentAssertions](https://www.nuget.org/packages/FluentAssertions) 


Durchgeführte  Katas
-------------------------

- *29.10.2015 Stack Kata* - Cellent.CodingDojo.StackKata und Cellent.CodingDojo.StackKata.Tests



---
### Erkenntnisse

1.  Nullprüfung bei Generics
```cs
if (typeof(TElement)==default(TElement))
                throw new InvalidOperationException();
```
`Operator '!=' cannot be applied to operands of type 'T' and 'T'`
`T is a type argument and can be a class or a struct, Thus compiler won't let you perform actions that doesn't exist in classes and structs.`
