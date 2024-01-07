# Team 4 MushRoom Blog Project
- This repository contains the MushRoom Blog project provided by YetGen Jump & Akbank Backend Education Program.
- The details of the project, which we completed as Team 4, are provided below: ⇓

# Project Description
- Welcome to Mushroom Project – a dynamic blog platform designed for users to share their thoughts, experiences, and engage in meaningful discussions. 
Our platform not only allows users to create and publish blog posts but also fosters a vibrant community where users can interact through comments.

# Features
--Configuration and Relationship: Configurations were created for each entity, and relationships between these entities were defined. This ensures that various structures, such as one-to-one and one-to-many relationships, are managed in a consistent and orderly manner within the database.

--One Database, Multiple DbContexts: Two separate DbContext systems were created for the Identity and application (app) sections, allowing the management of these tables in the same database. This approach ensures the organized management of tables with different functionalities within the same database.

--Fluent Validation: Fluent Validation has been implemented to ensure the compliance of data created during processes such as login and registration with the defined constraints. By preventing user or system-related errors, it establishes a secure data entry system.

--User secret system: Sensitive data, such as database information, was securely stored using the User Secret System. This system ensures the protection of private information from unauthorized access.

--Identity Mechanism, JWT Token, Token Based Authentication: To create a user, initially, a controller was established, and security and identity management aspects, such as user authentication, JWT tokens, and token-based authentication, were implemented at an advanced level.

--CQRS Pattern: Blogpost, Tag, and Comment Entities, Utilizing the Command Query Responsibility Segregation (CQRS) pattern, the system implemented tailored approaches for handling commands and queries specific to Blogpost, Tag, and Comment entities. We performed add, edit and delete operations on commands for BlogPost, Comment and Tag, and getall and getbyid operations on queries.

--Queries and Commands: Customized queries and commands were developed to cater to the nuanced functionalities of Blogpost, Tag, and Comment entities. These specialized operations streamlined data management, offering precise interactions and optimized performance.

--Dependency Injection and MediatR Integration: The implementation embraced Dependency Injection, facilitating loose coupling and enhancing modularity across the Blogpost, Tag, and Comment modules.

--Mediatr: MediatR was adeptly integrated into the system, particularly within the Blogpost, Tag, and Comment modules. This integration centralized request handling, streamlining interactions and communications among these entities. MediatR enhanced the overall architecture by promoting a more organized and efficient flow of commands and queries within the system.

--Database Design and Repositories:The database design encompassed well-defined configurations for each entity, establishing clear relationships between them. Abstract and Concrete Read&Write repositories were meticulously implemented, providing dedicated and optimized data access layers for Blogpost, Tag, and Comment entities.

## Zehra Bengisu's part [![Zehra Bengisu](https://img.shields.io/badge/Bengisu-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Bengisoo)
- Database Design, CQRS Pattern, MediatR, Tag & BlogPost Controller, Read&Write repositories,  Tag's & BlogPost commands & queries, Dependency Injection


## Livanur's Part  [![Livanur](https://img.shields.io/badge/Livanur-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/livaae)
- CQRS Pattern, MediatR, Database Design, Comment & BlogPost Controller, Comments's & BlogPost's commands & queries, Abstract and Concrete Read&Write repositories, Dependency Injection


## Cengizhan's Part [![Cengizhan](https://img.shields.io/badge/Cengizhan-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/ccengizhann)
- Fluent Validation, Identity Mechanism, JWT Token, Token Based Authentication, User secret


## Elif's part [![Elif](https://img.shields.io/badge/Elif-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/elifbaykara)
-  Identity Mechanism, JWT Token, Token Based Authentication,


## Esmanur's Part [![Esmanur](https://img.shields.io/badge/Hatice-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/Esmanurrr)
- CQRS Update, GetById commands & queries, Creation of Entities, Interception Mechanism, Basic structure of the project


## Issues and Solutions
-Authentication Changes:
JWT-based authentication mechanism has been added to the project. However, attempts to modify customized identity classes (IdentityUserContext, IdentityDbContext) caused issues and were subsequently reverted.

-500 Server Error:
After making authentication changes, a 500 server error was encountered during the registration process. The following steps were taken to understand and resolve the issue:

-The details of the error were examined using error tracking tools or console output.
Checked if the DEBUG mode in the settings.py file was set to True.

