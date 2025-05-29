# Inventory Management System

A Model-View-Controller(MVC) Inventory Management System developed as a course project for **CSC 440 - Visual Programming Lab** at **IUBAT**, Spring 2025. The system manages inventory operations with role-specific dashboards for Warehouse Staff, Manager, Supplier, and Users.

## 🗂️ Project Structure

This project follows a modular design using Windows Forms with role-based dashboards:
- **Warehouse Staff Dashboard**: Handles stock input/output.
- **Manager Dashboard**: Manages reports, inventory levels, and user permissions.
- **Supplier Dashboard**: Views supply orders and delivers items.
- **User Dashboard**: Regular user interface for viewing available items.

## 💻 Technologies Used

- **Language**: C#
- **Framework**: .NET Windows Forms
- **Database**: SQL Server (LocalDB or Express)
- **IDE**: Visual Studio 2022 or later

## 🏗️ Features

- Role-based login system
- Real-time stock tracking
- Add/edit/delete inventory items
- Supplier delivery records
- Inventory alerts (low stock, expiry)
- Report generation (PDF/CSV export optional)
- Intuitive and responsive UI
-----------------------------------------------------------------------------

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2022 or newer
- .NET Framework 4.7.2+
- SQL Server (LocalDB or Express)
---------------------------------------------------------------------------------
### Steps to Run

**Clone the Repository**
   ```bash
   git clone https://github.com/InfinityAbir/Inventory-Management-System.git

1. Open in Visual Studio

2. Unzip the project and open it in Visual Studio.

3. If any issues occur, delete the bin/, obj/, and .vs/ folders and reload the project.

4. Configure Database Connection

5. Go to appsettings.json.

6. Update the ConnectionStrings section with your SQL Server instance details.

7. Click Build > Build Solution or press Ctrl+Shift+B.

8. Then run the application using F5 or the Start button.

9. Customize as Needed

10. Feel free to update or extend the project as per your requirements!

----------------------------------------------------------------------------------

## 📝 Project Presentation

A detailed project presentation is available in the `/pptx/` folder. It includes:

- **Introduction**
- **Design Planning**
- **Component-wise Implementation**
- **Data Binding Techniques**
- **Visual Feedback and Usability Testing**
- **Appendix**
