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

References

[2] Rosenberg, D. and Scott, K., 1999. Use case driven object modeling with UML (pp. 1-4). Reading: Addison-Wesley Professional. Available at: https://link.springer.com/book/10.1007/978-1-4302-0369-8 (Accessed on: 12th January 2023)



## **11. Appendix**

![](System%20Overall%20architecture%201.png)  
Figure 1: System overall architecture of student management system.
<br>

![Use case diagram](use%20case%20diagram.svg)  
Figure 2: Use case diagram of student management system.
<br>
