# IIYADA - Clinic Management System
## Table of Contents
- [Introduction](#introduction)
- [Actors](#actors)
- [Class Diagram](#class-diagram)
- [Getting started](#getting-started)

## Introduction

IYADA is a comprehensive clinic management windows forms app developed using Visual Studio 2022. The primary language used is C#, and ADO.NET is utilized for database manipulation. The design is enhanced using the Guna framework.

### Key features include:

- Recording patient information by the secretary.
- Managing patient data, consultation appointments, medications, and more by the doctor.

## Actors

There are two main users for this application:

- Doctor: Manages consultations and medications.
- Secretary: Handles patient information.

## Class Diagram

The project consists of multiple classes, each serving a specific role. For example:

![image](/gestionCabinie/Resources/class-diagram-screenshot.png)

Patient Interface: Contains several methods to manage patient information, including CIN, NAME, LASTNAME, PHONE, and ADDRESS. The available operations are:    **Add, Edit, Delete, Search**
Consultation details: include Id, CIN, date, description, appointment date, medications, and quantity.

### Getting Started
Prerequisites

- Visual Studio 2022
- .NET Framework
- MSSQL server
- GUNA framework 

### Clone the repository:

```bash
git clone https://github.com/Oussa-Err/IYADA.git
```
Open the project in Visual Studio 2022.
Configure the database connection string in the backend/.env file.
Build and run the project.

### Usage

**For Secretaries:** Use the patient management interface to add, edit, delete, and search for patient records.<br />
**For Doctors:** Use the consultation interface to manage consultation records, including appointment scheduling and medication management.

## Contributions are welcome! 
Please follow these steps:

- Fork the repository.
- Create a new branch (git checkout -b feature-branch).
- Commit your changes (git commit -m 'Add some feature').
- Push to the branch (git push origin feature-branch).
- Open a pull request.