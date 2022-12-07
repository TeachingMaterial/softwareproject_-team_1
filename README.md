# Phase 1 - Requirements Engineering
 
# Introduction
 
I am going to introduce the topic here....
 
|Name|Git Username|Gre Username|Task|
|---|---|---|---|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s|Introduction, User requirements definition, Gantt chart, References|
|Harishanan Thevarajah|Harishanan|ht7998v|Introduction, Software process model, User requirements definition, References|
|Nandana Krishna|nk1121|nk1640r|Introduction, Glossary, System requirements specification, References|
|Karim Borgi|kb9488|kb3825c|Introduction, Systems requirements specification, possible risk and risk planning, References|


## **5 System Requirements Specification**
----

The SRS lists all the system requirements including functional, non-functional, and interface requirements. Typically, SRS is useful for the system developers, possible marketing staff, and testers, system manager and system owner. The customer requires a student management system for an online university where the staff and students can access the student profile, courses and modules, exams, results, timetable, register new students, and monitor the attendance. This online platform shall strengthen institutional legitimacy, improve user satisfaction, and provide information rich virtual campus for both students and faculty.

### **5.1 Functional Requirements**
----
|Activity|User story|Description|Priority [High=5 Low=1]|
|---|---|---|---|
|Login|An existing user shall be able to login into the system.|The user shall be able to enter the system once their email id and password are entered. They will be able to enter the OTP they have received in their registered mobile number or in the Microsoft authenticator app.|5|
|Reset Password|The user shall be able reset the password.|The user can reset the password by clicking “forgot my password” button. Then the user shall receive an email regarding password reset.|5|
|Course Catalogue|User can access the catalogue of modules.|The user can access a list of the modules and its course id and leader. By clicking any of the desired course, the user shall be directed to the respective module page.|5|
|Modules|The students can access their module details and the faculty can upload any required information in this section.|The faculty can upload any required data like lecture notes, lecture recordings, resources and materials, coursework details, previous year questions and resit information. They shall also be able to provide a link for the coursework submission and a link to enter the virtual classroom.|5|
|Student Records|The students can update their personal information, can access their course details, results, account and can make payment.|The students can update or edit their personal information like mobile number, address, emergency contact details, email address, and bank details. The students can access their course details, mode of study, department and faculty, year of study and their level of study. The students can view their grades and results letter. Students can check their accounts and make online fee transactions by clicking the “Make Payment” button and the user will be directed to an external payment option.|5|
|Timetable and Term Dates|The user can access the class and exam timetable.|The user can access lectures/labs/tutorials/workshops timetable by clicking “My Timetable” button.|5|
|Attendance|Programme leader or course leader can record and view attendance of the students.|the programme leader or the course leader can record the attendance of the students. The students can also view their attendance records.|5|
|Notifications|The user will receive notifications in the notification tab.|The user shall receive notification about their upcoming submissions and events.|5|
|Register new students|New students can access the different courses and register to the university.|New students can access the catalogue of the courses, course content, fees, duration, start month, entry requirements and career opportunity. The students can register to the university by providing necessary previous educational certificates as per the entry requirements. Once the students get their offer from the university, they can confirm their offer and pay the fees. When the student is enrolled, they will receive a personal email id, username, and a temporary password.|5|

### **5.2 Non Functional Requirements**
----
•	Speed: The system shall not take more than two seconds to load the page or refresh the screen. 

•	Usability: The user shall not take more than one hour of training to attain their goals. The users shall not make an average of 2 errors after they complete their training. 

•	Security: Only the user with the role “system owner” can view the students records. The students have access to only their own information, not that of any other participants. Similarly, only the student's email, username, and unique ID are accessible to the programme leader and module leader.

•	Reliability: The user will be able to access any data or visit any links 98% of the time without failure.

•	Availability: In the case of any unanticipated system disruption, all features will be accessible again after one working day.

•	Maintainability: The system shall be down for maintenance approximately three hours in the event of any feature malfunction.

•	Recoverability: If a critical event happens on the system, the company shall take action to resume normal operations as soon as possible—in no more than two days.

•	Data integrity: The system shall maintain data integrity by keeping backups of all data of students and faculty.

•	Localization: The system includes a feature that changes the time zone and currency based on the country the user is in. 

•	Scalability: The system should support at least 1,000,000 simultaneous visits.

•	Performance: The system shall receive any email in not more than 10 seconds to reset the password. The user shall receive an OTP to the registered phone number or the authenticator app in not more than 10 seconds to login into the system. The system will generate a user id and an email id for each student based on the first letters of their names, and a four-digit number will be followed the two letters. 

### **7 Glossary**
----

•	Agile process: A process approach which is flexible to rapid changing requirements.

•	Business risk: Risks affecting the organization developing the software.

•	C# : A computer programming language.

•	End-user: A person who ultimately uses or is intended to ultimately use a product.

•	External stakeholders: People or groups outside the organization. 

•	Functional requirement: Defines the requirements for a product, including its features and functionalities.

•	Incremental process model: A method of building software products in which a system is built piece-by-piece. 

•	Non-functional requirement: describe the general properties of a system.

•	Product risk: Risks that affect the quality or performance of the software being developed.

•	Project risk: Risks that affect schedule and resources.

•	Stakeholder:  People or organizations that have an interest in the project and software to be produced.

•	System Manager: Plan, coordinate, and direct computer-related activities at an organization and help determine its information technology goals.

•	System Owner: The individual responsible for the overall procurement, development, integration, modification, operation, maintenance, and retirement of an information system.

•	System Requirements Specification: A document that outlines need of the software and how the software works.

•	User requirements: This means what the user expects the software to do.

•	Waterfall process model: A software process model having a plan driven approach with individual phases of activities such as specification and development.

### **References**
----
[3] Thayer, R.H., 2002. Software system engineering: A tutorial. Computer, 35(4), pp.68-73. Available at: https://ieeexplore.ieee.org/abstract/document/993773?casa_token=yAn9P3B2VHcAAAAA:xm_Nm-WJqTaIX7m28rd5fnx59BpA7IC5zkYcMfK6EW7byV8isK3lONyVUUdvzgQEq2OG9fBLUrU (Accessed on: 2nd December 2022)