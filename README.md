# 📧 Identity Email Project

A modern email/messaging application based on ASP.NET Core Identity. A full-featured platform where users can securely send and receive messages, save drafts, and manage their messages.

##  Features

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

## 📸 Application Screenshots & Features

### 1. Login Screen
<img width="1919" height="991" alt="1" src="https://github.com/user-attachments/assets/109b079c-878b-49ae-b038-0033d9b6200c" />

This screen allows registered users to **sign in** with their email and password.  
- Email and password input validation.  
- Quick navigation to the **Register** page for new users.  
- Styled with AdminLTE components for a clean UI.  

---

### 2. Registration Screen
<img width="1919" height="991" alt="2" src="https://github.com/user-attachments/assets/ebd51d1e-3c60-4cd6-98d5-c7db67d549a3" />


The registration page where new users can create an account.  
- Fields: First Name, Last Name, Username, Email, and Password.  
- ASP.NET Identity validation for strong password rules and unique email/username.  
- Direct integration with Entity Framework Core for user persistence.  

---

### 3. Inbox
<img width="1919" height="991" alt="3" src="https://github.com/user-attachments/assets/47f1950a-cc1b-414d-bc38-47c222644832" />


The main mailbox interface for receiving messages.  
- Displays all **incoming messages** with sender, subject, date, and status (Read/Unread).  
- Message actions: **Mark as Read/Unread**, **Delete**.  
- Sidebar with folders: Inbox, Sent, Drafts, Trash.  
- Label system for marking important messages.  

---

### 4. Sent Messages
<img width="1919" height="991" alt="4" src="https://github.com/user-attachments/assets/3db1bdae-f705-4286-b774-077de840c5be" />


Shows all messages sent by the current user.  
- List of sent messages with subject and date.  
- **View** button to see the full details of a sent message.  

---

### 5. Drafts
<img width="1919" height="991" alt="5" src="https://github.com/user-attachments/assets/19e403a4-aa13-4726-b4e3-0728c0df9d48" />


Displays all saved drafts.  
- Draft messages saved with subject and date.  
- Ability to **Edit** or **Delete** drafts.  
- Supports resuming draft editing before sending.  

---

### 6. Trash
<img width="1919" height="991" alt="6" src="https://github.com/user-attachments/assets/5cff5624-c06a-492a-be06-d0b05695248e" />

The trash folder for deleted messages.  
- Shows deleted messages with subject, sender, and date.  
- Options to **Restore** messages back to Inbox or permanently **Delete**.  

---

### 7. Important Messages
<img width="1919" height="991" alt="7" src="https://github.com/user-attachments/assets/e7afd1e9-0010-4b9c-b20c-aeb3821d5c0a" />


A dedicated view for all messages marked as **important**.  
- Starred messages are highlighted and filtered here.  
- Actions: **Read/Unread** and **Delete**.  

---

### 8. Notifications Dropdown
<img width="628" height="523" alt="8" src="https://github.com/user-attachments/assets/992dbc51-60c1-4834-b6e9-d6af563af05d" />


Top-bar dropdown displaying quick notifications of recent messages.  
- Shows sender name, subject, and received time.  
- Star icon for quickly marking messages as important.  
- **See All Messages** link for full navigation.  

---

### 9. User Profile & Logout
<img width="394" height="311" alt="9" src="https://github.com/user-attachments/assets/8bf535db-b9f6-4509-b9bf-35abc0c9448b" />


Top-right user menu for account management.  
- Displays the logged-in user’s name.  
- **Logout** button to securely sign out using ASP.NET Identity authentication.

### 10. Multi-User Inbox
<img width="1919" height="991" alt="10" src="https://github.com/user-attachments/assets/4ff6b0e0-2e1a-4483-9b0f-dd52bea5dfc8" />


This screen demonstrates that **different user accounts** can log in and view only their own mailbox.  
- Each user has an isolated inbox.  
- The system ensures **data separation**: users can only see the messages sent to them.  
- Supports all actions: **Read/Unread toggle**, **Delete**, and **Label management**.  
- Example: One user sees messages from "Okan Baskaya", while another sees their own mailbox content independently.  

### 11. Message Detail
<img width="1919" height="991" alt="image" src="https://github.com/user-attachments/assets/9bb6af26-c8aa-49a4-9685-8a247c82dc08" />


This screen displays the full **message details**.  
- Shows sender email, subject, and timestamp.  
- Displays the complete message body.  
- Provides a user-friendly way to manage single message interactions.  



## 📝 License

This project is licensed under the MIT License. See the `LICENSE` file for details.

## 👨‍💻 Developer

**Okan Baskaya**
- GitHub: [@emreokanbaskaya1](https://github.com/emreokanbaskaya1)
- LinkedIn: [Emre Okan Baskaya]([https://linkedin.com/in/okanbaskaya](https://www.linkedin.com/in/emre-okan-baskaya/))

## 📞 Contact

For questions about this project:
- Email: emreokanbaskaya@gmail.com

---

⭐ **If you liked this project, don't forget to give it a star!**
