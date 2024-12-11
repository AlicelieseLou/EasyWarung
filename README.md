# 🚀 EasyWarung - POS System for Small to Medium Stores  

**EasyWarung** is a Point of Sale (POS) application designed for small to medium-sized stores, providing a user-friendly interface for managing store operations efficiently. Built with VB .NET using Bunifu UI for an enhanced user experience, it utilizes SQL Server (SSMS) for database management and RDLC for generating detailed reports and transaction receipts.  

## 🌟 Features  

### 🔐 Authentication  
- **Login with 3 User Roles**: Access is role-based, ensuring functionality appropriate to each user.  

### 🗂️ Menus  
The application is divided into 7 primary menus:  
1. **📊 Dashboard**: Overview of store metrics and activities.  
2. **📁 Category**: Manage product categories with CRUD operations and detailed reports.  
3. **🛒 Product**: Full control over product data with CRUD functionality and detailed reporting.  
4. **📋 Order**:  
   - Manage and process orders with CRUD functionality.  
   - **Right-click DataGridView Event**: Quickly update order statuses.  
   - Detailed reports for order tracking.  
5. **👤 User**: User management with CRUD operations, detailed reporting, and role assignments.  
6. **⚙️ Setting**:  
   - Update user profile information for the logged-in user.  
   - Configure database connection settings.  
7. **🚪 Logout**: Securely log out of the application.  

### 📄 Reporting  
- **Master Data Reports**: Generate detailed reports for categories, products, orders, and users.  
- **🧾 Transaction Receipts**: Print receipts for every transaction.  

## 🛠️ Technology Stack  
- **Programming Language**: VB .NET  
- **UI Framework**: Bunifu UI  
- **Database**: SQL Server (SSMS)  
- **Reporting Tool**: RDLC  
- **IDE**: Visual Studio  

## ⚡ Installation  
1. **Clone the repository**:  
   ```
   git clone https://github.com/AlicelieseLou/EasyWarung.git
   ```
2. **Open the solution file in Visual Studio.**
3. **Restore NuGet packages if required.**
4. **Set up the database:**
   - Import the provided SQL script into SQL Server Management Studio (SSMS).
   - Configure the database connection in the Settings menu.
5. **Build and run the application.**

## 🚀 Usage  
1. **🔐 Login**: Use one of the predefined roles to access the application.  
2. Navigate through the menus to manage data, process orders, and configure settings.  
3. Use the **📋 Order** menu's right-click feature to update order statuses.  
4. Generate reports via the respective **📄 Reports** sections.

## 📷 Screenshots

### 🔐 Login Page
The login page requires users to authenticate before accessing the application.
![Screenshot (773)](https://github.com/user-attachments/assets/9a1bd2f2-7422-4f4d-b6b3-235b97b10b4b)

### 📋 Order Menu  
The order menu allows users to manage orders, including a right-click functionality on the DataGridView to update order statuses.
![Screenshot (774)](https://github.com/user-attachments/assets/d9798649-d71d-4526-84f2-492012dfb17d)





