# Bookstore
This is a Visual Basic application for a college bookstore that calculates the cost of software for customers (students and non-students). It handles credit card information, applies student discounts, and records transactions to a text file.

## Features

* **Cost Calculation:** Calculates the price of software based on customer type (student or non-student).
* **Student Discounts:** Applies specific discounts to software purchases for students.
* **Data Recording:** Records transaction details (credit card number, software, discount, cost) to a text file.
* **Input Validation:** Validates user input, including credit card number and expiration date.
* **User Interface:** Provides a graphical user interface (GUI) for easy interaction.

## How It Works

1.  **User Input:** The user enters their credit card number, expiration date, selects a software title, and specifies whether they are a student.
2.  **Input Validation:** The application validates the credit card number and expiration date to ensure they are in the correct format.
3.  **Cost Calculation:**
    * If the user is a student, the application applies the appropriate discount to the software price.
    * If the user is a non-student, the application calculates the regular price.
4.  **Transaction Recording:** The application records the transaction details (credit card number, software, discount, and final cost) to a text file.
5.  **Output:** The application displays the final cost of the software to the user.

## File Structure

* `frmCollegeBookstore.vb`: Contains the main form's code.
* `Student.vb`: Defines the `Student` class, which inherits from `SimpleCustomer` and calculates discounted prices.
* `SimpleCustomer.vb`: Defines the `SimpleCustomer` class, which calculates the regular price of software.
* `RecordFile.vb`: Defines the `RecordFile` class, which handles writing transaction data to a text file.
* `costs.txt`:  Stores the transaction records.

## How to Use

1.  **Prerequisites:**
    * Microsoft Visual Studio (or a compatible VB.NET compiler)
2.  **User Interaction:**
    * Enter customer information in the form.
    * Click the "Final Total" button to calculate and display the cost.
    * Click the "Daily Total" button to view the total sales for the day.
    * Click the "Clear" button to reset the form.
