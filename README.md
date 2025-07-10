# 💇‍♀️ Customer Manager 8.0

**Customer Manager 8.0** is a simple, user-friendly C# console application designed to help small businesses manage customer information.  
Originally built for my wife's beauty salon, it's a lightweight tool for storing, listing, and managing client records with just a few keystrokes.

---

## ✨ Features

- 📄 **Add new customers** (Name, Email, CPF)
- 📋 **View all registered clients**
- 🗑️ **Remove customers** by selecting their index
- 💾 **Saves all data to a local JSON file** (`clients.json`)
- ⚙️ **Loads data on startup** so nothing is lost

---

## 🧰 Technologies Used

- **C#** (.NET Console Application)
- **System.Text.Json** for serialization
- Minimal and portable — no database needed

---

## 📌 How to Use

When you run the application, you'll be greeted with a simple menu:

Customer/Client Manager 8.0 - Welcome!
Developed by SolarX!

Please select an option:
1 - Customer List
2 - Add Customer
3 - Remove Customer
4 - Exit

yaml
Copiar
Editar

Choose an option by typing the number and pressing Enter.

### ➕ Add Customer
You'll be prompted to enter the customer's name, email, and CPF. The program saves the customer to `clients.json` automatically.

### 📋 List Customers
Displays all saved clients with their info and index number.

### 🗑️ Remove Customer
Shows a list of customers, asks for the index of the one to remove, and confirms before deletion.

---

## 🧠 Why I Built This

My wife runs a beauty salon and needed a basic tool to manage her customer contacts — no spreadsheets or complicated systems.  
I created this app to make her daily admin smoother, and it also gave me a practical C# project to sharpen my skills.

---

## 💾 Data Format Example (`clients.json`)

```json
[
  {
    "Nome": "Ana Costa",
    "Email": "ana@example.com",
    "Cpf": "123.456.789-00"
  }
]
🚧 Potential Improvements
🔒 Input validation for CPF and email

📅 Appointment scheduling

🧾 Export customer lists to .csv

🌐 GUI version (WinForms or WPF)

👤 Author
SolarX
💡 Built for real-life needs — tested and loved in a beauty salon!


📄 License
Use this project freely for learning or personal use.
If you improve it or use it in your own business — I’d love to hear about it!
