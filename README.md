# 🏥 C# Console Patient Management System (CPMS)

A console-based **Patient Management System** built in **C# (.NET 8)** that allows healthcare administrators to manage patient records via a simple interactive menu. This project demonstrates core **Object-Oriented Programming (OOP)** principles, array manipulation, input validation, and error handling in C#.

---

## 📋 Features

| Feature | Description |
|---|---|
| ➕ Add Patient | Register a new patient with name, age, and medical condition |
| ❌ Remove Patient | Remove a patient record by name |
| 🔍 Search Patient | Look up a patient by name and view their details |
| 📋 Display All Patients | View all currently registered patient records |
| 🚪 Exit | Gracefully exit the application with a farewell message |

---

## 🛠️ Tech Stack

- **Language:** C# (.NET 8)
- **Project Type:** Console Application
- **IDE:** JetBrains Rider / Visual Studio / VS Code
- **Framework:** .NET 8.0

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- A terminal or command prompt

### Clone the Repository

```bash
git clone https://github.com/<your-username>/csharp-patient-management-system.git
cd csharp-patient-management-system
```

### Build the Project

```bash
cd Question_1
dotnet build
```

### Run the Project

```bash
dotnet run
```

---

## 🖥️ Usage

Once the application launches, you will be presented with the following menu:

```
1. Add Patient
2. Remove Patient
3. Search Patient
4. Display All Patients
5. Exit
Enter your choice:
```

### Example Workflow

**Adding a Patient:**
```
Enter your choice: 1
Enter the patient's name: John Smith
Enter the patient's age: 45
Enter the patient's medical condition: Hypertension
```

**Searching for a Patient:**
```
Enter your choice: 3
Enter patient name that you want to search: John Smith

Patient Name: John Smith
Age: 45
Medical Condition: Hypertension
```

**Removing a Patient:**
```
Enter your choice: 2
Enter patient name that you want to remove: John Smith

Patient successfully removed from array.
```

**Displaying All Patients:**
```
Enter your choice: 4

Name: Jane Doe
Age: 32
Medical Condition: Diabetes
```

---

## 📁 Project Structure

```
CSharp-CPMS-Q1-Y2-2025/
├── Question_1.sln              # Solution file
├── Requirements.txt            # Project requirements & planning notes
├── README.md                   # Project documentation
└── Question_1/
    ├── CPMS.cs                 # Patient model class (Name, Age, MedicalCondition)
    ├── Program.cs              # Main program logic & menu operations
    └── Question_1.csproj       # Project configuration file
```

---

## 🏗️ How It Works

### CPMS Class (`CPMS.cs`)
A simple **data model** class that represents a patient with three properties:
- `Name` (string)
- `Age` (int)
- `MedicalCondition` (string)

### Program Class (`Program.cs`)
Contains the main program loop and four static methods:
- `AddPatient()` – Validates space in the array and stores a new `CPMS` object
- `RemovePatient()` – Searches by name and sets the matching index to `null`
- `SearchPatient()` – Searches by name and displays patient details
- `DisplayAll()` – Iterates the array and prints all non-null records

---

## ⚠️ Input Validation

- Menu input must be an integer between 1 and 5; otherwise a `FormatException` is caught and an error message is displayed
- The array has a configurable constant size (`const int size`)
- The application alerts the user when the patient array is full

---

## 📄 License

This project is intended for **educational purposes** as part of a programming coursework assessment.

---

> **Note:** This is Question 1 of a C# Programming coursework submission (Q1 · Year 2 · 2025).

