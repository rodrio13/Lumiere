# TrackEmployee Final Presentation
### 1. Planning and Requirements: 
#### Entrance Requirements
|   __ID__    |                             __Description__                             | __Test Method__ |
|-------------|-------------------------------------------------------------------------|-----------------|
| 1           | User successfully accesses website                                      | Inspection      |
| 1.1         | User creates their on card                                              | Demonstration   |
| 1.2         | User updates their information                                          | Demonstration   |
| 1.3         | User can delete their card                                              | Inspection      |
| 2           | Links inside main dropdown navigate the user correctly                  | Test            |
| 2.1         | User successfully signs out of account                                  | Test            |
| 2.2         | Pages scale for mobile use                                              | Inspection      |
| 3           | User can upload picture or input text for post                          | Demonstration   |
| 3.1         | User selects specific roles and departments they belong to              | Demonstration   |
| 4           | Post to personal feed                                                   | Inspection      |
| 4.1         | User Submits their information for all to see                           | Inspection      |
### 2. Defining Requirements:
- Requirements were defined to satisfy what I as the developer believed any potential customer would want in
an application for simply giving back to other and doing good.
### 3. Designing Product:
#### Wireframes
*Landing Page*

### 4. Building Product:
- The product was initially being built using MVC with C#, HTML, and CSS. Later I decided to transition from MVC to Blazor upon its release.  
### 5. Testing:
#### Requirements Traceability
| __ID__  |       __1__         |          __2__        |         __3__         |      __4__          |
|---------|---------------------|-----------------------|-----------------------|---------------------|
| 1       | :heavy_check_mark:  |                       |                       |                     |
| 1.1     | :heavy_check_mark:  |                       |                       |                     |
| 1.2     | :heavy_check_mark:  |                       |                       |                     |
| 2       |                     | :heavy_check_mark:    |                       |                     |
| 2.1     |                     | :heavy_check_mark:    |                       |                     |
| 2.2     |                     | :heavy_check_mark:    |                       |                     |
| 2.3     |                     | :heavy_check_mark:    |                       |                     |
| 3       |                     |                       | :heavy_check_mark:    |                     |
| 3.1     |                     |                       | :heavy_check_mark:    |                     |
| 4       |                     |                       | :heavy_check_mark:    | :x:                 |
| 4.1     |                     |                       | :heavy_check_mark:    | :x:                 |
|Test Casses traced to a test case: 100%                                                              |

#### Exit Criteria
| __ID__  |                           __Test Procedure__                       | __Req__ | __Status__  | __Date__    | 
|---------|--------------------------------------------------------------------|---------|-------------|-------------|
| 1       | Enter correct URL                                                  | 1       | Failed      | 2019-11-03  |
| 1.1     | User navigates to Sign Up tab after ID 1                           | 1       | Passed      | 2019-11-03  |
| 1.2     | User Clicks Profile tab after sign up                              | 1,1.1   | Passed      | 2019-11-03  |
| 2       | Navigate to profile and view email listed below picture            | 1 - 1.2 | Passed      | 2019-11-03  |
| 2.1     | Click dropdown next to meu on profile                              | 1, 2    | Passed      | 2019-11-03  |
| 2.2     | Menu dropdown --> Setting --> Sign Out                             | 1 - 2   | Passed      | 2019-11-03  |
| 2.3     | Mobile phone, enter url listed in ID 1                             | 1 - 2   | Passed      | 2019-11-03  |
| 3       | Post --> Choose Files                                              | 1 - 3   | Passed      | 2019-11-03  |
| 3.1     | Volunteer with Button --> Choose: Hours, Date, Location            | 1 - 3.1 | Passed      | 2019-11-03  |
| 4       | Post --> Choose Files --> Post                                     | 3, 4    | Failed      | 2019-11-03  |
| 4.1     | Volunteer with Button --> Choose: Hours, Date, Location --> Submit | 3, 4    | Failed      | 2019-11-03  |
|Test Casses passing: 78%  
###### Review Findings:
- Layout of some buttons/ text move instead of re-size in mobile view.
- Page renders back to the top after hitting settings the first time, but not after.
### 6. Deployment:
- Application is not currently deployed in Azure.

# Solutions
- Technologies used for the creation of this tracker include JavaScript, Bootstrap, and Azure.
- Future Developments will further or complete the project, bringing features such as Messaging and Google Maps Integration. 

# Architecture and Code 

  
# Demonstration


# Lessons Learned
1. Being able to correctly implement some functions. 
2. I got drawn into a whole and just kept digging. 
3. High expectations vs. Realistic Goals
