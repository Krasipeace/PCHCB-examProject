![GitHub last commit](https://img.shields.io/github/last-commit/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub repo size](https://img.shields.io/github/repo-size/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub language count](https://img.shields.io/github/languages/count/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![GitHub top language](https://img.shields.io/github/languages/top/Krasipeace/PCHCB---ASP.NET-Advanced-Exam-Project) ![License](https://img.shields.io/badge/license-MIT-green) [![CodeFactor](https://www.codefactor.io/repository/github/krasipeace/pchcb/badge)](https://www.codefactor.io/repository/github/krasipeace/pchcb)

# PC's Hardware Compatibility Builder
Started as exam project and part of SoftUni [ASP.NET Advanced course at SoftUni](https://github.com/Krasipeace/SoftUni/tree/main/ASP.NET%20Advanced).
Now this is an app that I develop from time to time.

Table of Contents
=================

- [PC's Hardware Compatibility Builder](#pcs-hardware-compatibility-builder)
- [Table of Contents](#table-of-contents)
  - [Overview](#overview)
  - [Get Started](#get-started)
  - [Software/Technologies Used](#softwaretechnologies-used)
  - [Admin Area](#admin-area)
  - [Add Component](#add-component)
  - [View Component in Details](#view-component-in-details)
  - [View All Components by Type](#view-all-components-by-type)
  - [View All Components by Provider](#view-all-components-by-provider)
  - [Assemble PC Configuration](#assemble-pc-configuration)
  - [License](#license)

=================

## Overview

Personal Computer's Hardware Compatibility Builder is a web application that allows users to configure a custom PC configuration based on their specific needs and requirements. The app provides a user-friendly interface that guides users through the process of selecting the components they need for their PC, including the CPU, GPU, RAM, storage, case, motherboard, power supply, and cooling solutions. The app also provides users to register as providers of Pc components and add them to the app's database.

## Get Started 

Add your connection string in the `appsettings.json` file in the `PCHCB.Web` project or as secret. Example:

`{
  "ConnectionStrings": {
    "DefaultConnection": "Server=CHANGE-ME;Database=PCHCBDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}`

Apply Migrations to the `PCHCB.Data` project. Run the `PCHCB.Web` project.

Start the app in Development, you have seeded Administrator with the following credentials:
- Username/Email: `admin@pchcb.com`
- Password: `admin123`

As Administrator you will have full access in both client side and admin side(area) of the app.

You can register as new User, then you can register as Provider and change your Id in Providers Table in the database to `E92E7BEB-55D6-4D18-A99D-3ED3411058F5`. This Provider's Id has many seeded components in the database, which you can use for testing purposes.

You can also register as new User and/or Provider.

## Software/Technologies Used

- [VS 2022](https://visualstudio.microsoft.com/vs/)
- [MSSQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [ASP.NET Core 6.0](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
- [Entity Framework Core 6.0.16](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/6.0.16)
- [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML) / [CSS](https://developer.mozilla.org/en-US/docs/Web/CSS) / [Bootstrap 5.1](https://getbootstrap.com/docs/5.1/getting-started/introduction/)
- [JavaScript](https://www.javascript.com/) / [jQuery](https://jquery.com/)
- [toastr.js](https://github.com/CodeSeven/toastr)
- [Recaptcha v3](https://developers.google.com/recaptcha/docs/v3)

## Admin Area

The Admin Area is accessible only by the Administrator. It is a separate area of the app, which is not accessible by the regular users. The Admin Area provides the Administrator with full access to the app.

![AdminArea](https://i.imgur.com/gtAI2VW.png)

![AllUsers](https://i.imgur.com/PwIWqxZ.png)



## Add/Edit/Delete Component

Every Provider can add up to eight types of PC components:

- `CPU`
- `GPU`
- `RAM`
- `Storage`
- `Case`
- `Motherboard`
- `Power Supply`
- `Cooling Solution`

![Component](https://i.imgur.com/P1Lq4Ph.png)

## View Component in Details

Every Component has its own `Details` page, which provides the user with more information about the component. If you are provider of the component, you can edit or delete it. You can also see additional information about the `Provider`

![Details](https://i.imgur.com/bu6D2dJ.png)

## View All Components by Type

Every user can view all components by their type. Use the search bar to find desired component. 

![AllComponents](https://i.imgur.com/ZPal9UT.png)

## View All Components by Provider

Every provider can view his own Hardware.

![providerComponents](https://i.imgur.com/049FohC.png)

## Assemble PC Configuration

Every user can build his own PC Configuration with the provided hardware.

![assemble](https://i.imgur.com/nOPJE68.png)

## License 

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE)

---

[Back to Course Info](https://github.com/Krasipeace/SoftUni/tree/main/ASP.NET%20Advanced)

[Back to top](#)
