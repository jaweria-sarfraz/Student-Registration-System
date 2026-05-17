# Student Registration System 🎓

A professional, data-driven desktop GUI application developed using Visual Studio (Visual Basic) and fully integrated with an SQL Server backend database. This system provides a robust administrative interface for managing student profiles, registration data, and authentication credentials securely.

## 🎨 Design Aesthetic & GUI Features
- **Dark & Professional Layout:** Custom-styled using clean grayscales (`ControlDarkDark`) and high-contrast dark elements to ensure a sleek visual hierarchy and reduce eye strain.
- **Dynamic Input Validation:** Features real-time validation handlers, including dedicated email syntax verification (`@gmail.com` pattern checks) with instant dynamic error label feedback.
- **Interactive Security Controls:** Implements real-time password visibility toggles managing the `UseSystemPasswordChar` control character dynamically.

## ✨ Core Functionalities
- **Full Database CRUD Operations:** Seamlessly executes Create, Read, Update, and Delete commands mapped directly to tables in the backend storage.
- **Data Grid Binding:** Integrated `DataGridView` component bound to runtime query data, updating dynamically with every SQL transaction to show live records.
- **Focus Management & Reset Flow:** Automated form cleaning routines that reset drop-down indices and re-assign active focus to ensure smooth user operations.

## 🛠️ Technical Architecture
- **Frontend / Interface:** Visual Basic .NET (WinForms Architecture)
- **IDE:** Visual Studio Community (Targeting .NET 8.0-Windows)
- **Database Engine:** Microsoft SQL Server (`System.Data.SqlClient`)
- **Connectivity:** Managed locally via secure connection strings pointing to instances (`DESKTOP-APADBTF\SQLEXPRESS`).

---
*Developed as part of my academic and technical software portfolio to demonstrate enterprise desktop layout design, relational database connectivity, and structured exception validation workflows.*
