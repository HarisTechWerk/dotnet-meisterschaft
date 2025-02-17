# 📢 **NotificationServiceDemo**

## 🚀 Overview  
**NotificationServiceDemo** is a flexible and modular notification system built with **C# and .NET**.  
It supports **multiple notification channels** like **Email, SMS, and Push Notifications**, following **SOLID principles** for scalability and maintainability.

---

## 🔥 Features  
✅ **Multi-Channel Support** – Easily send notifications via **Email, SMS, and Push**  
✅ **Extensible Architecture** – Add new notification types with minimal effort  
✅ **Dependency Injection (DI)** – Ensures flexibility and testability  
✅ **Follows SOLID Principles** – Clean and maintainable design  
✅ **Unit Testing** – Uses **xUnit** and **Moq** for testing  

---

## 🛠 Tech Stack  
- **.NET 9**  
- **C#**  
- **Dependency Injection (DI)**  
- **xUnit & Moq (Unit Testing)**  

---

## 📂 Project Structure  
```bash
NotificationServiceDemo
├── src/                      # Core application
│   ├── INotificationService.cs
│   ├── BaseNotificationService.cs
│   ├── EmailNotificationService.cs
│   ├── SMSNotificationService.cs
│   ├── PushNotificationService.cs
│   ├── NotificationManager.cs
│   ├── Program.cs
│
├── tests/                    # Unit tests
│   ├── NotificationServiceTests.cs
│
└── README.md                 # Project documentation
