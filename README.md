# RFID Tracking System

## Overview

This project is an RFID tracking system that utilizes antennas to monitor RFID tags actively. The system is built with a WPF Forms application and uses MS SQL Server for data storage. This application can be used for various tracking needs, including inventory management, asset tracking, and real-time location monitoring.

## Features

- **Real-Time Tracking**: Monitor RFID tags in real-time using connected antennas.
- **Data Storage**: All tracking data is stored in an MS SQL Server database for easy retrieval and analysis.
- **User-Friendly Interface**: A WPF Forms application provides an intuitive interface for monitoring and managing RFID tags.
- **Customizable Alerts**: Set up alerts for specific RFID tags or events.
- **Reporting**: Generate reports based on tracking data for further analysis.

## System Architecture

- **RFID Antennas**: Hardware used to read RFID tags.
- **WPF Application**: Front-end application built using Windows Presentation Foundation (WPF) to provide a graphical user interface.
- **MS SQL Server**: Database server used to store tracking data and application configurations.

## Installation

### Prerequisites

- **RFID Hardware**: Compatible RFID antennas and tags.
- **Software**: 
  - .NET Framework
  - MS SQL Server
  - Visual Studio (for development and deployment)

### Steps

#### Set Up the Database

1. **Install MS SQL Server**: Make sure MS SQL Server is installed on your machine or server.
2. **Run SQL Scripts**: Execute the SQL scripts provided in the `database` folder to set up the necessary tables and stored procedures.

#### Configure the Application

1. **Open the Project**: Launch the project in Visual Studio.
2. **Update Connection String**: Modify the database connection string in `App.config` to point to your MS SQL Server instance.

#### Build and Run

1. **Build the Solution**: Compile the solution in Visual Studio.
2. **Run the Application**: Start the application to begin monitoring RFID tags.

## Usage

1. **Connect Antennas**: Ensure that all RFID antennas are properly connected and configured.
2. **Launch Application**: Start the WPF application to begin monitoring.
3. **Monitor Tags**: Use the interface to track RFID tags and view real-time data.
4. **Generate Reports**: Utilize the reporting features to analyze historical tracking data.
