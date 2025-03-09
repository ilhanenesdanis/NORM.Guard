
# NORM.Guard

# Guard Clauses Library for C#

A lightweight, easy-to-use library for implementing guard clauses in C# applications. This library provides simple and customizable validation checks, allowing you to protect your code from common runtime errors like null, empty, or invalid values. Ideal for adding method parameter validation and error handling in a clean and efficient way.

## Features
- Validate arguments and method parameters
- Handle null, empty, or invalid string values
- Customize exception handling (supports custom exception types)
- Easy to integrate into your existing projects

## Installation

To install the **NORM.Guard** library, run the following command in your **Package Manager Console** or **dotnet CLI**:

### Using NuGet Package Manager:
```bash
Install-Package NORM.Guard
```

### Using dotnet CLI:
```bash
dotnet add package NORM.Guard
```

## Usage

### 1. Null Check for Any Object
To check if an object is `null` and throw an exception:

```csharp
using GuardClauses;

public class Example
{
    public void Method(object value)
    {
        GuardClauses.AgainstNull(value, "value cannot be null");
    }
}
```

### 2. Null or Empty Check for Strings
To check if a string is `null` or empty and throw an exception:

```csharp
using GuardClauses;

public class Example
{
    public void Method(string value)
    {
        GuardClauses.AgainstInvalidString(value, "value cannot be null or empty");
    }
}
```

### 3. Custom Exception Type for Guard Clauses
You can also use custom exception types when validating values. Simply pass your custom exception type as a generic parameter.

```csharp
using GuardClauses;

public class Example
{
    public void Method(string value)
    {
        GuardClauses.AgainstInvalidString<CustomException>(value, "value cannot be null or empty");
    }
}

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}
```

### 4. General Condition Check
You can also throw exceptions based on general conditions:

```csharp
using GuardClauses;

public class Example
{
    public void Method(bool condition)
    {
        GuardClauses.Against<ArgumentException>(condition, "Condition failed");
    }
}
```

## Contribution

Feel free to fork the repository and contribute to improving this library! Please submit issues and pull requests for bug fixes or enhancements.

## Author

Copyright © 2025 Danis. All rights reserved.
