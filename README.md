# MunicipalityReportingApp
Municipality Reporting Application - README
Overview
The Municipality Reporting Application is a C# Windows Forms application designed to facilitate the reporting of local issues by citizens. The application is user-friendly and provides an efficient platform for residents to engage with municipal services. In this version, only the “Report Issues” functionality is implemented, while other features, such as “Local Events and Announcements” and “Service Request Status,” are placeholders for future updates.

Features
Main Menu:
Displays three options on startup:
Report Issues (implemented)
Local Events and Announcements (disabled)
Service Request Status (disabled)
Report Issues:
Users can provide details of an issue, including location, category, and description.
Supports attaching images or documents related to the issue.
Integrates a ProgressBar as a user engagement feature to visualize the progress of reporting.
Technical Requirements
The application uses Windows Forms and C# for the user interface.
Data structures such as lists are used to store user-reported issues and their details.
The engagement feature (ProgressBar) helps users track their progress in submitting a report.
Installation Instructions
Prerequisites:
Visual Studio 2019 or later
.NET Framework 4.8 or later
Steps to Compile:
Download or clone the repository.
Open the solution file (.sln) in Visual Studio.
Build the solution using Ctrl + Shift + B.
Ensure there are no errors during the build process.
Steps to Run:
Press F5 in Visual Studio to run the application in Debug mode.
Alternatively, navigate to the bin/Debug/ folder, and run the executable file (.exe).
How to Use the Application
Main Menu:

Upon launching, users are presented with a main menu featuring three options:
Report Issues (enabled)
Local Events and Announcements (disabled)
Service Request Status (disabled)
Click on the Report Issues button to proceed.
Report Issues Form:

Input the location of the issue in the provided textbox.
Select the category of the issue from the dropdown (e.g., roads, utilities, sanitation).
Provide a detailed description of the issue in the description box.
Attach any relevant media (images/documents) by clicking the Attach File button.
The ProgressBar will update as you fill out the details, giving visual feedback on your progress.
Click Submit to finalize the report.
Use the Back to Main Menu button to return to the main screen.
Error Handling:
Ensure that all required fields (Location, Category, and Description) are filled out before submitting the report.
If no media is attached, the application will still allow submission, but attaching images or documents is encouraged for better issue resolution.
Future Features
Local Events and Announcements: Will allow users to view and receive updates on local happenings.
Service Request Status: Users will be able to track the status of previously submitted service requests.