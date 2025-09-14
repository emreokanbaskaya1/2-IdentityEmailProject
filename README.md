# 📧 MyAcademy Identity Email Project

A modern email/messaging application based on ASP.NET Core Identity. A full-featured platform where users can securely send and receive messages, save drafts, and manage their messages.

## ✨ Features

### 🔐 Authentication
- **User Registration** - Create account with email and password
- **Secure Login** - Authentication with ASP.NET Core Identity
- **Session Management** - Secure logout and session control

### 📨 Message Management
- **Inbox** - Priority display of last 3 messages
- **Sent Messages** - List all sent messages
- **Draft System** - Save and edit messages as drafts
- **Trash** - Restore deleted messages
- **Important Messages** - Star marking system

### 🎯 Message Operations
- **Read/Unread** - Change message status
- **Delete** - Secure deletion with soft delete
- **Restore** - Restore messages from trash
- **Draft Editing** - Edit saved drafts

### 📱 User Interface
- **Modern Design** - Professional look with AdminLTE 3.0.4
- **Responsive** - Mobile and desktop compatible
- **Dynamic Header** - Show last 3 messages in dropdown
- **Pagination** - Performance listing with 5 messages per page
- **Real-time Counts** - Unread, trash, important message counts

## 🛠️ Technologies

### Backend
- **ASP.NET Core 9.0** - Modern web framework
- **Entity Framework Core** - ORM and database management
- **ASP.NET Core Identity** - Authentication and authorization
- **SQL Server** - Database

### Frontend
- **AdminLTE 3.0.4** - Modern admin panel theme
- **Bootstrap 4** - Responsive CSS framework
- **FontAwesome** - Icon library
- **jQuery** - JavaScript library

### Database
- **Code First Migration** - Database schema management
- **Soft Delete** - Secure data deletion
- **Foreign Key Relations** - Relational data structure

## 📁 Project Structure

```
IdentityEmailApp/
├── Controllers/
│   ├── HomeController.cs          # Home page controller
│   ├── LoginController.cs         # Login/logout controller
│   ├── RegisterController.cs      # Registration controller
│   ├── MessageController.cs       # Message operations controller
│   └── MainLayoutController.cs    # Layout data controller
├── Entities/
│   ├── AppUser.cs                 # User entity
│   ├── AppRole.cs                 # Role entity
│   └── Message.cs                 # Message entity
├── Models/
│   ├── LoginViewModel.cs          # Login model
│   ├── RegisterViewModel.cs       # Registration model
│   └── SendMessageViewModel.cs    # Send message model
├── Views/
│   ├── MainLayout/
│   │   └── Index.cshtml           # Main layout
│   ├── Message/
│   │   ├── Index.cshtml           # Inbox
│   │   ├── SendMessage.cshtml     # Send message
│   │   ├── SentMessages.cshtml    # Sent messages
│   │   ├── Drafts.cshtml          # Drafts
│   │   ├── Trash.cshtml           # Trash
│   │   └── MessageDetail.cshtml   # Message detail
│   ├── Login/
│   │   └── Index.cshtml           # Login page
│   └── Register/
│       └── SignUp.cshtml          # Registration page
├── Context/
│   └── AppDbContext.cs            # Database context
├── Validations/
│   └── CustomErrorDescriber.cs    # Custom error messages
└── Migrations/                     # Database migrations
```

## 🚀 Installation

### Requirements
- .NET 9.0 SDK
- SQL Server (LocalDB supported)
- Visual Studio 2022 or VS Code

### Steps

1. **Clone the project**
```bash
git clone https://github.com/yourusername/MyAcademyIdentityProject.git
cd MyAcademyIdentityProject
```

2. **Install packages**
```bash
dotnet restore
```

3. **Create database**
```bash
dotnet ef database update
```

4. **Run the application**
```bash
dotnet run
```

5. **Open in browser**
```
https://localhost:7058
```

## 📊 Database Schema

### AppUser (Users)
- `Id` - Unique user ID
- `FirstName` - First name
- `LastName` - Last name
- `Email` - Email address
- `UserName` - Username

### Message (Messages)
- `MessageId` - Unique message ID
- `SenderId` - Sender user ID
- `ReceiverId` - Receiver user ID (nullable - for drafts)
- `Subject` - Message subject
- `Body` - Message content
- `SendDate` - Send date
- `IsRead` - Read status
- `IsDeleted` - Deleted status (soft delete)
- `IsImportant` - Important message status
- `IsDraft` - Draft status
- `DraftDate` - Draft save date

## 🔧 Feature Details

### Message System
- **Inbox**: Priority display of last 3 messages
- **Pagination**: Performance listing with 5 messages per page
- **Soft Delete**: Messages are not physically deleted
- **Draft System**: Save messages as drafts

### Security
- **Identity Framework**: Secure authentication
- **Authorization**: Page-based authorization
- **Input Validation**: Input validation
- **SQL Injection Protection**: Protected with Entity Framework

### Performance
- **Optimized AdminLTE**: Unnecessary files removed
- **Async Operations**: Asynchronous database operations
- **Efficient Queries**: Optimized queries

## 🎨 Screenshots

### Home Page
- Modern sidebar navigation
- Dynamic message counts
- Last 3 messages dropdown

### Message Management
- Clean list view
- Quick action buttons
- Responsive design

## 🤝 Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## 👨‍💻 Developer

**Okan Baskaya**
- GitHub: [@yourusername](https://github.com/yourusername)
- LinkedIn: [Okan Baskaya](https://linkedin.com/in/okanbaskaya)

## 📞 Contact

For questions about this project:
- Email: okan@example.com
- GitHub Issues: [Issues](https://github.com/yourusername/MyAcademyIdentityProject/issues)

---

⭐ **If you liked this project, don't forget to give it a star!**