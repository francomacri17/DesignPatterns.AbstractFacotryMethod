# Abstract Factory Pattern Implementation in C#

This repository contains a C# implementation of the Abstract Factory Design Pattern. The Abstract Factory Pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes. In this example, we demonstrate the pattern by creating a simple GUI library that can produce UI elements in two different styles: Light and Dark.

## Project Structure

- `IButton` & `ICheckbox`: Interfaces for abstract products.
- `LightButton`, `DarkButton`, `LightCheckbox`, `DarkCheckbox`: Concrete products implementing the respective interfaces.
- `IGUIFactory`: An interface for the abstract factory.
- `LightThemeFactory` & `DarkThemeFactory`: Concrete factories that implement `IGUIFactory` and produce light-themed and dark-themed UI elements respectively.
- `Program`: The entry point of the application, demonstrating the usage of the factories.

## Getting Started

To run this example, you need a C# development environment set up with .NET Core or .NET Framework, depending on your preference. The code was written to be straightforward and should run in any environment that supports C#.

### Prerequisites

- .NET SDK (Check the version used and recommend accordingly)
- A C# compatible IDE (Visual Studio, VS Code with C# extension, Rider, etc.)

### Running the Application

1. Clone the repository to your local machine.
2. Open the solution in your IDE.
3. Build the solution to resolve dependencies.
4. Run the application. The output will demonstrate the creation of UI elements in both Light and Dark themes using the Abstract Factory Pattern.

## Understanding the Abstract Factory Pattern

The Abstract Factory Pattern is used when a system should be independent of how its products are created, composed, and represented. It's particularly useful when:
- The system consists of multiple families of products.
- A family of related product objects is designed to be used together.
- You want to provide a class library of products, revealing only their interfaces, not their implementations.

In this example, `IGUIFactory` acts as the abstract factory interface with methods to create abstract products (`IButton` and `ICheckbox`). `LightThemeFactory` and `DarkThemeFactory` are concrete implementations that create concrete products (`LightButton`, `DarkButton`, `LightCheckbox`, `DarkCheckbox`).

## Contributing

Contributions are welcome! If you have suggestions for improving this implementation or extending the example, please feel free to fork the repository, make your changes, and submit a pull request.

## License

This project is open source and available under the [MIT License](LICENSE).
