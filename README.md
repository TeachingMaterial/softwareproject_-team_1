# **Phase 3 - Implementation and Testing**

## **1. Table**


|Name|Git Username|Gre Username|Tasks|
|-----|---|-----|---|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s@gre.ac.uk|Course & Module Section|
|Harishanan Thevarjah|Harishanan|ht7998v@gre.ac.uk|Home Page, Fees Page, Time Table and Student Profile|
|Karim Borgi|kb9488|kb3825c@gre.ac.uk|Login & OTP Page, Login Database|
|Nandana Krishna|nk1121|nk1640r@gre.ac.uk|Attendance Page, Other Database's|

---
## **2. Introduction**

In the third phase of our project, we focused on implementing and testing the second phase of the student management system. Our team used the C# programming language to design the user interface, and we created various forms for different tasks such as login, OTP verification, creating accounts, home page, fees, attendance, timetable, courses, and student records. We created separate databases for each form, and the textboxes on the forms retrieved data from these databases and executed processes according to instructions. After creating forms in different branches, we merged them together into the test branch on GitHub. To ensure the proper connections between the databases and the windows forms, we conducted various tests. The test branch was pushed into the when testing was completed.

---

## **3. Implementation**

The Student Management System system consists of several pages including a login page, OTP page, home page, course page, attendance page, timetable page, fees page, and student profile page. The implementation of each of these pages is discussed below: 

**We have created a login interface with 3 forms:** 

- Login 
- Create account
- OTP form


The login prompt will ask the user to input their usernames and password, this will be validated using data from a windows access database. If the login details are correct, the user will then go to an  otp form, which in theory should send the user to receive an otp in their email and if they input the correct one, then the login process succeeds, and the user proceeds to the login page.
In case the user has no account, they can press the create account button, this will allow them to insert their details which will be pushed forward to the access database.

### **3.1 Login Page**

The login page comprises of 2 labels, 2 textboxes, and 2 buttons

The labels are used to hint for the user to know where they can input the required fields

The textboxes are:

- Username
- Password

There are where the users can input their details.

The buttons are:

- Login
- Create Account

The login button will redirect user to the OTP page for further verification, while the create account button will redirect users to create their new account

The Validation code:

![Alt text](login%20code.jpeg)

The code above is able to validate the inputted username and password from the Microsoft access database, checking the strings and using a counter to make sure input is the same as the pre-existing data.

**New Account**

This form comprises of 6 labels,6 textboxes,  as well as one button. These textboxes and labels will prompt users to input the required fields and allow for the user to input them. The dropdown menu is used to allow users to select their course which is linked to the database. Pressing on the create button will guide users back to the login page.

**OTP Page**

This form just comprises of a label, a textbox, and 1 button. These will prompt the user to input their OTP into the textbox as a form of extra validation. The login button will guide the user to proceed to the home screen.

---


 ### **3.1 Course Page**
 
 The course page takes the user to their corresponding course page. We created course page's for four different courses.

![Alt text](coursepage.png)
 

It contains following elements/options:

- **Course Details** - Course information including Course name and Course leader name.

- **Announcements** - Option to add announcements regarding course.

- **Course Handbook** - Users can view the course handbook.

- **Module Button** - Users can go to the corresponding module page by clicking module button.

---

### **3.2 Module Page** 

The Module page takes the user to their corresponding module page. We created two modules each for every courses for an demo.

![Alt text](modulepage.png)

It contains following elements/options:

- **Module Details** - Course information including Module name and Module leader name, etc...

- **Lecture Notes** - Users can view Lecture notes.

- **Courseworks & Exams** - Users can view information regarding coursework, exams etc...

- **Resources & Materials** - Users can go to the corresponding module page by clicking module button.

However, We made some basic format of a Course page and Module Page, The admin users will be able to make changes as their needs.



----

## **4. Testing**

To ensure the system works as intended, several tests were conducted during and after the development process. 

The testing involved the following steps:

- **Unit Testing** - We performed unit testing on each sections to ensure that they are working as expected. 

- **Integration & System Testing** - We performed integration testing on the entire system after merging to ensure that all the systems are working together seamlessly. 

- **Regression Testing** - The system was tested after any changes or updates were made to ensure that the existing functionality was not affected.


The testing process helped to identify and fix any bugs or errors in the system, ensuring that it works smoothly and meets the requirements of the users.

---

## **Conclusion**

The user interface for our project were created using the C#. We created various forms for different functionalities. After developing the forms, we integrated them into the test branch. Nevertheless, we encountered obstacles when we tried to link the forms to the MS Access database. We attempted to remedy the situation by creating separate databases for each form within a branch that contained the source data file. However, even after pushing this branch to the test branch, we still encountered some issues.
Despite the difficulties we faced during this project, we were able to gain valuable insights into designing and coding Windows forms. We also deepened our understanding of the MS Access data file. As we move forward, we hope to continue working on similar project to make it a success, drawing upon our newfound knowledge and experience. 