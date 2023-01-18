# Phase 1 - Requirements Engineering

## **1. Introduction**
---
This markdown sheet describes phase 1 in creating student management system software for an online university. A student management system means that students can participate in educational activities such as attending classes, learning modules and tutorials, monitoring their progress and receiving feedback/results. Due to student management's facilities they are widely used in every educational institution such as schools and universities. The advantages of having a student management system software are students can access studies at any time from anywhere, reduce the workloads of institutions rather than maintaining physical storage and maintenance and improve productivity for lecturers by focusing on only teaching rather than maintaining and securing physical components. Therefore, this student management system is useful for every partipants in the educational institutions such as students, lecturers, insititution's director and more.



## **2. Table**
---
|Name|Git username|Gre username|Task|
|---|---|---|---|
|Harishanan Thevarjah|Harishanan|ht7998v@gre.ac.uk|Introduction, Software process model, User requirements definition, References|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s@gre.ac.uk|Introduction, User requirements definition, Gantt chart, References|
|Nandana Krishna|nk1121|nk1640r@gre.ac.uk|Introduction, Glossary, System requirements specification, References|
|Karim Borgi|kb9488|kb3825c@gre.ac.uk|Introduction, Systems requirements specification, possible risk and risk planning, References|

|Name|Git Username|Gre Username|Task|
|---|---|---|---|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s|Introduction, User requirements definition, Gantt chart, References|
|Harishanan Thevarajah|Harishanan|ht7998v|Introduction, Software process model, User requirements definition, References|
|Nandana Krishna|nk1121|nk1640r|Introduction, Glossary, System requirements specification, References|
|Karim Borgi|kb9488|kb3825c|Introduction, Systems requirements specification, possible risk and risk planning, References|


## **3. Software process model**
---
This is going to be an abstract of our software process to create student management system for the online university. This student management system final version going to produce on 23rd March will fulfill the requirements asked by our clients.

To produce this student management system, our organization is going to use incremental software process model. It is a method of software development where an initial student management system will be designed, will be implemented and tested little by little and produce final student management system fulfilling most of the stakeholder’s requirements.

The reasons are to choose incremental model rather than others are many. In below, some of them have provided.

1.	We are developing a software. There is a chance users/ stakeholders can come and request to change requirements. For examples, online university management can change in future. Therefore, some principles/ requirements can change.
2.	This is the first student management system for the online university is going to use. Therefore, our customers/ stakeholders can’t be sure what they want.
3.	There are some other model such as Waterfall model, it’s hard to go back and change the requirements when needed. It takes more time and money.
4.	Or, if integration and configuration model used, it can be too complex. Asking helps of some various software and components. They can lead to complexity and can’t be able to satisfy other stakeholders all the time. 
5.	In incremental model, it’s easy comparatively with other models. Easily can go back and change. Less time and money. Can satisfy each stakeholders’ needs.
6.	Easier to get customers’/ stakeholders’ feedbacks/ opinions while developing the student management system.
7.	Customer needs this student management system in quick. Therefore, the incremental model can fulfill the requirements in short period by its less numbers of activities in the model.

![Figure 1: Incremental model workflow structure](Incremental%20image.jpg)
<center>Figure 1: Incremental model activity structure</center>

Figure 1 shows the workflow structure of our chosen software process model. The circle on the left in figure 1 describes the requirement gathered from our interviews with online university stakeholders. The middle rectangle has 3 software process activities. They are specification, development and validation. Each of them is concurrent activity. In the deeper description of each is,

1.	Specification: Making a formal document from the gathered user and system, functional and non-functional requirements. From that, we software Engineers will develop an initial version of student management system. It will be displayed to the system stakeholders of online university. This can be said as our phase 1.

2.	Development: From the initial version, system stakeholders will request some changes/ developments. They will be reconsidered back. Then, it outputs the intermediate version. It will be displayed to more other stakeholders and to some end users. This can be said our phase 
3.	Validation: Finally with every consideration of intermediate system, the system will be rechecked for last time to see whether it fulfills the customer requirements. Then, the final version of student management system will be implemented in the online university. This can be said our phase 3.

In the above, incremental software model definition, the advantages of the incremental software process model and workflow structures are described. But there is one more responsibility to mention. It is the limitation of the incremental software model. They are frequent incoming new requirements can corrupt the software structure and the development process is not visible. The outcomes of these would lead to more complex and spending and the developed versions’ costs can’t be estimated due to the rapid development. To reduce the effects of our limitations, we software engineers try to get our system and user requirements in completeness and consistent and reduce the imprecision of requirements.



## **5. User requirement Definition**
---

The user requirement definition part classified into 3 parts, first is stakeholder table and requirement, second is specifications of student management system and the requirements and finally with use case diagram of user requirements. [2]


### **5.1 Stakeholder Table**
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

### **5.2 Specifications of Student Management System**
---

- **5.2.1 Course & Module**
  - Students can view their corresponding course details, information and announcements. (Eg:  students can view announcements related to scheduled classes).
  - Students can access learning resources for each module. (Each module will have its own page) 
  - Module leaders can provide learning resources, detailed information & announcements. (Can upload resources whenever required & can provide announcements about class sections through the module page) 
  - Course leaders can provide resources & instructions. 
  - IT admin will be able to manage issues arising with the course & module page.
  - Newly joining students can view different course options available & can view each course's detailed structure.

- **5.2.2 Coursework, Exams & Results**

  - Module leaders can provide coursework specifications, marking criteria & submission links.
  - Module leaders can conduct online exams.
  - Students can view coursework specifications for each module.
  - Students can view grading criteria & deadlines.
  - Students will be able to submit their coursework through submission links.
  - Students will be able to do online exams in allocated times.
  - Students can view their results when it's published.
  - Module leaders can publish the results in each student account. 
  - Director & Course leader can view each student's performance in coursework & exams. 

- **5.2.3 Attendance Monitoring**
  
  - Students can mark attendance for allocated class sections and can view their overall attendance. 
  - Module leaders can allow students to mark their attendance for each section. 
  - Programme leader and module leader can view student's attendance rate. 
  - Director can view the overall attendance engagement rate in each course.

- **5.2.4 Fees & Funding**
  
  - Students can view their finance page, can view the options available to pay and they can proceed with payment. 
  - Newly joining students can view the fee structure and can view the options available to pay. 
  - Director can view each student's finance details.

- **5.2.5 Student Profiles**
 
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

- **5.2.6 Timetable**
  
  - Students will be able to see their class and exam timetable as allocated. 
  - Course and module leaders will be able to update or make changes to the timetable. 
  - Director can view the timetable. 

### **5.3 User Case Diagram**
---

In the above topics, stakeholders and facility requirements are detailed. To add more value for the definition of user requirements, below a user case diagram is shown. 

![User case](User%20case.jpg)
<center> Figure 3: User case </center>

In figure 3, according to online university hierarchical position director is the top one. He can view the students’ details, courses and modules details in any needs of any time from the student management system. Then, the IT admin in the university is in charge for the whole student management system. He is the one responsible to create student accounts for the new students and fixing minor issues in the student account. In addition, he can manage the reports created by module and programme leaders. Next is the programme leader, able to provide and alter programme details and can monitor student engagements in the respective programme. He can also view the reports provided by the module leader and can provide report about his programme. Finally, the module leader, able to provide and alter module details and can monitor student engagements in the respective module. He can only provide reports of students in the student management system. 




## **8. Reference**
---
[1] C. Larman and V. R. Basili, "Iterative and incremental developments. a brief history," in Computer, vol. 36, no. 6, pp. 47-56, June 2003. Available at: https://ieeexplore.ieee.org/document/1204375 (Accessed on: 27th November 2022)

[2] Maiden, N., 2008. User requirements and system requirements. IEEE Software, 25(2), pp.90-91. Available on: https://ieeexplore.ieee.org/abstract/document/4455639/authors#authors (Accessed on:1st December 2022)



## **9. Gantt chart**
---
![Gantt chart for planning project](gantt_chart.svg)

