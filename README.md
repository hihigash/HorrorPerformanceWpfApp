# HorrorPerformanceWpfApp

A WPF application designed to demonstrate common performance anti-patterns and inefficient coding practices. This educational project showcases how seemingly innocent code can lead to significant performance degradation.

## 📋 Overview

This application loads and displays user data from a CSV file in a WPF DataGrid. While the functionality is simple, the implementation contains intentional performance bottlenecks to illustrate common programming mistakes that can severely impact application performance.

## 🚀 Features

- **User Data Display**: Loads user information from CSV file and displays in a sortable DataGrid
- **Age Calculation**: Calculates and displays average age of all users
- **Performance Bottlenecks**: Intentionally includes inefficient code patterns for educational purposes
- **Unit Tests**: Includes test cases with performance expectations

## 🏗️ Architecture

The application follows a simple layered architecture:

- **Presentation Layer**: `MainWindow.xaml` - WPF user interface
- **Business Logic**: `UserManager.cs` - Handles user data operations
- **Data Model**: `User.cs` - Represents user entity
- **Data Source**: `DummyData.csv` - Contains 3,000 user records

## 🔧 Technical Stack

- **.NET 8.0**: Target framework with Windows-specific features
- **WPF**: Windows Presentation Foundation for UI
- **nietras.SeparatedValues (Sep)**: High-performance CSV parsing library
- **MSTest**: Unit testing framework

## 📁 Project Structure

```
HorrorPerformanceWpfApp/
├── HorrorPerformanceWpfApp/           # Main WPF application
│   ├── MainWindow.xaml                # Main UI window
│   ├── MainWindow.xaml.cs            # Main window code-behind
│   ├── User.cs                       # User data model
│   ├── UserManager.cs                # User data management
│   └── Resources/
│       └── DummyData.csv             # Sample data (3,000 records)
├── HorrorPerformanceWpfAppTests/      # Unit tests
│   └── UserManagerTests.cs          # UserManager test cases
└── README.md                         # This file
```

## 📊 Performance Metrics

The application includes a performance test that expects:
- Loading 3,000 user records
- Average age calculation to complete within 1 second (often fails due to intentional bottlenecks)
- Initial UI load time of ~2 seconds

