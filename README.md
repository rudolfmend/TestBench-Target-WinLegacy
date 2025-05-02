# TestBench Target WinLegacy

A sample application designed to serve as a testing subject for developers creating monitoring, accessibility, or UI automation tools. This application provides predictable user interface elements and behaviors that developers can use to test their monitoring solutions.

## Purpose

TestBench Target WinLegacy was specifically created for Windows 7, 8, and 8.1 environments to provide a reliable target application when developing tools to monitor and test UI interactions.

## Main Features

- Small and fast application with consistent behavior
- Tests opening a Windows directory in the Documents folder
- Provides a target app for trying out monitoring and testing tools
- Simulates adding defined items to a table
- Simple chronological display of data in a table format
- Data persistence via JSON files
- Customizable table values with validation

## Technical Details

- Developed for .NET Framework 4.7.2
- Windows Forms application
- Implements proper DPI awareness
- Uses Newtonsoft.Json for data serialization
- Implements INotifyPropertyChanged for data binding
- Designed with accessibility and testing in mind

## Usage

1. Start the application
2. Click on "Open Application" on the main screen
3. In the second window, you can:
   - Select dates from the dropdown
   - Add entries with procedure names, points, and delegate information
   - Save and load data to/from JSON files
   - Delete selected entries
   - Open the Documents folder to access saved data

## For Developers

This application is ideal for testing:
- UI automation tools
- Accessibility solutions
- Application monitoring systems
- UI interaction recording tools
- Form control validation

## License

This project is licensed under the Apache License 2.0 - see the LICENSE file for details.

## Author

Rudolf Mendzezof
