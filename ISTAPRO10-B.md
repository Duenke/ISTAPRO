# ISTAPRO10-B
**Jacob Duenke**  
*April 01, 2019*

# **Software Requirements Specification**
## Help Ticket Project
<div style="page-break-after: always;"></div>

## **Table of Contents**
1. Intro  
    1.1 Purpose  
    1.2 Intended Audience  
    1.3 Intended Use  
    1.4 Scope  
    1.5 Definitions and Acronyms  
1. Overall Description   
1. System Features and Requirements  
    3.1 Functional Requirements  
        3.1.1 The User
        3.1.2 The Technician
        3.1.3 The System
    3.2 Usability  
        3.2.1 Graphical User Interface  
        3.2.2 Accessibility  
<div style="page-break-after: always;"></div>

## **1. Intro**
This section defines the purpose, audience, use, and scope of the Help Ticket Project, as well as a list of definitions and acronyms used in this document.

## **1.1 Purpose**
The purpose of this document is to give a detailed description of the requirements for the "*Help Ticket System*". These requirements will serve as a proposal to the customer as well as a reference for the development team.

## **1.2 Intended Audience**
The intended audience for this document is the customer requesting the software as well as the development team.

## **1.3 Intended Use**
The customer will review and accept or reject this document as a complete specification of requirements for the software.  
The development team will then use this document as a reference for the first iteration of development. The first iteration will be complete when all the requirements in this document have been met.

## **1.4 Scope**
The "*Help Ticket System*" is a web-based, self serve help ticket system for users of the WhateverBand product. The system is free and accessible to the user.  
The user can navigate to the website, enter some details, and submit a help ticket with ease. The user will leave an email address in the details for response and updates from the technician working on the ticket.  
The technicians responsible for resolving user issues will see new tickets waiting for resolution, pull the ticket from the repository, and send updates to the user about issues encountered or final resolution.  
The system will archive resolved and unresolved, but closed tickets in a final repository for future retrieval if necessary.

## **1.5 Definitions and Acronyms**
User - Someone who has purchased WhateverBrand product and requests help resolving an issue.  
Technician - System administrator who is charged with analyzing and resolving user issues.  
Website - The web application "*Help Ticket System*".  
System - The application, it's logic, database, and automatic processes.  
DESC - Description.  
RAT - Rational.  
DEP - Dependency.  

## **2. Overall Description**
This document will give an overview of the whole system and it's interactions with other systems and introduce the basic functionality of it.

## **3. System Features and Requirements**
This section contains the specific requirements of the "*Help Ticket System*" from the perspective of the User as well as the Technician and the System.

## **3.1 Functional Requirements**
**3.1.1 User Class 1 - The User**  
*3.1.1.1 Functional requirement 1.1*  
ID: FR1  
TITLE: Access the web application  
DESC: A user will be able to navigate to the web application without any special accounts or passwords, provided s/he has an internet connection and an internet enabled device.  
RAT: In order for a user to find the "*Help Ticket System*".  
DEP: None

*3.1.1.2 Functional requirement 1.2*  
ID: FR2  
TITLE: Submit a help ticket  
DESC: A user will be able to submit a help ticket from the web application by typing in a description of the issue, the platform on which the issue has occurred, and an email address for return notifications.  
RAT: In order for a user to submit a help ticket.  
DEP: FR1  

**3.1.2 User Class 2 - The Technician**  
*3.1.2.1 Functional requirement 2.1*  
ID: FR3  
TITLE: Retrieve new help ticket  
DESC: A technician will be able to retrieve a new, unopened help ticket from the system and view it's contents.  
RAT: In order for a technician to view new help tickets.  
DEP: FR1, FR2  

*3.1.2.2 Functional requirement 2.2*  
ID: FR4  
TITLE: View open help ticket  
DESC: A technician will be able to view a previously opened, unfinished help ticket from the system and view it's contents.  
RAT: In order for a technician to view opened help tickets.  
DEP: FR1, FR2, FR3  

*3.1.2.3 Functional requirement 2.3*  
ID: FR5  
TITLE: Close open help ticket  
DESC: A technician will be able to close an open help ticket after issue resolution.  
RAT: In order for a technician to close opened help tickets.  
DEP: FR1, FR2  

**3.1.3 User Class 3 - The System**  
*3.1.3.1 Functional requirement 3.1*  
ID: FR6  
TITLE: Store new help ticket  
DESC: The system will be able to store newly submitted help tickets in a relational database.  
RAT: In order for the system to store new help tickets.  
DEP: FR1, FR2  

*3.1.3.2 Functional requirement 3.2*  
ID: FR7  
TITLE: Move ticket from one table to another in database  
DESC: The system will be able to remove tickets from one table in the database and place them in another.  
RAT: In order for the system to store new, open, and closed tickets in the appropriate table.  
DEP: FR1, FR2, FR6  

*3.1.3.3 Functional requirement 3.3*  
ID: FR8  
TITLE: Recall tickets from the database.    
DESC: The system will be able to recall the information of a help ticket from the database and display it's contents to a technician.  
RAT: In order for the system to display ticket contents to a technician.  
DEP: FR1, FR2, FR6

*3.1.3.4 Functional requirement 3.4*  
ID: FR9  
TITLE: Email notifications to the user.  
DESC: The system will be able to automatically email a notification to the user email listed in the help ticket description when a technician has closed the ticket. The notification will include all the information from the original ticket, as well as the notes added by the technician.  
RAT: In order for the system to notify the user of ticket resolution.  
DEP: FR1, FR2, FR3, FR5  

## **3.2 Usability**
**3.2.1 Graphical User Interface**  
The "*Help Ticket System*" will provide a uniform, uncluttered graphical interface from all views.

**3.2.2 Accessibility**  
The "*Help Ticket System*" will provide English language support only.