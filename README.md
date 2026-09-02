# Factory Pattern

This repository demonstrates the Factory Pattern — a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

## Overview

The Factory Pattern centralizes object creation logic and decouples client code from concrete implementations. It's useful when:

- A class can't anticipate the class of objects it must create.
- You want to centralize object creation and keep client code independent of concrete classes.
- The instantiation process is complex or requires conditional logic.

## Typical Structure

- Product: The interface or abstract class that defines the type of object the factory produces.
- ConcreteProduct: Concrete implementations of the Product interface.
- Factory (Creator): Declares the factory method that returns Product objects. May include default implementation or define an abstract method.
- ConcreteFactory: Implements the factory method to return instances of ConcreteProduct.
