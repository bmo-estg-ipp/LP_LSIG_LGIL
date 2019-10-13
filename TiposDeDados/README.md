# C# Data Types

C# is a strongly-typed language. It means we must declare the type of a variable which indicates the kind of values it is going to store such as integer, float, decimal, text, etc.

C# mainly categorized data types in two types: Value types and Reference types. Value types include simple types (e.g. int, float, bool, and char), enum types, struct types, and Nullable value types. Reference types include class types, interface types, delegate types, and array types.

![Data types](https://www.tutorialsteacher.com/Content/images/csharp/datatypes.png)

C# includes some predefined value types and reference types. The following table lists predefined data types:

| Type     | Description                                                  | Range                                                           | Suffix |
|----------|--------------------------------------------------------------|-----------------------------------------------------------------|--------|
| byte     | 8-bit unsigned integer                                       | 0 to 255                                                        |        |
| sbyte    | 8-bit signed integer                                         | -128 to 127                                                     |        |
| short    | 16-bit signed integer                                        | -32,768 to 32,767                                               |        |
| ushort   | 16-bit unsigned integer                                      | 0 to 65,535                                                     |        |
| int      | 32-bit signed integer                                        | -2,147,483,648 to2,147,483,647                                  |        |
| uint     | 32-bit unsigned integer                                      | 0 to 4,294,967,295                                              | u      |
| long     | 64-bit signed integer                                        | -9,223,372,036,854,775,808 to9,223,372,036,854,775,807          | l      |
| ulong    | 64-bit unsigned integer                                      | 0 to 18,446,744,073,709,551,615                                 | ul     |
| float    | 32-bit Single-precision floating point type                  | -3.402823e38 to 3.402823e38                                     | f      |
| double   | 64-bit double-precision floating point type                  | -1.79769313486232e308 to 1.79769313486232e308                   | d      |
| decimal  | 128-bit decimal type for financial and monetary calculations | (+ or -)1.0 x 10e-28 to7.9 x 10e28                              | m      |
| char     | 16-bit single Unicode character                              | Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode) |        |
| bool     | 8-bit logical true/false value                               | True or False                                                   |        |
| string   | A sequence of Unicode characters                             |                                                                 |        |
| DateTime | Represents date and time                                     | 0:00:00am 1/1/01 to11:59:59pm 12/31/9999                        |        |

```csharp
(...)
uint ui = 100u;
float fl = 10.2f;
long l = 45755452222222l;
ulong ul = 45755452222222ul;
double d = 11452222.555d;
decimal mon = 1000.15m;
(...)
```

## Default Value

Every data type has a default value. Numeric type is 0, boolean has false and char has '/0' as default value
```csharp
(...)
int i = default; // 0
float f = default;// 0
decimal d = default;// 0
bool b = default;// false
char c = default;// '\0'
(...)
```

[Reference](https://www.tutorialsteacher.com/csharp/csharp-data-types)