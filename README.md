# HTTP Server with WinForms UI

A custom HTTP server built from scratch in C#, featuring a WinForms UI that allows users to specify a custom listening port and view request logs. This project also includes plans for rewriting the server using Golang for improved performance and scalability.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Future Plans](#future-plans)
- [Contributing](#contributing)
- [License](#license)

## Introduction
This project is an HTTP server built from scratch using C#. It includes a WinForms-based user interface that enables users to set a custom listening port and view incoming request logs. The goal is to create a simple and flexible HTTP server that can be easily managed through a graphical interface. The project is also planned to be rewritten in Golang to leverage its performance advantages.

## Features
- Customizable listening port
- Real-time request logging
- User-friendly WinForms UI
- Lightweight and efficient server design

## Technologies
- **Backend**: C#
- **Frontend**: WinForms
- **Planned Rewrite**: Golang
- **Logging**: Built-in logging mechanism

## Installation
### Prerequisites
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) with .NET Desktop Development workload
- [.NET Core SDK](https://dotnet.microsoft.com/download)

### Steps
1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/http-server.git
    cd http-server
    ```

2. Open the solution file (`HttpServer.sln`) in Visual Studio.

3. Build the solution to restore dependencies and compile the project.

4. Run the application from Visual Studio.

## Usage
1. Launch the HTTP server application.
2. In the WinForms UI, specify the desired listening port.
3. Start the server to begin handling HTTP requests.
4. View incoming request logs in real-time through the UI.

## Future Plans
- **Rewriting in Golang**: The server will be rewritten using Golang to improve performance and scalability. This transition will leverage Go's concurrency model and efficient memory management.
- **Additional Features**: Enhancements such as SSL support, more detailed logging, and a RESTful API for managing server settings are planned.

## Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
