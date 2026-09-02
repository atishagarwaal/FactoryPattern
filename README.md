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

## Examples

Below are short conceptual examples in common languages. Refer to the code in this repository for concrete implementations.

### Java (conceptual)

```java
// Product
public interface Shape {
    void draw();
}

// ConcreteProduct
public class Circle implements Shape {
    public void draw() { System.out.println("Drawing a Circle"); }
}

// Factory
public class ShapeFactory {
    public Shape getShape(String type) {
        if (type == null) return null;
        if (type.equalsIgnoreCase("CIRCLE")) return new Circle();
        // add more shapes
        return null;
    }
}

// Client
ShapeFactory factory = new ShapeFactory();
Shape s = factory.getShape("CIRCLE");
s.draw();
```

### Python (conceptual)

```python
class Product:
    def do(self):
        raise NotImplementedError

class ConcreteA(Product):
    def do(self):
        print("A doing")

class Factory:
    def create(self, kind):
        if kind == 'a':
            return ConcreteA()
        raise ValueError('unknown')

f = Factory()
obj = f.create('a')
obj.do()
```

## How to use this repository

1. Browse the language-specific folders (if present) to find concrete examples and implementations.
2. Run the examples using the relevant language runtime or build tool (javac/java, python, dotnet, etc.).
3. Modify or extend factories/products to experiment with variations (e.g., adding configuration-based factories or abstract factory variations).

## When to prefer other patterns

- If you need families of related products, consider the Abstract Factory.
- If instantiation should be deferred until first use, consider Lazy Initialization or Singleton (careful with shared state).

## Contributing

Contributions welcome. If you add a new language or example, please:

- Create a new folder named after the language (e.g., `java/`, `python/`).
- Add a short README in that folder explaining how to build/run the example.
- Submit a pull request with a clear description of the change.

## License

If this repository should include a license, add a LICENSE file or update this README to indicate the intended license.
