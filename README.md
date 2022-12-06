# Phase 1 - Requirements Engineering

# Introduction

I am going to introduce the topic here....

|Name|Git Username|Gre Username|Task|
|---|---|---|---|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s|Introduction, User requirements definition, Gantt chart, References|
|Harishanan Thevarajah|Harishanan|ht7998v|Introduction, Software process model, User requirements definition, References|
|Nandana Krishna|nk1121|nk1640r|Introduction, Glossary, System requirements specification, References|
|Karim Borgi|kb9488|kb3825c|Introduction, Systems requirements specification, possible risk and risk planning, References|


## **2. User requirement Definition**
---

The user requirement definition part classified into 3 parts, first is stakeholder table and requirement, second is specifications of student management system and the requirements and finally with use case diagram of user requirements. [2]


### **2.1 Stakeholder Table**
---

The table below express the stake holders, types and their requirements. This table form under the gathered information from the interview happened with client. 

|Stakeholders|Types|Requirements|
|-----|---|-----|
|Enrolled student|End user| Want to mark attendance, Want to get course and module details, Want to submit course works, Want to get learning resources, Want to check grades.|
|Programme leader|End user|Want to get students course details, Want to check student engagements in the programme, Want to provide programme instructions to students.|
|Module leader|End user|Want to get students’ course details, Want to check student engagements in the module, Want to check course work submissions, Want to provide module instructions to students, Want to upload learning resources.|
|Director|System Owner|Want to get student details including student contacts, Want to know students’ finance details, Can observe overall performance.|
|IT Admin|System Manager|Want to create student's profiles with username, Want to manage student's profiles, Want to fix issues in students’ profiles.|
|New Students|External Stakeholders|Want to check programme details and structure, Want to check fee’s structure, Want to register in a programme.|



![User hierachical](User%20interaction.png)
<center>Figure 2: Stakeholder interaction </center>

### **2.2 Specifications of Student Management System**
---

- **2.2.1 Course & Module**
  - Students can view their corresponding course details, information and announcements. (Eg:  students can view announcements related to scheduled classes).
  - Students can access learning resources for each module. (Each module will have its own page) 
  - Module leaders can provide learning resources, detailed information & announcements. (Can upload resources whenever required & can provide announcements about class sections through the module page) 
  - Course leaders can provide resources & instructions. 
  - IT admin will be able to manage issues arising with the course & module page.
  - Newly joining students can view different course options available & can view each course's detailed structure.

- **2.2.2 Coursework, Exams & Results**

  - Module leaders can provide coursework specifications, marking criteria & submission links.
  - Module leaders can conduct online exams.
  - Students can view coursework specifications for each module.
  - Students can view grading criteria & deadlines.
  - Students will be able to submit their coursework through submission links.
  - Students will be able to do online exams in allocated times.
  - Students can view their results when it's published.
  - Module leaders can publish the results in each student account. 
  - Director & Course leader can view each student's performance in coursework & exams. 

- **2.2.3 Attendance Monitoring**
  
  - Students can mark attendance for allocated class sections and can view their overall attendance. 
  - Module leaders can allow students to mark their attendance for each section. 
  - Programme leader and module leader can view student's attendance rate. 
  - Director can view the overall attendance engagement rate in each course.

- **2.2.4 Fees & Funding**
  
  - Students can view their finance page, can view the options available to pay and they can proceed with payment. 
  - Newly joining students can view the fee structure and can view the options available to pay. 
  - Director can view each student's finance details.

- **2.2.5 Student Profiles**
 
  - IT admin can produce only username, student ID and temporary password for newly joining students. 
  - Newly joining students can build their own profile with the username and temporary password provided by IT admin. 
  - Students won't be able to change usernames. 
  - Two-factor authentication is required when signing in. 
  - Students can update their details whenever needed. 
  - Only Director will be able to see personal details. 
  - Students can manage their profile including course and fee details. 
  - Director, course and module leaders will be able to view each student's profile. 
  - Course leaders can see students enrolled in the corresponding course. 
  - IT Admin will be able to manage student profiles and fix the issues related to student accounts. 

- **2.2.6 Timetable**
  
  - Students will be able to see their class and exam timetable as allocated. 
  - Course and module leaders will be able to update or make changes to the timetable. 
  - Director can view the timetable. 

### **2.3 User Case Diagram**
---

In the above topics, stakeholders and facility requirements are detailed. To add more value for the definition of user requirements, below a user case diagram is shown. 

![User case](User%20case.jpg)
<center> Figure 3: User case </center>

In figure 3, according to online university hierarchical position director is the top one. He can view the students’ details, courses and modules details in any needs of any time from the student management system. Then, the IT admin in the university is in charge for the whole student management system. He is the one responsible to create student accounts for the new students and fixing minor issues in the student account. In addition, he can manage the reports created by module and programme leaders. Next is the programme leader, able to provide and alter programme details and can monitor student engagements in the respective programme. He can also view the reports provided by the module leader and can provide report about his programme. Finally, the module leader, able to provide and alter module details and can monitor student engagements in the respective module. He can only provide reports of students in the student management system. 

References

[2] Maiden, N., 2008. User requirements and system requirements. IEEE Software, 25(2), pp.90-91. Available on: https://ieeexplore.ieee.org/abstract/document/4455639/authors#authors (Accessed on:1st December 2022)



