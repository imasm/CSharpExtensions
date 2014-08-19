# CSharpExtensions

Useful extensions for C#.

## String extensions

#### EqualsNullSafe

Null safe string comparison 

```csharp
const string str1 = "123";
const string str2 = "123";
const string str3 = "abc";
const string strNull = null;

str1.EqualsNullSafe(str1); // true
str1.EqualsNullSafe(str2); // true
str1.EqualsNullSafe(str3); // false

str1.EqualsNullSafe(strNull);     // false
strNull.EqualsNullSafe(str1);     // false
strNull.EqualsNullSafe(strNull);  // true
```

#### EqualsAbbreviations

```csharp
strA.EqualsInv(strB)    // Invariant Culture (Null safe)
strA.EqualsInvIC(strB)  // Invariant Culture, Ignore case (Null safe)

strA.EqualsOrd(strB)    // Ordinal Culture (Null safe)
strA.EqualsOrdIC(strB)  // Ordinal Culture, Ignore case (Null safe)
```

#### SafeSubstring()

Substring with range checking.

```csharp
string s = "12345".SafeSubstring(0,3);   // s is "123"
string s = "12345".SafeSubstring(0,10);  // s is "12345"

string s = "12345".SafeSubstring(3);     // s is "45"
string s = "12345".SafeSubstring(3, 5);  // s is "45"

string s = "12345".SafeSubstring(10);    // s is ""
```

#### Right() / Left()

```csharp
string s = "12345".Left(3);   // s is "123"
string s = "12345".Right(2);  // s is "45"

string s = "12345".Left(10);  // s is "12345"
string s = "12345".Right(10); // s is "12345"
```

#### SplitAndTrim()

```csharp
string s = "0 , 1 ,    2 , 3 ,4 ".sample.SplitAndTrim(new char[] {','}); 
// s is ["0","1","2","3","4"]
```

## String Parsers

Parsing operations that converts a string that represents a .NET Framework base type into that base type.

#### Example:
```csharp
int num = "123".ParseToInt(); // num is 123

int num = "ABC".ParseToInt(); // FormatException!!

int num = "ABC".ParseToIntOrDefault(); // int = 0

int num = "ABC".ParseToIntOrDefault(-1); // int = -1
```


#### Methods:
 - **ParseToInt()**
 - **ParseToIntOrDefault([defaultValue])**
 - **ParseToShort()**
 - **ParseToShortOrDefault([defaultValue])**
 - **ParseToLong()**
 - **ParseToLongOrDefault([defaultValue])**
 - **ParseToDecimal()**
 - **ParseToDecimalOrDefault([defaultValue])**
 - **ParseToDouble()**
 - **ParseToDoubleOrDefault([defaultValue])**


## Collection extensions

#### IsNullOrEmpty()

Indicates whether the specified enumerable is null or empty.

```csharp
readonly List<int> _nullList = null;
readonly List<int> _emptyList = new List<int>();
readonly List<int> _list = new List<int> { 1, 2, 3 };

_list.IsNullOrEmpty();         // false
_emptyList.IsNullOrEmpty();    // true
_nullList.IsNullOrEmpty();     // true
```

#### FirstIndex()

Finds the index of the first item matching an expression (-1 not found).


```csharp
readonly List<int> _nullList = null;
readonly List<int> _emptyList = new List<int>();
readonly List<int> _list = new List<int> { 1, 2, 3 };

_nullList.FirstIndex(x => x == 3));   // result is -1
_emptyList.FirstIndex(x => x == 3));  // result is -1
_list.FirstIndex(x => x == 1));       // result is 0
_list.FirstIndex(x => x == 2));       // result is 1
_list.FirstIndex(x => x == 3));       // result is 2
_list.FirstIndex(x => x == 4));       // result is -1
```

## Round Extensions

#### MRound()

Returns a number rounded to the desired multiple.

```csharp
0.80.MRound(.25);   // Result = 0.75
0.80M.MRound(.05M); // Result = 0.80
0.255.MRound(.25);  // Result = 0.25
```

#### TestRoundAwayFromZero()

Rounds a decimal value to the nearest integer. 
When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.

```csharp
1.5.RoundAwayFromZero();  // Result = 2
2.5.RoundAwayFromZero();  // Result = 3
3.5.RoundAwayFromZero();  // Result = 4
```

####RoundToEven()
Rounds a decimal value to the nearest integer. 
When a number is halfway between two others, it is rounded toward the nearest even number.

```csharp
1.5.RoundToEven();  // Result = 2
2.5.RoundToEven();  // Result = 2
3.5.RoundToEven();  // Result = 4
```
