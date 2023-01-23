## 8.0 State Diagram

### 8.1 Chart Description and Structure

The state chart diagram is a representation of the different states and transitions that occur in a system. The diagram starts with the initial state of "login" where the system will ask for login credentials. If the credentials are incorrect, the system will transition to "incorrect_login" and display an error message before returning to the login state. If the credentials are correct, the system will move to the "OTP" state where it will ask for a one-time password. If the OTP is incorrect, the system will transition to the "incorrect_otp" state and display an error message before returning to the OTP state. If the OTP is correct, the system will transition to the "home" state.  
From there, the user can view courses, timetable, student profile, announcements, and attendance. The user can also logout of the system from the home state. The user also has options to view files and videos, submit assignments, view employment opportunities, and make payments from the home state. The diagram also includes states for module leader tab, course leader tab and fees state for further options for the user.   

## 11. Appendix
---  

![State diagram](state%20diagram.png)  
Figure 12: State diagram for student management system  

