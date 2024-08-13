
# Game Script 

## Overview

**Game Script** is a WPF application designed to manage and navigate a game script. It allows users to view the full script or navigate through it line by line. The script is displayed with a comic-style font and can be navigated using "Next" and "Previous" buttons. This project is built using WPF with C# and provides a user-friendly interface for interacting with a game script.

## Features

- **Full Script Display**: View the entire game script in a scrollable text area.
- **Line-by-Line Navigation**: Navigate through the script one line at a time using "Next" and "Previous" buttons.
- **Custom Background**: The application includes a custom background image and comic-style font for a unique look and feel.

## Prerequisites

- **.NET Framework**: Ensure that you have the .NET Framework installed on your system.
- **Visual Studio**: It's recommended to use Visual Studio for running and debugging the application.

## Installation

1. **Clone the Repository**: Download or clone the repository to your local machine.

    ```bash
    git clone https://github.com/SamuelNkomo/GameScript.git
    ```

2. **Open the Project**: Open the solution file (`GameScript.sln`) in Visual Studio.

3. **Build the Solution**: Build the solution to restore any necessary packages and compile the project.

## Usage

1. **Run the Application**: Start the application by pressing `F5` in Visual Studio or by running the compiled executable from the `bin` directory.

2. **View the Script**: The main window displays the full script in a text area. The script is also shown line by line in a separate text area.

3. **Navigate Through the Script**:
    - **"Next" Button**: Click to move to the next line in the script.
    - **"Previous" Button**: Click to move to the previous line in the script.

4. **Background and Fonts**: The application uses a custom background image and comic-style font. The background image is set in `App.xaml`, and the font styles are applied globally.

## Font Sizing Information

### Font Sizes in the Application

- **TextBlock Font Size**:
    - **Full Script and Current Line Labels**: `16` points.
    - **Example**: `<TextBlock FontSize="16"/>`

- **TextBox Font Size**:
    - **Script Display**: `14` points.
    - **Example**: `<TextBox FontSize="14"/>`

- **Button Font Size**:
    - **Navigation Buttons**: `14` points.
    - **Example**: `<Button FontSize="14"/>`

These settings ensure consistency in text size across the application's UI, contributing to a clear and user-friendly interface.

## Development

### Setting Up the Development Environment

1. **Ensure Dependencies**: Make sure that you have all necessary dependencies installed, including .NET Framework and any third-party libraries used in the project.

2. **Modify Resources**: To change the background image or font, update the `App.xaml` file and replace the image in the `Resources` folder.

3. **Edit Scripts**: Update the game script in the `ScriptManager` class as needed.

### Adding New Features

1. **Modify XAML**: Add or change UI elements in `MainWindow.xaml` or other XAML files as needed.

2. **Update Code-Behind**: Make changes to the logic in `MainWindow.xaml.cs` or other code-behind files to implement new functionality.

3. **Test Changes**: Build and test the application to ensure that new features work as expected.

## Contributing

1. **Fork the Repository**: Create a fork of the repository on GitHub.

2. **Create a Branch**: Create a new branch for your changes.

    ```bash
    git checkout -b feature/your-feature
    ```

3. **Make Changes**: Implement your changes and commit them.

    ```bash
    git add .
    git commit -m "Add your feature description"
    ```

4. **Push and Create a Pull Request**: Push your changes to your fork and create a pull request on GitHub.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For questions or issues, please contact:

- **Name**: Samuel Nkomo
- **Email**: ST10085591@vcconnect.edu.za
- **GitHub**: [SamuelNkomo](https://github.com/SamuelNkomo)
