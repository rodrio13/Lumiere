# TrackEmployee Final Presentation
### 1. Planning and Requirements: 
#### Entrance Requirements
|   __ID__    |                             __Description__                             | __Test Method__ |
|-------------|-------------------------------------------------------------------------|-----------------|
| 1           | User successfully accesses website                                      | Inspection      |
| 1.1         | User can register                                                       | Demonstration   |
| 1.2         | User can successfully log in                                            | Demonstration   |
| 2           | User can create cards                                                   | Inspection      |
| 2.1         | User can update cards                                                   | Test            |
| 2.2         | User can delete cards                                                   | Test            |
| 2.3         | User can upload photos                                                  | Inspection      |

### 2. Defining Requirements:
- Requirements were defined to satisfy what I as the developer believed any potential customer would want in
an application for simply giving back to other and doing good.

### 3. Building Product:
- The product was initially being built using MVC with C#, HTML, and CSS.
### 4. Testing:
#### Requirements Traceability
| __ID__  |       __1__         |          __2__        |         __3__         |      __4__          |
|---------|---------------------|-----------------------|-----------------------|---------------------|
| 1       | :heavy_check_mark:  |                       |                       |                     |
| 1.1     | :heavy_check_mark:  |                       |                       |                     |
| 1.2     | :heavy_check_mark:  |                       |                       |                     |
| 2       |                     | :heavy_check_mark:    |                       |                     |
| 2.1     |                     | :x:                   |                       |                     |
| 2.2     |                     | :x:                   |                       |                     |
| 2.3     |                     | :x:                   |                       |                     |
|Test Casses traced to a test case: 58%                                                              |

#### Exit Criteria
| __ID__  |                           __Test Procedure__                       | __Req__ | __Status__  | __Date__    | 
|---------|--------------------------------------------------------------------|---------|-------------|-------------|
| 1       | Enter correct URL                                                  | 1       | Passed      | 2019-11-03  |
| 1.1     | User registers                                                     | 1       | Passed      | 2019-11-03  |
| 1.2     | User logs in                                                       | 1       | Passed      | 2019-11-03  |
| 2       | Create Employee card                                               | 1 - 1.2 | Passed      | 2019-11-03  |
| 2.1     | Update Employee card                                               | 1, 2    | Passed      | 2019-11-03  |
| 2.2     | Delete Employee card                                               | 1 - 2   | Fail        | 2019-11-03  |
| 2.3     | Upload photo                                                       | 1 - 2   | Fail        | 2019-11-03  |

|Test Casses passing: 71%  
###### Review Findings:
- Sometimes when the websites resizes to mobile the buttons are misplaced
### 5. Deployment:
https://lumiere.azurewebsites.net/

# Solutions
- Technologies used for the creation of this tracker include JavaScript, Bootstrap, and Azure.
- Future Developments will further or complete the project, bringing features such as Messaging and Google Maps Integration. 

# Architecture and Code 
https://github.com/rodrio13/EmployeeCards/tree/master/Me2You

# Demonstration
![image](https://user-images.githubusercontent.com/52425891/68411278-06fc8000-013f-11ea-8d4d-e7f7a16187b4.png)

# Lessons Learned
1. High expectations vs. Realistic Goals
