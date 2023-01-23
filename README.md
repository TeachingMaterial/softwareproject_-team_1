
## **2. Table**
---
|Name|Git username|Gre username|Task|
|---|---|---|---|
|Harishanan Thevarjah|Harishanan|ht7998v@gre.ac.uk|Sequence diagram, Class diagram, Gantt chart, Reference|
|Nirmal Philips Tom|nirmalphilips2003|nt1217s@gre.ac.uk|UML case diagram, Overall architecture, Reference|
|Nandana Krishna|nk1121|nk1640r@gre.ac.uk|Introduction, Overall architecture, Activity diagram, Reference|
|Karim Borgi|kb9488|kb3825c@gre.ac.uk| Class diagram, State chart diagram, Reference|  


## **4. Use Case Diagram**
---  
A use-case diagram describes the high-level functions and scope of a system. Moreover, these diagrams show how the system interacts with its actors. Use cases and actors in use-case diagrams describe what the system does and how the actors use it, but not how it operates internally. [2] 


### **4.1 Elements in use-case diagrams:**
--- 
- Use cases

  A use case describes a function that a system performs to achieve a user's goal.

- Actors

  An actor represents a role of a user that interacts with the system that you are modeling. The user can be a human user, an organization, a machine, or another external system. 

Accroding to figure 2 in appendix (use case diagram), Users are classified into Primary users and Secondary users according to their role:


|Primary Users|Secondary Users|
|---|---|
|New Students|Module Leader|
|Enrolled Students|Programme Leader|
||IT Admin|
||Director|


### **4.2 Tabular Description: STUDENT MANAGEMENT SYSTEM**
---  
From the figure 2(use case diagram) in appendix the use cases are described detail in the below tabular descriptions.  
<br>

#### **4.2.1 Create Profile/Profile Login/Reset Password/Manage Profile**
---
|      |       |
|---|---|
|Actors|•	New Student •	Enrolled Student •	IT Admin|
|Description|•	New Students/Enrolled Profiles can Create/Manage their profile, account with the username and temporary password provided by IT Admin. •	Students can reset their password. •	IT Admin can fix issues related to student account and profiles.|
|Data|•	Student Records/Personal details. •	Account Information.|
|Stimulus|•	Username and temporary password provided by IT Admin. •	Student creating/Managing their profile.|
|Response|•	IT Admin will fix issues related to account.|
|Comments|•	Students require two-factor authentication to login their profile.|  
<br>

#### **4.2.2 Module Page/Information & Announcements/View Results/Timetable &Term Dates**
---
|    |    |
|---|---|
|Actors|•	Enrolled Student •	Module Leader •	Programme Leader •	IT Admin|
|Description|•	Students can access Learning resources, coursework & Exam details for each module. •	Student can view Announcements & other information related to course. •	Students can view their results. •	Students can view their Timetable & Term Dates. •	Module leader can provide learning resources, coursework & Exam details through Module page. •	Module leader can provide announcements through module page. •	Programme Leader can provide announcements. •	IT Admin can fix issues arising with module page.|
|Data|•	Course/Module records.|
|Stimulus|•	Announcements  provided by Programme/Module Leader. •	Learning resources/Coursework & Exam details updated by Module Leader.|
|Response|•	Students uploading coursework's. •	Students attending exams. •	Students viewing results.|
|Comments|• Module leader will only be able to access their corresponding module. |  
<br>

#### **4.2.3 Attendance/Performance & Engagement Rate/Fees & Funding**
---  
|   |   |
|---|---|
|Actors|•	Enrolled Student •	Module Leader •	Programme Leader •	Director|
|Description|•	Students can mark their attendance for each section. •	Student can view and make fees payments. •	Module Leader can allow students to mark their attendance. •	Module Leader can view each student's performance & engagement rate for their corresponding module. •	Programme Leader can view each student's performance & engagement rate for each module. •	Director can view overall performance & engagement rate. •	Director will be able to view student fees records.|
|Data|•	Attendance records. •	Performance & Engagement records. •	Fees, Funding records.|
|Stimulus|•	Module leader allowing students to mark their attendance. •	Fees & Funding details and payment options delivered.|
|Response|•	Students marking their attendance. •	Students paying fees. • Programme/Module Leader & Director checking performance & engagement rate. |
|Comments|• Module Leader can view students perfomance for their corresponding module. • Programme Leader can view students performance for their programme. • Director can view each students performance & overall Module/Course performance.|  
<br>



## **5. Sequence diagram**
---
### **5.1 Sequence diagram structure**
---
The sequence diagram unified modelling language is another type of interaction model diagram. It shows all components/ parts in the system with user interaction. Here, data flows sequentially from one object to another to show the system interactions. Engineers prefer this type of interaction model most in the design phase.  
The sequence diagram mainly has a stick figure, rectangle boxes and arrow lines with a label. They respectively indicate,  
<ul>
    <li> Stick figure : user of the system  
    <li> Rectangle boxes : components/ objects of the system  
    <li> Arrow lines with label : message/ data flow between the objects. (It can be dashed lines to represent any return messages)  
</ul>
This documentation aims to create student management software for an online university. Therefore, a student is considered the user and student management software is regarded as a system. Student management software has several objects in it. They are a student portal, login server and system server containing courses, modules, timetables, attendance and fees objects. Therefore, in the sequence diagram, a student is shown as a stick figure and the student portal, login server, system server and other components are represented with a rectangle.  

Moreover, vertical dashed lines, vertical rectangular boxes and some dotted rectangle boxes with separating dot lines have been used. The vertical dashed lines show the existence of objects and an actor over the time. It is known as a lifeline. Vertical rectangular boxes over them are used to indicate the activation of an object. They are known as activation boxes. The activation box starts from the first interaction message and ends with the last interaction message of the object. The rectangle box with separating dotted lines is used to represent the conditions. It is known as an alternative frame. It can have two or more mutually exclusive conditions in it. Each rectangle will be labeled with the conditions.[4]    


### **5.2 Sequence diagram design**
---
 The diagram shown in appendix figure 3 is the sequence diagram created for the student management software. The diagram's top and bottom sequentially show the actor and objects in the student management system software. This sequence diagram process shows students how to access their module, course, or other needs in the student management software.  

As to the use case,

1.	Students must first login through their own student portal login page. He has to use his valid username and password.  

2.	The student portal will send those credentials to the login server. The login server contains its database and will check whether the credentials are valid.  

3.	The login server can react in two different mutually exclusive ways. Therefore, an alternative frame is used with two separated rectangles. They represent,  

    1. If credentials are valid, it requests a one-time password from the Microsoft authentication app.  
    2. If credentials are invalid, the login server reacts with an error message saying "wrong credentials" through the student portal.  

4.	If credential valid(3.1) happens, the student enters the one-time password in the student portal login page.  

5.	The student portal sends the one-time password again to the login server to verify it.   

6.	Again, another alternative frame shows the results after verification. (This one-time password step happens for an extra layer of security. An unknown person can access a student portal online without the student's permission by finding his username and password. Therefore, this extra layer of protection gives the students an acknowledgment that they are entering their student portal.)  

    1.	If OTP is valid, students can view their student portal home page.  

    2.	If OTP is invalid, the student gets a message saying, "OTP is incorrect." 

7.	If a student gets through the home page, the student can request any function he requires. It can be any operation in his portal, such as wanting to view his course detail or wanting to view his module or timetable.  

8.	The student portal will send the command to the system software.  

9.	If the student asks to view the course, the system server will send a request message to the course object.  

10.	The course object will return the page/details of the course to the system server.  
(Likewise, 9 and 10, It happens to all other objects such as modules, attendance, timetable and fees.)  

11.	The system server will send the accepted command function to 	the student portal.  

12.	The student portal will display the requested function output.  

The above sequence processes are how the student management system works, as shown in the sequence diagram in appendix figure 3.



## **6. Class diagram**
---
Before moving to other behavioural UML diagrams, it's better to start from the class diagram. It gives users accurate illustartions of the system and objects used in student management system. Class diagrams are known as static structural unified modelling language. It describes the structure of the system in more details. Thess details aid a lot in system implementation and testing part(phase 3).


### **6.1 Class diagram structure**
---
A class diagram represents with 3 rectangle boxes. The top rectangle represents the class name, middle rectangle represents the class attributes and the bottom rectangle represents class methods/ operations.  
1. Class diagram is used to represent the components in the student management system software. They are student profile, course, module, timetable, log in, register attendance and fees/ payment. These components are named in the top rectangle which is **class name**.  
2. These components will have same/ specific characteristics. Example student profile class have student id, student first name, student last name, student username, student contact number, student address and student date of birth. These characteristics will be used in the middle rectangle which is **class attributes**. Similar like this each class will have number of attributes. These attributes help to identify the instances in the class. [3] 

3. Class to interact with data a **method** must need. Example student class to get data for its components, it must have operations such as add a student, save student, edit student details, update student details, delete student and search student. These operations will be displayed in the bottom rectangle. 

Moreover, there is an important thing. It is the **class visibility**. Every user in the class diagram can’t access all data. For example, in a student class student’s first name can be public, but his student id cannot be. It must be protected. Therefore, engineers use different access levels such as public, private, package and protected.  Public means can be accessed from everywhere. Private means can only be accessed inside the class. Protected means accessed only in the same class and sub-classes of the system. Packaged means accessed only in the class package.


### **6.2 Class diagram design**
---
The diagram shown in appendix figure 4 represents the student management software’s class diagram. It contains classes such as,
1.	End Users : Student, Module leader and Course leader.   
2.	Student profile : to access the online university.  
3.	System components : Courses, Modules, Timetable, Fees, Attendance and Login.  

The classes in the diagram are built using relevant attributes and methods. The attributes in classes are shown with suitable data types. For example, consider the log in class shown in the class diagram. It has a login id, which has inputs in numbers. Therefore, an integer data type is used. Similarly, for all other attributes, the data types are mentioned next to them. Appropriate methods are fetched in the method box to activate the class functions. For example, course class must have the functions to add a new course, add course details and edit course details. On that account, “add Course()”, “add Details()” and “edit Details()” operations used.  

Next, the attributes' visibility, most attributes have access levels of private and protected mode. Private is shown with (-) and protected is shown with (#) before the attributes. Private access level is used in student profiles' date of birth, mobile number and home address. These kinds of access levels are assigned due to security purposes. The private visibility gives access to the class only. They are similarly considered in the login class's password, module, and course leader's id. Apart from these attributes, everything's access level is set to protected visibility. It can be accessed only in the class and its subclasses. Although this consideration has been made in phase 2, it is possible to change them in phase 3 due to data retrieval needs.  

The classes in figure 4 are connected using relevant association links. Students are the end users of this system. Suppose the students want to access online university, they should have valid student profile. Therefore, an inheritance link is used between the student class and the student profile class. It considers the student as a main class and the student profile as a sub-class. If students had valid student profiles, they can access the system's components such as courses, timetable, attendance, login and fees. Therefore, a composition link is used between the student profile and the system's function classes. Moreover, an association link is used between the module leader class and the student profile class. It is a basic relationship to connect classes. The association link provides the module leader class to access his module's students' details. However, the earlier described private access will not show the students' address, contact or date of birth details. This same scenario happens for the course leader and student profile class.  

Finally, the numbers near the edges of connecting links show the multiplicity between the classes. In other words, active logical association. The online university's student management system will allow one student to have only one student portal. Therefore, one has been placed on the two edges of connecting links between the student and student profile classes. Likewise, it happens in the connections between the student profile and the system's components. Saying one student profile can access one system component. The multiplicity in the connecting link with course and module classes have "1" to "1..n", saying one course will have at least 1 module to n number of modules. Therefore, "1" is denoted near the course and "1..n" is denoted near the modules. The "n" represents the number of possibilities. Due to the client's needs, it can be two or more in the system implementation part phase. For example, in online university teaching, a module can have two module leaders due to module or course complexity. Therefore, a '1..n' and '1.. n' multiplicity is used near module leader, module class, and course leader and course class. 

By getting to know these class diagram, readers can understand the following behavioural UML diagrams in more details.   


## **9. References**
---
[2] Rosenberg, D. and Scott, K., 1999. Use case driven object modeling with UML (pp. 1-4). Reading: Addison-Wesley Professional. Available at: https://link.springer.com/book/10.1007/978-1-4302-0369-8 (Accessed on: 12th January 2023)

[3] Ali, N.H., Shukur, Z. and Idris, S., 2007, August. A design of an assessment system for UML class diagram. In 2007 International Conference on Computational Science and its Applications (ICCSA 2007) (pp. 539-546). IEEE. Available at:https://ieeexplore.ieee.org/abstract/document/4301193?casa_token=OarJoq_pyF0AAAAA:EQHNdhEVgcgXf0Ihx1JJsLXiG1Abc9jemIjIGvmAYQNCOyXuGzzHfeeUN-bbiRxfMxOrewKbUBU (Accessed on: 10th January 2023)  

[4] Sien, V.Y., 2011. An investigation of difficulties experienced by students developing unified modelling language (UML) class and sequence diagrams. Computer Science Education, 21(4), pp.317-342. Available at: https://sciresol.s3.us-east-2.amazonaws.com/IJST/Articles/2010/Issue-8/Article20.pdf (Accessed on: 5th January 2023)  


## **10. Gantt chart**
---
![Gantt chart](Gantt%20chart%202.jpg)
<center>Gantt chart for phase 2</center>  


## **11. Appendix**
---  
![](System%20Overall%20architecture%201.png)  
Figure 1: System overall architecture of student management system.
<br>

![Use case diagram](use%20case%20diagram.svg)  
Figure 2: Use case diagram of student management system.
<br>

![Sequence diagram](Sequence.jpg)
<center>Figure 3: Sequence diagram for student management system</center>  
<br> 

![Class diagram](Class%20diagram.png)
<center>Figure 4: Class diagram for student management system </center>  
<br>







