# Design Patterns - Command

This repository showcases an implementation of the Command design pattern in C#. The code demonstrates how commands can be encapsulated as objects, allowing users to parameterize clients with requests, queues, and operations. This approach promotes decoupling and enhances flexibility in handling operations.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Command design pattern is a behavioral pattern that encapsulates a request as an object, thereby allowing users to parameterize clients with different requests, delay execution, or support undoable operations. It decouples the sender and receiver, enabling flexible and maintainable code.

## Implementation Overview
This repository provides a C# implementation of the Command design pattern. Key components of the code include:

- **ICommand Interface**: Defines the abstract `Execute()` method for all command implementations.
- **ConcreteCommand Class**: A concrete implementation of the `ICommand` interface that encapsulates a specific action.
- **CommandInvoker Class**: Holds and triggers commands, supporting the addition and execution of multiple commands.
- **Program Class**: Demonstrates the usage of the pattern by creating commands, adding them to the invoker, and executing them.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Command.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Command
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Command pattern in action.
3. Modify or extend the `ConcreteCommand` class or add new commands to simulate different scenarios.

### Example Output:
```
Executing commands:
Executing action: Turn on the lights
Executing action: Play music
Executing action: Start the coffee machine
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

