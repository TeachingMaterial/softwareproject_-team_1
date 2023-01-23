## **1. Introduction**
---
In the phase/1 we have identified the functional and non-functional requirements of the student the management system and in phase/2 we will focus on developing the abstract models of the system. System modelling is the representation of a system using graphical notation, which helps the analyst to understand the functionality of the system and to communicate with the clients. The system modelling and design process involves analysing the requirements of the system and creating a visual representation of the system's components and how they interact. This process typically includes creating an overall architecture of the system, use case diagrams, sequence diagrams, class diagrams, activity diagrams and state chart diagrams.

## **3. Overall Architecture of the System**
---
Architecture design of a system refers to the process of defining the structural elements and their relationships, interactions, and interfaces to create a blueprint for building a system. This includes identifying and specifying the components, modules, and data that make up the system, as well as the overall organization and flow of the system. The architecture design is an important step in the software development process as it sets the foundation for the entire project and guides the development of the system. 
Fig 1. Represents the overall architecture of the student management system. Typically, the overall architecture include the following components like user interface, database, login page and homepage. The user can enter to the login page through any web browser by entering the username and password. The system will verify the identity of the user and determine their level of access to the systems features. The user interface allows the students, module leaders, and the IT admins to access the student management system and perform various tasks such as managing participants, viewing timetable and attendance, updating, or editing student profile. The database stores and manages the data used by the system. Overall, the architecture is designed to provide a reliable, secure, and user-friendly environment for the student management system.[1]  


## **7. Activity Diagram**
---
### **7.1 Activity Diagram Structure**
---

An activity diagram is a kind of flowchart that depicts how a system behaves, more specifically how activities or actions flow through a system. An activity diagram would depict the various activities or actions that take place within an online student management system, such as logging in, submitting coursework, viewing attendance, the timetable, lecture notes, grades, and so on. Typically, the diagram would show a succession of interconnected forms, such as rectangles and diamonds, that stand in for various actions or choices, as well as arrows that show the direction of control between these choices and actions. For further illustration the diagram may also include swim lanes which shows the different actors within the system, such as students, module leaders, and administrators. [5]

Some of the key shapes that are typically included in an activity diagram are as follows: 
---
|  |   |   |
|---|---|---|
|1.|Start node|Represents the starting point of the activity or process.|
|2.|Action state|Represents a specific action or step that is being performed within the activity or process.|
|3.|Decision node|This shape represents a point in the activity where a decision needs to be made and multiple paths can be taken.|
|4.|Control flow|Represents the flow of the activities or process.|
|5.|Merge|To bring multiple flows together.|
|6.|Fork|To split the flow into multiple paths.|
|7.|End state|Represents the end point of the activity or process.|

### **7.2 Activity Diagram Design**
---
APPENDIX shows the activity diagram for various activities and process involved in the student management system. 

Fig 5. Represents the activity diagram of the courses. This field mainly includes three main activities such as edit/ add course, search for a course and add participant.  In the edit/add section the admin can upload the course files and save it to the database. The user can search for a course by entering the key words and it will return appropriate messages as per the search result. The user can also add participants to the course by pressing the “add participant” button, which will allow them to search for a particular student. 

Fig 6. Represents the activity diagram of the student profile. In this field the students can view their personal details and edit it. The system will check the validity of the details entered by the user and save the changes.  

Fig 7.1 Represents the module leader activity diagram of the module. In this field the module leader can add/edit modules, add participant, upload a link for coursework submission and upload a link to enter the virtual; classroom., 

Fig 7.2 Represents the student activity diagram of the module. Here the students can view the lecture notes, view the resources and materials and can add coursework submissions. 

Fig 8. Represents the activity diagram of the login or register. Here the user can either login or register. Once the user finishes the registration, they will be directed to the login section. This activity would involve a user entering their username and password in order to gain access to the system. 

Fig 9. Represents the activity diagram of the fees. In this field the students can pay their fees by clicking the “Check account and make payment” button. Once the button is pressed, they will be redirected to the fee payment section where they can enter the amount they wish to way and their bank details. The system will then check whether the user is valid or not, if yes then the user could enter the OTP and confirm the payment. The system will also check the validity of the OTP. 

Fig 10.1 Represents the module leader activity diagram of the attendance. Here the module leader can view and display the QR CODE. 

Fig 10.2 Represents the student activity diagram of the attendance. Here the students can view and record attendance. the y would be able to record the attendance by just scanning the QR code displayed by the module leader. 

Fig 11. Represents the activity diagram of the timetable and term dates. Here the user will be able to view the term dates and my timetable, and they can return to the home page by clicking the home button. 


## **10. References**
---
[1] Songsom, N., Nilsook, P., Wannapiroon, P., Fung, L.C.C. and Wong, K., 2019. System architecture of a student relationship management system using Internet of Things to collect Digital Footprint of Higher Education Institutions. International Journal of Emerging Technologies in Learning (iJET), 14(23), pp.125-140. Availabel at: https://www.learntechlib.org/p/217252/ (Accessed on: 15th January 2023)  

[5] Bastos, R.M. and Ruiz, D.D.A., 2002, January. Extending UML activity diagram for workflow modeling in production systems. In Proceedings of the 35th Annual Hawaii International Conference on System Sciences (pp. 3786-3795). IEEE. Availabel at:https://ieeexplore.ieee.org/abstract/document/994510 (Accessed on: 15th January 2023)  



## **11. Appendix**
---
![Activity diagram for courses](Activity%20for%20courses.png)
Figure 5: Activity diagram for courses

![Activity diagram for student profile](activity%20diagram%20for%20student%20profile.png)

Figure 6: Activity diagram for student profile

![Module leader activity diagram of the module](module%20leader%20activity%20for%20module.png)
Figure 7.1 Module leader activity diagram for module

![Student activity diagram for module](student%20activity%20diagram%20for%20module.png)

Figure 7.2 Student activity diagram for module

![Activity diagram for login or register](activity%20diagram%20for%20login.png)

Figure 8. Activity diagram for login 

![Activity diagram for fees](activity%20diagram%20for%20fees.png)

Figure 9. Activity diagram for fees

![ Module leader activity diagram for attendance](module%20leader%20activity%20for%20attendance.png)

Figure 10.1. Module leader activity diagram for attendance

![Student activity diagram for attendance](student%20activity%20diagram%20for%20attendance.png)

Figure 10.2. Student activity diagram for attendance

![ Activity diagram for termdates and timetable](activity%20diagram%20for%20timetable%20and%20termdates.png)

Figure 11. Activity diagram for termdates and timetable 

