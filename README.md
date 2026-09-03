# Factory Pattern

## Overview

This repository demonstrates the **Factory Pattern** — a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created. The Factory Pattern centralizes object creation logic and decouples client code from concrete implementations.

## Description

The Factory Pattern is used when:

- A class can't anticipate the class of objects it must create
- You want to centralize object creation and keep client code independent of concrete classes
- The instantiation process is complex or requires conditional logic

### Typical Structure

- **Product**: The interface or abstract class that defines the type of object the factory produces
- **ConcreteProduct**: Concrete implementations of the Product interface
- **Factory (Creator)**: Declares the factory method that returns Product objects. May include default implementation or define an abstract method
- **ConcreteFactory**: Implements the factory method to return instances of ConcreteProduct

## Pre-requisites

- .NET Framework or .NET Core (version 4.7 or higher recommended)
- C# compiler
- Visual Studio, Visual Studio Code, or any C# IDE of your choice
- Basic understanding of object-oriented programming and design patterns

## Build and Run

### Using Visual Studio:

1. Open the solution file (`.sln`) in Visual Studio
2. Build the solution using `Build > Build Solution` or press `Ctrl+Shift+B`
3. Run the application using `Debug > Start Debugging` or press `F5`

### Using Command Line (dotnet CLI):

1. Navigate to the project directory:
   ```bash
   cd FactoryPattern
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

### Using Command Line (.NET Framework):

1. Navigate to the project directory:
   ```bash
   cd FactoryPattern
   ```

2. Build using MSBuild:
   ```bash
   msbuild FactoryPattern.csproj
   ```

3. Run the compiled executable from the output folder
